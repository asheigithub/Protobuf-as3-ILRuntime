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
	public dynamic final class role_base_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const LEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.level", "level", (1 << 3) | com.netease.protobuf.WireType.VARINT);

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
		public static const COMMONSCENE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.commonscene", "commonscene", (2 << 3) | com.netease.protobuf.WireType.VARINT);

		private var commonscene$field:int;

		public function clearCommonscene():void {
			hasField$0 &= 0xfffffffd;
			commonscene$field = new int();
		}

		public function get hasCommonscene():Boolean {
			return (hasField$0 & 0x2) != 0;
		}

		public function set commonscene(value:int):void {
			hasField$0 |= 0x2;
			commonscene$field = value;
		}

		public function get commonscene():int {
			return commonscene$field;
		}

		/**
		 *  @private
		 */
		public static const HARDSCENE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.hardscene", "hardscene", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		private var hardscene$field:int;

		public function clearHardscene():void {
			hasField$0 &= 0xfffffffb;
			hardscene$field = new int();
		}

		public function get hasHardscene():Boolean {
			return (hasField$0 & 0x4) != 0;
		}

		public function set hardscene(value:int):void {
			hasField$0 |= 0x4;
			hardscene$field = value;
		}

		public function get hardscene():int {
			return hardscene$field;
		}

		/**
		 *  @private
		 */
		public static const ACCOUNT:FieldDescriptor_TYPE_STRING = new FieldDescriptor_TYPE_STRING("SProtoSpace.role_base_info.account", "account", (4 << 3) | com.netease.protobuf.WireType.LENGTH_DELIMITED);

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
		public static const HEROID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.heroid", "heroid", (5 << 3) | com.netease.protobuf.WireType.VARINT);

		private var heroid$field:uint;

		public function clearHeroid():void {
			hasField$0 &= 0xfffffff7;
			heroid$field = new uint();
		}

		public function get hasHeroid():Boolean {
			return (hasField$0 & 0x8) != 0;
		}

		public function set heroid(value:uint):void {
			hasField$0 |= 0x8;
			heroid$field = value;
		}

		public function get heroid():uint {
			return heroid$field;
		}

		/**
		 *  @private
		 */
		public static const VP:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.vp", "vp", (6 << 3) | com.netease.protobuf.WireType.VARINT);

		private var vp$field:uint;

		public function clearVp():void {
			hasField$0 &= 0xffffffef;
			vp$field = new uint();
		}

		public function get hasVp():Boolean {
			return (hasField$0 & 0x10) != 0;
		}

		public function set vp(value:uint):void {
			hasField$0 |= 0x10;
			vp$field = value;
		}

		public function get vp():uint {
			return vp$field;
		}

		/**
		 *  @private
		 */
		public static const VP_UPDATE_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.vp_update_time", "vpUpdateTime", (7 << 3) | com.netease.protobuf.WireType.VARINT);

		private var vp_update_time$field:uint;

		public function clearVpUpdateTime():void {
			hasField$0 &= 0xffffffdf;
			vp_update_time$field = new uint();
		}

		public function get hasVpUpdateTime():Boolean {
			return (hasField$0 & 0x20) != 0;
		}

		public function set vpUpdateTime(value:uint):void {
			hasField$0 |= 0x20;
			vp_update_time$field = value;
		}

		public function get vpUpdateTime():uint {
			return vp_update_time$field;
		}

		/**
		 *  @private
		 */
		public static const EXP:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.exp", "exp", (8 << 3) | com.netease.protobuf.WireType.VARINT);

		private var exp$field:uint;

		public function clearExp():void {
			hasField$0 &= 0xffffffbf;
			exp$field = new uint();
		}

		public function get hasExp():Boolean {
			return (hasField$0 & 0x40) != 0;
		}

		public function set exp(value:uint):void {
			hasField$0 |= 0x40;
			exp$field = value;
		}

		public function get exp():uint {
			return exp$field;
		}

		/**
		 *  @private
		 */
		public static const COIN:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.coin", "coin", (9 << 3) | com.netease.protobuf.WireType.VARINT);

		private var coin$field:uint;

		public function clearCoin():void {
			hasField$0 &= 0xffffff7f;
			coin$field = new uint();
		}

		public function get hasCoin():Boolean {
			return (hasField$0 & 0x80) != 0;
		}

		public function set coin(value:uint):void {
			hasField$0 |= 0x80;
			coin$field = value;
		}

		public function get coin():uint {
			return coin$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.diamond", "diamond", (10 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond$field:uint;

		public function clearDiamond():void {
			hasField$0 &= 0xfffffeff;
			diamond$field = new uint();
		}

		public function get hasDiamond():Boolean {
			return (hasField$0 & 0x100) != 0;
		}

		public function set diamond(value:uint):void {
			hasField$0 |= 0x100;
			diamond$field = value;
		}

		public function get diamond():uint {
			return diamond$field;
		}

		/**
		 *  @private
		 */
		public static const VIPLEVEL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.viplevel", "viplevel", (11 << 3) | com.netease.protobuf.WireType.VARINT);

		private var viplevel$field:int;

		public function clearViplevel():void {
			hasField$0 &= 0xfffffdff;
			viplevel$field = new int();
		}

		public function get hasViplevel():Boolean {
			return (hasField$0 & 0x200) != 0;
		}

		public function set viplevel(value:int):void {
			hasField$0 |= 0x200;
			viplevel$field = value;
		}

		public function get viplevel():int {
			return viplevel$field;
		}

		/**
		 *  @private
		 */
		public static const VIPEXP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.vipexp", "vipexp", (12 << 3) | com.netease.protobuf.WireType.VARINT);

		private var vipexp$field:int;

		public function clearVipexp():void {
			hasField$0 &= 0xfffffbff;
			vipexp$field = new int();
		}

		public function get hasVipexp():Boolean {
			return (hasField$0 & 0x400) != 0;
		}

		public function set vipexp(value:int):void {
			hasField$0 |= 0x400;
			vipexp$field = value;
		}

		public function get vipexp():int {
			return vipexp$field;
		}

		/**
		 *  @private
		 */
		public static const LASTLEAVETIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.lastleavetime", "lastleavetime", (13 << 3) | com.netease.protobuf.WireType.VARINT);

		private var lastleavetime$field:uint;

		public function clearLastleavetime():void {
			hasField$0 &= 0xfffff7ff;
			lastleavetime$field = new uint();
		}

		public function get hasLastleavetime():Boolean {
			return (hasField$0 & 0x800) != 0;
		}

		public function set lastleavetime(value:uint):void {
			hasField$0 |= 0x800;
			lastleavetime$field = value;
		}

		public function get lastleavetime():uint {
			return lastleavetime$field;
		}

		/**
		 *  @private
		 */
		public static const ONEMONEYCARDINGTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.onemoneycardingtime", "onemoneycardingtime", (14 << 3) | com.netease.protobuf.WireType.VARINT);

		private var onemoneycardingtime$field:uint;

		public function clearOnemoneycardingtime():void {
			hasField$0 &= 0xffffefff;
			onemoneycardingtime$field = new uint();
		}

		public function get hasOnemoneycardingtime():Boolean {
			return (hasField$0 & 0x1000) != 0;
		}

		public function set onemoneycardingtime(value:uint):void {
			hasField$0 |= 0x1000;
			onemoneycardingtime$field = value;
		}

		public function get onemoneycardingtime():uint {
			return onemoneycardingtime$field;
		}

		/**
		 *  @private
		 */
		public static const ONEMONEYCARDINGCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.onemoneycardingcount", "onemoneycardingcount", (15 << 3) | com.netease.protobuf.WireType.VARINT);

		private var onemoneycardingcount$field:int;

		public function clearOnemoneycardingcount():void {
			hasField$0 &= 0xffffdfff;
			onemoneycardingcount$field = new int();
		}

		public function get hasOnemoneycardingcount():Boolean {
			return (hasField$0 & 0x2000) != 0;
		}

		public function set onemoneycardingcount(value:int):void {
			hasField$0 |= 0x2000;
			onemoneycardingcount$field = value;
		}

		public function get onemoneycardingcount():int {
			return onemoneycardingcount$field;
		}

		/**
		 *  @private
		 */
		public static const TENMONEYCARDINGTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.tenmoneycardingtime", "tenmoneycardingtime", (16 << 3) | com.netease.protobuf.WireType.VARINT);

		private var tenmoneycardingtime$field:uint;

		public function clearTenmoneycardingtime():void {
			hasField$0 &= 0xffffbfff;
			tenmoneycardingtime$field = new uint();
		}

		public function get hasTenmoneycardingtime():Boolean {
			return (hasField$0 & 0x4000) != 0;
		}

		public function set tenmoneycardingtime(value:uint):void {
			hasField$0 |= 0x4000;
			tenmoneycardingtime$field = value;
		}

		public function get tenmoneycardingtime():uint {
			return tenmoneycardingtime$field;
		}

		/**
		 *  @private
		 */
		public static const TENMONEYCARDINGCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.tenmoneycardingcount", "tenmoneycardingcount", (17 << 3) | com.netease.protobuf.WireType.VARINT);

		private var tenmoneycardingcount$field:int;

		public function clearTenmoneycardingcount():void {
			hasField$0 &= 0xffff7fff;
			tenmoneycardingcount$field = new int();
		}

		public function get hasTenmoneycardingcount():Boolean {
			return (hasField$0 & 0x8000) != 0;
		}

		public function set tenmoneycardingcount(value:int):void {
			hasField$0 |= 0x8000;
			tenmoneycardingcount$field = value;
		}

		public function get tenmoneycardingcount():int {
			return tenmoneycardingcount$field;
		}

		/**
		 *  @private
		 */
		public static const ONEGOLDCARDINGTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.onegoldcardingtime", "onegoldcardingtime", (18 << 3) | com.netease.protobuf.WireType.VARINT);

		private var onegoldcardingtime$field:uint;

		public function clearOnegoldcardingtime():void {
			hasField$0 &= 0xfffeffff;
			onegoldcardingtime$field = new uint();
		}

		public function get hasOnegoldcardingtime():Boolean {
			return (hasField$0 & 0x10000) != 0;
		}

		public function set onegoldcardingtime(value:uint):void {
			hasField$0 |= 0x10000;
			onegoldcardingtime$field = value;
		}

		public function get onegoldcardingtime():uint {
			return onegoldcardingtime$field;
		}

		/**
		 *  @private
		 */
		public static const ONEGOLDCARDINGCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.onegoldcardingcount", "onegoldcardingcount", (19 << 3) | com.netease.protobuf.WireType.VARINT);

		private var onegoldcardingcount$field:int;

		public function clearOnegoldcardingcount():void {
			hasField$0 &= 0xfffdffff;
			onegoldcardingcount$field = new int();
		}

		public function get hasOnegoldcardingcount():Boolean {
			return (hasField$0 & 0x20000) != 0;
		}

		public function set onegoldcardingcount(value:int):void {
			hasField$0 |= 0x20000;
			onegoldcardingcount$field = value;
		}

		public function get onegoldcardingcount():int {
			return onegoldcardingcount$field;
		}

		/**
		 *  @private
		 */
		public static const TENGOLDCARDINGTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.tengoldcardingtime", "tengoldcardingtime", (20 << 3) | com.netease.protobuf.WireType.VARINT);

		private var tengoldcardingtime$field:uint;

		public function clearTengoldcardingtime():void {
			hasField$0 &= 0xfffbffff;
			tengoldcardingtime$field = new uint();
		}

		public function get hasTengoldcardingtime():Boolean {
			return (hasField$0 & 0x40000) != 0;
		}

		public function set tengoldcardingtime(value:uint):void {
			hasField$0 |= 0x40000;
			tengoldcardingtime$field = value;
		}

		public function get tengoldcardingtime():uint {
			return tengoldcardingtime$field;
		}

		/**
		 *  @private
		 */
		public static const TENGOLDCARDINGCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.tengoldcardingcount", "tengoldcardingcount", (21 << 3) | com.netease.protobuf.WireType.VARINT);

		private var tengoldcardingcount$field:int;

		public function clearTengoldcardingcount():void {
			hasField$0 &= 0xfff7ffff;
			tengoldcardingcount$field = new int();
		}

		public function get hasTengoldcardingcount():Boolean {
			return (hasField$0 & 0x80000) != 0;
		}

		public function set tengoldcardingcount(value:int):void {
			hasField$0 |= 0x80000;
			tengoldcardingcount$field = value;
		}

		public function get tengoldcardingcount():int {
			return tengoldcardingcount$field;
		}

		/**
		 *  @private
		 */
		public static const ONEEQUIPMONEYCARDINGTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.oneequipmoneycardingtime", "oneequipmoneycardingtime", (22 << 3) | com.netease.protobuf.WireType.VARINT);

		private var oneequipmoneycardingtime$field:uint;

		public function clearOneequipmoneycardingtime():void {
			hasField$0 &= 0xffefffff;
			oneequipmoneycardingtime$field = new uint();
		}

		public function get hasOneequipmoneycardingtime():Boolean {
			return (hasField$0 & 0x100000) != 0;
		}

		public function set oneequipmoneycardingtime(value:uint):void {
			hasField$0 |= 0x100000;
			oneequipmoneycardingtime$field = value;
		}

		public function get oneequipmoneycardingtime():uint {
			return oneequipmoneycardingtime$field;
		}

		/**
		 *  @private
		 */
		public static const ONEEQUIPMONEYCARDINGCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.oneequipmoneycardingcount", "oneequipmoneycardingcount", (23 << 3) | com.netease.protobuf.WireType.VARINT);

		private var oneequipmoneycardingcount$field:int;

		public function clearOneequipmoneycardingcount():void {
			hasField$0 &= 0xffdfffff;
			oneequipmoneycardingcount$field = new int();
		}

		public function get hasOneequipmoneycardingcount():Boolean {
			return (hasField$0 & 0x200000) != 0;
		}

		public function set oneequipmoneycardingcount(value:int):void {
			hasField$0 |= 0x200000;
			oneequipmoneycardingcount$field = value;
		}

		public function get oneequipmoneycardingcount():int {
			return oneequipmoneycardingcount$field;
		}

		/**
		 *  @private
		 */
		public static const TENEQUIPMONEYCARDINGTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.tenequipmoneycardingtime", "tenequipmoneycardingtime", (24 << 3) | com.netease.protobuf.WireType.VARINT);

		private var tenequipmoneycardingtime$field:uint;

		public function clearTenequipmoneycardingtime():void {
			hasField$0 &= 0xffbfffff;
			tenequipmoneycardingtime$field = new uint();
		}

		public function get hasTenequipmoneycardingtime():Boolean {
			return (hasField$0 & 0x400000) != 0;
		}

		public function set tenequipmoneycardingtime(value:uint):void {
			hasField$0 |= 0x400000;
			tenequipmoneycardingtime$field = value;
		}

		public function get tenequipmoneycardingtime():uint {
			return tenequipmoneycardingtime$field;
		}

		/**
		 *  @private
		 */
		public static const TENEQUIPMONEYCARDINGCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.tenequipmoneycardingcount", "tenequipmoneycardingcount", (25 << 3) | com.netease.protobuf.WireType.VARINT);

		private var tenequipmoneycardingcount$field:int;

		public function clearTenequipmoneycardingcount():void {
			hasField$0 &= 0xff7fffff;
			tenequipmoneycardingcount$field = new int();
		}

		public function get hasTenequipmoneycardingcount():Boolean {
			return (hasField$0 & 0x800000) != 0;
		}

		public function set tenequipmoneycardingcount(value:int):void {
			hasField$0 |= 0x800000;
			tenequipmoneycardingcount$field = value;
		}

		public function get tenequipmoneycardingcount():int {
			return tenequipmoneycardingcount$field;
		}

		/**
		 *  @private
		 */
		public static const ONEEQUIPGOLDCARDINGTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.oneequipgoldcardingtime", "oneequipgoldcardingtime", (26 << 3) | com.netease.protobuf.WireType.VARINT);

		private var oneequipgoldcardingtime$field:uint;

		public function clearOneequipgoldcardingtime():void {
			hasField$0 &= 0xfeffffff;
			oneequipgoldcardingtime$field = new uint();
		}

		public function get hasOneequipgoldcardingtime():Boolean {
			return (hasField$0 & 0x1000000) != 0;
		}

		public function set oneequipgoldcardingtime(value:uint):void {
			hasField$0 |= 0x1000000;
			oneequipgoldcardingtime$field = value;
		}

		public function get oneequipgoldcardingtime():uint {
			return oneequipgoldcardingtime$field;
		}

		/**
		 *  @private
		 */
		public static const ONEEQUIPGOLDCARDINGCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.oneequipgoldcardingcount", "oneequipgoldcardingcount", (27 << 3) | com.netease.protobuf.WireType.VARINT);

		private var oneequipgoldcardingcount$field:int;

		public function clearOneequipgoldcardingcount():void {
			hasField$0 &= 0xfdffffff;
			oneequipgoldcardingcount$field = new int();
		}

		public function get hasOneequipgoldcardingcount():Boolean {
			return (hasField$0 & 0x2000000) != 0;
		}

		public function set oneequipgoldcardingcount(value:int):void {
			hasField$0 |= 0x2000000;
			oneequipgoldcardingcount$field = value;
		}

		public function get oneequipgoldcardingcount():int {
			return oneequipgoldcardingcount$field;
		}

		/**
		 *  @private
		 */
		public static const TENEQUIPGOLDCARDINGTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.tenequipgoldcardingtime", "tenequipgoldcardingtime", (28 << 3) | com.netease.protobuf.WireType.VARINT);

		private var tenequipgoldcardingtime$field:uint;

		public function clearTenequipgoldcardingtime():void {
			hasField$0 &= 0xfbffffff;
			tenequipgoldcardingtime$field = new uint();
		}

		public function get hasTenequipgoldcardingtime():Boolean {
			return (hasField$0 & 0x4000000) != 0;
		}

		public function set tenequipgoldcardingtime(value:uint):void {
			hasField$0 |= 0x4000000;
			tenequipgoldcardingtime$field = value;
		}

		public function get tenequipgoldcardingtime():uint {
			return tenequipgoldcardingtime$field;
		}

		/**
		 *  @private
		 */
		public static const TENEQUIPGOLDCARDINGCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.tenequipgoldcardingcount", "tenequipgoldcardingcount", (29 << 3) | com.netease.protobuf.WireType.VARINT);

		private var tenequipgoldcardingcount$field:int;

		public function clearTenequipgoldcardingcount():void {
			hasField$0 &= 0xf7ffffff;
			tenequipgoldcardingcount$field = new int();
		}

		public function get hasTenequipgoldcardingcount():Boolean {
			return (hasField$0 & 0x8000000) != 0;
		}

		public function set tenequipgoldcardingcount(value:int):void {
			hasField$0 |= 0x8000000;
			tenequipgoldcardingcount$field = value;
		}

		public function get tenequipgoldcardingcount():int {
			return tenequipgoldcardingcount$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2COINTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.diamond2cointime", "diamond2cointime", (30 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2cointime$field:uint;

		public function clearDiamond2cointime():void {
			hasField$0 &= 0xefffffff;
			diamond2cointime$field = new uint();
		}

		public function get hasDiamond2cointime():Boolean {
			return (hasField$0 & 0x10000000) != 0;
		}

		public function set diamond2cointime(value:uint):void {
			hasField$0 |= 0x10000000;
			diamond2cointime$field = value;
		}

		public function get diamond2cointime():uint {
			return diamond2cointime$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2COINCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.diamond2coincount", "diamond2coincount", (31 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2coincount$field:int;

		public function clearDiamond2coincount():void {
			hasField$0 &= 0xdfffffff;
			diamond2coincount$field = new int();
		}

		public function get hasDiamond2coincount():Boolean {
			return (hasField$0 & 0x20000000) != 0;
		}

		public function set diamond2coincount(value:int):void {
			hasField$0 |= 0x20000000;
			diamond2coincount$field = value;
		}

		public function get diamond2coincount():int {
			return diamond2coincount$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2ENERGYTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.diamond2energytime", "diamond2energytime", (32 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2energytime$field:uint;

		public function clearDiamond2energytime():void {
			hasField$0 &= 0xbfffffff;
			diamond2energytime$field = new uint();
		}

		public function get hasDiamond2energytime():Boolean {
			return (hasField$0 & 0x40000000) != 0;
		}

		public function set diamond2energytime(value:uint):void {
			hasField$0 |= 0x40000000;
			diamond2energytime$field = value;
		}

		public function get diamond2energytime():uint {
			return diamond2energytime$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2ENERGYCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.diamond2energycount", "diamond2energycount", (33 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2energycount$field:int;

		public function clearDiamond2energycount():void {
			hasField$0 &= 0x7fffffff;
			diamond2energycount$field = new int();
		}

		public function get hasDiamond2energycount():Boolean {
			return (hasField$0 & 0x80000000) != 0;
		}

		public function set diamond2energycount(value:int):void {
			hasField$0 |= 0x80000000;
			diamond2energycount$field = value;
		}

		public function get diamond2energycount():int {
			return diamond2energycount$field;
		}

		/**
		 *  @private
		 */
		public static const SKILLNUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.skillnum", "skillnum", (34 << 3) | com.netease.protobuf.WireType.VARINT);

		private var skillnum$field:int;

		private var hasField$1:uint = 0;

		public function clearSkillnum():void {
			hasField$1 &= 0xfffffffe;
			skillnum$field = new int();
		}

		public function get hasSkillnum():Boolean {
			return (hasField$1 & 0x1) != 0;
		}

		public function set skillnum(value:int):void {
			hasField$1 |= 0x1;
			skillnum$field = value;
		}

		public function get skillnum():int {
			return skillnum$field;
		}

		/**
		 *  @private
		 */
		public static const SKILLNUM_UPDATE_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.skillnum_update_time", "skillnumUpdateTime", (35 << 3) | com.netease.protobuf.WireType.VARINT);

		private var skillnum_update_time$field:uint;

		public function clearSkillnumUpdateTime():void {
			hasField$1 &= 0xfffffffd;
			skillnum_update_time$field = new uint();
		}

		public function get hasSkillnumUpdateTime():Boolean {
			return (hasField$1 & 0x2) != 0;
		}

		public function set skillnumUpdateTime(value:uint):void {
			hasField$1 |= 0x2;
			skillnum_update_time$field = value;
		}

		public function get skillnumUpdateTime():uint {
			return skillnum_update_time$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2SKILLNUMTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.diamond2skillnumtime", "diamond2skillnumtime", (36 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2skillnumtime$field:uint;

		public function clearDiamond2skillnumtime():void {
			hasField$1 &= 0xfffffffb;
			diamond2skillnumtime$field = new uint();
		}

		public function get hasDiamond2skillnumtime():Boolean {
			return (hasField$1 & 0x4) != 0;
		}

		public function set diamond2skillnumtime(value:uint):void {
			hasField$1 |= 0x4;
			diamond2skillnumtime$field = value;
		}

		public function get diamond2skillnumtime():uint {
			return diamond2skillnumtime$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2SKILLNUMCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.diamond2skillnumcount", "diamond2skillnumcount", (37 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2skillnumcount$field:int;

		public function clearDiamond2skillnumcount():void {
			hasField$1 &= 0xfffffff7;
			diamond2skillnumcount$field = new int();
		}

		public function get hasDiamond2skillnumcount():Boolean {
			return (hasField$1 & 0x8) != 0;
		}

		public function set diamond2skillnumcount(value:int):void {
			hasField$1 |= 0x8;
			diamond2skillnumcount$field = value;
		}

		public function get diamond2skillnumcount():int {
			return diamond2skillnumcount$field;
		}

		/**
		 *  @private
		 */
		public static const WORLDCHATTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.worldchattime", "worldchattime", (38 << 3) | com.netease.protobuf.WireType.VARINT);

		private var worldchattime$field:uint;

		public function clearWorldchattime():void {
			hasField$1 &= 0xffffffef;
			worldchattime$field = new uint();
		}

		public function get hasWorldchattime():Boolean {
			return (hasField$1 & 0x10) != 0;
		}

		public function set worldchattime(value:uint):void {
			hasField$1 |= 0x10;
			worldchattime$field = value;
		}

		public function get worldchattime():uint {
			return worldchattime$field;
		}

		/**
		 *  @private
		 */
		public static const WORLDCHATCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.worldchatcount", "worldchatcount", (39 << 3) | com.netease.protobuf.WireType.VARINT);

		private var worldchatcount$field:int;

		public function clearWorldchatcount():void {
			hasField$1 &= 0xffffffdf;
			worldchatcount$field = new int();
		}

		public function get hasWorldchatcount():Boolean {
			return (hasField$1 & 0x20) != 0;
		}

		public function set worldchatcount(value:int):void {
			hasField$1 |= 0x20;
			worldchatcount$field = value;
		}

		public function get worldchatcount():int {
			return worldchatcount$field;
		}

		/**
		 *  @private
		 */
		public static const ARENATIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.arenatime", "arenatime", (40 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arenatime$field:uint;

		public function clearArenatime():void {
			hasField$1 &= 0xffffffbf;
			arenatime$field = new uint();
		}

		public function get hasArenatime():Boolean {
			return (hasField$1 & 0x40) != 0;
		}

		public function set arenatime(value:uint):void {
			hasField$1 |= 0x40;
			arenatime$field = value;
		}

		public function get arenatime():uint {
			return arenatime$field;
		}

		/**
		 *  @private
		 */
		public static const ARENACOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.arenacount", "arenacount", (41 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arenacount$field:int;

		public function clearArenacount():void {
			hasField$1 &= 0xffffff7f;
			arenacount$field = new int();
		}

		public function get hasArenacount():Boolean {
			return (hasField$1 & 0x80) != 0;
		}

		public function set arenacount(value:int):void {
			hasField$1 |= 0x80;
			arenacount$field = value;
		}

		public function get arenacount():int {
			return arenacount$field;
		}

		/**
		 *  @private
		 */
		public static const ARENACDTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.arenacdtime", "arenacdtime", (42 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arenacdtime$field:uint;

		public function clearArenacdtime():void {
			hasField$1 &= 0xfffffeff;
			arenacdtime$field = new uint();
		}

		public function get hasArenacdtime():Boolean {
			return (hasField$1 & 0x100) != 0;
		}

		public function set arenacdtime(value:uint):void {
			hasField$1 |= 0x100;
			arenacdtime$field = value;
		}

		public function get arenacdtime():uint {
			return arenacdtime$field;
		}

		/**
		 *  @private
		 */
		public static const ARENACDVALUE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.arenacdvalue", "arenacdvalue", (43 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arenacdvalue$field:int;

		public function clearArenacdvalue():void {
			hasField$1 &= 0xfffffdff;
			arenacdvalue$field = new int();
		}

		public function get hasArenacdvalue():Boolean {
			return (hasField$1 & 0x200) != 0;
		}

		public function set arenacdvalue(value:int):void {
			hasField$1 |= 0x200;
			arenacdvalue$field = value;
		}

		public function get arenacdvalue():int {
			return arenacdvalue$field;
		}

		/**
		 *  @private
		 */
		public static const ARENA_RESETCD_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.arena_resetcd_time", "arenaResetcdTime", (44 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arena_resetcd_time$field:uint;

		public function clearArenaResetcdTime():void {
			hasField$1 &= 0xfffffbff;
			arena_resetcd_time$field = new uint();
		}

		public function get hasArenaResetcdTime():Boolean {
			return (hasField$1 & 0x400) != 0;
		}

		public function set arenaResetcdTime(value:uint):void {
			hasField$1 |= 0x400;
			arena_resetcd_time$field = value;
		}

		public function get arenaResetcdTime():uint {
			return arena_resetcd_time$field;
		}

		/**
		 *  @private
		 */
		public static const ARENA_RESETCD_COUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.arena_resetcd_count", "arenaResetcdCount", (45 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arena_resetcd_count$field:int;

		public function clearArenaResetcdCount():void {
			hasField$1 &= 0xfffff7ff;
			arena_resetcd_count$field = new int();
		}

		public function get hasArenaResetcdCount():Boolean {
			return (hasField$1 & 0x800) != 0;
		}

		public function set arenaResetcdCount(value:int):void {
			hasField$1 |= 0x800;
			arena_resetcd_count$field = value;
		}

		public function get arenaResetcdCount():int {
			return arena_resetcd_count$field;
		}

		/**
		 *  @private
		 */
		public static const ARENA_BUYCOUNT_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.arena_buycount_time", "arenaBuycountTime", (46 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arena_buycount_time$field:uint;

		public function clearArenaBuycountTime():void {
			hasField$1 &= 0xffffefff;
			arena_buycount_time$field = new uint();
		}

		public function get hasArenaBuycountTime():Boolean {
			return (hasField$1 & 0x1000) != 0;
		}

		public function set arenaBuycountTime(value:uint):void {
			hasField$1 |= 0x1000;
			arena_buycount_time$field = value;
		}

		public function get arenaBuycountTime():uint {
			return arena_buycount_time$field;
		}

		/**
		 *  @private
		 */
		public static const ARENA_BUYCOUNT_NUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.arena_buycount_num", "arenaBuycountNum", (47 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arena_buycount_num$field:int;

		public function clearArenaBuycountNum():void {
			hasField$1 &= 0xffffdfff;
			arena_buycount_num$field = new int();
		}

		public function get hasArenaBuycountNum():Boolean {
			return (hasField$1 & 0x2000) != 0;
		}

		public function set arenaBuycountNum(value:int):void {
			hasField$1 |= 0x2000;
			arena_buycount_num$field = value;
		}

		public function get arenaBuycountNum():int {
			return arena_buycount_num$field;
		}

		/**
		 *  @private
		 */
		public static const ARENA_COIN:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.arena_coin", "arenaCoin", (48 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arena_coin$field:int;

		public function clearArenaCoin():void {
			hasField$1 &= 0xffffbfff;
			arena_coin$field = new int();
		}

		public function get hasArenaCoin():Boolean {
			return (hasField$1 & 0x4000) != 0;
		}

		public function set arenaCoin(value:int):void {
			hasField$1 |= 0x4000;
			arena_coin$field = value;
		}

		public function get arenaCoin():int {
			return arena_coin$field;
		}

		/**
		 *  @private
		 */
		public static const TITLE_ID:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.title_id", "titleId", (49 << 3) | com.netease.protobuf.WireType.VARINT);

		private var title_id$field:int;

		public function clearTitleId():void {
			hasField$1 &= 0xffff7fff;
			title_id$field = new int();
		}

		public function get hasTitleId():Boolean {
			return (hasField$1 & 0x8000) != 0;
		}

		public function set titleId(value:int):void {
			hasField$1 |= 0x8000;
			title_id$field = value;
		}

		public function get titleId():int {
			return title_id$field;
		}

		/**
		 *  @private
		 */
		public static const TITLE_CREDIT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.title_credit", "titleCredit", (50 << 3) | com.netease.protobuf.WireType.VARINT);

		private var title_credit$field:int;

		public function clearTitleCredit():void {
			hasField$1 &= 0xfffeffff;
			title_credit$field = new int();
		}

		public function get hasTitleCredit():Boolean {
			return (hasField$1 & 0x10000) != 0;
		}

		public function set titleCredit(value:int):void {
			hasField$1 |= 0x10000;
			title_credit$field = value;
		}

		public function get titleCredit():int {
			return title_credit$field;
		}

		/**
		 *  @private
		 */
		public static const TITLE_STAR:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.title_star", "titleStar", (51 << 3) | com.netease.protobuf.WireType.VARINT);

		private var title_star$field:int;

		public function clearTitleStar():void {
			hasField$1 &= 0xfffdffff;
			title_star$field = new int();
		}

		public function get hasTitleStar():Boolean {
			return (hasField$1 & 0x20000) != 0;
		}

		public function set titleStar(value:int):void {
			hasField$1 |= 0x20000;
			title_star$field = value;
		}

		public function get titleStar():int {
			return title_star$field;
		}

		/**
		 *  @private
		 */
		public static const SIGN_WEEK_DAYS:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.sign_week_days", "signWeekDays", (52 << 3) | com.netease.protobuf.WireType.VARINT);

		private var sign_week_days$field:int;

		public function clearSignWeekDays():void {
			hasField$1 &= 0xfffbffff;
			sign_week_days$field = new int();
		}

		public function get hasSignWeekDays():Boolean {
			return (hasField$1 & 0x40000) != 0;
		}

		public function set signWeekDays(value:int):void {
			hasField$1 |= 0x40000;
			sign_week_days$field = value;
		}

		public function get signWeekDays():int {
			return sign_week_days$field;
		}

		/**
		 *  @private
		 */
		public static const SIGN_WEEK_LAST_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.sign_week_last_time", "signWeekLastTime", (53 << 3) | com.netease.protobuf.WireType.VARINT);

		private var sign_week_last_time$field:uint;

		public function clearSignWeekLastTime():void {
			hasField$1 &= 0xfff7ffff;
			sign_week_last_time$field = new uint();
		}

		public function get hasSignWeekLastTime():Boolean {
			return (hasField$1 & 0x80000) != 0;
		}

		public function set signWeekLastTime(value:uint):void {
			hasField$1 |= 0x80000;
			sign_week_last_time$field = value;
		}

		public function get signWeekLastTime():uint {
			return sign_week_last_time$field;
		}

		/**
		 *  @private
		 */
		public static const SIGN_MONTH_DAYS:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.sign_month_days", "signMonthDays", (54 << 3) | com.netease.protobuf.WireType.VARINT);

		private var sign_month_days$field:int;

		public function clearSignMonthDays():void {
			hasField$1 &= 0xffefffff;
			sign_month_days$field = new int();
		}

		public function get hasSignMonthDays():Boolean {
			return (hasField$1 & 0x100000) != 0;
		}

		public function set signMonthDays(value:int):void {
			hasField$1 |= 0x100000;
			sign_month_days$field = value;
		}

		public function get signMonthDays():int {
			return sign_month_days$field;
		}

		/**
		 *  @private
		 */
		public static const SIGN_MONTH_LAST_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.sign_month_last_time", "signMonthLastTime", (55 << 3) | com.netease.protobuf.WireType.VARINT);

		private var sign_month_last_time$field:uint;

		public function clearSignMonthLastTime():void {
			hasField$1 &= 0xffdfffff;
			sign_month_last_time$field = new uint();
		}

		public function get hasSignMonthLastTime():Boolean {
			return (hasField$1 & 0x200000) != 0;
		}

		public function set signMonthLastTime(value:uint):void {
			hasField$1 |= 0x200000;
			sign_month_last_time$field = value;
		}

		public function get signMonthLastTime():uint {
			return sign_month_last_time$field;
		}

		/**
		 *  @private
		 */
		public static const RESIGN_MONTH_DAYS:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.resign_month_days", "resignMonthDays", (56 << 3) | com.netease.protobuf.WireType.VARINT);

		private var resign_month_days$field:int;

		public function clearResignMonthDays():void {
			hasField$1 &= 0xffbfffff;
			resign_month_days$field = new int();
		}

		public function get hasResignMonthDays():Boolean {
			return (hasField$1 & 0x400000) != 0;
		}

		public function set resignMonthDays(value:int):void {
			hasField$1 |= 0x400000;
			resign_month_days$field = value;
		}

		public function get resignMonthDays():int {
			return resign_month_days$field;
		}

		/**
		 *  @private
		 */
		public static const PERIOD_PRIZE_DAYS:RepeatedFieldDescriptor_TYPE_INT32 = new RepeatedFieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.period_prize_days", "periodPrizeDays", (57 << 3) | com.netease.protobuf.WireType.VARINT);

		[ArrayElementType("int")]
		public var periodPrizeDays:Array = [];

		/**
		 *  @private
		 */
		public static const DECOMPOSE_COIN:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.decompose_coin", "decomposeCoin", (58 << 3) | com.netease.protobuf.WireType.VARINT);

		private var decompose_coin$field:int;

		public function clearDecomposeCoin():void {
			hasField$1 &= 0xff7fffff;
			decompose_coin$field = new int();
		}

		public function get hasDecomposeCoin():Boolean {
			return (hasField$1 & 0x800000) != 0;
		}

		public function set decomposeCoin(value:int):void {
			hasField$1 |= 0x800000;
			decompose_coin$field = value;
		}

		public function get decomposeCoin():int {
			return decompose_coin$field;
		}

		/**
		 *  @private
		 */
		public static const MOBA_COIN:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.moba_coin", "mobaCoin", (59 << 3) | com.netease.protobuf.WireType.VARINT);

		private var moba_coin$field:int;

		public function clearMobaCoin():void {
			hasField$1 &= 0xfeffffff;
			moba_coin$field = new int();
		}

		public function get hasMobaCoin():Boolean {
			return (hasField$1 & 0x1000000) != 0;
		}

		public function set mobaCoin(value:int):void {
			hasField$1 |= 0x1000000;
			moba_coin$field = value;
		}

		public function get mobaCoin():int {
			return moba_coin$field;
		}

		/**
		 *  @private
		 */
		public static const MOBA_EXP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.moba_exp", "mobaExp", (60 << 3) | com.netease.protobuf.WireType.VARINT);

		private var moba_exp$field:int;

		public function clearMobaExp():void {
			hasField$1 &= 0xfdffffff;
			moba_exp$field = new int();
		}

		public function get hasMobaExp():Boolean {
			return (hasField$1 & 0x2000000) != 0;
		}

		public function set mobaExp(value:int):void {
			hasField$1 |= 0x2000000;
			moba_exp$field = value;
		}

		public function get mobaExp():int {
			return moba_exp$field;
		}

		/**
		 *  @private
		 */
		public static const MOBA_POINT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.moba_point", "mobaPoint", (61 << 3) | com.netease.protobuf.WireType.VARINT);

		private var moba_point$field:int;

		public function clearMobaPoint():void {
			hasField$1 &= 0xfbffffff;
			moba_point$field = new int();
		}

		public function get hasMobaPoint():Boolean {
			return (hasField$1 & 0x4000000) != 0;
		}

		public function set mobaPoint(value:int):void {
			hasField$1 |= 0x4000000;
			moba_point$field = value;
		}

		public function get mobaPoint():int {
			return moba_point$field;
		}

		/**
		 *  @private
		 */
		public static const TODAY_MOBACOIN:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.today_mobacoin", "todayMobacoin", (62 << 3) | com.netease.protobuf.WireType.VARINT);

		private var today_mobacoin$field:int;

		public function clearTodayMobacoin():void {
			hasField$1 &= 0xf7ffffff;
			today_mobacoin$field = new int();
		}

		public function get hasTodayMobacoin():Boolean {
			return (hasField$1 & 0x8000000) != 0;
		}

		public function set todayMobacoin(value:int):void {
			hasField$1 |= 0x8000000;
			today_mobacoin$field = value;
		}

		public function get todayMobacoin():int {
			return today_mobacoin$field;
		}

		/**
		 *  @private
		 */
		public static const TODAY_MOBAEXP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.today_mobaexp", "todayMobaexp", (63 << 3) | com.netease.protobuf.WireType.VARINT);

		private var today_mobaexp$field:int;

		public function clearTodayMobaexp():void {
			hasField$1 &= 0xefffffff;
			today_mobaexp$field = new int();
		}

		public function get hasTodayMobaexp():Boolean {
			return (hasField$1 & 0x10000000) != 0;
		}

		public function set todayMobaexp(value:int):void {
			hasField$1 |= 0x10000000;
			today_mobaexp$field = value;
		}

		public function get todayMobaexp():int {
			return today_mobaexp$field;
		}

		/**
		 *  @private
		 */
		public static const TODAY_TEAMCOIN:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.today_teamcoin", "todayTeamcoin", (64 << 3) | com.netease.protobuf.WireType.VARINT);

		private var today_teamcoin$field:int;

		public function clearTodayTeamcoin():void {
			hasField$1 &= 0xdfffffff;
			today_teamcoin$field = new int();
		}

		public function get hasTodayTeamcoin():Boolean {
			return (hasField$1 & 0x20000000) != 0;
		}

		public function set todayTeamcoin(value:int):void {
			hasField$1 |= 0x20000000;
			today_teamcoin$field = value;
		}

		public function get todayTeamcoin():int {
			return today_teamcoin$field;
		}

		/**
		 *  @private
		 */
		public static const VIP_SIGNED_DAYS:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.vip_signed_days", "vipSignedDays", (65 << 3) | com.netease.protobuf.WireType.VARINT);

		private var vip_signed_days$field:int;

		public function clearVipSignedDays():void {
			hasField$1 &= 0xbfffffff;
			vip_signed_days$field = new int();
		}

		public function get hasVipSignedDays():Boolean {
			return (hasField$1 & 0x40000000) != 0;
		}

		public function set vipSignedDays(value:int):void {
			hasField$1 |= 0x40000000;
			vip_signed_days$field = value;
		}

		public function get vipSignedDays():int {
			return vip_signed_days$field;
		}

		/**
		 *  @private
		 */
		public static const CRYSTAL:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.crystal", "crystal", (66 << 3) | com.netease.protobuf.WireType.VARINT);

		private var crystal$field:uint;

		public function clearCrystal():void {
			hasField$1 &= 0x7fffffff;
			crystal$field = new uint();
		}

		public function get hasCrystal():Boolean {
			return (hasField$1 & 0x80000000) != 0;
		}

		public function set crystal(value:uint):void {
			hasField$1 |= 0x80000000;
			crystal$field = value;
		}

		public function get crystal():uint {
			return crystal$field;
		}

		/**
		 *  @private
		 */
		public static const CRYSTAL_UPDATE_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.crystal_update_time", "crystalUpdateTime", (67 << 3) | com.netease.protobuf.WireType.VARINT);

		private var crystal_update_time$field:uint;

		private var hasField$2:uint = 0;

		public function clearCrystalUpdateTime():void {
			hasField$2 &= 0xfffffffe;
			crystal_update_time$field = new uint();
		}

		public function get hasCrystalUpdateTime():Boolean {
			return (hasField$2 & 0x1) != 0;
		}

		public function set crystalUpdateTime(value:uint):void {
			hasField$2 |= 0x1;
			crystal_update_time$field = value;
		}

		public function get crystalUpdateTime():uint {
			return crystal_update_time$field;
		}

		/**
		 *  @private
		 */
		public static const CRYSTAL_OUTPUT_SECOND:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.crystal_output_second", "crystalOutputSecond", (68 << 3) | com.netease.protobuf.WireType.VARINT);

		private var crystal_output_second$field:uint;

		public function clearCrystalOutputSecond():void {
			hasField$2 &= 0xfffffffd;
			crystal_output_second$field = new uint();
		}

		public function get hasCrystalOutputSecond():Boolean {
			return (hasField$2 & 0x2) != 0;
		}

		public function set crystalOutputSecond(value:uint):void {
			hasField$2 |= 0x2;
			crystal_output_second$field = value;
		}

		public function get crystalOutputSecond():uint {
			return crystal_output_second$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2CRYSTALTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.diamond2crystaltime", "diamond2crystaltime", (69 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2crystaltime$field:uint;

		public function clearDiamond2crystaltime():void {
			hasField$2 &= 0xfffffffb;
			diamond2crystaltime$field = new uint();
		}

		public function get hasDiamond2crystaltime():Boolean {
			return (hasField$2 & 0x4) != 0;
		}

		public function set diamond2crystaltime(value:uint):void {
			hasField$2 |= 0x4;
			diamond2crystaltime$field = value;
		}

		public function get diamond2crystaltime():uint {
			return diamond2crystaltime$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2CRYSTALCOUNT:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.diamond2crystalcount", "diamond2crystalcount", (70 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2crystalcount$field:int;

		public function clearDiamond2crystalcount():void {
			hasField$2 &= 0xfffffff7;
			diamond2crystalcount$field = new int();
		}

		public function get hasDiamond2crystalcount():Boolean {
			return (hasField$2 & 0x8) != 0;
		}

		public function set diamond2crystalcount(value:int):void {
			hasField$2 |= 0x8;
			diamond2crystalcount$field = value;
		}

		public function get diamond2crystalcount():int {
			return diamond2crystalcount$field;
		}

		/**
		 *  @private
		 */
		public static const VIGOUR:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.vigour", "vigour", (71 << 3) | com.netease.protobuf.WireType.VARINT);

		private var vigour$field:uint;

		public function clearVigour():void {
			hasField$2 &= 0xffffffef;
			vigour$field = new uint();
		}

		public function get hasVigour():Boolean {
			return (hasField$2 & 0x10) != 0;
		}

		public function set vigour(value:uint):void {
			hasField$2 |= 0x10;
			vigour$field = value;
		}

		public function get vigour():uint {
			return vigour$field;
		}

		/**
		 *  @private
		 */
		public static const VIGOUR_UPDATE_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.vigour_update_time", "vigourUpdateTime", (72 << 3) | com.netease.protobuf.WireType.VARINT);

		private var vigour_update_time$field:uint;

		public function clearVigourUpdateTime():void {
			hasField$2 &= 0xffffffdf;
			vigour_update_time$field = new uint();
		}

		public function get hasVigourUpdateTime():Boolean {
			return (hasField$2 & 0x20) != 0;
		}

		public function set vigourUpdateTime(value:uint):void {
			hasField$2 |= 0x20;
			vigour_update_time$field = value;
		}

		public function get vigourUpdateTime():uint {
			return vigour_update_time$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2VIGOURTIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.diamond2vigourtime", "diamond2vigourtime", (73 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2vigourtime$field:uint;

		public function clearDiamond2vigourtime():void {
			hasField$2 &= 0xffffffbf;
			diamond2vigourtime$field = new uint();
		}

		public function get hasDiamond2vigourtime():Boolean {
			return (hasField$2 & 0x40) != 0;
		}

		public function set diamond2vigourtime(value:uint):void {
			hasField$2 |= 0x40;
			diamond2vigourtime$field = value;
		}

		public function get diamond2vigourtime():uint {
			return diamond2vigourtime$field;
		}

		/**
		 *  @private
		 */
		public static const DIAMOND2VIGOURCOUNT:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.diamond2vigourcount", "diamond2vigourcount", (74 << 3) | com.netease.protobuf.WireType.VARINT);

		private var diamond2vigourcount$field:uint;

		public function clearDiamond2vigourcount():void {
			hasField$2 &= 0xffffff7f;
			diamond2vigourcount$field = new uint();
		}

		public function get hasDiamond2vigourcount():Boolean {
			return (hasField$2 & 0x80) != 0;
		}

		public function set diamond2vigourcount(value:uint):void {
			hasField$2 |= 0x80;
			diamond2vigourcount$field = value;
		}

		public function get diamond2vigourcount():uint {
			return diamond2vigourcount$field;
		}

		/**
		 *  @private
		 */
		public static const RS_EXP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.rs_exp", "rsExp", (75 << 3) | com.netease.protobuf.WireType.VARINT);

		private var rs_exp$field:int;

		public function clearRsExp():void {
			hasField$2 &= 0xfffffeff;
			rs_exp$field = new int();
		}

		public function get hasRsExp():Boolean {
			return (hasField$2 & 0x100) != 0;
		}

		public function set rsExp(value:int):void {
			hasField$2 |= 0x100;
			rs_exp$field = value;
		}

		public function get rsExp():int {
			return rs_exp$field;
		}

		/**
		 *  @private
		 */
		public static const RS_RECEIVED_REWARD_ID:RepeatedFieldDescriptor_TYPE_INT32 = new RepeatedFieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.rs_received_reward_id", "rsReceivedRewardId", (76 << 3) | com.netease.protobuf.WireType.VARINT);

		[ArrayElementType("int")]
		public var rsReceivedRewardId:Array = [];

		/**
		 *  @private
		 */
		public static const RS_RECEIVED_REWARD_LV:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.rs_received_reward_lv", "rsReceivedRewardLv", (77 << 3) | com.netease.protobuf.WireType.VARINT);

		private var rs_received_reward_lv$field:int;

		public function clearRsReceivedRewardLv():void {
			hasField$2 &= 0xfffffdff;
			rs_received_reward_lv$field = new int();
		}

		public function get hasRsReceivedRewardLv():Boolean {
			return (hasField$2 & 0x200) != 0;
		}

		public function set rsReceivedRewardLv(value:int):void {
			hasField$2 |= 0x200;
			rs_received_reward_lv$field = value;
		}

		public function get rsReceivedRewardLv():int {
			if(!hasRsReceivedRewardLv) {
				return 1;
			}
			return rs_received_reward_lv$field;
		}

		/**
		 *  @private
		 */
		public static const DUNGEON_BUYCOUNT_TIME:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.dungeon_buycount_time", "dungeonBuycountTime", (78 << 3) | com.netease.protobuf.WireType.VARINT);

		private var dungeon_buycount_time$field:uint;

		public function clearDungeonBuycountTime():void {
			hasField$2 &= 0xfffffbff;
			dungeon_buycount_time$field = new uint();
		}

		public function get hasDungeonBuycountTime():Boolean {
			return (hasField$2 & 0x400) != 0;
		}

		public function set dungeonBuycountTime(value:uint):void {
			hasField$2 |= 0x400;
			dungeon_buycount_time$field = value;
		}

		public function get dungeonBuycountTime():uint {
			return dungeon_buycount_time$field;
		}

		/**
		 *  @private
		 */
		public static const DUNGEON_BUYCOUNT_NUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.dungeon_buycount_num", "dungeonBuycountNum", (79 << 3) | com.netease.protobuf.WireType.VARINT);

		private var dungeon_buycount_num$field:int;

		public function clearDungeonBuycountNum():void {
			hasField$2 &= 0xfffff7ff;
			dungeon_buycount_num$field = new int();
		}

		public function get hasDungeonBuycountNum():Boolean {
			return (hasField$2 & 0x800) != 0;
		}

		public function set dungeonBuycountNum(value:int):void {
			hasField$2 |= 0x800;
			dungeon_buycount_num$field = value;
		}

		public function get dungeonBuycountNum():int {
			return dungeon_buycount_num$field;
		}

		/**
		 *  @private
		 */
		public static const PEERAGE_AVATAR_ID:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.peerage_avatar_id", "peerageAvatarId", (80 << 3) | com.netease.protobuf.WireType.VARINT);

		private var peerage_avatar_id$field:int;

		public function clearPeerageAvatarId():void {
			hasField$2 &= 0xffffefff;
			peerage_avatar_id$field = new int();
		}

		public function get hasPeerageAvatarId():Boolean {
			return (hasField$2 & 0x1000) != 0;
		}

		public function set peerageAvatarId(value:int):void {
			hasField$2 |= 0x1000;
			peerage_avatar_id$field = value;
		}

		public function get peerageAvatarId():int {
			return peerage_avatar_id$field;
		}

		/**
		 *  @private
		 */
		public static const PEERAGE_LEV:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.peerage_lev", "peerageLev", (81 << 3) | com.netease.protobuf.WireType.VARINT);

		private var peerage_lev$field:int;

		public function clearPeerageLev():void {
			hasField$2 &= 0xffffdfff;
			peerage_lev$field = new int();
		}

		public function get hasPeerageLev():Boolean {
			return (hasField$2 & 0x2000) != 0;
		}

		public function set peerageLev(value:int):void {
			hasField$2 |= 0x2000;
			peerage_lev$field = value;
		}

		public function get peerageLev():int {
			return peerage_lev$field;
		}

		/**
		 *  @private
		 */
		public static const PEERAGE_EXP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.peerage_exp", "peerageExp", (82 << 3) | com.netease.protobuf.WireType.VARINT);

		private var peerage_exp$field:int;

		public function clearPeerageExp():void {
			hasField$2 &= 0xffffbfff;
			peerage_exp$field = new int();
		}

		public function get hasPeerageExp():Boolean {
			return (hasField$2 & 0x4000) != 0;
		}

		public function set peerageExp(value:int):void {
			hasField$2 |= 0x4000;
			peerage_exp$field = value;
		}

		public function get peerageExp():int {
			return peerage_exp$field;
		}

		/**
		 *  @private
		 */
		public static const MONEY_CARD_HERO_NUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.money_card_hero_num", "moneyCardHeroNum", (83 << 3) | com.netease.protobuf.WireType.VARINT);

		private var money_card_hero_num$field:int;

		public function clearMoneyCardHeroNum():void {
			hasField$2 &= 0xffff7fff;
			money_card_hero_num$field = new int();
		}

		public function get hasMoneyCardHeroNum():Boolean {
			return (hasField$2 & 0x8000) != 0;
		}

		public function set moneyCardHeroNum(value:int):void {
			hasField$2 |= 0x8000;
			money_card_hero_num$field = value;
		}

		public function get moneyCardHeroNum():int {
			return money_card_hero_num$field;
		}

		/**
		 *  @private
		 */
		public static const GOLD_CARD_HERO_NUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.gold_card_hero_num", "goldCardHeroNum", (84 << 3) | com.netease.protobuf.WireType.VARINT);

		private var gold_card_hero_num$field:int;

		public function clearGoldCardHeroNum():void {
			hasField$2 &= 0xfffeffff;
			gold_card_hero_num$field = new int();
		}

		public function get hasGoldCardHeroNum():Boolean {
			return (hasField$2 & 0x10000) != 0;
		}

		public function set goldCardHeroNum(value:int):void {
			hasField$2 |= 0x10000;
			gold_card_hero_num$field = value;
		}

		public function get goldCardHeroNum():int {
			return gold_card_hero_num$field;
		}

		/**
		 *  @private
		 */
		public static const ARENA_UNREAD_FLAG:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.arena_unread_flag", "arenaUnreadFlag", (85 << 3) | com.netease.protobuf.WireType.VARINT);

		private var arena_unread_flag$field:int;

		public function clearArenaUnreadFlag():void {
			hasField$2 &= 0xfffdffff;
			arena_unread_flag$field = new int();
		}

		public function get hasArenaUnreadFlag():Boolean {
			return (hasField$2 & 0x20000) != 0;
		}

		public function set arenaUnreadFlag(value:int):void {
			hasField$2 |= 0x20000;
			arena_unread_flag$field = value;
		}

		public function get arenaUnreadFlag():int {
			return arena_unread_flag$field;
		}

		/**
		 *  @private
		 */
		public static const ZODIAC_SOUL:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.zodiac_soul", "zodiacSoul", (86 << 3) | com.netease.protobuf.WireType.VARINT);

		private var zodiac_soul$field:uint;

		public function clearZodiacSoul():void {
			hasField$2 &= 0xfffbffff;
			zodiac_soul$field = new uint();
		}

		public function get hasZodiacSoul():Boolean {
			return (hasField$2 & 0x40000) != 0;
		}

		public function set zodiacSoul(value:uint):void {
			hasField$2 |= 0x40000;
			zodiac_soul$field = value;
		}

		public function get zodiacSoul():uint {
			return zodiac_soul$field;
		}

		/**
		 *  @private
		 */
		public static const LOTTERY_TOTAL_TIMES:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.lottery_total_times", "lotteryTotalTimes", (87 << 3) | com.netease.protobuf.WireType.VARINT);

		private var lottery_total_times$field:int;

		public function clearLotteryTotalTimes():void {
			hasField$2 &= 0xfff7ffff;
			lottery_total_times$field = new int();
		}

		public function get hasLotteryTotalTimes():Boolean {
			return (hasField$2 & 0x80000) != 0;
		}

		public function set lotteryTotalTimes(value:int):void {
			hasField$2 |= 0x80000;
			lottery_total_times$field = value;
		}

		public function get lotteryTotalTimes():int {
			return lottery_total_times$field;
		}

		/**
		 *  @private
		 */
		public static const LOTTERY_FREE_NUM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.lottery_free_num", "lotteryFreeNum", (88 << 3) | com.netease.protobuf.WireType.VARINT);

		private var lottery_free_num$field:int;

		public function clearLotteryFreeNum():void {
			hasField$2 &= 0xffefffff;
			lottery_free_num$field = new int();
		}

		public function get hasLotteryFreeNum():Boolean {
			return (hasField$2 & 0x100000) != 0;
		}

		public function set lotteryFreeNum(value:int):void {
			hasField$2 |= 0x100000;
			lottery_free_num$field = value;
		}

		public function get lotteryFreeNum():int {
			return lottery_free_num$field;
		}

		/**
		 *  @private
		 */
		public static const LOTTERY_FREE_TIME:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.lottery_free_time", "lotteryFreeTime", (89 << 3) | com.netease.protobuf.WireType.VARINT);

		private var lottery_free_time$field:int;

		public function clearLotteryFreeTime():void {
			hasField$2 &= 0xffdfffff;
			lottery_free_time$field = new int();
		}

		public function get hasLotteryFreeTime():Boolean {
			return (hasField$2 & 0x200000) != 0;
		}

		public function set lotteryFreeTime(value:int):void {
			hasField$2 |= 0x200000;
			lottery_free_time$field = value;
		}

		public function get lotteryFreeTime():int {
			return lottery_free_time$field;
		}

		/**
		 *  @private
		 */
		public static const MAGIC_CRYSTAL:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.magic_crystal", "magicCrystal", (90 << 3) | com.netease.protobuf.WireType.VARINT);

		private var magic_crystal$field:int;

		public function clearMagicCrystal():void {
			hasField$2 &= 0xffbfffff;
			magic_crystal$field = new int();
		}

		public function get hasMagicCrystal():Boolean {
			return (hasField$2 & 0x400000) != 0;
		}

		public function set magicCrystal(value:int):void {
			hasField$2 |= 0x400000;
			magic_crystal$field = value;
		}

		public function get magicCrystal():int {
			return magic_crystal$field;
		}

		/**
		 *  @private
		 */
		public static const BIG_AWARD_COUNT_DOWN:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.big_award_count_down", "bigAwardCountDown", (91 << 3) | com.netease.protobuf.WireType.VARINT);

		private var big_award_count_down$field:int;

		public function clearBigAwardCountDown():void {
			hasField$2 &= 0xff7fffff;
			big_award_count_down$field = new int();
		}

		public function get hasBigAwardCountDown():Boolean {
			return (hasField$2 & 0x800000) != 0;
		}

		public function set bigAwardCountDown(value:int):void {
			hasField$2 |= 0x800000;
			big_award_count_down$field = value;
		}

		public function get bigAwardCountDown():int {
			return big_award_count_down$field;
		}

		/**
		 *  @private
		 */
		public static const MAX_VP:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.max_vp", "maxVp", (92 << 3) | com.netease.protobuf.WireType.VARINT);

		private var max_vp$field:uint;

		public function clearMaxVp():void {
			hasField$2 &= 0xfeffffff;
			max_vp$field = new uint();
		}

		public function get hasMaxVp():Boolean {
			return (hasField$2 & 0x1000000) != 0;
		}

		public function set maxVp(value:uint):void {
			hasField$2 |= 0x1000000;
			max_vp$field = value;
		}

		public function get maxVp():uint {
			return max_vp$field;
		}

		/**
		 *  @private
		 */
		public static const UNLOCKED_CHAPTER_ID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.unlocked_chapter_id", "unlockedChapterId", (93 << 3) | com.netease.protobuf.WireType.VARINT);

		private var unlocked_chapter_id$field:uint;

		public function clearUnlockedChapterId():void {
			hasField$2 &= 0xfdffffff;
			unlocked_chapter_id$field = new uint();
		}

		public function get hasUnlockedChapterId():Boolean {
			return (hasField$2 & 0x2000000) != 0;
		}

		public function set unlockedChapterId(value:uint):void {
			hasField$2 |= 0x2000000;
			unlocked_chapter_id$field = value;
		}

		public function get unlockedChapterId():uint {
			return unlocked_chapter_id$field;
		}

		/**
		 *  @private
		 */
		public static const UNLOCKED_WORLD_FOG_ID:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.role_base_info.unlocked_world_fog_id", "unlockedWorldFogId", (94 << 3) | com.netease.protobuf.WireType.VARINT);

		private var unlocked_world_fog_id$field:uint;

		public function clearUnlockedWorldFogId():void {
			hasField$2 &= 0xfbffffff;
			unlocked_world_fog_id$field = new uint();
		}

		public function get hasUnlockedWorldFogId():Boolean {
			return (hasField$2 & 0x4000000) != 0;
		}

		public function set unlockedWorldFogId(value:uint):void {
			hasField$2 |= 0x4000000;
			unlocked_world_fog_id$field = value;
		}

		public function get unlockedWorldFogId():uint {
			return unlocked_world_fog_id$field;
		}

		/**
		 *  @private
		 */
		public static const LIANGCAO:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.liangcao", "liangcao", (95 << 3) | com.netease.protobuf.WireType.VARINT);

		private var liangcao$field:int;

		public function clearLiangcao():void {
			hasField$2 &= 0xf7ffffff;
			liangcao$field = new int();
		}

		public function get hasLiangcao():Boolean {
			return (hasField$2 & 0x8000000) != 0;
		}

		public function set liangcao(value:int):void {
			hasField$2 |= 0x8000000;
			liangcao$field = value;
		}

		public function get liangcao():int {
			return liangcao$field;
		}

		/**
		 *  @private
		 */
		public static const PLAYER_CAMP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.player_camp", "playerCamp", (96 << 3) | com.netease.protobuf.WireType.VARINT);

		private var player_camp$field:int;

		public function clearPlayerCamp():void {
			hasField$2 &= 0xefffffff;
			player_camp$field = new int();
		}

		public function get hasPlayerCamp():Boolean {
			return (hasField$2 & 0x10000000) != 0;
		}

		public function set playerCamp(value:int):void {
			hasField$2 |= 0x10000000;
			player_camp$field = value;
		}

		public function get playerCamp():int {
			if(!hasPlayerCamp) {
				return 0;
			}
			return player_camp$field;
		}

		/**
		 *  @private
		 */
		public static const COUNTRY_LV:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.country_lv", "countryLv", (97 << 3) | com.netease.protobuf.WireType.VARINT);

		private var country_lv$field:int;

		public function clearCountryLv():void {
			hasField$2 &= 0xdfffffff;
			country_lv$field = new int();
		}

		public function get hasCountryLv():Boolean {
			return (hasField$2 & 0x20000000) != 0;
		}

		public function set countryLv(value:int):void {
			hasField$2 |= 0x20000000;
			country_lv$field = value;
		}

		public function get countryLv():int {
			if(!hasCountryLv) {
				return 0;
			}
			return country_lv$field;
		}

		/**
		 *  @private
		 */
		public static const FREE_PHANTOM:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.free_phantom", "freePhantom", (98 << 3) | com.netease.protobuf.WireType.VARINT);

		private var free_phantom$field:int;

		public function clearFreePhantom():void {
			hasField$2 &= 0xbfffffff;
			free_phantom$field = new int();
		}

		public function get hasFreePhantom():Boolean {
			return (hasField$2 & 0x40000000) != 0;
		}

		public function set freePhantom(value:int):void {
			hasField$2 |= 0x40000000;
			free_phantom$field = value;
		}

		public function get freePhantom():int {
			return free_phantom$field;
		}

		/**
		 *  @private
		 */
		public static const CAN_GAIN_PHANTOM_EXP:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.role_base_info.can_gain_phantom_exp", "canGainPhantomExp", (99 << 3) | com.netease.protobuf.WireType.VARINT);

		private var can_gain_phantom_exp$field:int;

		public function clearCanGainPhantomExp():void {
			hasField$2 &= 0x7fffffff;
			can_gain_phantom_exp$field = new int();
		}

		public function get hasCanGainPhantomExp():Boolean {
			return (hasField$2 & 0x80000000) != 0;
		}

		public function set canGainPhantomExp(value:int):void {
			hasField$2 |= 0x80000000;
			can_gain_phantom_exp$field = value;
		}

		public function get canGainPhantomExp():int {
			return can_gain_phantom_exp$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			if (hasLevel) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, level$field);
			}
			if (hasCommonscene) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 2);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, commonscene$field);
			}
			if (hasHardscene) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, hardscene$field);
			}
			if (hasAccount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.LENGTH_DELIMITED, 4);
				com.netease.protobuf.WriteUtils.write_TYPE_STRING(output, account$field);
			}
			if (hasHeroid) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 5);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, heroid$field);
			}
			if (hasVp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 6);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, vp$field);
			}
			if (hasVpUpdateTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 7);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, vp_update_time$field);
			}
			if (hasExp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 8);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, exp$field);
			}
			if (hasCoin) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 9);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, coin$field);
			}
			if (hasDiamond) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 10);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, diamond$field);
			}
			if (hasViplevel) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 11);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, viplevel$field);
			}
			if (hasVipexp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 12);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, vipexp$field);
			}
			if (hasLastleavetime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 13);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, lastleavetime$field);
			}
			if (hasOnemoneycardingtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 14);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, onemoneycardingtime$field);
			}
			if (hasOnemoneycardingcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 15);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, onemoneycardingcount$field);
			}
			if (hasTenmoneycardingtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 16);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, tenmoneycardingtime$field);
			}
			if (hasTenmoneycardingcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 17);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, tenmoneycardingcount$field);
			}
			if (hasOnegoldcardingtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 18);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, onegoldcardingtime$field);
			}
			if (hasOnegoldcardingcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 19);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, onegoldcardingcount$field);
			}
			if (hasTengoldcardingtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 20);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, tengoldcardingtime$field);
			}
			if (hasTengoldcardingcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 21);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, tengoldcardingcount$field);
			}
			if (hasOneequipmoneycardingtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 22);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, oneequipmoneycardingtime$field);
			}
			if (hasOneequipmoneycardingcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 23);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, oneequipmoneycardingcount$field);
			}
			if (hasTenequipmoneycardingtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 24);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, tenequipmoneycardingtime$field);
			}
			if (hasTenequipmoneycardingcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 25);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, tenequipmoneycardingcount$field);
			}
			if (hasOneequipgoldcardingtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 26);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, oneequipgoldcardingtime$field);
			}
			if (hasOneequipgoldcardingcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 27);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, oneequipgoldcardingcount$field);
			}
			if (hasTenequipgoldcardingtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 28);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, tenequipgoldcardingtime$field);
			}
			if (hasTenequipgoldcardingcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 29);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, tenequipgoldcardingcount$field);
			}
			if (hasDiamond2cointime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 30);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, diamond2cointime$field);
			}
			if (hasDiamond2coincount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 31);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, diamond2coincount$field);
			}
			if (hasDiamond2energytime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 32);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, diamond2energytime$field);
			}
			if (hasDiamond2energycount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 33);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, diamond2energycount$field);
			}
			if (hasSkillnum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 34);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, skillnum$field);
			}
			if (hasSkillnumUpdateTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 35);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, skillnum_update_time$field);
			}
			if (hasDiamond2skillnumtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 36);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, diamond2skillnumtime$field);
			}
			if (hasDiamond2skillnumcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 37);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, diamond2skillnumcount$field);
			}
			if (hasWorldchattime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 38);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, worldchattime$field);
			}
			if (hasWorldchatcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 39);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, worldchatcount$field);
			}
			if (hasArenatime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 40);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, arenatime$field);
			}
			if (hasArenacount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 41);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, arenacount$field);
			}
			if (hasArenacdtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 42);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, arenacdtime$field);
			}
			if (hasArenacdvalue) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 43);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, arenacdvalue$field);
			}
			if (hasArenaResetcdTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 44);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, arena_resetcd_time$field);
			}
			if (hasArenaResetcdCount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 45);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, arena_resetcd_count$field);
			}
			if (hasArenaBuycountTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 46);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, arena_buycount_time$field);
			}
			if (hasArenaBuycountNum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 47);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, arena_buycount_num$field);
			}
			if (hasArenaCoin) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 48);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, arena_coin$field);
			}
			if (hasTitleId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 49);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, title_id$field);
			}
			if (hasTitleCredit) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 50);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, title_credit$field);
			}
			if (hasTitleStar) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 51);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, title_star$field);
			}
			if (hasSignWeekDays) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 52);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, sign_week_days$field);
			}
			if (hasSignWeekLastTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 53);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, sign_week_last_time$field);
			}
			if (hasSignMonthDays) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 54);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, sign_month_days$field);
			}
			if (hasSignMonthLastTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 55);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, sign_month_last_time$field);
			}
			if (hasResignMonthDays) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 56);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, resign_month_days$field);
			}
			for (var periodPrizeDays$index:uint = 0; periodPrizeDays$index < this.periodPrizeDays.length; ++periodPrizeDays$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 57);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.periodPrizeDays[periodPrizeDays$index]);
			}
			if (hasDecomposeCoin) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 58);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, decompose_coin$field);
			}
			if (hasMobaCoin) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 59);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, moba_coin$field);
			}
			if (hasMobaExp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 60);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, moba_exp$field);
			}
			if (hasMobaPoint) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 61);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, moba_point$field);
			}
			if (hasTodayMobacoin) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 62);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, today_mobacoin$field);
			}
			if (hasTodayMobaexp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 63);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, today_mobaexp$field);
			}
			if (hasTodayTeamcoin) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 64);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, today_teamcoin$field);
			}
			if (hasVipSignedDays) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 65);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, vip_signed_days$field);
			}
			if (hasCrystal) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 66);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, crystal$field);
			}
			if (hasCrystalUpdateTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 67);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, crystal_update_time$field);
			}
			if (hasCrystalOutputSecond) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 68);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, crystal_output_second$field);
			}
			if (hasDiamond2crystaltime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 69);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, diamond2crystaltime$field);
			}
			if (hasDiamond2crystalcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 70);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, diamond2crystalcount$field);
			}
			if (hasVigour) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 71);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, vigour$field);
			}
			if (hasVigourUpdateTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 72);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, vigour_update_time$field);
			}
			if (hasDiamond2vigourtime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 73);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, diamond2vigourtime$field);
			}
			if (hasDiamond2vigourcount) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 74);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, diamond2vigourcount$field);
			}
			if (hasRsExp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 75);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, rs_exp$field);
			}
			for (var rsReceivedRewardId$index:uint = 0; rsReceivedRewardId$index < this.rsReceivedRewardId.length; ++rsReceivedRewardId$index) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 76);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.rsReceivedRewardId[rsReceivedRewardId$index]);
			}
			if (hasRsReceivedRewardLv) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 77);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, rs_received_reward_lv$field);
			}
			if (hasDungeonBuycountTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 78);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, dungeon_buycount_time$field);
			}
			if (hasDungeonBuycountNum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 79);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, dungeon_buycount_num$field);
			}
			if (hasPeerageAvatarId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 80);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, peerage_avatar_id$field);
			}
			if (hasPeerageLev) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 81);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, peerage_lev$field);
			}
			if (hasPeerageExp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 82);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, peerage_exp$field);
			}
			if (hasMoneyCardHeroNum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 83);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, money_card_hero_num$field);
			}
			if (hasGoldCardHeroNum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 84);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, gold_card_hero_num$field);
			}
			if (hasArenaUnreadFlag) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 85);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, arena_unread_flag$field);
			}
			if (hasZodiacSoul) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 86);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, zodiac_soul$field);
			}
			if (hasLotteryTotalTimes) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 87);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, lottery_total_times$field);
			}
			if (hasLotteryFreeNum) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 88);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, lottery_free_num$field);
			}
			if (hasLotteryFreeTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 89);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, lottery_free_time$field);
			}
			if (hasMagicCrystal) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 90);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, magic_crystal$field);
			}
			if (hasBigAwardCountDown) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 91);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, big_award_count_down$field);
			}
			if (hasMaxVp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 92);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, max_vp$field);
			}
			if (hasUnlockedChapterId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 93);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, unlocked_chapter_id$field);
			}
			if (hasUnlockedWorldFogId) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 94);
				com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, unlocked_world_fog_id$field);
			}
			if (hasLiangcao) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 95);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, liangcao$field);
			}
			if (hasPlayerCamp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 96);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, player_camp$field);
			}
			if (hasCountryLv) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 97);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, country_lv$field);
			}
			if (hasFreePhantom) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 98);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, free_phantom$field);
			}
			if (hasCanGainPhantomExp) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 99);
				com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, can_gain_phantom_exp$field);
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
			var commonscene$count:uint = 0;
			var hardscene$count:uint = 0;
			var account$count:uint = 0;
			var heroid$count:uint = 0;
			var vp$count:uint = 0;
			var vp_update_time$count:uint = 0;
			var exp$count:uint = 0;
			var coin$count:uint = 0;
			var diamond$count:uint = 0;
			var viplevel$count:uint = 0;
			var vipexp$count:uint = 0;
			var lastleavetime$count:uint = 0;
			var onemoneycardingtime$count:uint = 0;
			var onemoneycardingcount$count:uint = 0;
			var tenmoneycardingtime$count:uint = 0;
			var tenmoneycardingcount$count:uint = 0;
			var onegoldcardingtime$count:uint = 0;
			var onegoldcardingcount$count:uint = 0;
			var tengoldcardingtime$count:uint = 0;
			var tengoldcardingcount$count:uint = 0;
			var oneequipmoneycardingtime$count:uint = 0;
			var oneequipmoneycardingcount$count:uint = 0;
			var tenequipmoneycardingtime$count:uint = 0;
			var tenequipmoneycardingcount$count:uint = 0;
			var oneequipgoldcardingtime$count:uint = 0;
			var oneequipgoldcardingcount$count:uint = 0;
			var tenequipgoldcardingtime$count:uint = 0;
			var tenequipgoldcardingcount$count:uint = 0;
			var diamond2cointime$count:uint = 0;
			var diamond2coincount$count:uint = 0;
			var diamond2energytime$count:uint = 0;
			var diamond2energycount$count:uint = 0;
			var skillnum$count:uint = 0;
			var skillnum_update_time$count:uint = 0;
			var diamond2skillnumtime$count:uint = 0;
			var diamond2skillnumcount$count:uint = 0;
			var worldchattime$count:uint = 0;
			var worldchatcount$count:uint = 0;
			var arenatime$count:uint = 0;
			var arenacount$count:uint = 0;
			var arenacdtime$count:uint = 0;
			var arenacdvalue$count:uint = 0;
			var arena_resetcd_time$count:uint = 0;
			var arena_resetcd_count$count:uint = 0;
			var arena_buycount_time$count:uint = 0;
			var arena_buycount_num$count:uint = 0;
			var arena_coin$count:uint = 0;
			var title_id$count:uint = 0;
			var title_credit$count:uint = 0;
			var title_star$count:uint = 0;
			var sign_week_days$count:uint = 0;
			var sign_week_last_time$count:uint = 0;
			var sign_month_days$count:uint = 0;
			var sign_month_last_time$count:uint = 0;
			var resign_month_days$count:uint = 0;
			var decompose_coin$count:uint = 0;
			var moba_coin$count:uint = 0;
			var moba_exp$count:uint = 0;
			var moba_point$count:uint = 0;
			var today_mobacoin$count:uint = 0;
			var today_mobaexp$count:uint = 0;
			var today_teamcoin$count:uint = 0;
			var vip_signed_days$count:uint = 0;
			var crystal$count:uint = 0;
			var crystal_update_time$count:uint = 0;
			var crystal_output_second$count:uint = 0;
			var diamond2crystaltime$count:uint = 0;
			var diamond2crystalcount$count:uint = 0;
			var vigour$count:uint = 0;
			var vigour_update_time$count:uint = 0;
			var diamond2vigourtime$count:uint = 0;
			var diamond2vigourcount$count:uint = 0;
			var rs_exp$count:uint = 0;
			var rs_received_reward_lv$count:uint = 0;
			var dungeon_buycount_time$count:uint = 0;
			var dungeon_buycount_num$count:uint = 0;
			var peerage_avatar_id$count:uint = 0;
			var peerage_lev$count:uint = 0;
			var peerage_exp$count:uint = 0;
			var money_card_hero_num$count:uint = 0;
			var gold_card_hero_num$count:uint = 0;
			var arena_unread_flag$count:uint = 0;
			var zodiac_soul$count:uint = 0;
			var lottery_total_times$count:uint = 0;
			var lottery_free_num$count:uint = 0;
			var lottery_free_time$count:uint = 0;
			var magic_crystal$count:uint = 0;
			var big_award_count_down$count:uint = 0;
			var max_vp$count:uint = 0;
			var unlocked_chapter_id$count:uint = 0;
			var unlocked_world_fog_id$count:uint = 0;
			var liangcao$count:uint = 0;
			var player_camp$count:uint = 0;
			var country_lv$count:uint = 0;
			var free_phantom$count:uint = 0;
			var can_gain_phantom_exp$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (level$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.level cannot be set twice.');
					}
					++level$count;
					this.level = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 2:
					if (commonscene$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.commonscene cannot be set twice.');
					}
					++commonscene$count;
					this.commonscene = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 3:
					if (hardscene$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.hardscene cannot be set twice.');
					}
					++hardscene$count;
					this.hardscene = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 4:
					if (account$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.account cannot be set twice.');
					}
					++account$count;
					this.account = com.netease.protobuf.ReadUtils.read_TYPE_STRING(input);
					break;
				case 5:
					if (heroid$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.heroid cannot be set twice.');
					}
					++heroid$count;
					this.heroid = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 6:
					if (vp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.vp cannot be set twice.');
					}
					++vp$count;
					this.vp = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 7:
					if (vp_update_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.vpUpdateTime cannot be set twice.');
					}
					++vp_update_time$count;
					this.vpUpdateTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 8:
					if (exp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.exp cannot be set twice.');
					}
					++exp$count;
					this.exp = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 9:
					if (coin$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.coin cannot be set twice.');
					}
					++coin$count;
					this.coin = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 10:
					if (diamond$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond cannot be set twice.');
					}
					++diamond$count;
					this.diamond = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 11:
					if (viplevel$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.viplevel cannot be set twice.');
					}
					++viplevel$count;
					this.viplevel = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 12:
					if (vipexp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.vipexp cannot be set twice.');
					}
					++vipexp$count;
					this.vipexp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 13:
					if (lastleavetime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.lastleavetime cannot be set twice.');
					}
					++lastleavetime$count;
					this.lastleavetime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 14:
					if (onemoneycardingtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.onemoneycardingtime cannot be set twice.');
					}
					++onemoneycardingtime$count;
					this.onemoneycardingtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 15:
					if (onemoneycardingcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.onemoneycardingcount cannot be set twice.');
					}
					++onemoneycardingcount$count;
					this.onemoneycardingcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 16:
					if (tenmoneycardingtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.tenmoneycardingtime cannot be set twice.');
					}
					++tenmoneycardingtime$count;
					this.tenmoneycardingtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 17:
					if (tenmoneycardingcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.tenmoneycardingcount cannot be set twice.');
					}
					++tenmoneycardingcount$count;
					this.tenmoneycardingcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 18:
					if (onegoldcardingtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.onegoldcardingtime cannot be set twice.');
					}
					++onegoldcardingtime$count;
					this.onegoldcardingtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 19:
					if (onegoldcardingcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.onegoldcardingcount cannot be set twice.');
					}
					++onegoldcardingcount$count;
					this.onegoldcardingcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 20:
					if (tengoldcardingtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.tengoldcardingtime cannot be set twice.');
					}
					++tengoldcardingtime$count;
					this.tengoldcardingtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 21:
					if (tengoldcardingcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.tengoldcardingcount cannot be set twice.');
					}
					++tengoldcardingcount$count;
					this.tengoldcardingcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 22:
					if (oneequipmoneycardingtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.oneequipmoneycardingtime cannot be set twice.');
					}
					++oneequipmoneycardingtime$count;
					this.oneequipmoneycardingtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 23:
					if (oneequipmoneycardingcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.oneequipmoneycardingcount cannot be set twice.');
					}
					++oneequipmoneycardingcount$count;
					this.oneequipmoneycardingcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 24:
					if (tenequipmoneycardingtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.tenequipmoneycardingtime cannot be set twice.');
					}
					++tenequipmoneycardingtime$count;
					this.tenequipmoneycardingtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 25:
					if (tenequipmoneycardingcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.tenequipmoneycardingcount cannot be set twice.');
					}
					++tenequipmoneycardingcount$count;
					this.tenequipmoneycardingcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 26:
					if (oneequipgoldcardingtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.oneequipgoldcardingtime cannot be set twice.');
					}
					++oneequipgoldcardingtime$count;
					this.oneequipgoldcardingtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 27:
					if (oneequipgoldcardingcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.oneequipgoldcardingcount cannot be set twice.');
					}
					++oneequipgoldcardingcount$count;
					this.oneequipgoldcardingcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 28:
					if (tenequipgoldcardingtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.tenequipgoldcardingtime cannot be set twice.');
					}
					++tenequipgoldcardingtime$count;
					this.tenequipgoldcardingtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 29:
					if (tenequipgoldcardingcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.tenequipgoldcardingcount cannot be set twice.');
					}
					++tenequipgoldcardingcount$count;
					this.tenequipgoldcardingcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 30:
					if (diamond2cointime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2cointime cannot be set twice.');
					}
					++diamond2cointime$count;
					this.diamond2cointime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 31:
					if (diamond2coincount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2coincount cannot be set twice.');
					}
					++diamond2coincount$count;
					this.diamond2coincount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 32:
					if (diamond2energytime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2energytime cannot be set twice.');
					}
					++diamond2energytime$count;
					this.diamond2energytime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 33:
					if (diamond2energycount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2energycount cannot be set twice.');
					}
					++diamond2energycount$count;
					this.diamond2energycount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 34:
					if (skillnum$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.skillnum cannot be set twice.');
					}
					++skillnum$count;
					this.skillnum = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 35:
					if (skillnum_update_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.skillnumUpdateTime cannot be set twice.');
					}
					++skillnum_update_time$count;
					this.skillnumUpdateTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 36:
					if (diamond2skillnumtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2skillnumtime cannot be set twice.');
					}
					++diamond2skillnumtime$count;
					this.diamond2skillnumtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 37:
					if (diamond2skillnumcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2skillnumcount cannot be set twice.');
					}
					++diamond2skillnumcount$count;
					this.diamond2skillnumcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 38:
					if (worldchattime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.worldchattime cannot be set twice.');
					}
					++worldchattime$count;
					this.worldchattime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 39:
					if (worldchatcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.worldchatcount cannot be set twice.');
					}
					++worldchatcount$count;
					this.worldchatcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 40:
					if (arenatime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenatime cannot be set twice.');
					}
					++arenatime$count;
					this.arenatime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 41:
					if (arenacount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenacount cannot be set twice.');
					}
					++arenacount$count;
					this.arenacount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 42:
					if (arenacdtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenacdtime cannot be set twice.');
					}
					++arenacdtime$count;
					this.arenacdtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 43:
					if (arenacdvalue$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenacdvalue cannot be set twice.');
					}
					++arenacdvalue$count;
					this.arenacdvalue = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 44:
					if (arena_resetcd_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenaResetcdTime cannot be set twice.');
					}
					++arena_resetcd_time$count;
					this.arenaResetcdTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 45:
					if (arena_resetcd_count$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenaResetcdCount cannot be set twice.');
					}
					++arena_resetcd_count$count;
					this.arenaResetcdCount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 46:
					if (arena_buycount_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenaBuycountTime cannot be set twice.');
					}
					++arena_buycount_time$count;
					this.arenaBuycountTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 47:
					if (arena_buycount_num$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenaBuycountNum cannot be set twice.');
					}
					++arena_buycount_num$count;
					this.arenaBuycountNum = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 48:
					if (arena_coin$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenaCoin cannot be set twice.');
					}
					++arena_coin$count;
					this.arenaCoin = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 49:
					if (title_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.titleId cannot be set twice.');
					}
					++title_id$count;
					this.titleId = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 50:
					if (title_credit$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.titleCredit cannot be set twice.');
					}
					++title_credit$count;
					this.titleCredit = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 51:
					if (title_star$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.titleStar cannot be set twice.');
					}
					++title_star$count;
					this.titleStar = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 52:
					if (sign_week_days$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.signWeekDays cannot be set twice.');
					}
					++sign_week_days$count;
					this.signWeekDays = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 53:
					if (sign_week_last_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.signWeekLastTime cannot be set twice.');
					}
					++sign_week_last_time$count;
					this.signWeekLastTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 54:
					if (sign_month_days$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.signMonthDays cannot be set twice.');
					}
					++sign_month_days$count;
					this.signMonthDays = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 55:
					if (sign_month_last_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.signMonthLastTime cannot be set twice.');
					}
					++sign_month_last_time$count;
					this.signMonthLastTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 56:
					if (resign_month_days$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.resignMonthDays cannot be set twice.');
					}
					++resign_month_days$count;
					this.resignMonthDays = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 57:
					if ((tag & 7) == com.netease.protobuf.WireType.LENGTH_DELIMITED) {
						com.netease.protobuf.ReadUtils.readPackedRepeated(input, com.netease.protobuf.ReadUtils.read_TYPE_INT32, this.periodPrizeDays);
						break;
					}
					this.periodPrizeDays.push(com.netease.protobuf.ReadUtils.read_TYPE_INT32(input));
					break;
				case 58:
					if (decompose_coin$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.decomposeCoin cannot be set twice.');
					}
					++decompose_coin$count;
					this.decomposeCoin = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 59:
					if (moba_coin$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.mobaCoin cannot be set twice.');
					}
					++moba_coin$count;
					this.mobaCoin = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 60:
					if (moba_exp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.mobaExp cannot be set twice.');
					}
					++moba_exp$count;
					this.mobaExp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 61:
					if (moba_point$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.mobaPoint cannot be set twice.');
					}
					++moba_point$count;
					this.mobaPoint = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 62:
					if (today_mobacoin$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.todayMobacoin cannot be set twice.');
					}
					++today_mobacoin$count;
					this.todayMobacoin = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 63:
					if (today_mobaexp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.todayMobaexp cannot be set twice.');
					}
					++today_mobaexp$count;
					this.todayMobaexp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 64:
					if (today_teamcoin$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.todayTeamcoin cannot be set twice.');
					}
					++today_teamcoin$count;
					this.todayTeamcoin = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 65:
					if (vip_signed_days$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.vipSignedDays cannot be set twice.');
					}
					++vip_signed_days$count;
					this.vipSignedDays = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 66:
					if (crystal$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.crystal cannot be set twice.');
					}
					++crystal$count;
					this.crystal = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 67:
					if (crystal_update_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.crystalUpdateTime cannot be set twice.');
					}
					++crystal_update_time$count;
					this.crystalUpdateTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 68:
					if (crystal_output_second$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.crystalOutputSecond cannot be set twice.');
					}
					++crystal_output_second$count;
					this.crystalOutputSecond = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 69:
					if (diamond2crystaltime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2crystaltime cannot be set twice.');
					}
					++diamond2crystaltime$count;
					this.diamond2crystaltime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 70:
					if (diamond2crystalcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2crystalcount cannot be set twice.');
					}
					++diamond2crystalcount$count;
					this.diamond2crystalcount = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 71:
					if (vigour$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.vigour cannot be set twice.');
					}
					++vigour$count;
					this.vigour = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 72:
					if (vigour_update_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.vigourUpdateTime cannot be set twice.');
					}
					++vigour_update_time$count;
					this.vigourUpdateTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 73:
					if (diamond2vigourtime$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2vigourtime cannot be set twice.');
					}
					++diamond2vigourtime$count;
					this.diamond2vigourtime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 74:
					if (diamond2vigourcount$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.diamond2vigourcount cannot be set twice.');
					}
					++diamond2vigourcount$count;
					this.diamond2vigourcount = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 75:
					if (rs_exp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.rsExp cannot be set twice.');
					}
					++rs_exp$count;
					this.rsExp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 76:
					if ((tag & 7) == com.netease.protobuf.WireType.LENGTH_DELIMITED) {
						com.netease.protobuf.ReadUtils.readPackedRepeated(input, com.netease.protobuf.ReadUtils.read_TYPE_INT32, this.rsReceivedRewardId);
						break;
					}
					this.rsReceivedRewardId.push(com.netease.protobuf.ReadUtils.read_TYPE_INT32(input));
					break;
				case 77:
					if (rs_received_reward_lv$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.rsReceivedRewardLv cannot be set twice.');
					}
					++rs_received_reward_lv$count;
					this.rsReceivedRewardLv = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 78:
					if (dungeon_buycount_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.dungeonBuycountTime cannot be set twice.');
					}
					++dungeon_buycount_time$count;
					this.dungeonBuycountTime = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 79:
					if (dungeon_buycount_num$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.dungeonBuycountNum cannot be set twice.');
					}
					++dungeon_buycount_num$count;
					this.dungeonBuycountNum = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 80:
					if (peerage_avatar_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.peerageAvatarId cannot be set twice.');
					}
					++peerage_avatar_id$count;
					this.peerageAvatarId = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 81:
					if (peerage_lev$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.peerageLev cannot be set twice.');
					}
					++peerage_lev$count;
					this.peerageLev = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 82:
					if (peerage_exp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.peerageExp cannot be set twice.');
					}
					++peerage_exp$count;
					this.peerageExp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 83:
					if (money_card_hero_num$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.moneyCardHeroNum cannot be set twice.');
					}
					++money_card_hero_num$count;
					this.moneyCardHeroNum = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 84:
					if (gold_card_hero_num$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.goldCardHeroNum cannot be set twice.');
					}
					++gold_card_hero_num$count;
					this.goldCardHeroNum = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 85:
					if (arena_unread_flag$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.arenaUnreadFlag cannot be set twice.');
					}
					++arena_unread_flag$count;
					this.arenaUnreadFlag = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 86:
					if (zodiac_soul$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.zodiacSoul cannot be set twice.');
					}
					++zodiac_soul$count;
					this.zodiacSoul = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 87:
					if (lottery_total_times$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.lotteryTotalTimes cannot be set twice.');
					}
					++lottery_total_times$count;
					this.lotteryTotalTimes = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 88:
					if (lottery_free_num$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.lotteryFreeNum cannot be set twice.');
					}
					++lottery_free_num$count;
					this.lotteryFreeNum = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 89:
					if (lottery_free_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.lotteryFreeTime cannot be set twice.');
					}
					++lottery_free_time$count;
					this.lotteryFreeTime = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 90:
					if (magic_crystal$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.magicCrystal cannot be set twice.');
					}
					++magic_crystal$count;
					this.magicCrystal = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 91:
					if (big_award_count_down$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.bigAwardCountDown cannot be set twice.');
					}
					++big_award_count_down$count;
					this.bigAwardCountDown = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 92:
					if (max_vp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.maxVp cannot be set twice.');
					}
					++max_vp$count;
					this.maxVp = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 93:
					if (unlocked_chapter_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.unlockedChapterId cannot be set twice.');
					}
					++unlocked_chapter_id$count;
					this.unlockedChapterId = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 94:
					if (unlocked_world_fog_id$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.unlockedWorldFogId cannot be set twice.');
					}
					++unlocked_world_fog_id$count;
					this.unlockedWorldFogId = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				case 95:
					if (liangcao$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.liangcao cannot be set twice.');
					}
					++liangcao$count;
					this.liangcao = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 96:
					if (player_camp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.playerCamp cannot be set twice.');
					}
					++player_camp$count;
					this.playerCamp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 97:
					if (country_lv$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.countryLv cannot be set twice.');
					}
					++country_lv$count;
					this.countryLv = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 98:
					if (free_phantom$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.freePhantom cannot be set twice.');
					}
					++free_phantom$count;
					this.freePhantom = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 99:
					if (can_gain_phantom_exp$count != 0) {
						throw new flash.errors.IOError('Bad data format: role_base_info.canGainPhantomExp cannot be set twice.');
					}
					++can_gain_phantom_exp$count;
					this.canGainPhantomExp = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
