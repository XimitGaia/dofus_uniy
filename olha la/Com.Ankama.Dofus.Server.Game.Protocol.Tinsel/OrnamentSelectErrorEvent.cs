using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x2000063")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OrnamentSelectErrorEvent : IMessage<OrnamentSelectErrorEvent>, IMessage, IEquatable<OrnamentSelectErrorEvent>, IDeepCloneable<OrnamentSelectErrorEvent>, IBufferMessage
{
	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OrnamentSelectErrorEvent> _parser;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000140")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x18")]
	private TinselSelectError reason_;

	[Token(Token = "0x170000B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OrnamentSelectErrorEvent> Parser
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x952FE0", Offset = "0x9523E0", VA = "0x180952FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x952F30", Offset = "0x952330", VA = "0x180952F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x953030", Offset = "0x952430", VA = "0x180953030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TinselSelectError Reason
	{
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TinselSelectError);
		}
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OrnamentSelectErrorEvent()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OrnamentSelectErrorEvent(OrnamentSelectErrorEvent other)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x952CC0", Offset = "0x9520C0", VA = "0x180952CC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OrnamentSelectErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x952D40", Offset = "0x952140", VA = "0x180952D40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OrnamentSelectErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x952DD0", Offset = "0x9521D0", VA = "0x180952DD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x952C30", Offset = "0x952030", VA = "0x180952C30", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OrnamentSelectErrorEvent other)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
