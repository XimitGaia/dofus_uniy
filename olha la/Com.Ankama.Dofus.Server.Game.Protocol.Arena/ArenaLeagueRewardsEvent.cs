using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BA4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaLeagueRewardsEvent : IMessage<ArenaLeagueRewardsEvent>, IMessage, IEquatable<ArenaLeagueRewardsEvent>, IDeepCloneable<ArenaLeagueRewardsEvent>, IBufferMessage
{
	[Token(Token = "0x4002B72")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaLeagueRewardsEvent> _parser;

	[Token(Token = "0x4002B73")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B74")]
	public const int SeasonIdFieldNumber = 1;

	[Token(Token = "0x4002B75")]
	[FieldOffset(Offset = "0x18")]
	private int seasonId_;

	[Token(Token = "0x4002B76")]
	public const int LeagueIdFieldNumber = 2;

	[Token(Token = "0x4002B77")]
	[FieldOffset(Offset = "0x1C")]
	private int leagueId_;

	[Token(Token = "0x4002B78")]
	public const int LadderPositionFieldNumber = 3;

	[Token(Token = "0x4002B79")]
	[FieldOffset(Offset = "0x20")]
	private int ladderPosition_;

	[Token(Token = "0x4002B7A")]
	public const int EndSeasonRewardFieldNumber = 4;

	[Token(Token = "0x4002B7B")]
	[FieldOffset(Offset = "0x24")]
	private bool endSeasonReward_;

	[Token(Token = "0x17001AF5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ArenaLeagueRewardsEvent> Parser
	{
		[Token(Token = "0x6007A6A")]
		[Address(RVA = "0xC30320", Offset = "0xC2F720", VA = "0x180C30320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007A6B")]
		[Address(RVA = "0xC30270", Offset = "0xC2F670", VA = "0x180C30270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007A6C")]
		[Address(RVA = "0xC30370", Offset = "0xC2F770", VA = "0x180C30370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AF8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SeasonId
	{
		[Token(Token = "0x6007A70")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007A71")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001AF9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LeagueId
	{
		[Token(Token = "0x6007A72")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007A73")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001AFA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LadderPosition
	{
		[Token(Token = "0x6007A74")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007A75")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001AFB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool EndSeasonReward
	{
		[Token(Token = "0x6007A76")]
		[Address(RVA = "0xA7E460", Offset = "0xA7D860", VA = "0x180A7E460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007A77")]
		[Address(RVA = "0xA7E710", Offset = "0xA7DB10", VA = "0x180A7E710")]
		set
		{
		}
	}

	[Token(Token = "0x6007A6D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaLeagueRewardsEvent()
	{
	}

	[Token(Token = "0x6007A6E")]
	[Address(RVA = "0xA7E300", Offset = "0xA7D700", VA = "0x180A7E300")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaLeagueRewardsEvent(ArenaLeagueRewardsEvent other)
	{
	}

	[Token(Token = "0x6007A6F")]
	[Address(RVA = "0xC2FEF0", Offset = "0xC2F2F0", VA = "0x180C2FEF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaLeagueRewardsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007A78")]
	[Address(RVA = "0xC2FF80", Offset = "0xC2F380", VA = "0x180C2FF80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A79")]
	[Address(RVA = "0xA7DFE0", Offset = "0xA7D3E0", VA = "0x180A7DFE0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ArenaLeagueRewardsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A7A")]
	[Address(RVA = "0xC30020", Offset = "0xC2F420", VA = "0x180C30020", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007A7B")]
	[Address(RVA = "0xC30110", Offset = "0xC2F510", VA = "0x180C30110", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007A7C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007A7D")]
	[Address(RVA = "0xBB1760", Offset = "0xBB0B60", VA = "0x180BB1760", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007A7E")]
	[Address(RVA = "0xC2FE00", Offset = "0xC2F200", VA = "0x180C2FE00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007A7F")]
	[Address(RVA = "0xA7E130", Offset = "0xA7D530", VA = "0x180A7E130", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaLeagueRewardsEvent other)
	{
	}

	[Token(Token = "0x6007A80")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007A81")]
	[Address(RVA = "0xA7E470", Offset = "0xA7D870", VA = "0x180A7E470", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
