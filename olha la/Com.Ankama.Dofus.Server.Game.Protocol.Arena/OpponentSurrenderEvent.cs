using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BD7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OpponentSurrenderEvent : IMessage<OpponentSurrenderEvent>, IMessage, IEquatable<OpponentSurrenderEvent>, IDeepCloneable<OpponentSurrenderEvent>, IBufferMessage
{
	[Token(Token = "0x4002C03")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OpponentSurrenderEvent> _parser;

	[Token(Token = "0x4002C04")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001B5D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OpponentSurrenderEvent> Parser
	{
		[Token(Token = "0x6007C7A")]
		[Address(RVA = "0xC37940", Offset = "0xC36D40", VA = "0x180C37940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B5E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007C7B")]
		[Address(RVA = "0xC37890", Offset = "0xC36C90", VA = "0x180C37890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B5F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007C7C")]
		[Address(RVA = "0xC37990", Offset = "0xC36D90", VA = "0x180C37990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007C7D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpponentSurrenderEvent()
	{
	}

	[Token(Token = "0x6007C7E")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpponentSurrenderEvent(OpponentSurrenderEvent other)
	{
	}

	[Token(Token = "0x6007C7F")]
	[Address(RVA = "0xC37630", Offset = "0xC36A30", VA = "0x180C37630", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OpponentSurrenderEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007C80")]
	[Address(RVA = "0xC376B0", Offset = "0xC36AB0", VA = "0x180C376B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C81")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OpponentSurrenderEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C82")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007C83")]
	[Address(RVA = "0xC37730", Offset = "0xC36B30", VA = "0x180C37730", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007C84")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007C85")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007C86")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007C87")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OpponentSurrenderEvent other)
	{
	}

	[Token(Token = "0x6007C88")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007C89")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
