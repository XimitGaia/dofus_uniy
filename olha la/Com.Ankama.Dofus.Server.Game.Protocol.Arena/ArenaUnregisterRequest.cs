using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000B8C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaUnregisterRequest : IMessage<ArenaUnregisterRequest>, IMessage, IEquatable<ArenaUnregisterRequest>, IDeepCloneable<ArenaUnregisterRequest>, IBufferMessage
{
	[Token(Token = "0x4002B14")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaUnregisterRequest> _parser;

	[Token(Token = "0x4002B15")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001ABB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaUnregisterRequest> Parser
	{
		[Token(Token = "0x600796D")]
		[Address(RVA = "0xC34700", Offset = "0xC33B00", VA = "0x180C34700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ABC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600796E")]
		[Address(RVA = "0xC34650", Offset = "0xC33A50", VA = "0x180C34650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ABD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600796F")]
		[Address(RVA = "0xC34750", Offset = "0xC33B50", VA = "0x180C34750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007970")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaUnregisterRequest()
	{
	}

	[Token(Token = "0x6007971")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaUnregisterRequest(ArenaUnregisterRequest other)
	{
	}

	[Token(Token = "0x6007972")]
	[Address(RVA = "0xC343F0", Offset = "0xC337F0", VA = "0x180C343F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaUnregisterRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007973")]
	[Address(RVA = "0xC34470", Offset = "0xC33870", VA = "0x180C34470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007974")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaUnregisterRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007975")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007976")]
	[Address(RVA = "0xC344F0", Offset = "0xC338F0", VA = "0x180C344F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007977")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007978")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007979")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600797A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ArenaUnregisterRequest other)
	{
	}

	[Token(Token = "0x600797B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600797C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
