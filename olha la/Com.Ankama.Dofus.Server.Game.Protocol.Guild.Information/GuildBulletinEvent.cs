using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004C6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildBulletinEvent : IMessage<GuildBulletinEvent>, IMessage, IEquatable<GuildBulletinEvent>, IDeepCloneable<GuildBulletinEvent>, IBufferMessage
{
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildBulletinEvent> _parser;

	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001055")]
	public const int BulletinFieldNumber = 1;

	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x18")]
	private SocialNoticeInformation bulletin_;

	[Token(Token = "0x17000AB6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildBulletinEvent> Parser
	{
		[Token(Token = "0x6003268")]
		[Address(RVA = "0x9E9BB0", Offset = "0x9E8FB0", VA = "0x1809E9BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003269")]
		[Address(RVA = "0x9E9B00", Offset = "0x9E8F00", VA = "0x1809E9B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600326A")]
		[Address(RVA = "0x9E9D00", Offset = "0x9E9100", VA = "0x1809E9D00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AB9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialNoticeInformation Bulletin
	{
		[Token(Token = "0x600326E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600326F")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x600326B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBulletinEvent()
	{
	}

	[Token(Token = "0x600326C")]
	[Address(RVA = "0x9E9A90", Offset = "0x9E8E90", VA = "0x1809E9A90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBulletinEvent(GuildBulletinEvent other)
	{
	}

	[Token(Token = "0x600326D")]
	[Address(RVA = "0x9E9710", Offset = "0x9E8B10", VA = "0x1809E9710", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBulletinEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003270")]
	[Address(RVA = "0x9E97B0", Offset = "0x9E8BB0", VA = "0x1809E97B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003271")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildBulletinEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003272")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003273")]
	[Address(RVA = "0x9E9930", Offset = "0x9E8D30", VA = "0x1809E9930", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003274")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003275")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003276")]
	[Address(RVA = "0x9E9680", Offset = "0x9E8A80", VA = "0x1809E9680", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003277")]
	[Address(RVA = "0x9E9860", Offset = "0x9E8C60", VA = "0x1809E9860", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildBulletinEvent other)
	{
	}

	[Token(Token = "0x6003278")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003279")]
	[Address(RVA = "0x9E9C00", Offset = "0x9E9000", VA = "0x1809E9C00", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
