using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000648")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectMovePricedRequest : IMessage<ExchangeObjectMovePricedRequest>, IMessage, IEquatable<ExchangeObjectMovePricedRequest>, IDeepCloneable<ExchangeObjectMovePricedRequest>, IBufferMessage
{
	[Token(Token = "0x400161A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectMovePricedRequest> _parser;

	[Token(Token = "0x400161B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400161C")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x400161D")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x400161E")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x400161F")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x4001620")]
	public const int PriceFieldNumber = 3;

	[Token(Token = "0x4001621")]
	[FieldOffset(Offset = "0x20")]
	private long price_;

	[Token(Token = "0x17000E75")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeObjectMovePricedRequest> Parser
	{
		[Token(Token = "0x6004356")]
		[Address(RVA = "0xA6EC10", Offset = "0xA6E010", VA = "0x180A6EC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E76")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004357")]
		[Address(RVA = "0xA6EB60", Offset = "0xA6DF60", VA = "0x180A6EB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E77")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004358")]
		[Address(RVA = "0xA6EC60", Offset = "0xA6E060", VA = "0x180A6EC60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E78")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x600435C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600435D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E79")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Quantity
	{
		[Token(Token = "0x600435E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600435F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000E7A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Price
	{
		[Token(Token = "0x6004360")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004361")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6004359")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectMovePricedRequest()
	{
	}

	[Token(Token = "0x600435A")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectMovePricedRequest(ExchangeObjectMovePricedRequest other)
	{
	}

	[Token(Token = "0x600435B")]
	[Address(RVA = "0xA6E8D0", Offset = "0xA6DCD0", VA = "0x180A6E8D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectMovePricedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004362")]
	[Address(RVA = "0xA6E960", Offset = "0xA6DD60", VA = "0x180A6E960", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004363")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectMovePricedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004364")]
	[Address(RVA = "0x9625B0", Offset = "0x9619B0", VA = "0x1809625B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004365")]
	[Address(RVA = "0xA6EA00", Offset = "0xA6DE00", VA = "0x180A6EA00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004366")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004367")]
	[Address(RVA = "0xA26730", Offset = "0xA25B30", VA = "0x180A26730", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004368")]
	[Address(RVA = "0xA6E7F0", Offset = "0xA6DBF0", VA = "0x180A6E7F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004369")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectMovePricedRequest other)
	{
	}

	[Token(Token = "0x600436A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600436B")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
