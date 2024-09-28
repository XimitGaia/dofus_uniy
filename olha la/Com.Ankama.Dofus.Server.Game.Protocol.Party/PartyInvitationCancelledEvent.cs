using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200027A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationCancelledEvent : IMessage<PartyInvitationCancelledEvent>, IMessage, IEquatable<PartyInvitationCancelledEvent>, IDeepCloneable<PartyInvitationCancelledEvent>, IBufferMessage
{
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationCancelledEvent> _parser;

	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000878")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400087A")]
	public const int CancellerIdFieldNumber = 2;

	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x20")]
	private long cancellerId_;

	[Token(Token = "0x400087C")]
	public const int GuestIdFieldNumber = 3;

	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x28")]
	private long guestId_;

	[Token(Token = "0x1700056E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyInvitationCancelledEvent> Parser
	{
		[Token(Token = "0x600196E")]
		[Address(RVA = "0xCF3FD0", Offset = "0xCF33D0", VA = "0x180CF3FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600196F")]
		[Address(RVA = "0xCF3F20", Offset = "0xCF3320", VA = "0x180CF3F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000570")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001970")]
		[Address(RVA = "0xCF4020", Offset = "0xCF3420", VA = "0x180CF4020", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000571")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000572")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CancellerId
	{
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000573")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long GuestId
	{
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6001971")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationCancelledEvent()
	{
	}

	[Token(Token = "0x6001972")]
	[Address(RVA = "0xA97190", Offset = "0xA96590", VA = "0x180A97190")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationCancelledEvent(PartyInvitationCancelledEvent other)
	{
	}

	[Token(Token = "0x6001973")]
	[Address(RVA = "0xCF3C90", Offset = "0xCF3090", VA = "0x180CF3C90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationCancelledEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600197A")]
	[Address(RVA = "0xCF3D20", Offset = "0xCF3120", VA = "0x180CF3D20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600197B")]
	[Address(RVA = "0xA96E30", Offset = "0xA96230", VA = "0x180A96E30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyInvitationCancelledEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600197C")]
	[Address(RVA = "0xA96F10", Offset = "0xA96310", VA = "0x180A96F10", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600197D")]
	[Address(RVA = "0xCF3DC0", Offset = "0xCF31C0", VA = "0x180CF3DC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600197E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600197F")]
	[Address(RVA = "0xC44A90", Offset = "0xC43E90", VA = "0x180C44A90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001980")]
	[Address(RVA = "0xCF3BA0", Offset = "0xCF2FA0", VA = "0x180CF3BA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001981")]
	[Address(RVA = "0xA96FC0", Offset = "0xA963C0", VA = "0x180A96FC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyInvitationCancelledEvent other)
	{
	}

	[Token(Token = "0x6001982")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001983")]
	[Address(RVA = "0xA972F0", Offset = "0xA966F0", VA = "0x180A972F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
