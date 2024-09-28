using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x2000114")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellsEvent : IMessage<SpellsEvent>, IMessage, IEquatable<SpellsEvent>, IDeepCloneable<SpellsEvent>, IBufferMessage
{
	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellsEvent> _parser;

	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003A2")]
	public const int SpellVisualisationFieldNumber = 1;

	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x18")]
	private bool spellVisualisation_;

	[Token(Token = "0x40003A4")]
	public const int HumanSpellsFieldNumber = 2;

	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<SpellItem> _repeated_humanSpells_codec;

	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<SpellItem> humanSpells_;

	[Token(Token = "0x40003A7")]
	public const int MutantSpellsFieldNumber = 3;

	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<SpellItem> _repeated_mutantSpells_codec;

	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<SpellItem> mutantSpells_;

	[Token(Token = "0x1700023B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SpellsEvent> Parser
	{
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0xB72EE0", Offset = "0xB722E0", VA = "0x180B72EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xB72E30", Offset = "0xB72230", VA = "0x180B72E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xB731B0", Offset = "0xB725B0", VA = "0x180B731B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool SpellVisualisation
	{
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x1700023F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<SpellItem> HumanSpells
	{
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000240")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<SpellItem> MutantSpells
	{
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A90")]
	[Address(RVA = "0xB72CC0", Offset = "0xB720C0", VA = "0x180B72CC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellsEvent()
	{
	}

	[Token(Token = "0x6000A91")]
	[Address(RVA = "0xB72D70", Offset = "0xB72170", VA = "0x180B72D70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellsEvent(SpellsEvent other)
	{
	}

	[Token(Token = "0x6000A92")]
	[Address(RVA = "0xB72610", Offset = "0xB71A10", VA = "0x180B72610", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000A97")]
	[Address(RVA = "0xB727B0", Offset = "0xB71BB0", VA = "0x180B727B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A98")]
	[Address(RVA = "0xB726F0", Offset = "0xB71AF0", VA = "0x180B726F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpellsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A99")]
	[Address(RVA = "0xB728B0", Offset = "0xB71CB0", VA = "0x180B728B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0xB72A40", Offset = "0xB71E40", VA = "0x180B72A40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0xB730B0", Offset = "0xB724B0", VA = "0x180B730B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0xB72530", Offset = "0xB71930", VA = "0x180B72530", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0xB729A0", Offset = "0xB71DA0", VA = "0x180B729A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpellsEvent other)
	{
	}

	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0xB72F30", Offset = "0xB72330", VA = "0x180B72F30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
