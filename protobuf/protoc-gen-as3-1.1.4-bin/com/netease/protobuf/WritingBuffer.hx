package com.netease.protobuf;

@:final extern class WritingBuffer extends flash.utils.ByteArray {
	function new() : Void;
	function beginBlock() : UInt;
	function endBlock(p1 : UInt) : Void;
	function toNormal(p1 : flash.utils.IDataOutput) : Void;
}
