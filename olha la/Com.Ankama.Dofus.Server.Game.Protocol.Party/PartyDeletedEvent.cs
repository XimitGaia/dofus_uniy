using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000298")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyDeletedEvent : IMessage<PartyDeletedEvent>, IMessage, IEquatable<PartyDeletedEvent>, IDeepCloneable<PartyDeletedEvent>, IBufferMessage
{
	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyDeletedEvent> _parser;

	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000904")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x170005C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyDeletedEvent> Parser
	{
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0xD0EED0", Offset = "0xD0E2D0", VA = "0x180D0EED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0xD0EE20", Offset = "0xD0E220", VA = "0x180D0EE20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0xD0EF20", Offset = "0xD0E320", VA = "0x180D0EF20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001AD9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyDeletedEvent()
	{
	}

	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyDeletedEvent(PartyDeletedEvent other)
	{
	}

	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0xD0EBB0", Offset = "0xD0DFB0", VA = "0x180D0EBB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyDeletedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0xD0EC30", Offset = "0xD0E030", VA = "0x180D0EC30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyDeletedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0xD0ECC0", Offset = "0xD0E0C0", VA = "0x180D0ECC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0xD0EB20", Offset = "0xD0DF20", VA = "0x180D0EB20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyDeletedEvent other)
	{
	}

	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
