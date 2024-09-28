using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B0D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorInformation : IMessage<TaxCollectorInformation>, IMessage, IEquatable<TaxCollectorInformation>, IDeepCloneable<TaxCollectorInformation>, IBufferMessage
{
	[Token(Token = "0x40028E4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorInformation> _parser;

	[Token(Token = "0x40028E5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40028E6")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x40028E7")]
	[FieldOffset(Offset = "0x18")]
	private string uid_;

	[Token(Token = "0x40028E8")]
	public const int FirstNameIdFieldNumber = 2;

	[Token(Token = "0x40028E9")]
	[FieldOffset(Offset = "0x20")]
	private int firstNameId_;

	[Token(Token = "0x40028EA")]
	public const int LastNameIdFieldNumber = 3;

	[Token(Token = "0x40028EB")]
	[FieldOffset(Offset = "0x24")]
	private int lastNameId_;

	[Token(Token = "0x40028EC")]
	public const int AllianceFieldNumber = 4;

	[Token(Token = "0x40028ED")]
	[FieldOffset(Offset = "0x28")]
	private AllianceInformation alliance_;

	[Token(Token = "0x40028EE")]
	public const int CallerIdFieldNumber = 5;

	[Token(Token = "0x40028EF")]
	[FieldOffset(Offset = "0x30")]
	private long callerId_;

	[Token(Token = "0x40028F0")]
	public const int CallerNameFieldNumber = 6;

	[Token(Token = "0x40028F1")]
	[FieldOffset(Offset = "0x38")]
	private string callerName_;

	[Token(Token = "0x40028F2")]
	public const int HiredDateFieldNumber = 7;

	[Token(Token = "0x40028F3")]
	[FieldOffset(Offset = "0x40")]
	private long hiredDate_;

	[Token(Token = "0x40028F4")]
	public const int CoordinatesFieldNumber = 8;

	[Token(Token = "0x40028F5")]
	[FieldOffset(Offset = "0x48")]
	private MapCoordinates coordinates_;

	[Token(Token = "0x40028F6")]
	public const int SubAreaIdFieldNumber = 9;

	[Token(Token = "0x40028F7")]
	[FieldOffset(Offset = "0x50")]
	private int subAreaId_;

	[Token(Token = "0x40028F8")]
	public const int MapIdFieldNumber = 10;

	[Token(Token = "0x40028F9")]
	[FieldOffset(Offset = "0x58")]
	private long mapId_;

	[Token(Token = "0x40028FA")]
	public const int StateFieldNumber = 11;

	[Token(Token = "0x40028FB")]
	[FieldOffset(Offset = "0x60")]
	private TaxCollectorState state_;

	[Token(Token = "0x40028FC")]
	public const int EntityLookFieldNumber = 12;

	[Token(Token = "0x40028FD")]
	[FieldOffset(Offset = "0x68")]
	private EntityLook entityLook_;

	[Token(Token = "0x40028FE")]
	public const int ComplementaryInformationFieldNumber = 13;

	[Token(Token = "0x40028FF")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TaxCollectorComplementaryInformation> _repeated_complementaryInformation_codec;

	[Token(Token = "0x4002900")]
	[FieldOffset(Offset = "0x70")]
	private readonly RepeatedField<TaxCollectorComplementaryInformation> complementaryInformation_;

	[Token(Token = "0x4002901")]
	public const int CharacterCharacteristicsFieldNumber = 14;

	[Token(Token = "0x4002902")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<CharacterCharacteristic> _repeated_characterCharacteristics_codec;

	[Token(Token = "0x4002903")]
	[FieldOffset(Offset = "0x78")]
	private readonly RepeatedField<CharacterCharacteristic> characterCharacteristics_;

	[Token(Token = "0x4002904")]
	public const int EquipmentsFieldNumber = 15;

	[Token(Token = "0x4002905")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_equipments_codec;

	[Token(Token = "0x4002906")]
	[FieldOffset(Offset = "0x80")]
	private readonly RepeatedField<ObjectItemInventory> equipments_;

	[Token(Token = "0x4002907")]
	public const int SpellsFieldNumber = 16;

	[Token(Token = "0x4002908")]
	[FieldOffset(Offset = "0x20")]
	private static readonly FieldCodec<TaxCollectorOrderedSpell> _repeated_spells_codec;

	[Token(Token = "0x4002909")]
	[FieldOffset(Offset = "0x88")]
	private readonly RepeatedField<TaxCollectorOrderedSpell> spells_;

	[Token(Token = "0x17001977")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorInformation> Parser
	{
		[Token(Token = "0x600741B")]
		[Address(RVA = "0xC0FEC0", Offset = "0xC0F2C0", VA = "0x180C0FEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001978")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600741C")]
		[Address(RVA = "0xC0FE10", Offset = "0xC0F210", VA = "0x180C0FE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001979")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600741D")]
		[Address(RVA = "0xC10700", Offset = "0xC0FB00", VA = "0x180C10700", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700197A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Uid
	{
		[Token(Token = "0x6007421")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007422")]
		[Address(RVA = "0xC10860", Offset = "0xC0FC60", VA = "0x180C10860")]
		set
		{
		}
	}

	[Token(Token = "0x1700197B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstNameId
	{
		[Token(Token = "0x6007423")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007424")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700197C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastNameId
	{
		[Token(Token = "0x6007425")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007426")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700197D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInformation Alliance
	{
		[Token(Token = "0x6007427")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007428")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x1700197E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CallerId
	{
		[Token(Token = "0x6007429")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600742A")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700197F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CallerName
	{
		[Token(Token = "0x600742B")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600742C")]
		[Address(RVA = "0xC107E0", Offset = "0xC0FBE0", VA = "0x180C107E0")]
		set
		{
		}
	}

	[Token(Token = "0x17001980")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long HiredDate
	{
		[Token(Token = "0x600742D")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600742E")]
		[Address(RVA = "0xAFF0D0", Offset = "0xAFE4D0", VA = "0x180AFF0D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001981")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapCoordinates Coordinates
	{
		[Token(Token = "0x600742F")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007430")]
		[Address(RVA = "0x92EFD0", Offset = "0x92E3D0", VA = "0x18092EFD0")]
		set
		{
		}
	}

	[Token(Token = "0x17001982")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SubAreaId
	{
		[Token(Token = "0x6007431")]
		[Address(RVA = "0x874EA0", Offset = "0x8742A0", VA = "0x180874EA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007432")]
		[Address(RVA = "0x874F70", Offset = "0x874370", VA = "0x180874F70")]
		set
		{
		}
	}

	[Token(Token = "0x17001983")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x6007433")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007434")]
		[Address(RVA = "0xBC8B10", Offset = "0xBC7F10", VA = "0x180BC8B10")]
		set
		{
		}
	}

	[Token(Token = "0x17001984")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorState State
	{
		[Token(Token = "0x6007435")]
		[Address(RVA = "0x9DF0C0", Offset = "0x9DE4C0", VA = "0x1809DF0C0")]
		get
		{
			return default(TaxCollectorState);
		}
		[Token(Token = "0x6007436")]
		[Address(RVA = "0x9DF8F0", Offset = "0x9DECF0", VA = "0x1809DF8F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001985")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityLook EntityLook
	{
		[Token(Token = "0x6007437")]
		[Address(RVA = "0x8E5D30", Offset = "0x8E5130", VA = "0x1808E5D30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007438")]
		[Address(RVA = "0xC10850", Offset = "0xC0FC50", VA = "0x180C10850")]
		set
		{
		}
	}

	[Token(Token = "0x17001986")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TaxCollectorComplementaryInformation> ComplementaryInformation
	{
		[Token(Token = "0x6007439")]
		[Address(RVA = "0x9C6060", Offset = "0x9C5460", VA = "0x1809C6060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001987")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharacterCharacteristic> CharacterCharacteristics
	{
		[Token(Token = "0x600743A")]
		[Address(RVA = "0x87E160", Offset = "0x87D560", VA = "0x18087E160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001988")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Equipments
	{
		[Token(Token = "0x600743B")]
		[Address(RVA = "0x8E5A60", Offset = "0x8E4E60", VA = "0x1808E5A60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001989")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TaxCollectorOrderedSpell> Spells
	{
		[Token(Token = "0x600743C")]
		[Address(RVA = "0x87DC60", Offset = "0x87D060", VA = "0x18087DC60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600741E")]
	[Address(RVA = "0xC0FC80", Offset = "0xC0F080", VA = "0x180C0FC80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorInformation()
	{
	}

	[Token(Token = "0x600741F")]
	[Address(RVA = "0xC0FA80", Offset = "0xC0EE80", VA = "0x180C0FA80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorInformation(TaxCollectorInformation other)
	{
	}

	[Token(Token = "0x6007420")]
	[Address(RVA = "0xC0EEA0", Offset = "0xC0E2A0", VA = "0x180C0EEA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600743D")]
	[Address(RVA = "0xC0EF00", Offset = "0xC0E300", VA = "0x180C0EF00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600743E")]
	[Address(RVA = "0xC0EF60", Offset = "0xC0E360", VA = "0x180C0EF60", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600743F")]
	[Address(RVA = "0xC0F160", Offset = "0xC0E560", VA = "0x180C0F160", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007440")]
	[Address(RVA = "0xC0F670", Offset = "0xC0EA70", VA = "0x180C0F670", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007441")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007442")]
	[Address(RVA = "0xC103E0", Offset = "0xC0F7E0", VA = "0x180C103E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007443")]
	[Address(RVA = "0xC0EB20", Offset = "0xC0DF20", VA = "0x180C0EB20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007444")]
	[Address(RVA = "0xC0F3B0", Offset = "0xC0E7B0", VA = "0x180C0F3B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorInformation other)
	{
	}

	[Token(Token = "0x6007445")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007446")]
	[Address(RVA = "0xC0FF10", Offset = "0xC0F310", VA = "0x180C0FF10", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
