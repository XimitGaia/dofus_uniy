using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200066C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeAcceptRequest : IMessage<ExchangeAcceptRequest>, IMessage, IEquatable<ExchangeAcceptRequest>, IDeepCloneable<ExchangeAcceptRequest>, IBufferMessage
{
	[Token(Token = "0x4001677")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeAcceptRequest> _parser;

	[Token(Token = "0x4001678")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000EBD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeAcceptRequest> Parser
	{
		[Token(Token = "0x60044DF")]
		[Address(RVA = "0xA86A10", Offset = "0xA85E10", VA = "0x180A86A10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60044E0")]
		[Address(RVA = "0xA86960", Offset = "0xA85D60", VA = "0x180A86960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EBF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60044E1")]
		[Address(RVA = "0xA86A60", Offset = "0xA85E60", VA = "0x180A86A60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60044E2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeAcceptRequest()
	{
	}

	[Token(Token = "0x60044E3")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeAcceptRequest(ExchangeAcceptRequest other)
	{
	}

	[Token(Token = "0x60044E4")]
	[Address(RVA = "0xA86700", Offset = "0xA85B00", VA = "0x180A86700", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeAcceptRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60044E5")]
	[Address(RVA = "0xA86780", Offset = "0xA85B80", VA = "0x180A86780", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044E6")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeAcceptRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044E7")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60044E8")]
	[Address(RVA = "0xA86800", Offset = "0xA85C00", VA = "0x180A86800", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60044E9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60044EA")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60044EB")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60044EC")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeAcceptRequest other)
	{
	}

	[Token(Token = "0x60044ED")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60044EE")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
