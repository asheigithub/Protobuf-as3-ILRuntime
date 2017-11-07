package com.netease.protobuf;

extern class WriteUtils {
	function new() : Void;
	static function writePackedRepeated(p1 : WritingBuffer, p2 : Dynamic, p3 : Array<Dynamic>) : Void;
	static function writeTag(p1 : WritingBuffer, p2 : UInt, p3 : UInt) : Void;
	static function writeUnknownPair(p1 : WritingBuffer, p2 : UInt, p3 : Dynamic) : Void;
	static function write_TYPE_BOOL(p1 : WritingBuffer, p2 : Bool) : Void;
	static function write_TYPE_BYTES(p1 : WritingBuffer, p2 : flash.utils.ByteArray) : Void;
	static function write_TYPE_DOUBLE(p1 : WritingBuffer, p2 : Float) : Void;
	static function write_TYPE_ENUM(p1 : WritingBuffer, p2 : Int) : Void;
	static function write_TYPE_FIXED32(p1 : WritingBuffer, p2 : UInt) : Void;
	static function write_TYPE_FIXED64(p1 : WritingBuffer, p2 : UInt64) : Void;
	static function write_TYPE_FLOAT(p1 : WritingBuffer, p2 : Float) : Void;
	static function write_TYPE_INT32(p1 : WritingBuffer, p2 : Int) : Void;
	static function write_TYPE_INT64(p1 : WritingBuffer, p2 : Int64) : Void;
	static function write_TYPE_MESSAGE(p1 : WritingBuffer, p2 : Message) : Void;
	static function write_TYPE_SFIXED32(p1 : WritingBuffer, p2 : Int) : Void;
	static function write_TYPE_SFIXED64(p1 : WritingBuffer, p2 : Int64) : Void;
	static function write_TYPE_SINT32(p1 : WritingBuffer, p2 : Int) : Void;
	static function write_TYPE_SINT64(p1 : WritingBuffer, p2 : Int64) : Void;
	static function write_TYPE_STRING(p1 : WritingBuffer, p2 : String) : Void;
	static function write_TYPE_UINT32(p1 : WritingBuffer, p2 : UInt) : Void;
	static function write_TYPE_UINT64(p1 : WritingBuffer, p2 : UInt64) : Void;
}
