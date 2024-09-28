using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank;

[Token(Token = "0x200046C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRanksEvent : IMessage<GuildRanksEvent>, IMessage, IEquatable<GuildRanksEvent>, IDeepCloneable<GuildRanksEvent>, IBufferMessage
{
	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRanksEvent> _parser;

	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F27")]
	public const int RanksFieldNumber = 1;

	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<RankInformation> _repeated_ranks_codec;

	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<RankInformation> ranks_;

	[Token(Token = "0x170009EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRanksEvent> Parser
	{
		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0x9DCF40", Offset = "0x9DC340", VA = "0x1809DCF40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002E8C")]
		[Address(RVA = "0x9DCE90", Offset = "0x9DC290", VA = "0x1809DCE90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002E8D")]
		[Address(RVA = "0x9DD150", Offset = "0x9DC550", VA = "0x1809DD150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009ED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<RankInformation> Ranks
	{
		[Token(Token = "0x6002E91")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x9DCE10", Offset = "0x9DC210", VA = "0x1809DCE10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRanksEvent()
	{
	}

	[Token(Token = "0x6002E8F")]
	[Address(RVA = "0x9DCD80", Offset = "0x9DC180", VA = "0x1809DCD80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRanksEvent(GuildRanksEvent other)
	{
	}

	[Token(Token = "0x6002E90")]
	[Address(RVA = "0x9DC8D0", Offset = "0x9DBCD0", VA = "0x1809DC8D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRanksEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002E92")]
	[Address(RVA = "0x9DC990", Offset = "0x9DBD90", VA = "0x1809DC990", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E93")]
	[Address(RVA = "0x9DCA70", Offset = "0x9DBE70", VA = "0x1809DCA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRanksEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E94")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002E95")]
	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", VA = "0x1809DCB80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002E96")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002E97")]
	[Address(RVA = "0x9DD0A0", Offset = "0x9DC4A0", VA = "0x1809DD0A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002E98")]
	[Address(RVA = "0x9DC830", Offset = "0x9DBC30", VA = "0x1809DC830", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002E99")]
	[Address(RVA = "0x9DCB00", Offset = "0x9DBF00", VA = "0x1809DCB00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRanksEvent other)
	{
	}

	[Token(Token = "0x6002E9A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002E9B")]
	[Address(RVA = "0x9DCF90", Offset = "0x9DC390", VA = "0x1809DCF90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
