using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A20")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamInformation : IMessage<FightTeamInformation>, IMessage, IEquatable<FightTeamInformation>, IDeepCloneable<FightTeamInformation>, IBufferMessage
{
	[Token(Token = "0x2000A21")]
	public enum TeamInformationOneofCase
	{
		[Token(Token = "0x4002467")]
		None = 0,
		[Token(Token = "0x4002468")]
		TeamMembers = 6,
		[Token(Token = "0x4002469")]
		LightInformation = 7
	}

	[Token(Token = "0x4002456")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamInformation> _parser;

	[Token(Token = "0x4002457")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002458")]
	public const int TeamFieldNumber = 1;

	[Token(Token = "0x4002459")]
	[FieldOffset(Offset = "0x18")]
	private Team team_;

	[Token(Token = "0x400245A")]
	public const int LeaderIdFieldNumber = 2;

	[Token(Token = "0x400245B")]
	[FieldOffset(Offset = "0x20")]
	private long leaderId_;

	[Token(Token = "0x400245C")]
	public const int SideFieldNumber = 3;

	[Token(Token = "0x400245D")]
	[FieldOffset(Offset = "0x28")]
	private Alignment side_;

	[Token(Token = "0x400245E")]
	public const int TypeFieldNumber = 4;

	[Token(Token = "0x400245F")]
	[FieldOffset(Offset = "0x2C")]
	private TeamType type_;

	[Token(Token = "0x4002460")]
	public const int WavesFieldNumber = 5;

	[Token(Token = "0x4002461")]
	[FieldOffset(Offset = "0x30")]
	private int waves_;

	[Token(Token = "0x4002462")]
	public const int TeamMembersFieldNumber = 6;

	[Token(Token = "0x4002463")]
	public const int LightInformationFieldNumber = 7;

	[Token(Token = "0x4002464")]
	[FieldOffset(Offset = "0x38")]
	private object teamInformation_;

	[Token(Token = "0x4002465")]
	[FieldOffset(Offset = "0x40")]
	private TeamInformationOneofCase teamInformationCase_;

	[Token(Token = "0x170016CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTeamInformation> Parser
	{
		[Token(Token = "0x60069BB")]
		[Address(RVA = "0xBBAC60", Offset = "0xBBA060", VA = "0x180BBAC60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60069BC")]
		[Address(RVA = "0xBBAB50", Offset = "0xBB9F50", VA = "0x180BBAB50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016CD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60069BD")]
		[Address(RVA = "0xBBB110", Offset = "0xBBA510", VA = "0x180BBB110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016CE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Team Team
	{
		[Token(Token = "0x60069C1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x60069C2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170016CF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long LeaderId
	{
		[Token(Token = "0x60069C3")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60069C4")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170016D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Alignment Side
	{
		[Token(Token = "0x60069C5")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(Alignment);
		}
		[Token(Token = "0x60069C6")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170016D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeamType Type
	{
		[Token(Token = "0x60069C7")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(TeamType);
		}
		[Token(Token = "0x60069C8")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x170016D2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Waves
	{
		[Token(Token = "0x60069C9")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60069CA")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x170016D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamMembersInformation TeamMembers
	{
		[Token(Token = "0x60069CB")]
		[Address(RVA = "0xBBACB0", Offset = "0xBBA0B0", VA = "0x180BBACB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60069CC")]
		[Address(RVA = "0x95FFD0", Offset = "0x95F3D0", VA = "0x18095FFD0")]
		set
		{
		}
	}

	[Token(Token = "0x170016D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamLightInformation LightInformation
	{
		[Token(Token = "0x60069CD")]
		[Address(RVA = "0xBBAC00", Offset = "0xBBA000", VA = "0x180BBAC00")]
		get
		{
			return null;
		}
		[Token(Token = "0x60069CE")]
		[Address(RVA = "0xB7AE40", Offset = "0xB7A240", VA = "0x180B7AE40")]
		set
		{
		}
	}

	[Token(Token = "0x170016D5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeamInformationOneofCase TeamInformationCase
	{
		[Token(Token = "0x60069CF")]
		[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
		get
		{
			return default(TeamInformationOneofCase);
		}
	}

	[Token(Token = "0x60069BE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamInformation()
	{
	}

	[Token(Token = "0x60069BF")]
	[Address(RVA = "0xBBA8B0", Offset = "0xBB9CB0", VA = "0x180BBA8B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamInformation(FightTeamInformation other)
	{
	}

	[Token(Token = "0x60069C0")]
	[Address(RVA = "0xBBA070", Offset = "0xBB9470", VA = "0x180BBA070", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60069D0")]
	[Address(RVA = "0x95F130", Offset = "0x95E530", VA = "0x18095F130")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearTeamInformation()
	{
	}

	[Token(Token = "0x60069D1")]
	[Address(RVA = "0xBBA1D0", Offset = "0xBB95D0", VA = "0x180BBA1D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60069D2")]
	[Address(RVA = "0xBBA0D0", Offset = "0xBB94D0", VA = "0x180BBA0D0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTeamInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60069D3")]
	[Address(RVA = "0xBBA310", Offset = "0xBB9710", VA = "0x180BBA310", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60069D4")]
	[Address(RVA = "0xBBA750", Offset = "0xBB9B50", VA = "0x180BBA750", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60069D5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60069D6")]
	[Address(RVA = "0xBBAF50", Offset = "0xBBA350", VA = "0x180BBAF50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60069D7")]
	[Address(RVA = "0xBB9E60", Offset = "0xBB9260", VA = "0x180BB9E60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60069D8")]
	[Address(RVA = "0xBBA4C0", Offset = "0xBB98C0", VA = "0x180BBA4C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTeamInformation other)
	{
	}

	[Token(Token = "0x60069D9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60069DA")]
	[Address(RVA = "0xBBAD10", Offset = "0xBBA110", VA = "0x180BBAD10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
