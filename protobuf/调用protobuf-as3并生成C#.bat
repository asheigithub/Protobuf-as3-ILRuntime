@echo ɾ���ɵ��ļ�

@del /f/s/q .\as3output



@protoc.exe --plugin=protoc-gen-as3=.\protoc-gen-as3-1.1.4-bin\protoc-gen-as3.bat --as3_out=.\as3output login.proto base.proto client.proto

@echo ��as3����Ϊ�ֽ���,������C#Э���ļ�
@AS3_2_CSharp_Compiler.exe -p ./as3output -o ../HotFixProto/proto.cs -c ../AS3ProtoBuf_Unity/Assets/StreamingAssets/proto.cswc



pause