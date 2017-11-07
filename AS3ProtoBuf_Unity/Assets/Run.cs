using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Run : MonoBehaviour
{

	//AppDomain是ILRuntime的入口，最好是在一个单例类中保存，整个游戏全局就一个，这里为了示例方便，每个例子里面都单独做了一个
	//大家在正式项目中请全局只创建一个AppDomain
	protected static ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	

	// Use this for initialization
	IEnumerator Start()
	{
		return LoadHotFixAssembly();
	}

	IEnumerator LoadHotFixAssembly()
	{
		
		//首先实例化ILRuntime的AppDomain，AppDomain是一个应用程序域，每个AppDomain都是一个独立的沙盒
		appdomain = new ILRuntime.Runtime.Enviorment.AppDomain();
		//正常项目中应该是自行从其他地方下载dll，或者打包在AssetBundle中读取，平时开发以及为了演示方便直接从StreammingAssets中读取，
		//正式发布的时候需要大家自行从其他地方读取dll

		//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		//这个DLL文件是直接编译HotFix_Project.sln生成的，已经在项目中设置好输出目录为StreamingAssets，在VS里直接编译即可生成到对应目录，无需手动拷贝
#if UNITY_ANDROID
        WWW www = new WWW(Application.streamingAssetsPath + "/HotFix_Lib.dll");
#else
		WWW www = new WWW("file:///" + Application.streamingAssetsPath + "/HotFixProto.dll");
#endif
		while (!www.isDone)
			yield return null;
		if (!string.IsNullOrEmpty(www.error))
			UnityEngine.Debug.LogError(www.error);
		byte[] dll = www.bytes;
		www.Dispose();

		//PDB文件是调试数据库，如需要在日志中显示报错的行号，则必须提供PDB文件，不过由于会额外耗用内存，正式发布时请将PDB去掉，下面LoadAssembly的时候pdb传null即可
#if UNITY_ANDROID
        www = new WWW(Application.streamingAssetsPath + "/HotFix_Lib.pdb");
#else
		www = new WWW("file:///" + Application.streamingAssetsPath + "/HotFixProto.pdb");
#endif
		while (!www.isDone)
			yield return null;
		if (!string.IsNullOrEmpty(www.error))
			UnityEngine.Debug.LogError(www.error);
		byte[] pdb = www.bytes;
		using (System.IO.MemoryStream fs = new MemoryStream(dll))
		{
			using (System.IO.MemoryStream p = new MemoryStream(pdb))
			{
				appdomain.LoadAssembly(fs, p, new Mono.Cecil.Pdb.PdbReaderProvider());
			}
		}



		//***创建flashplayer***
		//***我修改了Appdomain的代码，让Appdomain保存一个as3运行时的引用。这样可以避免静态变量。

		var flashplayer = new ASRuntime.Player();
		//加载as3编译器生成的protobuf代码。
#if UNITY_ANDROID
        www = new WWW(Application.streamingAssetsPath + "/HotFix_Lib.dll");
#else
		www = new WWW("file:///" + Application.streamingAssetsPath + "/proto.cswc");
#endif
		while (!www.isDone)
			yield return null;
		if (!string.IsNullOrEmpty(www.error))
			UnityEngine.Debug.LogError(www.error);

		ASBinCode.CSWC swc= ASBinCode.CSWC.loadFromBytes(www.bytes);
		flashplayer.loadCode(swc);
		appdomain.Tag = flashplayer;

		www.Dispose();



		InitializeILRuntime();
		OnHotFixLoaded();
	}

	unsafe void InitializeILRuntime()
	{
		//重定向log
		var mi = typeof(Debug).GetMethod("Log", new System.Type[] { typeof(object) });
		appdomain.RegisterCLRMethodRedirection(mi, DebugLogRedirection.Log_11);
		appdomain.RegisterCrossBindingAdaptor(new AS3Proto.MessageAdapter());

	}

	bool InitedILRuntime = false;
	IMethod s_HFInitialize;
	IMethod s_HFUpdate;

	public virtual void OnHotFixLoaded()
	{
		Debug.Log("[ILRTTest] Loaded");

		var hfMain = appdomain.GetType("HotFixProto.Main");
		s_HFInitialize = hfMain.GetMethod("Initialize", 0);
		s_HFUpdate = hfMain.GetMethod("Update", 0);
		appdomain.Invoke(s_HFInitialize, hfMain, null);

		InitedILRuntime = true;
	}

	// Update is called once per frame
	void Update()
	{
		if (InitedILRuntime)
		{
			appdomain.Invoke(s_HFUpdate, null, null);
		}

	}
}
