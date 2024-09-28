using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank;

[Token(Token = "0x2000C7F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRankUpdateRequest : IMessage<AllianceRankUpdateRequest>, IMessage, IEquatable<AllianceRankUpdateRequest>, IDeepCloneable<AllianceRankUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4002E2D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRankUpdateRequest> _parser;

	[Token(Token = "0x4002E2E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E2F")]
	public const int RankFieldNumber = 1;

	[Token(Token = "0x4002E30")]
	[FieldOffset(Offset = "0x18")]
	private RankInformation rank_;

	[Token(Token = "0x17001CD2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceRankUpdateRequest> Parser
	{
		[Token(Token = "0x600838F")]
		[Address(RVA = "0xC79810", Offset = "0xC78C10", VA = "0x180C79810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CD3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008390")]
		[Address(RVA = "0xC79760", Offset = "0xC78B60", VA = "0x180C79760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CD4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008391")]
		[Address(RVA = "0xC79960", Offset = "0xC78D60", VA = "0x180C79960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CD5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RankInformation Rank
	{
		[Token(Token = "0x6008395")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008396")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008392")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRankUpdateRequest()
	{
	}

	[Token(Token = "0x6008393")]
	[Address(RVA = "0x9B3950", Offset = "0x9B2D50", VA = "0x1809B3950")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRankUpdateRequest(AllianceRankUpdateRequest other)
	{
	}

	[Token(Token = "0x6008394")]
	[Address(RVA = "0xC793E0", Offset = "0xC787E0", VA = "0x180C793E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRankUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008397")]
	[Address(RVA = "0xC79480", Offset = "0xC78880", VA = "0x180C79480", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008398")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRankUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008399")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600839A")]
	[Address(RVA = "0xC79600", Offset = "0xC78A00", VA = "0x180C79600", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600839B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600839C")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600839D")]
	[Address(RVA = "0xC79350", Offset = "0xC78750", VA = "0x180C79350", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600839E")]
	[Address(RVA = "0xC79530", Offset = "0xC78930", VA = "0x180C79530", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceRankUpdateRequest other)
	{
	}

	[Token(Token = "0x600839F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60083A0")]
	[Address(RVA = "0xC79860", Offset = "0xC78C60", VA = "0x180C79860", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
