using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x2000057")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TitleLostEvent : IMessage<TitleLostEvent>, IMessage, IEquatable<TitleLostEvent>, IDeepCloneable<TitleLostEvent>, IBufferMessage
{
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TitleLostEvent> _parser;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000122")]
	public const int TitleIdFieldNumber = 1;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x18")]
	private int titleId_;

	[Token(Token = "0x1700009A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TitleLostEvent> Parser
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x942FD0", Offset = "0x9423D0", VA = "0x180942FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x942F20", Offset = "0x942320", VA = "0x180942F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x943020", Offset = "0x942420", VA = "0x180943020", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TitleId
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitleLostEvent()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleLostEvent(TitleLostEvent other)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x942CB0", Offset = "0x9420B0", VA = "0x180942CB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleLostEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x942D30", Offset = "0x942130", VA = "0x180942D30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TitleLostEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x942DC0", Offset = "0x9421C0", VA = "0x180942DC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x942C20", Offset = "0x942020", VA = "0x180942C20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TitleLostEvent other)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
