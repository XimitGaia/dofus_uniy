using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x200085C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChannelUpdateEvent : IMessage<ChannelUpdateEvent>, IMessage, IEquatable<ChannelUpdateEvent>, IDeepCloneable<ChannelUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4001CFD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChannelUpdateEvent> _parser;

	[Token(Token = "0x4001CFE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001CFF")]
	public const int ChannelFieldNumber = 1;

	[Token(Token = "0x4001D00")]
	[FieldOffset(Offset = "0x18")]
	private Channel channel_;

	[Token(Token = "0x4001D01")]
	public const int EnableFieldNumber = 2;

	[Token(Token = "0x4001D02")]
	[FieldOffset(Offset = "0x1C")]
	private bool enable_;

	[Token(Token = "0x170012EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChannelUpdateEvent> Parser
	{
		[Token(Token = "0x60058D3")]
		[Address(RVA = "0xAFB9E0", Offset = "0xAFADE0", VA = "0x180AFB9E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012ED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60058D4")]
		[Address(RVA = "0xAFB930", Offset = "0xAFAD30", VA = "0x180AFB930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60058D5")]
		[Address(RVA = "0xAFBA30", Offset = "0xAFAE30", VA = "0x180AFBA30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012EF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Channel Channel
	{
		[Token(Token = "0x60058D9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Channel);
		}
		[Token(Token = "0x60058DA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170012F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Enable
	{
		[Token(Token = "0x60058DB")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60058DC")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x60058D6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChannelUpdateEvent()
	{
	}

	[Token(Token = "0x60058D7")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChannelUpdateEvent(ChannelUpdateEvent other)
	{
	}

	[Token(Token = "0x60058D8")]
	[Address(RVA = "0xAFB5F0", Offset = "0xAFA9F0", VA = "0x180AFB5F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChannelUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60058DD")]
	[Address(RVA = "0xAFB680", Offset = "0xAFAA80", VA = "0x180AFB680", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60058DE")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChannelUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60058DF")]
	[Address(RVA = "0xAFB710", Offset = "0xAFAB10", VA = "0x180AFB710", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60058E0")]
	[Address(RVA = "0xAFB7D0", Offset = "0xAFABD0", VA = "0x180AFB7D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60058E1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60058E2")]
	[Address(RVA = "0xAA7940", Offset = "0xAA6D40", VA = "0x180AA7940", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60058E3")]
	[Address(RVA = "0xAFB560", Offset = "0xAFA960", VA = "0x180AFB560", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60058E4")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChannelUpdateEvent other)
	{
	}

	[Token(Token = "0x60058E5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60058E6")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
