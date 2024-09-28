using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x2000090")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorUpdatesListenStartRequest : IMessage<TaxCollectorUpdatesListenStartRequest>, IMessage, IEquatable<TaxCollectorUpdatesListenStartRequest>, IDeepCloneable<TaxCollectorUpdatesListenStartRequest>, IBufferMessage
{
	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorUpdatesListenStartRequest> _parser;

	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001E5")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x1700011E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorUpdatesListenStartRequest> Parser
	{
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x959CC0", Offset = "0x9590C0", VA = "0x180959CC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700011F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x959C10", Offset = "0x959010", VA = "0x180959C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000120")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x959DD0", Offset = "0x9591D0", VA = "0x180959DD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000121")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TaxCollectorUid
	{
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x959EB0", Offset = "0x9592B0", VA = "0x180959EB0")]
		set
		{
		}
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x959B20", Offset = "0x958F20", VA = "0x180959B20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorUpdatesListenStartRequest()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x959B70", Offset = "0x958F70", VA = "0x180959B70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorUpdatesListenStartRequest(TaxCollectorUpdatesListenStartRequest other)
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x9597E0", Offset = "0x958BE0", VA = "0x1809597E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorUpdatesListenStartRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x9598B0", Offset = "0x958CB0", VA = "0x1809598B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorUpdatesListenStartRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x9599C0", Offset = "0x958DC0", VA = "0x1809599C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x959750", Offset = "0x958B50", VA = "0x180959750", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x959960", Offset = "0x958D60", VA = "0x180959960", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorUpdatesListenStartRequest other)
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x959D10", Offset = "0x959110", VA = "0x180959D10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
