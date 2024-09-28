using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000C4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorPresetSpellUpdatedEvent : IMessage<TaxCollectorPresetSpellUpdatedEvent>, IMessage, IEquatable<TaxCollectorPresetSpellUpdatedEvent>, IDeepCloneable<TaxCollectorPresetSpellUpdatedEvent>, IBufferMessage
{
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorPresetSpellUpdatedEvent> _parser;

	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002AD")]
	public const int PresetUidFieldNumber = 1;

	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x18")]
	private string presetUid_;

	[Token(Token = "0x40002AF")]
	public const int SpellsFieldNumber = 2;

	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TaxCollectorOrderedSpell> _repeated_spells_codec;

	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<TaxCollectorOrderedSpell> spells_;

	[Token(Token = "0x1700019B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorPresetSpellUpdatedEvent> Parser
	{
		[Token(Token = "0x600077C")]
		[Address(RVA = "0xA69570", Offset = "0xA68970", VA = "0x180A69570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700019C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600077D")]
		[Address(RVA = "0xA694C0", Offset = "0xA688C0", VA = "0x180A694C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700019D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600077E")]
		[Address(RVA = "0xA697F0", Offset = "0xA68BF0", VA = "0x180A697F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700019E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUid
	{
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000783")]
		[Address(RVA = "0xA698D0", Offset = "0xA68CD0", VA = "0x180A698D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700019F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TaxCollectorOrderedSpell> Spells
	{
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0xA69380", Offset = "0xA68780", VA = "0x180A69380")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetSpellUpdatedEvent()
	{
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0xA69420", Offset = "0xA68820", VA = "0x180A69420")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetSpellUpdatedEvent(TaxCollectorPresetSpellUpdatedEvent other)
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0xA68E70", Offset = "0xA68270", VA = "0x180A68E70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetSpellUpdatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0xA68F40", Offset = "0xA68340", VA = "0x180A68F40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0xA69030", Offset = "0xA68430", VA = "0x180A69030", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorPresetSpellUpdatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0xA68490", Offset = "0xA67890", VA = "0x180A68490", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0xA69180", Offset = "0xA68580", VA = "0x180A69180", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0xA69710", Offset = "0xA68B10", VA = "0x180A69710", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600078B")]
	[Address(RVA = "0xA68D80", Offset = "0xA68180", VA = "0x180A68D80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0xA690E0", Offset = "0xA684E0", VA = "0x180A690E0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorPresetSpellUpdatedEvent other)
	{
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0xA695C0", Offset = "0xA689C0", VA = "0x180A695C0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
