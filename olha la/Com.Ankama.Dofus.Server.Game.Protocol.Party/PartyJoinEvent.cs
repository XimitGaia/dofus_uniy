using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000282")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyJoinEvent : IMessage<PartyJoinEvent>, IMessage, IEquatable<PartyJoinEvent>, IDeepCloneable<PartyJoinEvent>, IBufferMessage
{
	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyJoinEvent> _parser;

	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400089D")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400089F")]
	public const int PartyTypeFieldNumber = 2;

	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x1C")]
	private PartyType partyType_;

	[Token(Token = "0x40008A1")]
	public const int LeaderIdFieldNumber = 3;

	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x20")]
	private long leaderId_;

	[Token(Token = "0x40008A3")]
	public const int MaxParticipantsFieldNumber = 4;

	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x28")]
	private int maxParticipants_;

	[Token(Token = "0x40008A5")]
	public const int MembersFieldNumber = 5;

	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> _repeated_members_codec;

	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> members_;

	[Token(Token = "0x40008A8")]
	public const int GuestsFieldNumber = 6;

	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<PartyGuest> _repeated_guests_codec;

	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<PartyGuest> guests_;

	[Token(Token = "0x40008AB")]
	public const int RestrictedFieldNumber = 7;

	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x40")]
	private bool restricted_;

	[Token(Token = "0x40008AD")]
	public const int PartyNameFieldNumber = 8;

	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x48")]
	private string partyName_;

	[Token(Token = "0x1700057E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyJoinEvent> Parser
	{
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0xCF93E0", Offset = "0xCF87E0", VA = "0x180CF93E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60019B9")]
		[Address(RVA = "0xCF9330", Offset = "0xCF8730", VA = "0x180CF9330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000580")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60019BA")]
		[Address(RVA = "0xCF9850", Offset = "0xCF8C50", VA = "0x180CF9850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000581")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000582")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyType PartyType
	{
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(PartyType);
		}
		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000583")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LeaderId
	{
		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000584")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxParticipants
	{
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000585")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> Members
	{
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000586")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PartyGuest> Guests
	{
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000587")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Restricted
	{
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x871BC0", Offset = "0x870FC0", VA = "0x180871BC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x96EC00", Offset = "0x96E000", VA = "0x18096EC00")]
		set
		{
		}
	}

	[Token(Token = "0x17000588")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PartyName
	{
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0xCF9930", Offset = "0xCF8D30", VA = "0x180CF9930")]
		set
		{
		}
	}

	[Token(Token = "0x60019BB")]
	[Address(RVA = "0xCF9240", Offset = "0xCF8640", VA = "0x180CF9240")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyJoinEvent()
	{
	}

	[Token(Token = "0x60019BC")]
	[Address(RVA = "0xCF9060", Offset = "0xCF8460", VA = "0x180CF9060")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyJoinEvent(PartyJoinEvent other)
	{
	}

	[Token(Token = "0x60019BD")]
	[Address(RVA = "0xCF86A0", Offset = "0xCF7AA0", VA = "0x180CF86A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyJoinEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60019CC")]
	[Address(RVA = "0xCF88B0", Offset = "0xCF7CB0", VA = "0x180CF88B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60019CD")]
	[Address(RVA = "0xCF8A10", Offset = "0xCF7E10", VA = "0x180CF8A10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyJoinEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60019CE")]
	[Address(RVA = "0xCF8B30", Offset = "0xCF7F30", VA = "0x180CF8B30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60019CF")]
	[Address(RVA = "0xCF8DB0", Offset = "0xCF81B0", VA = "0x180CF8DB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60019D0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60019D1")]
	[Address(RVA = "0xCF9690", Offset = "0xCF8A90", VA = "0x180CF9690", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60019D2")]
	[Address(RVA = "0xCF84C0", Offset = "0xCF78C0", VA = "0x180CF84C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60019D3")]
	[Address(RVA = "0xCF8CB0", Offset = "0xCF80B0", VA = "0x180CF8CB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyJoinEvent other)
	{
	}

	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60019D5")]
	[Address(RVA = "0xCF9430", Offset = "0xCF8830", VA = "0x180CF9430", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
