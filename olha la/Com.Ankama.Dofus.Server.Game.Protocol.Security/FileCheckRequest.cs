using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Security;

[Token(Token = "0x2000158")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FileCheckRequest : IMessage<FileCheckRequest>, IMessage, IEquatable<FileCheckRequest>, IDeepCloneable<FileCheckRequest>, IBufferMessage
{
	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FileCheckRequest> _parser;

	[Token(Token = "0x4000495")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000496")]
	public const int CheckTypeFieldNumber = 1;

	[Token(Token = "0x4000497")]
	[FieldOffset(Offset = "0x18")]
	private CheckType checkType_;

	[Token(Token = "0x4000498")]
	public const int ValueFieldNumber = 2;

	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x20")]
	private string value_;

	[Token(Token = "0x170002D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FileCheckRequest> Parser
	{
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0xC45A00", Offset = "0xC44E00", VA = "0x180C45A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0xC45950", Offset = "0xC44D50", VA = "0x180C45950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0xC45B20", Offset = "0xC44F20", VA = "0x180C45B20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CheckType CheckType
	{
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(CheckType);
		}
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170002DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Value
	{
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0xC45C00", Offset = "0xC45000", VA = "0x180C45C00")]
		set
		{
		}
	}

	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0xC45850", Offset = "0xC44C50", VA = "0x180C45850")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FileCheckRequest()
	{
	}

	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0xC458A0", Offset = "0xC44CA0", VA = "0x180C458A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FileCheckRequest(FileCheckRequest other)
	{
	}

	[Token(Token = "0x6000D50")]
	[Address(RVA = "0xC45500", Offset = "0xC44900", VA = "0x180C45500", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FileCheckRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000D55")]
	[Address(RVA = "0xC455D0", Offset = "0xC449D0", VA = "0x180C455D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D56")]
	[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FileCheckRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D57")]
	[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000D58")]
	[Address(RVA = "0xC456F0", Offset = "0xC44AF0", VA = "0x180C456F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0xAD91E0", Offset = "0xAD85E0", VA = "0x180AD91E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0xC45440", Offset = "0xC44840", VA = "0x180C45440", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0xC45680", Offset = "0xC44A80", VA = "0x180C45680", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FileCheckRequest other)
	{
	}

	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0xC45A50", Offset = "0xC44E50", VA = "0x180C45A50", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
