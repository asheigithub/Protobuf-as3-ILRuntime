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
	public dynamic final class group_player_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const PLAYERID:FieldDescriptor_TYPE_UINT64 = new FieldDescriptor_TYPE_UINT64("SProtoSpace.group_player_info.playerid", "playerid", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var playerid:UInt64;

		/**
		 *  @private
		 */
		public static const PLAYERNAME:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.group_player_info.playername", "playername", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		private var playername$field:String;

		public function clearPlayername():void {
			playername$field = null;
		}

		public function get hasPlayername():Boolean {
			return playername$field != null;
		}

		public function set playername(value:String):void {
			playername$field = value;
		}

		public function get playername():String {
			return playername$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT64(output, this.playerid);
			if (hasPlayername) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
				com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, playername$field);
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
			var playername$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (playerid$count != 0) {
						throw new flash.errors.IOError('Bad data format: group_player_info.playerid cannot be set twice.');
					}
					++playerid$count;
					this.playerid = com.netease.protobuf.ReadUtils.read_TYPE_UINT64(input);
					break;
				case 2:
					if (playername$count != 0) {
						throw new flash.errors.IOError('Bad data format: group_player_info.playername cannot be set twice.');
					}
					++playername$count;
					this.playername = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
