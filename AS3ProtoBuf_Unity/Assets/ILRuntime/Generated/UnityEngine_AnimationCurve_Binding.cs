﻿using System;
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
    unsafe class UnityEngine_AnimationCurve_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.AnimationCurve);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("Evaluate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Evaluate_0);
            args = new Type[]{};
            method = type.GetMethod("get_keys", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_keys_1);
            args = new Type[]{typeof(UnityEngine.Keyframe[])};
            method = type.GetMethod("set_keys", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_keys_2);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("AddKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddKey_3);
            args = new Type[]{typeof(UnityEngine.Keyframe)};
            method = type.GetMethod("AddKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddKey_4);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Keyframe)};
            method = type.GetMethod("MoveKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveKey_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveKey_6);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_7);
            args = new Type[]{};
            method = type.GetMethod("get_length", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_length_8);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SmoothTangents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SmoothTangents_9);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("Linear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Linear_10);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("EaseInOut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EaseInOut_11);
            args = new Type[]{};
            method = type.GetMethod("get_preWrapMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_preWrapMode_12);
            args = new Type[]{typeof(UnityEngine.WrapMode)};
            method = type.GetMethod("set_preWrapMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_preWrapMode_13);
            args = new Type[]{};
            method = type.GetMethod("get_postWrapMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_postWrapMode_14);
            args = new Type[]{typeof(UnityEngine.WrapMode)};
            method = type.GetMethod("set_postWrapMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_postWrapMode_15);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.AnimationCurve());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.AnimationCurve[s]);

            args = new Type[]{typeof(UnityEngine.Keyframe[])};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* Evaluate_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single time = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Evaluate(time);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_keys_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.keys;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_keys_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Keyframe[] value = (UnityEngine.Keyframe[])typeof(UnityEngine.Keyframe[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.keys = value;

            return __ret;
        }

        static StackObject* AddKey_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single value = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single time = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddKey(time, value);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* AddKey_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Keyframe key = (UnityEngine.Keyframe)typeof(UnityEngine.Keyframe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddKey(key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* MoveKey_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Keyframe key = (UnityEngine.Keyframe)typeof(UnityEngine.Keyframe).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MoveKey(index, key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RemoveKey_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveKey(index);

            return __ret;
        }

        static StackObject* get_Item_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method[index];

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_length_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.length;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SmoothTangents_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single weight = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SmoothTangents(index, weight);

            return __ret;
        }

        static StackObject* Linear_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single valueEnd = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single timeEnd = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single valueStart = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single timeStart = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AnimationCurve.Linear(timeStart, valueStart, timeEnd, valueEnd);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* EaseInOut_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single valueEnd = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single timeEnd = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single valueStart = *(float*)&ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single timeStart = *(float*)&ptr_of_this_method->Value;

            var result_of_this_method = UnityEngine.AnimationCurve.EaseInOut(timeStart, valueStart, timeEnd, valueEnd);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_preWrapMode_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.preWrapMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_preWrapMode_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.WrapMode value = (UnityEngine.WrapMode)typeof(UnityEngine.WrapMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.preWrapMode = value;

            return __ret;
        }

        static StackObject* get_postWrapMode_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.postWrapMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_postWrapMode_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.WrapMode value = (UnityEngine.WrapMode)typeof(UnityEngine.WrapMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.AnimationCurve instance_of_this_method;
            instance_of_this_method = (UnityEngine.AnimationCurve)typeof(UnityEngine.AnimationCurve).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.postWrapMode = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Keyframe[] keys = (UnityEngine.Keyframe[])typeof(UnityEngine.Keyframe[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new UnityEngine.AnimationCurve(keys);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.AnimationCurve();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
