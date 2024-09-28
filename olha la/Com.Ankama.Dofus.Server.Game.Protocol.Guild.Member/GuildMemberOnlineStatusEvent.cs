using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x2000475")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMemberOnlineStatusEvent : IMessage<GuildMemberOnlineStatusEvent>, IMessage, IEquatable<GuildMemberOnlineStatusEvent>, IDeepCloneable<GuildMemberOnlineStatusEvent>, IBufferMessage
{
	[Token(Token = "0x4000F3B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMemberOnlineStatusEvent> _parser;

	[Token(Token = "0x4000F3C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F3D")]
	public const int MemberIdFieldNumber = 1;

	[Token(Token = "0x4000F3E")]
	[FieldOffset(Offset = "0x18")]
	private long memberId_;

	[Token(Token = "0x4000F3F")]
	public const int OnlineFieldNumber = 2;

	[Token(Token = "0x4000F40")]
	[FieldOffset(Offset = "0x20")]
	private bool online_;

	[Token(Token = "0x170009FB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildMemberOnlineStatusEvent> Parser
	{
		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x9D4C10", Offset = "0x9D4010", VA = "0x1809D4C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002EE5")]
		[Address(RVA = "0x9D4B60", Offset = "0x9D3F60", VA = "0x1809D4B60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002EE6")]
		[Address(RVA = "0x9D4DA0", Offset = "0x9D41A0", VA = "0x1809D4DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MemberId
	{
		[Token(Token = "0x6002EEA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002EEB")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170009FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Online
	{
		[Token(Token = "0x6002EEC")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002EED")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6002EE7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMemberOnlineStatusEvent()
	{
	}

	[Token(Token = "0x6002EE8")]
	[Address(RVA = "0x9D4B00", Offset = "0x9D3F00", VA = "0x1809D4B00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberOnlineStatusEvent(GuildMemberOnlineStatusEvent other)
	{
	}

	[Token(Token = "0x6002EE9")]
	[Address(RVA = "0x9D4700", Offset = "0x9D3B00", VA = "0x1809D4700", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberOnlineStatusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002EEE")]
	[Address(RVA = "0x9D47D0", Offset = "0x9D3BD0", VA = "0x1809D47D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x9D4790", Offset = "0x9D3B90", VA = "0x1809D4790", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMemberOnlineStatusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x9D4870", Offset = "0x9D3C70", VA = "0x1809D4870", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x9D49A0", Offset = "0x9D3DA0", VA = "0x1809D49A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x9D4D20", Offset = "0x9D4120", VA = "0x1809D4D20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x9D4670", Offset = "0x9D3A70", VA = "0x1809D4670", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x9D4940", Offset = "0x9D3D40", VA = "0x1809D4940", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMemberOnlineStatusEvent other)
	{
	}

	[Token(Token = "0x6002EF6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002EF7")]
	[Address(RVA = "0x9D4C60", Offset = "0x9D4060", VA = "0x1809D4C60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
