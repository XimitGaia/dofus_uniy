using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B6A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakActionEvent : IMessage<BakActionEvent>, IMessage, IEquatable<BakActionEvent>, IDeepCloneable<BakActionEvent>, IBufferMessage
{
	[Token(Token = "0x4002AA4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakActionEvent> _parser;

	[Token(Token = "0x4002AA5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002AA6")]
	public const int KamasFieldNumber = 1;

	[Token(Token = "0x4002AA7")]
	[FieldOffset(Offset = "0x18")]
	private long kamas_;

	[Token(Token = "0x4002AA8")]
	public const int AmountFieldNumber = 2;

	[Token(Token = "0x4002AA9")]
	[FieldOffset(Offset = "0x20")]
	private long amount_;

	[Token(Token = "0x4002AAA")]
	public const int RateFieldNumber = 3;

	[Token(Token = "0x4002AAB")]
	[FieldOffset(Offset = "0x28")]
	private int rate_;

	[Token(Token = "0x4002AAC")]
	public const int BidActionFieldNumber = 4;

	[Token(Token = "0x4002AAD")]
	[FieldOffset(Offset = "0x2C")]
	private BidAction bidAction_;

	[Token(Token = "0x4002AAE")]
	public const int TransactionUuidFieldNumber = 5;

	[Token(Token = "0x4002AAF")]
	[FieldOffset(Offset = "0x30")]
	private string transactionUuid_;

	[Token(Token = "0x17001A7A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BakActionEvent> Parser
	{
		[Token(Token = "0x6007835")]
		[Address(RVA = "0xC19D40", Offset = "0xC19140", VA = "0x180C19D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007836")]
		[Address(RVA = "0xC19C90", Offset = "0xC19090", VA = "0x180C19C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A7C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007837")]
		[Address(RVA = "0xC19FC0", Offset = "0xC193C0", VA = "0x180C19FC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A7D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Kamas
	{
		[Token(Token = "0x600783B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600783C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001A7E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Amount
	{
		[Token(Token = "0x600783D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600783E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A7F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Rate
	{
		[Token(Token = "0x600783F")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007840")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001A80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidAction BidAction
	{
		[Token(Token = "0x6007841")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(BidAction);
		}
		[Token(Token = "0x6007842")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17001A81")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TransactionUuid
	{
		[Token(Token = "0x6007843")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007844")]
		[Address(RVA = "0xC1A0A0", Offset = "0xC194A0", VA = "0x180C1A0A0")]
		set
		{
		}
	}

	[Token(Token = "0x6007838")]
	[Address(RVA = "0xC19B80", Offset = "0xC18F80", VA = "0x180C19B80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakActionEvent()
	{
	}

	[Token(Token = "0x6007839")]
	[Address(RVA = "0xC19BD0", Offset = "0xC18FD0", VA = "0x180C19BD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakActionEvent(BakActionEvent other)
	{
	}

	[Token(Token = "0x600783A")]
	[Address(RVA = "0xC19650", Offset = "0xC18A50", VA = "0x180C19650", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BakActionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007845")]
	[Address(RVA = "0xC19740", Offset = "0xC18B40", VA = "0x180C19740", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007846")]
	[Address(RVA = "0xC19810", Offset = "0xC18C10", VA = "0x180C19810", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BakActionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007847")]
	[Address(RVA = "0xC198A0", Offset = "0xC18CA0", VA = "0x180C198A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007848")]
	[Address(RVA = "0xC19A20", Offset = "0xC18E20", VA = "0x180C19A20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007849")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600784A")]
	[Address(RVA = "0xC19ED0", Offset = "0xC192D0", VA = "0x180C19ED0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600784B")]
	[Address(RVA = "0xC19510", Offset = "0xC18910", VA = "0x180C19510", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600784C")]
	[Address(RVA = "0xC19990", Offset = "0xC18D90", VA = "0x180C19990", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakActionEvent other)
	{
	}

	[Token(Token = "0x600784D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600784E")]
	[Address(RVA = "0xC19D90", Offset = "0xC19190", VA = "0x180C19D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
