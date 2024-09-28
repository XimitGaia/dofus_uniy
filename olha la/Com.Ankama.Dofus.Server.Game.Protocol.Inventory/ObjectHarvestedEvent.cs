using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003BB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectHarvestedEvent : IMessage<ObjectHarvestedEvent>, IMessage, IEquatable<ObjectHarvestedEvent>, IDeepCloneable<ObjectHarvestedEvent>, IBufferMessage
{
	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectHarvestedEvent> _parser;

	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CCD")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x4000CCF")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x1700084C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectHarvestedEvent> Parser
	{
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x990420", Offset = "0x98F820", VA = "0x180990420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700084D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60026DC")]
		[Address(RVA = "0x990370", Offset = "0x98F770", VA = "0x180990370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700084E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x990470", Offset = "0x98F870", VA = "0x180990470", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700084F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000850")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectHarvestedEvent()
	{
	}

	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectHarvestedEvent(ObjectHarvestedEvent other)
	{
	}

	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x9900F0", Offset = "0x98F4F0", VA = "0x1809900F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectHarvestedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60026E5")]
	[Address(RVA = "0x990180", Offset = "0x98F580", VA = "0x180990180", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectHarvestedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60026E8")]
	[Address(RVA = "0x990210", Offset = "0x98F610", VA = "0x180990210", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x990030", Offset = "0x98F430", VA = "0x180990030", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60026EC")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectHarvestedEvent other)
	{
	}

	[Token(Token = "0x60026ED")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
