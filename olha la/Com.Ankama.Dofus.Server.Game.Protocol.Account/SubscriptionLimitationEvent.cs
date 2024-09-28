using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account;

[Token(Token = "0x2000D42")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubscriptionLimitationEvent : IMessage<SubscriptionLimitationEvent>, IMessage, IEquatable<SubscriptionLimitationEvent>, IDeepCloneable<SubscriptionLimitationEvent>, IBufferMessage
{
	[Token(Token = "0x2000D43")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000D44")]
		public enum SubscriptionRequired
		{
			[Token(Token = "0x4003095")]
			[OriginalName("LIMITED_TO_SUBSCRIBER")]
			LimitedToSubscriber,
			[Token(Token = "0x4003096")]
			[OriginalName("LIMIT_ON_JOB_XP")]
			LimitOnJobXp,
			[Token(Token = "0x4003097")]
			[OriginalName("LIMIT_ON_JOB_USE")]
			LimitOnJobUse,
			[Token(Token = "0x4003098")]
			[OriginalName("LIMIT_ON_MAP")]
			LimitOnMap,
			[Token(Token = "0x4003099")]
			[OriginalName("LIMIT_ON_ITEM")]
			LimitOnItem,
			[Token(Token = "0x400309A")]
			[OriginalName("LIMIT_ON_HAVEN_BAG")]
			LimitOnHavenBag
		}
	}

	[Token(Token = "0x4003090")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SubscriptionLimitationEvent> _parser;

	[Token(Token = "0x4003091")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003092")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4003093")]
	[FieldOffset(Offset = "0x18")]
	private Types.SubscriptionRequired reason_;

	[Token(Token = "0x17001E73")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SubscriptionLimitationEvent> Parser
	{
		[Token(Token = "0x6008B8D")]
		[Address(RVA = "0xCBC8E0", Offset = "0xCBBCE0", VA = "0x180CBC8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E74")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008B8E")]
		[Address(RVA = "0xCBC830", Offset = "0xCBBC30", VA = "0x180CBC830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E75")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008B8F")]
		[Address(RVA = "0xCBC930", Offset = "0xCBBD30", VA = "0x180CBC930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E76")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.SubscriptionRequired Reason
	{
		[Token(Token = "0x6008B93")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.SubscriptionRequired);
		}
		[Token(Token = "0x6008B94")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6008B90")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SubscriptionLimitationEvent()
	{
	}

	[Token(Token = "0x6008B91")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SubscriptionLimitationEvent(SubscriptionLimitationEvent other)
	{
	}

	[Token(Token = "0x6008B92")]
	[Address(RVA = "0xCBC5C0", Offset = "0xCBB9C0", VA = "0x180CBC5C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscriptionLimitationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008B95")]
	[Address(RVA = "0xCBC640", Offset = "0xCBBA40", VA = "0x180CBC640", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B96")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SubscriptionLimitationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B97")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008B98")]
	[Address(RVA = "0xCBC6D0", Offset = "0xCBBAD0", VA = "0x180CBC6D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008B99")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008B9A")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008B9B")]
	[Address(RVA = "0xCBC530", Offset = "0xCBB930", VA = "0x180CBC530", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008B9C")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubscriptionLimitationEvent other)
	{
	}

	[Token(Token = "0x6008B9D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008B9E")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
