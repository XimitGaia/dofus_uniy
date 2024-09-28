using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000262")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationCancelRequest : IMessage<PartyInvitationCancelRequest>, IMessage, IEquatable<PartyInvitationCancelRequest>, IDeepCloneable<PartyInvitationCancelRequest>, IBufferMessage
{
	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationCancelRequest> _parser;

	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400080C")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400080E")]
	public const int GuestIdFieldNumber = 2;

	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x20")]
	private long guestId_;

	[Token(Token = "0x17000527")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyInvitationCancelRequest> Parser
	{
		[Token(Token = "0x600183A")]
		[Address(RVA = "0xCF3A70", Offset = "0xCF2E70", VA = "0x180CF3A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000528")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600183B")]
		[Address(RVA = "0xCF39C0", Offset = "0xCF2DC0", VA = "0x180CF39C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000529")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600183C")]
		[Address(RVA = "0xCF3AC0", Offset = "0xCF2EC0", VA = "0x180CF3AC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700052B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long GuestId
	{
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600183D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationCancelRequest()
	{
	}

	[Token(Token = "0x600183E")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationCancelRequest(PartyInvitationCancelRequest other)
	{
	}

	[Token(Token = "0x600183F")]
	[Address(RVA = "0xCF3730", Offset = "0xCF2B30", VA = "0x180CF3730", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationCancelRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001844")]
	[Address(RVA = "0xCF37C0", Offset = "0xCF2BC0", VA = "0x180CF37C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001845")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyInvitationCancelRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001846")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001847")]
	[Address(RVA = "0xCF3860", Offset = "0xCF2C60", VA = "0x180CF3860", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001848")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001849")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600184A")]
	[Address(RVA = "0xCF3670", Offset = "0xCF2A70", VA = "0x180CF3670", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600184B")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyInvitationCancelRequest other)
	{
	}

	[Token(Token = "0x600184C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600184D")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
