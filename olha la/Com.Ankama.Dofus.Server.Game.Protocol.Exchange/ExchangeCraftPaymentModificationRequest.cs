using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000672")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeCraftPaymentModificationRequest : IMessage<ExchangeCraftPaymentModificationRequest>, IMessage, IEquatable<ExchangeCraftPaymentModificationRequest>, IDeepCloneable<ExchangeCraftPaymentModificationRequest>, IBufferMessage
{
	[Token(Token = "0x400168A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeCraftPaymentModificationRequest> _parser;

	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400168C")]
	public const int QuantityFieldNumber = 1;

	[Token(Token = "0x400168D")]
	[FieldOffset(Offset = "0x18")]
	private long quantity_;

	[Token(Token = "0x17000ECB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeCraftPaymentModificationRequest> Parser
	{
		[Token(Token = "0x6004525")]
		[Address(RVA = "0xA89910", Offset = "0xA88D10", VA = "0x180A89910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ECC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004526")]
		[Address(RVA = "0xA89860", Offset = "0xA88C60", VA = "0x180A89860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ECD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004527")]
		[Address(RVA = "0xA89960", Offset = "0xA88D60", VA = "0x180A89960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ECE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Quantity
	{
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6004528")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftPaymentModificationRequest()
	{
	}

	[Token(Token = "0x6004529")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftPaymentModificationRequest(ExchangeCraftPaymentModificationRequest other)
	{
	}

	[Token(Token = "0x600452A")]
	[Address(RVA = "0xA895F0", Offset = "0xA889F0", VA = "0x180A895F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftPaymentModificationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600452D")]
	[Address(RVA = "0xA89670", Offset = "0xA88A70", VA = "0x180A89670", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600452E")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeCraftPaymentModificationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600452F")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004530")]
	[Address(RVA = "0xA89700", Offset = "0xA88B00", VA = "0x180A89700", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004531")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004532")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004533")]
	[Address(RVA = "0xA89560", Offset = "0xA88960", VA = "0x180A89560", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004534")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeCraftPaymentModificationRequest other)
	{
	}

	[Token(Token = "0x6004535")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004536")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
