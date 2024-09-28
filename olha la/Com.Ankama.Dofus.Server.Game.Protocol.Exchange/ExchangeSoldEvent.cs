using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000705")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeSoldEvent : IMessage<ExchangeSoldEvent>, IMessage, IEquatable<ExchangeSoldEvent>, IDeepCloneable<ExchangeSoldEvent>, IBufferMessage
{
	[Token(Token = "0x40018C2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeSoldEvent> _parser;

	[Token(Token = "0x40018C3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700102A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeSoldEvent> Parser
	{
		[Token(Token = "0x6004B74")]
		[Address(RVA = "0xABFA30", Offset = "0xABEE30", VA = "0x180ABFA30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004B75")]
		[Address(RVA = "0xABF980", Offset = "0xABED80", VA = "0x180ABF980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700102C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004B76")]
		[Address(RVA = "0xABFA80", Offset = "0xABEE80", VA = "0x180ABFA80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B77")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeSoldEvent()
	{
	}

	[Token(Token = "0x6004B78")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeSoldEvent(ExchangeSoldEvent other)
	{
	}

	[Token(Token = "0x6004B79")]
	[Address(RVA = "0xABF720", Offset = "0xABEB20", VA = "0x180ABF720", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeSoldEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004B7A")]
	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", VA = "0x180ABF7A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B7B")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeSoldEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004B7C")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004B7D")]
	[Address(RVA = "0xABF820", Offset = "0xABEC20", VA = "0x180ABF820", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004B7E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004B7F")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004B80")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004B81")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeSoldEvent other)
	{
	}

	[Token(Token = "0x6004B82")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004B83")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
