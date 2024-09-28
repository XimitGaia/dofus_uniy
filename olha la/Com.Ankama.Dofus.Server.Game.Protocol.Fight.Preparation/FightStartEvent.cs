using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x200063B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightStartEvent : IMessage<FightStartEvent>, IMessage, IEquatable<FightStartEvent>, IDeepCloneable<FightStartEvent>, IBufferMessage
{
	[Token(Token = "0x40015F7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightStartEvent> _parser;

	[Token(Token = "0x40015F8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000E5A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightStartEvent> Parser
	{
		[Token(Token = "0x60042CC")]
		[Address(RVA = "0xA835E0", Offset = "0xA829E0", VA = "0x180A835E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E5B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60042CD")]
		[Address(RVA = "0xA83530", Offset = "0xA82930", VA = "0x180A83530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E5C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60042CE")]
		[Address(RVA = "0xA83630", Offset = "0xA82A30", VA = "0x180A83630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60042CF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStartEvent()
	{
	}

	[Token(Token = "0x60042D0")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStartEvent(FightStartEvent other)
	{
	}

	[Token(Token = "0x60042D1")]
	[Address(RVA = "0xA832D0", Offset = "0xA826D0", VA = "0x180A832D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStartEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60042D2")]
	[Address(RVA = "0xA83350", Offset = "0xA82750", VA = "0x180A83350", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60042D3")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightStartEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60042D4")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60042D5")]
	[Address(RVA = "0xA833D0", Offset = "0xA827D0", VA = "0x180A833D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60042D6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60042D7")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60042D8")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60042D9")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightStartEvent other)
	{
	}

	[Token(Token = "0x60042DA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60042DB")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
