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
	public dynamic final class friend_base_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const PLAYER_ID:FieldDescriptor_TYPE_UINT64 = new FieldDescriptor_TYPE_UINT64("SProtoSpace.friend_base_info.player_id", "playerId", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		private var player_id$field:UInt64;

		public function clearPlayerId():void {
			player_id$field = null;
		}

		public function get hasPlayerId():Boolean {
			return player_id$field != null;
		}

		public function set playerId(value:UInt64):void {
			player_id$field = value;
		}

		public function get playerId():UInt64 {
			return player_id$field;
		}

		/**
		 *  @private
		 */
		public static const PLAYER_NAME:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.friend_base_info.player_name", "playerName", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		private var player_name$field:String;

		public function clearPlayerName():void {
			player_name$field = null;
		}

		public function get hasPlayerName():Boolean {
			return player_name$field != null;
		}

		public function set playerName(value:String):void {
			player_name$field = value;
		}

		public function get playerName():String {
			return player_name$field;
		}

		/**
		 *  @private
		 */
		public static const PLAYER_LV:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.friend_base_info.player_lv", "playerLv", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var player_lv$field:int;

		private var hasField$0:uint = 0;

		public function clearPlayerLv():void {
			hasField$0 &= 0xfffffffe;
			player_lv$field = new int();
		}

		public function get hasPlayerLv():Boolean {
			return (hasField$0 & 0x1) != 0;
		}

		public function set playerLv(value:int):void {
			hasField$0 |= 0x1;
			player_lv$field = value;
		}

		public function get playerLv():int {
			return player_lv$field;
		}

		/**
		 *  @private
		 */
		public static const TEMPLATE_ID:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.friend_base_info.template_id", "templateId", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		private var template_id$field:int;

		public function clearTemplateId():void {
			hasField$0 &= 0xfffffffd;
			template_id$field = new int();
		}

		public function get hasTemplateId():Boolean {
			return (hasField$0 & 0x2) != 0;
		}

		public function set templateId(value:int):void {
			hasField$0 |= 0x2;
			template_id$field = value;
		}

		public function get templateId():int {
			return template_id$field;
		}

		/**
		 *  @private
		 */
		public static const VIP_LV:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.friend_base_info.vip_lv", "vipLv", (5 << 3) | com.netease.protobuf.WireType.VARINT);

		private var vip_lv$field:int;

		public function clearVipLv():void {
			hasField$0 &= 0xfffffffb;
			vip_lv$field = new int();
		}

		public function get hasVipLv():Boolean {
			return (hasField$0 & 0x4) != 0;
		}

		public function set vipLv(value:int):void {
			hasField$0 |= 0x4;
			vip_lv$field = value;
		}

		public function get vipLv():int {
			return vip_lv$field;
		}

		/**
		 *  @private
		 */
		public static const SOCIETY_NAME:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.friend_base_info.society_name", "societyName", (6 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		private var society_name$field:String;

		public function clearSocietyName():void {
			society_name$field = null;
		}

		public function get hasSocietyName():Boolean {
			return society_name$field != null;
		}

		public function set societyName(value:String):void {
			society_name$field = value;
		}

		public function get societyName():String {
			return society_name$field;
		}

		/**
		 *  @private
		 */
		public static const TOTAL_ABILITY:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.friend_base_info.total_ability", "totalAbility", (7 << 3) | com.netease.protobuf.WireType.VARINT);

		private var total_ability$field:int;

		public function clearTotalAbility():void {
			hasField$0 &= 0xfffffff7;
			total_ability$field = new int();
		}

		public function get hasTotalAbility():Boolean {
			return (hasField$0 & 0x8) != 0;
		}

		public function set totalAbility(value:int):void {
			hasField$0 |= 0x8;
			total_ability$field = value;
		}

		public function get totalAbility():int {
			return total_ability$field;
		}

		/**
		 *  @private
		 */
		public static const IS_NEW_MSG:FieldDescriptor_TYPE_BOOL = new FieldDescriptor_TYPE_BOOL("SProtoSpace.friend_base_info.is_new_msg", "isNewMsg", (8 << 3) | com.netease.protobuf.WireType.VARINT);

		private var is_new_msg$field:Boolean;

		public function clearIsNewMsg():void {
			hasField$0 &= 0xffffffef;
			is_new_msg$field = new Boolean();
		}

		public function get hasIsNewMsg():Boolean {
			return (hasField$0 & 0x10) != 0;
		}

		public function set isNewMsg(value:Boolean):void {
			hasField$0 |= 0x10;
			is_new_msg$field = value;
		}

		public function get isNewMsg():Boolean {
			return is_new_msg$field;
		}

		/**
		 *  @private
		 */
		public static const IS_FRIEND:FieldDescriptor_TYPE_BOOL = new FieldDescriptor_TYPE_BOOL("SProtoSpace.friend_base_info.is_friend", "isFriend", (9 << 3) | com.netease.protobuf.WireType.VARINT);

		private var is_friend$field:Boolean;

		public function clearIsFriend():void {
			hasField$0 &= 0xffffffdf;
			is_friend$field = new Boolean();
		}

		public function get hasIsFriend():Boolean {
			return (hasField$0 & 0x20) != 0;
		}

		public function set isFriend(value:Boolean):void {
			hasField$0 |= 0x20;
			is_friend$field = value;
		}

		public function get isFriend():Boolean {
			return is_friend$field;
		}

		/**
		 *  @private
		 */
		public static const OFFLINE_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.friend_base_info.offline_time", "offlineTime", (10 << 3) | com.netease.protobuf.WireType.VARINT);

		private var offline_time$field:uint;

		public function clearOfflineTime():void {
			hasField$0 &= 0xffffffbf;
			offline_time$field = new uint();
		}

		public function get hasOfflineTime():Boolean {
			return (hasField$0 & 0x40) != 0;
		}

		public function set offlineTime(value:uint):void {
			hasField$0 |= 0x40;
			offline_time$field = value;
		}

		public function get offlineTime():uint {
			return offline_time$field;
		}

		/**
		 *  @private
		 */
		public static const IS_CAN_GIVE:FieldDescriptor_TYPE_BOOL = new FieldDescriptor_TYPE_BOOL("SProtoSpace.friend_base_info.is_can_give", "isCanGive", (11 << 3) | com.netease.protobuf.WireType.VARINT);

		private var is_can_give$field:Boolean;

		public function clearIsCanGive():void {
			hasField$0 &= 0xffffff7f;
			is_can_give$field = new Boolean();
		}

		public function get hasIsCanGive():Boolean {
			return (hasField$0 & 0x80) != 0;
		}

		public function set isCanGive(value:Boolean):void {
			hasField$0 |= 0x80;
			is_can_give$field = value;
		}

		public function get isCanGive():Boolean {
			return is_can_give$field;
		}

		/**
		 *  @private
		 */
		public static const DATA_TYPE:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.friend_base_info.data_type", "dataType", (12 << 3) | com.netease.protobuf.WireType.VARINT);

		private var data_type$field:uint;

		public function clearDataType():void {
			hasField$0 &= 0xfffffeff;
			data_type$field = new uint();
		}

		public function get hasDataType():Boolean {
			return (hasField$0 & 0x100) != 0;
		}

		public function set dataType(value:uint):void {
			hasField$0 |= 0x100;
			data_type$field = value;
		}

		public function get dataType():uint {
			if(!hasDataType) {
				return 0;
			}
			return data_type$field;
		}

		/**
		 *  @private
		 */
		public static const CARAVAN_ID:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.friend_base_info.caravan_id", "caravanId", (13 << 3) | com.netease.protobuf.WireType.VARINT);

		private var caravan_id$field:int;

		public function clearCaravanId():void {
			hasField$0 &= 0xfffffdff;
			caravan_id$field = new int();
		}

		public function get hasCaravanId():Boolean {
			return (hasField$0 & 0x200) != 0;
		}

		public function set caravanId(value:int):void {
			hasField$0 |= 0x200;
			caravan_id$field = value;
		}

		public function get caravanId():int {
			if(!hasCaravanId) {
				return 0;
			}
			return caravan_id$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			if (hasPlayerId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT64(output, player_id$field);
			}
			if (hasPlayerName) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
				com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, player_name$field);
			}
			if (hasPlayerLv) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, player_lv$field);
			}
			if (hasTemplateId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, template_id$field);
			}
			if (hasVipLv) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 5);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, vip_lv$field);
			}
			if (hasSocietyName) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 6);
				com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, society_name$field);
			}
			if (hasTotalAbility) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, total_ability$field);
			}
			if (hasIsNewMsg) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 8);
				com.netease.protobuf.WriteUtils.write_TYPE_BOOL(output, is_new_msg$field);
			}
			if (hasIsFriend) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 9);
				com.netease.protobuf.WriteUtils.write_TYPE_BOOL(output, is_friend$field);
			}
			if (hasOfflineTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 10);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, offline_time$field);
			}
			if (hasIsCanGive) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 11);
				com.netease.protobuf.WriteUtils.write_TYPE_BOOL(output, is_can_give$field);
			}
			if (hasDataType) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 12);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, data_type$field);
			}
			if (hasCaravanId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 13);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, caravan_id$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var player_id$count:uint = 0;
			var player_name$count:uint = 0;
			var player_lv$count:uint = 0;
			var template_id$count:uint = 0;
			var vip_lv$count:uint = 0;
			var society_name$count:uint = 0;
			var total_ability$count:uint = 0;
			var is_new_msg$count:uint = 0;
			var is_friend$count:uint = 0;
			var offline_time$count:uint = 0;
			var is_can_give$count:uint = 0;
			var data_type$count:uint = 0;
			var caravan_id$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (player_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.playerId cannot be set twice.');
					}
					++player_id$count;
					this.playerId = com.netease.protobuf.ReadUtils.read_TYPE_UINT64(input);
					break;
				case 2:
					if (player_name$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.playerName cannot be set twice.');
					}
					++player_name$count;
					this.playerName = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 3:
					if (player_lv$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.playerLv cannot be set twice.');
					}
					++player_lv$count;
					this.playerLv = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 4:
					if (template_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.templateId cannot be set twice.');
					}
					++template_id$count;
					this.templateId = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 5:
					if (vip_lv$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.vipLv cannot be set twice.');
					}
					++vip_lv$count;
					this.vipLv = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 6:
					if (society_name$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.societyName cannot be set twice.');
					}
					++society_name$count;
					this.societyName = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 7:
					if (total_ability$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.totalAbility cannot be set twice.');
					}
					++total_ability$count;
					this.totalAbility = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 8:
					if (is_new_msg$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.isNewMsg cannot be set twice.');
					}
					++is_new_msg$count;
					this.isNewMsg = com.netease.protobuf.ReadUtils.read_TYPE_BOOL(input);
					break;
				case 9:
					if (is_friend$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.isFriend cannot be set twice.');
					}
					++is_friend$count;
					this.isFriend = com.netease.protobuf.ReadUtils.read_TYPE_BOOL(input);
					break;
				case 10:
					if (offline_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.offlineTime cannot be set twice.');
					}
					++offline_time$count;
					this.offlineTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 11:
					if (is_can_give$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.isCanGive cannot be set twice.');
					}
					++is_can_give$count;
					this.isCanGive = com.netease.protobuf.ReadUtils.read_TYPE_BOOL(input);
					break;
				case 12:
					if (data_type$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.dataType cannot be set twice.');
					}
					++data_type$count;
					this.dataType = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 13:
					if (caravan_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: friend_base_info.caravanId cannot be set twice.');
					}
					++caravan_id$count;
					this.caravanId = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
