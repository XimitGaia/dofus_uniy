using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006BD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseInListAddedEvent : IMessage<ExchangeBidHouseInListAddedEvent>, IMessage, IEquatable<ExchangeBidHouseInListAddedEvent>, IDeepCloneable<ExchangeBidHouseInListAddedEvent>, IBufferMessage
{
	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseInListAddedEvent> _parser;

	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400179E")]
	public const int BidItemUidFieldNumber = 1;

	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x18")]
	private int bidItemUid_;

	[Token(Token = "0x40017A0")]
	public const int ObjectGidFieldNumber = 2;

	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x1C")]
	private int objectGid_;

	[Token(Token = "0x40017A2")]
	public const int ObjectTypeFieldNumber = 3;

	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x20")]
	private int objectType_;

	[Token(Token = "0x40017A4")]
	public const int EffectsFieldNumber = 4;

	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x40017A7")]
	public const int PricesFieldNumber = 5;

	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<long> _repeated_prices_codec;

	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<long> prices_;

	[Token(Token = "0x17000F7D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseInListAddedEvent> Parser
	{
		[Token(Token = "0x600487B")]
		[Address(RVA = "0xAA03B0", Offset = "0xA9F7B0", VA = "0x180AA03B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600487C")]
		[Address(RVA = "0xAA0300", Offset = "0xA9F700", VA = "0x180AA0300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600487D")]
		[Address(RVA = "0xAA0730", Offset = "0xA9FB30", VA = "0x180AA0730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BidItemUid
	{
		[Token(Token = "0x6004881")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004882")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000F81")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004884")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000F82")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectType
	{
		[Token(Token = "0x6004885")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004886")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000F83")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x6004887")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F84")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> Prices
	{
		[Token(Token = "0x6004888")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600487E")]
	[Address(RVA = "0xAA0170", Offset = "0xA9F570", VA = "0x180AA0170")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseInListAddedEvent()
	{
	}

	[Token(Token = "0x600487F")]
	[Address(RVA = "0xAA0230", Offset = "0xA9F630", VA = "0x180AA0230")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseInListAddedEvent(ExchangeBidHouseInListAddedEvent other)
	{
	}

	[Token(Token = "0x6004880")]
	[Address(RVA = "0xA9FB80", Offset = "0xA9EF80", VA = "0x180A9FB80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseInListAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004889")]
	[Address(RVA = "0xA9FC80", Offset = "0xA9F080", VA = "0x180A9FC80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600488A")]
	[Address(RVA = "0xA9FDA0", Offset = "0xA9F1A0", VA = "0x180A9FDA0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeBidHouseInListAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600488B")]
	[Address(RVA = "0xA9C140", Offset = "0xA9B540", VA = "0x180A9C140", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600488C")]
	[Address(RVA = "0xA9FF30", Offset = "0xA9F330", VA = "0x180A9FF30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600488D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600488E")]
	[Address(RVA = "0xAA05E0", Offset = "0xA9F9E0", VA = "0x180AA05E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600488F")]
	[Address(RVA = "0xA9FA10", Offset = "0xA9EE10", VA = "0x180A9FA10", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004890")]
	[Address(RVA = "0xA9FE70", Offset = "0xA9F270", VA = "0x180A9FE70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeBidHouseInListAddedEvent other)
	{
	}

	[Token(Token = "0x6004891")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004892")]
	[Address(RVA = "0xAA0400", Offset = "0xA9F800", VA = "0x180AA0400", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
