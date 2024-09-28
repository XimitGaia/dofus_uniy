using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006FF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeWeightEvent : IMessage<ExchangeWeightEvent>, IMessage, IEquatable<ExchangeWeightEvent>, IDeepCloneable<ExchangeWeightEvent>, IBufferMessage
{
	[Token(Token = "0x40018A4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeWeightEvent> _parser;

	[Token(Token = "0x40018A5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018A6")]
	public const int CurrentWeightFieldNumber = 1;

	[Token(Token = "0x40018A7")]
	[FieldOffset(Offset = "0x18")]
	private int currentWeight_;

	[Token(Token = "0x40018A8")]
	public const int MaxWeightFieldNumber = 2;

	[Token(Token = "0x40018A9")]
	[FieldOffset(Offset = "0x1C")]
	private int maxWeight_;

	[Token(Token = "0x17001017")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeWeightEvent> Parser
	{
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0xAC1410", Offset = "0xAC0810", VA = "0x180AC1410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001018")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0xAC1360", Offset = "0xAC0760", VA = "0x180AC1360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001019")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0xAC1460", Offset = "0xAC0860", VA = "0x180AC1460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700101A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurrentWeight
	{
		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700101B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxWeight
	{
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6004B28")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeWeightEvent()
	{
	}

	[Token(Token = "0x6004B29")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeWeightEvent(ExchangeWeightEvent other)
	{
	}

	[Token(Token = "0x6004B2A")]
	[Address(RVA = "0xAC10E0", Offset = "0xAC04E0", VA = "0x180AC10E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeWeightEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004B2F")]
	[Address(RVA = "0xAC1170", Offset = "0xAC0570", VA = "0x180AC1170", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B30")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeWeightEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B31")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004B32")]
	[Address(RVA = "0xAC1200", Offset = "0xAC0600", VA = "0x180AC1200", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004B33")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004B34")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004B35")]
	[Address(RVA = "0xAC1020", Offset = "0xAC0420", VA = "0x180AC1020", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004B36")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeWeightEvent other)
	{
	}

	[Token(Token = "0x6004B37")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004B38")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
