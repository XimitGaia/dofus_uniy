using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x20004F4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationSubmitRequest : IMessage<GuildApplicationSubmitRequest>, IMessage, IEquatable<GuildApplicationSubmitRequest>, IDeepCloneable<GuildApplicationSubmitRequest>, IBufferMessage
{
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationSubmitRequest> _parser;

	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010D6")]
	public const int ApplyTextFieldNumber = 1;

	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x18")]
	private string applyText_;

	[Token(Token = "0x40010D8")]
	public const int GuildIdFieldNumber = 2;

	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x20")]
	private int guildId_;

	[Token(Token = "0x40010DA")]
	public const int TimeSpentFieldNumber = 3;

	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x24")]
	private int timeSpent_;

	[Token(Token = "0x40010DC")]
	public const int LanguageFilterFieldNumber = 4;

	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0x28")]
	private string languageFilter_;

	[Token(Token = "0x40010DE")]
	public const int AmbianceFilterFieldNumber = 5;

	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0x30")]
	private string ambianceFilter_;

	[Token(Token = "0x40010E0")]
	public const int PlayTimeFilterFieldNumber = 6;

	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0x38")]
	private string playTimeFilter_;

	[Token(Token = "0x40010E2")]
	public const int InterestFilterFieldNumber = 7;

	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0x40")]
	private string interestFilter_;

	[Token(Token = "0x40010E4")]
	public const int MinMaxGuildLevelFilterFieldNumber = 8;

	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0x48")]
	private string minMaxGuildLevelFilter_;

	[Token(Token = "0x40010E6")]
	public const int RecruitmentTypeFilterFieldNumber = 9;

	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x50")]
	private string recruitmentTypeFilter_;

	[Token(Token = "0x40010E8")]
	public const int MinMaxCharacterLevelFilterFieldNumber = 10;

	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x58")]
	private string minMaxCharacterLevelFilter_;

	[Token(Token = "0x40010EA")]
	public const int MinMaxAchievementFilterFieldNumber = 11;

	[Token(Token = "0x40010EB")]
	[FieldOffset(Offset = "0x60")]
	private string minMaxAchievementFilter_;

	[Token(Token = "0x40010EC")]
	public const int SearchNameFilterFieldNumber = 12;

	[Token(Token = "0x40010ED")]
	[FieldOffset(Offset = "0x68")]
	private string searchNameFilter_;

	[Token(Token = "0x40010EE")]
	public const int LastSortFilterFieldNumber = 13;

	[Token(Token = "0x40010EF")]
	[FieldOffset(Offset = "0x70")]
	private string lastSortFilter_;

	[Token(Token = "0x17000B15")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildApplicationSubmitRequest> Parser
	{
		[Token(Token = "0x6003447")]
		[Address(RVA = "0x9E7CC0", Offset = "0x9E70C0", VA = "0x1809E7CC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B16")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003448")]
		[Address(RVA = "0x9E7C10", Offset = "0x9E7010", VA = "0x1809E7C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B17")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003449")]
		[Address(RVA = "0x9E82F0", Offset = "0x9E76F0", VA = "0x1809E82F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B18")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string ApplyText
	{
		[Token(Token = "0x600344D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600344E")]
		[Address(RVA = "0x9E8440", Offset = "0x9E7840", VA = "0x1809E8440")]
		set
		{
		}
	}

	[Token(Token = "0x17000B19")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildId
	{
		[Token(Token = "0x600344F")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003450")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TimeSpent
	{
		[Token(Token = "0x6003451")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003452")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LanguageFilter
	{
		[Token(Token = "0x6003453")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003454")]
		[Address(RVA = "0x9E8520", Offset = "0x9E7920", VA = "0x1809E8520")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AmbianceFilter
	{
		[Token(Token = "0x6003455")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003456")]
		[Address(RVA = "0x9E83D0", Offset = "0x9E77D0", VA = "0x1809E83D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PlayTimeFilter
	{
		[Token(Token = "0x6003457")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003458")]
		[Address(RVA = "0x9E8750", Offset = "0x9E7B50", VA = "0x1809E8750")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string InterestFilter
	{
		[Token(Token = "0x6003459")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600345A")]
		[Address(RVA = "0x9E84B0", Offset = "0x9E78B0", VA = "0x1809E84B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MinMaxGuildLevelFilter
	{
		[Token(Token = "0x600345B")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x600345C")]
		[Address(RVA = "0x9E86E0", Offset = "0x9E7AE0", VA = "0x1809E86E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RecruitmentTypeFilter
	{
		[Token(Token = "0x600345D")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600345E")]
		[Address(RVA = "0x9E87C0", Offset = "0x9E7BC0", VA = "0x1809E87C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B21")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MinMaxCharacterLevelFilter
	{
		[Token(Token = "0x600345F")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003460")]
		[Address(RVA = "0x9E8670", Offset = "0x9E7A70", VA = "0x1809E8670")]
		set
		{
		}
	}

	[Token(Token = "0x17000B22")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MinMaxAchievementFilter
	{
		[Token(Token = "0x6003461")]
		[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x9E8600", Offset = "0x9E7A00", VA = "0x1809E8600")]
		set
		{
		}
	}

	[Token(Token = "0x17000B23")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SearchNameFilter
	{
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x8E5D30", Offset = "0x8E5130", VA = "0x1808E5D30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003464")]
		[Address(RVA = "0x9E8830", Offset = "0x9E7C30", VA = "0x1809E8830")]
		set
		{
		}
	}

	[Token(Token = "0x17000B24")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LastSortFilter
	{
		[Token(Token = "0x6003465")]
		[Address(RVA = "0x9C6060", Offset = "0x9C5460", VA = "0x1809C6060")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003466")]
		[Address(RVA = "0x9E8590", Offset = "0x9E7990", VA = "0x1809E8590")]
		set
		{
		}
	}

	[Token(Token = "0x600344A")]
	[Address(RVA = "0x9E7AB0", Offset = "0x9E6EB0", VA = "0x1809E7AB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationSubmitRequest()
	{
	}

	[Token(Token = "0x600344B")]
	[Address(RVA = "0x9E79A0", Offset = "0x9E6DA0", VA = "0x1809E79A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationSubmitRequest(GuildApplicationSubmitRequest other)
	{
	}

	[Token(Token = "0x600344C")]
	[Address(RVA = "0x9E7150", Offset = "0x9E6550", VA = "0x1809E7150", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationSubmitRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003467")]
	[Address(RVA = "0x9E7290", Offset = "0x9E6690", VA = "0x1809E7290", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003468")]
	[Address(RVA = "0x9E72F0", Offset = "0x9E66F0", VA = "0x1809E72F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationSubmitRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003469")]
	[Address(RVA = "0x9E7460", Offset = "0x9E6860", VA = "0x1809E7460", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600346A")]
	[Address(RVA = "0x9E7840", Offset = "0x9E6C40", VA = "0x1809E7840", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600346B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600346C")]
	[Address(RVA = "0x9E8070", Offset = "0x9E7470", VA = "0x1809E8070", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600346D")]
	[Address(RVA = "0x9E6E50", Offset = "0x9E6250", VA = "0x1809E6E50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600346E")]
	[Address(RVA = "0x9E76A0", Offset = "0x9E6AA0", VA = "0x1809E76A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationSubmitRequest other)
	{
	}

	[Token(Token = "0x600346F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003470")]
	[Address(RVA = "0x9E7D10", Offset = "0x9E7110", VA = "0x1809E7D10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
