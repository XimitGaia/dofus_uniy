using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x200010A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellEquipmentSlotsEvent : IMessage<ForgettableSpellEquipmentSlotsEvent>, IMessage, IEquatable<ForgettableSpellEquipmentSlotsEvent>, IDeepCloneable<ForgettableSpellEquipmentSlotsEvent>, IBufferMessage
{
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellEquipmentSlotsEvent> _parser;

	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000384")]
	public const int QuantityFieldNumber = 1;

	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x18")]
	private int quantity_;

	[Token(Token = "0x1700022D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ForgettableSpellEquipmentSlotsEvent> Parser
	{
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xB66A70", Offset = "0xB65E70", VA = "0x180B66A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xB669C0", Offset = "0xB65DC0", VA = "0x180B669C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xB66AC0", Offset = "0xB65EC0", VA = "0x180B66AC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000230")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellEquipmentSlotsEvent()
	{
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellEquipmentSlotsEvent(ForgettableSpellEquipmentSlotsEvent other)
	{
	}

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0xB66750", Offset = "0xB65B50", VA = "0x180B66750", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellEquipmentSlotsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000A51")]
	[Address(RVA = "0xB667D0", Offset = "0xB65BD0", VA = "0x180B667D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ForgettableSpellEquipmentSlotsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000A54")]
	[Address(RVA = "0xB66860", Offset = "0xB65C60", VA = "0x180B66860", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000A57")]
	[Address(RVA = "0xB666C0", Offset = "0xB65AC0", VA = "0x180B666C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ForgettableSpellEquipmentSlotsEvent other)
	{
	}

	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
