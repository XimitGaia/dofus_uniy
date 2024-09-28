using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BAA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaFighterIdleEvent : IMessage<ArenaFighterIdleEvent>, IMessage, IEquatable<ArenaFighterIdleEvent>, IDeepCloneable<ArenaFighterIdleEvent>, IBufferMessage
{
	[Token(Token = "0x4002B8F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaFighterIdleEvent> _parser;

	[Token(Token = "0x4002B90")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001B07")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaFighterIdleEvent> Parser
	{
		[Token(Token = "0x6007AB6")]
		[Address(RVA = "0xC2F430", Offset = "0xC2E830", VA = "0x180C2F430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007AB7")]
		[Address(RVA = "0xC2F380", Offset = "0xC2E780", VA = "0x180C2F380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B09")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007AB8")]
		[Address(RVA = "0xC2F480", Offset = "0xC2E880", VA = "0x180C2F480", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007AB9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFighterIdleEvent()
	{
	}

	[Token(Token = "0x6007ABA")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFighterIdleEvent(ArenaFighterIdleEvent other)
	{
	}

	[Token(Token = "0x6007ABB")]
	[Address(RVA = "0xC2F120", Offset = "0xC2E520", VA = "0x180C2F120", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFighterIdleEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007ABC")]
	[Address(RVA = "0xC2F1A0", Offset = "0xC2E5A0", VA = "0x180C2F1A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007ABD")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaFighterIdleEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007ABE")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007ABF")]
	[Address(RVA = "0xC2F220", Offset = "0xC2E620", VA = "0x180C2F220", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007AC0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007AC1")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007AC2")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007AC3")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaFighterIdleEvent other)
	{
	}

	[Token(Token = "0x6007AC4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007AC5")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
