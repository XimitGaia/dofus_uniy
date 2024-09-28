using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000635")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamRemoveMemberEvent : IMessage<FightTeamRemoveMemberEvent>, IMessage, IEquatable<FightTeamRemoveMemberEvent>, IDeepCloneable<FightTeamRemoveMemberEvent>, IBufferMessage
{
	[Token(Token = "0x40015E2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamRemoveMemberEvent> _parser;

	[Token(Token = "0x40015E3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015E4")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40015E5")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40015E6")]
	public const int TeamFieldNumber = 2;

	[Token(Token = "0x40015E7")]
	[FieldOffset(Offset = "0x1C")]
	private Team team_;

	[Token(Token = "0x40015E8")]
	public const int CharacterIdFieldNumber = 3;

	[Token(Token = "0x40015E9")]
	[FieldOffset(Offset = "0x20")]
	private long characterId_;

	[Token(Token = "0x17000E4B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTeamRemoveMemberEvent> Parser
	{
		[Token(Token = "0x6004284")]
		[Address(RVA = "0xA849B0", Offset = "0xA83DB0", VA = "0x180A849B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E4C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004285")]
		[Address(RVA = "0xA84900", Offset = "0xA83D00", VA = "0x180A84900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E4D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004286")]
		[Address(RVA = "0xA84AA0", Offset = "0xA83EA0", VA = "0x180A84AA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E4E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FightId
	{
		[Token(Token = "0x600428A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600428B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E4F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Team Team
	{
		[Token(Token = "0x600428C")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000E50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x600428E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600428F")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6004287")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamRemoveMemberEvent()
	{
	}

	[Token(Token = "0x6004288")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamRemoveMemberEvent(FightTeamRemoveMemberEvent other)
	{
	}

	[Token(Token = "0x6004289")]
	[Address(RVA = "0xA845C0", Offset = "0xA839C0", VA = "0x180A845C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamRemoveMemberEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004290")]
	[Address(RVA = "0xA84650", Offset = "0xA83A50", VA = "0x180A84650", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004291")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTeamRemoveMemberEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004292")]
	[Address(RVA = "0xA846F0", Offset = "0xA83AF0", VA = "0x180A846F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004293")]
	[Address(RVA = "0xA847A0", Offset = "0xA83BA0", VA = "0x180A847A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004294")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004295")]
	[Address(RVA = "0xA84A00", Offset = "0xA83E00", VA = "0x180A84A00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004296")]
	[Address(RVA = "0xA844E0", Offset = "0xA838E0", VA = "0x180A844E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004297")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTeamRemoveMemberEvent other)
	{
	}

	[Token(Token = "0x6004298")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004299")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
