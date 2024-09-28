using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000721")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeCraftPaymentModifiedEvent : IMessage<ExchangeCraftPaymentModifiedEvent>, IMessage, IEquatable<ExchangeCraftPaymentModifiedEvent>, IDeepCloneable<ExchangeCraftPaymentModifiedEvent>, IBufferMessage
{
	[Token(Token = "0x4001919")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeCraftPaymentModifiedEvent> _parser;

	[Token(Token = "0x400191A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400191B")]
	public const int KamasFieldNumber = 1;

	[Token(Token = "0x400191C")]
	[FieldOffset(Offset = "0x18")]
	private long kamas_;

	[Token(Token = "0x17001063")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeCraftPaymentModifiedEvent> Parser
	{
		[Token(Token = "0x6004C95")]
		[Address(RVA = "0xAB8E50", Offset = "0xAB8250", VA = "0x180AB8E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001064")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004C96")]
		[Address(RVA = "0xAB8DA0", Offset = "0xAB81A0", VA = "0x180AB8DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001065")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004C97")]
		[Address(RVA = "0xAB8EA0", Offset = "0xAB82A0", VA = "0x180AB8EA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001066")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Kamas
	{
		[Token(Token = "0x6004C9B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6004C98")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftPaymentModifiedEvent()
	{
	}

	[Token(Token = "0x6004C99")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftPaymentModifiedEvent(ExchangeCraftPaymentModifiedEvent other)
	{
	}

	[Token(Token = "0x6004C9A")]
	[Address(RVA = "0xAB8B30", Offset = "0xAB7F30", VA = "0x180AB8B30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeCraftPaymentModifiedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004C9D")]
	[Address(RVA = "0xAB8BB0", Offset = "0xAB7FB0", VA = "0x180AB8BB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C9E")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeCraftPaymentModifiedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C9F")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004CA0")]
	[Address(RVA = "0xAB8C40", Offset = "0xAB8040", VA = "0x180AB8C40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004CA1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004CA2")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004CA3")]
	[Address(RVA = "0xAB8AA0", Offset = "0xAB7EA0", VA = "0x180AB8AA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004CA4")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeCraftPaymentModifiedEvent other)
	{
	}

	[Token(Token = "0x6004CA5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004CA6")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
