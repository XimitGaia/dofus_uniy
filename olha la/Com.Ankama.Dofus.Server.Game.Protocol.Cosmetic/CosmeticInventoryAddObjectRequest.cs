using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BEF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CosmeticInventoryAddObjectRequest : IMessage<CosmeticInventoryAddObjectRequest>, IMessage, IEquatable<CosmeticInventoryAddObjectRequest>, IDeepCloneable<CosmeticInventoryAddObjectRequest>, IBufferMessage
{
	[Token(Token = "0x4002C5A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CosmeticInventoryAddObjectRequest> _parser;

	[Token(Token = "0x4002C5B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C5C")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x4002C5D")]
	[FieldOffset(Offset = "0x18")]
	private int uid_;

	[Token(Token = "0x17001B8A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CosmeticInventoryAddObjectRequest> Parser
	{
		[Token(Token = "0x6007D5D")]
		[Address(RVA = "0xC58790", Offset = "0xC57B90", VA = "0x180C58790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B8B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007D5E")]
		[Address(RVA = "0xC586E0", Offset = "0xC57AE0", VA = "0x180C586E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B8C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007D5F")]
		[Address(RVA = "0xC587E0", Offset = "0xC57BE0", VA = "0x180C587E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B8D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Uid
	{
		[Token(Token = "0x6007D63")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D64")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007D60")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryAddObjectRequest()
	{
	}

	[Token(Token = "0x6007D61")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryAddObjectRequest(CosmeticInventoryAddObjectRequest other)
	{
	}

	[Token(Token = "0x6007D62")]
	[Address(RVA = "0xC58470", Offset = "0xC57870", VA = "0x180C58470", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryAddObjectRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007D65")]
	[Address(RVA = "0xC584F0", Offset = "0xC578F0", VA = "0x180C584F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D66")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CosmeticInventoryAddObjectRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D67")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007D68")]
	[Address(RVA = "0xC58580", Offset = "0xC57980", VA = "0x180C58580", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007D69")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007D6A")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007D6B")]
	[Address(RVA = "0xC583E0", Offset = "0xC577E0", VA = "0x180C583E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007D6C")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CosmeticInventoryAddObjectRequest other)
	{
	}

	[Token(Token = "0x6007D6D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007D6E")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
