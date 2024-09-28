using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x2000098")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorOrderedSpellMoveRequest : IMessage<TaxCollectorOrderedSpellMoveRequest>, IMessage, IEquatable<TaxCollectorOrderedSpellMoveRequest>, IDeepCloneable<TaxCollectorOrderedSpellMoveRequest>, IBufferMessage
{
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorOrderedSpellMoveRequest> _parser;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001FD")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x40001FF")]
	public const int FromSlotIdFieldNumber = 2;

	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x20")]
	private int fromSlotId_;

	[Token(Token = "0x4000201")]
	public const int ToSlotIdFieldNumber = 3;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x24")]
	private int toSlotId_;

	[Token(Token = "0x17000130")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorOrderedSpellMoveRequest> Parser
	{
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x954B10", Offset = "0x953F10", VA = "0x180954B10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000131")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x954A60", Offset = "0x953E60", VA = "0x180954A60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000132")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x954D00", Offset = "0x954100", VA = "0x180954D00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000133")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TaxCollectorUid
	{
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x954DE0", Offset = "0x9541E0", VA = "0x180954DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000134")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FromSlotId
	{
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000135")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ToSlotId
	{
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x954960", Offset = "0x953D60", VA = "0x180954960")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorOrderedSpellMoveRequest()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x9549B0", Offset = "0x953DB0", VA = "0x1809549B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpellMoveRequest(TaxCollectorOrderedSpellMoveRequest other)
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x9544B0", Offset = "0x9538B0", VA = "0x1809544B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpellMoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x954590", Offset = "0x953990", VA = "0x180954590", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x954650", Offset = "0x953A50", VA = "0x180954650", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorOrderedSpellMoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x9546D0", Offset = "0x953AD0", VA = "0x1809546D0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x954800", Offset = "0x953C00", VA = "0x180954800", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x954C50", Offset = "0x954050", VA = "0x180954C50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x9543D0", Offset = "0x9537D0", VA = "0x1809543D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x954780", Offset = "0x953B80", VA = "0x180954780", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorOrderedSpellMoveRequest other)
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x954B60", Offset = "0x953F60", VA = "0x180954B60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
