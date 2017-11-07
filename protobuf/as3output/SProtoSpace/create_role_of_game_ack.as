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
	public dynamic final class create_role_of_game_ack extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const CREATE_RET:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.create_role_of_game_ack.create_ret", "createRet", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		public var createRet:int;

		/**
		 *  @private
		 */
		public static const ACCOUNT:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.create_role_of_game_ack.account", "account", (1 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		private var account$field:String;

		public function clearAccount():void {
			account$field = null;
		}

		public function get hasAccount():Boolean {
			return account$field != null;
		}

		public function set account(value:String):void {
			account$field = value;
		}

		public function get account():String {
			return account$field;
		}

		/**
		 *  @private
		 */
		public static const PLAYERNAME:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.create_role_of_game_ack.playername", "playername", (3 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var playername:String;

		/**
		 *  @private
		 */
		public static const PLAYERID:FieldDescriptor_TYPE_UINT64 = new FieldDescriptor_TYPE_UINT64("SProtoSpace.create_role_of_game_ack.playerid", "playerid", (5 << 3) | com.netease.protobuf.WireType.VARINT);

		private var playerid$field:UInt64;

		public function clearPlayerid():void {
			playerid$field = null;
		}

		public function get hasPlayerid():Boolean {
			return playerid$field != null;
		}

		public function set playerid(value:UInt64):void {
			playerid$field = value;
		}

		public function get playerid():UInt64 {
			return playerid$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.createRet);
			if (hasAccount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 1);
				com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, account$field);
			}
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 3);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.playername);
			if (hasPlayerid) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 5);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT64(output, playerid$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var create_ret$count:uint = 0;
			var account$count:uint = 0;
			var playername$count:uint = 0;
			var playerid$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 4:
					if (create_ret$count != 0) {
						throw new flash.errors.IOError('Bad data format: create_role_of_game_ack.createRet cannot be set twice.');
					}
					++create_ret$count;
					this.createRet = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 1:
					if (account$count != 0) {
						throw new flash.errors.IOError('Bad data format: create_role_of_game_ack.account cannot be set twice.');
					}
					++account$count;
					this.account = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 3:
					if (playername$count != 0) {
						throw new flash.errors.IOError('Bad data format: create_role_of_game_ack.playername cannot be set twice.');
					}
					++playername$count;
					this.playername = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 5:
					if (playerid$count != 0) {
						throw new flash.errors.IOError('Bad data format: create_role_of_game_ack.playerid cannot be set twice.');
					}
					++playerid$count;
					this.playerid = com.netease.protobuf.ReadUtils.read_TYPE_UINT64(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
