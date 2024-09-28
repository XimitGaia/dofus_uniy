using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001C8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetInfo : IMessage<CharacterPresetInfo>, IMessage, IEquatable<CharacterPresetInfo>, IDeepCloneable<CharacterPresetInfo>, IBufferMessage
{
	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetInfo> _parser;

	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40005EF")]
	public const int UuidFieldNumber = 1;

	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x18")]
	private string uuid_;

	[Token(Token = "0x40005F1")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x40005F3")]
	public const int SymbolIdFieldNumber = 3;

	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x28")]
	private int symbolId_;

	[Token(Token = "0x40005F5")]
	public const int IsFavoriteFieldNumber = 4;

	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x2C")]
	private bool isFavorite_;

	[Token(Token = "0x40005F7")]
	public const int LastModificationDateFieldNumber = 5;

	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x30")]
	private string lastModificationDate_;

	[Token(Token = "0x40005F9")]
	public const int EquipmentByPositionFieldNumber = 6;

	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MapField<int, Equipment>.Codec _map_equipmentByPosition_codec;

	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x38")]
	private readonly MapField<int, Equipment> equipmentByPosition_;

	[Token(Token = "0x40005FC")]
	public const int SpellPresetFieldNumber = 7;

	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x40")]
	private SpellPreset spellPreset_;

	[Token(Token = "0x40005FE")]
	public const int CharacteristicsInfoFieldNumber = 8;

	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x48")]
	private CharacteristicsInfo characteristicsInfo_;

	[Token(Token = "0x4000600")]
	public const int PresetLookFieldNumber = 9;

	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x50")]
	private PresetLook presetLook_;

	[Token(Token = "0x4000602")]
	public const int RideFieldNumber = 10;

	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0x58")]
	private Ride ride_;

	[Token(Token = "0x4000604")]
	public const int OutfitUuidFieldNumber = 11;

	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string OutfitUuidDefaultValue;

	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x60")]
	private string outfitUuid_;

	[Token(Token = "0x170003CF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterPresetInfo> Parser
	{
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0xCBEB70", Offset = "0xCBDF70", VA = "0x180CBEB70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0xCBEA50", Offset = "0xCBDE50", VA = "0x180CBEA50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003D1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0xCBF1F0", Offset = "0xCBE5F0", VA = "0x180CBF1F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003D2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001200")]
		[Address(RVA = "0xCBF420", Offset = "0xCBE820", VA = "0x180CBF420")]
		set
		{
		}
	}

	[Token(Token = "0x170003D3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001202")]
		[Address(RVA = "0xCBF340", Offset = "0xCBE740", VA = "0x180CBF340")]
		set
		{
		}
	}

	[Token(Token = "0x170003D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SymbolId
	{
		[Token(Token = "0x6001203")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170003D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsFavorite
	{
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x9A7CA0", Offset = "0x9A70A0", VA = "0x1809A7CA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x9A8090", Offset = "0x9A7490", VA = "0x1809A8090")]
		set
		{
		}
	}

	[Token(Token = "0x170003D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LastModificationDate
	{
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001208")]
		[Address(RVA = "0xCBF2D0", Offset = "0xCBE6D0", VA = "0x180CBF2D0")]
		set
		{
		}
	}

	[Token(Token = "0x170003D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, Equipment> EquipmentByPosition
	{
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003D8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellPreset SpellPreset
	{
		[Token(Token = "0x600120A")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
		set
		{
		}
	}

	[Token(Token = "0x170003D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacteristicsInfo CharacteristicsInfo
	{
		[Token(Token = "0x600120C")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x600120D")]
		[Address(RVA = "0x92EFD0", Offset = "0x92E3D0", VA = "0x18092EFD0")]
		set
		{
		}
	}

	[Token(Token = "0x170003DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetLook PresetLook
	{
		[Token(Token = "0x600120E")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600120F")]
		[Address(RVA = "0x912500", Offset = "0x911900", VA = "0x180912500")]
		set
		{
		}
	}

	[Token(Token = "0x170003DB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Ride Ride
	{
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x912510", Offset = "0x911910", VA = "0x180912510")]
		set
		{
		}
	}

	[Token(Token = "0x170003DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string OutfitUuid
	{
		[Token(Token = "0x6001212")]
		[Address(RVA = "0xCBEB10", Offset = "0xCBDF10", VA = "0x180CBEB10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001213")]
		[Address(RVA = "0xCBF3B0", Offset = "0xCBE7B0", VA = "0x180CBF3B0")]
		set
		{
		}
	}

	[Token(Token = "0x170003DD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasOutfitUuid
	{
		[Token(Token = "0x6001214")]
		[Address(RVA = "0xCBEB00", Offset = "0xCBDF00", VA = "0x180CBEB00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60011FC")]
	[Address(RVA = "0xCBE980", Offset = "0xCBDD80", VA = "0x180CBE980")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetInfo()
	{
	}

	[Token(Token = "0x60011FD")]
	[Address(RVA = "0xCBE660", Offset = "0xCBDA60", VA = "0x180CBE660")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetInfo(CharacterPresetInfo other)
	{
	}

	[Token(Token = "0x60011FE")]
	[Address(RVA = "0xCBDAA0", Offset = "0xCBCEA0", VA = "0x180CBDAA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetInfo Clone()
	{
		return null;
	}

	[Token(Token = "0x6001215")]
	[Address(RVA = "0xCBDA80", Offset = "0xCBCE80", VA = "0x180CBDA80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearOutfitUuid()
	{
	}

	[Token(Token = "0x6001216")]
	[Address(RVA = "0xCBDB00", Offset = "0xCBCF00", VA = "0x180CBDB00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001217")]
	[Address(RVA = "0xCBDB60", Offset = "0xCBCF60", VA = "0x180CBDB60", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterPresetInfo other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001218")]
	[Address(RVA = "0xCBDCF0", Offset = "0xCBD0F0", VA = "0x180CBDCF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001219")]
	[Address(RVA = "0xCBE3B0", Offset = "0xCBD7B0", VA = "0x180CBE3B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600121A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600121B")]
	[Address(RVA = "0xCBEF70", Offset = "0xCBE370", VA = "0x180CBEF70", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600121C")]
	[Address(RVA = "0xCBD7C0", Offset = "0xCBCBC0", VA = "0x180CBD7C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600121D")]
	[Address(RVA = "0xCBDF30", Offset = "0xCBD330", VA = "0x180CBDF30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterPresetInfo other)
	{
	}

	[Token(Token = "0x600121E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600121F")]
	[Address(RVA = "0xCBEBC0", Offset = "0xCBDFC0", VA = "0x180CBEBC0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
