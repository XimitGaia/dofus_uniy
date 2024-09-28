using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account;

[Token(Token = "0x2000D3C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuestLimitationEvent : IMessage<GuestLimitationEvent>, IMessage, IEquatable<GuestLimitationEvent>, IDeepCloneable<GuestLimitationEvent>, IBufferMessage
{
	[Token(Token = "0x2000D3D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000D3E")]
		public enum GuestLimitation
		{
			[Token(Token = "0x4003083")]
			[OriginalName("LIMITED_TO_REGISTERED")]
			LimitedToRegistered,
			[Token(Token = "0x4003084")]
			[OriginalName("LIMIT_ON_JOB_XP")]
			LimitOnJobXp,
			[Token(Token = "0x4003085")]
			[OriginalName("LIMIT_ON_JOB_USE")]
			LimitOnJobUse,
			[Token(Token = "0x4003086")]
			[OriginalName("LIMIT_ON_MAP")]
			LimitOnMap,
			[Token(Token = "0x4003087")]
			[OriginalName("LIMIT_ON_ITEM")]
			LimitOnItem,
			[Token(Token = "0x4003088")]
			[OriginalName("LIMIT_ON_CHAT")]
			LimitOnChat,
			[Token(Token = "0x4003089")]
			[OriginalName("LIMIT_ON_GUILD")]
			LimitOnGuild
		}
	}

	[Token(Token = "0x400307E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuestLimitationEvent> _parser;

	[Token(Token = "0x400307F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003080")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4003081")]
	[FieldOffset(Offset = "0x18")]
	private Types.GuestLimitation reason_;

	[Token(Token = "0x17001E6B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuestLimitationEvent> Parser
	{
		[Token(Token = "0x6008B61")]
		[Address(RVA = "0xCBBF10", Offset = "0xCBB310", VA = "0x180CBBF10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E6C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008B62")]
		[Address(RVA = "0xCBBE60", Offset = "0xCBB260", VA = "0x180CBBE60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E6D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008B63")]
		[Address(RVA = "0xCBBF60", Offset = "0xCBB360", VA = "0x180CBBF60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E6E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.GuestLimitation Reason
	{
		[Token(Token = "0x6008B67")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.GuestLimitation);
		}
		[Token(Token = "0x6008B68")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6008B64")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuestLimitationEvent()
	{
	}

	[Token(Token = "0x6008B65")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuestLimitationEvent(GuestLimitationEvent other)
	{
	}

	[Token(Token = "0x6008B66")]
	[Address(RVA = "0xCBBBF0", Offset = "0xCBAFF0", VA = "0x180CBBBF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuestLimitationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008B69")]
	[Address(RVA = "0xCBBC70", Offset = "0xCBB070", VA = "0x180CBBC70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B6A")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuestLimitationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B6B")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008B6C")]
	[Address(RVA = "0xCBBD00", Offset = "0xCBB100", VA = "0x180CBBD00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008B6D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008B6E")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008B6F")]
	[Address(RVA = "0xCBBB60", Offset = "0xCBAF60", VA = "0x180CBBB60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008B70")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuestLimitationEvent other)
	{
	}

	[Token(Token = "0x6008B71")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008B72")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
