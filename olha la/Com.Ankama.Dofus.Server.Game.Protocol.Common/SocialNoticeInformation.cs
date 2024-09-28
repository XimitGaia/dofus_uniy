using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B04")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialNoticeInformation : IMessage<SocialNoticeInformation>, IMessage, IEquatable<SocialNoticeInformation>, IDeepCloneable<SocialNoticeInformation>, IBufferMessage
{
	[Token(Token = "0x40028BF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SocialNoticeInformation> _parser;

	[Token(Token = "0x40028C0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40028C1")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x40028C2")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x40028C3")]
	public const int TimestampFieldNumber = 2;

	[Token(Token = "0x40028C4")]
	[FieldOffset(Offset = "0x20")]
	private long timestamp_;

	[Token(Token = "0x40028C5")]
	public const int MemberIdFieldNumber = 3;

	[Token(Token = "0x40028C6")]
	[FieldOffset(Offset = "0x28")]
	private long memberId_;

	[Token(Token = "0x40028C7")]
	public const int MemberNameFieldNumber = 4;

	[Token(Token = "0x40028C8")]
	[FieldOffset(Offset = "0x30")]
	private string memberName_;

	[Token(Token = "0x1700195F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialNoticeInformation> Parser
	{
		[Token(Token = "0x60073B4")]
		[Address(RVA = "0xC0C570", Offset = "0xC0B970", VA = "0x180C0C570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001960")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60073B5")]
		[Address(RVA = "0xC0C4C0", Offset = "0xC0B8C0", VA = "0x180C0C4C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001961")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60073B6")]
		[Address(RVA = "0xC0C7E0", Offset = "0xC0BBE0", VA = "0x180C0C7E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001962")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Content
	{
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60073BB")]
		[Address(RVA = "0xC0C8C0", Offset = "0xC0BCC0", VA = "0x180C0C8C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001963")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Timestamp
	{
		[Token(Token = "0x60073BC")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60073BD")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001964")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MemberId
	{
		[Token(Token = "0x60073BE")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60073BF")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17001965")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MemberName
	{
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60073C1")]
		[Address(RVA = "0xC0C930", Offset = "0xC0BD30", VA = "0x180C0C930")]
		set
		{
		}
	}

	[Token(Token = "0x60073B7")]
	[Address(RVA = "0xC0C450", Offset = "0xC0B850", VA = "0x180C0C450")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialNoticeInformation()
	{
	}

	[Token(Token = "0x60073B8")]
	[Address(RVA = "0xC0C360", Offset = "0xC0B760", VA = "0x180C0C360")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialNoticeInformation(SocialNoticeInformation other)
	{
	}

	[Token(Token = "0x60073B9")]
	[Address(RVA = "0xC0BE00", Offset = "0xC0B200", VA = "0x180C0BE00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialNoticeInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60073C2")]
	[Address(RVA = "0xC0BF10", Offset = "0xC0B310", VA = "0x180C0BF10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60073C3")]
	[Address(RVA = "0xC0BFF0", Offset = "0xC0B3F0", VA = "0x180C0BFF0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SocialNoticeInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60073C4")]
	[Address(RVA = "0xC0C080", Offset = "0xC0B480", VA = "0x180C0C080", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60073C5")]
	[Address(RVA = "0xC0C200", Offset = "0xC0B600", VA = "0x180C0C200", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60073C6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60073C7")]
	[Address(RVA = "0xC0C700", Offset = "0xC0BB00", VA = "0x180C0C700", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60073C8")]
	[Address(RVA = "0xC0BCE0", Offset = "0xC0B0E0", VA = "0x180C0BCE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60073C9")]
	[Address(RVA = "0xC0C160", Offset = "0xC0B560", VA = "0x180C0C160", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SocialNoticeInformation other)
	{
	}

	[Token(Token = "0x60073CA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60073CB")]
	[Address(RVA = "0xC0C5C0", Offset = "0xC0B9C0", VA = "0x180C0C5C0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
