using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account;

[Token(Token = "0x2000D40")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuestModeEvent : IMessage<GuestModeEvent>, IMessage, IEquatable<GuestModeEvent>, IDeepCloneable<GuestModeEvent>, IBufferMessage
{
	[Token(Token = "0x400308B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuestModeEvent> _parser;

	[Token(Token = "0x400308C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400308D")]
	public const int EffectiveFieldNumber = 1;

	[Token(Token = "0x400308E")]
	[FieldOffset(Offset = "0x18")]
	private bool effective_;

	[Token(Token = "0x17001E6F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuestModeEvent> Parser
	{
		[Token(Token = "0x6008B77")]
		[Address(RVA = "0xCBC400", Offset = "0xCBB800", VA = "0x180CBC400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008B78")]
		[Address(RVA = "0xCBC350", Offset = "0xCBB750", VA = "0x180CBC350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E71")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008B79")]
		[Address(RVA = "0xCBC450", Offset = "0xCBB850", VA = "0x180CBC450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E72")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Effective
	{
		[Token(Token = "0x6008B7D")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008B7E")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6008B7A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuestModeEvent()
	{
	}

	[Token(Token = "0x6008B7B")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuestModeEvent(GuestModeEvent other)
	{
	}

	[Token(Token = "0x6008B7C")]
	[Address(RVA = "0xCBC040", Offset = "0xCBB440", VA = "0x180CBC040", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuestModeEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008B7F")]
	[Address(RVA = "0xCBC0C0", Offset = "0xCBB4C0", VA = "0x180CBC0C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B80")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuestModeEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B81")]
	[Address(RVA = "0xCBC150", Offset = "0xCBB550", VA = "0x180CBC150", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008B82")]
	[Address(RVA = "0xCBC1F0", Offset = "0xCBB5F0", VA = "0x180CBC1F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008B83")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008B84")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008B85")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008B86")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuestModeEvent other)
	{
	}

	[Token(Token = "0x6008B87")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008B88")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
