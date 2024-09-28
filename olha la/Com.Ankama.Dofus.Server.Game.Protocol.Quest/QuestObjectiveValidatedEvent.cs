using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x200019E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestObjectiveValidatedEvent : IMessage<QuestObjectiveValidatedEvent>, IMessage, IEquatable<QuestObjectiveValidatedEvent>, IDeepCloneable<QuestObjectiveValidatedEvent>, IBufferMessage
{
	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestObjectiveValidatedEvent> _parser;

	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400057C")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x400057E")]
	public const int ObjectiveIdFieldNumber = 2;

	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x1C")]
	private int objectiveId_;

	[Token(Token = "0x1700037D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestObjectiveValidatedEvent> Parser
	{
		[Token(Token = "0x600105D")]
		[Address(RVA = "0xC4A3C0", Offset = "0xC497C0", VA = "0x180C4A3C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700037E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600105E")]
		[Address(RVA = "0xC4A310", Offset = "0xC49710", VA = "0x180C4A310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700037F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600105F")]
		[Address(RVA = "0xC4A410", Offset = "0xC49810", VA = "0x180C4A410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000380")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestId
	{
		[Token(Token = "0x6001063")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001064")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000381")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectiveId
	{
		[Token(Token = "0x6001065")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6001060")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestObjectiveValidatedEvent()
	{
	}

	[Token(Token = "0x6001061")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestObjectiveValidatedEvent(QuestObjectiveValidatedEvent other)
	{
	}

	[Token(Token = "0x6001062")]
	[Address(RVA = "0xC4A090", Offset = "0xC49490", VA = "0x180C4A090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestObjectiveValidatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001067")]
	[Address(RVA = "0xC4A120", Offset = "0xC49520", VA = "0x180C4A120", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001068")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestObjectiveValidatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001069")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600106A")]
	[Address(RVA = "0xC4A1B0", Offset = "0xC495B0", VA = "0x180C4A1B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600106B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600106C")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600106D")]
	[Address(RVA = "0xC49FD0", Offset = "0xC493D0", VA = "0x180C49FD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600106E")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestObjectiveValidatedEvent other)
	{
	}

	[Token(Token = "0x600106F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001070")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
