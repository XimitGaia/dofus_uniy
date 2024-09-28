using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000640")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectMoveRequest : IMessage<ExchangeObjectMoveRequest>, IMessage, IEquatable<ExchangeObjectMoveRequest>, IDeepCloneable<ExchangeObjectMoveRequest>, IBufferMessage
{
	[Token(Token = "0x40015FE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectMoveRequest> _parser;

	[Token(Token = "0x40015FF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001600")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4001601")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4001602")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4001603")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x17000E61")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectMoveRequest> Parser
	{
		[Token(Token = "0x60042F6")]
		[Address(RVA = "0xA6F130", Offset = "0xA6E530", VA = "0x180A6F130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E62")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60042F7")]
		[Address(RVA = "0xA6F080", Offset = "0xA6E480", VA = "0x180A6F080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E63")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60042F8")]
		[Address(RVA = "0xA6F180", Offset = "0xA6E580", VA = "0x180A6F180", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E64")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E65")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Quantity
	{
		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60042FF")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60042F9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectMoveRequest()
	{
	}

	[Token(Token = "0x60042FA")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectMoveRequest(ExchangeObjectMoveRequest other)
	{
	}

	[Token(Token = "0x60042FB")]
	[Address(RVA = "0xA6EE00", Offset = "0xA6E200", VA = "0x180A6EE00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectMoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004300")]
	[Address(RVA = "0xA6EE90", Offset = "0xA6E290", VA = "0x180A6EE90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004301")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectMoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004302")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004303")]
	[Address(RVA = "0xA6EF20", Offset = "0xA6E320", VA = "0x180A6EF20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004304")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004305")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004306")]
	[Address(RVA = "0xA6ED40", Offset = "0xA6E140", VA = "0x180A6ED40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004307")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeObjectMoveRequest other)
	{
	}

	[Token(Token = "0x6004308")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004309")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
