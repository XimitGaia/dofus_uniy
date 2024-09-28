using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B76")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakApiKeyEvent : IMessage<BakApiKeyEvent>, IMessage, IEquatable<BakApiKeyEvent>, IDeepCloneable<BakApiKeyEvent>, IBufferMessage
{
	[Token(Token = "0x4002AD4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakApiKeyEvent> _parser;

	[Token(Token = "0x4002AD5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002AD6")]
	public const int TokenFieldNumber = 1;

	[Token(Token = "0x4002AD7")]
	[FieldOffset(Offset = "0x18")]
	private string token_;

	[Token(Token = "0x17001A94")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BakApiKeyEvent> Parser
	{
		[Token(Token = "0x60078AF")]
		[Address(RVA = "0xC1AFF0", Offset = "0xC1A3F0", VA = "0x180C1AFF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A95")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60078B0")]
		[Address(RVA = "0xC1AF40", Offset = "0xC1A340", VA = "0x180C1AF40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A96")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60078B1")]
		[Address(RVA = "0xC1B100", Offset = "0xC1A500", VA = "0x180C1B100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A97")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Token
	{
		[Token(Token = "0x60078B5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60078B6")]
		[Address(RVA = "0xC1B1E0", Offset = "0xC1A5E0", VA = "0x180C1B1E0")]
		set
		{
		}
	}

	[Token(Token = "0x60078B2")]
	[Address(RVA = "0xC1AEF0", Offset = "0xC1A2F0", VA = "0x180C1AEF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakApiKeyEvent()
	{
	}

	[Token(Token = "0x60078B3")]
	[Address(RVA = "0xC1AE50", Offset = "0xC1A250", VA = "0x180C1AE50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakApiKeyEvent(BakApiKeyEvent other)
	{
	}

	[Token(Token = "0x60078B4")]
	[Address(RVA = "0xC1AB10", Offset = "0xC19F10", VA = "0x180C1AB10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakApiKeyEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60078B7")]
	[Address(RVA = "0xC1ABE0", Offset = "0xC19FE0", VA = "0x180C1ABE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60078B8")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BakApiKeyEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60078B9")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60078BA")]
	[Address(RVA = "0xC1ACF0", Offset = "0xC1A0F0", VA = "0x180C1ACF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60078BB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60078BC")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60078BD")]
	[Address(RVA = "0xC1AA80", Offset = "0xC19E80", VA = "0x180C1AA80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60078BE")]
	[Address(RVA = "0xC1AC90", Offset = "0xC1A090", VA = "0x180C1AC90", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakApiKeyEvent other)
	{
	}

	[Token(Token = "0x60078BF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60078C0")]
	[Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
