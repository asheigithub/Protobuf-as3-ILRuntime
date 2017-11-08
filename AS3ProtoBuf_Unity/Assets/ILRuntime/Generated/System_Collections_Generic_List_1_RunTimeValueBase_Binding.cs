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
    unsafe class System_Collections_Generic_List_1_RunTimeValueBase_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_0);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("AddRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRange_1);
            args = new Type[]{};
            method = type.GetMethod("AsReadOnly", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AsReadOnly_2);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase)};
            method = type.GetMethod("BinarySearch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BinarySearch_3);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase), typeof(System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("BinarySearch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BinarySearch_4);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(ASBinCode.RunTimeValueBase), typeof(System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("BinarySearch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BinarySearch_5);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_6);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase)};
            method = type.GetMethod("Contains", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Contains_7);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase[])};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_8);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase[]), typeof(System.Int32)};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_9);
            args = new Type[]{typeof(System.Int32), typeof(ASBinCode.RunTimeValueBase[]), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_10);
            args = new Type[]{typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("Exists", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Exists_11);
            args = new Type[]{typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("Find", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Find_12);
            args = new Type[]{typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("FindAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindAll_13);
            args = new Type[]{typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("FindIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindIndex_14);
            args = new Type[]{typeof(System.Int32), typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("FindIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindIndex_15);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("FindIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindIndex_16);
            args = new Type[]{typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("FindLast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindLast_17);
            args = new Type[]{typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("FindLastIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindLastIndex_18);
            args = new Type[]{typeof(System.Int32), typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("FindLastIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindLastIndex_19);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("FindLastIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindLastIndex_20);
            args = new Type[]{typeof(System.Action<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("ForEach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ForEach_21);
            args = new Type[]{};
            method = type.GetMethod("GetEnumerator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnumerator_22);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRange_23);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase)};
            method = type.GetMethod("IndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IndexOf_24);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase), typeof(System.Int32)};
            method = type.GetMethod("IndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IndexOf_25);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("IndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IndexOf_26);
            args = new Type[]{typeof(System.Int32), typeof(ASBinCode.RunTimeValueBase)};
            method = type.GetMethod("Insert", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Insert_27);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("InsertRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InsertRange_28);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase)};
            method = type.GetMethod("LastIndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LastIndexOf_29);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase), typeof(System.Int32)};
            method = type.GetMethod("LastIndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LastIndexOf_30);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("LastIndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LastIndexOf_31);
            args = new Type[]{typeof(ASBinCode.RunTimeValueBase)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_32);
            args = new Type[]{typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("RemoveAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAll_33);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAt_34);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("RemoveRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveRange_35);
            args = new Type[]{};
            method = type.GetMethod("Reverse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reverse_36);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Reverse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reverse_37);
            args = new Type[]{};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_38);
            args = new Type[]{typeof(System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_39);
            args = new Type[]{typeof(System.Comparison<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_40);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_41);
            args = new Type[]{};
            method = type.GetMethod("ToArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToArray_42);
            args = new Type[]{};
            method = type.GetMethod("TrimExcess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrimExcess_43);
            args = new Type[]{typeof(System.Predicate<ASBinCode.RunTimeValueBase>)};
            method = type.GetMethod("TrueForAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrueForAll_44);
            args = new Type[]{};
            method = type.GetMethod("get_Capacity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Capacity_45);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_Capacity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Capacity_46);
            args = new Type[]{};
            method = type.GetMethod("get_Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Count_47);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_48);
            args = new Type[]{typeof(System.Int32), typeof(ASBinCode.RunTimeValueBase)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_49);



            app.RegisterCLRCreateDefaultInstance(type, () => new System.Collections.Generic.List<ASBinCode.RunTimeValueBase>());
            app.RegisterCLRCreateArrayInstance(type, s => new System.Collections.Generic.List<ASBinCode.RunTimeValueBase>[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);

        }


        static StackObject* Add_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Add(item);

            return __ret;
        }

        static StackObject* AddRange_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase> collection = (System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRange(collection);

            return __ret;
        }

        static StackObject* AsReadOnly_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AsReadOnly();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BinarySearch_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.BinarySearch(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BinarySearch_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase> comparer = (System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.BinarySearch(item, comparer);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BinarySearch_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase> comparer = (System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.BinarySearch(index, count, item, comparer);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Clear_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
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
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Contains(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CopyTo_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ASBinCode.RunTimeValueBase[] array = (ASBinCode.RunTimeValueBase[])typeof(ASBinCode.RunTimeValueBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(array);

            return __ret;
        }

        static StackObject* CopyTo_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 arrayIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ASBinCode.RunTimeValueBase[] array = (ASBinCode.RunTimeValueBase[])typeof(ASBinCode.RunTimeValueBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(array, arrayIndex);

            return __ret;
        }

        static StackObject* CopyTo_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 arrayIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ASBinCode.RunTimeValueBase[] array = (ASBinCode.RunTimeValueBase[])typeof(ASBinCode.RunTimeValueBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(index, array, arrayIndex, count);

            return __ret;
        }

        static StackObject* Exists_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Exists(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Find_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Find(match);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindAll_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindAll(match);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindIndex_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindIndex(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindIndex_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 startIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindIndex(startIndex, match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindIndex_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 startIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindIndex(startIndex, count, match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindLast_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindLast(match);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindLastIndex_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindLastIndex(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindLastIndex_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 startIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindLastIndex(startIndex, match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindLastIndex_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 startIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindLastIndex(startIndex, count, match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ForEach_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<ASBinCode.RunTimeValueBase> action = (System.Action<ASBinCode.RunTimeValueBase>)typeof(System.Action<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ForEach(action);

            return __ret;
        }

        static StackObject* GetEnumerator_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetEnumerator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRange_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRange(index, count);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IndexOf_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IndexOf(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IndexOf_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IndexOf(item, index);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IndexOf_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IndexOf(item, index, count);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Insert_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Insert(index, item);

            return __ret;
        }

        static StackObject* InsertRange_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase> collection = (System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InsertRange(index, collection);

            return __ret;
        }

        static StackObject* LastIndexOf_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LastIndexOf(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* LastIndexOf_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LastIndexOf(item, index);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* LastIndexOf_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LastIndexOf(item, index, count);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Remove_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ASBinCode.RunTimeValueBase item = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Remove(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RemoveAll_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RemoveAll(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RemoveAt_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveAt(index);

            return __ret;
        }

        static StackObject* RemoveRange_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveRange(index, count);

            return __ret;
        }

        static StackObject* Reverse_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reverse();

            return __ret;
        }

        static StackObject* Reverse_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reverse(index, count);

            return __ret;
        }

        static StackObject* Sort_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort();

            return __ret;
        }

        static StackObject* Sort_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase> comparer = (System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort(comparer);

            return __ret;
        }

        static StackObject* Sort_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Comparison<ASBinCode.RunTimeValueBase> comparison = (System.Comparison<ASBinCode.RunTimeValueBase>)typeof(System.Comparison<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort(comparison);

            return __ret;
        }

        static StackObject* Sort_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase> comparer = (System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.IComparer<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort(index, count, comparer);

            return __ret;
        }

        static StackObject* ToArray_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToArray();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TrimExcess_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TrimExcess();

            return __ret;
        }

        static StackObject* TrueForAll_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<ASBinCode.RunTimeValueBase> match = (System.Predicate<ASBinCode.RunTimeValueBase>)typeof(System.Predicate<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TrueForAll(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_Capacity_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Capacity;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Capacity_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Capacity = value;

            return __ret;
        }

        static StackObject* get_Count_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_Item_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method[index];

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Item_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ASBinCode.RunTimeValueBase value = (ASBinCode.RunTimeValueBase)typeof(ASBinCode.RunTimeValueBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<ASBinCode.RunTimeValueBase> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.List<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method[index] = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new System.Collections.Generic.List<ASBinCode.RunTimeValueBase>();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase> collection = (System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>)typeof(System.Collections.Generic.IEnumerable<ASBinCode.RunTimeValueBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new System.Collections.Generic.List<ASBinCode.RunTimeValueBase>(collection);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 capacity = ptr_of_this_method->Value;

            var result_of_this_method = new System.Collections.Generic.List<ASBinCode.RunTimeValueBase>(capacity);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
