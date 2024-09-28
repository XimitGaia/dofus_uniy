using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005E5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightEndEvent : IMessage<FightEndEvent>, IMessage, IEquatable<FightEndEvent>, IDeepCloneable<FightEndEvent>, IBufferMessage
{
	[Token(Token = "0x400148F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightEndEvent> _parser;

	[Token(Token = "0x4001490")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001491")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4001492")]
	public const int DurationFieldNumber = 1;

	[Token(Token = "0x4001493")]
	[FieldOffset(Offset = "0x1C")]
	private int duration_;

	[Token(Token = "0x4001494")]
	public const int RewardRateFieldNumber = 2;

	[Token(Token = "0x4001495")]
	[FieldOffset(Offset = "0x20")]
	private int rewardRate_;

	[Token(Token = "0x4001496")]
	public const int LootShareLimitMalusFieldNumber = 3;

	[Token(Token = "0x4001497")]
	[FieldOffset(Offset = "0x24")]
	private int lootShareLimitMalus_;

	[Token(Token = "0x4001498")]
	public const int ResultsFieldNumber = 4;

	[Token(Token = "0x4001499")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FightResultListEntry> _repeated_results_codec;

	[Token(Token = "0x400149A")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<FightResultListEntry> results_;

	[Token(Token = "0x400149B")]
	public const int NamedPartyTeamsOutcomesFieldNumber = 5;

	[Token(Token = "0x400149C")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<NamedPartyTeamWithOutcome> _repeated_namedPartyTeamsOutcomes_codec;

	[Token(Token = "0x400149D")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<NamedPartyTeamWithOutcome> namedPartyTeamsOutcomes_;

	[Token(Token = "0x400149E")]
	public const int BudgetFieldNumber = 6;

	[Token(Token = "0x400149F")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int BudgetDefaultValue;

	[Token(Token = "0x40014A0")]
	[FieldOffset(Offset = "0x38")]
	private int budget_;

	[Token(Token = "0x17000D7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightEndEvent> Parser
	{
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0xA3D560", Offset = "0xA3C960", VA = "0x180A3D560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0xA3D4B0", Offset = "0xA3C8B0", VA = "0x180A3D4B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0xA3D960", Offset = "0xA3CD60", VA = "0x180A3D960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Duration
	{
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000D7F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardRate
	{
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000D80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LootShareLimitMalus
	{
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000D81")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FightResultListEntry> Results
	{
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D82")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<NamedPartyTeamWithOutcome> NamedPartyTeamsOutcomes
	{
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D83")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Budget
	{
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0xA3D440", Offset = "0xA3C840", VA = "0x180A3D440")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0xA3DA40", Offset = "0xA3CE40", VA = "0x180A3DA40")]
		set
		{
		}
	}

	[Token(Token = "0x17000D84")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasBudget
	{
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003EE0")]
	[Address(RVA = "0xA3D2A0", Offset = "0xA3C6A0", VA = "0x180A3D2A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightEndEvent()
	{
	}

	[Token(Token = "0x6003EE1")]
	[Address(RVA = "0xA3D360", Offset = "0xA3C760", VA = "0x180A3D360")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightEndEvent(FightEndEvent other)
	{
	}

	[Token(Token = "0x6003EE2")]
	[Address(RVA = "0xA3CA30", Offset = "0xA3BE30", VA = "0x180A3CA30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightEndEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003EEE")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearBudget()
	{
	}

	[Token(Token = "0x6003EEF")]
	[Address(RVA = "0xA3CC50", Offset = "0xA3C050", VA = "0x180A3CC50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003EF0")]
	[Address(RVA = "0xA3CB40", Offset = "0xA3BF40", VA = "0x180A3CB40", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightEndEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003EF1")]
	[Address(RVA = "0xA3CDA0", Offset = "0xA3C1A0", VA = "0x180A3CDA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003EF2")]
	[Address(RVA = "0xA3CFE0", Offset = "0xA3C3E0", VA = "0x180A3CFE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003EF3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003EF4")]
	[Address(RVA = "0xA3D7A0", Offset = "0xA3CBA0", VA = "0x180A3D7A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003EF5")]
	[Address(RVA = "0xA3C840", Offset = "0xA3BC40", VA = "0x180A3C840", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003EF6")]
	[Address(RVA = "0xA3CF00", Offset = "0xA3C300", VA = "0x180A3CF00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightEndEvent other)
	{
	}

	[Token(Token = "0x6003EF7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003EF8")]
	[Address(RVA = "0xA3D5B0", Offset = "0xA3C9B0", VA = "0x180A3D5B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
