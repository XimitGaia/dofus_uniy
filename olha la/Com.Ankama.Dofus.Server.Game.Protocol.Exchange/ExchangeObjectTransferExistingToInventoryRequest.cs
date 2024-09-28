using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000652")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectTransferExistingToInventoryRequest : IMessage<ExchangeObjectTransferExistingToInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferExistingToInventoryRequest>, IDeepCloneable<ExchangeObjectTransferExistingToInventoryRequest>, IBufferMessage
{
	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectTransferExistingToInventoryRequest> _parser;

	[Token(Token = "0x400163C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000E8C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeObjectTransferExistingToInventoryRequest> Parser
	{
		[Token(Token = "0x60043C8")]
		[Address(RVA = "0xA8FBD0", Offset = "0xA8EFD0", VA = "0x180A8FBD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E8D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60043C9")]
		[Address(RVA = "0xA8FB20", Offset = "0xA8EF20", VA = "0x180A8FB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E8E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60043CA")]
		[Address(RVA = "0xA8FC20", Offset = "0xA8F020", VA = "0x180A8FC20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60043CB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectTransferExistingToInventoryRequest()
	{
	}

	[Token(Token = "0x60043CC")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferExistingToInventoryRequest(ExchangeObjectTransferExistingToInventoryRequest other)
	{
	}

	[Token(Token = "0x60043CD")]
	[Address(RVA = "0xA8F8C0", Offset = "0xA8ECC0", VA = "0x180A8F8C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferExistingToInventoryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60043CE")]
	[Address(RVA = "0xA8F940", Offset = "0xA8ED40", VA = "0x180A8F940", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043CF")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectTransferExistingToInventoryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043D0")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60043D1")]
	[Address(RVA = "0xA8F9C0", Offset = "0xA8EDC0", VA = "0x180A8F9C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60043D2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60043D3")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60043D4")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60043D5")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeObjectTransferExistingToInventoryRequest other)
	{
	}

	[Token(Token = "0x60043D6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60043D7")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
