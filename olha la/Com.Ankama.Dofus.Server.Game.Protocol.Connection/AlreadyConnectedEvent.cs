using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x200081B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlreadyConnectedEvent : IMessage<AlreadyConnectedEvent>, IMessage, IEquatable<AlreadyConnectedEvent>, IDeepCloneable<AlreadyConnectedEvent>, IBufferMessage
{
	[Token(Token = "0x4001C01")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AlreadyConnectedEvent> _parser;

	[Token(Token = "0x4001C02")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001255")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlreadyConnectedEvent> Parser
	{
		[Token(Token = "0x6005617")]
		[Address(RVA = "0xAFABB0", Offset = "0xAF9FB0", VA = "0x180AFABB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001256")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005618")]
		[Address(RVA = "0xAFAB00", Offset = "0xAF9F00", VA = "0x180AFAB00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001257")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005619")]
		[Address(RVA = "0xAFAC00", Offset = "0xAFA000", VA = "0x180AFAC00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600561A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlreadyConnectedEvent()
	{
	}

	[Token(Token = "0x600561B")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlreadyConnectedEvent(AlreadyConnectedEvent other)
	{
	}

	[Token(Token = "0x600561C")]
	[Address(RVA = "0xAFA8A0", Offset = "0xAF9CA0", VA = "0x180AFA8A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlreadyConnectedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600561D")]
	[Address(RVA = "0xAFA920", Offset = "0xAF9D20", VA = "0x180AFA920", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600561E")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlreadyConnectedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600561F")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005620")]
	[Address(RVA = "0xAFA9A0", Offset = "0xAF9DA0", VA = "0x180AFA9A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005621")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005622")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005623")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005624")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlreadyConnectedEvent other)
	{
	}

	[Token(Token = "0x6005625")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005626")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
