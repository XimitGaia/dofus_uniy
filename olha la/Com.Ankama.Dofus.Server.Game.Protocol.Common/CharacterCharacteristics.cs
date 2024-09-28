using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009EF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCharacteristics : IMessage<CharacterCharacteristics>, IMessage, IEquatable<CharacterCharacteristics>, IDeepCloneable<CharacterCharacteristics>, IBufferMessage
{
	[Token(Token = "0x4002350")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCharacteristics> _parser;

	[Token(Token = "0x4002351")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002352")]
	public const int ExperienceFieldNumber = 1;

	[Token(Token = "0x4002353")]
	[FieldOffset(Offset = "0x18")]
	private long experience_;

	[Token(Token = "0x4002354")]
	public const int ExperienceLevelFloorFieldNumber = 2;

	[Token(Token = "0x4002355")]
	[FieldOffset(Offset = "0x20")]
	private long experienceLevelFloor_;

	[Token(Token = "0x4002356")]
	public const int ExperienceNextLevelFloorFieldNumber = 3;

	[Token(Token = "0x4002357")]
	[FieldOffset(Offset = "0x28")]
	private long experienceNextLevelFloor_;

	[Token(Token = "0x4002358")]
	public const int ExperienceBonusLimitFieldNumber = 4;

	[Token(Token = "0x4002359")]
	[FieldOffset(Offset = "0x30")]
	private long experienceBonusLimit_;

	[Token(Token = "0x400235A")]
	public const int KamasFieldNumber = 5;

	[Token(Token = "0x400235B")]
	[FieldOffset(Offset = "0x38")]
	private long kamas_;

	[Token(Token = "0x400235C")]
	public const int AlignmentInformationFieldNumber = 6;

	[Token(Token = "0x400235D")]
	[FieldOffset(Offset = "0x40")]
	private AlignmentInformation alignmentInformation_;

	[Token(Token = "0x400235E")]
	public const int CriticalHitWeaponFieldNumber = 7;

	[Token(Token = "0x400235F")]
	[FieldOffset(Offset = "0x48")]
	private int criticalHitWeapon_;

	[Token(Token = "0x4002360")]
	public const int CharacteristicsFieldNumber = 8;

	[Token(Token = "0x4002361")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<CharacterCharacteristic> _repeated_characteristics_codec;

	[Token(Token = "0x4002362")]
	[FieldOffset(Offset = "0x50")]
	private readonly RepeatedField<CharacterCharacteristic> characteristics_;

	[Token(Token = "0x4002363")]
	public const int SpellModifiersFieldNumber = 9;

	[Token(Token = "0x4002364")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<SpellModifier> _repeated_spellModifiers_codec;

	[Token(Token = "0x4002365")]
	[FieldOffset(Offset = "0x58")]
	private readonly RepeatedField<SpellModifier> spellModifiers_;

	[Token(Token = "0x4002366")]
	public const int ProbationTimeFieldNumber = 10;

	[Token(Token = "0x4002367")]
	[FieldOffset(Offset = "0x60")]
	private long probationTime_;

	[Token(Token = "0x17001638")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterCharacteristics> Parser
	{
		[Token(Token = "0x600678A")]
		[Address(RVA = "0xBA5D60", Offset = "0xBA5160", VA = "0x180BA5D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001639")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600678B")]
		[Address(RVA = "0xBA5CB0", Offset = "0xBA50B0", VA = "0x180BA5CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700163A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600678C")]
		[Address(RVA = "0xBA6270", Offset = "0xBA5670", VA = "0x180BA6270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700163B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Experience
	{
		[Token(Token = "0x6006790")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006791")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700163C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ExperienceLevelFloor
	{
		[Token(Token = "0x6006792")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006793")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700163D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ExperienceNextLevelFloor
	{
		[Token(Token = "0x6006794")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006795")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x1700163E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ExperienceBonusLimit
	{
		[Token(Token = "0x6006796")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006797")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700163F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Kamas
	{
		[Token(Token = "0x6006798")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006799")]
		[Address(RVA = "0x9EFE00", Offset = "0x9EF200", VA = "0x1809EFE00")]
		set
		{
		}
	}

	[Token(Token = "0x17001640")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlignmentInformation AlignmentInformation
	{
		[Token(Token = "0x600679A")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600679B")]
		[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
		set
		{
		}
	}

	[Token(Token = "0x17001641")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CriticalHitWeapon
	{
		[Token(Token = "0x600679C")]
		[Address(RVA = "0x7D9E50", Offset = "0x7D9250", VA = "0x1807D9E50")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600679D")]
		[Address(RVA = "0xBA6350", Offset = "0xBA5750", VA = "0x180BA6350")]
		set
		{
		}
	}

	[Token(Token = "0x17001642")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharacterCharacteristic> Characteristics
	{
		[Token(Token = "0x600679E")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001643")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SpellModifier> SpellModifiers
	{
		[Token(Token = "0x600679F")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001644")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ProbationTime
	{
		[Token(Token = "0x60067A0")]
		[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60067A1")]
		[Address(RVA = "0xBA6360", Offset = "0xBA5760", VA = "0x180BA6360")]
		set
		{
		}
	}

	[Token(Token = "0x600678D")]
	[Address(RVA = "0xBA59B0", Offset = "0xBA4DB0", VA = "0x180BA59B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristics()
	{
	}

	[Token(Token = "0x600678E")]
	[Address(RVA = "0xBA5A70", Offset = "0xBA4E70", VA = "0x180BA5A70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristics(CharacterCharacteristics other)
	{
	}

	[Token(Token = "0x600678F")]
	[Address(RVA = "0xBA4FF0", Offset = "0xBA43F0", VA = "0x180BA4FF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristics Clone()
	{
		return null;
	}

	[Token(Token = "0x60067A2")]
	[Address(RVA = "0xBA5180", Offset = "0xBA4580", VA = "0x180BA5180", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60067A3")]
	[Address(RVA = "0xBA5050", Offset = "0xBA4450", VA = "0x180BA5050", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterCharacteristics other)
	{
		return default(bool);
	}

	[Token(Token = "0x60067A4")]
	[Address(RVA = "0xBA52F0", Offset = "0xBA46F0", VA = "0x180BA52F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60067A5")]
	[Address(RVA = "0xBA5700", Offset = "0xBA4B00", VA = "0x180BA5700", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60067A6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60067A7")]
	[Address(RVA = "0xBA6070", Offset = "0xBA5470", VA = "0x180BA6070", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60067A8")]
	[Address(RVA = "0xBA4DA0", Offset = "0xBA41A0", VA = "0x180BA4DA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60067A9")]
	[Address(RVA = "0xBA5470", Offset = "0xBA4870", VA = "0x180BA5470", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterCharacteristics other)
	{
	}

	[Token(Token = "0x60067AA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60067AB")]
	[Address(RVA = "0xBA5DB0", Offset = "0xBA51B0", VA = "0x180BA5DB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
