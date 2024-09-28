using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x2000481")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildJoinedEvent : IMessage<GuildJoinedEvent>, IMessage, IEquatable<GuildJoinedEvent>, IDeepCloneable<GuildJoinedEvent>, IBufferMessage
{
	[Token(Token = "0x4000F5E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildJoinedEvent> _parser;

	[Token(Token = "0x4000F5F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F60")]
	public const int GuildInformationFieldNumber = 1;

	[Token(Token = "0x4000F61")]
	[FieldOffset(Offset = "0x18")]
	private GuildInformation guildInformation_;

	[Token(Token = "0x4000F62")]
	public const int RankIdFieldNumber = 2;

	[Token(Token = "0x4000F63")]
	[FieldOffset(Offset = "0x20")]
	private int rankId_;

	[Token(Token = "0x17000A15")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildJoinedEvent> Parser
	{
		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x9D2220", Offset = "0x9D1620", VA = "0x1809D2220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A16")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0x9D2170", Offset = "0x9D1570", VA = "0x1809D2170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A17")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002F6D")]
		[Address(RVA = "0x9D2410", Offset = "0x9D1810", VA = "0x1809D2410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A18")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInformation GuildInformation
	{
		[Token(Token = "0x6002F71")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F72")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A19")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankId
	{
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6002F6E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildJoinedEvent()
	{
	}

	[Token(Token = "0x6002F6F")]
	[Address(RVA = "0x9D20F0", Offset = "0x9D14F0", VA = "0x1809D20F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildJoinedEvent(GuildJoinedEvent other)
	{
	}

	[Token(Token = "0x6002F70")]
	[Address(RVA = "0x9D1D60", Offset = "0x9D1160", VA = "0x1809D1D60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildJoinedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002F75")]
	[Address(RVA = "0x9D1E10", Offset = "0x9D1210", VA = "0x1809D1E10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F76")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildJoinedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x9D1F90", Offset = "0x9D1390", VA = "0x1809D1F90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002F79")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x9D2390", Offset = "0x9D1790", VA = "0x1809D2390", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x9D1CA0", Offset = "0x9D10A0", VA = "0x1809D1CA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x9D1EC0", Offset = "0x9D12C0", VA = "0x1809D1EC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildJoinedEvent other)
	{
	}

	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x9D2270", Offset = "0x9D1670", VA = "0x1809D2270", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
