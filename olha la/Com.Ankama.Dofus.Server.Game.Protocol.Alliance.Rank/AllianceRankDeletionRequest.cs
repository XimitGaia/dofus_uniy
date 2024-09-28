using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank;

[Token(Token = "0x2000C7D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRankDeletionRequest : IMessage<AllianceRankDeletionRequest>, IMessage, IEquatable<AllianceRankDeletionRequest>, IDeepCloneable<AllianceRankDeletionRequest>, IBufferMessage
{
	[Token(Token = "0x4002E26")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRankDeletionRequest> _parser;

	[Token(Token = "0x4002E27")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E28")]
	public const int RankIdFieldNumber = 1;

	[Token(Token = "0x4002E29")]
	[FieldOffset(Offset = "0x18")]
	private int rankId_;

	[Token(Token = "0x4002E2A")]
	public const int ReplacementRankIdFieldNumber = 2;

	[Token(Token = "0x4002E2B")]
	[FieldOffset(Offset = "0x1C")]
	private int replacementRankId_;

	[Token(Token = "0x17001CCD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRankDeletionRequest> Parser
	{
		[Token(Token = "0x6008377")]
		[Address(RVA = "0xC77970", Offset = "0xC76D70", VA = "0x180C77970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008378")]
		[Address(RVA = "0xC778C0", Offset = "0xC76CC0", VA = "0x180C778C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CCF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008379")]
		[Address(RVA = "0xC779C0", Offset = "0xC76DC0", VA = "0x180C779C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankId
	{
		[Token(Token = "0x600837D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600837E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001CD1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReplacementRankId
	{
		[Token(Token = "0x600837F")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008380")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600837A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRankDeletionRequest()
	{
	}

	[Token(Token = "0x600837B")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRankDeletionRequest(AllianceRankDeletionRequest other)
	{
	}

	[Token(Token = "0x600837C")]
	[Address(RVA = "0xC77640", Offset = "0xC76A40", VA = "0x180C77640", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRankDeletionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008381")]
	[Address(RVA = "0xC776D0", Offset = "0xC76AD0", VA = "0x180C776D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008382")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRankDeletionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008383")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008384")]
	[Address(RVA = "0xC77760", Offset = "0xC76B60", VA = "0x180C77760", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008385")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008386")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008387")]
	[Address(RVA = "0xC77580", Offset = "0xC76980", VA = "0x180C77580", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008388")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceRankDeletionRequest other)
	{
	}

	[Token(Token = "0x6008389")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600838A")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
