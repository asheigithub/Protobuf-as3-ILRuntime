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
    unsafe class System_Collections_Generic_HashSet_1_UInt32_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(System.Collections.Generic.HashSet<System.UInt32>);
            args = new Type[]{};
            method = type.GetMethod("get_Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Count_0);
            args = new Type[]{typeof(System.UInt32[])};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_1);
            args = new Type[]{typeof(System.UInt32[]), typeof(System.Int32)};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_2);
            args = new Type[]{typeof(System.UInt32[]), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_3);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_4);
            args = new Type[]{};
            method = type.GetMethod("get_Comparer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Comparer_5);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_6);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("Contains", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Contains_7);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_8);
            args = new Type[]{typeof(System.Predicate<System.UInt32>)};
            method = type.GetMethod("RemoveWhere", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveWhere_9);
            args = new Type[]{};
            method = type.GetMethod("TrimExcess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrimExcess_10);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("IntersectWith", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IntersectWith_11);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("ExceptWith", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExceptWith_12);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("Overlaps", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Overlaps_13);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("SetEquals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetEquals_14);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("SymmetricExceptWith", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SymmetricExceptWith_15);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("UnionWith", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnionWith_16);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("IsSubsetOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsSubsetOf_17);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("IsProperSubsetOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsProperSubsetOf_18);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("IsSupersetOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsSupersetOf_19);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetMethod("IsProperSupersetOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsProperSupersetOf_20);
            args = new Type[]{};
            method = type.GetMethod("CreateSetComparer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateSetComparer_21);
            args = new Type[]{typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext)};
            method = type.GetMethod("GetObjectData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetObjectData_22);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("OnDeserialization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDeserialization_23);
            args = new Type[]{};
            method = type.GetMethod("GetEnumerator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnumerator_24);



            app.RegisterCLRCreateDefaultInstance(type, () => new System.Collections.Generic.HashSet<System.UInt32>());
            app.RegisterCLRCreateArrayInstance(type, s => new System.Collections.Generic.HashSet<System.UInt32>[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Collections.Generic.IEqualityComparer<System.UInt32>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.UInt32>), typeof(System.Collections.Generic.IEqualityComparer<System.UInt32>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_3);

        }


        static StackObject* get_Count_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CopyTo_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32[] array = (System.UInt32[])typeof(System.UInt32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(array);

            return __ret;
        }

        static StackObject* CopyTo_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt32[] array = (System.UInt32[])typeof(System.UInt32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(array, index);

            return __ret;
        }

        static StackObject* CopyTo_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt32[] array = (System.UInt32[])typeof(System.UInt32[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(array, index, count);

            return __ret;
        }

        static StackObject* Add_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 item = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Add(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_Comparer_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Comparer;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Clear_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* Contains_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 item = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Contains(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Remove_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 item = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Remove(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RemoveWhere_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.UInt32> predicate = (System.Predicate<System.UInt32>)typeof(System.Predicate<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RemoveWhere(predicate);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* TrimExcess_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TrimExcess();

            return __ret;
        }

        static StackObject* IntersectWith_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.IntersectWith(other);

            return __ret;
        }

        static StackObject* ExceptWith_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ExceptWith(other);

            return __ret;
        }

        static StackObject* Overlaps_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Overlaps(other);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetEquals_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SetEquals(other);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SymmetricExceptWith_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SymmetricExceptWith(other);

            return __ret;
        }

        static StackObject* UnionWith_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnionWith(other);

            return __ret;
        }

        static StackObject* IsSubsetOf_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSubsetOf(other);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsProperSubsetOf_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsProperSubsetOf(other);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsSupersetOf_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSupersetOf(other);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsProperSupersetOf_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> other = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsProperSupersetOf(other);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CreateSetComparer_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = System.Collections.Generic.HashSet<System.UInt32>.CreateSetComparer();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetObjectData_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Runtime.Serialization.StreamingContext context = (System.Runtime.Serialization.StreamingContext)typeof(System.Runtime.Serialization.StreamingContext).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Runtime.Serialization.SerializationInfo info = (System.Runtime.Serialization.SerializationInfo)typeof(System.Runtime.Serialization.SerializationInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetObjectData(info, context);

            return __ret;
        }

        static StackObject* OnDeserialization_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object sender = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDeserialization(sender);

            return __ret;
        }

        static StackObject* GetEnumerator_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.HashSet<System.UInt32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.HashSet<System.UInt32>)typeof(System.Collections.Generic.HashSet<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetEnumerator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new System.Collections.Generic.HashSet<System.UInt32>();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEqualityComparer<System.UInt32> comparer = (System.Collections.Generic.IEqualityComparer<System.UInt32>)typeof(System.Collections.Generic.IEqualityComparer<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new System.Collections.Generic.HashSet<System.UInt32>(comparer);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.UInt32> collection = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new System.Collections.Generic.HashSet<System.UInt32>(collection);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEqualityComparer<System.UInt32> comparer = (System.Collections.Generic.IEqualityComparer<System.UInt32>)typeof(System.Collections.Generic.IEqualityComparer<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.IEnumerable<System.UInt32> collection = (System.Collections.Generic.IEnumerable<System.UInt32>)typeof(System.Collections.Generic.IEnumerable<System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new System.Collections.Generic.HashSet<System.UInt32>(collection, comparer);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
