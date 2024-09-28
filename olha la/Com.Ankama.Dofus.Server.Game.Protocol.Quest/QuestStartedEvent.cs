using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x200019A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestStartedEvent : IMessage<QuestStartedEvent>, IMessage, IEquatable<QuestStartedEvent>, IDeepCloneable<QuestStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestStartedEvent> _parser;

	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000572")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x17000375")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestStartedEvent> Parser
	{
		[Token(Token = "0x6001031")]
		[Address(RVA = "0xC4D6D0", Offset = "0xC4CAD0", VA = "0x180C4D6D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000376")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001032")]
		[Address(RVA = "0xC4D620", Offset = "0xC4CA20", VA = "0x180C4D620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000377")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001033")]
		[Address(RVA = "0xC4D720", Offset = "0xC4CB20", VA = "0x180C4D720", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000378")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestId
	{
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001034")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestStartedEvent()
	{
	}

	[Token(Token = "0x6001035")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStartedEvent(QuestStartedEvent other)
	{
	}

	[Token(Token = "0x6001036")]
	[Address(RVA = "0xC4D3B0", Offset = "0xC4C7B0", VA = "0x180C4D3B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001039")]
	[Address(RVA = "0xC4D430", Offset = "0xC4C830", VA = "0x180C4D430", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600103A")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600103B")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600103C")]
	[Address(RVA = "0xC4D4C0", Offset = "0xC4C8C0", VA = "0x180C4D4C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600103D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600103E")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600103F")]
	[Address(RVA = "0xC4D320", Offset = "0xC4C720", VA = "0x180C4D320", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001040")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestStartedEvent other)
	{
	}

	[Token(Token = "0x6001041")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001042")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
