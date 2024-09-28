using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006C5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseOfflineSoldItemsEvent : IMessage<ExchangeBidHouseOfflineSoldItemsEvent>, IMessage, IEquatable<ExchangeBidHouseOfflineSoldItemsEvent>, IDeepCloneable<ExchangeBidHouseOfflineSoldItemsEvent>, IBufferMessage
{
	[Token(Token = "0x40017C9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseOfflineSoldItemsEvent> _parser;

	[Token(Token = "0x40017CA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017CB")]
	public const int BidHouseItemsFieldNumber = 1;

	[Token(Token = "0x40017CC")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectGidWithQuantity> _repeated_bidHouseItems_codec;

	[Token(Token = "0x40017CD")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectGidWithQuantity> bidHouseItems_;

	[Token(Token = "0x17000F97")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeBidHouseOfflineSoldItemsEvent> Parser
	{
		[Token(Token = "0x60048E2")]
		[Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F98")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60048E3")]
		[Address(RVA = "0xAA30B0", Offset = "0xAA24B0", VA = "0x180AA30B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F99")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60048E4")]
		[Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F9A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectGidWithQuantity> BidHouseItems
	{
		[Token(Token = "0x60048E8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60048E5")]
	[Address(RVA = "0xAA2FA0", Offset = "0xAA23A0", VA = "0x180AA2FA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseOfflineSoldItemsEvent()
	{
	}

	[Token(Token = "0x60048E6")]
	[Address(RVA = "0xAA3020", Offset = "0xAA2420", VA = "0x180AA3020")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseOfflineSoldItemsEvent(ExchangeBidHouseOfflineSoldItemsEvent other)
	{
	}

	[Token(Token = "0x60048E7")]
	[Address(RVA = "0xAA2AF0", Offset = "0xAA1EF0", VA = "0x180AA2AF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseOfflineSoldItemsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60048E9")]
	[Address(RVA = "0xAA2C40", Offset = "0xAA2040", VA = "0x180AA2C40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60048EA")]
	[Address(RVA = "0xAA2BB0", Offset = "0xAA1FB0", VA = "0x180AA2BB0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseOfflineSoldItemsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60048EB")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60048EC")]
	[Address(RVA = "0xAA2DA0", Offset = "0xAA21A0", VA = "0x180AA2DA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60048ED")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60048EE")]
	[Address(RVA = "0xAA32C0", Offset = "0xAA26C0", VA = "0x180AA32C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60048EF")]
	[Address(RVA = "0xAA2A50", Offset = "0xAA1E50", VA = "0x180AA2A50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60048F0")]
	[Address(RVA = "0xAA2D20", Offset = "0xAA2120", VA = "0x180AA2D20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseOfflineSoldItemsEvent other)
	{
	}

	[Token(Token = "0x60048F1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60048F2")]
	[Address(RVA = "0xAA31B0", Offset = "0xAA25B0", VA = "0x180AA31B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
