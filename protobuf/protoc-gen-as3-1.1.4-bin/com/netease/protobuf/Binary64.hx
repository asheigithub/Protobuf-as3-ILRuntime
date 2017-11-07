package com.netease.protobuf;

extern class Binary64 {
	var internalHigh : UInt;
	var low : UInt;
	function new(p1 : UInt = 0, p2 : UInt = 0) : Void;
	function add(p1 : UInt) : Void;
	function bitwiseNot() : Void;
	function div(p1 : UInt) : UInt;
	function mul(p1 : UInt) : Void;
	static var CHAR_CODE_0 : UInt;
	static var CHAR_CODE_9 : UInt;
	static var CHAR_CODE_A : UInt;
	static var CHAR_CODE_Z : UInt;
}
