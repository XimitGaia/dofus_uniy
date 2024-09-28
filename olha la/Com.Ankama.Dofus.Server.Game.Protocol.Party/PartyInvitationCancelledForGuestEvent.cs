using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000278")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationCancelledForGuestEvent : IMessage<PartyInvitationCancelledForGuestEvent>, IMessage, IEquatable<PartyInvitationCancelledForGuestEvent>, IDeepCloneable<PartyInvitationCancelledForGuestEvent>, IBufferMessage
{
	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationCancelledForGuestEvent> _parser;

	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000871")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000873")]
	public const int CancellerIdFieldNumber = 2;

	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x20")]
	private long cancellerId_;

	[Token(Token = "0x17000569")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyInvitationCancelledForGuestEvent> Parser
	{
		[Token(Token = "0x6001956")]
		[Address(RVA = "0xCF4500", Offset = "0xCF3900", VA = "0x180CF4500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001957")]
		[Address(RVA = "0xCF4450", Offset = "0xCF3850", VA = "0x180CF4450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001958")]
		[Address(RVA = "0xCF4550", Offset = "0xCF3950", VA = "0x180CF4550", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x600195C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700056D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CancellerId
	{
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001959")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationCancelledForGuestEvent()
	{
	}

	[Token(Token = "0x600195A")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationCancelledForGuestEvent(PartyInvitationCancelledForGuestEvent other)
	{
	}

	[Token(Token = "0x600195B")]
	[Address(RVA = "0xCF41C0", Offset = "0xCF35C0", VA = "0x180CF41C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationCancelledForGuestEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001960")]
	[Address(RVA = "0xCF4250", Offset = "0xCF3650", VA = "0x180CF4250", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001961")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyInvitationCancelledForGuestEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001962")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001963")]
	[Address(RVA = "0xCF42F0", Offset = "0xCF36F0", VA = "0x180CF42F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001964")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001965")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001966")]
	[Address(RVA = "0xCF4100", Offset = "0xCF3500", VA = "0x180CF4100", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001967")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyInvitationCancelledForGuestEvent other)
	{
	}

	[Token(Token = "0x6001968")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001969")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
