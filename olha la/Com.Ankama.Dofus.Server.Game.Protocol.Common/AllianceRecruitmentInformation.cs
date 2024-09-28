using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B00")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRecruitmentInformation : IMessage<AllianceRecruitmentInformation>, IMessage, IEquatable<AllianceRecruitmentInformation>, IDeepCloneable<AllianceRecruitmentInformation>, IBufferMessage
{
	[Token(Token = "0x4002897")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRecruitmentInformation> _parser;

	[Token(Token = "0x4002898")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002899")]
	public const int SocialUidFieldNumber = 1;

	[Token(Token = "0x400289A")]
	[FieldOffset(Offset = "0x18")]
	private string socialUid_;

	[Token(Token = "0x400289B")]
	public const int RecruitmentTypeFieldNumber = 2;

	[Token(Token = "0x400289C")]
	[FieldOffset(Offset = "0x20")]
	private SocialRecruitmentType recruitmentType_;

	[Token(Token = "0x400289D")]
	public const int TitleFieldNumber = 3;

	[Token(Token = "0x400289E")]
	[FieldOffset(Offset = "0x28")]
	private string title_;

	[Token(Token = "0x400289F")]
	public const int TextFieldNumber = 4;

	[Token(Token = "0x40028A0")]
	[FieldOffset(Offset = "0x30")]
	private string text_;

	[Token(Token = "0x40028A1")]
	public const int SelectedLanguagesFieldNumber = 5;

	[Token(Token = "0x40028A2")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_selectedLanguages_codec;

	[Token(Token = "0x40028A3")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<int> selectedLanguages_;

	[Token(Token = "0x40028A4")]
	public const int SelectedCriterionFieldNumber = 6;

	[Token(Token = "0x40028A5")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_selectedCriterion_codec;

	[Token(Token = "0x40028A6")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<int> selectedCriterion_;

	[Token(Token = "0x40028A7")]
	public const int MinLevelFieldNumber = 7;

	[Token(Token = "0x40028A8")]
	[FieldOffset(Offset = "0x48")]
	private int minLevel_;

	[Token(Token = "0x40028A9")]
	public const int MinLevelFacultativeFieldNumber = 8;

	[Token(Token = "0x40028AA")]
	[FieldOffset(Offset = "0x4C")]
	private bool minLevelFacultative_;

	[Token(Token = "0x40028AB")]
	public const int InvalidatedByModerationFieldNumber = 9;

	[Token(Token = "0x40028AC")]
	[FieldOffset(Offset = "0x4D")]
	private bool invalidatedByModeration_;

	[Token(Token = "0x40028AD")]
	public const int LastEditPlayerNameFieldNumber = 10;

	[Token(Token = "0x40028AE")]
	[FieldOffset(Offset = "0x50")]
	private string lastEditPlayerName_;

	[Token(Token = "0x40028AF")]
	public const int LastEditDateFieldNumber = 11;

	[Token(Token = "0x40028B0")]
	[FieldOffset(Offset = "0x58")]
	private long lastEditDate_;

	[Token(Token = "0x40028B1")]
	public const int AutoLockedFieldNumber = 12;

	[Token(Token = "0x40028B2")]
	[FieldOffset(Offset = "0x60")]
	private bool autoLocked_;

	[Token(Token = "0x17001949")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRecruitmentInformation> Parser
	{
		[Token(Token = "0x600736E")]
		[Address(RVA = "0xBEFF10", Offset = "0xBEF310", VA = "0x180BEFF10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700194A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600736F")]
		[Address(RVA = "0xBEFE40", Offset = "0xBEF240", VA = "0x180BEFE40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700194B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007370")]
		[Address(RVA = "0xBF0520", Offset = "0xBEF920", VA = "0x180BF0520", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700194C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string SocialUid
	{
		[Token(Token = "0x6007374")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007375")]
		[Address(RVA = "0xBF0690", Offset = "0xBEFA90", VA = "0x180BF0690")]
		set
		{
		}
	}

	[Token(Token = "0x1700194D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialRecruitmentType RecruitmentType
	{
		[Token(Token = "0x6007376")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(SocialRecruitmentType);
		}
		[Token(Token = "0x6007377")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700194E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Title
	{
		[Token(Token = "0x6007378")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007379")]
		[Address(RVA = "0xBF0770", Offset = "0xBEFB70", VA = "0x180BF0770")]
		set
		{
		}
	}

	[Token(Token = "0x1700194F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Text
	{
		[Token(Token = "0x600737A")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600737B")]
		[Address(RVA = "0xBF0700", Offset = "0xBEFB00", VA = "0x180BF0700")]
		set
		{
		}
	}

	[Token(Token = "0x17001950")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SelectedLanguages
	{
		[Token(Token = "0x600737C")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001951")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SelectedCriterion
	{
		[Token(Token = "0x600737D")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001952")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MinLevel
	{
		[Token(Token = "0x600737E")]
		[Address(RVA = "0x7D9E50", Offset = "0x7D9250", VA = "0x1807D9E50")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600737F")]
		[Address(RVA = "0xBA6350", Offset = "0xBA5750", VA = "0x180BA6350")]
		set
		{
		}
	}

	[Token(Token = "0x17001953")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool MinLevelFacultative
	{
		[Token(Token = "0x6007380")]
		[Address(RVA = "0xBEFF00", Offset = "0xBEF300", VA = "0x180BEFF00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007381")]
		[Address(RVA = "0xBF0680", Offset = "0xBEFA80", VA = "0x180BF0680")]
		set
		{
		}
	}

	[Token(Token = "0x17001954")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool InvalidatedByModeration
	{
		[Token(Token = "0x6007382")]
		[Address(RVA = "0xBEFEF0", Offset = "0xBEF2F0", VA = "0x180BEFEF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007383")]
		[Address(RVA = "0xBF0600", Offset = "0xBEFA00", VA = "0x180BF0600")]
		set
		{
		}
	}

	[Token(Token = "0x17001955")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LastEditPlayerName
	{
		[Token(Token = "0x6007384")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007385")]
		[Address(RVA = "0xBF0610", Offset = "0xBEFA10", VA = "0x180BF0610")]
		set
		{
		}
	}

	[Token(Token = "0x17001956")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long LastEditDate
	{
		[Token(Token = "0x6007386")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007387")]
		[Address(RVA = "0xBC8B10", Offset = "0xBC7F10", VA = "0x180BC8B10")]
		set
		{
		}
	}

	[Token(Token = "0x17001957")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool AutoLocked
	{
		[Token(Token = "0x6007388")]
		[Address(RVA = "0xBC8620", Offset = "0xBC7A20", VA = "0x180BC8620")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007389")]
		[Address(RVA = "0xBC8B40", Offset = "0xBC7F40", VA = "0x180BC8B40")]
		set
		{
		}
	}

	[Token(Token = "0x6007371")]
	[Address(RVA = "0xBEFC00", Offset = "0xBEF000", VA = "0x180BEFC00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInformation()
	{
	}

	[Token(Token = "0x6007372")]
	[Address(RVA = "0xBEFD20", Offset = "0xBEF120", VA = "0x180BEFD20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInformation(AllianceRecruitmentInformation other)
	{
	}

	[Token(Token = "0x6007373")]
	[Address(RVA = "0xBEF250", Offset = "0xBEE650", VA = "0x180BEF250", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600738A")]
	[Address(RVA = "0xBEF500", Offset = "0xBEE900", VA = "0x180BEF500", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600738B")]
	[Address(RVA = "0xBEF3A0", Offset = "0xBEE7A0", VA = "0x180BEF3A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRecruitmentInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600738C")]
	[Address(RVA = "0xBEF6A0", Offset = "0xBEEAA0", VA = "0x180BEF6A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600738D")]
	[Address(RVA = "0xBEFA40", Offset = "0xBEEE40", VA = "0x180BEFA40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600738E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600738F")]
	[Address(RVA = "0xBF02B0", Offset = "0xBEF6B0", VA = "0x180BF02B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007390")]
	[Address(RVA = "0xBEEFF0", Offset = "0xBEE3F0", VA = "0x180BEEFF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007391")]
	[Address(RVA = "0xBEF8E0", Offset = "0xBEECE0", VA = "0x180BEF8E0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceRecruitmentInformation other)
	{
	}

	[Token(Token = "0x6007392")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007393")]
	[Address(RVA = "0xBEFF60", Offset = "0xBEF360", VA = "0x180BEFF60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
