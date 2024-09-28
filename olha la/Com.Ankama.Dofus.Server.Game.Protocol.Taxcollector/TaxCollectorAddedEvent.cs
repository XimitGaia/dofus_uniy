using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000A8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorAddedEvent : IMessage<TaxCollectorAddedEvent>, IMessage, IEquatable<TaxCollectorAddedEvent>, IDeepCloneable<TaxCollectorAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorAddedEvent> _parser;

	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000233")]
	public const int CallerIdFieldNumber = 1;

	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x18")]
	private long callerId_;

	[Token(Token = "0x4000235")]
	public const int TaxCollectorFieldNumber = 2;

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x20")]
	private TaxCollectorInformation taxCollector_;

	[Token(Token = "0x17000156")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorAddedEvent> Parser
	{
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x9537A0", Offset = "0x952BA0", VA = "0x1809537A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000157")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x9536F0", Offset = "0x952AF0", VA = "0x1809536F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000158")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x953990", Offset = "0x952D90", VA = "0x180953990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000159")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CallerId
	{
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700015A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorInformation TaxCollector
	{
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorAddedEvent()
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x953670", Offset = "0x952A70", VA = "0x180953670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorAddedEvent(TaxCollectorAddedEvent other)
	{
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x9531D0", Offset = "0x9525D0", VA = "0x1809531D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x9532E0", Offset = "0x9526E0", VA = "0x1809532E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x953270", Offset = "0x952670", VA = "0x180953270", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x9533A0", Offset = "0x9527A0", VA = "0x1809533A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x953510", Offset = "0x952910", VA = "0x180953510", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x953910", Offset = "0x952D10", VA = "0x180953910", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x953110", Offset = "0x952510", VA = "0x180953110", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x953430", Offset = "0x952830", VA = "0x180953430", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorAddedEvent other)
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x9537F0", Offset = "0x952BF0", VA = "0x1809537F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
