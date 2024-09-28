using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B4E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class WhoIsNoMatchEvent : IMessage<WhoIsNoMatchEvent>, IMessage, IEquatable<WhoIsNoMatchEvent>, IDeepCloneable<WhoIsNoMatchEvent>, IBufferMessage
{
	[Token(Token = "0x4002A54")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<WhoIsNoMatchEvent> _parser;

	[Token(Token = "0x4002A55")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001A4C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<WhoIsNoMatchEvent> Parser
	{
		[Token(Token = "0x6007740")]
		[Address(RVA = "0xC2AEE0", Offset = "0xC2A2E0", VA = "0x180C2AEE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A4D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007741")]
		[Address(RVA = "0xC2AE30", Offset = "0xC2A230", VA = "0x180C2AE30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A4E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007742")]
		[Address(RVA = "0xC2AF30", Offset = "0xC2A330", VA = "0x180C2AF30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007743")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsNoMatchEvent()
	{
	}

	[Token(Token = "0x6007744")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsNoMatchEvent(WhoIsNoMatchEvent other)
	{
	}

	[Token(Token = "0x6007745")]
	[Address(RVA = "0xC2ABD0", Offset = "0xC29FD0", VA = "0x180C2ABD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsNoMatchEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007746")]
	[Address(RVA = "0xC2AC50", Offset = "0xC2A050", VA = "0x180C2AC50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007747")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WhoIsNoMatchEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007748")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007749")]
	[Address(RVA = "0xC2ACD0", Offset = "0xC2A0D0", VA = "0x180C2ACD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600774A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600774B")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600774C")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600774D")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WhoIsNoMatchEvent other)
	{
	}

	[Token(Token = "0x600774E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600774F")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
