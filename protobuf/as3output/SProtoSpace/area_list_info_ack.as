package SProtoSpace {
	import com.netease.protobuf.*;
	use namespace com.netease.protobuf.used_by_generated_code;
	import com.netease.protobuf.fieldDescriptors.*;
	import flash.utils.Endian;
	import flash.utils.IDataInput;
	import flash.utils.IDataOutput;
	import flash.utils.IExternalizable;
	import flash.errors.IOError;
	import SProtoSpace.group_area_info;
	import SProtoSpace.gate_net_info;
	import SProtoSpace.group_hero_info;
	// @@protoc_insertion_point(imports)

	// @@protoc_insertion_point(class_metadata)
	public dynamic final class area_list_info_ack extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const GROUP_NET_INFO:RepeatedFieldDescriptor_TYPE_MESSAGE = new RepeatedFieldDescriptor_TYPE_MESSAGE("SProtoSpace.area_list_info_ack.group_net_info", "groupNetInfo", (1 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.gate_net_info; });

		[ArrayElementType("SProtoSpace.gate_net_info")]
		public var groupNetInfo:Array = [];

		/**
		 *  @private
		 */
		public static const ACCOUNT:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.area_list_info_ack.account", "account", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var account:String;

		/**
		 *  @private
		 */
		public static const CHECK_SERVER_ID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.area_list_info_ack.check_server_id", "checkServerId", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var check_server_id$field:uint;

		private var hasField$0:uint = 0;

		public function clearCheckServerId():void {
			hasField$0 &= 0xfffffffe;
			check_server_id$field = new uint();
		}

		public function get hasCheckServerId():Boolean {
			return (hasField$0 & 0x1) != 0;
		}

		public function set checkServerId(value:uint):void {
			hasField$0 |= 0x1;
			check_server_id$field = value;
		}

		public function get checkServerId():uint {
			return check_server_id$field;
		}

		/**
		 *  @private
		 */
		public static const AREA_GROUPS:RepeatedFieldDescriptor_TYPE_MESSAGE = new RepeatedFieldDescriptor_TYPE_MESSAGE("SProtoSpace.area_list_info_ack.area_groups", "areaGroups", (4 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.group_area_info; });

		[ArrayElementType("SProtoSpace.group_area_info")]
		public var areaGroups:Array = [];

		/**
		 *  @private
		 */
		public static const RECOMMEND_AREAS:RepeatedFieldDescriptor_TYPE_MESSAGE = new RepeatedFieldDescriptor_TYPE_MESSAGE("SProtoSpace.area_list_info_ack.recommend_areas", "recommendAreas", (5 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.group_area_info; });

		[ArrayElementType("SProtoSpace.group_area_info")]
		public var recommendAreas:Array = [];

		/**
		 *  @private
		 */
		public static const MY_LOGIN_AREAS:FieldDescriptor_TYPE_MESSAGE = new FieldDescriptor_TYPE_MESSAGE("SProtoSpace.area_list_info_ack.my_login_areas", "myLoginAreas", (6 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.group_area_info; });

		private var my_login_areas$field:SProtoSpace.group_area_info;

		public function clearMyLoginAreas():void {
			my_login_areas$field = null;
		}

		public function get hasMyLoginAreas():Boolean {
			return my_login_areas$field != null;
		}

		public function set myLoginAreas(value:SProtoSpace.group_area_info):void {
			my_login_areas$field = value;
		}

		public function get myLoginAreas():SProtoSpace.group_area_info {
			return my_login_areas$field;
		}

		/**
		 *  @private
		 */
		public static const MY_GROUP_PLAYERS:RepeatedFieldDescriptor_TYPE_MESSAGE = new RepeatedFieldDescriptor_TYPE_MESSAGE("SProtoSpace.area_list_info_ack.my_group_players", "myGroupPlayers", (7 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED, function():Class { return SProtoSpace.group_hero_info; });

		[ArrayElementType("SProtoSpace.group_hero_info")]
		public var myGroupPlayers:Array = [];

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			for (var groupNetInfo$index:uint = 0; groupNetInfo$index < this.groupNetInfo.length; ++groupNetInfo$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 1);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, this.groupNetInfo[groupNetInfo$index]);
			}
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.account);
			if (hasCheckServerId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, check_server_id$field);
			}
			for (var areaGroups$index:uint = 0; areaGroups$index < this.areaGroups.length; ++areaGroups$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 4);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, this.areaGroups[areaGroups$index]);
			}
			for (var recommendAreas$index:uint = 0; recommendAreas$index < this.recommendAreas.length; ++recommendAreas$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 5);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, this.recommendAreas[recommendAreas$index]);
			}
			if (hasMyLoginAreas) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 6);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, my_login_areas$field);
			}
			for (var myGroupPlayers$index:uint = 0; myGroupPlayers$index < this.myGroupPlayers.length; ++myGroupPlayers$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 7);
				com.netease.protobuf.WriteUtils.write_TYPE_MESSAGE(output, this.myGroupPlayers[myGroupPlayers$index]);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var account$count:uint = 0;
			var check_server_id$count:uint = 0;
			var my_login_areas$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					this.groupNetInfo.push(com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, new SProtoSpace.gate_net_info()));
					break;
				case 2:
					if (account$count != 0) {
						throw new flash.errors.IOError('Bad data format: area_list_info_ack.account cannot be set twice.');
					}
					++account$count;
					this.account = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 3:
					if (check_server_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: area_list_info_ack.checkServerId cannot be set twice.');
					}
					++check_server_id$count;
					this.checkServerId = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 4:
					this.areaGroups.push(com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, new SProtoSpace.group_area_info()));
					break;
				case 5:
					this.recommendAreas.push(com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, new SProtoSpace.group_area_info()));
					break;
				case 6:
					if (my_login_areas$count != 0) {
						throw new flash.errors.IOError('Bad data format: area_list_info_ack.myLoginAreas cannot be set twice.');
					}
					++my_login_areas$count;
					this.myLoginAreas = new SProtoSpace.group_area_info();
					com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, this.myLoginAreas);
					break;
				case 7:
					this.myGroupPlayers.push(com.netease.protobuf.ReadUtils.read_TYPE_MESSAGE(input, new SProtoSpace.group_hero_info()));
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
