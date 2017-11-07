using ASBinCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AS3_2_CSharp_Compiler
{
	class CodeGen
	{
		private CSWC swc;
		private ASBinCode.rtti.Class as3class;
		private ASRuntime.Player player;
		private string GetTypeString(RunTimeDataType as3type)
		{
			switch (as3type)
			{
				case RunTimeDataType.rt_int:
					return "int";
				case RunTimeDataType.rt_boolean:
					return "bool";
				case RunTimeDataType.rt_uint:
					return "uint";
				case RunTimeDataType.rt_number:
					return "double";
				case RunTimeDataType.rt_string:
					return "string";
				case RunTimeDataType.fun_void:
					return "void";
				default:
					if (as3type > RunTimeDataType.unknown)
					{
						var cls = swc.getClassByRunTimeDataType(as3type);
						return cls.package + (string.IsNullOrEmpty(cls.package) ? "" : ".") + cls.name;
					}
					else if (as3type == RunTimeDataType.rt_array)
					{
						return "System.Collections.Generic.List<{0}>";
					}
					else
					{
						return "类型不支持";
					}
					
			}
		}

		private HashSet<string> keywords = new HashSet<string>( 
			new string[] {
				"base","beforeWriteTo","afterMergeFrom","_iswritting","_isreadding"
			}
			);

		private string GetName(string name)
		{
			if (keywords.Contains(name))
			{
				return name + "_";
			}
			else
			{
				return name;
			}
		}

		private string GetConvertToAS3ParameterFunctionName(RunTimeDataType type)
		{		
			string paratype = GetTypeString(type);
			return GetConvertToAS3ParameterFunctionName(paratype);
		}
		private string GetConvertToAS3ParameterFunctionName(string paratype)
		{
			if (paratype == "flash.utils.ByteArray")
			{
				return "ConvertBytesToByteArray";
			}
			else if (paratype == "com.netease.protobuf.UInt64")
			{
				return "ConvertULongToObj";
			}
			else if (paratype == "com.netease.protobuf.Int64")
			{
				return "ConvertLongToObj";
			}
			else
			{
				return string.Empty;
			}
		}


		private string GetConvertFromAS3ParameterFunctionName(RunTimeDataType type)
		{
			string paratype = GetTypeString(type);
			if (paratype == "flash.utils.ByteArray")
			{
				return "ConvertByteArrayToBytes";
			}
			else if (paratype == "com.netease.protobuf.UInt64")
			{
				return "ConvertObjToULong";
			}
			else if (paratype == "com.netease.protobuf.Int64")
			{
				return "ConvertObjToLong";
			}
			else
			{
				return string.Empty;
			}
		}

		Dictionary<string, string> enumMembers = new Dictionary<string, string>();
		Dictionary<string, string> repeatEnumMembers = new Dictionary<string, string>();

		public CodeGen(ASBinCode.rtti.Class as3class,CSWC swc,ASRuntime.Player player)
		{
			this.swc = swc;
			this.as3class = as3class;
			this.player = player;
		}

		public string GetCode()
		{
			if (as3class.super.name == "Object")
			{
				StringBuilder content = new StringBuilder();

				foreach (var item in as3class.staticClass.fields)
				{
					if (item.inheritFrom == null)
					{
						content.Append("\t\t");

						string field = "";//item.isPublic ? "public" : (item.isInternal ? "internal" : "private");
						//if (item.isProtectd) field += " protected";
						//if (item.isConst) field += " const";

						//field += " " + GetTypeString(item.valueType);

						field += " " + GetName(item.name);
						if (item.defaultValue != null)
						{
							field += " = " + item.defaultValue.ToString();
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("发现枚举字段没有默认值." + as3class.name + ":" + item.name);
							Console.ResetColor();
						}


						field += ",";

						content.AppendLine(field);
					}
				}

				//Enum文档
				foreach (var item in as3class.fields)
				{
					if (item.inheritFrom == null)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("发现枚举类中的非静态字段:" + as3class.name + ":" + item.name);
						Console.ResetColor();
					}
				}

				var tempate = Properties.Resources.EnumTemplate;
				tempate = tempate.Replace("[PACKAGE]", as3class.package)
						.Replace("[CLASSNAME]", as3class.name)
						.Replace("[CONTENT]", content.ToString());

				return tempate.ToString();
			}
			else if (as3class.super.name == "Message")
			{
				
				var enumtype = swc.getClassDefinitionByName("com.netease.protobuf.fieldDescriptors.FieldDescriptor_TYPE_ENUM");
				var repeatEnum = swc.getClassDefinitionByName("com.netease.protobuf.fieldDescriptors.RepeatedFieldDescriptor_TYPE_ENUM");
				//****查询元数据***
				foreach (var item in as3class.staticClass.classMembers)
				{
					if (item.valueType == enumtype.getRtType())
					{

						var findenum = ((ASBinCode.rtData.rtObject)player.getMemberValue(as3class.package + (string.IsNullOrEmpty(as3class.package) ? "" : ".") + as3class.name, item.name + ".enumType")).value._class.instanceClass;
						var bindmember = player.getMemberValue(as3class.package + (string.IsNullOrEmpty(as3class.package) ? "" : ".") + as3class.name, item.name + ".name");

						enumMembers.Add(bindmember.ToString(), findenum.package + (string.IsNullOrEmpty(findenum.package) ? "" : ".") + findenum.name);

					}
					else if (item.valueType == repeatEnum.getRtType())
					{
						var findenum = ((ASBinCode.rtData.rtObject)player.getMemberValue(as3class.package + (string.IsNullOrEmpty(as3class.package) ? "" : ".") + as3class.name, item.name + ".enumType")).value._class.instanceClass;
						var bindmember = player.getMemberValue(as3class.package + (string.IsNullOrEmpty(as3class.package) ? "" : ".") + as3class.name, item.name + ".name");

						repeatEnumMembers.Add(bindmember.ToString(), findenum.package + (string.IsNullOrEmpty(findenum.package) ? "" : ".") + findenum.name);

					}
				}

				StringBuilder content = new StringBuilder();

				List<ASBinCode.rtti.ClassMember> fieldlist = new List<ASBinCode.rtti.ClassMember>();
				List<ASBinCode.rtti.ClassMember> propertylist = new List<ASBinCode.rtti.ClassMember>();

				foreach (var member in as3class.classMembers)
				{
					if (member.inheritFrom != null && (member.inheritFrom.name != "Message" || member.inheritSrcMember.isConstructor))
						continue;
					if (member.isConstructor)
						continue;

					if (!member.isPublic)
						continue;
					if (member.isGetter || member.isSetter)
						continue;
					if (member.valueType == RunTimeDataType.rt_function)
					{
						if (member.inheritFrom != null)
							continue;

						var function = swc.functions[((MethodGetterBase)member.bindField).functionId];
						string type = GetTypeString(function.signature.returnType);


						string method = "\t\tpublic ";
						if (member.isOverride)
						{
							method += "override ";
						}

						method += type + " ";
						method += GetName(member.name);
						method += "(";

						for (int i = 0; i < function.signature.parameters.Count; i++)
						{
							var p = function.signature.parameters[i];

							string paratype = GetTypeString(p.type);

							if (paratype == "flash.utils.IDataInput")
							{
								paratype = "System.IO.MemoryStream";
							}
							else if (paratype == "flash.utils.IDataOutput")
							{
								paratype = "System.IO.MemoryStream";
							}
							else if (paratype == "flash.utils.ByteArray")
							{
								paratype = "byte[]";
							}
							else if (paratype == "com.netease.protobuf.UInt64")
							{
								paratype = "System.UInt64";
							}
							else if (paratype == "com.netease.protobuf.Int64")
							{
								paratype = "System.Int64";
							}

							method += paratype + " " + p.name;
							if (i < function.signature.parameters.Count - 1)
							{
								method += ",";
							}
						}

						method += "){";

						method += " player.invokeMethod(as3Object, \"" + member.name + "\"";

						for (int i = 0; i < function.signature.parameters.Count; i++)
						{

							method += ","+GetConvertToAS3ParameterFunctionName(function.signature.parameters[i].type) +"(" + function.signature.parameters[i].name + ")";
						}

						method += ");";
						method +="}";



						content.AppendLine(method);

					}
					else if (member.bindField is ASBinCode.ClassPropertyGetter)
					{
						string propertytype = GetTypeString(member.valueType);
						if (propertytype == "flash.utils.ByteArray")
						{
							propertytype = "byte[]";
						}
						else if (propertytype == "com.netease.protobuf.UInt64")
						{
							propertytype = "System.UInt64";
						}
						else if (propertytype == "com.netease.protobuf.Int64")
						{
							propertytype = "System.Int64";
						}

						if ((propertytype=="byte[]") || (propertytype == "System.UInt64") || (propertytype == "System.Int64") || ((member.valueType < RunTimeDataType._OBJECT)))
						{
							bool isenum = false;
							if (enumMembers.ContainsKey(member.name))
							{
								propertytype = enumMembers[member.name];
								isenum = true;
							}

							string filed = "\t\tpublic " + propertytype + " " + GetName(member.name) +
								"{";

							ClassPropertyGetter prop = (ClassPropertyGetter)member.bindField;

							if (prop.getter != null && prop.getter.classmember.isPublic)
							{
								filed += "get { return (" + propertytype + ")(" + GetConvertFromAS3ParameterFunctionName(member.valueType) + "(player.getMemberValue(as3Object, \"" + member.name + "\"))); }";
							}

							if (prop.setter != null && prop.setter.classmember.isPublic)
							{
								filed += "set { player.setMemberValue(as3Object, \"" + member.name + "\", " + GetConvertToAS3ParameterFunctionName(member.valueType) +( isenum?"(int)":"")+ "(value)); }";
							}

							filed += "}";



							content.AppendLine(filed);

						}
						else
						{
							string field = Properties.Resources.ClassPropertyTemplate
								.Replace("[PROPERTYTYPE]",propertytype)
								.Replace("[CNAME]",GetName(member.name))
								.Replace("[NAME]",member.name)
								;

							content.AppendLine(field);
							propertylist.Add(member);

						}
						
							
					}
					else if (as3class.fields.Contains(member))
					{
						fieldlist.Add(member);

						string fieldtype = GetTypeString(member.valueType);
						if (fieldtype == "System.Collections.Generic.List<{0}>")
						{
							Field f = (Field)member.bindField;

							foreach (var item in f.metas)
							{
								if (item.MetaName == "ArrayElementType")
								{
									if (repeatEnumMembers.ContainsKey(member.name))
									{
										fieldtype = string.Format(fieldtype, repeatEnumMembers[member.name]);
									}
									else
									{
										fieldtype = string.Format(fieldtype, item.MetaData.ToString());
									}
									break;
								}
							}
						}
						else if (fieldtype == "flash.utils.ByteArray")
						{
							fieldtype = "byte[]";
						}
						else if (fieldtype == "com.netease.protobuf.UInt64")
						{
							fieldtype = "System.UInt64";
						}
						else if (fieldtype == "com.netease.protobuf.Int64")
						{
							fieldtype = "System.Int64";
						}

						if (enumMembers.ContainsKey(member.name))
						{
							fieldtype = enumMembers[member.name];
						}

						string field = "\t\tpublic " +  fieldtype + " " + GetName( member.name) + " ;";

						content.AppendLine(field);
					}
				}

				string afterMergeFrom = string.Empty;
				string beforeWriteTo = string.Empty;
				if (fieldlist.Count > 0)
				{
					//***追加afterMergeFrom()

					afterMergeFrom = "\t\tprivate bool _isreadding;\n";
					afterMergeFrom += "\t\tprotected override void afterMergeFrom()\n";
					afterMergeFrom += "\t\t{\n";
					afterMergeFrom += "\t\t\tif(_isreadding) { return;} else { _isreadding=true; }\n";
					afterMergeFrom += "\t\t\ttry\n";
					afterMergeFrom += "\t\t\t{\n";

					for (int i = 0; i < fieldlist.Count; i++)
					{
						var member = fieldlist[i];
						string fieldtype = GetTypeString(member.valueType);
						
						if (fieldtype == "System.Collections.Generic.List<{0}>")
						{
							Field f = (Field)member.bindField;
							string vectortype = string.Empty;
							string elementtype = string.Empty;
							foreach (var item in f.metas)
							{
								if (item.MetaName == "ArrayElementType")
								{
									vectortype = item.MetaData.ToString();

									if (repeatEnumMembers.ContainsKey(member.name))
									{
										fieldtype = string.Format(fieldtype, repeatEnumMembers[member.name]);
									}
									else
									{
										fieldtype = string.Format(fieldtype, item.MetaData.ToString());
									}
									elementtype = vectortype;
									if (repeatEnumMembers.ContainsKey(member.name))
									{
										elementtype = repeatEnumMembers[member.name];
									}


									if (elementtype == "flash.utils.ByteArray")
									{
										elementtype = "byte[]";
									}
									else if (elementtype == "com.netease.protobuf.UInt64")
									{
										elementtype = "System.UInt64";
									}
									else if (elementtype == "com.netease.protobuf.Int64")
									{
										elementtype = "System.Int64";
									}
									else if (elementtype == "Number")
									{
										elementtype = "double";
									}
									

									break;
								}
							}

							string listtemplate =
@"			{
				[CNAME] = new [LIST]();
				uint len = (uint)player.getMemberValue(as3Object, ""[NAME].length"");
				for (int i = 0; i < len; i++)
				{
					[VECTORTYPE] v = default([VECTORTYPE]);
[SETVALUE]
					[CNAME].Add(v);
				}
			}
";

							bool isclass = false;
							var c = swc.getClassDefinitionByName(vectortype);
							if(c !=null)
							{
								RunTimeDataType primtype;
								if (ASRuntime.TypeConverter.Object_CanImplicit_ToPrimitive(c, out primtype))
								{
									isclass = false;
								}
								else
								{
									isclass = true;
								}

							}

							afterMergeFrom += listtemplate.Replace("[CNAME]",GetName(member.name))
								.Replace("[NAME]",member.name)
								.Replace("[VECTORTYPE]",elementtype)
								.Replace("[SETVALUE]", GetLoadFieldValueStmt( "v" ,elementtype,member, isclass,"i","\t\t"))
								.Replace("[LIST]",fieldtype)
								;



							continue;
						}
						else if (fieldtype == "flash.utils.ByteArray")
						{
							fieldtype = "byte[]";
						}
						else if (fieldtype == "com.netease.protobuf.UInt64")
						{
							fieldtype = "System.UInt64";
						}
						else if (fieldtype == "com.netease.protobuf.Int64")
						{
							fieldtype = "System.Int64";
						}

						afterMergeFrom += GetLoadFieldValueStmt(GetName(member.name), fieldtype, member, member.valueType > RunTimeDataType._OBJECT , null);

					}
					afterMergeFrom += "\t\t\t}\n";
					afterMergeFrom += "\t\t\tfinally\n";
					afterMergeFrom += "\t\t\t{\n";
					afterMergeFrom += "\t\t\t_isreadding=false;\n";
					afterMergeFrom += "\t\t\t}\n";
					afterMergeFrom += "\t\t}\n";



					//****追加beforeWriteTo******

					beforeWriteTo = "\t\tprivate bool _iswritting;\n";
					beforeWriteTo += "\t\tprotected override void beforeWriteTo()\n";
					beforeWriteTo += "\t\t{\n";
					beforeWriteTo += "\t\t\tif(_iswritting) { return;} else { _iswritting=true; }\n";
					beforeWriteTo += "\t\t\ttry\n";
					beforeWriteTo += "\t\t\t{\n";

					for (int i = 0; i < fieldlist.Count; i++)
					{
						var member = fieldlist[i];
						string fieldtype = GetTypeString(member.valueType);

						if (fieldtype == "System.Collections.Generic.List<{0}>")
						{
							Field f = (Field)member.bindField;
							string vectortype = string.Empty;
							string elementtype = string.Empty;
							foreach (var item in f.metas)
							{
								if (item.MetaName == "ArrayElementType")
								{
									vectortype = item.MetaData.ToString();
									fieldtype = string.Format(fieldtype, item.MetaData.ToString());

									elementtype = vectortype;

									if (elementtype == "flash.utils.ByteArray")
									{
										elementtype = "byte[]";
									}
									else if (elementtype == "com.netease.protobuf.UInt64")
									{
										elementtype = "System.UInt64";
									}
									else if (elementtype == "com.netease.protobuf.Int64")
									{
										elementtype = "System.Int64";
									}
									else if (elementtype == "Number")
									{
										elementtype = "double";
									}

									break;
								}
							}

							string listtemplate =
@"			{
				player.setMemberValue(as3Object, ""[CNAME].length"", [CNAME].Count);
				for (int i = 0; i < [CNAME].Count; i++)
				{
					var v = [CNAME][i];
[SAVEVALUE]					
				}
			}
";
							bool isclass = false;
							var c = swc.getClassDefinitionByName(vectortype);
							if (c != null)
							{
								RunTimeDataType primtype;
								if (ASRuntime.TypeConverter.Object_CanImplicit_ToPrimitive(c, out primtype))
								{
									isclass = false;
								}
								else
								{
									isclass = true;
								}

							}

							beforeWriteTo += listtemplate.Replace("[CNAME]", GetName(member.name))
								.Replace("[SAVEVALUE]", GetSaveFieldValueStmt("v", elementtype, vectortype, member.name, isclass, "i", "\t\t"));
								;


							continue;
						}
						else if (fieldtype == "flash.utils.ByteArray")
						{
							fieldtype = "byte[]";
						}
						else if (fieldtype == "com.netease.protobuf.UInt64")
						{
							fieldtype = "System.UInt64";
						}
						else if (fieldtype == "com.netease.protobuf.Int64")
						{
							fieldtype = "System.Int64";
						}

						beforeWriteTo += GetSaveFieldValueStmt(GetName(member.name), fieldtype, GetTypeString(member.valueType), member.name, member.valueType > RunTimeDataType._OBJECT, null);

					}


					for (int i = 0; i < propertylist.Count; i++)
					{
						var member = propertylist[i];
						string template = Properties.Resources.ClassPropertyBeforeWriteTo;

						beforeWriteTo += template.Replace("[CNAME]",GetName(member.name))
							.Replace("[NAME]",member.name)
							
							;

					}




					beforeWriteTo += "\t\t\t}\n";
					beforeWriteTo += "\t\t\tfinally\n";
					beforeWriteTo += "\t\t\t{\n";
					beforeWriteTo += "\t\t\t_iswritting=false;\n";
					beforeWriteTo += "\t\t\t}\n";
					beforeWriteTo += "\t\t}\n";
				}



				var tempate = Properties.Resources.MessageTemplate;
				tempate = tempate.Replace("[PACKAGE]", as3class.package)
						.Replace("[AS3PROTOTYPE]",as3class.package + (string.IsNullOrEmpty(as3class.package)?"":".") + as3class.name)
						.Replace("[CLASSNAME]", as3class.name)
						.Replace("[afterMergeFrom]",afterMergeFrom)
						.Replace("[beforeWriteTo]",beforeWriteTo)
						.Replace("[CONTENT]", content.ToString());
						
				return tempate.ToString();
				
			}
			else
			{
				return string.Empty;
			}
		}

		private string GetLoadFieldValueStmt(string fieldname,string fieldtype ,ASBinCode.rtti.ClassMember member,bool isclass,string indexArg,string addtab="" )
		{
			string result = string.Empty;

			if ((fieldtype == "byte[]") || (fieldtype == "System.UInt64") || (fieldtype == "System.Int64") || !isclass )
			{

				//if (prop.setter != null && prop.setter.classmember.isPublic)
				//{
				//	filed += "set { player.setMemberValue(as3Object, \"" + member.name + "\", " + GetConvertToAS3ParameterFunctionName(member.valueType) + "(value)); }";
				//}

				if (enumMembers.ContainsKey(member.name))
				{
					fieldtype = enumMembers[member.name];
				}
				if (!string.IsNullOrEmpty(indexArg)
					&&
					repeatEnumMembers.ContainsKey(member.name)
					)
				{
					fieldtype = repeatEnumMembers[member.name];
				}
				result += addtab+ "\t\t\t" + fieldname + " = (" + fieldtype + ")(" + GetConvertFromAS3ParameterFunctionName(member.valueType) + "(player.getMemberValue(as3Object, \"" + member.name + "\" "+ (string.IsNullOrEmpty(indexArg)?"":"," + indexArg) + " )));\n";

			}
			else
			{
				//var obj = player.getMemberValue(as3Object, "[NAME]");
				//if (obj != null)
				//	___[CNAME] = [PROPERTYTYPE].Create(obj);
				result += addtab + "\t\t\t{\n";
				result += addtab + "\t\t\t\tvar obj = player.getMemberValue(as3Object, \"" + member.name + "\"" + (string.IsNullOrEmpty(indexArg) ? "" : "," + indexArg) + ");\n";
				result += addtab + "\t\t\t\tif (obj !=null)\n";
				result += addtab + "\t\t\t\t\t" + fieldname + " = " + fieldtype + ".Create(obj);\n";
				result += addtab + "\t\t\t\telse\n";
				result += addtab + "\t\t\t\t\t" + fieldname + " = null;\n";
				result += addtab + "\t\t\t}\n";
			}

			return result;

		}

		private string GetSaveFieldValueStmt(string fieldname, string fieldtype, string as3fileldtype , string membername, bool isclass, string indexArg, string addtab = "")
		{
			string result = string.Empty;

			if ((fieldtype == "byte[]") || (fieldtype == "System.UInt64") || (fieldtype == "System.Int64") || !isclass)
			{
				bool isenum = false;
				if (enumMembers.ContainsKey(membername))
				{
					isenum = true;
				}
				if (!string.IsNullOrEmpty(indexArg)
					&&
					repeatEnumMembers.ContainsKey(membername)
					)
				{
					isenum = true;
				}
				result += addtab + "\t\t\tplayer.setMemberValue(as3Object, \"" + membername + "\", " + GetConvertToAS3ParameterFunctionName(as3fileldtype) +(isenum?"(int)":"") +"(" + fieldname + ")" + (string.IsNullOrEmpty(indexArg)?"":","+indexArg) + " );\n";

			}
			else
			{

				//if (value != null)
				//{
				//	player.setMemberValue(as3Object, "base", LoadBindObject(value));
				//}
				//else
				//{
				//	player.setMemberValue(as3Object, "base", null);
				//}

				result += addtab + "\t\t\t{\n";
				result += addtab + "\t\t\t\tif ("+ fieldname +" != null)\n";
				result += addtab + "\t\t\t\t{\n";
				result += addtab + "\t\t\t\t\tplayer.setMemberValue(as3Object, \"" + membername + "\", LoadBindObjectAndWriteField(" + fieldname+")" + (string.IsNullOrEmpty(indexArg) ? "" : "," + indexArg) + ");\n";
				result += addtab + "\t\t\t\t}\n";
				result += addtab + "\t\t\t\telse\n";
				result += addtab + "\t\t\t\t{\n";
				result += addtab + "\t\t\t\t\tplayer.setMemberValue(as3Object, \"" + membername + "\", null);\n";
				result += addtab + "\t\t\t\t}\n";
				result += addtab + "\t\t\t}\n";
			}
			return result;
		}
	}
}
