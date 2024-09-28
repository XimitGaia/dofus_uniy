using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004C8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildBulletinSetErrorEvent : IMessage<GuildBulletinSetErrorEvent>, IMessage, IEquatable<GuildBulletinSetErrorEvent>, IDeepCloneable<GuildBulletinSetErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildBulletinSetErrorEvent> _parser;

	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400105A")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x18")]
	private SocialNoticeError error_;

	[Token(Token = "0x17000ABA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildBulletinSetErrorEvent> Parser
	{
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x9EA190", Offset = "0x9E9590", VA = "0x1809EA190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ABB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600327F")]
		[Address(RVA = "0x9EA0E0", Offset = "0x9E94E0", VA = "0x1809EA0E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ABC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003280")]
		[Address(RVA = "0x9EA1E0", Offset = "0x9E95E0", VA = "0x1809EA1E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ABD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialNoticeError Error
	{
		[Token(Token = "0x6003284")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialNoticeError);
		}
		[Token(Token = "0x6003285")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003281")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBulletinSetErrorEvent()
	{
	}

	[Token(Token = "0x6003282")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildBulletinSetErrorEvent(GuildBulletinSetErrorEvent other)
	{
	}

	[Token(Token = "0x6003283")]
	[Address(RVA = "0x9E9E70", Offset = "0x9E9270", VA = "0x1809E9E70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildBulletinSetErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003286")]
	[Address(RVA = "0x9E9EF0", Offset = "0x9E92F0", VA = "0x1809E9EF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003287")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildBulletinSetErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003288")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003289")]
	[Address(RVA = "0x9E9F80", Offset = "0x9E9380", VA = "0x1809E9F80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600328A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600328B")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600328C")]
	[Address(RVA = "0x9E9DE0", Offset = "0x9E91E0", VA = "0x1809E9DE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600328D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildBulletinSetErrorEvent other)
	{
	}

	[Token(Token = "0x600328E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600328F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
