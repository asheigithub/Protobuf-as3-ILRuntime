package com.netease.protobuf;

extern class ZigZag {
	function new() : Void;
	static function decode32(p1 : Int) : Int;
	static function decode64high(p1 : UInt, p2 : Int) : Int;
	static function decode64low(p1 : UInt, p2 : Int) : UInt;
	static function encode32(p1 : Int) : Int;
	static function encode64high(p1 : UInt, p2 : Int) : Int;
	static function encode64low(p1 : UInt, p2 : Int) : UInt;
}
