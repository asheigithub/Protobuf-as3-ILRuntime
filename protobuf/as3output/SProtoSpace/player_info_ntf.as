package SProtoSpace {
	import com.netease.protobuf.*;
	use namespace com.netease.protobuf.used_by_generated_code;
	import com.netease.protobuf.fieldDescriptors.*;
	import flash.utils.Endian;
	import flash.utils.IDataInput;
	import flash.utils.IDataOutput;
	import flash.utils.IExternalizable;
	import flash.errors.IOError;
	import SProtoSpace.friend_base_info;
	// @@protoc_insertion_point(imports)

	// @@protoc_insertion_point(class_metadata)
	public dynamic final class player_info_ntf extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const INFO:FieldDescriptor_TYPE_MESSAGE = new FieldDescriptor_TYPE_MESSAGE("SProtoSpace.player_info_ntf.info", "info", (1 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.friend_base_info; });

		private var info$field:SProtoSpace.friend_base_info;

		public function clearInfo():void {
			info$field = null;
		}

		public function get hasInfo():Boolean {
			return info$field != null;
		}

		public function set info(value:SProtoSpace.friend_base_info):void {
			info$field = value;
		}

		public function get info():SProtoSpace.friend_base_info {
			return info$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			if (hasInfo) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 1);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, info$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var info$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (info$count != 0) {
						throw new flash.errors.IOError('Bad data format: player_info_ntf.info cannot be set twice.');
					}
					++info$count;
					this.info = new SProtoSpace.friend_base_info();
					com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, this.info);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
