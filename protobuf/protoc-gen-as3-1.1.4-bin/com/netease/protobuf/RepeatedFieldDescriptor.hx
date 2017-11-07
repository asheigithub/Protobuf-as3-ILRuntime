package com.netease.protobuf;

extern class RepeatedFieldDescriptor extends BaseFieldDescriptor {
	var elementType(default,never) : Class<Dynamic>;
	var nonPackedWireType(default,never) : Int;
	function new() : Void;
	function readNonPacked(p1 : flash.utils.IDataInput, p2 : Message) : Void;
	function readPacked(p1 : flash.utils.IDataInput, p2 : Message) : Void;
}
