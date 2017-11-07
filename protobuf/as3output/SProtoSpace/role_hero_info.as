package SProtoSpace {
	import com.netease.protobuf.*;
	use namespace com.netease.protobuf.used_by_generated_code;
	import com.netease.protobuf.fieldDescriptors.*;
	import flash.utils.Endian;
	import flash.utils.IDataInput;
	import flash.utils.IDataOutput;
	import flash.utils.IExternalizable;
	import flash.errors.IOError;
	import SProtoSpace.hero_equip_info;
	import SProtoSpace.hero_skill_info;
	import SProtoSpace.hero_symbol_info;
	// @@protoc_insertion_point(imports)

	// @@protoc_insertion_point(class_metadata)
	public dynamic final class role_hero_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const ID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_hero_info.id", "id", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var id:uint;

		/**
		 *  @private
		 */
		public static const LEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_hero_info.level", "level", (2 << 3) | com.netease.protobuf.WireType.VARINT);

		private var level$field:int;

		private var hasField$0:uint = 0;

		public function clearLevel():void {
			hasField$0 &= 0xfffffffe;
			level$field = new int();
		}

		public function get hasLevel():Boolean {
			return (hasField$0 & 0x1) != 0;
		}

		public function set level(value:int):void {
			hasField$0 |= 0x1;
			level$field = value;
		}

		public function get level():int {
			return level$field;
		}

		/**
		 *  @private
		 */
		public static const HP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_hero_info.hp", "hp", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var hp$field:int;

		public function clearHp():void {
			hasField$0 &= 0xfffffffd;
			hp$field = new int();
		}

		public function get hasHp():Boolean {
			return (hasField$0 & 0x2) != 0;
		}

		public function set hp(value:int):void {
			hasField$0 |= 0x2;
			hp$field = value;
		}

		public function get hp():int {
			return hp$field;
		}

		/**
		 *  @private
		 */
		public static const EXP:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_hero_info.exp", "exp", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		private var exp$field:uint;

		public function clearExp():void {
			hasField$0 &= 0xfffffffb;
			exp$field = new uint();
		}

		public function get hasExp():Boolean {
			return (hasField$0 & 0x4) != 0;
		}

		public function set exp(value:uint):void {
			hasField$0 |= 0x4;
			exp$field = value;
		}

		public function get exp():uint {
			return exp$field;
		}

		/**
		 *  @private
		 */
		public static const STARNUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_hero_info.starnum", "starnum", (10 << 3) | com.netease.protobuf.WireType.VARINT);

		private var starnum$field:int;

		public function clearStarnum():void {
			hasField$0 &= 0xfffffff7;
			starnum$field = new int();
		}

		public function get hasStarnum():Boolean {
			return (hasField$0 & 0x8) != 0;
		}

		public function set starnum(value:int):void {
			hasField$0 |= 0x8;
			starnum$field = value;
		}

		public function get starnum():int {
			return starnum$field;
		}

		/**
		 *  @private
		 */
		public static const QUALITY:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_hero_info.quality", "quality", (11 << 3) | com.netease.protobuf.WireType.VARINT);

		private var quality$field:int;

		public function clearQuality():void {
			hasField$0 &= 0xffffffef;
			quality$field = new int();
		}

		public function get hasQuality():Boolean {
			return (hasField$0 & 0x10) != 0;
		}

		public function set quality(value:int):void {
			hasField$0 |= 0x10;
			quality$field = value;
		}

		public function get quality():int {
			return quality$field;
		}

		/**
		 *  @private
		 */
		public static const SKILLS:RepeatedFieldDescriptor_TYPE_MESSAGE = new RepeatedFieldDescriptor_TYPE_MESSAGE("SProtoSpace.role_hero_info.skills", "skills", (12 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.hero_skill_info; });

		[ArrayElementType("SProtoSpace.hero_skill_info")]
		public var skills:Array = [];

		/**
		 *  @private
		 */
		public static const EQUIPS:RepeatedFieldDescriptor_TYPE_MESSAGE = new RepeatedFieldDescriptor_TYPE_MESSAGE("SProtoSpace.role_hero_info.equips", "equips", (13 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.hero_equip_info; });

		[ArrayElementType("SProtoSpace.hero_equip_info")]
		public var equips:Array = [];

		/**
		 *  @private
		 */
		public static const SYMBOLS:RepeatedFieldDescriptor_TYPE_MESSAGE = new RepeatedFieldDescriptor_TYPE_MESSAGE("SProtoSpace.role_hero_info.symbols", "symbols", (14 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.hero_symbol_info; });

		[ArrayElementType("SProtoSpace.hero_symbol_info")]
		public var symbols:Array = [];

		/**
		 *  @private
		 */
		public static const ARENA_FLAG:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_hero_info.arena_flag", "arenaFlag", (15 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arena_flag$field:int;

		public function clearArenaFlag():void {
			hasField$0 &= 0xffffffdf;
			arena_flag$field = new int();
		}

		public function get hasArenaFlag():Boolean {
			return (hasField$0 & 0x20) != 0;
		}

		public function set arenaFlag(value:int):void {
			hasField$0 |= 0x20;
			arena_flag$field = value;
		}

		public function get arenaFlag():int {
			return arena_flag$field;
		}

		/**
		 *  @private
		 */
		public static const BIT_DESTINY:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_hero_info.bit_destiny", "bitDestiny", (16 << 3) | com.netease.protobuf.WireType.VARINT);

		private var bit_destiny$field:int;

		public function clearBitDestiny():void {
			hasField$0 &= 0xffffffbf;
			bit_destiny$field = new int();
		}

		public function get hasBitDestiny():Boolean {
			return (hasField$0 & 0x40) != 0;
		}

		public function set bitDestiny(value:int):void {
			hasField$0 |= 0x40;
			bit_destiny$field = value;
		}

		public function get bitDestiny():int {
			return bit_destiny$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.id);
			if (hasLevel) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 2);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, level$field);
			}
			if (hasHp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, hp$field);
			}
			if (hasExp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, exp$field);
			}
			if (hasStarnum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 10);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, starnum$field);
			}
			if (hasQuality) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 11);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, quality$field);
			}
			for (var skills$index:uint = 0; skills$index < this.skills.length; ++skills$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 12);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, this.skills[skills$index]);
			}
			for (var equips$index:uint = 0; equips$index < this.equips.length; ++equips$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 13);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, this.equips[equips$index]);
			}
			for (var symbols$index:uint = 0; symbols$index < this.symbols.length; ++symbols$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 14);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, this.symbols[symbols$index]);
			}
			if (hasArenaFlag) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 15);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, arena_flag$field);
			}
			if (hasBitDestiny) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 16);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, bit_destiny$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var id$count:uint = 0;
			var level$count:uint = 0;
			var hp$count:uint = 0;
			var exp$count:uint = 0;
			var starnum$count:uint = 0;
			var quality$count:uint = 0;
			var arena_flag$count:uint = 0;
			var bit_destiny$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (id$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_hero_info.id cannot be set twice.');
					}
					++id$count;
					this.id = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 2:
					if (level$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_hero_info.level cannot be set twice.');
					}
					++level$count;
					this.level = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 3:
					if (hp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_hero_info.hp cannot be set twice.');
					}
					++hp$count;
					this.hp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 4:
					if (exp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_hero_info.exp cannot be set twice.');
					}
					++exp$count;
					this.exp = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 10:
					if (starnum$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_hero_info.starnum cannot be set twice.');
					}
					++starnum$count;
					this.starnum = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 11:
					if (quality$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_hero_info.quality cannot be set twice.');
					}
					++quality$count;
					this.quality = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 12:
					this.skills.push(com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, new SProtoSpace.hero_skill_info()));
					break;
				case 13:
					this.equips.push(com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, new SProtoSpace.hero_equip_info()));
					break;
				case 14:
					this.symbols.push(com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, new SProtoSpace.hero_symbol_info()));
					break;
				case 15:
					if (arena_flag$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_hero_info.arenaFlag cannot be set twice.');
					}
					++arena_flag$count;
					this.arenaFlag = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 16:
					if (bit_destiny$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_hero_info.bitDestiny cannot be set twice.');
					}
					++bit_destiny$count;
					this.bitDestiny = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
