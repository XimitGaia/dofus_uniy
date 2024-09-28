using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account;

[Token(Token = "0x2000D36")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AccountInformationUpdateEvent : IMessage<AccountInformationUpdateEvent>, IMessage, IEquatable<AccountInformationUpdateEvent>, IDeepCloneable<AccountInformationUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4003069")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AccountInformationUpdateEvent> _parser;

	[Token(Token = "0x400306A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400306B")]
	public const int SubscriptionEndDateFieldNumber = 1;

	[Token(Token = "0x400306C")]
	[FieldOffset(Offset = "0x18")]
	private long subscriptionEndDate_;

	[Token(Token = "0x17001E5C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AccountInformationUpdateEvent> Parser
	{
		[Token(Token = "0x6008B19")]
		[Address(RVA = "0xCB9040", Offset = "0xCB8440", VA = "0x180CB9040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E5D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008B1A")]
		[Address(RVA = "0xCB8F90", Offset = "0xCB8390", VA = "0x180CB8F90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E5E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008B1B")]
		[Address(RVA = "0xCB9090", Offset = "0xCB8490", VA = "0x180CB9090", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E5F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long SubscriptionEndDate
	{
		[Token(Token = "0x6008B1F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008B20")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6008B1C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AccountInformationUpdateEvent()
	{
	}

	[Token(Token = "0x6008B1D")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AccountInformationUpdateEvent(AccountInformationUpdateEvent other)
	{
	}

	[Token(Token = "0x6008B1E")]
	[Address(RVA = "0xCB8D20", Offset = "0xCB8120", VA = "0x180CB8D20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AccountInformationUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008B21")]
	[Address(RVA = "0xCB8DA0", Offset = "0xCB81A0", VA = "0x180CB8DA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B22")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AccountInformationUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B23")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008B24")]
	[Address(RVA = "0xCB8E30", Offset = "0xCB8230", VA = "0x180CB8E30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008B25")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008B26")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008B27")]
	[Address(RVA = "0xCB8C90", Offset = "0xCB8090", VA = "0x180CB8C90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008B28")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AccountInformationUpdateEvent other)
	{
	}

	[Token(Token = "0x6008B29")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008B2A")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
