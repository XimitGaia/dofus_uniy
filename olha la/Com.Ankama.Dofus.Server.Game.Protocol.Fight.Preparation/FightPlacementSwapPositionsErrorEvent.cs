using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000629")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPlacementSwapPositionsErrorEvent : IMessage<FightPlacementSwapPositionsErrorEvent>, IMessage, IEquatable<FightPlacementSwapPositionsErrorEvent>, IDeepCloneable<FightPlacementSwapPositionsErrorEvent>, IBufferMessage
{
	[Token(Token = "0x40015B3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPlacementSwapPositionsErrorEvent> _parser;

	[Token(Token = "0x40015B4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000E2B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightPlacementSwapPositionsErrorEvent> Parser
	{
		[Token(Token = "0x60041F1")]
		[Address(RVA = "0xA80620", Offset = "0xA7FA20", VA = "0x180A80620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E2C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60041F2")]
		[Address(RVA = "0xA80570", Offset = "0xA7F970", VA = "0x180A80570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E2D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60041F3")]
		[Address(RVA = "0xA80670", Offset = "0xA7FA70", VA = "0x180A80670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041F4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsErrorEvent()
	{
	}

	[Token(Token = "0x60041F5")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsErrorEvent(FightPlacementSwapPositionsErrorEvent other)
	{
	}

	[Token(Token = "0x60041F6")]
	[Address(RVA = "0xA80310", Offset = "0xA7F710", VA = "0x180A80310", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60041F7")]
	[Address(RVA = "0xA80390", Offset = "0xA7F790", VA = "0x180A80390", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60041F8")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightPlacementSwapPositionsErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60041F9")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60041FA")]
	[Address(RVA = "0xA80410", Offset = "0xA7F810", VA = "0x180A80410", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60041FB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60041FC")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60041FD")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60041FE")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightPlacementSwapPositionsErrorEvent other)
	{
	}

	[Token(Token = "0x60041FF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004200")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
