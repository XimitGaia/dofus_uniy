using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A3E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightRemovableEffect : IMessage<FightRemovableEffect>, IMessage, IEquatable<FightRemovableEffect>, IDeepCloneable<FightRemovableEffect>, IBufferMessage
{
	[Token(Token = "0x2000A3F")]
	public enum EffectOneofCase
	{
		[Token(Token = "0x40024FF")]
		None = 0,
		[Token(Token = "0x4002500")]
		TemporaryBoostEffect = 8,
		[Token(Token = "0x4002501")]
		TemporarySpellImmunityEffect = 9,
		[Token(Token = "0x4002502")]
		TriggeredEffect = 10
	}

	[Token(Token = "0x2000A40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000A41")]
		public enum EffectDissipationState
		{
			[Token(Token = "0x4002504")]
			[OriginalName("DISSIPATED")]
			Dissipated,
			[Token(Token = "0x4002505")]
			[OriginalName("DISSIPATED_BY_DEATH")]
			DissipatedByDeath,
			[Token(Token = "0x4002506")]
			[OriginalName("DISSIPATED_BY_STRONG_DISPEL")]
			DissipatedByStrongDispel,
			[Token(Token = "0x4002507")]
			[OriginalName("REALLY_NOT_DISSIPATED")]
			ReallyNotDissipated
		}
	}

	[Token(Token = "0x40024E9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightRemovableEffect> _parser;

	[Token(Token = "0x40024EA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40024EB")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x40024EC")]
	[FieldOffset(Offset = "0x18")]
	private int uid_;

	[Token(Token = "0x40024ED")]
	public const int TargetIdFieldNumber = 2;

	[Token(Token = "0x40024EE")]
	[FieldOffset(Offset = "0x20")]
	private long targetId_;

	[Token(Token = "0x40024EF")]
	public const int TurnDurationFieldNumber = 3;

	[Token(Token = "0x40024F0")]
	[FieldOffset(Offset = "0x28")]
	private int turnDuration_;

	[Token(Token = "0x40024F1")]
	public const int DissipationStateFieldNumber = 4;

	[Token(Token = "0x40024F2")]
	[FieldOffset(Offset = "0x2C")]
	private Types.EffectDissipationState dissipationState_;

	[Token(Token = "0x40024F3")]
	public const int SpellIdFieldNumber = 5;

	[Token(Token = "0x40024F4")]
	[FieldOffset(Offset = "0x30")]
	private int spellId_;

	[Token(Token = "0x40024F5")]
	public const int EffectIdFieldNumber = 6;

	[Token(Token = "0x40024F6")]
	[FieldOffset(Offset = "0x34")]
	private int effectId_;

	[Token(Token = "0x40024F7")]
	public const int ParentBoostIdFieldNumber = 7;

	[Token(Token = "0x40024F8")]
	[FieldOffset(Offset = "0x38")]
	private int parentBoostId_;

	[Token(Token = "0x40024F9")]
	public const int TemporaryBoostEffectFieldNumber = 8;

	[Token(Token = "0x40024FA")]
	public const int TemporarySpellImmunityEffectFieldNumber = 9;

	[Token(Token = "0x40024FB")]
	public const int TriggeredEffectFieldNumber = 10;

	[Token(Token = "0x40024FC")]
	[FieldOffset(Offset = "0x40")]
	private object effect_;

	[Token(Token = "0x40024FD")]
	[FieldOffset(Offset = "0x48")]
	private EffectOneofCase effectCase_;

	[Token(Token = "0x17001724")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightRemovableEffect> Parser
	{
		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0xBB8AA0", Offset = "0xBB7EA0", VA = "0x180BB8AA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001725")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006B20")]
		[Address(RVA = "0xBB89F0", Offset = "0xBB7DF0", VA = "0x180BB89F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001726")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006B21")]
		[Address(RVA = "0xBB9180", Offset = "0xBB8580", VA = "0x180BB9180", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001727")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Uid
	{
		[Token(Token = "0x6006B25")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B26")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001728")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TargetId
	{
		[Token(Token = "0x6006B27")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006B28")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001729")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TurnDuration
	{
		[Token(Token = "0x6006B29")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B2A")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x1700172A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.EffectDissipationState DissipationState
	{
		[Token(Token = "0x6006B2B")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(Types.EffectDissipationState);
		}
		[Token(Token = "0x6006B2C")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x1700172B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x6006B2D")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B2E")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x1700172C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EffectId
	{
		[Token(Token = "0x6006B2F")]
		[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B30")]
		[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
		set
		{
		}
	}

	[Token(Token = "0x1700172D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ParentBoostId
	{
		[Token(Token = "0x6006B31")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B32")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x1700172E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTemporaryBoostEffect TemporaryBoostEffect
	{
		[Token(Token = "0x6006B33")]
		[Address(RVA = "0xBB8AF0", Offset = "0xBB7EF0", VA = "0x180BB8AF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006B34")]
		[Address(RVA = "0xBB9260", Offset = "0xBB8660", VA = "0x180BB9260")]
		set
		{
		}
	}

	[Token(Token = "0x1700172F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTemporarySpellImmunityEffect TemporarySpellImmunityEffect
	{
		[Token(Token = "0x6006B35")]
		[Address(RVA = "0xBB8B50", Offset = "0xBB7F50", VA = "0x180BB8B50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006B36")]
		[Address(RVA = "0xBB92A0", Offset = "0xBB86A0", VA = "0x180BB92A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001730")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTriggeredEffect TriggeredEffect
	{
		[Token(Token = "0x6006B37")]
		[Address(RVA = "0xBB8BB0", Offset = "0xBB7FB0", VA = "0x180BB8BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006B38")]
		[Address(RVA = "0xBB92E0", Offset = "0xBB86E0", VA = "0x180BB92E0")]
		set
		{
		}
	}

	[Token(Token = "0x17001731")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EffectOneofCase EffectCase
	{
		[Token(Token = "0x6006B39")]
		[Address(RVA = "0x7D9E50", Offset = "0x7D9250", VA = "0x1807D9E50")]
		get
		{
			return default(EffectOneofCase);
		}
	}

	[Token(Token = "0x6006B22")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightRemovableEffect()
	{
	}

	[Token(Token = "0x6006B23")]
	[Address(RVA = "0xBB8670", Offset = "0xBB7A70", VA = "0x180BB8670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightRemovableEffect(FightRemovableEffect other)
	{
	}

	[Token(Token = "0x6006B24")]
	[Address(RVA = "0xBB7D50", Offset = "0xBB7150", VA = "0x180BB7D50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightRemovableEffect Clone()
	{
		return null;
	}

	[Token(Token = "0x6006B3A")]
	[Address(RVA = "0xBB7D30", Offset = "0xBB7130", VA = "0x180BB7D30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearEffect()
	{
	}

	[Token(Token = "0x6006B3B")]
	[Address(RVA = "0xBB7DB0", Offset = "0xBB71B0", VA = "0x180BB7DB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B3C")]
	[Address(RVA = "0xBB7F30", Offset = "0xBB7330", VA = "0x180BB7F30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightRemovableEffect other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B3D")]
	[Address(RVA = "0xBB8080", Offset = "0xBB7480", VA = "0x180BB8080", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006B3E")]
	[Address(RVA = "0xBB8510", Offset = "0xBB7910", VA = "0x180BB8510", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006B3F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006B40")]
	[Address(RVA = "0xBB8F10", Offset = "0xBB8310", VA = "0x180BB8F10", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006B41")]
	[Address(RVA = "0xBB7A60", Offset = "0xBB6E60", VA = "0x180BB7A60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006B42")]
	[Address(RVA = "0xBB82D0", Offset = "0xBB76D0", VA = "0x180BB82D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightRemovableEffect other)
	{
	}

	[Token(Token = "0x6006B43")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006B44")]
	[Address(RVA = "0xBB8C10", Offset = "0xBB8010", VA = "0x180BB8C10", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
