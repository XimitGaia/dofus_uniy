using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x200009E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorPresetSpellAddRequest : IMessage<TaxCollectorPresetSpellAddRequest>, IMessage, IEquatable<TaxCollectorPresetSpellAddRequest>, IDeepCloneable<TaxCollectorPresetSpellAddRequest>, IBufferMessage
{
	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorPresetSpellAddRequest> _parser;

	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400020C")]
	public const int PresetUidFieldNumber = 1;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x18")]
	private string presetUid_;

	[Token(Token = "0x400020E")]
	public const int SpellFieldNumber = 2;

	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x20")]
	private TaxCollectorOrderedSpell spell_;

	[Token(Token = "0x1700013C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorPresetSpellAddRequest> Parser
	{
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x955E90", Offset = "0x955290", VA = "0x180955E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x955DE0", Offset = "0x9551E0", VA = "0x180955DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x956020", Offset = "0x955420", VA = "0x180956020", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700013F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUid
	{
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x956100", Offset = "0x955500", VA = "0x180956100")]
		set
		{
		}
	}

	[Token(Token = "0x17000140")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpell Spell
	{
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x955CD0", Offset = "0x9550D0", VA = "0x180955CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetSpellAddRequest()
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x955D20", Offset = "0x955120", VA = "0x180955D20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetSpellAddRequest(TaxCollectorPresetSpellAddRequest other)
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x9558D0", Offset = "0x954CD0", VA = "0x1809558D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetSpellAddRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x9559C0", Offset = "0x954DC0", VA = "0x1809559C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorPresetSpellAddRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x955B70", Offset = "0x954F70", VA = "0x180955B70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x955810", Offset = "0x954C10", VA = "0x180955810", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x955A80", Offset = "0x954E80", VA = "0x180955A80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorPresetSpellAddRequest other)
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x955EE0", Offset = "0x9552E0", VA = "0x180955EE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
