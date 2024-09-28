using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200064A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectModifyPricedRequest : IMessage<ExchangeObjectModifyPricedRequest>, IMessage, IEquatable<ExchangeObjectModifyPricedRequest>, IDeepCloneable<ExchangeObjectModifyPricedRequest>, IBufferMessage
{
	[Token(Token = "0x4001623")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectModifyPricedRequest> _parser;

	[Token(Token = "0x4001624")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001625")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4001626")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4001627")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4001628")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x4001629")]
	public const int PriceFieldNumber = 3;

	[Token(Token = "0x400162A")]
	[FieldOffset(Offset = "0x20")]
	private long price_;

	[Token(Token = "0x17000E7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectModifyPricedRequest> Parser
	{
		[Token(Token = "0x6004370")]
		[Address(RVA = "0xA8D750", Offset = "0xA8CB50", VA = "0x180A8D750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004371")]
		[Address(RVA = "0xA8D6A0", Offset = "0xA8CAA0", VA = "0x180A8D6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004372")]
		[Address(RVA = "0xA8D7A0", Offset = "0xA8CBA0", VA = "0x180A8D7A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectUid
	{
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E7F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000E80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Price
	{
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6004373")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectModifyPricedRequest()
	{
	}

	[Token(Token = "0x6004374")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectModifyPricedRequest(ExchangeObjectModifyPricedRequest other)
	{
	}

	[Token(Token = "0x6004375")]
	[Address(RVA = "0xA8D410", Offset = "0xA8C810", VA = "0x180A8D410", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectModifyPricedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600437C")]
	[Address(RVA = "0xA8D4A0", Offset = "0xA8C8A0", VA = "0x180A8D4A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600437D")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectModifyPricedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600437E")]
	[Address(RVA = "0x9625B0", Offset = "0x9619B0", VA = "0x1809625B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600437F")]
	[Address(RVA = "0xA8D540", Offset = "0xA8C940", VA = "0x180A8D540", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004380")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004381")]
	[Address(RVA = "0xA26730", Offset = "0xA25B30", VA = "0x180A26730", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004382")]
	[Address(RVA = "0xA8D330", Offset = "0xA8C730", VA = "0x180A8D330", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004383")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeObjectModifyPricedRequest other)
	{
	}

	[Token(Token = "0x6004384")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004385")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
