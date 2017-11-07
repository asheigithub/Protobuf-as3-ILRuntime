@echo 删除旧的文件

@del /f/s/q .\as3output



@protoc.exe --plugin=protoc-gen-as3=.\protoc-gen-as3-1.1.4-bin\protoc-gen-as3.bat --as3_out=.\as3output login.proto base.proto client.proto

@echo 将as3编译为字节码,并生成C#协议文件
@AS3_2_CSharp_Compiler.exe -p ./as3output -o ../HotFixProto/proto.cs -c ../AS3ProtoBuf_Unity/Assets/StreamingAssets/proto.cswc



pause