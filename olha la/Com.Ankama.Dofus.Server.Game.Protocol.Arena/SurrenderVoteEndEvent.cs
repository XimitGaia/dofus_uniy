using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BD5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SurrenderVoteEndEvent : IMessage<SurrenderVoteEndEvent>, IMessage, IEquatable<SurrenderVoteEndEvent>, IDeepCloneable<SurrenderVoteEndEvent>, IBufferMessage
{
	[Token(Token = "0x4002BFE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SurrenderVoteEndEvent> _parser;

	[Token(Token = "0x4002BFF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C00")]
	public const int VoteResultFieldNumber = 1;

	[Token(Token = "0x4002C01")]
	[FieldOffset(Offset = "0x18")]
	private bool voteResult_;

	[Token(Token = "0x17001B59")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SurrenderVoteEndEvent> Parser
	{
		[Token(Token = "0x6007C64")]
		[Address(RVA = "0xC3CDD0", Offset = "0xC3C1D0", VA = "0x180C3CDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B5A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007C65")]
		[Address(RVA = "0xC3CD20", Offset = "0xC3C120", VA = "0x180C3CD20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B5B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007C66")]
		[Address(RVA = "0xC3CE20", Offset = "0xC3C220", VA = "0x180C3CE20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B5C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool VoteResult
	{
		[Token(Token = "0x6007C6A")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007C6B")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007C67")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderVoteEndEvent()
	{
	}

	[Token(Token = "0x6007C68")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderVoteEndEvent(SurrenderVoteEndEvent other)
	{
	}

	[Token(Token = "0x6007C69")]
	[Address(RVA = "0xC3CA10", Offset = "0xC3BE10", VA = "0x180C3CA10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderVoteEndEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007C6C")]
	[Address(RVA = "0xC3CA90", Offset = "0xC3BE90", VA = "0x180C3CA90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C6D")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SurrenderVoteEndEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C6E")]
	[Address(RVA = "0xC3CB20", Offset = "0xC3BF20", VA = "0x180C3CB20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007C6F")]
	[Address(RVA = "0xC3CBC0", Offset = "0xC3BFC0", VA = "0x180C3CBC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007C70")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007C71")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007C72")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007C73")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SurrenderVoteEndEvent other)
	{
	}

	[Token(Token = "0x6007C74")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007C75")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
