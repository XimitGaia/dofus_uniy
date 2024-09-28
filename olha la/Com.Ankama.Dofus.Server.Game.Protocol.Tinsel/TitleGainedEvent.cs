using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x2000055")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TitleGainedEvent : IMessage<TitleGainedEvent>, IMessage, IEquatable<TitleGainedEvent>, IDeepCloneable<TitleGainedEvent>, IBufferMessage
{
	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TitleGainedEvent> _parser;

	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400011D")]
	public const int TitleIdFieldNumber = 1;

	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x18")]
	private int titleId_;

	[Token(Token = "0x17000096")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TitleGainedEvent> Parser
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x942AF0", Offset = "0x941EF0", VA = "0x180942AF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000097")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x942A40", Offset = "0x941E40", VA = "0x180942A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000098")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x942B40", Offset = "0x941F40", VA = "0x180942B40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000099")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TitleId
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleGainedEvent()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleGainedEvent(TitleGainedEvent other)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x9427D0", Offset = "0x941BD0", VA = "0x1809427D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleGainedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x942850", Offset = "0x941C50", VA = "0x180942850", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TitleGainedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x9428E0", Offset = "0x941CE0", VA = "0x1809428E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x942740", Offset = "0x941B40", VA = "0x180942740", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TitleGainedEvent other)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
