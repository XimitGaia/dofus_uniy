using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006AD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeStartedWithPodsEvent : IMessage<ExchangeStartedWithPodsEvent>, IMessage, IEquatable<ExchangeStartedWithPodsEvent>, IDeepCloneable<ExchangeStartedWithPodsEvent>, IBufferMessage
{
	[Token(Token = "0x400175C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeStartedWithPodsEvent> _parser;

	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400175E")]
	public const int ExchangeTypeFieldNumber = 1;

	[Token(Token = "0x400175F")]
	[FieldOffset(Offset = "0x18")]
	private ExchangeType exchangeType_;

	[Token(Token = "0x4001760")]
	public const int FirstCharacterIdFieldNumber = 2;

	[Token(Token = "0x4001761")]
	[FieldOffset(Offset = "0x20")]
	private long firstCharacterId_;

	[Token(Token = "0x4001762")]
	public const int FirstCharacterCurrentWeightFieldNumber = 3;

	[Token(Token = "0x4001763")]
	[FieldOffset(Offset = "0x28")]
	private int firstCharacterCurrentWeight_;

	[Token(Token = "0x4001764")]
	public const int FirstCharacterMaxWeightFieldNumber = 4;

	[Token(Token = "0x4001765")]
	[FieldOffset(Offset = "0x2C")]
	private int firstCharacterMaxWeight_;

	[Token(Token = "0x4001766")]
	public const int SecondCharacterIdFieldNumber = 5;

	[Token(Token = "0x4001767")]
	[FieldOffset(Offset = "0x30")]
	private long secondCharacterId_;

	[Token(Token = "0x4001768")]
	public const int SecondCharacterCurrentWeightFieldNumber = 6;

	[Token(Token = "0x4001769")]
	[FieldOffset(Offset = "0x38")]
	private int secondCharacterCurrentWeight_;

	[Token(Token = "0x400176A")]
	public const int SecondCharacterMaxWeightFieldNumber = 7;

	[Token(Token = "0x400176B")]
	[FieldOffset(Offset = "0x3C")]
	private int secondCharacterMaxWeight_;

	[Token(Token = "0x17000F51")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeStartedWithPodsEvent> Parser
	{
		[Token(Token = "0x60047B3")]
		[Address(RVA = "0xAAC760", Offset = "0xAABB60", VA = "0x180AAC760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F52")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60047B4")]
		[Address(RVA = "0xAAC6B0", Offset = "0xAABAB0", VA = "0x180AAC6B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F53")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60047B5")]
		[Address(RVA = "0xAACA30", Offset = "0xAABE30", VA = "0x180AACA30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F54")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeType ExchangeType
	{
		[Token(Token = "0x60047B9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ExchangeType);
		}
		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000F55")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FirstCharacterId
	{
		[Token(Token = "0x60047BB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60047BC")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F56")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstCharacterCurrentWeight
	{
		[Token(Token = "0x60047BD")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60047BE")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000F57")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FirstCharacterMaxWeight
	{
		[Token(Token = "0x60047BF")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60047C0")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17000F58")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SecondCharacterId
	{
		[Token(Token = "0x60047C1")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60047C2")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F59")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SecondCharacterCurrentWeight
	{
		[Token(Token = "0x60047C3")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60047C4")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x17000F5A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SecondCharacterMaxWeight
	{
		[Token(Token = "0x60047C5")]
		[Address(RVA = "0x946B90", Offset = "0x945F90", VA = "0x180946B90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60047C6")]
		[Address(RVA = "0x9470F0", Offset = "0x9464F0", VA = "0x1809470F0")]
		set
		{
		}
	}

	[Token(Token = "0x60047B6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedWithPodsEvent()
	{
	}

	[Token(Token = "0x60047B7")]
	[Address(RVA = "0xAAC630", Offset = "0xAABA30", VA = "0x180AAC630")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeStartedWithPodsEvent(ExchangeStartedWithPodsEvent other)
	{
	}

	[Token(Token = "0x60047B8")]
	[Address(RVA = "0xAAC150", Offset = "0xAAB550", VA = "0x180AAC150", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedWithPodsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60047C7")]
	[Address(RVA = "0xAAC200", Offset = "0xAAB600", VA = "0x180AAC200", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60047C8")]
	[Address(RVA = "0xAAC2C0", Offset = "0xAAB6C0", VA = "0x180AAC2C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeStartedWithPodsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60047C9")]
	[Address(RVA = "0xAAC320", Offset = "0xAAB720", VA = "0x180AAC320", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60047CA")]
	[Address(RVA = "0xAAC4D0", Offset = "0xAAB8D0", VA = "0x180AAC4D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60047CB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60047CC")]
	[Address(RVA = "0xAAC910", Offset = "0xAABD10", VA = "0x180AAC910", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60047CD")]
	[Address(RVA = "0xAABFC0", Offset = "0xAAB3C0", VA = "0x180AABFC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60047CE")]
	[Address(RVA = "0xAAC430", Offset = "0xAAB830", VA = "0x180AAC430", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeStartedWithPodsEvent other)
	{
	}

	[Token(Token = "0x60047CF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60047D0")]
	[Address(RVA = "0xAAC7B0", Offset = "0xAABBB0", VA = "0x180AAC7B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
