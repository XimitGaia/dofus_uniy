using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006B9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseGenericItemAddedEvent : IMessage<ExchangeBidHouseGenericItemAddedEvent>, IMessage, IEquatable<ExchangeBidHouseGenericItemAddedEvent>, IDeepCloneable<ExchangeBidHouseGenericItemAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseGenericItemAddedEvent> _parser;

	[Token(Token = "0x4001793")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001794")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x17000F75")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseGenericItemAddedEvent> Parser
	{
		[Token(Token = "0x600484F")]
		[Address(RVA = "0xA9F400", Offset = "0xA9E800", VA = "0x180A9F400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F76")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004850")]
		[Address(RVA = "0xA9F350", Offset = "0xA9E750", VA = "0x180A9F350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F77")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004851")]
		[Address(RVA = "0xA9F450", Offset = "0xA9E850", VA = "0x180A9F450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F78")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x6004855")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004856")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004852")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseGenericItemAddedEvent()
	{
	}

	[Token(Token = "0x6004853")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseGenericItemAddedEvent(ExchangeBidHouseGenericItemAddedEvent other)
	{
	}

	[Token(Token = "0x6004854")]
	[Address(RVA = "0xA9F0E0", Offset = "0xA9E4E0", VA = "0x180A9F0E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseGenericItemAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004857")]
	[Address(RVA = "0xA9F160", Offset = "0xA9E560", VA = "0x180A9F160", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004858")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeBidHouseGenericItemAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004859")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600485A")]
	[Address(RVA = "0xA9F1F0", Offset = "0xA9E5F0", VA = "0x180A9F1F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600485B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600485C")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600485D")]
	[Address(RVA = "0xA9F050", Offset = "0xA9E450", VA = "0x180A9F050", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600485E")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseGenericItemAddedEvent other)
	{
	}

	[Token(Token = "0x600485F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004860")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
