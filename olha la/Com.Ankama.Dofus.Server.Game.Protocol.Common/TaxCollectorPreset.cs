using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B1A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorPreset : IMessage<TaxCollectorPreset>, IMessage, IEquatable<TaxCollectorPreset>, IDeepCloneable<TaxCollectorPreset>, IBufferMessage
{
	[Token(Token = "0x400293A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorPreset> _parser;

	[Token(Token = "0x400293B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400293C")]
	public const int PresetUidFieldNumber = 1;

	[Token(Token = "0x400293D")]
	[FieldOffset(Offset = "0x18")]
	private string presetUid_;

	[Token(Token = "0x400293E")]
	public const int SpellsFieldNumber = 2;

	[Token(Token = "0x400293F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TaxCollectorOrderedSpell> _repeated_spells_codec;

	[Token(Token = "0x4002940")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<TaxCollectorOrderedSpell> spells_;

	[Token(Token = "0x4002941")]
	public const int CharacteristicsFieldNumber = 3;

	[Token(Token = "0x4002942")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<CharacterCharacteristic> _repeated_characteristics_codec;

	[Token(Token = "0x4002943")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<CharacterCharacteristic> characteristics_;

	[Token(Token = "0x170019A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorPreset> Parser
	{
		[Token(Token = "0x60074CD")]
		[Address(RVA = "0xC11DE0", Offset = "0xC111E0", VA = "0x180C11DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60074CE")]
		[Address(RVA = "0xC11D30", Offset = "0xC11130", VA = "0x180C11D30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60074CF")]
		[Address(RVA = "0xC12100", Offset = "0xC11500", VA = "0x180C12100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019AB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUid
	{
		[Token(Token = "0x60074D3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60074D4")]
		[Address(RVA = "0xC121E0", Offset = "0xC115E0", VA = "0x180C121E0")]
		set
		{
		}
	}

	[Token(Token = "0x170019AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<TaxCollectorOrderedSpell> Spells
	{
		[Token(Token = "0x60074D5")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019AD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharacterCharacteristic> Characteristics
	{
		[Token(Token = "0x60074D6")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074D0")]
	[Address(RVA = "0xC11C40", Offset = "0xC11040", VA = "0x180C11C40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPreset()
	{
	}

	[Token(Token = "0x60074D1")]
	[Address(RVA = "0xC11B70", Offset = "0xC10F70", VA = "0x180C11B70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPreset(TaxCollectorPreset other)
	{
	}

	[Token(Token = "0x60074D2")]
	[Address(RVA = "0xC11450", Offset = "0xC10850", VA = "0x180C11450", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPreset Clone()
	{
		return null;
	}

	[Token(Token = "0x60074D7")]
	[Address(RVA = "0xC11550", Offset = "0xC10950", VA = "0x180C11550", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60074D8")]
	[Address(RVA = "0xC11670", Offset = "0xC10A70", VA = "0x180C11670", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorPreset other)
	{
		return default(bool);
	}

	[Token(Token = "0x60074D9")]
	[Address(RVA = "0xC11740", Offset = "0xC10B40", VA = "0x180C11740", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60074DA")]
	[Address(RVA = "0xC118C0", Offset = "0xC10CC0", VA = "0x180C118C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60074DB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60074DC")]
	[Address(RVA = "0xC11FE0", Offset = "0xC113E0", VA = "0x180C11FE0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60074DD")]
	[Address(RVA = "0xC11320", Offset = "0xC10720", VA = "0x180C11320", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60074DE")]
	[Address(RVA = "0xC11800", Offset = "0xC10C00", VA = "0x180C11800", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorPreset other)
	{
	}

	[Token(Token = "0x60074DF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60074E0")]
	[Address(RVA = "0xC11E30", Offset = "0xC11230", VA = "0x180C11E30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
