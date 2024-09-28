using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006CB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeErrorEvent : IMessage<ExchangeErrorEvent>, IMessage, IEquatable<ExchangeErrorEvent>, IDeepCloneable<ExchangeErrorEvent>, IBufferMessage
{
	[Token(Token = "0x20006CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20006CD")]
		public enum ExchangeError
		{
			[Token(Token = "0x40017E0")]
			[OriginalName("REQUEST_IMPOSSIBLE")]
			RequestImpossible,
			[Token(Token = "0x40017E1")]
			[OriginalName("REQUEST_CHARACTER_OCCUPIED")]
			RequestCharacterOccupied,
			[Token(Token = "0x40017E2")]
			[OriginalName("REQUEST_CHARACTER_JOB_NOT_EQUIPPED")]
			RequestCharacterJobNotEquipped,
			[Token(Token = "0x40017E3")]
			[OriginalName("REQUEST_CHARACTER_TOOL_TOO_FAR")]
			RequestCharacterToolTooFar,
			[Token(Token = "0x40017E4")]
			[OriginalName("REQUEST_CHARACTER_OVERLOADED")]
			RequestCharacterOverloaded,
			[Token(Token = "0x40017E5")]
			[OriginalName("REQUEST_CHARACTER_NOT_SUBSCRIBER")]
			RequestCharacterNotSubscriber,
			[Token(Token = "0x40017E6")]
			[OriginalName("REQUEST_CHARACTER_GUEST")]
			RequestCharacterGuest,
			[Token(Token = "0x40017E7")]
			[OriginalName("MOUNT_PADDOCK_ERROR")]
			MountPaddockError,
			[Token(Token = "0x40017E8")]
			[OriginalName("BID_SEARCH_ERROR")]
			BidSearchError,
			[Token(Token = "0x40017E9")]
			[OriginalName("SELL_ERROR")]
			SellError,
			[Token(Token = "0x40017EA")]
			[OriginalName("BUY_ERROR")]
			BuyError
		}
	}

	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeErrorEvent> _parser;

	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017DD")]
	public const int ErrorTypeFieldNumber = 1;

	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x18")]
	private Types.ExchangeError errorType_;

	[Token(Token = "0x17000FA4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeErrorEvent> Parser
	{
		[Token(Token = "0x6004925")]
		[Address(RVA = "0xAA7340", Offset = "0xAA6740", VA = "0x180AA7340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FA5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004926")]
		[Address(RVA = "0xAA7290", Offset = "0xAA6690", VA = "0x180AA7290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FA6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004927")]
		[Address(RVA = "0xAA7390", Offset = "0xAA6790", VA = "0x180AA7390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FA7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ExchangeError ErrorType
	{
		[Token(Token = "0x600492B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.ExchangeError);
		}
		[Token(Token = "0x600492C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004928")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeErrorEvent()
	{
	}

	[Token(Token = "0x6004929")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeErrorEvent(ExchangeErrorEvent other)
	{
	}

	[Token(Token = "0x600492A")]
	[Address(RVA = "0xAA7020", Offset = "0xAA6420", VA = "0x180AA7020", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600492D")]
	[Address(RVA = "0xAA70A0", Offset = "0xAA64A0", VA = "0x180AA70A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600492E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600492F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004930")]
	[Address(RVA = "0xAA7130", Offset = "0xAA6530", VA = "0x180AA7130", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004931")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004932")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004933")]
	[Address(RVA = "0xAA6F90", Offset = "0xAA6390", VA = "0x180AA6F90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004934")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeErrorEvent other)
	{
	}

	[Token(Token = "0x6004935")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004936")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
