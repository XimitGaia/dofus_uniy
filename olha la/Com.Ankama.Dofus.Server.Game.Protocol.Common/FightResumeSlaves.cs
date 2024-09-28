using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A59")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightResumeSlaves : IMessage<FightResumeSlaves>, IMessage, IEquatable<FightResumeSlaves>, IDeepCloneable<FightResumeSlaves>, IBufferMessage
{
	[Token(Token = "0x400256E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightResumeSlaves> _parser;

	[Token(Token = "0x400256F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002570")]
	public const int SlaveIdFieldNumber = 1;

	[Token(Token = "0x4002571")]
	[FieldOffset(Offset = "0x18")]
	private long slaveId_;

	[Token(Token = "0x4002572")]
	public const int SpellCoolDownsFieldNumber = 2;

	[Token(Token = "0x4002573")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FightSpellCoolDown> _repeated_spellCoolDowns_codec;

	[Token(Token = "0x4002574")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<FightSpellCoolDown> spellCoolDowns_;

	[Token(Token = "0x4002575")]
	public const int SummonCountFieldNumber = 3;

	[Token(Token = "0x4002576")]
	[FieldOffset(Offset = "0x28")]
	private int summonCount_;

	[Token(Token = "0x4002577")]
	public const int BombCountFieldNumber = 4;

	[Token(Token = "0x4002578")]
	[FieldOffset(Offset = "0x2C")]
	private int bombCount_;

	[Token(Token = "0x1700176D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightResumeSlaves> Parser
	{
		[Token(Token = "0x6006C2E")]
		[Address(RVA = "0xBCDCC0", Offset = "0xBCD0C0", VA = "0x180BCDCC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006C2F")]
		[Address(RVA = "0xBCDC10", Offset = "0xBCD010", VA = "0x180BCDC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006C30")]
		[Address(RVA = "0xBCDFA0", Offset = "0xBCD3A0", VA = "0x180BCDFA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001770")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SlaveId
	{
		[Token(Token = "0x6006C34")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006C35")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001771")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FightSpellCoolDown> SpellCoolDowns
	{
		[Token(Token = "0x6006C36")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001772")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SummonCount
	{
		[Token(Token = "0x6006C37")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006C38")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001773")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BombCount
	{
		[Token(Token = "0x6006C39")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006C3A")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x6006C31")]
	[Address(RVA = "0xBCDAF0", Offset = "0xBCCEF0", VA = "0x180BCDAF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightResumeSlaves()
	{
	}

	[Token(Token = "0x6006C32")]
	[Address(RVA = "0xBCDB70", Offset = "0xBCCF70", VA = "0x180BCDB70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightResumeSlaves(FightResumeSlaves other)
	{
	}

	[Token(Token = "0x6006C33")]
	[Address(RVA = "0xBCD520", Offset = "0xBCC920", VA = "0x180BCD520", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightResumeSlaves Clone()
	{
		return null;
	}

	[Token(Token = "0x6006C3B")]
	[Address(RVA = "0xBCD6A0", Offset = "0xBCCAA0", VA = "0x180BCD6A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C3C")]
	[Address(RVA = "0xBCD5F0", Offset = "0xBCC9F0", VA = "0x180BCD5F0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightResumeSlaves other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C3D")]
	[Address(RVA = "0xBCD790", Offset = "0xBCCB90", VA = "0x180BCD790", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006C3E")]
	[Address(RVA = "0xBCD8F0", Offset = "0xBCCCF0", VA = "0x180BCD8F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006C3F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006C40")]
	[Address(RVA = "0xBCDE80", Offset = "0xBCD280", VA = "0x180BCDE80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006C41")]
	[Address(RVA = "0xBCD3E0", Offset = "0xBCC7E0", VA = "0x180BCD3E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006C42")]
	[Address(RVA = "0xBCD850", Offset = "0xBCCC50", VA = "0x180BCD850", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightResumeSlaves other)
	{
	}

	[Token(Token = "0x6006C43")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006C44")]
	[Address(RVA = "0xBCDD10", Offset = "0xBCD110", VA = "0x180BCDD10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
