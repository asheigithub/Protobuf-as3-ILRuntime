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
	public dynamic final class reconnect_to_check_info_req extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const LLID:FieldDescriptor_TYPE_UINT64 = new FieldDescriptor_TYPE_UINT64("SProtoSpace.reconnect_to_check_info_req.llid", "llid", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var llid:UInt64;

		/**
		 *  @private
		 */
		public static const ACCOUNT:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.reconnect_to_check_info_req.account", "account", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var account:String;

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT64(output, this.llid);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.account);
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var llid$count:uint = 0;
			var account$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (llid$count != 0) {
						throw new flash.errors.IOError('Bad data format: reconnect_to_check_info_req.llid cannot be set twice.');
					}
					++llid$count;
					this.llid = com.netease.protobuf.ReadUtils.read_TYPE_UINT64(input);
					break;
				case 2:
					if (account$count != 0) {
						throw new flash.errors.IOError('Bad data format: reconnect_to_check_info_req.account cannot be set twice.');
					}
					++account$count;
					this.account = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
