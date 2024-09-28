using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B5E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakBufferListRequest : IMessage<BakBufferListRequest>, IMessage, IEquatable<BakBufferListRequest>, IDeepCloneable<BakBufferListRequest>, IBufferMessage
{
	[Token(Token = "0x4002A82")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakBufferListRequest> _parser;

	[Token(Token = "0x4002A83")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001A64")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BakBufferListRequest> Parser
	{
		[Token(Token = "0x60077C4")]
		[Address(RVA = "0xC1C3A0", Offset = "0xC1B7A0", VA = "0x180C1C3A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A65")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60077C5")]
		[Address(RVA = "0xC1C2F0", Offset = "0xC1B6F0", VA = "0x180C1C2F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A66")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60077C6")]
		[Address(RVA = "0xC1C3F0", Offset = "0xC1B7F0", VA = "0x180C1C3F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077C7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakBufferListRequest()
	{
	}

	[Token(Token = "0x60077C8")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakBufferListRequest(BakBufferListRequest other)
	{
	}

	[Token(Token = "0x60077C9")]
	[Address(RVA = "0xC1C090", Offset = "0xC1B490", VA = "0x180C1C090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakBufferListRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60077CA")]
	[Address(RVA = "0xC1C110", Offset = "0xC1B510", VA = "0x180C1C110", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60077CB")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BakBufferListRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60077CC")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60077CD")]
	[Address(RVA = "0xC1C190", Offset = "0xC1B590", VA = "0x180C1C190", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60077CE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60077CF")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60077D0")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60077D1")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakBufferListRequest other)
	{
	}

	[Token(Token = "0x60077D2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60077D3")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
