using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004C4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMotdSetErrorEvent : IMessage<GuildMotdSetErrorEvent>, IMessage, IEquatable<GuildMotdSetErrorEvent>, IDeepCloneable<GuildMotdSetErrorEvent>, IBufferMessage
{
	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMotdSetErrorEvent> _parser;

	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001050")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x18")]
	private SocialNoticeError error_;

	[Token(Token = "0x17000AB2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildMotdSetErrorEvent> Parser
	{
		[Token(Token = "0x6003252")]
		[Address(RVA = "0x9F5AF0", Offset = "0x9F4EF0", VA = "0x1809F5AF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003253")]
		[Address(RVA = "0x9F5A40", Offset = "0x9F4E40", VA = "0x1809F5A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003254")]
		[Address(RVA = "0x9F5B40", Offset = "0x9F4F40", VA = "0x1809F5B40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialNoticeError Error
	{
		[Token(Token = "0x6003258")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialNoticeError);
		}
		[Token(Token = "0x6003259")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003255")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMotdSetErrorEvent()
	{
	}

	[Token(Token = "0x6003256")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMotdSetErrorEvent(GuildMotdSetErrorEvent other)
	{
	}

	[Token(Token = "0x6003257")]
	[Address(RVA = "0x9F57D0", Offset = "0x9F4BD0", VA = "0x1809F57D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMotdSetErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600325A")]
	[Address(RVA = "0x9F5850", Offset = "0x9F4C50", VA = "0x1809F5850", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600325B")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildMotdSetErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600325C")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600325D")]
	[Address(RVA = "0x9F58E0", Offset = "0x9F4CE0", VA = "0x1809F58E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600325E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600325F")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003260")]
	[Address(RVA = "0x9F5740", Offset = "0x9F4B40", VA = "0x1809F5740", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003261")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildMotdSetErrorEvent other)
	{
	}

	[Token(Token = "0x6003262")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003263")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
