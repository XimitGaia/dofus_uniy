using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank;

[Token(Token = "0x2000464")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRankUpdateAllRequest : IMessage<GuildRankUpdateAllRequest>, IMessage, IEquatable<GuildRankUpdateAllRequest>, IDeepCloneable<GuildRankUpdateAllRequest>, IBufferMessage
{
	[Token(Token = "0x4000F0B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRankUpdateAllRequest> _parser;

	[Token(Token = "0x4000F0C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F0D")]
	public const int RanksFieldNumber = 1;

	[Token(Token = "0x4000F0E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<RankInformation> _repeated_ranks_codec;

	[Token(Token = "0x4000F0F")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<RankInformation> ranks_;

	[Token(Token = "0x170009D8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRankUpdateAllRequest> Parser
	{
		[Token(Token = "0x6002E31")]
		[Address(RVA = "0x9B3250", Offset = "0x9B2650", VA = "0x1809B3250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002E32")]
		[Address(RVA = "0x9B31A0", Offset = "0x9B25A0", VA = "0x1809B31A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009DA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002E33")]
		[Address(RVA = "0x9B3460", Offset = "0x9B2860", VA = "0x1809B3460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RankInformation> Ranks
	{
		[Token(Token = "0x6002E37")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E34")]
	[Address(RVA = "0x9B3090", Offset = "0x9B2490", VA = "0x1809B3090")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankUpdateAllRequest()
	{
	}

	[Token(Token = "0x6002E35")]
	[Address(RVA = "0x9B3110", Offset = "0x9B2510", VA = "0x1809B3110")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankUpdateAllRequest(GuildRankUpdateAllRequest other)
	{
	}

	[Token(Token = "0x6002E36")]
	[Address(RVA = "0x9B2BE0", Offset = "0x9B1FE0", VA = "0x1809B2BE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankUpdateAllRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002E38")]
	[Address(RVA = "0x9B2CA0", Offset = "0x9B20A0", VA = "0x1809B2CA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E39")]
	[Address(RVA = "0x9B2D80", Offset = "0x9B2180", VA = "0x1809B2D80", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRankUpdateAllRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E3A")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002E3B")]
	[Address(RVA = "0x9B2E90", Offset = "0x9B2290", VA = "0x1809B2E90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002E3C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002E3D")]
	[Address(RVA = "0x9B33B0", Offset = "0x9B27B0", VA = "0x1809B33B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002E3E")]
	[Address(RVA = "0x9B2B40", Offset = "0x9B1F40", VA = "0x1809B2B40", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002E3F")]
	[Address(RVA = "0x9B2E10", Offset = "0x9B2210", VA = "0x1809B2E10", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildRankUpdateAllRequest other)
	{
	}

	[Token(Token = "0x6002E40")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002E41")]
	[Address(RVA = "0x9B32A0", Offset = "0x9B26A0", VA = "0x1809B32A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
