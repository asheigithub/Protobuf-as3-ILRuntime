package com.netease.protobuf;

@:final extern class Int64 extends Binary64 {
	var high : Int;
	function new(p1 : UInt = 0, p2 : Int = 0) : Void;
	function toNumber() : Float;
	function toString(p1 : UInt = 10) : String;
	static function fromNumber(p1 : Float) : Int64;
	static function parseInt64(p1 : String, p2 : UInt = 0) : Int64;
}
