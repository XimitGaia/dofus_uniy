using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug;

[Token(Token = "0x200076F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DebugClearHighlightCellsEvent : IMessage<DebugClearHighlightCellsEvent>, IMessage, IEquatable<DebugClearHighlightCellsEvent>, IDeepCloneable<DebugClearHighlightCellsEvent>, IBufferMessage
{
	[Token(Token = "0x4001A04")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DebugClearHighlightCellsEvent> _parser;

	[Token(Token = "0x4001A05")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170010FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DebugClearHighlightCellsEvent> Parser
	{
		[Token(Token = "0x6004F74")]
		[Address(RVA = "0xAD7E90", Offset = "0xAD7290", VA = "0x180AD7E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010FF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004F75")]
		[Address(RVA = "0xAD7DE0", Offset = "0xAD71E0", VA = "0x180AD7DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001100")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004F76")]
		[Address(RVA = "0xAD7EE0", Offset = "0xAD72E0", VA = "0x180AD7EE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F77")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebugClearHighlightCellsEvent()
	{
	}

	[Token(Token = "0x6004F78")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DebugClearHighlightCellsEvent(DebugClearHighlightCellsEvent other)
	{
	}

	[Token(Token = "0x6004F79")]
	[Address(RVA = "0xAD7B80", Offset = "0xAD6F80", VA = "0x180AD7B80", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DebugClearHighlightCellsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004F7A")]
	[Address(RVA = "0xAD7C00", Offset = "0xAD7000", VA = "0x180AD7C00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F7B")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DebugClearHighlightCellsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F7C")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004F7D")]
	[Address(RVA = "0xAD7C80", Offset = "0xAD7080", VA = "0x180AD7C80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004F7E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004F7F")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004F80")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004F81")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DebugClearHighlightCellsEvent other)
	{
	}

	[Token(Token = "0x6004F82")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004F83")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
