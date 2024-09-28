using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x200019C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestValidatedEvent : IMessage<QuestValidatedEvent>, IMessage, IEquatable<QuestValidatedEvent>, IDeepCloneable<QuestValidatedEvent>, IBufferMessage
{
	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestValidatedEvent> _parser;

	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000577")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x17000379")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestValidatedEvent> Parser
	{
		[Token(Token = "0x6001047")]
		[Address(RVA = "0xC4E5B0", Offset = "0xC4D9B0", VA = "0x180C4E5B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700037A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001048")]
		[Address(RVA = "0xC4E500", Offset = "0xC4D900", VA = "0x180C4E500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700037B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001049")]
		[Address(RVA = "0xC4E600", Offset = "0xC4DA00", VA = "0x180C4E600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700037C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestId
	{
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600104A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestValidatedEvent()
	{
	}

	[Token(Token = "0x600104B")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestValidatedEvent(QuestValidatedEvent other)
	{
	}

	[Token(Token = "0x600104C")]
	[Address(RVA = "0xC4E290", Offset = "0xC4D690", VA = "0x180C4E290", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestValidatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600104F")]
	[Address(RVA = "0xC4E310", Offset = "0xC4D710", VA = "0x180C4E310", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001050")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestValidatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001051")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001052")]
	[Address(RVA = "0xC4E3A0", Offset = "0xC4D7A0", VA = "0x180C4E3A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001053")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001054")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001055")]
	[Address(RVA = "0xC4E200", Offset = "0xC4D600", VA = "0x180C4E200", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001056")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestValidatedEvent other)
	{
	}

	[Token(Token = "0x6001057")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001058")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
