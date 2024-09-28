using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification;

[Token(Token = "0x2000828")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServerSessionReadyEvent : IMessage<ServerSessionReadyEvent>, IMessage, IEquatable<ServerSessionReadyEvent>, IDeepCloneable<ServerSessionReadyEvent>, IBufferMessage
{
	[Token(Token = "0x4001C25")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ServerSessionReadyEvent> _parser;

	[Token(Token = "0x4001C26")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001270")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerSessionReadyEvent> Parser
	{
		[Token(Token = "0x60056A0")]
		[Address(RVA = "0xB111C0", Offset = "0xB105C0", VA = "0x180B111C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001271")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60056A1")]
		[Address(RVA = "0xB11110", Offset = "0xB10510", VA = "0x180B11110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001272")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60056A2")]
		[Address(RVA = "0xB11210", Offset = "0xB10610", VA = "0x180B11210", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60056A3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerSessionReadyEvent()
	{
	}

	[Token(Token = "0x60056A4")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerSessionReadyEvent(ServerSessionReadyEvent other)
	{
	}

	[Token(Token = "0x60056A5")]
	[Address(RVA = "0xB10EB0", Offset = "0xB102B0", VA = "0x180B10EB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerSessionReadyEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60056A6")]
	[Address(RVA = "0xB10F30", Offset = "0xB10330", VA = "0x180B10F30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056A7")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerSessionReadyEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056A8")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60056A9")]
	[Address(RVA = "0xB10FB0", Offset = "0xB103B0", VA = "0x180B10FB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60056AA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60056AB")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60056AC")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60056AD")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ServerSessionReadyEvent other)
	{
	}

	[Token(Token = "0x60056AE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60056AF")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
