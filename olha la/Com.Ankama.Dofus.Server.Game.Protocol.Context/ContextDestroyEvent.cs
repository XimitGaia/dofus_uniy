using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x200078F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextDestroyEvent : IMessage<ContextDestroyEvent>, IMessage, IEquatable<ContextDestroyEvent>, IDeepCloneable<ContextDestroyEvent>, IBufferMessage
{
	[Token(Token = "0x4001A57")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextDestroyEvent> _parser;

	[Token(Token = "0x4001A58")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700112F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContextDestroyEvent> Parser
	{
		[Token(Token = "0x600506E")]
		[Address(RVA = "0xAD1620", Offset = "0xAD0A20", VA = "0x180AD1620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001130")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600506F")]
		[Address(RVA = "0xAD1570", Offset = "0xAD0970", VA = "0x180AD1570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001131")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005070")]
		[Address(RVA = "0xAD1670", Offset = "0xAD0A70", VA = "0x180AD1670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005071")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextDestroyEvent()
	{
	}

	[Token(Token = "0x6005072")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextDestroyEvent(ContextDestroyEvent other)
	{
	}

	[Token(Token = "0x6005073")]
	[Address(RVA = "0xAD1310", Offset = "0xAD0710", VA = "0x180AD1310", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextDestroyEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005074")]
	[Address(RVA = "0xAD1390", Offset = "0xAD0790", VA = "0x180AD1390", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005075")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContextDestroyEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005076")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005077")]
	[Address(RVA = "0xAD1410", Offset = "0xAD0810", VA = "0x180AD1410", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005078")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005079")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600507A")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600507B")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContextDestroyEvent other)
	{
	}

	[Token(Token = "0x600507C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600507D")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
