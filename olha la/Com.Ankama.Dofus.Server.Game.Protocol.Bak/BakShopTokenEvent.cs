using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B7A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakShopTokenEvent : IMessage<BakShopTokenEvent>, IMessage, IEquatable<BakShopTokenEvent>, IDeepCloneable<BakShopTokenEvent>, IBufferMessage
{
	[Token(Token = "0x4002ADC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakShopTokenEvent> _parser;

	[Token(Token = "0x4002ADD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002ADE")]
	public const int TokenFieldNumber = 1;

	[Token(Token = "0x4002ADF")]
	[FieldOffset(Offset = "0x18")]
	private string token_;

	[Token(Token = "0x17001A9B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BakShopTokenEvent> Parser
	{
		[Token(Token = "0x60078D9")]
		[Address(RVA = "0xC1FB20", Offset = "0xC1EF20", VA = "0x180C1FB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A9C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60078DA")]
		[Address(RVA = "0xC1FA70", Offset = "0xC1EE70", VA = "0x180C1FA70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60078DB")]
		[Address(RVA = "0xC1FC30", Offset = "0xC1F030", VA = "0x180C1FC30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A9E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Token
	{
		[Token(Token = "0x60078DF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60078E0")]
		[Address(RVA = "0xC1FD10", Offset = "0xC1F110", VA = "0x180C1FD10")]
		set
		{
		}
	}

	[Token(Token = "0x60078DC")]
	[Address(RVA = "0xC1F980", Offset = "0xC1ED80", VA = "0x180C1F980")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakShopTokenEvent()
	{
	}

	[Token(Token = "0x60078DD")]
	[Address(RVA = "0xC1F9D0", Offset = "0xC1EDD0", VA = "0x180C1F9D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BakShopTokenEvent(BakShopTokenEvent other)
	{
	}

	[Token(Token = "0x60078DE")]
	[Address(RVA = "0xC1F640", Offset = "0xC1EA40", VA = "0x180C1F640", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakShopTokenEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60078E1")]
	[Address(RVA = "0xC1F710", Offset = "0xC1EB10", VA = "0x180C1F710", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60078E2")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BakShopTokenEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60078E3")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60078E4")]
	[Address(RVA = "0xC1F820", Offset = "0xC1EC20", VA = "0x180C1F820", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60078E5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60078E6")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60078E7")]
	[Address(RVA = "0xC1F5B0", Offset = "0xC1E9B0", VA = "0x180C1F5B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60078E8")]
	[Address(RVA = "0xC1F7C0", Offset = "0xC1EBC0", VA = "0x180C1F7C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakShopTokenEvent other)
	{
	}

	[Token(Token = "0x60078E9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60078EA")]
	[Address(RVA = "0xC1FB70", Offset = "0xC1EF70", VA = "0x180C1FB70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
