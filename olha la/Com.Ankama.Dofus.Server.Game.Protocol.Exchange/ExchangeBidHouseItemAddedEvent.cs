using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006B5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseItemAddedEvent : IMessage<ExchangeBidHouseItemAddedEvent>, IMessage, IEquatable<ExchangeBidHouseItemAddedEvent>, IDeepCloneable<ExchangeBidHouseItemAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4001784")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseItemAddedEvent> _parser;

	[Token(Token = "0x4001785")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001786")]
	public const int ItemFieldNumber = 1;

	[Token(Token = "0x4001787")]
	[FieldOffset(Offset = "0x18")]
	private BidItem item_;

	[Token(Token = "0x4001788")]
	public const int PriceFieldNumber = 2;

	[Token(Token = "0x4001789")]
	[FieldOffset(Offset = "0x20")]
	private long price_;

	[Token(Token = "0x400178A")]
	public const int UnsoldDelayFieldNumber = 3;

	[Token(Token = "0x400178B")]
	[FieldOffset(Offset = "0x28")]
	private long unsoldDelay_;

	[Token(Token = "0x17000F6B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeBidHouseItemAddedEvent> Parser
	{
		[Token(Token = "0x600481F")]
		[Address(RVA = "0xAA2260", Offset = "0xAA1660", VA = "0x180AA2260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004820")]
		[Address(RVA = "0xAA21B0", Offset = "0xAA15B0", VA = "0x180AA21B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004821")]
		[Address(RVA = "0xAA2490", Offset = "0xAA1890", VA = "0x180AA2490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F6E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BidItem Item
	{
		[Token(Token = "0x6004825")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004826")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F6F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Price
	{
		[Token(Token = "0x6004827")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004828")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UnsoldDelay
	{
		[Token(Token = "0x6004829")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600482A")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6004822")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseItemAddedEvent()
	{
	}

	[Token(Token = "0x6004823")]
	[Address(RVA = "0xAA2130", Offset = "0xAA1530", VA = "0x180AA2130")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseItemAddedEvent(ExchangeBidHouseItemAddedEvent other)
	{
	}

	[Token(Token = "0x6004824")]
	[Address(RVA = "0xAA1C50", Offset = "0xAA1050", VA = "0x180AA1C50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseItemAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600482B")]
	[Address(RVA = "0xAA1D80", Offset = "0xAA1180", VA = "0x180AA1D80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600482C")]
	[Address(RVA = "0xAA1D00", Offset = "0xAA1100", VA = "0x180AA1D00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeBidHouseItemAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600482D")]
	[Address(RVA = "0xAA1E40", Offset = "0xAA1240", VA = "0x180AA1E40", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600482E")]
	[Address(RVA = "0xAA1FD0", Offset = "0xAA13D0", VA = "0x180AA1FD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600482F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004830")]
	[Address(RVA = "0xAA23F0", Offset = "0xAA17F0", VA = "0x180AA23F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004831")]
	[Address(RVA = "0xAA1B60", Offset = "0xAA0F60", VA = "0x180AA1B60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004832")]
	[Address(RVA = "0xAA1EF0", Offset = "0xAA12F0", VA = "0x180AA1EF0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseItemAddedEvent other)
	{
	}

	[Token(Token = "0x6004833")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004834")]
	[Address(RVA = "0xAA22B0", Offset = "0xAA16B0", VA = "0x180AA22B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
