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
	public dynamic final class db_role_base_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const LEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.db_role_base_info.level", "level", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var level:int;

		/**
		 *  @private
		 */
		public static const GAMEID:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.db_role_base_info.gameid", "gameid", (2 << 3) | com.netease.protobuf.WireType.VARINT);

		public var gameid:int;

		/**
		 *  @private
		 */
		public static const ACCOUNT:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.db_role_base_info.account", "account", (3 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var account:String;

		/**
		 *  @private
		 */
		public static const VP:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.db_role_base_info.vp", "vp", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		public var vp:uint;

		/**
		 *  @private
		 */
		public static const VP_UPDATE_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.db_role_base_info.vp_update_time", "vpUpdateTime", (5 << 3) | com.netease.protobuf.WireType.VARINT);

		public var vpUpdateTime:uint;

		/**
		 *  @private
		 */
		public static const EXP:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.db_role_base_info.exp", "exp", (6 << 3) | com.netease.protobuf.WireType.VARINT);

		public var exp:uint;

		/**
		 *  @private
		 */
		public static const COIN:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.db_role_base_info.coin", "coin", (7 << 3) | com.netease.protobuf.WireType.VARINT);

		private var coin$field:uint;

		private var hasField$0:uint = 0;

		public function clearCoin():void {
			hasField$0 &= 0xfffffffe;
			coin$field = new uint();
		}

		public function get hasCoin():Boolean {
			return (hasField$0 & 0x1) != 0;
		}

		public function set coin(value:uint):void {
			hasField$0 |= 0x1;
			coin$field = value;
		}

		public function get coin():uint {
			return coin$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.db_role_base_info.diamond", "diamond", (8 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond$field:uint;

		public function clearDiamond():void {
			hasField$0 &= 0xfffffffd;
			diamond$field = new uint();
		}

		public function get hasDiamond():Boolean {
			return (hasField$0 & 0x2) != 0;
		}

		public function set diamond(value:uint):void {
			hasField$0 |= 0x2;
			diamond$field = value;
		}

		public function get diamond():uint {
			return diamond$field;
		}

		/**
		 *  @private
		 */
		public static const VIPLEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.db_role_base_info.viplevel", "viplevel", (9 << 3) | com.netease.protobuf.WireType.VARINT);

		private var viplevel$field:int;

		public function clearViplevel():void {
			hasField$0 &= 0xfffffffb;
			viplevel$field = new int();
		}

		public function get hasViplevel():Boolean {
			return (hasField$0 & 0x4) != 0;
		}

		public function set viplevel(value:int):void {
			hasField$0 |= 0x4;
			viplevel$field = value;
		}

		public function get viplevel():int {
			return viplevel$field;
		}

		/**
		 *  @private
		 */
		public static const VIPEXP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.db_role_base_info.vipexp", "vipexp", (10 << 3) | com.netease.protobuf.WireType.VARINT);

		private var vipexp$field:int;

		public function clearVipexp():void {
			hasField$0 &= 0xfffffff7;
			vipexp$field = new int();
		}

		public function get hasVipexp():Boolean {
			return (hasField$0 & 0x8) != 0;
		}

		public function set vipexp(value:int):void {
			hasField$0 |= 0x8;
			vipexp$field = value;
		}

		public function get vipexp():int {
			return vipexp$field;
		}

		/**
		 *  @private
		 */
		public static const LASTLEAVETIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.db_role_base_info.lastleavetime", "lastleavetime", (11 << 3) | com.netease.protobuf.WireType.VARINT);

		private var lastleavetime$field:uint;

		public function clearLastleavetime():void {
			hasField$0 &= 0xffffffef;
			lastleavetime$field = new uint();
		}

		public function get hasLastleavetime():Boolean {
			return (hasField$0 & 0x10) != 0;
		}

		public function set lastleavetime(value:uint):void {
			hasField$0 |= 0x10;
			lastleavetime$field = value;
		}

		public function get lastleavetime():uint {
			return lastleavetime$field;
		}

		/**
		 *  @private
		 */
		public static const DECOMPOSE_COIN:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.db_role_base_info.decompose_coin", "decomposeCoin", (12 << 3) | com.netease.protobuf.WireType.VARINT);

		private var decompose_coin$field:int;

		public function clearDecomposeCoin():void {
			hasField$0 &= 0xffffffdf;
			decompose_coin$field = new int();
		}

		public function get hasDecomposeCoin():Boolean {
			return (hasField$0 & 0x20) != 0;
		}

		public function set decomposeCoin(value:int):void {
			hasField$0 |= 0x20;
			decompose_coin$field = value;
		}

		public function get decomposeCoin():int {
			return decompose_coin$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.level);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.gameid);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 3);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.account);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.vp);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 5);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.vpUpdateTime);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 6);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.exp);
			if (hasCoin) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, coin$field);
			}
			if (hasDiamond) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 8);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, diamond$field);
			}
			if (hasViplevel) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 9);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, viplevel$field);
			}
			if (hasVipexp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 10);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, vipexp$field);
			}
			if (hasLastleavetime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 11);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, lastleavetime$field);
			}
			if (hasDecomposeCoin) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 12);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, decompose_coin$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var level$count:uint = 0;
			var gameid$count:uint = 0;
			var account$count:uint = 0;
			var vp$count:uint = 0;
			var vp_update_time$count:uint = 0;
			var exp$count:uint = 0;
			var coin$count:uint = 0;
			var diamond$count:uint = 0;
			var viplevel$count:uint = 0;
			var vipexp$count:uint = 0;
			var lastleavetime$count:uint = 0;
			var decompose_coin$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (level$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.level cannot be set twice.');
					}
					++level$count;
					this.level = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 2:
					if (gameid$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.gameid cannot be set twice.');
					}
					++gameid$count;
					this.gameid = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 3:
					if (account$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.account cannot be set twice.');
					}
					++account$count;
					this.account = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 4:
					if (vp$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.vp cannot be set twice.');
					}
					++vp$count;
					this.vp = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 5:
					if (vp_update_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.vpUpdateTime cannot be set twice.');
					}
					++vp_update_time$count;
					this.vpUpdateTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 6:
					if (exp$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.exp cannot be set twice.');
					}
					++exp$count;
					this.exp = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 7:
					if (coin$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.coin cannot be set twice.');
					}
					++coin$count;
					this.coin = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 8:
					if (diamond$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.diamond cannot be set twice.');
					}
					++diamond$count;
					this.diamond = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 9:
					if (viplevel$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.viplevel cannot be set twice.');
					}
					++viplevel$count;
					this.viplevel = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 10:
					if (vipexp$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.vipexp cannot be set twice.');
					}
					++vipexp$count;
					this.vipexp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 11:
					if (lastleavetime$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.lastleavetime cannot be set twice.');
					}
					++lastleavetime$count;
					this.lastleavetime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 12:
					if (decompose_coin$count != 0) {
						throw new flash.errors.IOError('Bad data format: db_role_base_info.decomposeCoin cannot be set twice.');
					}
					++decompose_coin$count;
					this.decomposeCoin = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
