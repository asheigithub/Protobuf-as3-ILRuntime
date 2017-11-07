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
	public dynamic final class hero_symbol_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const SYMBOL_POS:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.hero_symbol_info.symbol_pos", "symbolPos", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var symbolPos:int;

		/**
		 *  @private
		 */
		public static const ITEM_INDEX:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.hero_symbol_info.item_index", "itemIndex", (2 << 3) | com.netease.protobuf.WireType.VARINT);

		public var itemIndex:uint;

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.symbolPos);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.itemIndex);
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var symbol_pos$count:uint = 0;
			var item_index$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (symbol_pos$count != 0) {
						throw new flash.errors.IOError('Bad data format: hero_symbol_info.symbolPos cannot be set twice.');
					}
					++symbol_pos$count;
					this.symbolPos = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 2:
					if (item_index$count != 0) {
						throw new flash.errors.IOError('Bad data format: hero_symbol_info.itemIndex cannot be set twice.');
					}
					++item_index$count;
					this.itemIndex = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
