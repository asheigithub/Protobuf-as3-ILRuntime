﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ASBinCode
{
	
	/// <summary>
	/// 表示是变量
	/// </summary>
	public abstract class VariableBase : LeftValueBase,IMember
    {
        //private RunTimeDataType type;

        private  string _name;

        protected  int _indexOfMembers;

        protected readonly int refblockid;

        /// <summary>
        /// 在哪个代码块中定义
        /// </summary>
        public int refdefinedinblockid { get { return refblockid; } }

        public int indexOfMembers
        {
            get
            {
                return _indexOfMembers;
            }
        }

        /// <summary>
        /// 赋值是否忽略编译期类型检查
        /// </summary>
        public readonly bool ignoreImplicitCast;

        /// <summary>
        /// 是否不可赋值
        /// </summary>
        public readonly bool isConst;

        public VariableBase(string name, int index, int refblockid) : this(name, index, false, refblockid, false)
        {

        }
        public VariableBase(string name, int index,int refblockid,bool isConst):this(name,index,false,refblockid,isConst)
        {

        }
        public VariableBase(string name, int index, bool ignoreImplicitCast, int refblockid)
            : this(name, index, ignoreImplicitCast, refblockid, RunTimeDataType.rt_void, false)

        {
        }
        public VariableBase(string name, int index, bool ignoreImplicitCast,int refblockid,bool isConst)
            :this(name,index,ignoreImplicitCast,refblockid, RunTimeDataType.rt_void,isConst)

        {
        }

        protected VariableBase(string name, int index, bool ignoreImplicitCast, int refblockid,RunTimeDataType type,bool isConst)
        {
            this._name = name;
            this._indexOfMembers = index;
            this.ignoreImplicitCast = ignoreImplicitCast;
            this.refblockid = refblockid;
            this.valueType = type;
            this.isConst = isConst;
        }

        /// <summary>
        /// 仅用于编译Catch块时
        /// </summary>
        /// <param name="n"></param>
        public void resetName(string n)
        {
            _name = n;
        }

        //public sealed override  RunTimeDataType valueType
        //{
        //    get
        //    {
        //        return type;
        //    }

        //    //set
        //    //{
        //    //    type = value;
        //    //}
        //}

        public string name
        {
            get
            {
                return _name;
            }
        }


        //public override sealed RunTimeValueBase getValue(RunTimeScope scope)
        //{
            //throw new NotImplementedException();

            
            //return getSlot(scope).getValue();

            //while (refblockid != scope.blockId)
            //{
            //    scope = scope.parent;
            //}
            //return scope.memberData[indexOfMembers].getValue();

        //}

        //public abstract SLOT getSlot(RunTimeScope scope);
        
        


        public override string ToString()
        {
            return  (isConst?"CST":"VAR")+ "("+name+"\t"+valueType +")" ;
        }

        IMember IMember.clone()
        {
            return _clone();
        }

        protected abstract IMember _clone();
        //{
        //    return new VariableBase(name, _indexOfMembers, ignoreImplicitCast, refblockid, valueType, isConst);
        //}


        public override int GetHashCode()
        {
            return name.GetHashCode() ^ _indexOfMembers.GetHashCode() 
                ^ ignoreImplicitCast.GetHashCode() 
                ^ refblockid.GetHashCode() 
                ^ valueType.GetHashCode()
                ^ isConst.GetHashCode()
                ;   
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }

            if (!(obj.GetType().Equals(this.GetType())))
            {
                return false;
            }

            VariableBase other = obj as VariableBase;
            
            return name == other.name
                &&
                _indexOfMembers == other._indexOfMembers
                &&
                ignoreImplicitCast == other.ignoreImplicitCast
                &&
                refblockid == other.refblockid
                &&
                valueType == other.valueType
                &&
                isConst == other.isConst
                ;

        }














		public override void Serialize(BinaryWriter writer, CSWCSerizlizer serizlizer)
		{
			//	private string _name;
			writer.Write(_name);
			//protected int _indexOfMembers;
			writer.Write(_indexOfMembers);
			//protected readonly int refblockid;
			writer.Write(refblockid);

			///// <summary>
			///// 赋值是否忽略编译期类型检查
			///// </summary>
			//public readonly bool ignoreImplicitCast;
			writer.Write(ignoreImplicitCast);
			///// <summary>
			///// 是否不可赋值
			///// </summary>
			//public readonly bool isConst;
			writer.Write(isConst);

			base.Serialize(writer, serizlizer);
		}

	}
}
