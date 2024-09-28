using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002B1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddocksToSellRequest : IMessage<PaddocksToSellRequest>, IMessage, IEquatable<PaddocksToSellRequest>, IDeepCloneable<PaddocksToSellRequest>, IBufferMessage
{
	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddocksToSellRequest> _parser;

	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000979")]
	public const int PageIndexFieldNumber = 1;

	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x18")]
	private int pageIndex_;

	[Token(Token = "0x17000609")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PaddocksToSellRequest> Parser
	{
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0xD0E9F0", Offset = "0xD0DDF0", VA = "0x180D0E9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0xD0E940", Offset = "0xD0DD40", VA = "0x180D0E940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0xD0EA40", Offset = "0xD0DE40", VA = "0x180D0EA40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PageIndex
	{
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddocksToSellRequest()
	{
	}

	[Token(Token = "0x6001C03")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddocksToSellRequest(PaddocksToSellRequest other)
	{
	}

	[Token(Token = "0x6001C04")]
	[Address(RVA = "0xD0E6D0", Offset = "0xD0DAD0", VA = "0x180D0E6D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddocksToSellRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001C07")]
	[Address(RVA = "0xD0E750", Offset = "0xD0DB50", VA = "0x180D0E750", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C08")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddocksToSellRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C09")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001C0A")]
	[Address(RVA = "0xD0E7E0", Offset = "0xD0DBE0", VA = "0x180D0E7E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001C0C")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001C0D")]
	[Address(RVA = "0xD0E640", Offset = "0xD0DA40", VA = "0x180D0E640", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001C0E")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PaddocksToSellRequest other)
	{
	}

	[Token(Token = "0x6001C0F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001C10")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
