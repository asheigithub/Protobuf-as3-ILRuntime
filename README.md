 
# Protobuf-as3-ILRuntime
将protobuf-as3移植到ILRuntime中使用。支持protobuf-as3的全部功能,支持Unity5.X


使用AS3解释器解释protobuf-as3版，来使用protobuf.由于完全不涉及反射, 因此可直接在ILRuntime中使用。

执行AS3使用的是我编写的AS3编译器。   
地址 https://github.com/asheigithub/ASTool  
  
  
  

protobuf-as3版来自网易的开源protobuf-as3。  
地址 https://github.com/Atry/protoc-gen-as3  



我使用我的编译器编译了protobuf-as3并解释执行，然后生成C#的对接代码.  
  
请先配置 protobuf-as3的执行环境。
  
protobuf目录中有一个  调用protobuf-as3并生成C#.bat ,执行此bat即可生成所需代码

