using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000654")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectTransferAllFromInventoryRequest : IMessage<ExchangeObjectTransferAllFromInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferAllFromInventoryRequest>, IDeepCloneable<ExchangeObjectTransferAllFromInventoryRequest>, IBufferMessage
{
	[Token(Token = "0x400163E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectTransferAllFromInventoryRequest> _parser;

	[Token(Token = "0x400163F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000E8F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeObjectTransferAllFromInventoryRequest> Parser
	{
		[Token(Token = "0x60043DC")]
		[Address(RVA = "0xA8EF10", Offset = "0xA8E310", VA = "0x180A8EF10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60043DD")]
		[Address(RVA = "0xA8EE60", Offset = "0xA8E260", VA = "0x180A8EE60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E91")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60043DE")]
		[Address(RVA = "0xA8EF60", Offset = "0xA8E360", VA = "0x180A8EF60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60043DF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferAllFromInventoryRequest()
	{
	}

	[Token(Token = "0x60043E0")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferAllFromInventoryRequest(ExchangeObjectTransferAllFromInventoryRequest other)
	{
	}

	[Token(Token = "0x60043E1")]
	[Address(RVA = "0xA8EC00", Offset = "0xA8E000", VA = "0x180A8EC00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectTransferAllFromInventoryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60043E2")]
	[Address(RVA = "0xA8EC80", Offset = "0xA8E080", VA = "0x180A8EC80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043E3")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectTransferAllFromInventoryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043E4")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60043E5")]
	[Address(RVA = "0xA8ED00", Offset = "0xA8E100", VA = "0x180A8ED00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60043E6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60043E7")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60043E8")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60043E9")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeObjectTransferAllFromInventoryRequest other)
	{
	}

	[Token(Token = "0x60043EA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60043EB")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
