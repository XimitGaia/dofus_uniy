using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006A1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectModifiedInBagEvent : IMessage<ExchangeObjectModifiedInBagEvent>, IMessage, IEquatable<ExchangeObjectModifiedInBagEvent>, IDeepCloneable<ExchangeObjectModifiedInBagEvent>, IBufferMessage
{
	[Token(Token = "0x4001732")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectModifiedInBagEvent> _parser;

	[Token(Token = "0x4001733")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001734")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0x18")]
	private bool remote_;

	[Token(Token = "0x4001736")]
	public const int ObjectFieldNumber = 2;

	[Token(Token = "0x4001737")]
	[FieldOffset(Offset = "0x20")]
	private ObjectItemInventory object_;

	[Token(Token = "0x17000F33")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectModifiedInBagEvent> Parser
	{
		[Token(Token = "0x6004723")]
		[Address(RVA = "0xA8D0D0", Offset = "0xA8C4D0", VA = "0x180A8D0D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F34")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004724")]
		[Address(RVA = "0xA8D020", Offset = "0xA8C420", VA = "0x180A8D020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F35")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004725")]
		[Address(RVA = "0xA8D250", Offset = "0xA8C650", VA = "0x180A8D250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F36")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Remote
	{
		[Token(Token = "0x6004729")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600472A")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F37")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory Object
	{
		[Token(Token = "0x600472B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600472C")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6004726")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectModifiedInBagEvent()
	{
	}

	[Token(Token = "0x6004727")]
	[Address(RVA = "0xA8CFB0", Offset = "0xA8C3B0", VA = "0x180A8CFB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectModifiedInBagEvent(ExchangeObjectModifiedInBagEvent other)
	{
	}

	[Token(Token = "0x6004728")]
	[Address(RVA = "0xA8CB60", Offset = "0xA8BF60", VA = "0x180A8CB60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectModifiedInBagEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600472D")]
	[Address(RVA = "0xA8CC00", Offset = "0xA8C000", VA = "0x180A8CC00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600472E")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectModifiedInBagEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600472F")]
	[Address(RVA = "0xA8CCB0", Offset = "0xA8C0B0", VA = "0x180A8CCB0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004730")]
	[Address(RVA = "0xA8CE50", Offset = "0xA8C250", VA = "0x180A8CE50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004731")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004732")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004733")]
	[Address(RVA = "0xA8CAC0", Offset = "0xA8BEC0", VA = "0x180A8CAC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004734")]
	[Address(RVA = "0xA8CD70", Offset = "0xA8C170", VA = "0x180A8CD70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectModifiedInBagEvent other)
	{
	}

	[Token(Token = "0x6004735")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004736")]
	[Address(RVA = "0xA8D120", Offset = "0xA8C520", VA = "0x180A8D120", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
