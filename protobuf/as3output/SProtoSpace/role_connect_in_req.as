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
	public dynamic final class role_connect_in_req extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const PLAYERID:FieldDescriptor_TYPE_UINT64 = new FieldDescriptor_TYPE_UINT64("SProtoSpace.role_connect_in_req.playerid", "playerid", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var playerid:UInt64;

		/**
		 *  @private
		 */
		public static const ACCOUNT:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.role_connect_in_req.account", "account", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var account:String;

		/**
		 *  @private
		 */
		public static const CHECK_SERVER_ID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_connect_in_req.check_server_id", "checkServerId", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var check_server_id$field:uint;

		private var hasField$0:uint = 0;

		public function clearCheckServerId():void {
			hasField$0 &= 0xfffffffe;
			check_server_id$field = new uint();
		}

		public function get hasCheckServerId():Boolean {
			return (hasField$0 & 0x1) != 0;
		}

		public function set checkServerId(value:uint):void {
			hasField$0 |= 0x1;
			check_server_id$field = value;
		}

		public function get checkServerId():uint {
			return check_server_id$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT64(output, this.playerid);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.account);
			if (hasCheckServerId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, check_server_id$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var playerid$count:uint = 0;
			var account$count:uint = 0;
			var check_server_id$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (playerid$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_connect_in_req.playerid cannot be set twice.');
					}
					++playerid$count;
					this.playerid = com.netease.protobuf.ReadUtils.read_TYPE_UINT64(input);
					break;
				case 2:
					if (account$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_connect_in_req.account cannot be set twice.');
					}
					++account$count;
					this.account = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 3:
					if (check_server_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_connect_in_req.checkServerId cannot be set twice.');
					}
					++check_server_id$count;
					this.checkServerId = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
