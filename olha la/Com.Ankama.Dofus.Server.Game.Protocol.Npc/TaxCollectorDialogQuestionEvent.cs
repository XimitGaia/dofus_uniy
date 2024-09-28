using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002E5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorDialogQuestionEvent : IMessage<TaxCollectorDialogQuestionEvent>, IMessage, IEquatable<TaxCollectorDialogQuestionEvent>, IDeepCloneable<TaxCollectorDialogQuestionEvent>, IBufferMessage
{
	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorDialogQuestionEvent> _parser;

	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4000A2D")]
	public const int AllianceInformationFieldNumber = 1;

	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x20")]
	private AllianceInformation allianceInformation_;

	[Token(Token = "0x4000A2F")]
	public const int MaxPodsFieldNumber = 2;

	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x28")]
	private int maxPods_;

	[Token(Token = "0x4000A31")]
	public const int ProspectingFieldNumber = 3;

	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x2C")]
	private int prospecting_;

	[Token(Token = "0x4000A33")]
	public const int TaxCollectorsCountFieldNumber = 4;

	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x30")]
	private int taxCollectorsCount_;

	[Token(Token = "0x4000A35")]
	public const int PossibleAttackFieldNumber = 5;

	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int PossibleAttackDefaultValue;

	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x34")]
	private int possibleAttack_;

	[Token(Token = "0x4000A38")]
	public const int LootedPodsFieldNumber = 6;

	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x38")]
	private int lootedPods_;

	[Token(Token = "0x4000A3A")]
	public const int LootedItemsValueFieldNumber = 7;

	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x40")]
	private long lootedItemsValue_;

	[Token(Token = "0x17000679")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorDialogQuestionEvent> Parser
	{
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0xD2EB70", Offset = "0xD2DF70", VA = "0x180D2EB70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700067A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0xD2EAC0", Offset = "0xD2DEC0", VA = "0x180D2EAC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700067B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0xD2EF60", Offset = "0xD2E360", VA = "0x180D2EF60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700067C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation AllianceInformation
	{
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x1700067D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxPods
	{
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x1700067E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Prospecting
	{
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x1700067F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TaxCollectorsCount
	{
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17000680")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PossibleAttack
	{
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0xD2EBC0", Offset = "0xD2DFC0", VA = "0x180D2EBC0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0xA2D870", Offset = "0xA2CC70", VA = "0x180A2D870")]
		set
		{
		}
	}

	[Token(Token = "0x17000681")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasPossibleAttack
	{
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000682")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LootedPods
	{
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x17000683")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LootedItemsValue
	{
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0xAFF0D0", Offset = "0xAFE4D0", VA = "0x180AFF0D0")]
		set
		{
		}
	}

	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorDialogQuestionEvent()
	{
	}

	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0xD2EA20", Offset = "0xD2DE20", VA = "0x180D2EA20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorDialogQuestionEvent(TaxCollectorDialogQuestionEvent other)
	{
	}

	[Token(Token = "0x6001E00")]
	[Address(RVA = "0xD2E3A0", Offset = "0xD2D7A0", VA = "0x180D2E3A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorDialogQuestionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001E0C")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearPossibleAttack()
	{
	}

	[Token(Token = "0x6001E11")]
	[Address(RVA = "0xD2E530", Offset = "0xD2D930", VA = "0x180D2E530", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E12")]
	[Address(RVA = "0xD2E470", Offset = "0xD2D870", VA = "0x180D2E470", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorDialogQuestionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E13")]
	[Address(RVA = "0xD2E630", Offset = "0xD2DA30", VA = "0x180D2E630", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001E14")]
	[Address(RVA = "0xD2E8B0", Offset = "0xD2DCB0", VA = "0x180D2E8B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001E16")]
	[Address(RVA = "0xD2EDF0", Offset = "0xD2E1F0", VA = "0x180D2EDF0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001E17")]
	[Address(RVA = "0xD2E1C0", Offset = "0xD2D5C0", VA = "0x180D2E1C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001E18")]
	[Address(RVA = "0xD2E790", Offset = "0xD2DB90", VA = "0x180D2E790", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorDialogQuestionEvent other)
	{
	}

	[Token(Token = "0x6001E19")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001E1A")]
	[Address(RVA = "0xD2EC30", Offset = "0xD2E030", VA = "0x180D2EC30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
