using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000260")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationRefuseRequest : IMessage<PartyInvitationRefuseRequest>, IMessage, IEquatable<PartyInvitationRefuseRequest>, IDeepCloneable<PartyInvitationRefuseRequest>, IBufferMessage
{
	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationRefuseRequest> _parser;

	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000807")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x17000523")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyInvitationRefuseRequest> Parser
	{
		[Token(Token = "0x6001824")]
		[Address(RVA = "0xCF7170", Offset = "0xCF6570", VA = "0x180CF7170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000524")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001825")]
		[Address(RVA = "0xCF70C0", Offset = "0xCF64C0", VA = "0x180CF70C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000525")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001826")]
		[Address(RVA = "0xCF71C0", Offset = "0xCF65C0", VA = "0x180CF71C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000526")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001827")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationRefuseRequest()
	{
	}

	[Token(Token = "0x6001828")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationRefuseRequest(PartyInvitationRefuseRequest other)
	{
	}

	[Token(Token = "0x6001829")]
	[Address(RVA = "0xCF6E50", Offset = "0xCF6250", VA = "0x180CF6E50", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationRefuseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600182C")]
	[Address(RVA = "0xCF6ED0", Offset = "0xCF62D0", VA = "0x180CF6ED0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600182D")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyInvitationRefuseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600182E")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600182F")]
	[Address(RVA = "0xCF6F60", Offset = "0xCF6360", VA = "0x180CF6F60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001830")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001831")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001832")]
	[Address(RVA = "0xCF6DC0", Offset = "0xCF61C0", VA = "0x180CF6DC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001833")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyInvitationRefuseRequest other)
	{
	}

	[Token(Token = "0x6001834")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001835")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
