using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007B8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BlockListRequest : IMessage<BlockListRequest>, IMessage, IEquatable<BlockListRequest>, IDeepCloneable<BlockListRequest>, IBufferMessage
{
	[Token(Token = "0x4001AD6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BlockListRequest> _parser;

	[Token(Token = "0x4001AD7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001181")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BlockListRequest> Parser
	{
		[Token(Token = "0x600520A")]
		[Address(RVA = "0xAC9200", Offset = "0xAC8600", VA = "0x180AC9200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001182")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600520B")]
		[Address(RVA = "0xAC9150", Offset = "0xAC8550", VA = "0x180AC9150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001183")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600520C")]
		[Address(RVA = "0xAC9250", Offset = "0xAC8650", VA = "0x180AC9250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600520D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockListRequest()
	{
	}

	[Token(Token = "0x600520E")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockListRequest(BlockListRequest other)
	{
	}

	[Token(Token = "0x600520F")]
	[Address(RVA = "0xAC8EF0", Offset = "0xAC82F0", VA = "0x180AC8EF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockListRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005210")]
	[Address(RVA = "0xAC8F70", Offset = "0xAC8370", VA = "0x180AC8F70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005211")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BlockListRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005212")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005213")]
	[Address(RVA = "0xAC8FF0", Offset = "0xAC83F0", VA = "0x180AC8FF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005214")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005215")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005216")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005217")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BlockListRequest other)
	{
	}

	[Token(Token = "0x6005218")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005219")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
