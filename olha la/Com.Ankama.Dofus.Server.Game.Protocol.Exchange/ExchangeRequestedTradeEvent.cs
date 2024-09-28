using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006A9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeRequestedTradeEvent : IMessage<ExchangeRequestedTradeEvent>, IMessage, IEquatable<ExchangeRequestedTradeEvent>, IDeepCloneable<ExchangeRequestedTradeEvent>, IBufferMessage
{
	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeRequestedTradeEvent> _parser;

	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001750")]
	public const int ExchangeTypeFieldNumber = 1;

	[Token(Token = "0x4001751")]
	[FieldOffset(Offset = "0x18")]
	private ExchangeType exchangeType_;

	[Token(Token = "0x4001752")]
	public const int SourceIdFieldNumber = 2;

	[Token(Token = "0x4001753")]
	[FieldOffset(Offset = "0x20")]
	private long sourceId_;

	[Token(Token = "0x4001754")]
	public const int TargetIdFieldNumber = 3;

	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0x28")]
	private long targetId_;

	[Token(Token = "0x17000F47")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeRequestedTradeEvent> Parser
	{
		[Token(Token = "0x6004783")]
		[Address(RVA = "0xA972A0", Offset = "0xA966A0", VA = "0x180A972A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F48")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004784")]
		[Address(RVA = "0xA971F0", Offset = "0xA965F0", VA = "0x180A971F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F49")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004785")]
		[Address(RVA = "0xA97460", Offset = "0xA96860", VA = "0x180A97460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F4A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeType ExchangeType
	{
		[Token(Token = "0x6004789")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ExchangeType);
		}
		[Token(Token = "0x600478A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000F4B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SourceId
	{
		[Token(Token = "0x600478B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600478C")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F4C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetId
	{
		[Token(Token = "0x600478D")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600478E")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6004786")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeRequestedTradeEvent()
	{
	}

	[Token(Token = "0x6004787")]
	[Address(RVA = "0xA97190", Offset = "0xA96590", VA = "0x180A97190")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeRequestedTradeEvent(ExchangeRequestedTradeEvent other)
	{
	}

	[Token(Token = "0x6004788")]
	[Address(RVA = "0xA96DA0", Offset = "0xA961A0", VA = "0x180A96DA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeRequestedTradeEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600478F")]
	[Address(RVA = "0xA96E70", Offset = "0xA96270", VA = "0x180A96E70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004790")]
	[Address(RVA = "0xA96E30", Offset = "0xA96230", VA = "0x180A96E30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeRequestedTradeEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004791")]
	[Address(RVA = "0xA96F10", Offset = "0xA96310", VA = "0x180A96F10", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004792")]
	[Address(RVA = "0xA97030", Offset = "0xA96430", VA = "0x180A97030", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004793")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004794")]
	[Address(RVA = "0xA973C0", Offset = "0xA967C0", VA = "0x180A973C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004795")]
	[Address(RVA = "0xA96CB0", Offset = "0xA960B0", VA = "0x180A96CB0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004796")]
	[Address(RVA = "0xA96FC0", Offset = "0xA963C0", VA = "0x180A96FC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeRequestedTradeEvent other)
	{
	}

	[Token(Token = "0x6004797")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004798")]
	[Address(RVA = "0xA972F0", Offset = "0xA966F0", VA = "0x180A972F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
