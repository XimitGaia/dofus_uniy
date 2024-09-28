using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200068B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHousePriceRequest : IMessage<ExchangeBidHousePriceRequest>, IMessage, IEquatable<ExchangeBidHousePriceRequest>, IDeepCloneable<ExchangeBidHousePriceRequest>, IBufferMessage
{
	[Token(Token = "0x40016EA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHousePriceRequest> _parser;

	[Token(Token = "0x40016EB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016EC")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x40016ED")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x17000F00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHousePriceRequest> Parser
	{
		[Token(Token = "0x6004626")]
		[Address(RVA = "0xA879F0", Offset = "0xA86DF0", VA = "0x180A879F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F01")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004627")]
		[Address(RVA = "0xA87940", Offset = "0xA86D40", VA = "0x180A87940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F02")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004628")]
		[Address(RVA = "0xA87A40", Offset = "0xA86E40", VA = "0x180A87A40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F03")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x600462C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600462D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004629")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHousePriceRequest()
	{
	}

	[Token(Token = "0x600462A")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHousePriceRequest(ExchangeBidHousePriceRequest other)
	{
	}

	[Token(Token = "0x600462B")]
	[Address(RVA = "0xA876D0", Offset = "0xA86AD0", VA = "0x180A876D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHousePriceRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600462E")]
	[Address(RVA = "0xA87750", Offset = "0xA86B50", VA = "0x180A87750", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600462F")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHousePriceRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004630")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004631")]
	[Address(RVA = "0xA877E0", Offset = "0xA86BE0", VA = "0x180A877E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004632")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004633")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004634")]
	[Address(RVA = "0xA87640", Offset = "0xA86A40", VA = "0x180A87640", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004635")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHousePriceRequest other)
	{
	}

	[Token(Token = "0x6004636")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004637")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
