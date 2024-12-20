using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200065A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectTransferExistingFromInventoryRequest : IMessage<ExchangeObjectTransferExistingFromInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferExistingFromInventoryRequest>, IDeepCloneable<ExchangeObjectTransferExistingFromInventoryRequest>, IBufferMessage
{
	[Token(Token = "0x400164C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectTransferExistingFromInventoryRequest> _parser;

	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000E9A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectTransferExistingFromInventoryRequest> Parser
	{
		[Token(Token = "0x600441B")]
		[Address(RVA = "0xA8F790", Offset = "0xA8EB90", VA = "0x180A8F790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E9B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600441C")]
		[Address(RVA = "0xA8F6E0", Offset = "0xA8EAE0", VA = "0x180A8F6E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E9C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600441D")]
		[Address(RVA = "0xA8F7E0", Offset = "0xA8EBE0", VA = "0x180A8F7E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600441E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectTransferExistingFromInventoryRequest()
	{
	}

	[Token(Token = "0x600441F")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectTransferExistingFromInventoryRequest(ExchangeObjectTransferExistingFromInventoryRequest other)
	{
	}

	[Token(Token = "0x6004420")]
	[Address(RVA = "0xA8F480", Offset = "0xA8E880", VA = "0x180A8F480", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferExistingFromInventoryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004421")]
	[Address(RVA = "0xA8F500", Offset = "0xA8E900", VA = "0x180A8F500", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004422")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectTransferExistingFromInventoryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004423")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004424")]
	[Address(RVA = "0xA8F580", Offset = "0xA8E980", VA = "0x180A8F580", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004425")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004426")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004427")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004428")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectTransferExistingFromInventoryRequest other)
	{
	}

	[Token(Token = "0x6004429")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600442A")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
