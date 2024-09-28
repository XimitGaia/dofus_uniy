using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000674")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBuyRequest : IMessage<ExchangeBuyRequest>, IMessage, IEquatable<ExchangeBuyRequest>, IDeepCloneable<ExchangeBuyRequest>, IBufferMessage
{
	[Token(Token = "0x400168F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBuyRequest> _parser;

	[Token(Token = "0x4001690")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001691")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4001692")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4001693")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4001694")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x17000ECF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeBuyRequest> Parser
	{
		[Token(Token = "0x600453B")]
		[Address(RVA = "0xA88A70", Offset = "0xA87E70", VA = "0x180A88A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600453C")]
		[Address(RVA = "0xA889C0", Offset = "0xA87DC0", VA = "0x180A889C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600453D")]
		[Address(RVA = "0xA88AC0", Offset = "0xA87EC0", VA = "0x180A88AC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004542")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000ED3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Quantity
	{
		[Token(Token = "0x6004543")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004544")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600453E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBuyRequest()
	{
	}

	[Token(Token = "0x600453F")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBuyRequest(ExchangeBuyRequest other)
	{
	}

	[Token(Token = "0x6004540")]
	[Address(RVA = "0xA88740", Offset = "0xA87B40", VA = "0x180A88740", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBuyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004545")]
	[Address(RVA = "0xA887D0", Offset = "0xA87BD0", VA = "0x180A887D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004546")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBuyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004547")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004548")]
	[Address(RVA = "0xA88860", Offset = "0xA87C60", VA = "0x180A88860", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004549")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600454A")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600454B")]
	[Address(RVA = "0xA88680", Offset = "0xA87A80", VA = "0x180A88680", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600454C")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBuyRequest other)
	{
	}

	[Token(Token = "0x600454D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600454E")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
