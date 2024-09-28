using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006F1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidBuyerStartedEvent : IMessage<ExchangeBidBuyerStartedEvent>, IMessage, IEquatable<ExchangeBidBuyerStartedEvent>, IDeepCloneable<ExchangeBidBuyerStartedEvent>, IBufferMessage
{
	[Token(Token = "0x400186D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidBuyerStartedEvent> _parser;

	[Token(Token = "0x400186E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400186F")]
	public const int SellingConditionsFieldNumber = 1;

	[Token(Token = "0x4001870")]
	[FieldOffset(Offset = "0x18")]
	private SellingConditions sellingConditions_;

	[Token(Token = "0x17000FF5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidBuyerStartedEvent> Parser
	{
		[Token(Token = "0x6004A92")]
		[Address(RVA = "0xA9E870", Offset = "0xA9DC70", VA = "0x180A9E870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FF6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004A93")]
		[Address(RVA = "0xA9E7C0", Offset = "0xA9DBC0", VA = "0x180A9E7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FF7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004A94")]
		[Address(RVA = "0xA9E9C0", Offset = "0xA9DDC0", VA = "0x180A9E9C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FF8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SellingConditions SellingConditions
	{
		[Token(Token = "0x6004A98")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A99")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6004A95")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidBuyerStartedEvent()
	{
	}

	[Token(Token = "0x6004A96")]
	[Address(RVA = "0xA9E750", Offset = "0xA9DB50", VA = "0x180A9E750")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidBuyerStartedEvent(ExchangeBidBuyerStartedEvent other)
	{
	}

	[Token(Token = "0x6004A97")]
	[Address(RVA = "0xA9E3D0", Offset = "0xA9D7D0", VA = "0x180A9E3D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidBuyerStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004A9A")]
	[Address(RVA = "0xA9E470", Offset = "0xA9D870", VA = "0x180A9E470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A9B")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidBuyerStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A9C")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004A9D")]
	[Address(RVA = "0xA9E5F0", Offset = "0xA9D9F0", VA = "0x180A9E5F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004A9E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004A9F")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004AA0")]
	[Address(RVA = "0xA9E340", Offset = "0xA9D740", VA = "0x180A9E340", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004AA1")]
	[Address(RVA = "0xA9E520", Offset = "0xA9D920", VA = "0x180A9E520", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeBidBuyerStartedEvent other)
	{
	}

	[Token(Token = "0x6004AA2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004AA3")]
	[Address(RVA = "0xA9E8C0", Offset = "0xA9DCC0", VA = "0x180A9E8C0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
