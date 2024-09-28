using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000869")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerStatusUpdateErrorEvent : IMessage<PlayerStatusUpdateErrorEvent>, IMessage, IEquatable<PlayerStatusUpdateErrorEvent>, IDeepCloneable<PlayerStatusUpdateErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4001D28")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayerStatusUpdateErrorEvent> _parser;

	[Token(Token = "0x4001D29")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700130A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PlayerStatusUpdateErrorEvent> Parser
	{
		[Token(Token = "0x6005965")]
		[Address(RVA = "0xB278A0", Offset = "0xB26CA0", VA = "0x180B278A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700130B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005966")]
		[Address(RVA = "0xB277F0", Offset = "0xB26BF0", VA = "0x180B277F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700130C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005967")]
		[Address(RVA = "0xB278F0", Offset = "0xB26CF0", VA = "0x180B278F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005968")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerStatusUpdateErrorEvent()
	{
	}

	[Token(Token = "0x6005969")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerStatusUpdateErrorEvent(PlayerStatusUpdateErrorEvent other)
	{
	}

	[Token(Token = "0x600596A")]
	[Address(RVA = "0xB27590", Offset = "0xB26990", VA = "0x180B27590", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerStatusUpdateErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600596B")]
	[Address(RVA = "0xB27610", Offset = "0xB26A10", VA = "0x180B27610", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600596C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerStatusUpdateErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600596D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600596E")]
	[Address(RVA = "0xB27690", Offset = "0xB26A90", VA = "0x180B27690", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600596F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005970")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005971")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005972")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PlayerStatusUpdateErrorEvent other)
	{
	}

	[Token(Token = "0x6005973")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005974")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
