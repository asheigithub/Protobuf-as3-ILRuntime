#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System;
using System.Text;
using System.Collections.Generic;
[System.Reflection.Obfuscation(Exclude = true)]
public class ILRuntimeCLRBinding
{

	[MenuItem("ILRuntime/Generate CLR Binding Code")]
	static void GenerateCLRBinding()
	{
		List<Type> types = new List<Type>();
		types.Add(typeof(int));
		types.Add(typeof(float));
		types.Add(typeof(long));
		types.Add(typeof(object));
		types.Add(typeof(string));
		types.Add(typeof(Array));
		types.Add(typeof(Vector2));
		types.Add(typeof(Vector3));
		types.Add(typeof(Quaternion));
		types.Add(typeof(GameObject));
		types.Add(typeof(UnityEngine.Object));
		types.Add(typeof(Transform));
		types.Add(typeof(RectTransform));
		types.Add(typeof(Time));
		types.Add(typeof(Debug));
		//所有DLL内的类型的真实C#类型都是ILTypeInstance
		types.Add(typeof(List<ILRuntime.Runtime.Intepreter.ILTypeInstance>));

		types.Add(typeof(List<object>));
		types.Add(typeof(List<int>));
		types.Add(typeof(List<uint>));
		types.Add(typeof(List<bool>));
		types.Add(typeof(List<double>));
		types.Add(typeof(List<ASBinCode.RunTimeValueBase>));




		types.Add(typeof(HashSet<object>));
		types.Add(typeof(HashSet<string>));
		types.Add(typeof(HashSet<int>));
		types.Add(typeof(HashSet<uint>));
		types.Add(typeof(HashSet<long>));
		types.Add(typeof(HashSet<ulong>));
		types.Add(typeof(HashSet<ILRuntime.Runtime.Intepreter.ILTypeInstance>));



		types.Add(typeof(Dictionary<string, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
		types.Add(typeof(Dictionary<int, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
		types.Add(typeof(Dictionary<uint, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
		types.Add(typeof(Dictionary<long, ILRuntime.Runtime.Intepreter.ILTypeInstance>));
		types.Add(typeof(Dictionary<ulong, ILRuntime.Runtime.Intepreter.ILTypeInstance>));

		types.Add(typeof(Dictionary<long, int>));
		types.Add(typeof(Dictionary<int, long>));
		types.Add(typeof(Dictionary<long, long>));
		types.Add(typeof(Dictionary<int, int>));
		types.Add(typeof(Dictionary<object, object>));
		types.Add(typeof(Dictionary<string, int>));
		types.Add(typeof(Dictionary<string, long>));
		types.Add(typeof(Dictionary<string, uint>));
		types.Add(typeof(Dictionary<string, ulong>));
		types.Add(typeof(Dictionary<long, uint>));
		types.Add(typeof(Dictionary<ulong, int>));
		types.Add(typeof(Dictionary<ulong, uint>));
		types.Add(typeof(Dictionary<uint, int>));
		types.Add(typeof(Dictionary<uint, long>));
		types.Add(typeof(Dictionary<uint, uint>));
		types.Add(typeof(Dictionary<uint, ulong>));
		types.Add(typeof(Dictionary<ulong, ulong>));

		

		types.Add(typeof(System.IO.MemoryStream));
		types.Add(typeof(System.IO.BinaryReader));
		types.Add(typeof(System.IO.BinaryWriter));
		types.Add(typeof(System.Text.UTF8Encoding));

		types.Add(typeof(ASRuntime.Player));
		
		types.Add(typeof(GC));

		types.Add(typeof(UnityEngine.Debug));
		

		types.Add(typeof(AnimationCurve));
		types.Add(typeof(Keyframe));
		types.Add(typeof(WrapMode));

		ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(types, "Assets/ILRuntime/Generated");
	}
}
#endif
