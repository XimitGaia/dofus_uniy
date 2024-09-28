using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000276")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationDetailsEvent : IMessage<PartyInvitationDetailsEvent>, IMessage, IEquatable<PartyInvitationDetailsEvent>, IDeepCloneable<PartyInvitationDetailsEvent>, IBufferMessage
{
	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationDetailsEvent> _parser;

	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400085C")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x400085D")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400085E")]
	public const int PartyTypeFieldNumber = 2;

	[Token(Token = "0x400085F")]
	[FieldOffset(Offset = "0x1C")]
	private PartyType partyType_;

	[Token(Token = "0x4000860")]
	public const int PartyNameFieldNumber = 3;

	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x20")]
	private string partyName_;

	[Token(Token = "0x4000862")]
	public const int FromPlayerIdFieldNumber = 4;

	[Token(Token = "0x4000863")]
	[FieldOffset(Offset = "0x28")]
	private long fromPlayerId_;

	[Token(Token = "0x4000864")]
	public const int FromPlayerNameFieldNumber = 5;

	[Token(Token = "0x4000865")]
	[FieldOffset(Offset = "0x30")]
	private string fromPlayerName_;

	[Token(Token = "0x4000866")]
	public const int LeaderIdFieldNumber = 6;

	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x38")]
	private long leaderId_;

	[Token(Token = "0x4000868")]
	public const int MembersFieldNumber = 7;

	[Token(Token = "0x4000869")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> _repeated_members_codec;

	[Token(Token = "0x400086A")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> members_;

	[Token(Token = "0x400086B")]
	public const int GuestsFieldNumber = 8;

	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<PartyGuest> _repeated_guests_codec;

	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0x48")]
	private readonly RepeatedField<PartyGuest> guests_;

	[Token(Token = "0x1700055E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyInvitationDetailsEvent> Parser
	{
		[Token(Token = "0x6001934")]
		[Address(RVA = "0xCF53C0", Offset = "0xCF47C0", VA = "0x180CF53C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700055F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001935")]
		[Address(RVA = "0xCF5310", Offset = "0xCF4710", VA = "0x180CF5310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000560")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001936")]
		[Address(RVA = "0xCF5850", Offset = "0xCF4C50", VA = "0x180CF5850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000561")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000562")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyType PartyType
	{
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(PartyType);
		}
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000563")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PartyName
	{
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600193F")]
		[Address(RVA = "0xCF59A0", Offset = "0xCF4DA0", VA = "0x180CF59A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000564")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FromPlayerId
	{
		[Token(Token = "0x6001940")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000565")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FromPlayerName
	{
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001943")]
		[Address(RVA = "0xCF5930", Offset = "0xCF4D30", VA = "0x180CF5930")]
		set
		{
		}
	}

	[Token(Token = "0x17000566")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LeaderId
	{
		[Token(Token = "0x6001944")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001945")]
		[Address(RVA = "0x9EFE00", Offset = "0x9EF200", VA = "0x1809EFE00")]
		set
		{
		}
	}

	[Token(Token = "0x17000567")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> Members
	{
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000568")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PartyGuest> Guests
	{
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001937")]
	[Address(RVA = "0xCF5110", Offset = "0xCF4510", VA = "0x180CF5110")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationDetailsEvent()
	{
	}

	[Token(Token = "0x6001938")]
	[Address(RVA = "0xCF5210", Offset = "0xCF4610", VA = "0x180CF5210")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationDetailsEvent(PartyInvitationDetailsEvent other)
	{
	}

	[Token(Token = "0x6001939")]
	[Address(RVA = "0xCF4840", Offset = "0xCF3C40", VA = "0x180CF4840", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationDetailsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001948")]
	[Address(RVA = "0xCF4A90", Offset = "0xCF3E90", VA = "0x180CF4A90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001949")]
	[Address(RVA = "0xCF4970", Offset = "0xCF3D70", VA = "0x180CF4970", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyInvitationDetailsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600194A")]
	[Address(RVA = "0xCF4BF0", Offset = "0xCF3FF0", VA = "0x180CF4BF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600194B")]
	[Address(RVA = "0xCF4E60", Offset = "0xCF4260", VA = "0x180CF4E60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600194C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600194D")]
	[Address(RVA = "0xCF5680", Offset = "0xCF4A80", VA = "0x180CF5680", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600194E")]
	[Address(RVA = "0xCF4630", Offset = "0xCF3A30", VA = "0x180CF4630", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600194F")]
	[Address(RVA = "0xCF4D50", Offset = "0xCF4150", VA = "0x180CF4D50", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyInvitationDetailsEvent other)
	{
	}

	[Token(Token = "0x6001950")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001951")]
	[Address(RVA = "0xCF5410", Offset = "0xCF4810", VA = "0x180CF5410", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
