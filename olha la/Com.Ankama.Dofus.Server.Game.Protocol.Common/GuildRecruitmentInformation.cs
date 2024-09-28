using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A82")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRecruitmentInformation : IMessage<GuildRecruitmentInformation>, IMessage, IEquatable<GuildRecruitmentInformation>, IDeepCloneable<GuildRecruitmentInformation>, IBufferMessage
{
	[Token(Token = "0x4002623")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRecruitmentInformation> _parser;

	[Token(Token = "0x4002624")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002625")]
	public const int SocialIdFieldNumber = 1;

	[Token(Token = "0x4002626")]
	[FieldOffset(Offset = "0x18")]
	private int socialId_;

	[Token(Token = "0x4002627")]
	public const int RecruitmentTypeFieldNumber = 2;

	[Token(Token = "0x4002628")]
	[FieldOffset(Offset = "0x1C")]
	private SocialRecruitmentType recruitmentType_;

	[Token(Token = "0x4002629")]
	public const int TitleFieldNumber = 3;

	[Token(Token = "0x400262A")]
	[FieldOffset(Offset = "0x20")]
	private string title_;

	[Token(Token = "0x400262B")]
	public const int TextFieldNumber = 4;

	[Token(Token = "0x400262C")]
	[FieldOffset(Offset = "0x28")]
	private string text_;

	[Token(Token = "0x400262D")]
	public const int SelectedLanguagesFieldNumber = 5;

	[Token(Token = "0x400262E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_selectedLanguages_codec;

	[Token(Token = "0x400262F")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<int> selectedLanguages_;

	[Token(Token = "0x4002630")]
	public const int SelectedCriterionFieldNumber = 6;

	[Token(Token = "0x4002631")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_selectedCriterion_codec;

	[Token(Token = "0x4002632")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<int> selectedCriterion_;

	[Token(Token = "0x4002633")]
	public const int MinLevelFieldNumber = 7;

	[Token(Token = "0x4002634")]
	[FieldOffset(Offset = "0x40")]
	private int minLevel_;

	[Token(Token = "0x4002635")]
	public const int MinLevelFacultativeFieldNumber = 8;

	[Token(Token = "0x4002636")]
	[FieldOffset(Offset = "0x44")]
	private bool minLevelFacultative_;

	[Token(Token = "0x4002637")]
	public const int InvalidatedByModerationFieldNumber = 9;

	[Token(Token = "0x4002638")]
	[FieldOffset(Offset = "0x45")]
	private bool invalidatedByModeration_;

	[Token(Token = "0x4002639")]
	public const int LastEditPlayerNameFieldNumber = 10;

	[Token(Token = "0x400263A")]
	[FieldOffset(Offset = "0x48")]
	private string lastEditPlayerName_;

	[Token(Token = "0x400263B")]
	public const int LastEditDateFieldNumber = 11;

	[Token(Token = "0x400263C")]
	[FieldOffset(Offset = "0x50")]
	private long lastEditDate_;

	[Token(Token = "0x400263D")]
	public const int AutoLockedFieldNumber = 12;

	[Token(Token = "0x400263E")]
	[FieldOffset(Offset = "0x58")]
	private bool autoLocked_;

	[Token(Token = "0x400263F")]
	public const int MinSuccessFieldNumber = 13;

	[Token(Token = "0x4002640")]
	[FieldOffset(Offset = "0x5C")]
	private int minSuccess_;

	[Token(Token = "0x4002641")]
	public const int MinSuccessFacultativeFieldNumber = 14;

	[Token(Token = "0x4002642")]
	[FieldOffset(Offset = "0x60")]
	private bool minSuccessFacultative_;

	[Token(Token = "0x170017DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRecruitmentInformation> Parser
	{
		[Token(Token = "0x6006DE8")]
		[Address(RVA = "0xBD4D70", Offset = "0xBD4170", VA = "0x180BD4D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006DE9")]
		[Address(RVA = "0xBD4CA0", Offset = "0xBD40A0", VA = "0x180BD4CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006DEA")]
		[Address(RVA = "0xBD53D0", Offset = "0xBD47D0", VA = "0x180BD53D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SocialId
	{
		[Token(Token = "0x6006DEE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006DEF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170017E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialRecruitmentType RecruitmentType
	{
		[Token(Token = "0x6006DF0")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(SocialRecruitmentType);
		}
		[Token(Token = "0x6006DF1")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170017E1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Title
	{
		[Token(Token = "0x6006DF2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DF3")]
		[Address(RVA = "0xBD55C0", Offset = "0xBD49C0", VA = "0x180BD55C0")]
		set
		{
		}
	}

	[Token(Token = "0x170017E2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Text
	{
		[Token(Token = "0x6006DF4")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DF5")]
		[Address(RVA = "0xBD5550", Offset = "0xBD4950", VA = "0x180BD5550")]
		set
		{
		}
	}

	[Token(Token = "0x170017E3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SelectedLanguages
	{
		[Token(Token = "0x6006DF6")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017E4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SelectedCriterion
	{
		[Token(Token = "0x6006DF7")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017E5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MinLevel
	{
		[Token(Token = "0x6006DF8")]
		[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006DF9")]
		[Address(RVA = "0x9F30F0", Offset = "0x9F24F0", VA = "0x1809F30F0")]
		set
		{
		}
	}

	[Token(Token = "0x170017E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool MinLevelFacultative
	{
		[Token(Token = "0x6006DFA")]
		[Address(RVA = "0xBD4D60", Offset = "0xBD4160", VA = "0x180BD4D60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006DFB")]
		[Address(RVA = "0xBD5540", Offset = "0xBD4940", VA = "0x180BD5540")]
		set
		{
		}
	}

	[Token(Token = "0x170017E7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool InvalidatedByModeration
	{
		[Token(Token = "0x6006DFC")]
		[Address(RVA = "0xBD4D50", Offset = "0xBD4150", VA = "0x180BD4D50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006DFD")]
		[Address(RVA = "0xBD54B0", Offset = "0xBD48B0", VA = "0x180BD54B0")]
		set
		{
		}
	}

	[Token(Token = "0x170017E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LastEditPlayerName
	{
		[Token(Token = "0x6006DFE")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DFF")]
		[Address(RVA = "0xBD54D0", Offset = "0xBD48D0", VA = "0x180BD54D0")]
		set
		{
		}
	}

	[Token(Token = "0x170017E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LastEditDate
	{
		[Token(Token = "0x6006E00")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006E01")]
		[Address(RVA = "0xBD54C0", Offset = "0xBD48C0", VA = "0x180BD54C0")]
		set
		{
		}
	}

	[Token(Token = "0x170017EA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool AutoLocked
	{
		[Token(Token = "0x6006E02")]
		[Address(RVA = "0x874E60", Offset = "0x874260", VA = "0x180874E60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006E03")]
		[Address(RVA = "0x874F50", Offset = "0x874350", VA = "0x180874F50")]
		set
		{
		}
	}

	[Token(Token = "0x170017EB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MinSuccess
	{
		[Token(Token = "0x6006E04")]
		[Address(RVA = "0x9DF0A0", Offset = "0x9DE4A0", VA = "0x1809DF0A0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006E05")]
		[Address(RVA = "0x9DF8D0", Offset = "0x9DECD0", VA = "0x1809DF8D0")]
		set
		{
		}
	}

	[Token(Token = "0x170017EC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool MinSuccessFacultative
	{
		[Token(Token = "0x6006E06")]
		[Address(RVA = "0xBC8620", Offset = "0xBC7A20", VA = "0x180BC8620")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006E07")]
		[Address(RVA = "0xBC8B40", Offset = "0xBC7F40", VA = "0x180BC8B40")]
		set
		{
		}
	}

	[Token(Token = "0x6006DEB")]
	[Address(RVA = "0xBD4BA0", Offset = "0xBD3FA0", VA = "0x180BD4BA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRecruitmentInformation()
	{
	}

	[Token(Token = "0x6006DEC")]
	[Address(RVA = "0xBD4A70", Offset = "0xBD3E70", VA = "0x180BD4A70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRecruitmentInformation(GuildRecruitmentInformation other)
	{
	}

	[Token(Token = "0x6006DED")]
	[Address(RVA = "0xBD4060", Offset = "0xBD3460", VA = "0x180BD4060", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRecruitmentInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006E08")]
	[Address(RVA = "0xBD41C0", Offset = "0xBD35C0", VA = "0x180BD41C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006E09")]
	[Address(RVA = "0xBD4370", Offset = "0xBD3770", VA = "0x180BD4370", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRecruitmentInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006E0A")]
	[Address(RVA = "0xBD44D0", Offset = "0xBD38D0", VA = "0x180BD44D0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006E0B")]
	[Address(RVA = "0xBD48B0", Offset = "0xBD3CB0", VA = "0x180BD48B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006E0C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006E0D")]
	[Address(RVA = "0xBD5130", Offset = "0xBD4530", VA = "0x180BD5130", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006E0E")]
	[Address(RVA = "0xBD3DD0", Offset = "0xBD31D0", VA = "0x180BD3DD0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006E0F")]
	[Address(RVA = "0xBD4750", Offset = "0xBD3B50", VA = "0x180BD4750", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildRecruitmentInformation other)
	{
	}

	[Token(Token = "0x6006E10")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006E11")]
	[Address(RVA = "0xBD4DC0", Offset = "0xBD41C0", VA = "0x180BD4DC0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
