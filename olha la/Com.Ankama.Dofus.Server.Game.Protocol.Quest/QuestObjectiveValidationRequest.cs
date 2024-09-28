using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x2000189")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestObjectiveValidationRequest : IMessage<QuestObjectiveValidationRequest>, IMessage, IEquatable<QuestObjectiveValidationRequest>, IDeepCloneable<QuestObjectiveValidationRequest>, IBufferMessage
{
	[Token(Token = "0x4000538")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestObjectiveValidationRequest> _parser;

	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400053A")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x400053B")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x400053C")]
	public const int ObjectiveIdFieldNumber = 2;

	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x1C")]
	private int objectiveId_;

	[Token(Token = "0x1700034F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestObjectiveValidationRequest> Parser
	{
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0xC4A8E0", Offset = "0xC49CE0", VA = "0x180C4A8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000350")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0xC4A830", Offset = "0xC49C30", VA = "0x180C4A830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000351")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0xC4A930", Offset = "0xC49D30", VA = "0x180C4A930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000352")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestId
	{
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000353")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectiveId
	{
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6000F7C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestObjectiveValidationRequest()
	{
	}

	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestObjectiveValidationRequest(QuestObjectiveValidationRequest other)
	{
	}

	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0xC4A5B0", Offset = "0xC499B0", VA = "0x180C4A5B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestObjectiveValidationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000F83")]
	[Address(RVA = "0xC4A640", Offset = "0xC49A40", VA = "0x180C4A640", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestObjectiveValidationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000F86")]
	[Address(RVA = "0xC4A6D0", Offset = "0xC49AD0", VA = "0x180C4A6D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000F89")]
	[Address(RVA = "0xC4A4F0", Offset = "0xC498F0", VA = "0x180C4A4F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestObjectiveValidationRequest other)
	{
	}

	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
