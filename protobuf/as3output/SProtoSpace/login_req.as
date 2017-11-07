package SProtoSpace {
	import com.netease.protobuf.*;
	use namespace com.netease.protobuf.used_by_generated_code;
	import com.netease.protobuf.fieldDescriptors.*;
	import flash.utils.Endian;
	import flash.utils.IDataInput;
	import flash.utils.IDataOutput;
	import flash.utils.IExternalizable;
	import flash.errors.IOError;
	import SProtoSpace.EAuthType;
	import SProtoSpace.protoId;
	// @@protoc_insertion_point(imports)

	// @@protoc_insertion_point(class_metadata)
	public dynamic final class login_req extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const ACCOUNT:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.login_req.account", "account", (1 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var account:String;

		/**
		 *  @private
		 */
		public static const PASSWORD:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.login_req.password", "password", (2 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		public var password:String;

		/**
		 *  @private
		 */
		public static const ISDETAIL:FieldDescriptor_TYPE_BOOL = new FieldDescriptor_TYPE_BOOL("SProtoSpace.login_req.isdetail", "isdetail", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var isdetail$field:Boolean;

		private var hasField$0:uint = 0;

		public function clearIsdetail():void {
			hasField$0 &= 0xfffffffe;
			isdetail$field = new Boolean();
		}

		public function get hasIsdetail():Boolean {
			return (hasField$0 & 0x1) != 0;
		}

		public function set isdetail(value:Boolean):void {
			hasField$0 |= 0x1;
			isdetail$field = value;
		}

		public function get isdetail():Boolean {
			return isdetail$field;
		}

		/**
		 *  @private
		 */
		public static const USERID:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.login_req.userid", "userid", (4 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		private var userid$field:String;

		public function clearUserid():void {
			userid$field = null;
		}

		public function get hasUserid():Boolean {
			return userid$field != null;
		}

		public function set userid(value:String):void {
			userid$field = value;
		}

		public function get userid():String {
			return userid$field;
		}

		/**
		 *  @private
		 */
		public static const USERSESSION:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.login_req.usersession", "usersession", (5 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

		private var usersession$field:String;

		public function clearUsersession():void {
			usersession$field = null;
		}

		public function get hasUsersession():Boolean {
			return usersession$field != null;
		}

		public function set usersession(value:String):void {
			usersession$field = value;
		}

		public function get usersession():String {
			return usersession$field;
		}

		/**
		 *  @private
		 */
		public static const LOGINTYPE:FieldDescriptor_TYPE_ENUM = new FieldDescriptor_TYPE_ENUM("SProtoSpace.login_req.loginType", "loginType", (6 << 3) | com.netease.protobuf.WireType.VARINT, SProtoSpace.EAuthType);

		private var loginType$field:int;

		public function clearLoginType():void {
			hasField$0 &= 0xfffffffd;
			loginType$field = new int();
		}

		public function get hasLoginType():Boolean {
			return (hasField$0 & 0x2) != 0;
		}

		public function set loginType(value:int):void {
			hasField$0 |= 0x2;
			loginType$field = value;
		}

		public function get loginType():int {
			return loginType$field;
		}

		/**
		 *  @private
		 */
		public static const TESTENUM:FieldDescriptor_TYPE_ENUM = new FieldDescriptor_TYPE_ENUM("SProtoSpace.login_req.testEnum", "testEnum", (7 << 3) | com.netease.protobuf.WireType.VARINT, SProtoSpace.protoId);

		public var testEnum:int;

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.account);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, this.password);
			if (hasIsdetail) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_BOOL(output, isdetail$field);
			}
			if (hasUserid) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 4);
				com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, userid$field);
			}
			if (hasUsersession) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 5);
				com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, usersession$field);
			}
			if (hasLoginType) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 6);
				com.netease.protobuf.WriteUtils.write_TYPE_ENUM(output, loginType$field);
			}
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
			com.netease.protobuf.WriteUtils.write_TYPE_ENUM(output, this.testEnum);
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var account$count:uint = 0;
			var password$count:uint = 0;
			var isdetail$count:uint = 0;
			var userid$count:uint = 0;
			var usersession$count:uint = 0;
			var loginType$count:uint = 0;
			var testEnum$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (account$count != 0) {
						throw new flash.errors.IOError('Bad data format: login_req.account cannot be set twice.');
					}
					++account$count;
					this.account = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 2:
					if (password$count != 0) {
						throw new flash.errors.IOError('Bad data format: login_req.password cannot be set twice.');
					}
					++password$count;
					this.password = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 3:
					if (isdetail$count != 0) {
						throw new flash.errors.IOError('Bad data format: login_req.isdetail cannot be set twice.');
					}
					++isdetail$count;
					this.isdetail = com.netease.protobuf.ReadUtils.read_TYPE_BOOL(input);
					break;
				case 4:
					if (userid$count != 0) {
						throw new flash.errors.IOError('Bad data format: login_req.userid cannot be set twice.');
					}
					++userid$count;
					this.userid = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 5:
					if (usersession$count != 0) {
						throw new flash.errors.IOError('Bad data format: login_req.usersession cannot be set twice.');
					}
					++usersession$count;
					this.usersession = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 6:
					if (loginType$count != 0) {
						throw new flash.errors.IOError('Bad data format: login_req.loginType cannot be set twice.');
					}
					++loginType$count;
					this.loginType = com.netease.protobuf.ReadUtils.read_TYPE_ENUM(input);
					break;
				case 7:
					if (testEnum$count != 0) {
						throw new flash.errors.IOError('Bad data format: login_req.testEnum cannot be set twice.');
					}
					++testEnum$count;
					this.testEnum = com.netease.protobuf.ReadUtils.read_TYPE_ENUM(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
