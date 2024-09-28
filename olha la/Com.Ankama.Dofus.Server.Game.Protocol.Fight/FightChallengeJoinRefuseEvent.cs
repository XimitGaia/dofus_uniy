using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x200060A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightChallengeJoinRefuseEvent : IMessage<FightChallengeJoinRefuseEvent>, IMessage, IEquatable<FightChallengeJoinRefuseEvent>, IDeepCloneable<FightChallengeJoinRefuseEvent>, IBufferMessage
{
	[Token(Token = "0x200060B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200060C")]
		public enum FighterRefusedReason
		{
			[Token(Token = "0x400152E")]
			[OriginalName("FIGHTER_REFUSED")]
			FighterRefused,
			[Token(Token = "0x400152F")]
			[OriginalName("FIGHTER_ACCEPTED")]
			FighterAccepted,
			[Token(Token = "0x4001530")]
			[OriginalName("CHALLENGE_FULL")]
			ChallengeFull,
			[Token(Token = "0x4001531")]
			[OriginalName("TEAM_FULL")]
			TeamFull,
			[Token(Token = "0x4001532")]
			[OriginalName("WRONG_ALIGNMENT")]
			WrongAlignment,
			[Token(Token = "0x4001533")]
			[OriginalName("WRONG_GUILD")]
			WrongGuild,
			[Token(Token = "0x4001534")]
			[OriginalName("TOO_LATE")]
			TooLate,
			[Token(Token = "0x4001535")]
			[OriginalName("MUTANT_REFUSED")]
			MutantRefused,
			[Token(Token = "0x4001536")]
			[OriginalName("WRONG_MAP")]
			WrongMap,
			[Token(Token = "0x4001537")]
			[OriginalName("JUST_RESPAWNED")]
			JustRespawned,
			[Token(Token = "0x4001538")]
			[OriginalName("IM_OCCUPIED")]
			ImOccupied,
			[Token(Token = "0x4001539")]
			[OriginalName("OPPONENT_OCCUPIED")]
			OpponentOccupied,
			[Token(Token = "0x400153A")]
			[OriginalName("FIGHT_MYSELF")]
			FightMyself,
			[Token(Token = "0x400153B")]
			[OriginalName("INSUFFICIENT_RIGHTS")]
			InsufficientRights,
			[Token(Token = "0x400153C")]
			[OriginalName("MEMBER_ACCOUNT_NEEDED")]
			MemberAccountNeeded,
			[Token(Token = "0x400153D")]
			[OriginalName("OPPONENT_NOT_MEMBER")]
			OpponentNotMember,
			[Token(Token = "0x400153E")]
			[OriginalName("TEAM_LIMITED_BY_MAIN_CHARACTER")]
			TeamLimitedByMainCharacter,
			[Token(Token = "0x400153F")]
			[OriginalName("MULTI_ACCOUNT_NOT_ALLOWED")]
			MultiAccountNotAllowed,
			[Token(Token = "0x4001540")]
			[OriginalName("GHOST_REFUSED")]
			GhostRefused,
			[Token(Token = "0x4001541")]
			[OriginalName("WRONG_ALLIANCE")]
			WrongAlliance,
			[Token(Token = "0x4001542")]
			[OriginalName("AVA_ZONE")]
			AvaZone,
			[Token(Token = "0x4001543")]
			[OriginalName("ENTITY_REFUSED")]
			EntityRefused,
			[Token(Token = "0x4001544")]
			[OriginalName("NOT_ENOUGH_ROOM")]
			NotEnoughRoom,
			[Token(Token = "0x4001545")]
			[OriginalName("GUEST_ACCOUNT")]
			GuestAccount
		}
	}

	[Token(Token = "0x4001527")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightChallengeJoinRefuseEvent> _parser;

	[Token(Token = "0x4001528")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001529")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x400152A")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x400152B")]
	public const int ReasonFieldNumber = 2;

	[Token(Token = "0x400152C")]
	[FieldOffset(Offset = "0x20")]
	private Types.FighterRefusedReason reason_;

	[Token(Token = "0x17000DDE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightChallengeJoinRefuseEvent> Parser
	{
		[Token(Token = "0x6004097")]
		[Address(RVA = "0xA3C710", Offset = "0xA3BB10", VA = "0x180A3C710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DDF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004098")]
		[Address(RVA = "0xA3C660", Offset = "0xA3BA60", VA = "0x180A3C660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004099")]
		[Address(RVA = "0xA3C760", Offset = "0xA3BB60", VA = "0x180A3C760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DE1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x600409D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600409E")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000DE2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.FighterRefusedReason Reason
	{
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Types.FighterRefusedReason);
		}
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600409A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightChallengeJoinRefuseEvent()
	{
	}

	[Token(Token = "0x600409B")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightChallengeJoinRefuseEvent(FightChallengeJoinRefuseEvent other)
	{
	}

	[Token(Token = "0x600409C")]
	[Address(RVA = "0xA3C3D0", Offset = "0xA3B7D0", VA = "0x180A3C3D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightChallengeJoinRefuseEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60040A1")]
	[Address(RVA = "0xA3C460", Offset = "0xA3B860", VA = "0x180A3C460", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60040A2")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightChallengeJoinRefuseEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60040A3")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60040A4")]
	[Address(RVA = "0xA3C500", Offset = "0xA3B900", VA = "0x180A3C500", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60040A5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60040A6")]
	[Address(RVA = "0x948ED0", Offset = "0x9482D0", VA = "0x180948ED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60040A7")]
	[Address(RVA = "0xA3C310", Offset = "0xA3B710", VA = "0x180A3C310", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60040A8")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightChallengeJoinRefuseEvent other)
	{
	}

	[Token(Token = "0x60040A9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60040AA")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
