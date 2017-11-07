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
	public dynamic final class gate_test_req extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const SEND_TIME:FieldDescriptor_TYPE_INT64 = new FieldDescriptor_TYPE_INT64("SProtoSpace.gate_test_req.send_time", "sendTime", (2 << 3) | com.netease.protobuf.WireType.VARINT);

		private var send_time$field:Int64;

		public function clearSendTime():void {
			send_time$field = null;
		}

		public function get hasSendTime():Boolean {
			return send_time$field != null;
		}

		public function set sendTime(value:Int64):void {
			send_time$field = value;
		}

		public function get sendTime():Int64 {
			if(!hasSendTime) {
				return new Int64(0, 0);
			}
			return send_time$field;
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			if (hasSendTime) {
				com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 2);
				com.netease.protobuf.WriteUtils.write_TYPE_INT64(output, send_time$field);
			}
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var send_time$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 2:
					if (send_time$count != 0) {
						throw new flash.errors.IOError('Bad data format: gate_test_req.sendTime cannot be set twice.');
					}
					++send_time$count;
					this.sendTime = com.netease.protobuf.ReadUtils.read_TYPE_INT64(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
