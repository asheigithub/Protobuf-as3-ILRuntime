using ILRuntime.Runtime.Enviorment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.CLR.Method;

namespace AS3Proto
{
	class MessageAdapter : CrossBindingAdaptor
	{
		public override Type BaseCLRType
		{
			get
			{
				return typeof(Message);//这是你想继承的那个类
			}
		}

		public override Type AdaptorType
		{
			get
			{
				return typeof(Adaptor);
			}
		}

		public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			return new Adaptor(appdomain, instance);//创建一个新的实例
		}


		//实际的适配器类需要继承你想继承的那个类，并且实现CrossBindingAdaptorType接口
		class Adaptor : Message, CrossBindingAdaptorType
		{
			ILTypeInstance instance;
			ILRuntime.Runtime.Enviorment.AppDomain appdomain;

			


			//缓存这个数组来避免调用时的GC Alloc
			object[] param1 = new object[1];

			public Adaptor()
			{

			}

			public Adaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance):base()
			{
				this.appdomain = appdomain;
				this.instance = instance;

				//此时即可将运行时赋值给Message.就可以调用AS3脚本了。
				player = (ASRuntime.Player)appdomain.Tag;
			}

			public ILTypeInstance ILInstance { get { return instance; } }

			IMethod mafterMergeFrom;
			bool mafterMergeFromGot;
			bool isafterMergeFromInvoking;
			protected override void afterMergeFrom()
			{
				if (!mafterMergeFromGot)
				{
					//mAddChild = instance.Type.GetMethod("AddChild", 1);
					ILRuntime.CLR.TypeSystem.IType type = instance.Type;
					while (mafterMergeFrom == null && type is ILRuntime.CLR.TypeSystem.ILType)
					{
						mafterMergeFrom = type.GetMethod("afterMergeFrom", 0);
						type = type.BaseType;
					}
					mafterMergeFromGot = true;
				}

				//对于虚函数而言，必须设定一个标识位来确定是否当前已经在调用中，否则如果脚本类中调用base.TestVirtual()就会造成无限循环，最终导致爆栈
				if (mafterMergeFrom != null && !isafterMergeFromInvoking)
				{
					isafterMergeFromInvoking = true;
					
					var result = appdomain.Invoke(mafterMergeFrom, instance,null);
					isafterMergeFromInvoking = false;
				}
				else
					base.afterMergeFrom();
			}

			IMethod mbeforeWriteTo;
			bool mbeforeWriteToGot;
			bool isbeforeWriteToInvoking;
			protected override void beforeWriteTo()
			{
				if (!mbeforeWriteToGot)
				{
					//mAddChild = instance.Type.GetMethod("AddChild", 1);
					ILRuntime.CLR.TypeSystem.IType type = instance.Type;
					while (mbeforeWriteTo == null && type is ILRuntime.CLR.TypeSystem.ILType)
					{
						mbeforeWriteTo = type.GetMethod("beforeWriteTo", 0);
						type = type.BaseType;
					}
					mbeforeWriteToGot = true;
				}

				//对于虚函数而言，必须设定一个标识位来确定是否当前已经在调用中，否则如果脚本类中调用base.TestVirtual()就会造成无限循环，最终导致爆栈
				if (mbeforeWriteTo != null && !isbeforeWriteToInvoking)
				{
					isbeforeWriteToInvoking = true;

					var result = appdomain.Invoke(mbeforeWriteTo, instance, null);
					isbeforeWriteToInvoking = false;
				}
				else
					base.beforeWriteTo();
			}


		}


	}
}
