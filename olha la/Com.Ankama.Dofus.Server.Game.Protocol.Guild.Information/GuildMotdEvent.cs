using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004C2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMotdEvent : IMessage<GuildMotdEvent>, IMessage, IEquatable<GuildMotdEvent>, IDeepCloneable<GuildMotdEvent>, IBufferMessage
{
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMotdEvent> _parser;

	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400104B")]
	public const int MotdFieldNumber = 1;

	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x18")]
	private SocialNoticeInformation motd_;

	[Token(Token = "0x17000AAE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildMotdEvent> Parser
	{
		[Token(Token = "0x600323C")]
		[Address(RVA = "0x9F5510", Offset = "0x9F4910", VA = "0x1809F5510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AAF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600323D")]
		[Address(RVA = "0x9F5460", Offset = "0x9F4860", VA = "0x1809F5460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600323E")]
		[Address(RVA = "0x9F5660", Offset = "0x9F4A60", VA = "0x1809F5660", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialNoticeInformation Motd
	{
		[Token(Token = "0x6003242")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003243")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x600323F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMotdEvent()
	{
	}

	[Token(Token = "0x6003240")]
	[Address(RVA = "0x9E9A90", Offset = "0x9E8E90", VA = "0x1809E9A90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMotdEvent(GuildMotdEvent other)
	{
	}

	[Token(Token = "0x6003241")]
	[Address(RVA = "0x9F50E0", Offset = "0x9F44E0", VA = "0x1809F50E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMotdEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003244")]
	[Address(RVA = "0x9F5180", Offset = "0x9F4580", VA = "0x1809F5180", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003245")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildMotdEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003246")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003247")]
	[Address(RVA = "0x9F5300", Offset = "0x9F4700", VA = "0x1809F5300", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003248")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003249")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600324A")]
	[Address(RVA = "0x9F5050", Offset = "0x9F4450", VA = "0x1809F5050", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600324B")]
	[Address(RVA = "0x9F5230", Offset = "0x9F4630", VA = "0x1809F5230", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMotdEvent other)
	{
	}

	[Token(Token = "0x600324C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600324D")]
	[Address(RVA = "0x9F5560", Offset = "0x9F4960", VA = "0x1809F5560", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
