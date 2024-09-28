using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006BB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseGenericItemRemovedEvent : IMessage<ExchangeBidHouseGenericItemRemovedEvent>, IMessage, IEquatable<ExchangeBidHouseGenericItemRemovedEvent>, IDeepCloneable<ExchangeBidHouseGenericItemRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4001797")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseGenericItemRemovedEvent> _parser;

	[Token(Token = "0x4001798")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001799")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x400179A")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x17000F79")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseGenericItemRemovedEvent> Parser
	{
		[Token(Token = "0x6004865")]
		[Address(RVA = "0xA9F8E0", Offset = "0xA9ECE0", VA = "0x180A9F8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004866")]
		[Address(RVA = "0xA9F830", Offset = "0xA9EC30", VA = "0x180A9F830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004867")]
		[Address(RVA = "0xA9F930", Offset = "0xA9ED30", VA = "0x180A9F930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F7C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x600486B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600486C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004868")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseGenericItemRemovedEvent()
	{
	}

	[Token(Token = "0x6004869")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseGenericItemRemovedEvent(ExchangeBidHouseGenericItemRemovedEvent other)
	{
	}

	[Token(Token = "0x600486A")]
	[Address(RVA = "0xA9F5C0", Offset = "0xA9E9C0", VA = "0x180A9F5C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseGenericItemRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600486D")]
	[Address(RVA = "0xA9F640", Offset = "0xA9EA40", VA = "0x180A9F640", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600486E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseGenericItemRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600486F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004870")]
	[Address(RVA = "0xA9F6D0", Offset = "0xA9EAD0", VA = "0x180A9F6D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004871")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004872")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004873")]
	[Address(RVA = "0xA9F530", Offset = "0xA9E930", VA = "0x180A9F530", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004874")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseGenericItemRemovedEvent other)
	{
	}

	[Token(Token = "0x6004875")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004876")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
