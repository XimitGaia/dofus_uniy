using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000703")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBoughtEvent : IMessage<ExchangeBoughtEvent>, IMessage, IEquatable<ExchangeBoughtEvent>, IDeepCloneable<ExchangeBoughtEvent>, IBufferMessage
{
	[Token(Token = "0x40018BF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBoughtEvent> _parser;

	[Token(Token = "0x40018C0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001027")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeBoughtEvent> Parser
	{
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0xAB8970", Offset = "0xAB7D70", VA = "0x180AB8970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001028")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0xAB88C0", Offset = "0xAB7CC0", VA = "0x180AB88C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001029")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0xAB89C0", Offset = "0xAB7DC0", VA = "0x180AB89C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B63")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBoughtEvent()
	{
	}

	[Token(Token = "0x6004B64")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBoughtEvent(ExchangeBoughtEvent other)
	{
	}

	[Token(Token = "0x6004B65")]
	[Address(RVA = "0xAB8660", Offset = "0xAB7A60", VA = "0x180AB8660", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBoughtEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004B66")]
	[Address(RVA = "0xAB86E0", Offset = "0xAB7AE0", VA = "0x180AB86E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B67")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBoughtEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B68")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004B69")]
	[Address(RVA = "0xAB8760", Offset = "0xAB7B60", VA = "0x180AB8760", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004B6A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004B6B")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004B6C")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004B6D")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBoughtEvent other)
	{
	}

	[Token(Token = "0x6004B6E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004B6F")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
