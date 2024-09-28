using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x200005F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TitleSelectErrorEvent : IMessage<TitleSelectErrorEvent>, IMessage, IEquatable<TitleSelectErrorEvent>, IDeepCloneable<TitleSelectErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TitleSelectErrorEvent> _parser;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000136")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x18")]
	private TinselSelectError reason_;

	[Token(Token = "0x170000AA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TitleSelectErrorEvent> Parser
	{
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x9434B0", Offset = "0x9428B0", VA = "0x1809434B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x943400", Offset = "0x942800", VA = "0x180943400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x943500", Offset = "0x942900", VA = "0x180943500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TinselSelectError Reason
	{
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TinselSelectError);
		}
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitleSelectErrorEvent()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleSelectErrorEvent(TitleSelectErrorEvent other)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x943190", Offset = "0x942590", VA = "0x180943190", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleSelectErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x943210", Offset = "0x942610", VA = "0x180943210", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TitleSelectErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x9432A0", Offset = "0x9426A0", VA = "0x1809432A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x943100", Offset = "0x942500", VA = "0x180943100", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TitleSelectErrorEvent other)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
