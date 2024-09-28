using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000296")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyRestrictedEvent : IMessage<PartyRestrictedEvent>, IMessage, IEquatable<PartyRestrictedEvent>, IDeepCloneable<PartyRestrictedEvent>, IBufferMessage
{
	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyRestrictedEvent> _parser;

	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008FD")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x40008FF")]
	public const int RestrictedFieldNumber = 2;

	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x1C")]
	private bool restricted_;

	[Token(Token = "0x170005BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyRestrictedEvent> Parser
	{
		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0xD17E10", Offset = "0xD17210", VA = "0x180D17E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0xD17D60", Offset = "0xD17160", VA = "0x180D17D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001AC0")]
		[Address(RVA = "0xD17E60", Offset = "0xD17260", VA = "0x180D17E60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001AC4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Restricted
	{
		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyRestrictedEvent()
	{
	}

	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyRestrictedEvent(PartyRestrictedEvent other)
	{
	}

	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0xD17A20", Offset = "0xD16E20", VA = "0x180D17A20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyRestrictedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0xD17AB0", Offset = "0xD16EB0", VA = "0x180D17AB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyRestrictedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0xD17B40", Offset = "0xD16F40", VA = "0x180D17B40", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0xD17C00", Offset = "0xD17000", VA = "0x180D17C00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001ACE")]
	[Address(RVA = "0xD17990", Offset = "0xD16D90", VA = "0x180D17990", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001ACF")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyRestrictedEvent other)
	{
	}

	[Token(Token = "0x6001AD0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001AD1")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
