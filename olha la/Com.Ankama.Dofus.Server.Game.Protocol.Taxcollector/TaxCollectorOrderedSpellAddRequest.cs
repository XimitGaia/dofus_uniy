using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x2000094")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorOrderedSpellAddRequest : IMessage<TaxCollectorOrderedSpellAddRequest>, IMessage, IEquatable<TaxCollectorOrderedSpellAddRequest>, IDeepCloneable<TaxCollectorOrderedSpellAddRequest>, IBufferMessage
{
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorOrderedSpellAddRequest> _parser;

	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001EF")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x40001F1")]
	public const int AddedSpellFieldNumber = 2;

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x20")]
	private TaxCollectorOrderedSpell addedSpell_;

	[Token(Token = "0x17000126")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorOrderedSpellAddRequest> Parser
	{
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x9540F0", Offset = "0x9534F0", VA = "0x1809540F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000127")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x954040", Offset = "0x953440", VA = "0x180954040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000128")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x954280", Offset = "0x953680", VA = "0x180954280", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000129")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TaxCollectorUid
	{
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x954360", Offset = "0x953760", VA = "0x180954360")]
		set
		{
		}
	}

	[Token(Token = "0x1700012A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorOrderedSpell AddedSpell
	{
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x953F30", Offset = "0x953330", VA = "0x180953F30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpellAddRequest()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x953F80", Offset = "0x953380", VA = "0x180953F80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorOrderedSpellAddRequest(TaxCollectorOrderedSpellAddRequest other)
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x953B30", Offset = "0x952F30", VA = "0x180953B30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpellAddRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x953C20", Offset = "0x953020", VA = "0x180953C20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorOrderedSpellAddRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x953DD0", Offset = "0x9531D0", VA = "0x180953DD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x953A70", Offset = "0x952E70", VA = "0x180953A70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x953CE0", Offset = "0x9530E0", VA = "0x180953CE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorOrderedSpellAddRequest other)
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x954140", Offset = "0x953540", VA = "0x180954140", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
