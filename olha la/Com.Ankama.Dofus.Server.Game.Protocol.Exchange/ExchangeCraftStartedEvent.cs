using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000717")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeCraftStartedEvent : IMessage<ExchangeCraftStartedEvent>, IMessage, IEquatable<ExchangeCraftStartedEvent>, IDeepCloneable<ExchangeCraftStartedEvent>, IBufferMessage
{
	[Token(Token = "0x40018FB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeCraftStartedEvent> _parser;

	[Token(Token = "0x40018FC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018FD")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40018FE")]
	public const int SkillIdFieldNumber = 1;

	[Token(Token = "0x40018FF")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int SkillIdDefaultValue;

	[Token(Token = "0x4001900")]
	[FieldOffset(Offset = "0x1C")]
	private int skillId_;

	[Token(Token = "0x1700104D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeCraftStartedEvent> Parser
	{
		[Token(Token = "0x6004C24")]
		[Address(RVA = "0xAB9540", Offset = "0xAB8940", VA = "0x180AB9540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700104E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004C25")]
		[Address(RVA = "0xAB9490", Offset = "0xAB8890", VA = "0x180AB9490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700104F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004C26")]
		[Address(RVA = "0xAB9740", Offset = "0xAB8B40", VA = "0x180AB9740", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001050")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SkillId
	{
		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0xAB9590", Offset = "0xAB8990", VA = "0x180AB9590")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
		set
		{
		}
	}

	[Token(Token = "0x17001051")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSkillId
	{
		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004C27")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftStartedEvent()
	{
	}

	[Token(Token = "0x6004C28")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeCraftStartedEvent(ExchangeCraftStartedEvent other)
	{
	}

	[Token(Token = "0x6004C29")]
	[Address(RVA = "0xAB9050", Offset = "0xAB8450", VA = "0x180AB9050", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004C2D")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearSkillId()
	{
	}

	[Token(Token = "0x6004C2E")]
	[Address(RVA = "0xAB90E0", Offset = "0xAB84E0", VA = "0x180AB90E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C2F")]
	[Address(RVA = "0xAB9190", Offset = "0xAB8590", VA = "0x180AB9190", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeCraftStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C30")]
	[Address(RVA = "0xAB9200", Offset = "0xAB8600", VA = "0x180AB9200", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004C31")]
	[Address(RVA = "0xAB9320", Offset = "0xAB8720", VA = "0x180AB9320", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004C32")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004C33")]
	[Address(RVA = "0xAB96A0", Offset = "0xAB8AA0", VA = "0x180AB96A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004C34")]
	[Address(RVA = "0xAB8F80", Offset = "0xAB8380", VA = "0x180AB8F80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004C35")]
	[Address(RVA = "0xAB92C0", Offset = "0xAB86C0", VA = "0x180AB92C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeCraftStartedEvent other)
	{
	}

	[Token(Token = "0x6004C36")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004C37")]
	[Address(RVA = "0xAB9600", Offset = "0xAB8A00", VA = "0x180AB9600", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
