using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank;

[Token(Token = "0x200046A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildRankRemoveRequest : IMessage<GuildRankRemoveRequest>, IMessage, IEquatable<GuildRankRemoveRequest>, IDeepCloneable<GuildRankRemoveRequest>, IBufferMessage
{
	[Token(Token = "0x4000F1E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildRankRemoveRequest> _parser;

	[Token(Token = "0x4000F1F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F20")]
	public const int RankIdFieldNumber = 1;

	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x18")]
	private int rankId_;

	[Token(Token = "0x4000F22")]
	public const int NewRankIdFieldNumber = 2;

	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x1C")]
	private int newRankId_;

	[Token(Token = "0x170009E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRankRemoveRequest> Parser
	{
		[Token(Token = "0x6002E73")]
		[Address(RVA = "0x9DC700", Offset = "0x9DBB00", VA = "0x1809DC700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002E74")]
		[Address(RVA = "0x9DC650", Offset = "0x9DBA50", VA = "0x1809DC650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002E75")]
		[Address(RVA = "0x9DC750", Offset = "0x9DBB50", VA = "0x1809DC750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RankId
	{
		[Token(Token = "0x6002E79")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002E7A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170009E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NewRankId
	{
		[Token(Token = "0x6002E7B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002E7C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6002E76")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankRemoveRequest()
	{
	}

	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankRemoveRequest(GuildRankRemoveRequest other)
	{
	}

	[Token(Token = "0x6002E78")]
	[Address(RVA = "0x9DC3D0", Offset = "0x9DB7D0", VA = "0x1809DC3D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRankRemoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002E7D")]
	[Address(RVA = "0x9DC460", Offset = "0x9DB860", VA = "0x1809DC460", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E7E")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRankRemoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E7F")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002E80")]
	[Address(RVA = "0x9DC4F0", Offset = "0x9DB8F0", VA = "0x1809DC4F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002E81")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002E82")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x9DC310", Offset = "0x9DB710", VA = "0x1809DC310", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002E84")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRankRemoveRequest other)
	{
	}

	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002E86")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
