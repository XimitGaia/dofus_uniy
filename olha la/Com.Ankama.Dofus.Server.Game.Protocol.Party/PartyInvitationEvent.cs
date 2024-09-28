using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000274")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationEvent : IMessage<PartyInvitationEvent>, IMessage, IEquatable<PartyInvitationEvent>, IDeepCloneable<PartyInvitationEvent>, IBufferMessage
{
	[Token(Token = "0x4000849")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationEvent> _parser;

	[Token(Token = "0x400084A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400084B")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400084D")]
	public const int PartyTypeFieldNumber = 2;

	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0x1C")]
	private PartyType partyType_;

	[Token(Token = "0x400084F")]
	public const int PartyNameFieldNumber = 3;

	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0x20")]
	private string partyName_;

	[Token(Token = "0x4000851")]
	public const int MaxParticipantsFieldNumber = 4;

	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0x28")]
	private int maxParticipants_;

	[Token(Token = "0x4000853")]
	public const int FromPlayerIdFieldNumber = 5;

	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0x30")]
	private long fromPlayerId_;

	[Token(Token = "0x4000855")]
	public const int FromPlayerNameFieldNumber = 6;

	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0x38")]
	private string fromPlayerName_;

	[Token(Token = "0x4000857")]
	public const int ToPlayerIdFieldNumber = 7;

	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0x40")]
	private long toPlayerId_;

	[Token(Token = "0x17000554")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyInvitationEvent> Parser
	{
		[Token(Token = "0x6001912")]
		[Address(RVA = "0xCF68D0", Offset = "0xCF5CD0", VA = "0x180CF68D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000555")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001913")]
		[Address(RVA = "0xCF6820", Offset = "0xCF5C20", VA = "0x180CF6820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000556")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001914")]
		[Address(RVA = "0xCF6C00", Offset = "0xCF6000", VA = "0x180CF6C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000557")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000558")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyType PartyType
	{
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(PartyType);
		}
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000559")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PartyName
	{
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600191D")]
		[Address(RVA = "0xCF6D50", Offset = "0xCF6150", VA = "0x180CF6D50")]
		set
		{
		}
	}

	[Token(Token = "0x1700055A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxParticipants
	{
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x1700055B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long FromPlayerId
	{
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700055C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string FromPlayerName
	{
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001923")]
		[Address(RVA = "0xCF6CE0", Offset = "0xCF60E0", VA = "0x180CF6CE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700055D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ToPlayerId
	{
		[Token(Token = "0x6001924")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001925")]
		[Address(RVA = "0xAFF0D0", Offset = "0xAFE4D0", VA = "0x180AFF0D0")]
		set
		{
		}
	}

	[Token(Token = "0x6001915")]
	[Address(RVA = "0xCF67B0", Offset = "0xCF5BB0", VA = "0x180CF67B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationEvent()
	{
	}

	[Token(Token = "0x6001916")]
	[Address(RVA = "0xCF66B0", Offset = "0xCF5AB0", VA = "0x180CF66B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationEvent(PartyInvitationEvent other)
	{
	}

	[Token(Token = "0x6001917")]
	[Address(RVA = "0xCF6090", Offset = "0xCF5490", VA = "0x180CF6090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyInvitationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001926")]
	[Address(RVA = "0xCF6270", Offset = "0xCF5670", VA = "0x180CF6270", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001927")]
	[Address(RVA = "0xCF61C0", Offset = "0xCF55C0", VA = "0x180CF61C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyInvitationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001928")]
	[Address(RVA = "0xCF6360", Offset = "0xCF5760", VA = "0x180CF6360", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001929")]
	[Address(RVA = "0xCF6550", Offset = "0xCF5950", VA = "0x180CF6550", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600192A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600192B")]
	[Address(RVA = "0xCF6AC0", Offset = "0xCF5EC0", VA = "0x180CF6AC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600192C")]
	[Address(RVA = "0xCF5EF0", Offset = "0xCF52F0", VA = "0x180CF5EF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600192D")]
	[Address(RVA = "0xCF6490", Offset = "0xCF5890", VA = "0x180CF6490", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyInvitationEvent other)
	{
	}

	[Token(Token = "0x600192E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600192F")]
	[Address(RVA = "0xCF6920", Offset = "0xCF5D20", VA = "0x180CF6920", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
