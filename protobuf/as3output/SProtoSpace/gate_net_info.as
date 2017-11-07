package SProtoSpace {
	import com.netease.protobuf.*;
	use namespace com.netease.protobuf.used_by_generated_code;
	import com.netease.protobuf.fieldDescriptors.*;
	import flash.utils.Endian;
	import flash.utils.IDataInput;
	import flash.utils.IDataOutput;
	import flash.utils.IExternalizable;
	import flash.errors.IOError;
	// @@protoc_insertion_point(imports)

	// @@protoc_insertion_point(class_metadata)
	public dynamic final class gate_net_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const ID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.gate_net_info.id", "id", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var id:uint;

		/**
		 *  @private
		 */
		public static const IP:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.gate_net_info.ip", "ip", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var ip:String;

		/**
		 *  @private
		 */
		public static const PORT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.gate_net_info.port", "port", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		public var port:int;

		/**
		 *  @private
		 */
		public static const GROUP_NAME:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.gate_net_info.group_name", "groupName", (4 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var groupName:String;

		/**
		 *  @private
		 */
		public static const NEW:FieldDescriptor_TYPE_BOOL = new FieldDescriptor_TYPE_BOOL("SProtoSpace.gate_net_info.new", "__new", (5 << 3) | com.netease.protobuf.WireType.VARINT);

		public var __new:Boolean;

		/**
		 *  @private
		 */
		public static const STATE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.gate_net_info.state", "state", (6 << 3) | com.netease.protobuf.WireType.VARINT);

		public var state:int;

		/**
		 *  @private
		 */
		public static const GROUPINDEX:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.gate_net_info.groupindex", "groupindex", (7 << 3) | com.netease.protobuf.WireType.VARINT);

		public var groupindex:uint;

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.id);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.ip);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.port);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 4);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.groupName);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 5);
			com.netease.protobuf.WriteUtils.write_TYPE_BOOL(output, this.__new);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 6);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.state);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.groupindex);
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var id$count:uint = 0;
			var ip$count:uint = 0;
			var port$count:uint = 0;
			var group_name$count:uint = 0;
			var new$count:uint = 0;
			var state$count:uint = 0;
			var groupindex$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (id$count != 0) {
						throw new flash.errors.IOError('Bad data format: gate_net_info.id cannot be set twice.');
					}
					++id$count;
					this.id = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 2:
					if (ip$count != 0) {
						throw new flash.errors.IOError('Bad data format: gate_net_info.ip cannot be set twice.');
					}
					++ip$count;
					this.ip = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 3:
					if (port$count != 0) {
						throw new flash.errors.IOError('Bad data format: gate_net_info.port cannot be set twice.');
					}
					++port$count;
					this.port = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 4:
					if (group_name$count != 0) {
						throw new flash.errors.IOError('Bad data format: gate_net_info.groupName cannot be set twice.');
					}
					++group_name$count;
					this.groupName = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 5:
					if (new$count != 0) {
						throw new flash.errors.IOError('Bad data format: gate_net_info.__new cannot be set twice.');
					}
					++new$count;
					this.__new = com.netease.protobuf.ReadUtils.read_TYPE_BOOL(input);
					break;
				case 6:
					if (state$count != 0) {
						throw new flash.errors.IOError('Bad data format: gate_net_info.state cannot be set twice.');
					}
					++state$count;
					this.state = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 7:
					if (groupindex$count != 0) {
						throw new flash.errors.IOError('Bad data format: gate_net_info.groupindex cannot be set twice.');
					}
					++groupindex$count;
					this.groupindex = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
