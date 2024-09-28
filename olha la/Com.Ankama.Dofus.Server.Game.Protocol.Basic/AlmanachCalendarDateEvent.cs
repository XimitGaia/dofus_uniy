using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B44")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlmanachCalendarDateEvent : IMessage<AlmanachCalendarDateEvent>, IMessage, IEquatable<AlmanachCalendarDateEvent>, IDeepCloneable<AlmanachCalendarDateEvent>, IBufferMessage
{
	[Token(Token = "0x4002A12")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AlmanachCalendarDateEvent> _parser;

	[Token(Token = "0x4002A13")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A14")]
	public const int DateIdFieldNumber = 1;

	[Token(Token = "0x4002A15")]
	[FieldOffset(Offset = "0x18")]
	private int dateId_;

	[Token(Token = "0x17001A2B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlmanachCalendarDateEvent> Parser
	{
		[Token(Token = "0x60076C8")]
		[Address(RVA = "0xC14940", Offset = "0xC13D40", VA = "0x180C14940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A2C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60076C9")]
		[Address(RVA = "0xC14890", Offset = "0xC13C90", VA = "0x180C14890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A2D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60076CA")]
		[Address(RVA = "0xC14990", Offset = "0xC13D90", VA = "0x180C14990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A2E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DateId
	{
		[Token(Token = "0x60076CE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60076CF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60076CB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlmanachCalendarDateEvent()
	{
	}

	[Token(Token = "0x60076CC")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlmanachCalendarDateEvent(AlmanachCalendarDateEvent other)
	{
	}

	[Token(Token = "0x60076CD")]
	[Address(RVA = "0xC14620", Offset = "0xC13A20", VA = "0x180C14620", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlmanachCalendarDateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60076D0")]
	[Address(RVA = "0xC146A0", Offset = "0xC13AA0", VA = "0x180C146A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60076D1")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlmanachCalendarDateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60076D2")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60076D3")]
	[Address(RVA = "0xC14730", Offset = "0xC13B30", VA = "0x180C14730", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60076D4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60076D5")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60076D6")]
	[Address(RVA = "0xC14590", Offset = "0xC13990", VA = "0x180C14590", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60076D7")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlmanachCalendarDateEvent other)
	{
	}

	[Token(Token = "0x60076D8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60076D9")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
