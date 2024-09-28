using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200025E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationAcceptRequest : IMessage<PartyInvitationAcceptRequest>, IMessage, IEquatable<PartyInvitationAcceptRequest>, IDeepCloneable<PartyInvitationAcceptRequest>, IBufferMessage
{
	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationAcceptRequest> _parser;

	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000802")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x1700051F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyInvitationAcceptRequest> Parser
	{
		[Token(Token = "0x600180E")]
		[Address(RVA = "0xCF3540", Offset = "0xCF2940", VA = "0x180CF3540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000520")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600180F")]
		[Address(RVA = "0xCF3490", Offset = "0xCF2890", VA = "0x180CF3490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000521")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001810")]
		[Address(RVA = "0xCF3590", Offset = "0xCF2990", VA = "0x180CF3590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000522")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001815")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001811")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationAcceptRequest()
	{
	}

	[Token(Token = "0x6001812")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationAcceptRequest(PartyInvitationAcceptRequest other)
	{
	}

	[Token(Token = "0x6001813")]
	[Address(RVA = "0xCF3220", Offset = "0xCF2620", VA = "0x180CF3220", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationAcceptRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001816")]
	[Address(RVA = "0xCF32A0", Offset = "0xCF26A0", VA = "0x180CF32A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001817")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyInvitationAcceptRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001818")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001819")]
	[Address(RVA = "0xCF3330", Offset = "0xCF2730", VA = "0x180CF3330", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600181A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600181B")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600181C")]
	[Address(RVA = "0xCF3190", Offset = "0xCF2590", VA = "0x180CF3190", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600181D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyInvitationAcceptRequest other)
	{
	}

	[Token(Token = "0x600181E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600181F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
