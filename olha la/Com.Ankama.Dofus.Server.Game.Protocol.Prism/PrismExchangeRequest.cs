using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001B7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismExchangeRequest : IMessage<PrismExchangeRequest>, IMessage, IEquatable<PrismExchangeRequest>, IDeepCloneable<PrismExchangeRequest>, IBufferMessage
{
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismExchangeRequest> _parser;

	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170003B3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PrismExchangeRequest> Parser
	{
		[Token(Token = "0x6001160")]
		[Address(RVA = "0xCCFA60", Offset = "0xCCEE60", VA = "0x180CCFA60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001161")]
		[Address(RVA = "0xCCF9B0", Offset = "0xCCEDB0", VA = "0x180CCF9B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001162")]
		[Address(RVA = "0xCCFAB0", Offset = "0xCCEEB0", VA = "0x180CCFAB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001163")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismExchangeRequest()
	{
	}

	[Token(Token = "0x6001164")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismExchangeRequest(PrismExchangeRequest other)
	{
	}

	[Token(Token = "0x6001165")]
	[Address(RVA = "0xCCF750", Offset = "0xCCEB50", VA = "0x180CCF750", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismExchangeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001166")]
	[Address(RVA = "0xCCF7D0", Offset = "0xCCEBD0", VA = "0x180CCF7D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001167")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PrismExchangeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001168")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001169")]
	[Address(RVA = "0xCCF850", Offset = "0xCCEC50", VA = "0x180CCF850", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600116A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600116B")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600116C")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600116D")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PrismExchangeRequest other)
	{
	}

	[Token(Token = "0x600116E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600116F")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
