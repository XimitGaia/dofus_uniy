using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x20005C5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SequenceStartEvent : IMessage<SequenceStartEvent>, IMessage, IEquatable<SequenceStartEvent>, IDeepCloneable<SequenceStartEvent>, IBufferMessage
{
	[Token(Token = "0x400141E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SequenceStartEvent> _parser;

	[Token(Token = "0x400141F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001420")]
	public const int SequenceTypeFieldNumber = 1;

	[Token(Token = "0x4001421")]
	[FieldOffset(Offset = "0x18")]
	private SequenceType sequenceType_;

	[Token(Token = "0x4001422")]
	public const int AuthorIdFieldNumber = 2;

	[Token(Token = "0x4001423")]
	[FieldOffset(Offset = "0x20")]
	private long authorId_;

	[Token(Token = "0x17000D30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SequenceStartEvent> Parser
	{
		[Token(Token = "0x6003D95")]
		[Address(RVA = "0xA30890", Offset = "0xA2FC90", VA = "0x180A30890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D31")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0xA307E0", Offset = "0xA2FBE0", VA = "0x180A307E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D32")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003D97")]
		[Address(RVA = "0xA30960", Offset = "0xA2FD60", VA = "0x180A30960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D33")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SequenceType SequenceType
	{
		[Token(Token = "0x6003D9B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SequenceType);
		}
		[Token(Token = "0x6003D9C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000D34")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AuthorId
	{
		[Token(Token = "0x6003D9D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003D9E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6003D98")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceStartEvent()
	{
	}

	[Token(Token = "0x6003D99")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SequenceStartEvent(SequenceStartEvent other)
	{
	}

	[Token(Token = "0x6003D9A")]
	[Address(RVA = "0xA30550", Offset = "0xA2F950", VA = "0x180A30550", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SequenceStartEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003D9F")]
	[Address(RVA = "0xA305E0", Offset = "0xA2F9E0", VA = "0x180A305E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DA0")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SequenceStartEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DA1")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003DA2")]
	[Address(RVA = "0xA30680", Offset = "0xA2FA80", VA = "0x180A30680", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003DA3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003DA4")]
	[Address(RVA = "0xA308E0", Offset = "0xA2FCE0", VA = "0x180A308E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003DA5")]
	[Address(RVA = "0xA30490", Offset = "0xA2F890", VA = "0x180A30490", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003DA6")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SequenceStartEvent other)
	{
	}

	[Token(Token = "0x6003DA7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003DA8")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
