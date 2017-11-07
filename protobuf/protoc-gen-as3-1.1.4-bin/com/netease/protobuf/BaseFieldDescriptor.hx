package com.netease.protobuf;

extern class BaseFieldDescriptor implements IFieldDescriptor {
	var fullName : String;
	var name(default,never) : String;
	var tagNumber(default,never) : UInt;
	var type(default,never) : Class<Dynamic>;
	function new() : Void;
	function readSingleField(p1 : flash.utils.IDataInput) : Dynamic;
	function toString() : String;
	function write(p1 : WritingBuffer, p2 : Message) : Void;
	function writeSingleField(p1 : WritingBuffer, p2 : Dynamic) : Void;
	static function getExtensionByName(p1 : String) : BaseFieldDescriptor;
}
