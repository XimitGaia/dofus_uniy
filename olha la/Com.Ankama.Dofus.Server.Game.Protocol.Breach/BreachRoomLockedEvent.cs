using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008FB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachRoomLockedEvent : IMessage<BreachRoomLockedEvent>, IMessage, IEquatable<BreachRoomLockedEvent>, IDeepCloneable<BreachRoomLockedEvent>, IBufferMessage
{
	[Token(Token = "0x4001EC2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachRoomLockedEvent> _parser;

	[Token(Token = "0x4001EC3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700141E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachRoomLockedEvent> Parser
	{
		[Token(Token = "0x6005F07")]
		[Address(RVA = "0xB55EE0", Offset = "0xB552E0", VA = "0x180B55EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700141F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005F08")]
		[Address(RVA = "0xB55E30", Offset = "0xB55230", VA = "0x180B55E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001420")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005F09")]
		[Address(RVA = "0xB55F30", Offset = "0xB55330", VA = "0x180B55F30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005F0A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRoomLockedEvent()
	{
	}

	[Token(Token = "0x6005F0B")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRoomLockedEvent(BreachRoomLockedEvent other)
	{
	}

	[Token(Token = "0x6005F0C")]
	[Address(RVA = "0xB55BD0", Offset = "0xB54FD0", VA = "0x180B55BD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachRoomLockedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005F0D")]
	[Address(RVA = "0xB55C50", Offset = "0xB55050", VA = "0x180B55C50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F0E")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BreachRoomLockedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005F0F")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005F10")]
	[Address(RVA = "0xB55CD0", Offset = "0xB550D0", VA = "0x180B55CD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005F11")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005F12")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005F13")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005F14")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachRoomLockedEvent other)
	{
	}

	[Token(Token = "0x6005F15")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005F16")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
