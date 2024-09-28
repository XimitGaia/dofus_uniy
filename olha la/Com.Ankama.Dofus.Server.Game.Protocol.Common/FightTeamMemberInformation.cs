using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A2C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamMemberInformation : IMessage<FightTeamMemberInformation>, IMessage, IEquatable<FightTeamMemberInformation>, IDeepCloneable<FightTeamMemberInformation>, IBufferMessage
{
	[Token(Token = "0x2000A2D")]
	public enum InformationOneofCase
	{
		[Token(Token = "0x40024A6")]
		None = 0,
		[Token(Token = "0x40024A7")]
		CharacterMember = 2,
		[Token(Token = "0x40024A8")]
		EntityMember = 3,
		[Token(Token = "0x40024A9")]
		MonsterMember = 4,
		[Token(Token = "0x40024AA")]
		TaxCollectorMember = 5
	}

	[Token(Token = "0x400249B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamMemberInformation> _parser;

	[Token(Token = "0x400249C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400249D")]
	public const int MemberIdFieldNumber = 1;

	[Token(Token = "0x400249E")]
	[FieldOffset(Offset = "0x18")]
	private long memberId_;

	[Token(Token = "0x400249F")]
	public const int CharacterMemberFieldNumber = 2;

	[Token(Token = "0x40024A0")]
	public const int EntityMemberFieldNumber = 3;

	[Token(Token = "0x40024A1")]
	public const int MonsterMemberFieldNumber = 4;

	[Token(Token = "0x40024A2")]
	public const int TaxCollectorMemberFieldNumber = 5;

	[Token(Token = "0x40024A3")]
	[FieldOffset(Offset = "0x20")]
	private object information_;

	[Token(Token = "0x40024A4")]
	[FieldOffset(Offset = "0x28")]
	private InformationOneofCase informationCase_;

	[Token(Token = "0x170016F3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTeamMemberInformation> Parser
	{
		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0xBBE1F0", Offset = "0xBBD5F0", VA = "0x180BBE1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016F4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006A50")]
		[Address(RVA = "0xBBE080", Offset = "0xBBD480", VA = "0x180BBE080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016F5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006A51")]
		[Address(RVA = "0xBBE7F0", Offset = "0xBBDBF0", VA = "0x180BBE7F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MemberId
	{
		[Token(Token = "0x6006A55")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006A56")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170016F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMemberCharacter CharacterMember
	{
		[Token(Token = "0x6006A57")]
		[Address(RVA = "0xBBE020", Offset = "0xBBD420", VA = "0x180BBE020")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A58")]
		[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
		set
		{
		}
	}

	[Token(Token = "0x170016F8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberEntity EntityMember
	{
		[Token(Token = "0x6006A59")]
		[Address(RVA = "0xBBE130", Offset = "0xBBD530", VA = "0x180BBE130")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A5A")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x170016F9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberMonster MonsterMember
	{
		[Token(Token = "0x6006A5B")]
		[Address(RVA = "0xBBE190", Offset = "0xBBD590", VA = "0x180BBE190")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
		set
		{
		}
	}

	[Token(Token = "0x170016FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberTaxCollector TaxCollectorMember
	{
		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0xBBE240", Offset = "0xBBD640", VA = "0x180BBE240")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0x9264D0", Offset = "0x9258D0", VA = "0x1809264D0")]
		set
		{
		}
	}

	[Token(Token = "0x170016FB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InformationOneofCase InformationCase
	{
		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(InformationOneofCase);
		}
	}

	[Token(Token = "0x6006A52")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMemberInformation()
	{
	}

	[Token(Token = "0x6006A53")]
	[Address(RVA = "0xBBDBD0", Offset = "0xBBCFD0", VA = "0x180BBDBD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMemberInformation(FightTeamMemberInformation other)
	{
	}

	[Token(Token = "0x6006A54")]
	[Address(RVA = "0xBBD240", Offset = "0xBBC640", VA = "0x180BBD240", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamMemberInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006A60")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearInformation()
	{
	}

	[Token(Token = "0x6006A61")]
	[Address(RVA = "0xBBD3D0", Offset = "0xBBC7D0", VA = "0x180BBD3D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A62")]
	[Address(RVA = "0xBBD2A0", Offset = "0xBBC6A0", VA = "0x180BBD2A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTeamMemberInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A63")]
	[Address(RVA = "0xBBD540", Offset = "0xBBC940", VA = "0x180BBD540", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006A64")]
	[Address(RVA = "0xBBDA70", Offset = "0xBBCE70", VA = "0x180BBDA70", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006A65")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006A66")]
	[Address(RVA = "0xBBE5E0", Offset = "0xBBD9E0", VA = "0x180BBE5E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006A67")]
	[Address(RVA = "0xBBCFF0", Offset = "0xBBC3F0", VA = "0x180BBCFF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006A68")]
	[Address(RVA = "0xBBD770", Offset = "0xBBCB70", VA = "0x180BBD770", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightTeamMemberInformation other)
	{
	}

	[Token(Token = "0x6006A69")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006A6A")]
	[Address(RVA = "0xBBE2A0", Offset = "0xBBD6A0", VA = "0x180BBE2A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
