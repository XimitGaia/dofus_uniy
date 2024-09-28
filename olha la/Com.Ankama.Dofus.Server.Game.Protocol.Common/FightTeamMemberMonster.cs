using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A36")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamMemberMonster : IMessage<FightTeamMemberMonster>, IMessage, IEquatable<FightTeamMemberMonster>, IDeepCloneable<FightTeamMemberMonster>, IBufferMessage
{
	[Token(Token = "0x40024C5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamMemberMonster> _parser;

	[Token(Token = "0x40024C6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40024C7")]
	public const int MonsterIdFieldNumber = 1;

	[Token(Token = "0x40024C8")]
	[FieldOffset(Offset = "0x18")]
	private int monsterId_;

	[Token(Token = "0x40024C9")]
	public const int GradeFieldNumber = 2;

	[Token(Token = "0x40024CA")]
	[FieldOffset(Offset = "0x1C")]
	private int grade_;

	[Token(Token = "0x1700170D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightTeamMemberMonster> Parser
	{
		[Token(Token = "0x6006ABB")]
		[Address(RVA = "0xBBECC0", Offset = "0xBBE0C0", VA = "0x180BBECC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700170E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006ABC")]
		[Address(RVA = "0xBBEC10", Offset = "0xBBE010", VA = "0x180BBEC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700170F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006ABD")]
		[Address(RVA = "0xBBED10", Offset = "0xBBE110", VA = "0x180BBED10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001710")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MonsterId
	{
		[Token(Token = "0x6006AC1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006AC2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001711")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Grade
	{
		[Token(Token = "0x6006AC3")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006AC4")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6006ABE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberMonster()
	{
	}

	[Token(Token = "0x6006ABF")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberMonster(FightTeamMemberMonster other)
	{
	}

	[Token(Token = "0x6006AC0")]
	[Address(RVA = "0xBBE990", Offset = "0xBBDD90", VA = "0x180BBE990", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberMonster Clone()
	{
		return null;
	}

	[Token(Token = "0x6006AC5")]
	[Address(RVA = "0xBBEA20", Offset = "0xBBDE20", VA = "0x180BBEA20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AC6")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTeamMemberMonster other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AC7")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006AC8")]
	[Address(RVA = "0xBBEAB0", Offset = "0xBBDEB0", VA = "0x180BBEAB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006AC9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006ACA")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006ACB")]
	[Address(RVA = "0xBBE8D0", Offset = "0xBBDCD0", VA = "0x180BBE8D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006ACC")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTeamMemberMonster other)
	{
	}

	[Token(Token = "0x6006ACD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006ACE")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
