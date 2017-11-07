package com.netease.protobuf;

extern class Message {
	function new() : Void;
	function mergeDelimitedFrom(p1 : flash.utils.IDataInput) : Void;
	function mergeFrom(p1 : flash.utils.IDataInput) : Void;
	function readFromSlice(p1 : flash.utils.IDataInput, p2 : UInt) : Void;
	function toString() : String;
	function writeDelimitedTo(p1 : flash.utils.IDataOutput) : Void;
	function writeTo(p1 : flash.utils.IDataOutput) : Void;
	function writeToBuffer(p1 : WritingBuffer) : Void;
	static function getExtensionByName(p1 : String) : IFieldDescriptor;
}
