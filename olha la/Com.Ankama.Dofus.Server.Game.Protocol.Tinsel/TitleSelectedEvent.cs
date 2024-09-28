using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x200005D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TitleSelectedEvent : IMessage<TitleSelectedEvent>, IMessage, IEquatable<TitleSelectedEvent>, IDeepCloneable<TitleSelectedEvent>, IBufferMessage
{
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TitleSelectedEvent> _parser;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000131")]
	public const int TitleIdFieldNumber = 1;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x18")]
	private int titleId_;

	[Token(Token = "0x170000A6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TitleSelectedEvent> Parser
	{
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x943990", Offset = "0x942D90", VA = "0x180943990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x9438E0", Offset = "0x942CE0", VA = "0x1809438E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x9439E0", Offset = "0x942DE0", VA = "0x1809439E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TitleId
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitleSelectedEvent()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitleSelectedEvent(TitleSelectedEvent other)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x943670", Offset = "0x942A70", VA = "0x180943670", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleSelectedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x9436F0", Offset = "0x942AF0", VA = "0x1809436F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TitleSelectedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x943780", Offset = "0x942B80", VA = "0x180943780", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x9435E0", Offset = "0x9429E0", VA = "0x1809435E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TitleSelectedEvent other)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
