using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account;

[Token(Token = "0x2000D38")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AccountSubscriptionElapsedDurationUpdateEvent : IMessage<AccountSubscriptionElapsedDurationUpdateEvent>, IMessage, IEquatable<AccountSubscriptionElapsedDurationUpdateEvent>, IDeepCloneable<AccountSubscriptionElapsedDurationUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x400306E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AccountSubscriptionElapsedDurationUpdateEvent> _parser;

	[Token(Token = "0x400306F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003070")]
	public const int SubscriptionElapsedDurationFieldNumber = 1;

	[Token(Token = "0x4003071")]
	[FieldOffset(Offset = "0x18")]
	private long subscriptionElapsedDuration_;

	[Token(Token = "0x17001E60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AccountSubscriptionElapsedDurationUpdateEvent> Parser
	{
		[Token(Token = "0x6008B2F")]
		[Address(RVA = "0xCBA530", Offset = "0xCB9930", VA = "0x180CBA530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E61")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008B30")]
		[Address(RVA = "0xCBA480", Offset = "0xCB9880", VA = "0x180CBA480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E62")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008B31")]
		[Address(RVA = "0xCBA580", Offset = "0xCB9980", VA = "0x180CBA580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E63")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SubscriptionElapsedDuration
	{
		[Token(Token = "0x6008B35")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008B36")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6008B32")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountSubscriptionElapsedDurationUpdateEvent()
	{
	}

	[Token(Token = "0x6008B33")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountSubscriptionElapsedDurationUpdateEvent(AccountSubscriptionElapsedDurationUpdateEvent other)
	{
	}

	[Token(Token = "0x6008B34")]
	[Address(RVA = "0xCBA210", Offset = "0xCB9610", VA = "0x180CBA210", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountSubscriptionElapsedDurationUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008B37")]
	[Address(RVA = "0xCBA290", Offset = "0xCB9690", VA = "0x180CBA290", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B38")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AccountSubscriptionElapsedDurationUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B39")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008B3A")]
	[Address(RVA = "0xCBA320", Offset = "0xCB9720", VA = "0x180CBA320", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008B3B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008B3C")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008B3D")]
	[Address(RVA = "0xCBA180", Offset = "0xCB9580", VA = "0x180CBA180", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008B3E")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AccountSubscriptionElapsedDurationUpdateEvent other)
	{
	}

	[Token(Token = "0x6008B3F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008B40")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
