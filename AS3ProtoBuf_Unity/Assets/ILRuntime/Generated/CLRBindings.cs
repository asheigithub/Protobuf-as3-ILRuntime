using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {
        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            System_Int32_Binding.Register(app);
            System_Single_Binding.Register(app);
            System_Int64_Binding.Register(app);
            System_Object_Binding.Register(app);
            System_String_Binding.Register(app);
            System_Array_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            UnityEngine_Quaternion_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            UnityEngine_RectTransform_Binding.Register(app);
            UnityEngine_Time_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_Object_Binding.Register(app);
            System_Collections_Generic_List_1_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_UInt32_Binding.Register(app);
            System_Collections_Generic_List_1_Boolean_Binding.Register(app);
            System_Collections_Generic_List_1_Double_Binding.Register(app);
            System_Collections_Generic_List_1_RunTimeValueBase_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Object_Binding.Register(app);
            System_Collections_Generic_HashSet_1_String_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Int32_Binding.Register(app);
            System_Collections_Generic_HashSet_1_UInt32_Binding.Register(app);
            System_Collections_Generic_HashSet_1_Int64_Binding.Register(app);
            System_Collections_Generic_HashSet_1_UInt64_Binding.Register(app);
            System_Collections_Generic_HashSet_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt32_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt64_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Int64_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_Int64_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Object_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_Int64_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_UInt32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_UInt64_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_UInt32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt64_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt64_UInt32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt32_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt32_Int64_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt32_UInt32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt32_UInt64_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt64_UInt64_Binding.Register(app);
            System_IO_MemoryStream_Binding.Register(app);
            System_IO_BinaryReader_Binding.Register(app);
            System_IO_BinaryWriter_Binding.Register(app);
            System_Text_UTF8Encoding_Binding.Register(app);
            ASRuntime_Player_Binding.Register(app);
            System_GC_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            UnityEngine_AnimationCurve_Binding.Register(app);
            UnityEngine_Keyframe_Binding.Register(app);
            UnityEngine_WrapMode_Binding.Register(app);
        }
    }
}
