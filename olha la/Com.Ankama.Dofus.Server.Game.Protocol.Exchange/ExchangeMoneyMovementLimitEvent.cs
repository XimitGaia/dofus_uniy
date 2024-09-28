using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000691")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMoneyMovementLimitEvent : IMessage<ExchangeMoneyMovementLimitEvent>, IMessage, IEquatable<ExchangeMoneyMovementLimitEvent>, IDeepCloneable<ExchangeMoneyMovementLimitEvent>, IBufferMessage
{
	[Token(Token = "0x40016F7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMoneyMovementLimitEvent> _parser;

	[Token(Token = "0x40016F8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016F9")]
	public const int LimitFieldNumber = 1;

	[Token(Token = "0x40016FA")]
	[FieldOffset(Offset = "0x18")]
	private long limit_;

	[Token(Token = "0x17000F0B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeMoneyMovementLimitEvent> Parser
	{
		[Token(Token = "0x6004666")]
		[Address(RVA = "0xA8B690", Offset = "0xA8AA90", VA = "0x180A8B690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F0C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004667")]
		[Address(RVA = "0xA8B5E0", Offset = "0xA8A9E0", VA = "0x180A8B5E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F0D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004668")]
		[Address(RVA = "0xA8B6E0", Offset = "0xA8AAE0", VA = "0x180A8B6E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F0E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Limit
	{
		[Token(Token = "0x600466C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600466D")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6004669")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMoneyMovementLimitEvent()
	{
	}

	[Token(Token = "0x600466A")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMoneyMovementLimitEvent(ExchangeMoneyMovementLimitEvent other)
	{
	}

	[Token(Token = "0x600466B")]
	[Address(RVA = "0xA8B370", Offset = "0xA8A770", VA = "0x180A8B370", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMoneyMovementLimitEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600466E")]
	[Address(RVA = "0xA8B3F0", Offset = "0xA8A7F0", VA = "0x180A8B3F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600466F")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMoneyMovementLimitEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004670")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004671")]
	[Address(RVA = "0xA8B480", Offset = "0xA8A880", VA = "0x180A8B480", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004672")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004673")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004674")]
	[Address(RVA = "0xA8B2E0", Offset = "0xA8A6E0", VA = "0x180A8B2E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004675")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMoneyMovementLimitEvent other)
	{
	}

	[Token(Token = "0x6004676")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004677")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
