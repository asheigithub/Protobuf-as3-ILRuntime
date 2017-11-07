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
	public dynamic final class role_bag_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const TEMPLATEID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_bag_info.templateid", "templateid", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var templateid:uint;

		/**
		 *  @private
		 */
		public static const NUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_bag_info.num", "num", (2 << 3) | com.netease.protobuf.WireType.VARINT);

		private var num$field:int;

		private var hasField$0:uint = 0;

		public function clearNum():void {
			hasField$0 &= 0xfffffffe;
			num$field = new int();
		}

		public function get hasNum():Boolean {
			return (hasField$0 & 0x1) != 0;
		}

		public function set num(value:int):void {
			hasField$0 |= 0x1;
			num$field = value;
		}

		public function get num():int {
			return num$field;
		}

		/**
		 *  @private
		 */
		public static const STAR:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_bag_info.star", "star", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var star$field:int;

		public function clearStar():void {
			hasField$0 &= 0xfffffffd;
			star$field = new int();
		}

		public function get hasStar():Boolean {
			return (hasField$0 & 0x2) != 0;
		}

		public function set star(value:int):void {
			hasField$0 |= 0x2;
			star$field = value;
		}

		public function get star():int {
			return star$field;
		}

		/**
		 *  @private
		 */
		public static const LEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_bag_info.level", "level", (4 << 3) | com.netease.protobuf.WireType.VARINT);

		private var level$field:int;

		public function clearLevel():void {
			hasField$0 &= 0xfffffffb;
			level$field = new int();
		}

		public function get hasLevel():Boolean {
			return (hasField$0 & 0x4) != 0;
		}

		public function set level(value:int):void {
			hasField$0 |= 0x4;
			level$field = value;
		}

		public function get level():int {
			return level$field;
		}

		/**
		 *  @private
		 */
		public static const CUR_MAX_LEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_bag_info.cur_max_level", "curMaxLevel", (5 << 3) | com.netease.protobuf.WireType.VARINT);

		private var cur_max_level$field:int;

		public function clearCurMaxLevel():void {
			hasField$0 &= 0xfffffff7;
			cur_max_level$field = new int();
		}

		public function get hasCurMaxLevel():Boolean {
			return (hasField$0 & 0x8) != 0;
		}

		public function set curMaxLevel(value:int):void {
			hasField$0 |= 0x8;
			cur_max_level$field = value;
		}

		public function get curMaxLevel():int {
			return cur_max_level$field;
		}

		/**
		 *  @private
		 */
		public static const CUR_MAX_STARS:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_bag_info.cur_max_stars", "curMaxStars", (6 << 3) | com.netease.protobuf.WireType.VARINT);

		private var cur_max_stars$field:int;

		public function clearCurMaxStars():void {
			hasField$0 &= 0xffffffef;
			cur_max_stars$field = new int();
		}

		public function get hasCurMaxStars():Boolean {
			return (hasField$0 & 0x10) != 0;
		}

		public function set curMaxStars(value:int):void {
			hasField$0 |= 0x10;
			cur_max_stars$field = value;
		}

		public function get curMaxStars():int {
			return cur_max_stars$field;
		}

		/**
		 *  @private
		 */
		public static const STAR_EXP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_bag_info.star_exp", "starExp", (7 << 3) | com.netease.protobuf.WireType.VARINT);

		private var star_exp$field:int;

		public function clearStarExp():void {
			hasField$0 &= 0xffffffdf;
			star_exp$field = new int();
		}

		public function get hasStarExp():Boolean {
			return (hasField$0 & 0x20) != 0;
		}

		public function set starExp(value:int):void {
			hasField$0 |= 0x20;
			star_exp$field = value;
		}

		public function get starExp():int {
			return star_exp$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.templateid);
			if (hasNum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 2);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, num$field);
			}
			if (hasStar) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, star$field);
			}
			if (hasLevel) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 4);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, level$field);
			}
			if (hasCurMaxLevel) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 5);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, cur_max_level$field);
			}
			if (hasCurMaxStars) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 6);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, cur_max_stars$field);
			}
			if (hasStarExp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, star_exp$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var templateid$count:uint = 0;
			var num$count:uint = 0;
			var star$count:uint = 0;
			var level$count:uint = 0;
			var cur_max_level$count:uint = 0;
			var cur_max_stars$count:uint = 0;
			var star_exp$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (templateid$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_bag_info.templateid cannot be set twice.');
					}
					++templateid$count;
					this.templateid = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 2:
					if (num$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_bag_info.num cannot be set twice.');
					}
					++num$count;
					this.num = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 3:
					if (star$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_bag_info.star cannot be set twice.');
					}
					++star$count;
					this.star = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 4:
					if (level$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_bag_info.level cannot be set twice.');
					}
					++level$count;
					this.level = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 5:
					if (cur_max_level$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_bag_info.curMaxLevel cannot be set twice.');
					}
					++cur_max_level$count;
					this.curMaxLevel = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 6:
					if (cur_max_stars$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_bag_info.curMaxStars cannot be set twice.');
					}
					++cur_max_stars$count;
					this.curMaxStars = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 7:
					if (star_exp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_bag_info.starExp cannot be set twice.');
					}
					++star_exp$count;
					this.starExp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
