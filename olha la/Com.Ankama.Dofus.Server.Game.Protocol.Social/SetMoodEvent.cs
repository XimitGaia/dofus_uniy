using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000121")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetMoodEvent : IMessage<SetMoodEvent>, IMessage, IEquatable<SetMoodEvent>, IDeepCloneable<SetMoodEvent>, IBufferMessage
{
	[Token(Token = "0x2000122")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000123")]
		public enum Result
		{
			[Token(Token = "0x40003DC")]
			[OriginalName("OK")]
			Ok,
			[Token(Token = "0x40003DD")]
			[OriginalName("ERROR_UNKNOWN")]
			ErrorUnknown,
			[Token(Token = "0x40003DE")]
			[OriginalName("ERROR_FLOOD")]
			ErrorFlood
		}
	}

	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SetMoodEvent> _parser;

	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003D7")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x18")]
	private Types.Result result_;

	[Token(Token = "0x40003D9")]
	public const int SmileyIdFieldNumber = 2;

	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x1C")]
	private int smileyId_;

	[Token(Token = "0x1700025E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetMoodEvent> Parser
	{
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xB6CBB0", Offset = "0xB6BFB0", VA = "0x180B6CBB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xB6CB00", Offset = "0xB6BF00", VA = "0x180B6CB00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000260")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xB6CC00", Offset = "0xB6C000", VA = "0x180B6CC00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000261")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Result Result
	{
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Result);
		}
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000262")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SmileyId
	{
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetMoodEvent()
	{
	}

	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetMoodEvent(SetMoodEvent other)
	{
	}

	[Token(Token = "0x6000B29")]
	[Address(RVA = "0xB6C880", Offset = "0xB6BC80", VA = "0x180B6C880", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetMoodEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0xB6C910", Offset = "0xB6BD10", VA = "0x180B6C910", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetMoodEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B30")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000B31")]
	[Address(RVA = "0xB6C9A0", Offset = "0xB6BDA0", VA = "0x180B6C9A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0xB6C7C0", Offset = "0xB6BBC0", VA = "0x180B6C7C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SetMoodEvent other)
	{
	}

	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
