using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200066A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeTaxCollectorRequest : IMessage<ExchangeTaxCollectorRequest>, IMessage, IEquatable<ExchangeTaxCollectorRequest>, IDeepCloneable<ExchangeTaxCollectorRequest>, IBufferMessage
{
	[Token(Token = "0x4001672")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeTaxCollectorRequest> _parser;

	[Token(Token = "0x4001673")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001674")]
	public const int TaxCollectorUuidFieldNumber = 1;

	[Token(Token = "0x4001675")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUuid_;

	[Token(Token = "0x17000EB9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeTaxCollectorRequest> Parser
	{
		[Token(Token = "0x60044C9")]
		[Address(RVA = "0xA987A0", Offset = "0xA97BA0", VA = "0x180A987A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0xA986F0", Offset = "0xA97AF0", VA = "0x180A986F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0xA988B0", Offset = "0xA97CB0", VA = "0x180A988B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TaxCollectorUuid
	{
		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60044D0")]
		[Address(RVA = "0xA98990", Offset = "0xA97D90", VA = "0x180A98990")]
		set
		{
		}
	}

	[Token(Token = "0x60044CC")]
	[Address(RVA = "0xA986A0", Offset = "0xA97AA0", VA = "0x180A986A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorRequest()
	{
	}

	[Token(Token = "0x60044CD")]
	[Address(RVA = "0xA98600", Offset = "0xA97A00", VA = "0x180A98600")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeTaxCollectorRequest(ExchangeTaxCollectorRequest other)
	{
	}

	[Token(Token = "0x60044CE")]
	[Address(RVA = "0xA982C0", Offset = "0xA976C0", VA = "0x180A982C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeTaxCollectorRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60044D1")]
	[Address(RVA = "0xA98390", Offset = "0xA97790", VA = "0x180A98390", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044D2")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeTaxCollectorRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044D3")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60044D4")]
	[Address(RVA = "0xA984A0", Offset = "0xA978A0", VA = "0x180A984A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60044D5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60044D6")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60044D7")]
	[Address(RVA = "0xA98230", Offset = "0xA97630", VA = "0x180A98230", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60044D8")]
	[Address(RVA = "0xA98440", Offset = "0xA97840", VA = "0x180A98440", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeTaxCollectorRequest other)
	{
	}

	[Token(Token = "0x60044D9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60044DA")]
	[Address(RVA = "0xA987F0", Offset = "0xA97BF0", VA = "0x180A987F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
