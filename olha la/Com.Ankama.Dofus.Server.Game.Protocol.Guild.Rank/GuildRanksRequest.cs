using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank;

[Token(Token = "0x2000460")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRanksRequest : IMessage<GuildRanksRequest>, IMessage, IEquatable<GuildRanksRequest>, IDeepCloneable<GuildRanksRequest>, IBufferMessage
{
	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRanksRequest> _parser;

	[Token(Token = "0x4000F00")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170009CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRanksRequest> Parser
	{
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x9B3FB0", Offset = "0x9B33B0", VA = "0x1809B3FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x9B3F00", Offset = "0x9B3300", VA = "0x1809B3F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009D1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x9B4000", Offset = "0x9B3400", VA = "0x1809B4000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E06")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRanksRequest()
	{
	}

	[Token(Token = "0x6002E07")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRanksRequest(GuildRanksRequest other)
	{
	}

	[Token(Token = "0x6002E08")]
	[Address(RVA = "0x9B3CA0", Offset = "0x9B30A0", VA = "0x1809B3CA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRanksRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002E09")]
	[Address(RVA = "0x9B3D20", Offset = "0x9B3120", VA = "0x1809B3D20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E0A")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRanksRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E0B")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002E0C")]
	[Address(RVA = "0x9B3DA0", Offset = "0x9B31A0", VA = "0x1809B3DA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002E10")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRanksRequest other)
	{
	}

	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
