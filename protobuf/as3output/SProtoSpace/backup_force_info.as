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
	public dynamic final class backup_force_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_HP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_hp", "totalAttrHp", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrHp:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_ATTACK:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_attack", "totalAttrAttack", (2 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrAttack:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_DEFENSE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_defense", "totalAttrDefense", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrDefense:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_CRIT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_crit", "totalAttrCrit", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrCrit:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_CRIT_DEFENSE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_crit_defense", "totalAttrCritDefense", (5 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrCritDefense:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_HIT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_hit", "totalAttrHit", (6 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrHit:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_DODGE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_dodge", "totalAttrDodge", (7 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrDodge:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_PENETRATION:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_penetration", "totalAttrPenetration", (8 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrPenetration:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_PENETRATION_DEF:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_penetration_def", "totalAttrPenetrationDef", (9 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrPenetrationDef:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_REVOVER:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_revover", "totalAttrRevover", (10 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrRevover:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_TREAT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_treat", "totalAttrTreat", (11 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrTreat:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_VAMPIRE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_vampire", "totalAttrVampire", (12 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrVampire:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_CRITICAL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_critical", "totalAttrCritical", (13 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrCritical:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_ATTACK_SPEED:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_attack_speed", "totalAttrAttackSpeed", (14 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrAttackSpeed:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_MOVE_SPEED:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_move_speed", "totalAttrMoveSpeed", (15 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrMoveSpeed:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_SKILL_CD:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_skill_cd", "totalAttrSkillCd", (16 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrSkillCd:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_DAMAGE_ADD:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_damage_add", "totalAttrDamageAdd", (17 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrDamageAdd:int;

		/**
		 *  @private
		 */
		public static const TOTAL_ATTR_DAMAGE_REDUCE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_attr_damage_reduce", "totalAttrDamageReduce", (18 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalAttrDamageReduce:int;

		/**
		 *  @private
		 */
		public static const TOTAL_PARTIAL_ATTR_HP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_partial_attr_hp", "totalPartialAttrHp", (19 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalPartialAttrHp:int;

		/**
		 *  @private
		 */
		public static const TOTAL_PARTIAL_ATTR_ATTACK:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_partial_attr_attack", "totalPartialAttrAttack", (20 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalPartialAttrAttack:int;

		/**
		 *  @private
		 */
		public static const TOTAL_PARTIAL_ATTR_DEFENSE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.backup_force_info.total_partial_attr_defense", "totalPartialAttrDefense", (21 << 3) | com.netease.protobuf.WireType.VARINT);

		public var totalPartialAttrDefense:int;

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrHp);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrAttack);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrDefense);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrCrit);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 5);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrCritDefense);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 6);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrHit);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrDodge);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 8);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrPenetration);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 9);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrPenetrationDef);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 10);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrRevover);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 11);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrTreat);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 12);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrVampire);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 13);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrCritical);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 14);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrAttackSpeed);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 15);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrMoveSpeed);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 16);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrSkillCd);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 17);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrDamageAdd);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 18);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalAttrDamageReduce);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 19);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalPartialAttrHp);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 20);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalPartialAttrAttack);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 21);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.totalPartialAttrDefense);
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var total_attr_hp$count:uint = 0;
			var total_attr_attack$count:uint = 0;
			var total_attr_defense$count:uint = 0;
			var total_attr_crit$count:uint = 0;
			var total_attr_crit_defense$count:uint = 0;
			var total_attr_hit$count:uint = 0;
			var total_attr_dodge$count:uint = 0;
			var total_attr_penetration$count:uint = 0;
			var total_attr_penetration_def$count:uint = 0;
			var total_attr_revover$count:uint = 0;
			var total_attr_treat$count:uint = 0;
			var total_attr_vampire$count:uint = 0;
			var total_attr_critical$count:uint = 0;
			var total_attr_attack_speed$count:uint = 0;
			var total_attr_move_speed$count:uint = 0;
			var total_attr_skill_cd$count:uint = 0;
			var total_attr_damage_add$count:uint = 0;
			var total_attr_damage_reduce$count:uint = 0;
			var total_partial_attr_hp$count:uint = 0;
			var total_partial_attr_attack$count:uint = 0;
			var total_partial_attr_defense$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (total_attr_hp$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrHp cannot be set twice.');
					}
					++total_attr_hp$count;
					this.totalAttrHp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 2:
					if (total_attr_attack$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrAttack cannot be set twice.');
					}
					++total_attr_attack$count;
					this.totalAttrAttack = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 3:
					if (total_attr_defense$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrDefense cannot be set twice.');
					}
					++total_attr_defense$count;
					this.totalAttrDefense = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 4:
					if (total_attr_crit$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrCrit cannot be set twice.');
					}
					++total_attr_crit$count;
					this.totalAttrCrit = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 5:
					if (total_attr_crit_defense$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrCritDefense cannot be set twice.');
					}
					++total_attr_crit_defense$count;
					this.totalAttrCritDefense = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 6:
					if (total_attr_hit$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrHit cannot be set twice.');
					}
					++total_attr_hit$count;
					this.totalAttrHit = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 7:
					if (total_attr_dodge$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrDodge cannot be set twice.');
					}
					++total_attr_dodge$count;
					this.totalAttrDodge = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 8:
					if (total_attr_penetration$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrPenetration cannot be set twice.');
					}
					++total_attr_penetration$count;
					this.totalAttrPenetration = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 9:
					if (total_attr_penetration_def$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrPenetrationDef cannot be set twice.');
					}
					++total_attr_penetration_def$count;
					this.totalAttrPenetrationDef = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 10:
					if (total_attr_revover$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrRevover cannot be set twice.');
					}
					++total_attr_revover$count;
					this.totalAttrRevover = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 11:
					if (total_attr_treat$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrTreat cannot be set twice.');
					}
					++total_attr_treat$count;
					this.totalAttrTreat = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 12:
					if (total_attr_vampire$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrVampire cannot be set twice.');
					}
					++total_attr_vampire$count;
					this.totalAttrVampire = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 13:
					if (total_attr_critical$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrCritical cannot be set twice.');
					}
					++total_attr_critical$count;
					this.totalAttrCritical = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 14:
					if (total_attr_attack_speed$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrAttackSpeed cannot be set twice.');
					}
					++total_attr_attack_speed$count;
					this.totalAttrAttackSpeed = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 15:
					if (total_attr_move_speed$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrMoveSpeed cannot be set twice.');
					}
					++total_attr_move_speed$count;
					this.totalAttrMoveSpeed = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 16:
					if (total_attr_skill_cd$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrSkillCd cannot be set twice.');
					}
					++total_attr_skill_cd$count;
					this.totalAttrSkillCd = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 17:
					if (total_attr_damage_add$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrDamageAdd cannot be set twice.');
					}
					++total_attr_damage_add$count;
					this.totalAttrDamageAdd = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 18:
					if (total_attr_damage_reduce$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalAttrDamageReduce cannot be set twice.');
					}
					++total_attr_damage_reduce$count;
					this.totalAttrDamageReduce = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 19:
					if (total_partial_attr_hp$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalPartialAttrHp cannot be set twice.');
					}
					++total_partial_attr_hp$count;
					this.totalPartialAttrHp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 20:
					if (total_partial_attr_attack$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalPartialAttrAttack cannot be set twice.');
					}
					++total_partial_attr_attack$count;
					this.totalPartialAttrAttack = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 21:
					if (total_partial_attr_defense$count != 0) {
						throw new flash.errors.IOError('Bad data format: backup_force_info.totalPartialAttrDefense cannot be set twice.');
					}
					++total_partial_attr_defense$count;
					this.totalPartialAttrDefense = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
