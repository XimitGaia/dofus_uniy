using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006C9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeStoppedEvent : IMessage<ExchangeStoppedEvent>, IMessage, IEquatable<ExchangeStoppedEvent>, IDeepCloneable<ExchangeStoppedEvent>, IBufferMessage
{
	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeStoppedEvent> _parser;

	[Token(Token = "0x40017D7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017D8")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x40017D9")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x17000FA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeStoppedEvent> Parser
	{
		[Token(Token = "0x600490F")]
		[Address(RVA = "0xAAD3E0", Offset = "0xAAC7E0", VA = "0x180AAD3E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FA1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004910")]
		[Address(RVA = "0xAAD330", Offset = "0xAAC730", VA = "0x180AAD330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FA2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004911")]
		[Address(RVA = "0xAAD430", Offset = "0xAAC830", VA = "0x180AAD430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FA3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004916")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6004912")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeStoppedEvent()
	{
	}

	[Token(Token = "0x6004913")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStoppedEvent(ExchangeStoppedEvent other)
	{
	}

	[Token(Token = "0x6004914")]
	[Address(RVA = "0xAAD0C0", Offset = "0xAAC4C0", VA = "0x180AAD0C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStoppedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004917")]
	[Address(RVA = "0xAAD140", Offset = "0xAAC540", VA = "0x180AAD140", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004918")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeStoppedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004919")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600491A")]
	[Address(RVA = "0xAAD1D0", Offset = "0xAAC5D0", VA = "0x180AAD1D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600491B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600491C")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600491D")]
	[Address(RVA = "0xAAD030", Offset = "0xAAC430", VA = "0x180AAD030", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600491E")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeStoppedEvent other)
	{
	}

	[Token(Token = "0x600491F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004920")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
