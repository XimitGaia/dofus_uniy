using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006B3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseBuyResultEvent : IMessage<ExchangeBidHouseBuyResultEvent>, IMessage, IEquatable<ExchangeBidHouseBuyResultEvent>, IDeepCloneable<ExchangeBidHouseBuyResultEvent>, IBufferMessage
{
	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseBuyResultEvent> _parser;

	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400177F")]
	public const int BidItemUidFieldNumber = 1;

	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x18")]
	private int bidItemUid_;

	[Token(Token = "0x4001781")]
	public const int BoughtFieldNumber = 2;

	[Token(Token = "0x4001782")]
	[FieldOffset(Offset = "0x1C")]
	private bool bought_;

	[Token(Token = "0x17000F66")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeBidHouseBuyResultEvent> Parser
	{
		[Token(Token = "0x6004807")]
		[Address(RVA = "0xA9EF20", Offset = "0xA9E320", VA = "0x180A9EF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F67")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004808")]
		[Address(RVA = "0xA9EE70", Offset = "0xA9E270", VA = "0x180A9EE70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F68")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004809")]
		[Address(RVA = "0xA9EF70", Offset = "0xA9E370", VA = "0x180A9EF70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F69")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BidItemUid
	{
		[Token(Token = "0x600480D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600480E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000F6A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Bought
	{
		[Token(Token = "0x600480F")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004810")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x600480A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseBuyResultEvent()
	{
	}

	[Token(Token = "0x600480B")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseBuyResultEvent(ExchangeBidHouseBuyResultEvent other)
	{
	}

	[Token(Token = "0x600480C")]
	[Address(RVA = "0xA9EB30", Offset = "0xA9DF30", VA = "0x180A9EB30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseBuyResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004811")]
	[Address(RVA = "0xA9EBC0", Offset = "0xA9DFC0", VA = "0x180A9EBC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004812")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseBuyResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004813")]
	[Address(RVA = "0xA9EC50", Offset = "0xA9E050", VA = "0x180A9EC50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004814")]
	[Address(RVA = "0xA9ED10", Offset = "0xA9E110", VA = "0x180A9ED10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004815")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004816")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004817")]
	[Address(RVA = "0xA9EAA0", Offset = "0xA9DEA0", VA = "0x180A9EAA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004818")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseBuyResultEvent other)
	{
	}

	[Token(Token = "0x6004819")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600481A")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
