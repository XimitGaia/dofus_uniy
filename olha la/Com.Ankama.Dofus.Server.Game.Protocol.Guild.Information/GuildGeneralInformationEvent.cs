using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004BA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildGeneralInformationEvent : IMessage<GuildGeneralInformationEvent>, IMessage, IEquatable<GuildGeneralInformationEvent>, IDeepCloneable<GuildGeneralInformationEvent>, IBufferMessage
{
	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildGeneralInformationEvent> _parser;

	[Token(Token = "0x4001025")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001026")]
	public const int AbandonedPaddockFieldNumber = 1;

	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x18")]
	private bool abandonedPaddock_;

	[Token(Token = "0x4001028")]
	public const int LevelFieldNumber = 2;

	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x1C")]
	private int level_;

	[Token(Token = "0x400102A")]
	public const int ExpLevelFloorFieldNumber = 3;

	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x20")]
	private long expLevelFloor_;

	[Token(Token = "0x400102C")]
	public const int ExperienceFieldNumber = 4;

	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x28")]
	private long experience_;

	[Token(Token = "0x400102E")]
	public const int ExpLevelNextFloorFieldNumber = 5;

	[Token(Token = "0x400102F")]
	[FieldOffset(Offset = "0x30")]
	private long expLevelNextFloor_;

	[Token(Token = "0x4001030")]
	public const int CreationDateFieldNumber = 6;

	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0x38")]
	private string creationDate_;

	[Token(Token = "0x4001032")]
	public const int MembersCountFieldNumber = 7;

	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x40")]
	private int membersCount_;

	[Token(Token = "0x4001034")]
	public const int ScoreFieldNumber = 8;

	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x44")]
	private int score_;

	[Token(Token = "0x17000A96")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildGeneralInformationEvent> Parser
	{
		[Token(Token = "0x60031D5")]
		[Address(RVA = "0x9F2C50", Offset = "0x9F2050", VA = "0x1809F2C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A97")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60031D6")]
		[Address(RVA = "0x9F2BA0", Offset = "0x9F1FA0", VA = "0x1809F2BA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A98")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60031D7")]
		[Address(RVA = "0x9F2FA0", Offset = "0x9F23A0", VA = "0x1809F2FA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A99")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AbandonedPaddock
	{
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level
	{
		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60031DE")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ExpLevelFloor
	{
		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Experience
	{
		[Token(Token = "0x60031E1")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ExpLevelNextFloor
	{
		[Token(Token = "0x60031E3")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CreationDate
	{
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031E6")]
		[Address(RVA = "0x9F3080", Offset = "0x9F2480", VA = "0x1809F3080")]
		set
		{
		}
	}

	[Token(Token = "0x17000A9F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MembersCount
	{
		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60031E8")]
		[Address(RVA = "0x9F30F0", Offset = "0x9F24F0", VA = "0x1809F30F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000AA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Score
	{
		[Token(Token = "0x60031E9")]
		[Address(RVA = "0x7D9DB0", Offset = "0x7D91B0", VA = "0x1807D9DB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60031EA")]
		[Address(RVA = "0x9F3100", Offset = "0x9F2500", VA = "0x1809F3100")]
		set
		{
		}
	}

	[Token(Token = "0x60031D8")]
	[Address(RVA = "0x9F2B50", Offset = "0x9F1F50", VA = "0x1809F2B50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildGeneralInformationEvent()
	{
	}

	[Token(Token = "0x60031D9")]
	[Address(RVA = "0x9F2A80", Offset = "0x9F1E80", VA = "0x1809F2A80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildGeneralInformationEvent(GuildGeneralInformationEvent other)
	{
	}

	[Token(Token = "0x60031DA")]
	[Address(RVA = "0x9F2450", Offset = "0x9F1850", VA = "0x1809F2450", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildGeneralInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60031EB")]
	[Address(RVA = "0x9F2600", Offset = "0x9F1A00", VA = "0x1809F2600", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60031EC")]
	[Address(RVA = "0x9F2550", Offset = "0x9F1950", VA = "0x1809F2550", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildGeneralInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60031ED")]
	[Address(RVA = "0x9F26F0", Offset = "0x9F1AF0", VA = "0x1809F26F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60031EE")]
	[Address(RVA = "0x9F2920", Offset = "0x9F1D20", VA = "0x1809F2920", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60031EF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60031F0")]
	[Address(RVA = "0x9F2E40", Offset = "0x9F2240", VA = "0x1809F2E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60031F1")]
	[Address(RVA = "0x9F22B0", Offset = "0x9F16B0", VA = "0x1809F22B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60031F2")]
	[Address(RVA = "0x9F2860", Offset = "0x9F1C60", VA = "0x1809F2860", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildGeneralInformationEvent other)
	{
	}

	[Token(Token = "0x60031F3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60031F4")]
	[Address(RVA = "0x9F2CA0", Offset = "0x9F20A0", VA = "0x1809F2CA0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
