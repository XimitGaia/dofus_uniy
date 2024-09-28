using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x200087B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameOverEvent : IMessage<GameOverEvent>, IMessage, IEquatable<GameOverEvent>, IDeepCloneable<GameOverEvent>, IBufferMessage
{
	[Token(Token = "0x4001D62")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameOverEvent> _parser;

	[Token(Token = "0x4001D63")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001331")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GameOverEvent> Parser
	{
		[Token(Token = "0x6005A23")]
		[Address(RVA = "0xB26F80", Offset = "0xB26380", VA = "0x180B26F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001332")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005A24")]
		[Address(RVA = "0xB26ED0", Offset = "0xB262D0", VA = "0x180B26ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001333")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005A25")]
		[Address(RVA = "0xB26FD0", Offset = "0xB263D0", VA = "0x180B26FD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005A26")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameOverEvent()
	{
	}

	[Token(Token = "0x6005A27")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GameOverEvent(GameOverEvent other)
	{
	}

	[Token(Token = "0x6005A28")]
	[Address(RVA = "0xB26C70", Offset = "0xB26070", VA = "0x180B26C70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameOverEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005A29")]
	[Address(RVA = "0xB26CF0", Offset = "0xB260F0", VA = "0x180B26CF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A2A")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameOverEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A2B")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005A2C")]
	[Address(RVA = "0xB26D70", Offset = "0xB26170", VA = "0x180B26D70", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005A2D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005A2E")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005A2F")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005A30")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameOverEvent other)
	{
	}

	[Token(Token = "0x6005A31")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005A32")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
