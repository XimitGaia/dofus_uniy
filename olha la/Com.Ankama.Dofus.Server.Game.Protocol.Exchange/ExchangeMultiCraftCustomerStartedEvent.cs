using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200071B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMultiCraftCustomerStartedEvent : IMessage<ExchangeMultiCraftCustomerStartedEvent>, IMessage, IEquatable<ExchangeMultiCraftCustomerStartedEvent>, IDeepCloneable<ExchangeMultiCraftCustomerStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4001907")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMultiCraftCustomerStartedEvent> _parser;

	[Token(Token = "0x4001908")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001909")]
	public const int SkillIdFieldNumber = 1;

	[Token(Token = "0x400190A")]
	[FieldOffset(Offset = "0x18")]
	private int skillId_;

	[Token(Token = "0x400190B")]
	public const int CrafterJobLevelFieldNumber = 2;

	[Token(Token = "0x400190C")]
	[FieldOffset(Offset = "0x1C")]
	private int crafterJobLevel_;

	[Token(Token = "0x17001056")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeMultiCraftCustomerStartedEvent> Parser
	{
		[Token(Token = "0x6004C52")]
		[Address(RVA = "0xABF5F0", Offset = "0xABE9F0", VA = "0x180ABF5F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001057")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004C53")]
		[Address(RVA = "0xABF540", Offset = "0xABE940", VA = "0x180ABF540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001058")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004C54")]
		[Address(RVA = "0xABF640", Offset = "0xABEA40", VA = "0x180ABF640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001059")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SkillId
	{
		[Token(Token = "0x6004C58")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C59")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700105A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CrafterJobLevel
	{
		[Token(Token = "0x6004C5A")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C5B")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6004C55")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftCustomerStartedEvent()
	{
	}

	[Token(Token = "0x6004C56")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftCustomerStartedEvent(ExchangeMultiCraftCustomerStartedEvent other)
	{
	}

	[Token(Token = "0x6004C57")]
	[Address(RVA = "0xABF2C0", Offset = "0xABE6C0", VA = "0x180ABF2C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftCustomerStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004C5C")]
	[Address(RVA = "0xABF350", Offset = "0xABE750", VA = "0x180ABF350", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C5D")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMultiCraftCustomerStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C5E")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004C5F")]
	[Address(RVA = "0xABF3E0", Offset = "0xABE7E0", VA = "0x180ABF3E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004C60")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004C61")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004C62")]
	[Address(RVA = "0xABF200", Offset = "0xABE600", VA = "0x180ABF200", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004C63")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMultiCraftCustomerStartedEvent other)
	{
	}

	[Token(Token = "0x6004C64")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004C65")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
