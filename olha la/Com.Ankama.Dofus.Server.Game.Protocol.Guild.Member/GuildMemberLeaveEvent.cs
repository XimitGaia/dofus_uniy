using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x200047B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMemberLeaveEvent : IMessage<GuildMemberLeaveEvent>, IMessage, IEquatable<GuildMemberLeaveEvent>, IDeepCloneable<GuildMemberLeaveEvent>, IBufferMessage
{
	[Token(Token = "0x4000F4D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMemberLeaveEvent> _parser;

	[Token(Token = "0x4000F4E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F4F")]
	public const int KickedFieldNumber = 1;

	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x18")]
	private bool kicked_;

	[Token(Token = "0x4000F51")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17000A08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildMemberLeaveEvent> Parser
	{
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x9D4400", Offset = "0x9D3800", VA = "0x1809D4400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A09")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x9D4350", Offset = "0x9D3750", VA = "0x1809D4350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0x9D4590", Offset = "0x9D3990", VA = "0x1809D4590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Kicked
	{
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000A0C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6002F2A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberLeaveEvent()
	{
	}

	[Token(Token = "0x6002F2B")]
	[Address(RVA = "0x9D42F0", Offset = "0x9D36F0", VA = "0x1809D42F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMemberLeaveEvent(GuildMemberLeaveEvent other)
	{
	}

	[Token(Token = "0x6002F2C")]
	[Address(RVA = "0x9D3EF0", Offset = "0x9D32F0", VA = "0x1809D3EF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMemberLeaveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002F31")]
	[Address(RVA = "0x9D3FC0", Offset = "0x9D33C0", VA = "0x1809D3FC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F32")]
	[Address(RVA = "0x9D3F80", Offset = "0x9D3380", VA = "0x1809D3F80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMemberLeaveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F33")]
	[Address(RVA = "0x9D4060", Offset = "0x9D3460", VA = "0x1809D4060", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002F34")]
	[Address(RVA = "0x9D4190", Offset = "0x9D3590", VA = "0x1809D4190", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002F35")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002F36")]
	[Address(RVA = "0x9D4510", Offset = "0x9D3910", VA = "0x1809D4510", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002F37")]
	[Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002F38")]
	[Address(RVA = "0x9D4130", Offset = "0x9D3530", VA = "0x1809D4130", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMemberLeaveEvent other)
	{
	}

	[Token(Token = "0x6002F39")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002F3A")]
	[Address(RVA = "0x9D4450", Offset = "0x9D3850", VA = "0x1809D4450", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
