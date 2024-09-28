using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x20001A0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestStepValidatedEvent : IMessage<QuestStepValidatedEvent>, IMessage, IEquatable<QuestStepValidatedEvent>, IDeepCloneable<QuestStepValidatedEvent>, IBufferMessage
{
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestStepValidatedEvent> _parser;

	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000583")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x4000585")]
	public const int StepIdFieldNumber = 2;

	[Token(Token = "0x4000586")]
	[FieldOffset(Offset = "0x1C")]
	private int stepId_;

	[Token(Token = "0x17000382")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestStepValidatedEvent> Parser
	{
		[Token(Token = "0x6001075")]
		[Address(RVA = "0xC4E0D0", Offset = "0xC4D4D0", VA = "0x180C4E0D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000383")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001076")]
		[Address(RVA = "0xC4E020", Offset = "0xC4D420", VA = "0x180C4E020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000384")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001077")]
		[Address(RVA = "0xC4E120", Offset = "0xC4D520", VA = "0x180C4E120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000385")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestId
	{
		[Token(Token = "0x600107B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000386")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StepId
	{
		[Token(Token = "0x600107D")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6001078")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestStepValidatedEvent()
	{
	}

	[Token(Token = "0x6001079")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStepValidatedEvent(QuestStepValidatedEvent other)
	{
	}

	[Token(Token = "0x600107A")]
	[Address(RVA = "0xC4DDA0", Offset = "0xC4D1A0", VA = "0x180C4DDA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStepValidatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600107F")]
	[Address(RVA = "0xC4DE30", Offset = "0xC4D230", VA = "0x180C4DE30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001080")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestStepValidatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001081")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001082")]
	[Address(RVA = "0xC4DEC0", Offset = "0xC4D2C0", VA = "0x180C4DEC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001083")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001084")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001085")]
	[Address(RVA = "0xC4DCE0", Offset = "0xC4D0E0", VA = "0x180C4DCE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001086")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestStepValidatedEvent other)
	{
	}

	[Token(Token = "0x6001087")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001088")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
