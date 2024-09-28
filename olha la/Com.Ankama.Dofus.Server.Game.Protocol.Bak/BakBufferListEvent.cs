using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B60")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakBufferListEvent : IMessage<BakBufferListEvent>, IMessage, IEquatable<BakBufferListEvent>, IDeepCloneable<BakBufferListEvent>, IBufferMessage
{
	[Token(Token = "0x4002A85")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakBufferListEvent> _parser;

	[Token(Token = "0x4002A86")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A87")]
	public const int BuffersFieldNumber = 1;

	[Token(Token = "0x4002A88")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<BufferInformation> _repeated_buffers_codec;

	[Token(Token = "0x4002A89")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<BufferInformation> buffers_;

	[Token(Token = "0x17001A67")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BakBufferListEvent> Parser
	{
		[Token(Token = "0x60077D8")]
		[Address(RVA = "0xC1BDA0", Offset = "0xC1B1A0", VA = "0x180C1BDA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A68")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60077D9")]
		[Address(RVA = "0xC1BCF0", Offset = "0xC1B0F0", VA = "0x180C1BCF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A69")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60077DA")]
		[Address(RVA = "0xC1BFB0", Offset = "0xC1B3B0", VA = "0x180C1BFB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A6A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BufferInformation> Buffers
	{
		[Token(Token = "0x60077DE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077DB")]
	[Address(RVA = "0xC1BBE0", Offset = "0xC1AFE0", VA = "0x180C1BBE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BakBufferListEvent()
	{
	}

	[Token(Token = "0x60077DC")]
	[Address(RVA = "0xC1BC60", Offset = "0xC1B060", VA = "0x180C1BC60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakBufferListEvent(BakBufferListEvent other)
	{
	}

	[Token(Token = "0x60077DD")]
	[Address(RVA = "0xC1B730", Offset = "0xC1AB30", VA = "0x180C1B730", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakBufferListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60077DF")]
	[Address(RVA = "0xC1B880", Offset = "0xC1AC80", VA = "0x180C1B880", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60077E0")]
	[Address(RVA = "0xC1B7F0", Offset = "0xC1ABF0", VA = "0x180C1B7F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BakBufferListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60077E1")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60077E2")]
	[Address(RVA = "0xC1B9E0", Offset = "0xC1ADE0", VA = "0x180C1B9E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60077E3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60077E4")]
	[Address(RVA = "0xC1BF00", Offset = "0xC1B300", VA = "0x180C1BF00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60077E5")]
	[Address(RVA = "0xC1B690", Offset = "0xC1AA90", VA = "0x180C1B690", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60077E6")]
	[Address(RVA = "0xC1B960", Offset = "0xC1AD60", VA = "0x180C1B960", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakBufferListEvent other)
	{
	}

	[Token(Token = "0x60077E7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60077E8")]
	[Address(RVA = "0xC1BDF0", Offset = "0xC1B1F0", VA = "0x180C1BDF0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
