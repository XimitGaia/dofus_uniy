using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000676")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeSellRequest : IMessage<ExchangeSellRequest>, IMessage, IEquatable<ExchangeSellRequest>, IDeepCloneable<ExchangeSellRequest>, IBufferMessage
{
	[Token(Token = "0x4001696")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeSellRequest> _parser;

	[Token(Token = "0x4001697")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001698")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4001699")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x400169A")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x400169B")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x17000ED4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeSellRequest> Parser
	{
		[Token(Token = "0x6004553")]
		[Address(RVA = "0xA97930", Offset = "0xA96D30", VA = "0x180A97930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004554")]
		[Address(RVA = "0xA97880", Offset = "0xA96C80", VA = "0x180A97880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004555")]
		[Address(RVA = "0xA97980", Offset = "0xA96D80", VA = "0x180A97980", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000ED8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600455C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6004556")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeSellRequest()
	{
	}

	[Token(Token = "0x6004557")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeSellRequest(ExchangeSellRequest other)
	{
	}

	[Token(Token = "0x6004558")]
	[Address(RVA = "0xA97600", Offset = "0xA96A00", VA = "0x180A97600", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeSellRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600455D")]
	[Address(RVA = "0xA97690", Offset = "0xA96A90", VA = "0x180A97690", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600455E")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeSellRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600455F")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004560")]
	[Address(RVA = "0xA97720", Offset = "0xA96B20", VA = "0x180A97720", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004561")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004562")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004563")]
	[Address(RVA = "0xA97540", Offset = "0xA96940", VA = "0x180A97540", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004564")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeSellRequest other)
	{
	}

	[Token(Token = "0x6004565")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004566")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
