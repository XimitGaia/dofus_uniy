using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006BF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseInListUpdatedEvent : IMessage<ExchangeBidHouseInListUpdatedEvent>, IMessage, IEquatable<ExchangeBidHouseInListUpdatedEvent>, IDeepCloneable<ExchangeBidHouseInListUpdatedEvent>, IBufferMessage
{
	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseInListUpdatedEvent> _parser;

	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017AD")]
	public const int BidItemUidFieldNumber = 1;

	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0x18")]
	private int bidItemUid_;

	[Token(Token = "0x40017AF")]
	public const int ObjectGidFieldNumber = 2;

	[Token(Token = "0x40017B0")]
	[FieldOffset(Offset = "0x1C")]
	private int objectGid_;

	[Token(Token = "0x40017B1")]
	public const int ObjectTypeFieldNumber = 3;

	[Token(Token = "0x40017B2")]
	[FieldOffset(Offset = "0x20")]
	private int objectType_;

	[Token(Token = "0x40017B3")]
	public const int EffectsFieldNumber = 4;

	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x40017B5")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x40017B6")]
	public const int PricesFieldNumber = 5;

	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<long> _repeated_prices_codec;

	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<long> prices_;

	[Token(Token = "0x17000F85")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeBidHouseInListUpdatedEvent> Parser
	{
		[Token(Token = "0x6004897")]
		[Address(RVA = "0xAA1700", Offset = "0xAA0B00", VA = "0x180AA1700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F86")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004898")]
		[Address(RVA = "0xAA1650", Offset = "0xAA0A50", VA = "0x180AA1650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F87")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004899")]
		[Address(RVA = "0xAA1A80", Offset = "0xAA0E80", VA = "0x180AA1A80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F88")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BidItemUid
	{
		[Token(Token = "0x600489D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600489E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000F89")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x600489F")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60048A0")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000F8A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectType
	{
		[Token(Token = "0x60048A1")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000F8B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x60048A3")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F8C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> Prices
	{
		[Token(Token = "0x60048A4")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600489A")]
	[Address(RVA = "0xAA1590", Offset = "0xAA0990", VA = "0x180AA1590")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseInListUpdatedEvent()
	{
	}

	[Token(Token = "0x600489B")]
	[Address(RVA = "0xAA14C0", Offset = "0xAA08C0", VA = "0x180AA14C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseInListUpdatedEvent(ExchangeBidHouseInListUpdatedEvent other)
	{
	}

	[Token(Token = "0x600489C")]
	[Address(RVA = "0xAA0ED0", Offset = "0xAA02D0", VA = "0x180AA0ED0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseInListUpdatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60048A5")]
	[Address(RVA = "0xAA10A0", Offset = "0xAA04A0", VA = "0x180AA10A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60048A6")]
	[Address(RVA = "0xAA0FD0", Offset = "0xAA03D0", VA = "0x180AA0FD0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeBidHouseInListUpdatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60048A7")]
	[Address(RVA = "0xA9C140", Offset = "0xA9B540", VA = "0x180A9C140", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60048A8")]
	[Address(RVA = "0xAA1280", Offset = "0xAA0680", VA = "0x180AA1280", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60048A9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60048AA")]
	[Address(RVA = "0xAA1930", Offset = "0xAA0D30", VA = "0x180AA1930", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60048AB")]
	[Address(RVA = "0xAA0D60", Offset = "0xAA0160", VA = "0x180AA0D60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60048AC")]
	[Address(RVA = "0xAA11C0", Offset = "0xAA05C0", VA = "0x180AA11C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeBidHouseInListUpdatedEvent other)
	{
	}

	[Token(Token = "0x60048AD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60048AE")]
	[Address(RVA = "0xAA1750", Offset = "0xAA0B50", VA = "0x180AA1750", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
