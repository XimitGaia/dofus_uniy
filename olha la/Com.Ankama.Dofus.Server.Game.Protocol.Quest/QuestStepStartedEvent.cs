using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x20001A2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestStepStartedEvent : IMessage<QuestStepStartedEvent>, IMessage, IEquatable<QuestStepStartedEvent>, IDeepCloneable<QuestStepStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestStepStartedEvent> _parser;

	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400058A")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x400058C")]
	public const int StepIdFieldNumber = 2;

	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x1C")]
	private int stepId_;

	[Token(Token = "0x17000387")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestStepStartedEvent> Parser
	{
		[Token(Token = "0x600108D")]
		[Address(RVA = "0xCD4CA0", Offset = "0xCD40A0", VA = "0x180CD4CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000388")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600108E")]
		[Address(RVA = "0xCD4BF0", Offset = "0xCD3FF0", VA = "0x180CD4BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000389")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600108F")]
		[Address(RVA = "0xCD4CF0", Offset = "0xCD40F0", VA = "0x180CD4CF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700038A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestId
	{
		[Token(Token = "0x6001093")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001094")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700038B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StepId
	{
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6001090")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestStepStartedEvent()
	{
	}

	[Token(Token = "0x6001091")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestStepStartedEvent(QuestStepStartedEvent other)
	{
	}

	[Token(Token = "0x6001092")]
	[Address(RVA = "0xCD4970", Offset = "0xCD3D70", VA = "0x180CD4970", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestStepStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001097")]
	[Address(RVA = "0xCD4A00", Offset = "0xCD3E00", VA = "0x180CD4A00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001098")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestStepStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001099")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600109A")]
	[Address(RVA = "0xCD4A90", Offset = "0xCD3E90", VA = "0x180CD4A90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600109B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600109C")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600109D")]
	[Address(RVA = "0xCD48B0", Offset = "0xCD3CB0", VA = "0x180CD48B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600109E")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestStepStartedEvent other)
	{
	}

	[Token(Token = "0x600109F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
