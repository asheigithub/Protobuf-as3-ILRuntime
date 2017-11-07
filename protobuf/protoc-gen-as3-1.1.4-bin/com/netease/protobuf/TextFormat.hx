package com.netease.protobuf;

extern class TextFormat {
	function new() : Void;
	static function mergeFromString(p1 : String, p2 : Message) : Void;
	static function mergeFromUTFBytes(p1 : flash.utils.IDataInput, p2 : Message) : Void;
	static function printToString(p1 : Message, p2 : Bool = true, ?p3 : String) : String;
	static function printToUTFBytes(p1 : flash.utils.IDataOutput, p2 : Message, p3 : Bool = true, ?p4 : String) : Void;
}
