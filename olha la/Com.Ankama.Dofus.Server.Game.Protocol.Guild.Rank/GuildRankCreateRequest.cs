using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank;

[Token(Token = "0x2000462")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRankCreateRequest : IMessage<GuildRankCreateRequest>, IMessage, IEquatable<GuildRankCreateRequest>, IDeepCloneable<GuildRankCreateRequest>, IBufferMessage
{
	[Token(Token = "0x4000F02")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRankCreateRequest> _parser;

	[Token(Token = "0x4000F03")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F04")]
	public const int ParentRankIdFieldNumber = 1;

	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x18")]
	private int parentRankId_;

	[Token(Token = "0x4000F06")]
	public const int GfxIdFieldNumber = 2;

	[Token(Token = "0x4000F07")]
	[FieldOffset(Offset = "0x1C")]
	private int gfxId_;

	[Token(Token = "0x4000F08")]
	public const int NameFieldNumber = 3;

	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x170009D2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRankCreateRequest> Parser
	{
		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x9B1AE0", Offset = "0x9B0EE0", VA = "0x1809B1AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x9B1A30", Offset = "0x9B0E30", VA = "0x1809B1A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002E19")]
		[Address(RVA = "0x9B1CD0", Offset = "0x9B10D0", VA = "0x1809B1CD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ParentRankId
	{
		[Token(Token = "0x6002E1D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170009D6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GfxId
	{
		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170009D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x9B1DB0", Offset = "0x9B11B0", VA = "0x1809B1DB0")]
		set
		{
		}
	}

	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0x9B1930", Offset = "0x9B0D30", VA = "0x1809B1930")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRankCreateRequest()
	{
	}

	[Token(Token = "0x6002E1B")]
	[Address(RVA = "0x9B1980", Offset = "0x9B0D80", VA = "0x1809B1980")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankCreateRequest(GuildRankCreateRequest other)
	{
	}

	[Token(Token = "0x6002E1C")]
	[Address(RVA = "0x9B1480", Offset = "0x9B0880", VA = "0x1809B1480", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankCreateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002E23")]
	[Address(RVA = "0x9B1560", Offset = "0x9B0960", VA = "0x1809B1560", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E24")]
	[Address(RVA = "0x9B1620", Offset = "0x9B0A20", VA = "0x1809B1620", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRankCreateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E25")]
	[Address(RVA = "0x9B16A0", Offset = "0x9B0AA0", VA = "0x1809B16A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002E26")]
	[Address(RVA = "0x9B17D0", Offset = "0x9B0BD0", VA = "0x1809B17D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002E27")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002E28")]
	[Address(RVA = "0x9B1C20", Offset = "0x9B1020", VA = "0x1809B1C20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002E29")]
	[Address(RVA = "0x9B13A0", Offset = "0x9B07A0", VA = "0x1809B13A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002E2A")]
	[Address(RVA = "0x9B1750", Offset = "0x9B0B50", VA = "0x1809B1750", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildRankCreateRequest other)
	{
	}

	[Token(Token = "0x6002E2B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002E2C")]
	[Address(RVA = "0x9B1B30", Offset = "0x9B0F30", VA = "0x1809B1B30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
