using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Emote;

[Token(Token = "0x2000737")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EmotePlayRequest : IMessage<EmotePlayRequest>, IMessage, IEquatable<EmotePlayRequest>, IDeepCloneable<EmotePlayRequest>, IBufferMessage
{
	[Token(Token = "0x4001964")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EmotePlayRequest> _parser;

	[Token(Token = "0x4001965")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001966")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x4001967")]
	[FieldOffset(Offset = "0x18")]
	private int emoteId_;

	[Token(Token = "0x4001968")]
	public const int OnlyPlayEmoteFieldNumber = 2;

	[Token(Token = "0x4001969")]
	[FieldOffset(Offset = "0x1C")]
	private bool onlyPlayEmote_;

	[Token(Token = "0x17001094")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EmotePlayRequest> Parser
	{
		[Token(Token = "0x6004D70")]
		[Address(RVA = "0xAB6A50", Offset = "0xAB5E50", VA = "0x180AB6A50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001095")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004D71")]
		[Address(RVA = "0xAB69A0", Offset = "0xAB5DA0", VA = "0x180AB69A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001096")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004D72")]
		[Address(RVA = "0xAB6AA0", Offset = "0xAB5EA0", VA = "0x180AB6AA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001097")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EmoteId
	{
		[Token(Token = "0x6004D76")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004D77")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001098")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OnlyPlayEmote
	{
		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6004D73")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayRequest()
	{
	}

	[Token(Token = "0x6004D74")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayRequest(EmotePlayRequest other)
	{
	}

	[Token(Token = "0x6004D75")]
	[Address(RVA = "0xAB6660", Offset = "0xAB5A60", VA = "0x180AB6660", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EmotePlayRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004D7A")]
	[Address(RVA = "0xAB66F0", Offset = "0xAB5AF0", VA = "0x180AB66F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D7B")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EmotePlayRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D7C")]
	[Address(RVA = "0xAB6780", Offset = "0xAB5B80", VA = "0x180AB6780", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004D7D")]
	[Address(RVA = "0xAB6840", Offset = "0xAB5C40", VA = "0x180AB6840", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004D7E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004D7F")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004D80")]
	[Address(RVA = "0xAB65D0", Offset = "0xAB59D0", VA = "0x180AB65D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004D81")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EmotePlayRequest other)
	{
	}

	[Token(Token = "0x6004D82")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004D83")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
