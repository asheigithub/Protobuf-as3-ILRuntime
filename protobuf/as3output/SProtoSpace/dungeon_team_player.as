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
	public dynamic final class dungeon_team_player extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const LLID:FieldDescriptor_TYPE_UINT64 = new FieldDescriptor_TYPE_UINT64("SProtoSpace.dungeon_team_player.llId", "llId", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var llId:UInt64;

		/**
		 *  @private
		 */
		public static const NAME:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.dungeon_team_player.name", "name", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		private var name$field:String;

		public function clearName():void {
			name$field = null;
		}

		public function get hasName():Boolean {
			return name$field != null;
		}

		public function set name(value:String):void {
			name$field = value;
		}

		public function get name():String {
			return name$field;
		}

		/**
		 *  @private
		 */
		public static const STATE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.dungeon_team_player.state", "state", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var state$field:int;

		private var hasField$0:uint = 0;

		public function clearState():void {
			hasField$0 &= 0xfffffffe;
			state$field = new int();
		}

		public function get hasState():Boolean {
			return (hasField$0 & 0x1) != 0;
		}

		public function set state(value:int):void {
			hasField$0 |= 0x1;
			state$field = value;
		}

		public function get state():int {
			return state$field;
		}

		/**
		 *  @private
		 */
		public static const HERO_ID:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.dungeon_team_player.hero_id", "heroId", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		private var hero_id$field:int;

		public function clearHeroId():void {
			hasField$0 &= 0xfffffffd;
			hero_id$field = new int();
		}

		public function get hasHeroId():Boolean {
			return (hasField$0 & 0x2) != 0;
		}

		public function set heroId(value:int):void {
			hasField$0 |= 0x2;
			hero_id$field = value;
		}

		public function get heroId():int {
			return hero_id$field;
		}

		/**
		 *  @private
		 */
		public static const HERO_LEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.dungeon_team_player.hero_level", "heroLevel", (5 << 3) | com.netease.protobuf.WireType.VARINT);

		private var hero_level$field:int;

		public function clearHeroLevel():void {
			hasField$0 &= 0xfffffffb;
			hero_level$field = new int();
		}

		public function get hasHeroLevel():Boolean {
			return (hasField$0 & 0x4) != 0;
		}

		public function set heroLevel(value:int):void {
			hasField$0 |= 0x4;
			hero_level$field = value;
		}

		public function get heroLevel():int {
			return hero_level$field;
		}

		/**
		 *  @private
		 */
		public static const HERO_STAR:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.dungeon_team_player.hero_star", "heroStar", (6 << 3) | com.netease.protobuf.WireType.VARINT);

		private var hero_star$field:int;

		public function clearHeroStar():void {
			hasField$0 &= 0xfffffff7;
			hero_star$field = new int();
		}

		public function get hasHeroStar():Boolean {
			return (hasField$0 & 0x8) != 0;
		}

		public function set heroStar(value:int):void {
			hasField$0 |= 0x8;
			hero_star$field = value;
		}

		public function get heroStar():int {
			return hero_star$field;
		}

		/**
		 *  @private
		 */
		public static const HERO_QUALITY:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.dungeon_team_player.hero_quality", "heroQuality", (7 << 3) | com.netease.protobuf.WireType.VARINT);

		private var hero_quality$field:int;

		public function clearHeroQuality():void {
			hasField$0 &= 0xffffffef;
			hero_quality$field = new int();
		}

		public function get hasHeroQuality():Boolean {
			return (hasField$0 & 0x10) != 0;
		}

		public function set heroQuality(value:int):void {
			hasField$0 |= 0x10;
			hero_quality$field = value;
		}

		public function get heroQuality():int {
			return hero_quality$field;
		}

		/**
		 *  @private
		 */
		public static const BATTLE_ABILITY:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.dungeon_team_player.battle_ability", "battleAbility", (8 << 3) | com.netease.protobuf.WireType.VARINT);

		private var battle_ability$field:uint;

		public function clearBattleAbility():void {
			hasField$0 &= 0xffffffdf;
			battle_ability$field = new uint();
		}

		public function get hasBattleAbility():Boolean {
			return (hasField$0 & 0x20) != 0;
		}

		public function set battleAbility(value:uint):void {
			hasField$0 |= 0x20;
			battle_ability$field = value;
		}

		public function get battleAbility():uint {
			return battle_ability$field;
		}

		/**
		 *  @private
		 */
		public static const POS:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.dungeon_team_player.pos", "pos", (9 << 3) | com.netease.protobuf.WireType.VARINT);

		private var pos$field:int;

		public function clearPos():void {
			hasField$0 &= 0xffffffbf;
			pos$field = new int();
		}

		public function get hasPos():Boolean {
			return (hasField$0 & 0x40) != 0;
		}

		public function set pos(value:int):void {
			hasField$0 |= 0x40;
			pos$field = value;
		}

		public function get pos():int {
			return pos$field;
		}

		/**
		 *  @private
		 */
		public static const SERVER_ID:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.dungeon_team_player.server_id", "serverId", (10 << 3) | com.netease.protobuf.WireType.VARINT);

		private var server_id$field:int;

		public function clearServerId():void {
			hasField$0 &= 0xffffff7f;
			server_id$field = new int();
		}

		public function get hasServerId():Boolean {
			return (hasField$0 & 0x80) != 0;
		}

		public function set serverId(value:int):void {
			hasField$0 |= 0x80;
			server_id$field = value;
		}

		public function get serverId():int {
			return server_id$field;
		}

		/**
		 *  @private
		 */
		public static const IS_ROBOT:FieldDescriptor_TYPE_BOOL = new FieldDescriptor_TYPE_BOOL("SProtoSpace.dungeon_team_player.is_robot", "isRobot", (11 << 3) | com.netease.protobuf.WireType.VARINT);

		private var is_robot$field:Boolean;

		public function clearIsRobot():void {
			hasField$0 &= 0xfffffeff;
			is_robot$field = new Boolean();
		}

		public function get hasIsRobot():Boolean {
			return (hasField$0 & 0x100) != 0;
		}

		public function set isRobot(value:Boolean):void {
			hasField$0 |= 0x100;
			is_robot$field = value;
		}

		public function get isRobot():Boolean {
			return is_robot$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT64(output, this.llId);
			if (hasName) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
				com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, name$field);
			}
			if (hasState) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, state$field);
			}
			if (hasHeroId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, hero_id$field);
			}
			if (hasHeroLevel) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 5);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, hero_level$field);
			}
			if (hasHeroStar) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 6);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, hero_star$field);
			}
			if (hasHeroQuality) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, hero_quality$field);
			}
			if (hasBattleAbility) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 8);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, battle_ability$field);
			}
			if (hasPos) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 9);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, pos$field);
			}
			if (hasServerId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 10);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, server_id$field);
			}
			if (hasIsRobot) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 11);
				com.netease.protobuf.WriteUtils.write_TYPE_BOOL(output, is_robot$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var llId$count:uint = 0;
			var name$count:uint = 0;
			var state$count:uint = 0;
			var hero_id$count:uint = 0;
			var hero_level$count:uint = 0;
			var hero_star$count:uint = 0;
			var hero_quality$count:uint = 0;
			var battle_ability$count:uint = 0;
			var pos$count:uint = 0;
			var server_id$count:uint = 0;
			var is_robot$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (llId$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.llId cannot be set twice.');
					}
					++llId$count;
					this.llId = com.netease.protobuf.ReadUtils.read_TYPE_UINT64(input);
					break;
				case 2:
					if (name$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.name cannot be set twice.');
					}
					++name$count;
					this.name = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 3:
					if (state$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.state cannot be set twice.');
					}
					++state$count;
					this.state = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 4:
					if (hero_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.heroId cannot be set twice.');
					}
					++hero_id$count;
					this.heroId = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 5:
					if (hero_level$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.heroLevel cannot be set twice.');
					}
					++hero_level$count;
					this.heroLevel = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 6:
					if (hero_star$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.heroStar cannot be set twice.');
					}
					++hero_star$count;
					this.heroStar = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 7:
					if (hero_quality$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.heroQuality cannot be set twice.');
					}
					++hero_quality$count;
					this.heroQuality = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 8:
					if (battle_ability$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.battleAbility cannot be set twice.');
					}
					++battle_ability$count;
					this.battleAbility = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 9:
					if (pos$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.pos cannot be set twice.');
					}
					++pos$count;
					this.pos = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 10:
					if (server_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.serverId cannot be set twice.');
					}
					++server_id$count;
					this.serverId = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 11:
					if (is_robot$count != 0) {
						throw new flash.errors.IOError('Bad data format: dungeon_team_player.isRobot cannot be set twice.');
					}
					++is_robot$count;
					this.isRobot = com.netease.protobuf.ReadUtils.read_TYPE_BOOL(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
