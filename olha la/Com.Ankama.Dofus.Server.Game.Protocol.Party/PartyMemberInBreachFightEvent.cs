using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200029E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyMemberInBreachFightEvent : IMessage<PartyMemberInBreachFightEvent>, IMessage, IEquatable<PartyMemberInBreachFightEvent>, IDeepCloneable<PartyMemberInBreachFightEvent>, IBufferMessage
{
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyMemberInBreachFightEvent> _parser;

	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000923")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000925")]
	public const int ReasonFieldNumber = 2;

	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x1C")]
	private PartyMemberInFightCause reason_;

	[Token(Token = "0x4000927")]
	public const int MemberIdFieldNumber = 3;

	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x20")]
	private long memberId_;

	[Token(Token = "0x4000929")]
	public const int MemberAccountIdFieldNumber = 4;

	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0x28")]
	private long memberAccountId_;

	[Token(Token = "0x400092B")]
	public const int MemberNameFieldNumber = 5;

	[Token(Token = "0x400092C")]
	[FieldOffset(Offset = "0x30")]
	private string memberName_;

	[Token(Token = "0x400092D")]
	public const int FightIdFieldNumber = 6;

	[Token(Token = "0x400092E")]
	[FieldOffset(Offset = "0x38")]
	private int fightId_;

	[Token(Token = "0x400092F")]
	public const int TimeBeforeFightStartFieldNumber = 7;

	[Token(Token = "0x4000930")]
	[FieldOffset(Offset = "0x3C")]
	private int timeBeforeFightStart_;

	[Token(Token = "0x4000931")]
	public const int FloorFieldNumber = 8;

	[Token(Token = "0x4000932")]
	[FieldOffset(Offset = "0x40")]
	private int floor_;

	[Token(Token = "0x4000933")]
	public const int RoomFieldNumber = 9;

	[Token(Token = "0x4000934")]
	[FieldOffset(Offset = "0x44")]
	private int room_;

	[Token(Token = "0x170005D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyMemberInBreachFightEvent> Parser
	{
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0xD12AE0", Offset = "0xD11EE0", VA = "0x180D12AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0xD12A30", Offset = "0xD11E30", VA = "0x180D12A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0xD12E60", Offset = "0xD12260", VA = "0x180D12E60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberInFightCause Reason
	{
		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(PartyMemberInFightCause);
		}
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170005DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MemberId
	{
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170005DB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MemberAccountId
	{
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x170005DC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MemberName
	{
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0xD12F40", Offset = "0xD12340", VA = "0x180D12F40")]
		set
		{
		}
	}

	[Token(Token = "0x170005DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x170005DE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TimeBeforeFightStart
	{
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x946B90", Offset = "0x945F90", VA = "0x180946B90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x9470F0", Offset = "0x9464F0", VA = "0x1809470F0")]
		set
		{
		}
	}

	[Token(Token = "0x170005DF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Floor
	{
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x9F30F0", Offset = "0x9F24F0", VA = "0x1809F30F0")]
		set
		{
		}
	}

	[Token(Token = "0x170005E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Room
	{
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x7D9DB0", Offset = "0x7D91B0", VA = "0x1807D9DB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x9F3100", Offset = "0x9F2500", VA = "0x1809F3100")]
		set
		{
		}
	}

	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0xD129E0", Offset = "0xD11DE0", VA = "0x180D129E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberInBreachFightEvent()
	{
	}

	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0xD12910", Offset = "0xD11D10", VA = "0x180D12910")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberInBreachFightEvent(PartyMemberInBreachFightEvent other)
	{
	}

	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0xD122F0", Offset = "0xD116F0", VA = "0x180D122F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberInBreachFightEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001B40")]
	[Address(RVA = "0xD123F0", Offset = "0xD117F0", VA = "0x180D123F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B41")]
	[Address(RVA = "0xD124F0", Offset = "0xD118F0", VA = "0x180D124F0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyMemberInBreachFightEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B42")]
	[Address(RVA = "0xD125A0", Offset = "0xD119A0", VA = "0x180D125A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001B43")]
	[Address(RVA = "0xD127B0", Offset = "0xD11BB0", VA = "0x180D127B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001B44")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001B45")]
	[Address(RVA = "0xD12CF0", Offset = "0xD120F0", VA = "0x180D12CF0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001B46")]
	[Address(RVA = "0xD12110", Offset = "0xD11510", VA = "0x180D12110", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001B47")]
	[Address(RVA = "0xD126F0", Offset = "0xD11AF0", VA = "0x180D126F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyMemberInBreachFightEvent other)
	{
	}

	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001B49")]
	[Address(RVA = "0xD12B30", Offset = "0xD11F30", VA = "0x180D12B30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
