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
	public dynamic final class change_name_check_ack extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const NEW_NAME:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.change_name_check_ack.new_name", "newName", (1 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var newName:String;

		/**
		 *  @private
		 */
		public static const OLD_NAME:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.change_name_check_ack.old_name", "oldName", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var oldName:String;

		/**
		 *  @private
		 */
		public static const CLIENTID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.change_name_check_ack.clientid", "clientid", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		public var clientid:uint;

		/**
		 *  @private
		 */
		public static const RET:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.change_name_check_ack.ret", "ret", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		public var ret:int;

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.newName);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.oldName);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.clientid);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.ret);
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var new_name$count:uint = 0;
			var old_name$count:uint = 0;
			var clientid$count:uint = 0;
			var ret$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (new_name$count != 0) {
						throw new flash.errors.IOError('Bad data format: change_name_check_ack.newName cannot be set twice.');
					}
					++new_name$count;
					this.newName = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 2:
					if (old_name$count != 0) {
						throw new flash.errors.IOError('Bad data format: change_name_check_ack.oldName cannot be set twice.');
					}
					++old_name$count;
					this.oldName = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 3:
					if (clientid$count != 0) {
						throw new flash.errors.IOError('Bad data format: change_name_check_ack.clientid cannot be set twice.');
					}
					++clientid$count;
					this.clientid = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 4:
					if (ret$count != 0) {
						throw new flash.errors.IOError('Bad data format: change_name_check_ack.ret cannot be set twice.');
					}
					++ret$count;
					this.ret = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
