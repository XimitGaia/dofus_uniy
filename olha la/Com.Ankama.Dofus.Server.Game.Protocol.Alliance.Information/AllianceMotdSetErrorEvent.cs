using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CCA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceMotdSetErrorEvent : IMessage<AllianceMotdSetErrorEvent>, IMessage, IEquatable<AllianceMotdSetErrorEvent>, IDeepCloneable<AllianceMotdSetErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4002F2E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceMotdSetErrorEvent> _parser;

	[Token(Token = "0x4002F2F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F30")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4002F31")]
	[FieldOffset(Offset = "0x18")]
	private SocialNoticeError reason_;

	[Token(Token = "0x17001D7E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceMotdSetErrorEvent> Parser
	{
		[Token(Token = "0x60086C8")]
		[Address(RVA = "0xC9AD70", Offset = "0xC9A170", VA = "0x180C9AD70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D7F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60086C9")]
		[Address(RVA = "0xC9ACC0", Offset = "0xC9A0C0", VA = "0x180C9ACC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60086CA")]
		[Address(RVA = "0xC9ADC0", Offset = "0xC9A1C0", VA = "0x180C9ADC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D81")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialNoticeError Reason
	{
		[Token(Token = "0x60086CE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialNoticeError);
		}
		[Token(Token = "0x60086CF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60086CB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMotdSetErrorEvent()
	{
	}

	[Token(Token = "0x60086CC")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMotdSetErrorEvent(AllianceMotdSetErrorEvent other)
	{
	}

	[Token(Token = "0x60086CD")]
	[Address(RVA = "0xC9AA50", Offset = "0xC99E50", VA = "0x180C9AA50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceMotdSetErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60086D0")]
	[Address(RVA = "0xC9AAD0", Offset = "0xC99ED0", VA = "0x180C9AAD0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086D1")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceMotdSetErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60086D2")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60086D3")]
	[Address(RVA = "0xC9AB60", Offset = "0xC99F60", VA = "0x180C9AB60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60086D4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60086D5")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60086D6")]
	[Address(RVA = "0xC9A9C0", Offset = "0xC99DC0", VA = "0x180C9A9C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60086D7")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceMotdSetErrorEvent other)
	{
	}

	[Token(Token = "0x60086D8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60086D9")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
