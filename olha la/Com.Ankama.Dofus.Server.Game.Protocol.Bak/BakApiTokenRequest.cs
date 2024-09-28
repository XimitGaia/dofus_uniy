using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B74")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakApiTokenRequest : IMessage<BakApiTokenRequest>, IMessage, IEquatable<BakApiTokenRequest>, IDeepCloneable<BakApiTokenRequest>, IBufferMessage
{
	[Token(Token = "0x4002AD1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakApiTokenRequest> _parser;

	[Token(Token = "0x4002AD2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001A91")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BakApiTokenRequest> Parser
	{
		[Token(Token = "0x600789B")]
		[Address(RVA = "0xC1B560", Offset = "0xC1A960", VA = "0x180C1B560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A92")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600789C")]
		[Address(RVA = "0xC1B4B0", Offset = "0xC1A8B0", VA = "0x180C1B4B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A93")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600789D")]
		[Address(RVA = "0xC1B5B0", Offset = "0xC1A9B0", VA = "0x180C1B5B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600789E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakApiTokenRequest()
	{
	}

	[Token(Token = "0x600789F")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BakApiTokenRequest(BakApiTokenRequest other)
	{
	}

	[Token(Token = "0x60078A0")]
	[Address(RVA = "0xC1B250", Offset = "0xC1A650", VA = "0x180C1B250", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakApiTokenRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60078A1")]
	[Address(RVA = "0xC1B2D0", Offset = "0xC1A6D0", VA = "0x180C1B2D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60078A2")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BakApiTokenRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60078A3")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60078A4")]
	[Address(RVA = "0xC1B350", Offset = "0xC1A750", VA = "0x180C1B350", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60078A5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60078A6")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60078A7")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60078A8")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BakApiTokenRequest other)
	{
	}

	[Token(Token = "0x60078A9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60078AA")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
