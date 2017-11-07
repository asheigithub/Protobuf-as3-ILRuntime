package com.netease.protobuf;

@:final extern class UInt64 extends Binary64 {
	var high : UInt;
	function new(p1 : UInt = 0, p2 : UInt = 0) : Void;
	function toNumber() : Float;
	function toString(p1 : UInt = 10) : String;
	static function fromNumber(p1 : Float) : UInt64;
	static function parseUInt64(p1 : String, p2 : UInt = 0) : UInt64;
}
