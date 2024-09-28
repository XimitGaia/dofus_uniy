using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200071D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeCrafterJobLevelUpEvent : IMessage<ExchangeCrafterJobLevelUpEvent>, IMessage, IEquatable<ExchangeCrafterJobLevelUpEvent>, IDeepCloneable<ExchangeCrafterJobLevelUpEvent>, IBufferMessage
{
	[Token(Token = "0x400190E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeCrafterJobLevelUpEvent> _parser;

	[Token(Token = "0x400190F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001910")]
	public const int CrafterJobLevelFieldNumber = 1;

	[Token(Token = "0x4001911")]
	[FieldOffset(Offset = "0x18")]
	private int crafterJobLevel_;

	[Token(Token = "0x1700105B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeCrafterJobLevelUpEvent> Parser
	{
		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0xAB9BE0", Offset = "0xAB8FE0", VA = "0x180AB9BE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700105C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0xAB9B30", Offset = "0xAB8F30", VA = "0x180AB9B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700105D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0xAB9C30", Offset = "0xAB9030", VA = "0x180AB9C30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700105E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CrafterJobLevel
	{
		[Token(Token = "0x6004C70")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004C6D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeCrafterJobLevelUpEvent()
	{
	}

	[Token(Token = "0x6004C6E")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeCrafterJobLevelUpEvent(ExchangeCrafterJobLevelUpEvent other)
	{
	}

	[Token(Token = "0x6004C6F")]
	[Address(RVA = "0xAB98C0", Offset = "0xAB8CC0", VA = "0x180AB98C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCrafterJobLevelUpEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004C72")]
	[Address(RVA = "0xAB9940", Offset = "0xAB8D40", VA = "0x180AB9940", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C73")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeCrafterJobLevelUpEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C74")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004C75")]
	[Address(RVA = "0xAB99D0", Offset = "0xAB8DD0", VA = "0x180AB99D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004C76")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004C77")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004C78")]
	[Address(RVA = "0xAB9830", Offset = "0xAB8C30", VA = "0x180AB9830", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004C79")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeCrafterJobLevelUpEvent other)
	{
	}

	[Token(Token = "0x6004C7A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004C7B")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
