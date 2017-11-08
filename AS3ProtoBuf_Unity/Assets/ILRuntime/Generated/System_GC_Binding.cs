using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_GC_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(System.GC);
            args = new Type[]{};
            method = type.GetMethod("get_MaxGeneration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxGeneration_0);
            args = new Type[]{};
            method = type.GetMethod("Collect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Collect_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Collect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Collect_2);
            args = new Type[]{typeof(System.Int32), typeof(System.GCCollectionMode)};
            method = type.GetMethod("Collect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Collect_3);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("GetGeneration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGeneration_4);
            args = new Type[]{typeof(System.WeakReference)};
            method = type.GetMethod("GetGeneration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGeneration_5);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("GetTotalMemory", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTotalMemory_6);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("KeepAlive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, KeepAlive_7);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("ReRegisterForFinalize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReRegisterForFinalize_8);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("SuppressFinalize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SuppressFinalize_9);
            args = new Type[]{};
            method = type.GetMethod("WaitForPendingFinalizers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitForPendingFinalizers_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("CollectionCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CollectionCount_11);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("AddMemoryPressure", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddMemoryPressure_12);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("RemoveMemoryPressure", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveMemoryPressure_13);





        }


        static StackObject* get_MaxGeneration_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.GC.MaxGeneration;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Collect_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            System.GC.Collect();

            return __ret;
        }

        static StackObject* Collect_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 generation = ptr_of_this_method->Value;

            System.GC.Collect(generation);

            return __ret;
        }

        static StackObject* Collect_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.GCCollectionMode mode = (System.GCCollectionMode)typeof(System.GCCollectionMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 generation = ptr_of_this_method->Value;

            System.GC.Collect(generation, mode);

            return __ret;
        }

        static StackObject* GetGeneration_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = System.GC.GetGeneration(obj);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGeneration_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.WeakReference wo = (System.WeakReference)typeof(System.WeakReference).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = System.GC.GetGeneration(wo);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetTotalMemory_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean forceFullCollection = ptr_of_this_method->Value == 1;

            var result_of_this_method = System.GC.GetTotalMemory(forceFullCollection);

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* KeepAlive_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.GC.KeepAlive(obj);

            return __ret;
        }

        static StackObject* ReRegisterForFinalize_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.GC.ReRegisterForFinalize(obj);

            return __ret;
        }

        static StackObject* SuppressFinalize_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            System.GC.SuppressFinalize(obj);

            return __ret;
        }

        static StackObject* WaitForPendingFinalizers_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            System.GC.WaitForPendingFinalizers();

            return __ret;
        }

        static StackObject* CollectionCount_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 generation = ptr_of_this_method->Value;

            var result_of_this_method = System.GC.CollectionCount(generation);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* AddMemoryPressure_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 bytesAllocated = *(long*)&ptr_of_this_method->Value;

            System.GC.AddMemoryPressure(bytesAllocated);

            return __ret;
        }

        static StackObject* RemoveMemoryPressure_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 bytesAllocated = *(long*)&ptr_of_this_method->Value;

            System.GC.RemoveMemoryPressure(bytesAllocated);

            return __ret;
        }





    }
}
