using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005E3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightJoinRunningEvent : IMessage<FightJoinRunningEvent>, IMessage, IEquatable<FightJoinRunningEvent>, IDeepCloneable<FightJoinRunningEvent>, IBufferMessage
{
	[Token(Token = "0x400147D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightJoinRunningEvent> _parser;

	[Token(Token = "0x400147E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400147F")]
	public const int EffectsFieldNumber = 1;

	[Token(Token = "0x4001480")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FightRemovableEffectExtendedInformation> _repeated_effects_codec;

	[Token(Token = "0x4001481")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<FightRemovableEffectExtendedInformation> effects_;

	[Token(Token = "0x4001482")]
	public const int MarksFieldNumber = 2;

	[Token(Token = "0x4001483")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<FightMark> _repeated_marks_codec;

	[Token(Token = "0x4001484")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<FightMark> marks_;

	[Token(Token = "0x4001485")]
	public const int GameTurnFieldNumber = 3;

	[Token(Token = "0x4001486")]
	[FieldOffset(Offset = "0x28")]
	private int gameTurn_;

	[Token(Token = "0x4001487")]
	public const int FightStartFieldNumber = 4;

	[Token(Token = "0x4001488")]
	[FieldOffset(Offset = "0x2C")]
	private int fightStart_;

	[Token(Token = "0x4001489")]
	public const int FxTriggerCountsFieldNumber = 5;

	[Token(Token = "0x400148A")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<FightEffectTriggerCount> _repeated_fxTriggerCounts_codec;

	[Token(Token = "0x400148B")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<FightEffectTriggerCount> fxTriggerCounts_;

	[Token(Token = "0x400148C")]
	public const int ResumeFieldNumber = 6;

	[Token(Token = "0x400148D")]
	[FieldOffset(Offset = "0x38")]
	private FightResume resume_;

	[Token(Token = "0x17000D72")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightJoinRunningEvent> Parser
	{
		[Token(Token = "0x6003EC0")]
		[Address(RVA = "0xA3FDE0", Offset = "0xA3F1E0", VA = "0x180A3FDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D73")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003EC1")]
		[Address(RVA = "0xA3FD30", Offset = "0xA3F130", VA = "0x180A3FD30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D74")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003EC2")]
		[Address(RVA = "0xA40250", Offset = "0xA3F650", VA = "0x180A40250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D75")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FightRemovableEffectExtendedInformation> Effects
	{
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D76")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FightMark> Marks
	{
		[Token(Token = "0x6003EC7")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D77")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GameTurn
	{
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000D78")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightStart
	{
		[Token(Token = "0x6003ECA")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17000D79")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FightEffectTriggerCount> FxTriggerCounts
	{
		[Token(Token = "0x6003ECC")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D7A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightResume Resume
	{
		[Token(Token = "0x6003ECD")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003ECE")]
		[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
		set
		{
		}
	}

	[Token(Token = "0x6003EC3")]
	[Address(RVA = "0xA3FA20", Offset = "0xA3EE20", VA = "0x180A3FA20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightJoinRunningEvent()
	{
	}

	[Token(Token = "0x6003EC4")]
	[Address(RVA = "0xA3FB20", Offset = "0xA3EF20", VA = "0x180A3FB20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinRunningEvent(FightJoinRunningEvent other)
	{
	}

	[Token(Token = "0x6003EC5")]
	[Address(RVA = "0xA3F0D0", Offset = "0xA3E4D0", VA = "0x180A3F0D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinRunningEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003ECF")]
	[Address(RVA = "0xA3F130", Offset = "0xA3E530", VA = "0x180A3F130", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003ED0")]
	[Address(RVA = "0xA3F290", Offset = "0xA3E690", VA = "0x180A3F290", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightJoinRunningEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003ED1")]
	[Address(RVA = "0xA3F3B0", Offset = "0xA3E7B0", VA = "0x180A3F3B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003ED2")]
	[Address(RVA = "0xA3F6C0", Offset = "0xA3EAC0", VA = "0x180A3F6C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003ED3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003ED4")]
	[Address(RVA = "0xA400A0", Offset = "0xA3F4A0", VA = "0x180A400A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003ED5")]
	[Address(RVA = "0xA3EF10", Offset = "0xA3E310", VA = "0x180A3EF10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003ED6")]
	[Address(RVA = "0xA3F4C0", Offset = "0xA3E8C0", VA = "0x180A3F4C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightJoinRunningEvent other)
	{
	}

	[Token(Token = "0x6003ED7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003ED8")]
	[Address(RVA = "0xA3FE30", Offset = "0xA3F230", VA = "0x180A3FE30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
