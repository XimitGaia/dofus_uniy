using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200064C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectTransferAllToInventoryRequest : IMessage<ExchangeObjectTransferAllToInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferAllToInventoryRequest>, IDeepCloneable<ExchangeObjectTransferAllToInventoryRequest>, IBufferMessage
{
	[Token(Token = "0x400162C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectTransferAllToInventoryRequest> _parser;

	[Token(Token = "0x400162D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000E81")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectTransferAllToInventoryRequest> Parser
	{
		[Token(Token = "0x600438A")]
		[Address(RVA = "0xA8F350", Offset = "0xA8E750", VA = "0x180A8F350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E82")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600438B")]
		[Address(RVA = "0xA8F2A0", Offset = "0xA8E6A0", VA = "0x180A8F2A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E83")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600438C")]
		[Address(RVA = "0xA8F3A0", Offset = "0xA8E7A0", VA = "0x180A8F3A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600438D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferAllToInventoryRequest()
	{
	}

	[Token(Token = "0x600438E")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferAllToInventoryRequest(ExchangeObjectTransferAllToInventoryRequest other)
	{
	}

	[Token(Token = "0x600438F")]
	[Address(RVA = "0xA8F040", Offset = "0xA8E440", VA = "0x180A8F040", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferAllToInventoryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004390")]
	[Address(RVA = "0xA8F0C0", Offset = "0xA8E4C0", VA = "0x180A8F0C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004391")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectTransferAllToInventoryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004392")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004393")]
	[Address(RVA = "0xA8F140", Offset = "0xA8E540", VA = "0x180A8F140", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004394")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004395")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004396")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004397")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectTransferAllToInventoryRequest other)
	{
	}

	[Token(Token = "0x6004398")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004399")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
