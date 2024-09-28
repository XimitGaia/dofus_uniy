using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006AB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeStartedEvent : IMessage<ExchangeStartedEvent>, IMessage, IEquatable<ExchangeStartedEvent>, IDeepCloneable<ExchangeStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeStartedEvent> _parser;

	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001759")]
	public const int ExchangeTypeFieldNumber = 1;

	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x18")]
	private ExchangeType exchangeType_;

	[Token(Token = "0x17000F4D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeStartedEvent> Parser
	{
		[Token(Token = "0x600479D")]
		[Address(RVA = "0xAAB940", Offset = "0xAAAD40", VA = "0x180AAB940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F4E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600479E")]
		[Address(RVA = "0xAAB890", Offset = "0xAAAC90", VA = "0x180AAB890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F4F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600479F")]
		[Address(RVA = "0xAAB990", Offset = "0xAAAD90", VA = "0x180AAB990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeType ExchangeType
	{
		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ExchangeType);
		}
		[Token(Token = "0x60047A4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60047A0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedEvent()
	{
	}

	[Token(Token = "0x60047A1")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedEvent(ExchangeStartedEvent other)
	{
	}

	[Token(Token = "0x60047A2")]
	[Address(RVA = "0xAAB620", Offset = "0xAAAA20", VA = "0x180AAB620", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60047A5")]
	[Address(RVA = "0xAAB6A0", Offset = "0xAAAAA0", VA = "0x180AAB6A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60047A6")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60047A7")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60047A8")]
	[Address(RVA = "0xAAB730", Offset = "0xAAAB30", VA = "0x180AAB730", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60047A9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60047AA")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60047AB")]
	[Address(RVA = "0xAAB590", Offset = "0xAAA990", VA = "0x180AAB590", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60047AC")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeStartedEvent other)
	{
	}

	[Token(Token = "0x60047AD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60047AE")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
