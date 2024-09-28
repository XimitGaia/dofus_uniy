using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x2000486")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildSummaryRequest : IMessage<GuildSummaryRequest>, IMessage, IEquatable<GuildSummaryRequest>, IDeepCloneable<GuildSummaryRequest>, IBufferMessage
{
	[Token(Token = "0x2000487")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000488")]
		public enum SummarySort
		{
			[Token(Token = "0x4000F8F")]
			[OriginalName("SORT_BY_NAME")]
			SortByName,
			[Token(Token = "0x4000F90")]
			[OriginalName("SORT_BY_LEVEL")]
			SortByLevel,
			[Token(Token = "0x4000F91")]
			[OriginalName("SORT_BY_NB_MEMBERS")]
			SortByNbMembers,
			[Token(Token = "0x4000F92")]
			[OriginalName("SORT_BY_LAST_ACTIVITY")]
			SortByLastActivity
		}
	}

	[Token(Token = "0x4000F69")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildSummaryRequest> _parser;

	[Token(Token = "0x4000F6A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F6B")]
	public const int OffsetFieldNumber = 1;

	[Token(Token = "0x4000F6C")]
	[FieldOffset(Offset = "0x18")]
	private long offset_;

	[Token(Token = "0x4000F6D")]
	public const int CountFieldNumber = 2;

	[Token(Token = "0x4000F6E")]
	[FieldOffset(Offset = "0x20")]
	private int count_;

	[Token(Token = "0x4000F6F")]
	public const int NameFilterFieldNumber = 3;

	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x28")]
	private string nameFilter_;

	[Token(Token = "0x4000F71")]
	public const int HideFullFilterFieldNumber = 4;

	[Token(Token = "0x4000F72")]
	[FieldOffset(Offset = "0x30")]
	private bool hideFullFilter_;

	[Token(Token = "0x4000F73")]
	public const int FollowingGuildCriteriaFieldNumber = 5;

	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x31")]
	private bool followingGuildCriteria_;

	[Token(Token = "0x4000F75")]
	public const int CriterionFilterFieldNumber = 6;

	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_criterionFilter_codec;

	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<int> criterionFilter_;

	[Token(Token = "0x4000F78")]
	public const int LanguagesFilterFieldNumber = 7;

	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_languagesFilter_codec;

	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<int> languagesFilter_;

	[Token(Token = "0x4000F7B")]
	public const int RecruitmentTypeFiltersFieldNumber = 8;

	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<SocialRecruitmentType> _repeated_recruitmentTypeFilters_codec;

	[Token(Token = "0x4000F7D")]
	[FieldOffset(Offset = "0x48")]
	private readonly RepeatedField<SocialRecruitmentType> recruitmentTypeFilters_;

	[Token(Token = "0x4000F7E")]
	public const int MinLevelFilterFieldNumber = 9;

	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x50")]
	private int minLevelFilter_;

	[Token(Token = "0x4000F80")]
	public const int MaxLevelFilterFieldNumber = 10;

	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0x54")]
	private int maxLevelFilter_;

	[Token(Token = "0x4000F82")]
	public const int MinPlayerLevelFilterFieldNumber = 11;

	[Token(Token = "0x4000F83")]
	[FieldOffset(Offset = "0x58")]
	private int minPlayerLevelFilter_;

	[Token(Token = "0x4000F84")]
	public const int MaxPlayerLevelFilterFieldNumber = 12;

	[Token(Token = "0x4000F85")]
	[FieldOffset(Offset = "0x5C")]
	private int maxPlayerLevelFilter_;

	[Token(Token = "0x4000F86")]
	public const int MinSuccessFilterFieldNumber = 13;

	[Token(Token = "0x4000F87")]
	[FieldOffset(Offset = "0x60")]
	private int minSuccessFilter_;

	[Token(Token = "0x4000F88")]
	public const int MaxSuccessFilterFieldNumber = 14;

	[Token(Token = "0x4000F89")]
	[FieldOffset(Offset = "0x64")]
	private int maxSuccessFilter_;

	[Token(Token = "0x4000F8A")]
	public const int SortTypeFieldNumber = 15;

	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0x68")]
	private Types.SummarySort sortType_;

	[Token(Token = "0x4000F8C")]
	public const int SortDescendingFieldNumber = 16;

	[Token(Token = "0x4000F8D")]
	[FieldOffset(Offset = "0x6C")]
	private bool sortDescending_;

	[Token(Token = "0x17000A1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildSummaryRequest> Parser
	{
		[Token(Token = "0x6002F99")]
		[Address(RVA = "0x9DF0D0", Offset = "0x9DE4D0", VA = "0x1809DF0D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002F9A")]
		[Address(RVA = "0x9DEFD0", Offset = "0x9DE3D0", VA = "0x1809DEFD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002F9B")]
		[Address(RVA = "0x9DF7D0", Offset = "0x9DEBD0", VA = "0x1809DF7D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A21")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Offset
	{
		[Token(Token = "0x6002F9F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002FA0")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000A22")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Count
	{
		[Token(Token = "0x6002FA1")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002FA2")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000A23")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string NameFilter
	{
		[Token(Token = "0x6002FA3")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FA4")]
		[Address(RVA = "0x9DF900", Offset = "0x9DED00", VA = "0x1809DF900")]
		set
		{
		}
	}

	[Token(Token = "0x17000A24")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HideFullFilter
	{
		[Token(Token = "0x6002FA5")]
		[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002FA6")]
		[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A25")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FollowingGuildCriteria
	{
		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0x9DF080", Offset = "0x9DE480", VA = "0x1809DF080")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x9DF8B0", Offset = "0x9DECB0", VA = "0x1809DF8B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A26")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> CriterionFilter
	{
		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A27")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> LanguagesFilter
	{
		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A28")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SocialRecruitmentType> RecruitmentTypeFilters
	{
		[Token(Token = "0x6002FAB")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A29")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MinLevelFilter
	{
		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x874EA0", Offset = "0x8742A0", VA = "0x180874EA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002FAD")]
		[Address(RVA = "0x874F70", Offset = "0x874370", VA = "0x180874F70")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxLevelFilter
	{
		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0x873250", Offset = "0x872650", VA = "0x180873250")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002FAF")]
		[Address(RVA = "0x8732B0", Offset = "0x8726B0", VA = "0x1808732B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MinPlayerLevelFilter
	{
		[Token(Token = "0x6002FB0")]
		[Address(RVA = "0x9C5F60", Offset = "0x9C5360", VA = "0x1809C5F60")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002FB1")]
		[Address(RVA = "0x9C6720", Offset = "0x9C5B20", VA = "0x1809C6720")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxPlayerLevelFilter
	{
		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0x9DF0A0", Offset = "0x9DE4A0", VA = "0x1809DF0A0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0x9DF8D0", Offset = "0x9DECD0", VA = "0x1809DF8D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MinSuccessFilter
	{
		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0x9DF0C0", Offset = "0x9DE4C0", VA = "0x1809DF0C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x9DF8F0", Offset = "0x9DECF0", VA = "0x1809DF8F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxSuccessFilter
	{
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x9DF0B0", Offset = "0x9DE4B0", VA = "0x1809DF0B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x9DF8E0", Offset = "0x9DECE0", VA = "0x1809DF8E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.SummarySort SortType
	{
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x878BB0", Offset = "0x877FB0", VA = "0x180878BB0")]
		get
		{
			return default(Types.SummarySort);
		}
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x878BE0", Offset = "0x877FE0", VA = "0x180878BE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool SortDescending
	{
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x9DF120", Offset = "0x9DE520", VA = "0x1809DF120")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x9DF970", Offset = "0x9DED70", VA = "0x1809DF970")]
		set
		{
		}
	}

	[Token(Token = "0x6002F9C")]
	[Address(RVA = "0x9DEEC0", Offset = "0x9DE2C0", VA = "0x1809DEEC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSummaryRequest()
	{
	}

	[Token(Token = "0x6002F9D")]
	[Address(RVA = "0x9DED70", Offset = "0x9DE170", VA = "0x1809DED70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSummaryRequest(GuildSummaryRequest other)
	{
	}

	[Token(Token = "0x6002F9E")]
	[Address(RVA = "0x9DE1F0", Offset = "0x9DD5F0", VA = "0x1809DE1F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSummaryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x9DE370", Offset = "0x9DD770", VA = "0x1809DE370", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x9DE540", Offset = "0x9DD940", VA = "0x1809DE540", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildSummaryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FBE")]
	[Address(RVA = "0x9DE6C0", Offset = "0x9DDAC0", VA = "0x1809DE6C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002FBF")]
	[Address(RVA = "0x9DEAB0", Offset = "0x9DDEB0", VA = "0x1809DEAB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002FC1")]
	[Address(RVA = "0x9DF4F0", Offset = "0x9DE8F0", VA = "0x1809DF4F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x9DDF00", Offset = "0x9DD300", VA = "0x1809DDF00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002FC3")]
	[Address(RVA = "0x9DE940", Offset = "0x9DDD40", VA = "0x1809DE940", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildSummaryRequest other)
	{
	}

	[Token(Token = "0x6002FC4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002FC5")]
	[Address(RVA = "0x9DF130", Offset = "0x9DE530", VA = "0x1809DF130", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
