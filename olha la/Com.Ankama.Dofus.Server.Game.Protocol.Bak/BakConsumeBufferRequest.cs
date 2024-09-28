using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B62")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakConsumeBufferRequest : IMessage<BakConsumeBufferRequest>, IMessage, IEquatable<BakConsumeBufferRequest>, IDeepCloneable<BakConsumeBufferRequest>, IBufferMessage
{
	[Token(Token = "0x4002A8B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakConsumeBufferRequest> _parser;

	[Token(Token = "0x4002A8C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001A6B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BakConsumeBufferRequest> Parser
	{
		[Token(Token = "0x60077ED")]
		[Address(RVA = "0xC1D9E0", Offset = "0xC1CDE0", VA = "0x180C1D9E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A6C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60077EE")]
		[Address(RVA = "0xC1D930", Offset = "0xC1CD30", VA = "0x180C1D930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A6D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60077EF")]
		[Address(RVA = "0xC1DA30", Offset = "0xC1CE30", VA = "0x180C1DA30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077F0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakConsumeBufferRequest()
	{
	}

	[Token(Token = "0x60077F1")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakConsumeBufferRequest(BakConsumeBufferRequest other)
	{
	}

	[Token(Token = "0x60077F2")]
	[Address(RVA = "0xC1D6D0", Offset = "0xC1CAD0", VA = "0x180C1D6D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakConsumeBufferRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60077F3")]
	[Address(RVA = "0xC1D750", Offset = "0xC1CB50", VA = "0x180C1D750", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60077F4")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BakConsumeBufferRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60077F5")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60077F6")]
	[Address(RVA = "0xC1D7D0", Offset = "0xC1CBD0", VA = "0x180C1D7D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60077F7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60077F8")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60077F9")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60077FA")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakConsumeBufferRequest other)
	{
	}

	[Token(Token = "0x60077FB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60077FC")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
