using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000719")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMultiCraftCrafterStartedEvent : IMessage<ExchangeMultiCraftCrafterStartedEvent>, IMessage, IEquatable<ExchangeMultiCraftCrafterStartedEvent>, IDeepCloneable<ExchangeMultiCraftCrafterStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMultiCraftCrafterStartedEvent> _parser;

	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001904")]
	public const int SkillIdFieldNumber = 1;

	[Token(Token = "0x4001905")]
	[FieldOffset(Offset = "0x18")]
	private int skillId_;

	[Token(Token = "0x17001052")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMultiCraftCrafterStartedEvent> Parser
	{
		[Token(Token = "0x6004C3C")]
		[Address(RVA = "0xABF0D0", Offset = "0xABE4D0", VA = "0x180ABF0D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001053")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004C3D")]
		[Address(RVA = "0xABF020", Offset = "0xABE420", VA = "0x180ABF020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001054")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0xABF120", Offset = "0xABE520", VA = "0x180ABF120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001055")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SkillId
	{
		[Token(Token = "0x6004C42")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004C3F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftCrafterStartedEvent()
	{
	}

	[Token(Token = "0x6004C40")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMultiCraftCrafterStartedEvent(ExchangeMultiCraftCrafterStartedEvent other)
	{
	}

	[Token(Token = "0x6004C41")]
	[Address(RVA = "0xABEDB0", Offset = "0xABE1B0", VA = "0x180ABEDB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMultiCraftCrafterStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004C44")]
	[Address(RVA = "0xABEE30", Offset = "0xABE230", VA = "0x180ABEE30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C45")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMultiCraftCrafterStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C46")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004C47")]
	[Address(RVA = "0xABEEC0", Offset = "0xABE2C0", VA = "0x180ABEEC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004C48")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004C49")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004C4A")]
	[Address(RVA = "0xABED20", Offset = "0xABE120", VA = "0x180ABED20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004C4B")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeMultiCraftCrafterStartedEvent other)
	{
	}

	[Token(Token = "0x6004C4C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004C4D")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
