using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AS3_2_CSharp_Compiler
{
	class Program
	{
		static void AddSrcFiles(string path,Dictionary<string,string> dictSrcFileProjFile)
		{
			var linkapi = System.IO.Directory.GetFiles(path, "*.as", System.IO.SearchOption.AllDirectories);
			foreach (var item in linkapi)
			{
				string projfile = item.Replace("\\", "/").Replace(path.Replace("\\", "/"), "");
				if (projfile.StartsWith("/"))
					projfile = projfile.Substring(1);
				dictSrcFileProjFile.Add(item, projfile);
			}
		}


		/// <summary>
		/// 命令行参数定义
		/// </summary>
		private sealed class Options
		{
			[Option('p', "proto-as3", Required = true, HelpText = "protobuf-as3生成的as3代码的路径.")]
			public string ProtoAS3
			{
				get;
				set;
			}

			[Option('o', "proto-csharp", Required = true, HelpText = "将要生成的C#协议文件路径.")]
			public string OutPutCSFile
			{
				get;
				set;
			}

			[Option('c', "proto-cswc", Required = true, HelpText = "要生成的AS3字节码文件路径.")]
			public string OutPutCSWC
			{
				get;
				set;
			}

		}



		static void Main(string[] args)
		{
			//-- 分析命令行参数
			var options = new Options();
			var parser = new CommandLine.Parser(with => with.HelpWriter = Console.Error);

			if (!parser.ParseArgumentsStrict(args, options, () => Environment.Exit(-1)))
			{
				//-- 执行导出操作
				return;
			}


			string outputcsfile = options.OutPutCSFile; //@"../../../../HotFixProto/proto.cs";

			string outputswcfile = options.OutPutCSWC; //@"../../../../AS3ProtoBuf_Unity/Assets/StreamingAssets/proto.cswc";

			ASTool.Grammar grammar = ASCompiler.Grammar.getGrammar();

			string teststring = "package{}";

			Dictionary<string, string> srcFiles=new Dictionary<string, string>();
			string[] protofiles = null;

			
			{
				string path = options.ProtoAS3; 

				if (path.EndsWith(".as"))
				{
					path = System.IO.Path.GetDirectoryName(path);
				}

				if (string.IsNullOrEmpty(path))
				{
					path = ".\\";
				}

				string[] ps = path.Split(System.IO.Path.DirectorySeparatorChar);
				if (ps.Length == 2 && string.IsNullOrEmpty(ps[1]) && ps[0].IndexOf(System.IO.Path.VolumeSeparatorChar) > 0)
				{
					Console.WriteLine("无法在根目录下搜索.请将as源代码放到一个文件夹内");
					return;
				}
				else if (System.IO.Directory.Exists(path))
				{
					//Console.WriteLine(path);
					//teststring = System.IO.File.ReadAllText(args[0]);
					//files = System.IO.Directory.GetFiles(path, "*.as", System.IO.SearchOption.AllDirectories);

					AddSrcFiles(path, srcFiles);
					protofiles = new string[srcFiles.Count];
					srcFiles.Keys.CopyTo(protofiles, 0); //(string[])files.Clone();
				}
			}
			

			if (srcFiles.Count == 0)
			{
				Console.Write("输入as文件所在路径");
				return;
			}

			//*********加入ProtoBuf API*****
			//string apidir = @"../../../../as3protobuflib";
			//if (System.IO.Directory.Exists(apidir))
			//{
			//	AddSrcFiles(apidir, srcFiles);
			//}
			//*********************

			var proj = new ASTool.AS3.AS3Proj();
			var srcout = new ASTool.ConSrcOut();

			foreach(var src in srcFiles)
			{
				grammar.hasError = false;
				teststring = System.IO.File.ReadAllText(src.Key);
				if (string.IsNullOrEmpty(teststring))
				{
					continue;
				}

				teststring = teststring.Replace("override com.netease.protobuf.used_by_generated_code final function", "override protected final function");

				var tree = grammar.ParseTree(teststring, ASTool.AS3LexKeywords.LEXKEYWORDS,
							ASTool.AS3LexKeywords.LEXSKIPBLANKWORDS, src.Value);

				if (grammar.hasError)
				{
					Console.WriteLine(src.Key);
					Console.WriteLine("解析语法树失败!");
					Console.ReadLine();
					return;
				}



				var analyser = new ASTool.AS3FileGrammarAnalyser(proj, src.Value);
				if (!analyser.Analyse(grammar, tree)) //生成项目的语法树
				{
					Console.WriteLine(analyser.err.ToString());
					Console.WriteLine("语义分析失败!");
					Console.ReadLine();
					return;
				}
#if DEBUG
				//Console.Clear();
#endif
			}

#if DEBUG

			Console.WriteLine();
			Console.WriteLine("====语法树翻译====");

			//runtimeCompiler rtLoader = new runtimeCompiler();
			foreach (var p in proj.SrcFiles)
			{
				p.Write(0, srcout);
			}

#endif
			//Console.Read();
			//return;
			ASCompiler.compiler.Builder builder = new ASCompiler.compiler.Builder();
			builder.LoadLibrary( System.IO.File.ReadAllBytes("as3protobuf.swc") );
			//builder.LoadLibrary( System.IO.File.ReadAllBytes("astoolglobal.swc"));

			builder.Build(proj,null);


			if (builder.buildErrors.Count == 0)
			{
				ASBinCode.CSWC swc = builder.getBuildOutSWC();
				//System.IO.File.WriteAllBytes("astoolglobal.swc", swc.toBytes());
				//System.IO.File.WriteAllBytes("as3protobuf.swc", swc.toBytes());
				System.IO.File.WriteAllBytes(outputswcfile, swc.toBytes());

				if (swc != null)
				{
					ASRuntime.Player player = new ASRuntime.Player();
					player.loadCode(swc);

					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.AppendLine("using System;");

					foreach (var cls in swc.classes)
					{
						if (cls.staticClass != null)
						{
							
							//判断是否在编译路径中
							string fullname = cls.package + ( string.IsNullOrEmpty(cls.package)?"":  ".") + cls.name + ".as";
							foreach (var f in protofiles)
							{
								string ff = f.Replace("\\", ".").Replace("/", ".");
								if (ff.EndsWith(fullname))
								{
									CodeGen codeGen = new CodeGen(cls,swc,player);

									string cs= codeGen.GetCode();

									Console.Write(cs);
									stringBuilder.AppendLine(cs);
									
									break;
								}
							}

						}

					}

					System.IO.File.WriteAllText(outputcsfile, stringBuilder.ToString());
				}

			}

		}
	}
}
