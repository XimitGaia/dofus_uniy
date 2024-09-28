using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CB9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceSummaryRequest : IMessage<AllianceSummaryRequest>, IMessage, IEquatable<AllianceSummaryRequest>, IDeepCloneable<AllianceSummaryRequest>, IBufferMessage
{
	[Token(Token = "0x2000CBA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000CBB")]
		public enum DirectoryTextFilter
		{
			[Token(Token = "0x4002EED")]
			[OriginalName("ALLIANCE_SEARCH_DEFAULT_FILTER")]
			AllianceSearchDefaultFilter,
			[Token(Token = "0x4002EEE")]
			[OriginalName("ALLIANCE_SEARCH_NAME_FILTER")]
			AllianceSearchNameFilter,
			[Token(Token = "0x4002EEF")]
			[OriginalName("ALLIANCE_SEARCH_TAG_FILTER")]
			AllianceSearchTagFilter
		}

		[Token(Token = "0x2000CBC")]
		public enum AllianceSummarySort
		{
			[Token(Token = "0x4002EF1")]
			[OriginalName("SORT_BY_ALLIANCE_NAME")]
			SortByAllianceName,
			[Token(Token = "0x4002EF2")]
			[OriginalName("SORT_BY_ALLIANCE_TAG")]
			SortByAllianceTag,
			[Token(Token = "0x4002EF3")]
			[OriginalName("SORT_BY_NB_TERRITORIES")]
			SortByNbTerritories,
			[Token(Token = "0x4002EF4")]
			[OriginalName("SORT_BY_ALLIANCE_NB_MEMBERS")]
			SortByAllianceNbMembers
		}
	}

	[Token(Token = "0x4002ECD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceSummaryRequest> _parser;

	[Token(Token = "0x4002ECE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002ECF")]
	public const int OffsetFieldNumber = 1;

	[Token(Token = "0x4002ED0")]
	[FieldOffset(Offset = "0x18")]
	private long offset_;

	[Token(Token = "0x4002ED1")]
	public const int CountFieldNumber = 2;

	[Token(Token = "0x4002ED2")]
	[FieldOffset(Offset = "0x20")]
	private long count_;

	[Token(Token = "0x4002ED3")]
	public const int FilterTypeFieldNumber = 3;

	[Token(Token = "0x4002ED4")]
	[FieldOffset(Offset = "0x28")]
	private Types.DirectoryTextFilter filterType_;

	[Token(Token = "0x4002ED5")]
	public const int TextFilerFieldNumber = 4;

	[Token(Token = "0x4002ED6")]
	[FieldOffset(Offset = "0x30")]
	private string textFiler_;

	[Token(Token = "0x4002ED7")]
	public const int HideFullFilterFieldNumber = 5;

	[Token(Token = "0x4002ED8")]
	[FieldOffset(Offset = "0x38")]
	private bool hideFullFilter_;

	[Token(Token = "0x4002ED9")]
	public const int FollowingAllianceCriteriaFieldNumber = 6;

	[Token(Token = "0x4002EDA")]
	[FieldOffset(Offset = "0x39")]
	private bool followingAllianceCriteria_;

	[Token(Token = "0x4002EDB")]
	public const int CriterionFilterFieldNumber = 7;

	[Token(Token = "0x4002EDC")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_criterionFilter_codec;

	[Token(Token = "0x4002EDD")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<int> criterionFilter_;

	[Token(Token = "0x4002EDE")]
	public const int SortTypeFieldNumber = 8;

	[Token(Token = "0x4002EDF")]
	[FieldOffset(Offset = "0x48")]
	private Types.AllianceSummarySort sortType_;

	[Token(Token = "0x4002EE0")]
	public const int SortDescendingFieldNumber = 9;

	[Token(Token = "0x4002EE1")]
	[FieldOffset(Offset = "0x4C")]
	private bool sortDescending_;

	[Token(Token = "0x4002EE2")]
	public const int LanguagesFilterFieldNumber = 10;

	[Token(Token = "0x4002EE3")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_languagesFilter_codec;

	[Token(Token = "0x4002EE4")]
	[FieldOffset(Offset = "0x50")]
	private readonly RepeatedField<int> languagesFilter_;

	[Token(Token = "0x4002EE5")]
	public const int RecruitmentTypeFilterFieldNumber = 11;

	[Token(Token = "0x4002EE6")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<SocialRecruitmentType> _repeated_recruitmentTypeFilter_codec;

	[Token(Token = "0x4002EE7")]
	[FieldOffset(Offset = "0x58")]
	private readonly RepeatedField<SocialRecruitmentType> recruitmentTypeFilter_;

	[Token(Token = "0x4002EE8")]
	public const int MinPlayerLevelFilterFieldNumber = 12;

	[Token(Token = "0x4002EE9")]
	[FieldOffset(Offset = "0x60")]
	private int minPlayerLevelFilter_;

	[Token(Token = "0x4002EEA")]
	public const int MaxPlayerLevelFilterFieldNumber = 13;

	[Token(Token = "0x4002EEB")]
	[FieldOffset(Offset = "0x64")]
	private int maxPlayerLevelFilter_;

	[Token(Token = "0x17001D4C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceSummaryRequest> Parser
	{
		[Token(Token = "0x6008609")]
		[Address(RVA = "0xC9DC40", Offset = "0xC9D040", VA = "0x180C9DC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D4D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600860A")]
		[Address(RVA = "0xC9DB80", Offset = "0xC9CF80", VA = "0x180C9DB80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D4E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600860B")]
		[Address(RVA = "0xC9E2A0", Offset = "0xC9D6A0", VA = "0x180C9E2A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D4F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Offset
	{
		[Token(Token = "0x600860F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008610")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001D50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Count
	{
		[Token(Token = "0x6008611")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008612")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D51")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.DirectoryTextFilter FilterType
	{
		[Token(Token = "0x6008613")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(Types.DirectoryTextFilter);
		}
		[Token(Token = "0x6008614")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001D52")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TextFiler
	{
		[Token(Token = "0x6008615")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008616")]
		[Address(RVA = "0xC9E390", Offset = "0xC9D790", VA = "0x180C9E390")]
		set
		{
		}
	}

	[Token(Token = "0x17001D53")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HideFullFilter
	{
		[Token(Token = "0x6008617")]
		[Address(RVA = "0x9C5FF0", Offset = "0x9C53F0", VA = "0x1809C5FF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008618")]
		[Address(RVA = "0x9C6730", Offset = "0x9C5B30", VA = "0x1809C6730")]
		set
		{
		}
	}

	[Token(Token = "0x17001D54")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool FollowingAllianceCriteria
	{
		[Token(Token = "0x6008619")]
		[Address(RVA = "0xC9DC30", Offset = "0xC9D030", VA = "0x180C9DC30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600861A")]
		[Address(RVA = "0xC9E380", Offset = "0xC9D780", VA = "0x180C9E380")]
		set
		{
		}
	}

	[Token(Token = "0x17001D55")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CriterionFilter
	{
		[Token(Token = "0x600861B")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D56")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.AllianceSummarySort SortType
	{
		[Token(Token = "0x600861C")]
		[Address(RVA = "0x7D9E50", Offset = "0x7D9250", VA = "0x1807D9E50")]
		get
		{
			return default(Types.AllianceSummarySort);
		}
		[Token(Token = "0x600861D")]
		[Address(RVA = "0xBA6350", Offset = "0xBA5750", VA = "0x180BA6350")]
		set
		{
		}
	}

	[Token(Token = "0x17001D57")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool SortDescending
	{
		[Token(Token = "0x600861E")]
		[Address(RVA = "0xBEFF00", Offset = "0xBEF300", VA = "0x180BEFF00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600861F")]
		[Address(RVA = "0xBF0680", Offset = "0xBEFA80", VA = "0x180BF0680")]
		set
		{
		}
	}

	[Token(Token = "0x17001D58")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> LanguagesFilter
	{
		[Token(Token = "0x6008620")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D59")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<SocialRecruitmentType> RecruitmentTypeFilter
	{
		[Token(Token = "0x6008621")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D5A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MinPlayerLevelFilter
	{
		[Token(Token = "0x6008622")]
		[Address(RVA = "0x9DF0C0", Offset = "0x9DE4C0", VA = "0x1809DF0C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008623")]
		[Address(RVA = "0x9DF8F0", Offset = "0x9DECF0", VA = "0x1809DF8F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D5B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxPlayerLevelFilter
	{
		[Token(Token = "0x6008624")]
		[Address(RVA = "0x9DF0B0", Offset = "0x9DE4B0", VA = "0x1809DF0B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008625")]
		[Address(RVA = "0x9DF8E0", Offset = "0x9DECE0", VA = "0x1809DF8E0")]
		set
		{
		}
	}

	[Token(Token = "0x600860C")]
	[Address(RVA = "0xC9DA70", Offset = "0xC9CE70", VA = "0x180C9DA70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceSummaryRequest()
	{
	}

	[Token(Token = "0x600860D")]
	[Address(RVA = "0xC9D930", Offset = "0xC9CD30", VA = "0x180C9D930")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceSummaryRequest(AllianceSummaryRequest other)
	{
	}

	[Token(Token = "0x600860E")]
	[Address(RVA = "0xC9CE70", Offset = "0xC9C270", VA = "0x180C9CE70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceSummaryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008626")]
	[Address(RVA = "0xC9D130", Offset = "0xC9C530", VA = "0x180C9D130", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008627")]
	[Address(RVA = "0xC9CFD0", Offset = "0xC9C3D0", VA = "0x180C9CFD0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceSummaryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008628")]
	[Address(RVA = "0xC9D2E0", Offset = "0xC9C6E0", VA = "0x180C9D2E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008629")]
	[Address(RVA = "0xC9D670", Offset = "0xC9CA70", VA = "0x180C9D670", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600862A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600862B")]
	[Address(RVA = "0xC9E000", Offset = "0xC9D400", VA = "0x180C9E000", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600862C")]
	[Address(RVA = "0xC9CBD0", Offset = "0xC9BFD0", VA = "0x180C9CBD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600862D")]
	[Address(RVA = "0xC9D520", Offset = "0xC9C920", VA = "0x180C9D520", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceSummaryRequest other)
	{
	}

	[Token(Token = "0x600862E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600862F")]
	[Address(RVA = "0xC9DC90", Offset = "0xC9D090", VA = "0x180C9DC90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
