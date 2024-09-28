using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B18")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorOrderedSpell : IMessage<TaxCollectorOrderedSpell>, IMessage, IEquatable<TaxCollectorOrderedSpell>, IDeepCloneable<TaxCollectorOrderedSpell>, IBufferMessage
{
	[Token(Token = "0x4002933")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorOrderedSpell> _parser;

	[Token(Token = "0x4002934")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002935")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x4002936")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x4002937")]
	public const int SlotIdFieldNumber = 2;

	[Token(Token = "0x4002938")]
	[FieldOffset(Offset = "0x1C")]
	private int slotId_;

	[Token(Token = "0x170019A3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorOrderedSpell> Parser
	{
		[Token(Token = "0x60074B5")]
		[Address(RVA = "0xC111F0", Offset = "0xC105F0", VA = "0x180C111F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60074B6")]
		[Address(RVA = "0xC11140", Offset = "0xC10540", VA = "0x180C11140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019A5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60074B7")]
		[Address(RVA = "0xC11240", Offset = "0xC10640", VA = "0x180C11240", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019A6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpellId
	{
		[Token(Token = "0x60074BB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60074BC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170019A7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SlotId
	{
		[Token(Token = "0x60074BD")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60074BE")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60074B8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpell()
	{
	}

	[Token(Token = "0x60074B9")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorOrderedSpell(TaxCollectorOrderedSpell other)
	{
	}

	[Token(Token = "0x60074BA")]
	[Address(RVA = "0xC10EC0", Offset = "0xC102C0", VA = "0x180C10EC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorOrderedSpell Clone()
	{
		return null;
	}

	[Token(Token = "0x60074BF")]
	[Address(RVA = "0xC10F50", Offset = "0xC10350", VA = "0x180C10F50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60074C0")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorOrderedSpell other)
	{
		return default(bool);
	}

	[Token(Token = "0x60074C1")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60074C2")]
	[Address(RVA = "0xC10FE0", Offset = "0xC103E0", VA = "0x180C10FE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60074C3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60074C4")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60074C5")]
	[Address(RVA = "0xC10E00", Offset = "0xC10200", VA = "0x180C10E00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60074C6")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorOrderedSpell other)
	{
	}

	[Token(Token = "0x60074C7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60074C8")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
