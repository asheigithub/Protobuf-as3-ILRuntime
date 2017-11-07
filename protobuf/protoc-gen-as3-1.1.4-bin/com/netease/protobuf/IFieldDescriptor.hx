package com.netease.protobuf;

extern interface IFieldDescriptor {
	var name(default,never) : String;
	var tagNumber(default,never) : UInt;
	var type(default,never) : Class<Dynamic>;
}
