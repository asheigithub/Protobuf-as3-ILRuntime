using ASBinCode.rtData;
using ASRuntime.flash.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AS3Proto
{
	public class Message
	{
		protected ASRuntime.Player player;
		protected ASBinCode.rtData.rtObject as3Object;

		//public rtObject bindObject { get { return as3Object; } }
		protected rtObject LoadBindObject(Message message)
		{
			return message.as3Object;
		}

		protected rtObject LoadBindObjectAndWriteField(Message message)
		{
			message.beforeWriteTo();
			return message.as3Object;
		}

		protected void setAs3Object(ASBinCode.rtData.rtObject as3Object)
		{
			this.as3Object = as3Object;
			afterMergeFrom();
		}

		protected void createAs3Object(string prototype)
		{
			as3Object= player.createInstance(prototype);

			afterMergeFrom();
		}


		protected virtual void afterMergeFrom()
		{

		}
		protected virtual void beforeWriteTo()
		{

		}


		protected object ConvertLongToObj(Int64 arg)
		{
			return player.createInstance("com.netease.protobuf.Int64", (uint)(arg & 0xffffffff),(int)(arg>>32) );
		}

		protected long ConvertObjToLong(object obj)
		{
			uint low = (uint)player.getMemberValue((rtObject)obj, "low");
			int high = (int)player.getMemberValue((rtObject)obj, "high");
			long k = ((long)high << 32) | low;
			return k;
		}

		protected object ConvertULongToObj(UInt64 arg)
		{
			return player.createInstance("com.netease.protobuf.UInt64", (uint)(arg & 0xffffffff), (int)(arg >> 32));
		}

		protected ulong ConvertObjToULong(object obj)
		{
			uint low = (uint)player.getMemberValue((rtObject)obj, "low");
			uint high = (uint)player.getMemberValue((rtObject)obj, "high");
			ulong k = ((ulong)high << 32) | low;

			return k;
		}

		protected object ConvertBytesToByteArray(byte[] arg)
		{
			if (arg == null)
				return null;
			ASRuntime.flash.utils.ByteArray byteArray;
			var obj = player.createByteArrayObject(out byteArray);

			byteArray.WriteInto(arg);
			byteArray.position = 0;
			return obj;
		}

		protected byte[] ConvertByteArrayToBytes(object byteArray)
		{
			if (byteArray == null)
				return null;

			ByteArray ms =
					(ByteArray)((ASBinCode.rtti.HostedObject)((rtObject)(((rtObject)byteArray).value.memberData[0].getValue())).value).hosted_object;

			return ms.ToArray();
		}


		public void mergeFrom(System.IO.MemoryStream input)
		{
			ASRuntime.flash.utils.ByteArray byteArray;
			var obj = player.createByteArrayObject(out byteArray);

			byteArray.AttachMemoryStream(input,true);

			player.invokeMethod(as3Object, "mergeFrom", obj);

			byteArray.DetachMemoryStream();


			afterMergeFrom();
		}
		public void mergeDelimitedFrom(System.IO.MemoryStream input)
		{
			ASRuntime.flash.utils.ByteArray byteArray;
			var obj = player.createByteArrayObject(out byteArray);

			byteArray.AttachMemoryStream(input, true);

			player.invokeMethod(as3Object, "mergeDelimitedFrom", obj);

			byteArray.DetachMemoryStream();

			afterMergeFrom();
		}
		public void writeTo(System.IO.MemoryStream output)
		{
			beforeWriteTo();

			ASRuntime.flash.utils.ByteArray byteArray;
			var obj = player.createByteArrayObject(out byteArray);

			try
			{
				byteArray.AttachMemoryStream(output, true);
				player.invokeMethod(as3Object, "writeTo", obj);
				byteArray.DetachMemoryStream();
			}
			catch (Exception e)
			{

				throw;
			}


			

		}
		public void writeDelimitedTo(System.IO.MemoryStream output)
		{
			beforeWriteTo();

			ASRuntime.flash.utils.ByteArray byteArray;
			var obj = player.createByteArrayObject(out byteArray);

			byteArray.AttachMemoryStream(output, true);
			player.invokeMethod(as3Object, "writeDelimitedTo", obj);
			byteArray.DetachMemoryStream();
		}



		public string printByte(byte[] buff)
		{
			int count = buff.Length;

			StringBuilder output = new StringBuilder();

			output.Append("\"");
			int i = 0;
			while (count > 0)
			{
				count--;
				int b = (sbyte)buff[i++];
				switch (b)
				{
					case 7: output.Append("\\a"); break;
					case 8: output.Append("\\b"); break;
					case 12: output.Append("\\f"); break;
					case 10: output.Append("\\n"); break;
					case 13: output.Append("\\r"); break;
					case 9: output.Append("\\t"); break;
					case 11: output.Append("\\v"); break;
					case 92: output.Append("\\\\"); break;
					case 39: output.Append("\\\'"); break;
					case 34: output.Append("\\\""); break;
					default:
						if (b >= 0x20)
						{
							output.Append(System.Text.Encoding.UTF8.GetString(new byte[] { (byte)b }));
						}
						else
						{
							output.Append('\\');
							output.Append(System.Text.Encoding.UTF8.GetString(new byte[] { (byte)((int)'0' + (((uint)b >> 6) & 3)) }));
							output.Append(System.Text.Encoding.UTF8.GetString(new byte[] { (byte)((int)'0' + (((uint)b >> 3) & 7)) }));
							output.Append(System.Text.Encoding.UTF8.GetString(new byte[] { (byte)((int)'0' + (b & 7)) }));
						}
						break;
				}
			}
			output.Append("\"");


			return output.ToString();
		}


		public override string ToString()
		{
			return as3Object.value._class.package + ( string.IsNullOrEmpty(as3Object.value._class.package)?"":".") + as3Object.value._class.name;
		}

	}
}
