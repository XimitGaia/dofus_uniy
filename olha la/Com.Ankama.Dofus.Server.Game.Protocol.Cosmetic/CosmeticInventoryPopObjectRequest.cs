using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BF5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CosmeticInventoryPopObjectRequest : IMessage<CosmeticInventoryPopObjectRequest>, IMessage, IEquatable<CosmeticInventoryPopObjectRequest>, IDeepCloneable<CosmeticInventoryPopObjectRequest>, IBufferMessage
{
	[Token(Token = "0x4002C68")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CosmeticInventoryPopObjectRequest> _parser;

	[Token(Token = "0x4002C69")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C6A")]
	public const int GidFieldNumber = 1;

	[Token(Token = "0x4002C6B")]
	[FieldOffset(Offset = "0x18")]
	private int gid_;

	[Token(Token = "0x17001B92")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CosmeticInventoryPopObjectRequest> Parser
	{
		[Token(Token = "0x6007D89")]
		[Address(RVA = "0xC5B040", Offset = "0xC5A440", VA = "0x180C5B040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B93")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007D8A")]
		[Address(RVA = "0xC5AF90", Offset = "0xC5A390", VA = "0x180C5AF90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B94")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007D8B")]
		[Address(RVA = "0xC5B090", Offset = "0xC5A490", VA = "0x180C5B090", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B95")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Gid
	{
		[Token(Token = "0x6007D8F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D90")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007D8C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryPopObjectRequest()
	{
	}

	[Token(Token = "0x6007D8D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryPopObjectRequest(CosmeticInventoryPopObjectRequest other)
	{
	}

	[Token(Token = "0x6007D8E")]
	[Address(RVA = "0xC5AD20", Offset = "0xC5A120", VA = "0x180C5AD20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryPopObjectRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007D91")]
	[Address(RVA = "0xC5ADA0", Offset = "0xC5A1A0", VA = "0x180C5ADA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D92")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CosmeticInventoryPopObjectRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D93")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007D94")]
	[Address(RVA = "0xC5AE30", Offset = "0xC5A230", VA = "0x180C5AE30", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007D95")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007D96")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007D97")]
	[Address(RVA = "0xC5AC90", Offset = "0xC5A090", VA = "0x180C5AC90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007D98")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CosmeticInventoryPopObjectRequest other)
	{
	}

	[Token(Token = "0x6007D99")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007D9A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
