using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000C6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorFightRequest : IMessage<TaxCollectorFightRequest>, IMessage, IEquatable<TaxCollectorFightRequest>, IDeepCloneable<TaxCollectorFightRequest>, IBufferMessage
{
	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorFightRequest> _parser;

	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170001A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorFightRequest> Parser
	{
		[Token(Token = "0x6000793")]
		[Address(RVA = "0xA65C80", Offset = "0xA65080", VA = "0x180A65C80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000794")]
		[Address(RVA = "0xA65BD0", Offset = "0xA64FD0", VA = "0x180A65BD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000795")]
		[Address(RVA = "0xA65CD0", Offset = "0xA650D0", VA = "0x180A65CD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorFightRequest()
	{
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorFightRequest(TaxCollectorFightRequest other)
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0xA65970", Offset = "0xA64D70", VA = "0x180A65970", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorFightRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0xA659F0", Offset = "0xA64DF0", VA = "0x180A659F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorFightRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0xA65A70", Offset = "0xA64E70", VA = "0x180A65A70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600079D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorFightRequest other)
	{
	}

	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
