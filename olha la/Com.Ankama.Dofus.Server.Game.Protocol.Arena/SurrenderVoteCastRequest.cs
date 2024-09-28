using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BCF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SurrenderVoteCastRequest : IMessage<SurrenderVoteCastRequest>, IMessage, IEquatable<SurrenderVoteCastRequest>, IDeepCloneable<SurrenderVoteCastRequest>, IBufferMessage
{
	[Token(Token = "0x4002BEB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SurrenderVoteCastRequest> _parser;

	[Token(Token = "0x4002BEC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002BED")]
	public const int VoteFieldNumber = 1;

	[Token(Token = "0x4002BEE")]
	[FieldOffset(Offset = "0x18")]
	private bool vote_;

	[Token(Token = "0x17001B4B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SurrenderVoteCastRequest> Parser
	{
		[Token(Token = "0x6007C1E")]
		[Address(RVA = "0xC3C8E0", Offset = "0xC3BCE0", VA = "0x180C3C8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B4C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007C1F")]
		[Address(RVA = "0xC3C830", Offset = "0xC3BC30", VA = "0x180C3C830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B4D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007C20")]
		[Address(RVA = "0xC3C930", Offset = "0xC3BD30", VA = "0x180C3C930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B4E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Vote
	{
		[Token(Token = "0x6007C24")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007C25")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007C21")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderVoteCastRequest()
	{
	}

	[Token(Token = "0x6007C22")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderVoteCastRequest(SurrenderVoteCastRequest other)
	{
	}

	[Token(Token = "0x6007C23")]
	[Address(RVA = "0xC3C520", Offset = "0xC3B920", VA = "0x180C3C520", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SurrenderVoteCastRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007C26")]
	[Address(RVA = "0xC3C5A0", Offset = "0xC3B9A0", VA = "0x180C3C5A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C27")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SurrenderVoteCastRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007C28")]
	[Address(RVA = "0xC3C630", Offset = "0xC3BA30", VA = "0x180C3C630", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007C29")]
	[Address(RVA = "0xC3C6D0", Offset = "0xC3BAD0", VA = "0x180C3C6D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007C2A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007C2B")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007C2C")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007C2D")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SurrenderVoteCastRequest other)
	{
	}

	[Token(Token = "0x6007C2E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007C2F")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
