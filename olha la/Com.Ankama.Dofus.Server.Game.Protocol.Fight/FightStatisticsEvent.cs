using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005E7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightStatisticsEvent : IMessage<FightStatisticsEvent>, IMessage, IEquatable<FightStatisticsEvent>, IDeepCloneable<FightStatisticsEvent>, IBufferMessage
{
	[Token(Token = "0x40014A2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightStatisticsEvent> _parser;

	[Token(Token = "0x40014A3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014A4")]
	public const int DamageDoneFieldNumber = 1;

	[Token(Token = "0x40014A5")]
	[FieldOffset(Offset = "0x18")]
	private int damageDone_;

	[Token(Token = "0x40014A6")]
	public const int DamageTakenFieldNumber = 2;

	[Token(Token = "0x40014A7")]
	[FieldOffset(Offset = "0x1C")]
	private int damageTaken_;

	[Token(Token = "0x40014A8")]
	public const int BlockedDamageFieldNumber = 3;

	[Token(Token = "0x40014A9")]
	[FieldOffset(Offset = "0x20")]
	private int blockedDamage_;

	[Token(Token = "0x40014AA")]
	public const int AppliedShieldFieldNumber = 4;

	[Token(Token = "0x40014AB")]
	[FieldOffset(Offset = "0x24")]
	private int appliedShield_;

	[Token(Token = "0x40014AC")]
	public const int HealDoneFieldNumber = 5;

	[Token(Token = "0x40014AD")]
	[FieldOffset(Offset = "0x28")]
	private int healDone_;

	[Token(Token = "0x40014AE")]
	public const int HealTakenFieldNumber = 6;

	[Token(Token = "0x40014AF")]
	[FieldOffset(Offset = "0x2C")]
	private int healTaken_;

	[Token(Token = "0x40014B0")]
	public const int KillCountFieldNumber = 7;

	[Token(Token = "0x40014B1")]
	[FieldOffset(Offset = "0x30")]
	private int killCount_;

	[Token(Token = "0x17000D85")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightStatisticsEvent> Parser
	{
		[Token(Token = "0x6003EFD")]
		[Address(RVA = "0xA4B5C0", Offset = "0xA4A9C0", VA = "0x180A4B5C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D86")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0xA4B510", Offset = "0xA4A910", VA = "0x180A4B510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D87")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003EFF")]
		[Address(RVA = "0xA4B880", Offset = "0xA4AC80", VA = "0x180A4B880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D88")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DamageDone
	{
		[Token(Token = "0x6003F03")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F04")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000D89")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DamageTaken
	{
		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F06")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000D8A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BlockedDamage
	{
		[Token(Token = "0x6003F07")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000D8B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AppliedShield
	{
		[Token(Token = "0x6003F09")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F0A")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000D8C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HealDone
	{
		[Token(Token = "0x6003F0B")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F0C")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000D8D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HealTaken
	{
		[Token(Token = "0x6003F0D")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F0E")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17000D8E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int KillCount
	{
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x6003F00")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStatisticsEvent()
	{
	}

	[Token(Token = "0x6003F01")]
	[Address(RVA = "0xA4B4A0", Offset = "0xA4A8A0", VA = "0x180A4B4A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStatisticsEvent(FightStatisticsEvent other)
	{
	}

	[Token(Token = "0x6003F02")]
	[Address(RVA = "0xA4AFE0", Offset = "0xA4A3E0", VA = "0x180A4AFE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStatisticsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003F11")]
	[Address(RVA = "0xA4B080", Offset = "0xA4A480", VA = "0x180A4B080", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F12")]
	[Address(RVA = "0xA4B140", Offset = "0xA4A540", VA = "0x180A4B140", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightStatisticsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F13")]
	[Address(RVA = "0xA4B1A0", Offset = "0xA4A5A0", VA = "0x180A4B1A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003F14")]
	[Address(RVA = "0xA4B340", Offset = "0xA4A740", VA = "0x180A4B340", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003F15")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003F16")]
	[Address(RVA = "0xA4B760", Offset = "0xA4AB60", VA = "0x180A4B760", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003F17")]
	[Address(RVA = "0xA4AE50", Offset = "0xA4A250", VA = "0x180A4AE50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003F18")]
	[Address(RVA = "0xA4B2B0", Offset = "0xA4A6B0", VA = "0x180A4B2B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightStatisticsEvent other)
	{
	}

	[Token(Token = "0x6003F19")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003F1A")]
	[Address(RVA = "0xA4B610", Offset = "0xA4AA10", VA = "0x180A4B610", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
