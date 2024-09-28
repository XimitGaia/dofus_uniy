using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BD1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SurrenderVoteStartEvent : IMessage<SurrenderVoteStartEvent>, IMessage, IEquatable<SurrenderVoteStartEvent>, IDeepCloneable<SurrenderVoteStartEvent>, IBufferMessage
{
	[Token(Token = "0x4002BF0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SurrenderVoteStartEvent> _parser;

	[Token(Token = "0x4002BF1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002BF2")]
	public const int AlreadyCastedVoteFieldNumber = 1;

	[Token(Token = "0x4002BF3")]
	[FieldOffset(Offset = "0x18")]
	private bool alreadyCastedVote_;

	[Token(Token = "0x4002BF4")]
	public const int ParticipantNumberFieldNumber = 2;

	[Token(Token = "0x4002BF5")]
	[FieldOffset(Offset = "0x1C")]
	private int participantNumber_;

	[Token(Token = "0x4002BF6")]
	public const int CastedVoteNumberFieldNumber = 3;

	[Token(Token = "0x4002BF7")]
	[FieldOffset(Offset = "0x20")]
	private int castedVoteNumber_;

	[Token(Token = "0x4002BF8")]
	public const int VoteDurationFieldNumber = 4;

	[Token(Token = "0x4002BF9")]
	[FieldOffset(Offset = "0x24")]
	private int voteDuration_;

	[Token(Token = "0x17001B4F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SurrenderVoteStartEvent> Parser
	{
		[Token(Token = "0x6007C34")]
		[Address(RVA = "0xC3F1D0", Offset = "0xC3E5D0", VA = "0x180C3F1D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007C35")]
		[Address(RVA = "0xC3F120", Offset = "0xC3E520", VA = "0x180C3F120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B51")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007C36")]
		[Address(RVA = "0xC3F3E0", Offset = "0xC3E7E0", VA = "0x180C3F3E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B52")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AlreadyCastedVote
	{
		[Token(Token = "0x6007C3A")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007C3B")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001B53")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ParticipantNumber
	{
		[Token(Token = "0x6007C3C")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007C3D")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001B54")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CastedVoteNumber
	{
		[Token(Token = "0x6007C3E")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007C3F")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001B55")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int VoteDuration
	{
		[Token(Token = "0x6007C40")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007C41")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6007C37")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderVoteStartEvent()
	{
	}

	[Token(Token = "0x6007C38")]
	[Address(RVA = "0xC3F0C0", Offset = "0xC3E4C0", VA = "0x180C3F0C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderVoteStartEvent(SurrenderVoteStartEvent other)
	{
	}

	[Token(Token = "0x6007C39")]
	[Address(RVA = "0xC3EC80", Offset = "0xC3E080", VA = "0x180C3EC80", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SurrenderVoteStartEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007C42")]
	[Address(RVA = "0xC3ED60", Offset = "0xC3E160", VA = "0x180C3ED60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C43")]
	[Address(RVA = "0xC3ED10", Offset = "0xC3E110", VA = "0x180C3ED10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SurrenderVoteStartEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C44")]
	[Address(RVA = "0xC3EE00", Offset = "0xC3E200", VA = "0x180C3EE00", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007C45")]
	[Address(RVA = "0xC3EF60", Offset = "0xC3E360", VA = "0x180C3EF60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007C46")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007C47")]
	[Address(RVA = "0xC3F320", Offset = "0xC3E720", VA = "0x180C3F320", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007C48")]
	[Address(RVA = "0xC3EB90", Offset = "0xC3DF90", VA = "0x180C3EB90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007C49")]
	[Address(RVA = "0xC3EEF0", Offset = "0xC3E2F0", VA = "0x180C3EEF0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SurrenderVoteStartEvent other)
	{
	}

	[Token(Token = "0x6007C4A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007C4B")]
	[Address(RVA = "0xC3F220", Offset = "0xC3E620", VA = "0x180C3F220", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
