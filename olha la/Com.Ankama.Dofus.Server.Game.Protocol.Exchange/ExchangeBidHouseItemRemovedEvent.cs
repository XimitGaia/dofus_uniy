using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006B7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseItemRemovedEvent : IMessage<ExchangeBidHouseItemRemovedEvent>, IMessage, IEquatable<ExchangeBidHouseItemRemovedEvent>, IDeepCloneable<ExchangeBidHouseItemRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseItemRemovedEvent> _parser;

	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400178F")]
	public const int SellIdFieldNumber = 1;

	[Token(Token = "0x4001790")]
	[FieldOffset(Offset = "0x18")]
	private int sellId_;

	[Token(Token = "0x17000F71")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeBidHouseItemRemovedEvent> Parser
	{
		[Token(Token = "0x6004839")]
		[Address(RVA = "0xAA2920", Offset = "0xAA1D20", VA = "0x180AA2920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F72")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600483A")]
		[Address(RVA = "0xAA2870", Offset = "0xAA1C70", VA = "0x180AA2870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F73")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600483B")]
		[Address(RVA = "0xAA2970", Offset = "0xAA1D70", VA = "0x180AA2970", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F74")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SellId
	{
		[Token(Token = "0x600483F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004840")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600483C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseItemRemovedEvent()
	{
	}

	[Token(Token = "0x600483D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseItemRemovedEvent(ExchangeBidHouseItemRemovedEvent other)
	{
	}

	[Token(Token = "0x600483E")]
	[Address(RVA = "0xAA2600", Offset = "0xAA1A00", VA = "0x180AA2600", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseItemRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004841")]
	[Address(RVA = "0xAA2680", Offset = "0xAA1A80", VA = "0x180AA2680", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004842")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseItemRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004843")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004844")]
	[Address(RVA = "0xAA2710", Offset = "0xAA1B10", VA = "0x180AA2710", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004845")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004846")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004847")]
	[Address(RVA = "0xAA2570", Offset = "0xAA1970", VA = "0x180AA2570", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004848")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseItemRemovedEvent other)
	{
	}

	[Token(Token = "0x6004849")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600484A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
