using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x200018F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestObjectiveFollowRequest : IMessage<QuestObjectiveFollowRequest>, IMessage, IEquatable<QuestObjectiveFollowRequest>, IDeepCloneable<QuestObjectiveFollowRequest>, IBufferMessage
{
	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestObjectiveFollowRequest> _parser;

	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000547")]
	public const int QuestIdFieldNumber = 1;

	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x18")]
	private int questId_;

	[Token(Token = "0x4000549")]
	public const int ObjectiveIdFieldNumber = 2;

	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x1C")]
	private int objectiveId_;

	[Token(Token = "0x1700035A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestObjectiveFollowRequest> Parser
	{
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0xC49980", Offset = "0xC48D80", VA = "0x180C49980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700035B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0xC498D0", Offset = "0xC48CD0", VA = "0x180C498D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700035C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0xC499D0", Offset = "0xC48DD0", VA = "0x180C499D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700035D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestId
	{
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700035E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectiveId
	{
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestObjectiveFollowRequest()
	{
	}

	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestObjectiveFollowRequest(QuestObjectiveFollowRequest other)
	{
	}

	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0xC49650", Offset = "0xC48A50", VA = "0x180C49650", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestObjectiveFollowRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0xC496E0", Offset = "0xC48AE0", VA = "0x180C496E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC4")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestObjectiveFollowRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0xC49770", Offset = "0xC48B70", VA = "0x180C49770", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0xC49590", Offset = "0xC48990", VA = "0x180C49590", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestObjectiveFollowRequest other)
	{
	}

	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
