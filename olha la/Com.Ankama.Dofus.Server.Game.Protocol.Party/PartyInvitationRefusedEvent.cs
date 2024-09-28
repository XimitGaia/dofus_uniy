using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200027C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationRefusedEvent : IMessage<PartyInvitationRefusedEvent>, IMessage, IEquatable<PartyInvitationRefusedEvent>, IDeepCloneable<PartyInvitationRefusedEvent>, IBufferMessage
{
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationRefusedEvent> _parser;

	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000881")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000883")]
	public const int GuestIdFieldNumber = 2;

	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x20")]
	private long guestId_;

	[Token(Token = "0x17000574")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyInvitationRefusedEvent> Parser
	{
		[Token(Token = "0x6001988")]
		[Address(RVA = "0xCF76A0", Offset = "0xCF6AA0", VA = "0x180CF76A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000575")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001989")]
		[Address(RVA = "0xCF75F0", Offset = "0xCF69F0", VA = "0x180CF75F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000576")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600198A")]
		[Address(RVA = "0xCF76F0", Offset = "0xCF6AF0", VA = "0x180CF76F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000577")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000578")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long GuestId
	{
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600198B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationRefusedEvent()
	{
	}

	[Token(Token = "0x600198C")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationRefusedEvent(PartyInvitationRefusedEvent other)
	{
	}

	[Token(Token = "0x600198D")]
	[Address(RVA = "0xCF7360", Offset = "0xCF6760", VA = "0x180CF7360", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationRefusedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001992")]
	[Address(RVA = "0xCF73F0", Offset = "0xCF67F0", VA = "0x180CF73F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001993")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyInvitationRefusedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001994")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001995")]
	[Address(RVA = "0xCF7490", Offset = "0xCF6890", VA = "0x180CF7490", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001996")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001997")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001998")]
	[Address(RVA = "0xCF72A0", Offset = "0xCF66A0", VA = "0x180CF72A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001999")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyInvitationRefusedEvent other)
	{
	}

	[Token(Token = "0x600199A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600199B")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
