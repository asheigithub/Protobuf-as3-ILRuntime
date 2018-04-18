﻿using ASBinCode;
using ASBinCode.rtData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASRuntime.error
{
    /// <summary>
    /// 内部操作错误
    /// </summary>
    public class InternalError
    {
        public ASBinCode.SourceToken token;

        public string message;

        public int errorCode;


        public ASBinCode.RunTimeValueBase errorValue;

        internal Stack<FrameInfo> callStack;

		private CSWC swc;

		private InternalError(CSWC swc)
		{
			this.swc = swc;
		}

        public InternalError(CSWC swc,ASBinCode.SourceToken token,string message):this(swc)
        {
            this.token = token;
            this.message = message;
            this.errorValue = null;
        }
        /// <summary>
        /// 是否可被捕获的异常
        /// </summary>
        public bool catchable
        {
            get { return  errorValue != null; }
        }


        public InternalError(CSWC swc,ASBinCode.SourceToken token, string message ,ASBinCode.RunTimeValueBase errorValue ):this(swc)
        {
            this.token = token;
            this.message = message;
            this.errorValue = errorValue;
        }

        public InternalError(CSWC swc,ASBinCode.SourceToken token, ASBinCode.RunTimeValueBase errorValue):this(swc)
        {
            this.token = token;
            this.errorValue = errorValue;
            if (errorValue != null)
            {
				this.message = getErrorInfo(); //errorValue.ToString();
            }
        }


		public string getErrorInfo()
		{
			if (errorValue != null && swc !=null)
			{
				string errinfo = errorValue.ToString();
				if (errorValue.rtType > RunTimeDataType.unknown && swc.ErrorClass != null)
				{
					if (ClassMemberFinder.check_isinherits(errorValue, swc.ErrorClass.getRtType(), swc))
					{
						errinfo =
							((rtObjectBase)errorValue).value.memberData[1].getValue().ToString() + " #" +
							((rtObjectBase)errorValue).value.memberData[2].getValue().ToString() + " " +
							((rtObjectBase)errorValue).value.memberData[0].getValue().ToString();
					}
				}


				return "[故障] " + "信息=" + errinfo;
			}
			else
			{
				return message;
			}
		}

		public string getStackTrace()
		{
			if (errorValue != null )
			{
				string errinfo = string.Empty;
				if (errorValue.rtType > RunTimeDataType.unknown && swc.ErrorClass != null)
				{
					if (ClassMemberFinder.check_isinherits(errorValue, swc.ErrorClass.getRtType(), swc))
					{
						errinfo =
							((rtObjectBase)errorValue).value.memberData[3].getValue().ToString();
					}
				}
				else if(callStack !=null)
				{
					StringBuilder sb = new StringBuilder();

					var toget = new List<ASRuntime.FrameInfo>(callStack);
					toget.Reverse();

					foreach (var item in toget)
					{					
						if (item.block.instructions.Length ==0 )
						{
							continue;
						}

						if (item.codeLinePtr < item.block.instructions.Length)
						{
							sb.Append("\tat ");
							sb.Append(item.block.name);
							sb.Append(" [");
							sb.Append(item.block.instructions[item.codeLinePtr].token.sourceFile);
							sb.Append(" ");
							sb.Append(item.block.instructions[item.codeLinePtr].token.line + 1);
							sb.Append(" ptr:");
							sb.Append(item.block.instructions[item.codeLinePtr].token.ptr + 1);
							sb.Append("]");
							sb.AppendLine();
						}
						else
						{
							sb.Append("\tat ");
							sb.AppendLine(item.block.name);
						}


					}



					errinfo = sb.ToString();
					
				}

				return  "\t"+errinfo;
			}
			else
			{
				return string.Empty;
			}
		}

		public override string ToString()
		{
			return getErrorInfo() + getStackTrace();
		}
	}
}
