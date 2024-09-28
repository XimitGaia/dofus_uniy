using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200029A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyLoyaltyStatusEvent : IMessage<PartyLoyaltyStatusEvent>, IMessage, IEquatable<PartyLoyaltyStatusEvent>, IDeepCloneable<PartyLoyaltyStatusEvent>, IBufferMessage
{
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyLoyaltyStatusEvent> _parser;

	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000909")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400090B")]
	public const int LoyalFieldNumber = 2;

	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x1C")]
	private bool loyal_;

	[Token(Token = "0x170005C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyLoyaltyStatusEvent> Parser
	{
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0xD11FE0", Offset = "0xD113E0", VA = "0x180D11FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0xD11F30", Offset = "0xD11330", VA = "0x180D11F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0xD12030", Offset = "0xD11430", VA = "0x180D12030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Loyal
	{
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyLoyaltyStatusEvent()
	{
	}

	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyLoyaltyStatusEvent(PartyLoyaltyStatusEvent other)
	{
	}

	[Token(Token = "0x6001AF1")]
	[Address(RVA = "0xD11BF0", Offset = "0xD10FF0", VA = "0x180D11BF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyLoyaltyStatusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0xD11C80", Offset = "0xD11080", VA = "0x180D11C80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyLoyaltyStatusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0xD11D10", Offset = "0xD11110", VA = "0x180D11D10", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0xD11DD0", Offset = "0xD111D0", VA = "0x180D11DD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001AFA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001AFB")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001AFC")]
	[Address(RVA = "0xD11B60", Offset = "0xD10F60", VA = "0x180D11B60", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001AFD")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyLoyaltyStatusEvent other)
	{
	}

	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
