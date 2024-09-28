using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200025C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationDetailsRequest : IMessage<PartyInvitationDetailsRequest>, IMessage, IEquatable<PartyInvitationDetailsRequest>, IDeepCloneable<PartyInvitationDetailsRequest>, IBufferMessage
{
	[Token(Token = "0x40007FB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationDetailsRequest> _parser;

	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007FD")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x1700051B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyInvitationDetailsRequest> Parser
	{
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0xCF5DC0", Offset = "0xCF51C0", VA = "0x180CF5DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0xCF5D10", Offset = "0xCF5110", VA = "0x180CF5D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0xCF5E10", Offset = "0xCF5210", VA = "0x180CF5E10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x60017FE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60017FB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationDetailsRequest()
	{
	}

	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationDetailsRequest(PartyInvitationDetailsRequest other)
	{
	}

	[Token(Token = "0x60017FD")]
	[Address(RVA = "0xCF5AA0", Offset = "0xCF4EA0", VA = "0x180CF5AA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationDetailsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001800")]
	[Address(RVA = "0xCF5B20", Offset = "0xCF4F20", VA = "0x180CF5B20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001801")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyInvitationDetailsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001802")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001803")]
	[Address(RVA = "0xCF5BB0", Offset = "0xCF4FB0", VA = "0x180CF5BB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001804")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001805")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001806")]
	[Address(RVA = "0xCF5A10", Offset = "0xCF4E10", VA = "0x180CF5A10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001807")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyInvitationDetailsRequest other)
	{
	}

	[Token(Token = "0x6001808")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001809")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
