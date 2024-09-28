using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000141")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlignmentRankUpdateEvent : IMessage<AlignmentRankUpdateEvent>, IMessage, IEquatable<AlignmentRankUpdateEvent>, IDeepCloneable<AlignmentRankUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AlignmentRankUpdateEvent> _parser;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000450")]
	public const int AlignmentRankFieldNumber = 1;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x18")]
	private int alignmentRank_;

	[Token(Token = "0x4000452")]
	public const int VerboseFieldNumber = 2;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x1C")]
	private bool verbose_;

	[Token(Token = "0x170002AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlignmentRankUpdateEvent> Parser
	{
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0xB63FE0", Offset = "0xB633E0", VA = "0x180B63FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0xB63F30", Offset = "0xB63330", VA = "0x180B63F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0xB64030", Offset = "0xB63430", VA = "0x180B64030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AlignmentRank
	{
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170002B1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Verbose
	{
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlignmentRankUpdateEvent()
	{
	}

	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlignmentRankUpdateEvent(AlignmentRankUpdateEvent other)
	{
	}

	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0xB63BF0", Offset = "0xB62FF0", VA = "0x180B63BF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlignmentRankUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0xB63C80", Offset = "0xB63080", VA = "0x180B63C80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlignmentRankUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0xB63D10", Offset = "0xB63110", VA = "0x180B63D10", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000C92")]
	[Address(RVA = "0xB63DD0", Offset = "0xB631D0", VA = "0x180B63DD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000C95")]
	[Address(RVA = "0xB63B60", Offset = "0xB62F60", VA = "0x180B63B60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlignmentRankUpdateEvent other)
	{
	}

	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
