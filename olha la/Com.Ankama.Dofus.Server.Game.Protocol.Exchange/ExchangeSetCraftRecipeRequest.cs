using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000642")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeSetCraftRecipeRequest : IMessage<ExchangeSetCraftRecipeRequest>, IMessage, IEquatable<ExchangeSetCraftRecipeRequest>, IDeepCloneable<ExchangeSetCraftRecipeRequest>, IBufferMessage
{
	[Token(Token = "0x4001605")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeSetCraftRecipeRequest> _parser;

	[Token(Token = "0x4001606")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001607")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4001608")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x17000E66")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeSetCraftRecipeRequest> Parser
	{
		[Token(Token = "0x600430E")]
		[Address(RVA = "0xA7B8F0", Offset = "0xA7ACF0", VA = "0x180A7B8F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E67")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600430F")]
		[Address(RVA = "0xA7B840", Offset = "0xA7AC40", VA = "0x180A7B840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E68")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004310")]
		[Address(RVA = "0xA7B940", Offset = "0xA7AD40", VA = "0x180A7B940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E69")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x6004314")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004315")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004311")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeSetCraftRecipeRequest()
	{
	}

	[Token(Token = "0x6004312")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeSetCraftRecipeRequest(ExchangeSetCraftRecipeRequest other)
	{
	}

	[Token(Token = "0x6004313")]
	[Address(RVA = "0xA7B5D0", Offset = "0xA7A9D0", VA = "0x180A7B5D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeSetCraftRecipeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004316")]
	[Address(RVA = "0xA7B650", Offset = "0xA7AA50", VA = "0x180A7B650", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004317")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeSetCraftRecipeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004318")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004319")]
	[Address(RVA = "0xA7B6E0", Offset = "0xA7AAE0", VA = "0x180A7B6E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600431A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600431B")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600431C")]
	[Address(RVA = "0xA7B540", Offset = "0xA7A940", VA = "0x180A7B540", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600431D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeSetCraftRecipeRequest other)
	{
	}

	[Token(Token = "0x600431E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600431F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
