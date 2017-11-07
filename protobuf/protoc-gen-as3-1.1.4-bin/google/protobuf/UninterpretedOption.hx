package google.protobuf;

@:final extern class UninterpretedOption extends com.netease.protobuf.Message implements Dynamic {
	var aggregateValue : String;
	var doubleValue : Float;
	var hasAggregateValue(default,never) : Bool;
	var hasDoubleValue(default,never) : Bool;
	var hasIdentifierValue(default,never) : Bool;
	var hasNegativeIntValue(default,never) : Bool;
	var hasPositiveIntValue(default,never) : Bool;
	var hasStringValue(default,never) : Bool;
	var identifierValue : String;
	var name : Array<Dynamic>;
	var negativeIntValue : com.netease.protobuf.Int64;
	var positiveIntValue : com.netease.protobuf.UInt64;
	var stringValue : flash.utils.ByteArray;
	function new() : Void;
	function clearAggregateValue() : Void;
	function clearDoubleValue() : Void;
	function clearIdentifierValue() : Void;
	function clearNegativeIntValue() : Void;
	function clearPositiveIntValue() : Void;
	function clearStringValue() : Void;
	static var AGGREGATE_VALUE : com.netease.protobuf.fieldDescriptors.FieldDescriptor_TYPE_STRING;
	static var DOUBLE_VALUE : com.netease.protobuf.fieldDescriptors.FieldDescriptor_TYPE_DOUBLE;
	static var IDENTIFIER_VALUE : com.netease.protobuf.fieldDescriptors.FieldDescriptor_TYPE_STRING;
	static var NAME : com.netease.protobuf.fieldDescriptors.RepeatedFieldDescriptor_TYPE_MESSAGE;
	static var NEGATIVE_INT_VALUE : com.netease.protobuf.fieldDescriptors.FieldDescriptor_TYPE_INT64;
	static var POSITIVE_INT_VALUE : com.netease.protobuf.fieldDescriptors.FieldDescriptor_TYPE_UINT64;
	static var STRING_VALUE : com.netease.protobuf.fieldDescriptors.FieldDescriptor_TYPE_BYTES;
}
