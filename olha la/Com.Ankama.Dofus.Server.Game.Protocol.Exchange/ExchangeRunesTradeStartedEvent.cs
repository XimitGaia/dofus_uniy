using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006D5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeRunesTradeStartedEvent : IMessage<ExchangeRunesTradeStartedEvent>, IMessage, IEquatable<ExchangeRunesTradeStartedEvent>, IDeepCloneable<ExchangeRunesTradeStartedEvent>, IBufferMessage
{
	[Token(Token = "0x40017FD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeRunesTradeStartedEvent> _parser;

	[Token(Token = "0x40017FE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000FB5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeRunesTradeStartedEvent> Parser
	{
		[Token(Token = "0x600497F")]
		[Address(RVA = "0xAAB460", Offset = "0xAAA860", VA = "0x180AAB460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FB6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004980")]
		[Address(RVA = "0xAAB3B0", Offset = "0xAAA7B0", VA = "0x180AAB3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FB7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004981")]
		[Address(RVA = "0xAAB4B0", Offset = "0xAAA8B0", VA = "0x180AAB4B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004982")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeRunesTradeStartedEvent()
	{
	}

	[Token(Token = "0x6004983")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeRunesTradeStartedEvent(ExchangeRunesTradeStartedEvent other)
	{
	}

	[Token(Token = "0x6004984")]
	[Address(RVA = "0xAAB150", Offset = "0xAAA550", VA = "0x180AAB150", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeRunesTradeStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004985")]
	[Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004986")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeRunesTradeStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004987")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004988")]
	[Address(RVA = "0xAAB250", Offset = "0xAAA650", VA = "0x180AAB250", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004989")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600498A")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600498B")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600498C")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeRunesTradeStartedEvent other)
	{
	}

	[Token(Token = "0x600498D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600498E")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
