package com.netease.protobuf;

extern class ReadUtils {
	function new() : Void;
	static function readPackedRepeated(p1 : flash.utils.IDataInput, p2 : Dynamic, p3 : Array<Dynamic>) : Void;
	static function read_TYPE_BOOL(p1 : flash.utils.IDataInput) : Bool;
	static function read_TYPE_BYTES(p1 : flash.utils.IDataInput) : flash.utils.ByteArray;
	static function read_TYPE_DOUBLE(p1 : flash.utils.IDataInput) : Float;
	static function read_TYPE_ENUM(p1 : flash.utils.IDataInput) : Int;
	static function read_TYPE_FIXED32(p1 : flash.utils.IDataInput) : UInt;
	static function read_TYPE_FIXED64(p1 : flash.utils.IDataInput) : UInt64;
	static function read_TYPE_FLOAT(p1 : flash.utils.IDataInput) : Float;
	static function read_TYPE_INT32(p1 : flash.utils.IDataInput) : Int;
	static function read_TYPE_INT64(p1 : flash.utils.IDataInput) : Int64;
	static function read_TYPE_MESSAGE(p1 : flash.utils.IDataInput, p2 : Message) : Message;
	static function read_TYPE_SFIXED32(p1 : flash.utils.IDataInput) : Int;
	static function read_TYPE_SFIXED64(p1 : flash.utils.IDataInput) : Int64;
	static function read_TYPE_SINT32(p1 : flash.utils.IDataInput) : Int;
	static function read_TYPE_SINT64(p1 : flash.utils.IDataInput) : Int64;
	static function read_TYPE_STRING(p1 : flash.utils.IDataInput) : String;
	static function read_TYPE_UINT32(p1 : flash.utils.IDataInput) : UInt;
	static function read_TYPE_UINT64(p1 : flash.utils.IDataInput) : UInt64;
	static function skip(p1 : flash.utils.IDataInput, p2 : UInt) : Void;
}
