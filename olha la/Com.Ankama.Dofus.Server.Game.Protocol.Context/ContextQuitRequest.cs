using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000785")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextQuitRequest : IMessage<ContextQuitRequest>, IMessage, IEquatable<ContextQuitRequest>, IDeepCloneable<ContextQuitRequest>, IBufferMessage
{
	[Token(Token = "0x4001A42")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextQuitRequest> _parser;

	[Token(Token = "0x4001A43")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001120")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContextQuitRequest> Parser
	{
		[Token(Token = "0x6005018")]
		[Address(RVA = "0xAD1F40", Offset = "0xAD1340", VA = "0x180AD1F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001121")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005019")]
		[Address(RVA = "0xAD1E90", Offset = "0xAD1290", VA = "0x180AD1E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001122")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600501A")]
		[Address(RVA = "0xAD1F90", Offset = "0xAD1390", VA = "0x180AD1F90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600501B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextQuitRequest()
	{
	}

	[Token(Token = "0x600501C")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextQuitRequest(ContextQuitRequest other)
	{
	}

	[Token(Token = "0x600501D")]
	[Address(RVA = "0xAD1C30", Offset = "0xAD1030", VA = "0x180AD1C30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextQuitRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600501E")]
	[Address(RVA = "0xAD1CB0", Offset = "0xAD10B0", VA = "0x180AD1CB0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600501F")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContextQuitRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005020")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005021")]
	[Address(RVA = "0xAD1D30", Offset = "0xAD1130", VA = "0x180AD1D30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005022")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005023")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005024")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005025")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContextQuitRequest other)
	{
	}

	[Token(Token = "0x6005026")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005027")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
