package SProtoSpace {
	import com.netease.protobuf.*;
	use namespace com.netease.protobuf.used_by_generated_code;
	import com.netease.protobuf.fieldDescriptors.*;
	import flash.utils.Endian;
	import flash.utils.IDataInput;
	import flash.utils.IDataOutput;
	import flash.utils.IExternalizable;
	import flash.errors.IOError;
	import SProtoSpace.hero_skill_info;
	// @@protoc_insertion_point(imports)

	// @@protoc_insertion_point(class_metadata)
	public dynamic final class player_hero_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const ID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.player_hero_info.id", "id", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var id:uint;

		/**
		 *  @private
		 */
		public static const LEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.player_hero_info.level", "level", (2 << 3) | com.netease.protobuf.WireType.VARINT);

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
		public static const STARNUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.player_hero_info.starnum", "starnum", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var starnum$field:int;

		public function clearStarnum():void {
			hasField$0 &= 0xfffffffd;
			starnum$field = new int();
		}

		public function get hasStarnum():Boolean {
			return (hasField$0 & 0x2) != 0;
		}

		public function set starnum(value:int):void {
			hasField$0 |= 0x2;
			starnum$field = value;
		}

		public function get starnum():int {
			return starnum$field;
		}

		/**
		 *  @private
		 */
		public static const QUALITY:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.player_hero_info.quality", "quality", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		private var quality$field:int;

		public function clearQuality():void {
			hasField$0 &= 0xfffffffb;
			quality$field = new int();
		}

		public function get hasQuality():Boolean {
			return (hasField$0 & 0x4) != 0;
		}

		public function set quality(value:int):void {
			hasField$0 |= 0x4;
			quality$field = value;
		}

		public function get quality():int {
			return quality$field;
		}

		/**
		 *  @private
		 */
		public static const SKILLS:RepeatedFieldDescriptor_TYPE_MESSAGE = new RepeatedFieldDescriptor_TYPE_MESSAGE("SProtoSpace.player_hero_info.skills", "skills", (5 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.hero_skill_info; });

		[ArrayElementType("SProtoSpace.hero_skill_info")]
		public var skills:Array = [];

		/**
		 *  @private
		 */
		public static const EQUIPS:RepeatedFieldDescriptor_TYPE_UINT32 = new RepeatedFieldDescriptor_TYPE_UINT32("SProtoSpace.player_hero_info.equips", "equips", (6 << 3) | com.netease.protobuf.WireType.VARINT);

		[ArrayElementType("uint")]
		public var equips:Array = [];

		/**
		 *  @private
		 */
		public static const HP_PERCENT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.player_hero_info.hp_percent", "hpPercent", (7 << 3) | com.netease.protobuf.WireType.VARINT);

		private var hp_percent$field:int;

		public function clearHpPercent():void {
			hasField$0 &= 0xfffffff7;
			hp_percent$field = new int();
		}

		public function get hasHpPercent():Boolean {
			return (hasField$0 & 0x8) != 0;
		}

		public function set hpPercent(value:int):void {
			hasField$0 |= 0x8;
			hp_percent$field = value;
		}

		public function get hpPercent():int {
			return hp_percent$field;
		}

		/**
		 *  @private
		 */
		public static const HP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.player_hero_info.hp", "hp", (8 << 3) | com.netease.protobuf.WireType.VARINT);

		private var hp$field:int;

		public function clearHp():void {
			hasField$0 &= 0xffffffef;
			hp$field = new int();
		}

		public function get hasHp():Boolean {
			return (hasField$0 & 0x10) != 0;
		}

		public function set hp(value:int):void {
			hasField$0 |= 0x10;
			hp$field = value;
		}

		public function get hp():int {
			return hp$field;
		}

		/**
		 *  @private
		 */
		public static const MAX_HP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.player_hero_info.max_hp", "maxHp", (9 << 3) | com.netease.protobuf.WireType.VARINT);

		private var max_hp$field:int;

		public function clearMaxHp():void {
			hasField$0 &= 0xffffffdf;
			max_hp$field = new int();
		}

		public function get hasMaxHp():Boolean {
			return (hasField$0 & 0x20) != 0;
		}

		public function set maxHp(value:int):void {
			hasField$0 |= 0x20;
			max_hp$field = value;
		}

		public function get maxHp():int {
			return max_hp$field;
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
			if (hasStarnum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, starnum$field);
			}
			if (hasQuality) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, quality$field);
			}
			for (var skills$index:uint = 0; skills$index < this.skills.length; ++skills$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 5);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, this.skills[skills$index]);
			}
			for (var equips$index:uint = 0; equips$index < this.equips.length; ++equips$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 6);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.equips[equips$index]);
			}
			if (hasHpPercent) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, hp_percent$field);
			}
			if (hasHp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 8);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, hp$field);
			}
			if (hasMaxHp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 9);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, max_hp$field);
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
			var starnum$count:uint = 0;
			var quality$count:uint = 0;
			var hp_percent$count:uint = 0;
			var hp$count:uint = 0;
			var max_hp$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (id$count != 0) {
						throw new flash.errors.IOError('Bad data format: player_hero_info.id cannot be set twice.');
					}
					++id$count;
					this.id = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 2:
					if (level$count != 0) {
						throw new flash.errors.IOError('Bad data format: player_hero_info.level cannot be set twice.');
					}
					++level$count;
					this.level = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 3:
					if (starnum$count != 0) {
						throw new flash.errors.IOError('Bad data format: player_hero_info.starnum cannot be set twice.');
					}
					++starnum$count;
					this.starnum = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 4:
					if (quality$count != 0) {
						throw new flash.errors.IOError('Bad data format: player_hero_info.quality cannot be set twice.');
					}
					++quality$count;
					this.quality = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 5:
					this.skills.push(com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, new SProtoSpace.hero_skill_info()));
					break;
				case 6:
					if ((tag & 7) == com.netease.protobuf.WireType.LENGTH_DELIMITED) {
						com.netease.protobuf.ReadUtils.readPackedRepeated(input, com.netease.protobuf.ReadUtils.read_TYPE_UINT32, this.equips);
						break;
					}
					this.equips.push(com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input));
					break;
				case 7:
					if (hp_percent$count != 0) {
						throw new flash.errors.IOError('Bad data format: player_hero_info.hpPercent cannot be set twice.');
					}
					++hp_percent$count;
					this.hpPercent = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 8:
					if (hp$count != 0) {
						throw new flash.errors.IOError('Bad data format: player_hero_info.hp cannot be set twice.');
					}
					++hp$count;
					this.hp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 9:
					if (max_hp$count != 0) {
						throw new flash.errors.IOError('Bad data format: player_hero_info.maxHp cannot be set twice.');
					}
					++max_hp$count;
					this.maxHp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
