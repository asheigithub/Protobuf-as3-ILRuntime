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
	public dynamic final class main_task_info extends com.netease.protobuf.Message {
		/**
		 *  @private
		 */
		public static const TASKID:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.main_task_info.taskid", "taskid", (1 << 3) | com.netease.protobuf.WireType.VARINT);

		public var taskid:int;

		/**
		 *  @private
		 */
		public static const TASKSTATE:FieldDescriptor_TYPE_INT32 = new FieldDescriptor_TYPE_INT32("SProtoSpace.main_task_info.taskstate", "taskstate", (2 << 3) | com.netease.protobuf.WireType.VARINT);

		public var taskstate:int;

		/**
		 *  @private
		 */
		public static const CURNUM:FieldDescriptor_TYPE_UINT32 = new FieldDescriptor_TYPE_UINT32("SProtoSpace.main_task_info.curnum", "curnum", (3 << 3) | com.netease.protobuf.WireType.VARINT);

		public var curnum:uint;

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function writeToBuffer(output:com.netease.protobuf.WritingBuffer):void {
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 1);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.taskid);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 2);
			com.netease.protobuf.WriteUtils.write_TYPE_INT32(output, this.taskstate);
			com.netease.protobuf.WriteUtils.writeTag(output, com.netease.protobuf.WireType.VARINT, 3);
			com.netease.protobuf.WriteUtils.write_TYPE_UINT32(output, this.curnum);
			for (var fieldKey:* in this) {
				super.writeUnknown(output, fieldKey);
			}
		}

		/**
		 *  @private
		 */
		override com.netease.protobuf.used_by_generated_code final function readFromSlice(input:flash.utils.IDataInput, bytesAfterSlice:uint):void {
			var taskid$count:uint = 0;
			var taskstate$count:uint = 0;
			var curnum$count:uint = 0;
			while (input.bytesAvailable > bytesAfterSlice) {
				var tag:uint = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
				switch (tag >> 3) {
				case 1:
					if (taskid$count != 0) {
						throw new flash.errors.IOError('Bad data format: main_task_info.taskid cannot be set twice.');
					}
					++taskid$count;
					this.taskid = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 2:
					if (taskstate$count != 0) {
						throw new flash.errors.IOError('Bad data format: main_task_info.taskstate cannot be set twice.');
					}
					++taskstate$count;
					this.taskstate = com.netease.protobuf.ReadUtils.read_TYPE_INT32(input);
					break;
				case 3:
					if (curnum$count != 0) {
						throw new flash.errors.IOError('Bad data format: main_task_info.curnum cannot be set twice.');
					}
					++curnum$count;
					this.curnum = com.netease.protobuf.ReadUtils.read_TYPE_UINT32(input);
					break;
				default:
					super.readUnknown(input, tag);
					break;
				}
			}
		}

	}
}
