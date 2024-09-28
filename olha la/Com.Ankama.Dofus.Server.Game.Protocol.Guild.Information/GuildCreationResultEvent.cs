using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004B0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildCreationResultEvent : IMessage<GuildCreationResultEvent>, IMessage, IEquatable<GuildCreationResultEvent>, IDeepCloneable<GuildCreationResultEvent>, IBufferMessage
{
	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildCreationResultEvent> _parser;

	[Token(Token = "0x4001008")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001009")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x400100A")]
	[FieldOffset(Offset = "0x18")]
	private SocialGroupOperationResult result_;

	[Token(Token = "0x17000A80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildCreationResultEvent> Parser
	{
		[Token(Token = "0x6003163")]
		[Address(RVA = "0x9CA490", Offset = "0x9C9890", VA = "0x1809CA490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A81")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003164")]
		[Address(RVA = "0x9CA3E0", Offset = "0x9C97E0", VA = "0x1809CA3E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A82")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003165")]
		[Address(RVA = "0x9CA4E0", Offset = "0x9C98E0", VA = "0x1809CA4E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A83")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialGroupOperationResult Result
	{
		[Token(Token = "0x6003169")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialGroupOperationResult);
		}
		[Token(Token = "0x600316A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003166")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreationResultEvent()
	{
	}

	[Token(Token = "0x6003167")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreationResultEvent(GuildCreationResultEvent other)
	{
	}

	[Token(Token = "0x6003168")]
	[Address(RVA = "0x9CA170", Offset = "0x9C9570", VA = "0x1809CA170", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreationResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600316B")]
	[Address(RVA = "0x9CA1F0", Offset = "0x9C95F0", VA = "0x1809CA1F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600316C")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildCreationResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600316D")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600316E")]
	[Address(RVA = "0x9CA280", Offset = "0x9C9680", VA = "0x1809CA280", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600316F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003170")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003171")]
	[Address(RVA = "0x9CA0E0", Offset = "0x9C94E0", VA = "0x1809CA0E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003172")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildCreationResultEvent other)
	{
	}

	[Token(Token = "0x6003173")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003174")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
