using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006D3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeNpcTradeStartedEvent : IMessage<ExchangeNpcTradeStartedEvent>, IMessage, IEquatable<ExchangeNpcTradeStartedEvent>, IDeepCloneable<ExchangeNpcTradeStartedEvent>, IBufferMessage
{
	[Token(Token = "0x40017F8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeNpcTradeStartedEvent> _parser;

	[Token(Token = "0x40017F9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017FA")]
	public const int NpcIdFieldNumber = 1;

	[Token(Token = "0x40017FB")]
	[FieldOffset(Offset = "0x18")]
	private long npcId_;

	[Token(Token = "0x17000FB1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeNpcTradeStartedEvent> Parser
	{
		[Token(Token = "0x6004969")]
		[Address(RVA = "0xAA9CF0", Offset = "0xAA90F0", VA = "0x180AA9CF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FB2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600496A")]
		[Address(RVA = "0xAA9C40", Offset = "0xAA9040", VA = "0x180AA9C40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FB3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600496B")]
		[Address(RVA = "0xAA9D40", Offset = "0xAA9140", VA = "0x180AA9D40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FB4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NpcId
	{
		[Token(Token = "0x600496F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004970")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x600496C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeNpcTradeStartedEvent()
	{
	}

	[Token(Token = "0x600496D")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeNpcTradeStartedEvent(ExchangeNpcTradeStartedEvent other)
	{
	}

	[Token(Token = "0x600496E")]
	[Address(RVA = "0xAA99D0", Offset = "0xAA8DD0", VA = "0x180AA99D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeNpcTradeStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004971")]
	[Address(RVA = "0xAA9A50", Offset = "0xAA8E50", VA = "0x180AA9A50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004972")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeNpcTradeStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004973")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004974")]
	[Address(RVA = "0xAA9AE0", Offset = "0xAA8EE0", VA = "0x180AA9AE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004975")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004976")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004977")]
	[Address(RVA = "0xAA9940", Offset = "0xAA8D40", VA = "0x180AA9940", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004978")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeNpcTradeStartedEvent other)
	{
	}

	[Token(Token = "0x6004979")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600497A")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
