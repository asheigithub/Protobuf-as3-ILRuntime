using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.AS3Proto
{
	public class UnityOutput : ASRuntime.IRuntimeOutput
	{
		public void Error(string str)
		{
			UnityEngine.Debug.LogError(str);
		}

		public void Info(string str)
		{
			UnityEngine.Debug.Log(str);
		}

		public void Warring(string str)
		{
			UnityEngine.Debug.LogWarning(str);
		}
	}
}
