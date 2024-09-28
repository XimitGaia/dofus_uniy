using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank;

[Token(Token = "0x2000466")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRankUpdateRequest : IMessage<GuildRankUpdateRequest>, IMessage, IEquatable<GuildRankUpdateRequest>, IDeepCloneable<GuildRankUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4000F11")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRankUpdateRequest> _parser;

	[Token(Token = "0x4000F12")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F13")]
	public const int RankFieldNumber = 1;

	[Token(Token = "0x4000F14")]
	[FieldOffset(Offset = "0x18")]
	private RankInformation rank_;

	[Token(Token = "0x170009DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRankUpdateRequest> Parser
	{
		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x9B3A70", Offset = "0x9B2E70", VA = "0x1809B3A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009DD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x9B39C0", Offset = "0x9B2DC0", VA = "0x1809B39C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002E48")]
		[Address(RVA = "0x9B3BC0", Offset = "0x9B2FC0", VA = "0x1809B3BC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009DF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RankInformation Rank
	{
		[Token(Token = "0x6002E4C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002E49")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankUpdateRequest()
	{
	}

	[Token(Token = "0x6002E4A")]
	[Address(RVA = "0x9B3950", Offset = "0x9B2D50", VA = "0x1809B3950")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankUpdateRequest(GuildRankUpdateRequest other)
	{
	}

	[Token(Token = "0x6002E4B")]
	[Address(RVA = "0x9B35D0", Offset = "0x9B29D0", VA = "0x1809B35D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002E4E")]
	[Address(RVA = "0x9B3670", Offset = "0x9B2A70", VA = "0x1809B3670", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E4F")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRankUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E50")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002E51")]
	[Address(RVA = "0x9B37F0", Offset = "0x9B2BF0", VA = "0x1809B37F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002E52")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002E53")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002E54")]
	[Address(RVA = "0x9B3540", Offset = "0x9B2940", VA = "0x1809B3540", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002E55")]
	[Address(RVA = "0x9B3720", Offset = "0x9B2B20", VA = "0x1809B3720", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRankUpdateRequest other)
	{
	}

	[Token(Token = "0x6002E56")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002E57")]
	[Address(RVA = "0x9B3AC0", Offset = "0x9B2EC0", VA = "0x1809B3AC0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
