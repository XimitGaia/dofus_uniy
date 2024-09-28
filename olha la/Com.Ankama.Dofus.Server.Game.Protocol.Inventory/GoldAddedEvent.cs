using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003AB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GoldAddedEvent : IMessage<GoldAddedEvent>, IMessage, IEquatable<GoldAddedEvent>, IDeepCloneable<GoldAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4000C9F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GoldAddedEvent> _parser;

	[Token(Token = "0x4000CA0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CA1")]
	public const int SumFieldNumber = 1;

	[Token(Token = "0x4000CA2")]
	[FieldOffset(Offset = "0x18")]
	private long sum_;

	[Token(Token = "0x1700082B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GoldAddedEvent> Parser
	{
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x982CC0", Offset = "0x9820C0", VA = "0x180982CC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700082C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x982C10", Offset = "0x982010", VA = "0x180982C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700082D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600262D")]
		[Address(RVA = "0x982D10", Offset = "0x982110", VA = "0x180982D10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700082E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Sum
	{
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x600262E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GoldAddedEvent()
	{
	}

	[Token(Token = "0x600262F")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GoldAddedEvent(GoldAddedEvent other)
	{
	}

	[Token(Token = "0x6002630")]
	[Address(RVA = "0x9829A0", Offset = "0x981DA0", VA = "0x1809829A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GoldAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002633")]
	[Address(RVA = "0x982A20", Offset = "0x981E20", VA = "0x180982A20", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002634")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GoldAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002635")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002636")]
	[Address(RVA = "0x982AB0", Offset = "0x981EB0", VA = "0x180982AB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002637")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002638")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002639")]
	[Address(RVA = "0x982910", Offset = "0x981D10", VA = "0x180982910", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600263A")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GoldAddedEvent other)
	{
	}

	[Token(Token = "0x600263B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600263C")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
