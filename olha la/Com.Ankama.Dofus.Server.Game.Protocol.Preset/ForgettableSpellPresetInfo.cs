using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001CA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetInfo : IMessage<ForgettableSpellPresetInfo>, IMessage, IEquatable<ForgettableSpellPresetInfo>, IDeepCloneable<ForgettableSpellPresetInfo>, IBufferMessage
{
	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetInfo> _parser;

	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400060A")]
	public const int UuidFieldNumber = 1;

	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x18")]
	private string uuid_;

	[Token(Token = "0x400060C")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x400060E")]
	public const int SymbolIdFieldNumber = 3;

	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x28")]
	private int symbolId_;

	[Token(Token = "0x4000610")]
	public const int IsFavoriteFieldNumber = 4;

	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x2C")]
	private bool isFavorite_;

	[Token(Token = "0x4000612")]
	public const int LastModificationDateFieldNumber = 5;

	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x30")]
	private string lastModificationDate_;

	[Token(Token = "0x4000614")]
	public const int SpellPresetFieldNumber = 6;

	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0x38")]
	private SpellPreset spellPreset_;

	[Token(Token = "0x4000616")]
	public const int ForgettableSpellInfoByIdFieldNumber = 7;

	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MapField<int, ForgettableSpellInfo>.Codec _map_forgettableSpellInfoById_codec;

	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x40")]
	private readonly MapField<int, ForgettableSpellInfo> forgettableSpellInfoById_;

	[Token(Token = "0x170003DE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ForgettableSpellPresetInfo> Parser
	{
		[Token(Token = "0x6001224")]
		[Address(RVA = "0xCC3DE0", Offset = "0xCC31E0", VA = "0x180CC3DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003DF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001225")]
		[Address(RVA = "0xCC3D30", Offset = "0xCC3130", VA = "0x180CC3D30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001226")]
		[Address(RVA = "0xCC4240", Offset = "0xCC3640", VA = "0x180CC4240", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600122B")]
		[Address(RVA = "0xCC4400", Offset = "0xCC3800", VA = "0x180CC4400")]
		set
		{
		}
	}

	[Token(Token = "0x170003E2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600122D")]
		[Address(RVA = "0xCC4390", Offset = "0xCC3790", VA = "0x180CC4390")]
		set
		{
		}
	}

	[Token(Token = "0x170003E3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SymbolId
	{
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170003E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsFavorite
	{
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x9A7CA0", Offset = "0x9A70A0", VA = "0x1809A7CA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x9A8090", Offset = "0x9A7490", VA = "0x1809A8090")]
		set
		{
		}
	}

	[Token(Token = "0x170003E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LastModificationDate
	{
		[Token(Token = "0x6001232")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001233")]
		[Address(RVA = "0xCC4320", Offset = "0xCC3720", VA = "0x180CC4320")]
		set
		{
		}
	}

	[Token(Token = "0x170003E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellPreset SpellPreset
	{
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
		set
		{
		}
	}

	[Token(Token = "0x170003E7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, ForgettableSpellInfo> ForgettableSpellInfoById
	{
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001227")]
	[Address(RVA = "0xCC3B70", Offset = "0xCC2F70", VA = "0x180CC3B70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetInfo()
	{
	}

	[Token(Token = "0x6001228")]
	[Address(RVA = "0xCC3C40", Offset = "0xCC3040", VA = "0x180CC3C40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetInfo(ForgettableSpellPresetInfo other)
	{
	}

	[Token(Token = "0x6001229")]
	[Address(RVA = "0xCC3260", Offset = "0xCC2660", VA = "0x180CC3260", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetInfo Clone()
	{
		return null;
	}

	[Token(Token = "0x6001237")]
	[Address(RVA = "0xCC3480", Offset = "0xCC2880", VA = "0x180CC3480", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001238")]
	[Address(RVA = "0xCC3380", Offset = "0xCC2780", VA = "0x180CC3380", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellPresetInfo other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001239")]
	[Address(RVA = "0xCC35D0", Offset = "0xCC29D0", VA = "0x180CC35D0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600123A")]
	[Address(RVA = "0xCC3900", Offset = "0xCC2D00", VA = "0x180CC3900", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600123B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600123C")]
	[Address(RVA = "0xCC40A0", Offset = "0xCC34A0", VA = "0x180CC40A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600123D")]
	[Address(RVA = "0xCC30A0", Offset = "0xCC24A0", VA = "0x180CC30A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600123E")]
	[Address(RVA = "0xCC3740", Offset = "0xCC2B40", VA = "0x180CC3740", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ForgettableSpellPresetInfo other)
	{
	}

	[Token(Token = "0x600123F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001240")]
	[Address(RVA = "0xCC3E30", Offset = "0xCC3230", VA = "0x180CC3E30", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
