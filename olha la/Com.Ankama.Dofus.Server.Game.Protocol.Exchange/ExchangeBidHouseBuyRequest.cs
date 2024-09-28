using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000689")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseBuyRequest : IMessage<ExchangeBidHouseBuyRequest>, IMessage, IEquatable<ExchangeBidHouseBuyRequest>, IDeepCloneable<ExchangeBidHouseBuyRequest>, IBufferMessage
{
	[Token(Token = "0x40016E1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseBuyRequest> _parser;

	[Token(Token = "0x40016E2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016E3")]
	public const int BidItemUidFieldNumber = 1;

	[Token(Token = "0x40016E4")]
	[FieldOffset(Offset = "0x18")]
	private int bidItemUid_;

	[Token(Token = "0x40016E5")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x40016E6")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x40016E7")]
	public const int PriceFieldNumber = 3;

	[Token(Token = "0x40016E8")]
	[FieldOffset(Offset = "0x20")]
	private long price_;

	[Token(Token = "0x17000EFA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseBuyRequest> Parser
	{
		[Token(Token = "0x600460C")]
		[Address(RVA = "0xA86F60", Offset = "0xA86360", VA = "0x180A86F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EFB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600460D")]
		[Address(RVA = "0xA86EB0", Offset = "0xA862B0", VA = "0x180A86EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EFC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600460E")]
		[Address(RVA = "0xA86FB0", Offset = "0xA863B0", VA = "0x180A86FB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EFD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BidItemUid
	{
		[Token(Token = "0x6004612")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004613")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000EFE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x6004614")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004615")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000EFF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Price
	{
		[Token(Token = "0x6004616")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004617")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600460F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseBuyRequest()
	{
	}

	[Token(Token = "0x6004610")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseBuyRequest(ExchangeBidHouseBuyRequest other)
	{
	}

	[Token(Token = "0x6004611")]
	[Address(RVA = "0xA86C20", Offset = "0xA86020", VA = "0x180A86C20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseBuyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004618")]
	[Address(RVA = "0xA86CB0", Offset = "0xA860B0", VA = "0x180A86CB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004619")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseBuyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600461A")]
	[Address(RVA = "0x9625B0", Offset = "0x9619B0", VA = "0x1809625B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600461B")]
	[Address(RVA = "0xA86D50", Offset = "0xA86150", VA = "0x180A86D50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600461C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600461D")]
	[Address(RVA = "0xA26730", Offset = "0xA25B30", VA = "0x180A26730", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600461E")]
	[Address(RVA = "0xA86B40", Offset = "0xA85F40", VA = "0x180A86B40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600461F")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseBuyRequest other)
	{
	}

	[Token(Token = "0x6004620")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004621")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
