using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x2000096")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorOrderedSpellRemoveRequest : IMessage<TaxCollectorOrderedSpellRemoveRequest>, IMessage, IEquatable<TaxCollectorOrderedSpellRemoveRequest>, IDeepCloneable<TaxCollectorOrderedSpellRemoveRequest>, IBufferMessage
{
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorOrderedSpellRemoveRequest> _parser;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001F6")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x40001F8")]
	public const int SlotIdFieldNumber = 2;

	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x20")]
	private int slotId_;

	[Token(Token = "0x1700012B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorOrderedSpellRemoveRequest> Parser
	{
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x955510", Offset = "0x954910", VA = "0x180955510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700012C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x955460", Offset = "0x954860", VA = "0x180955460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700012D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x9556C0", Offset = "0x954AC0", VA = "0x1809556C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700012E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TaxCollectorUid
	{
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x9557A0", Offset = "0x954BA0", VA = "0x1809557A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700012F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SlotId
	{
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x955410", Offset = "0x954810", VA = "0x180955410")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorOrderedSpellRemoveRequest()
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x955360", Offset = "0x954760", VA = "0x180955360")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpellRemoveRequest(TaxCollectorOrderedSpellRemoveRequest other)
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x954F10", Offset = "0x954310", VA = "0x180954F10", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorOrderedSpellRemoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x954FE0", Offset = "0x9543E0", VA = "0x180954FE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorOrderedSpellRemoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x955200", Offset = "0x954600", VA = "0x180955200", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x955630", Offset = "0x954A30", VA = "0x180955630", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x954E50", Offset = "0x954250", VA = "0x180954E50", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x955190", Offset = "0x954590", VA = "0x180955190", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorOrderedSpellRemoveRequest other)
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x955560", Offset = "0x954960", VA = "0x180955560", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
