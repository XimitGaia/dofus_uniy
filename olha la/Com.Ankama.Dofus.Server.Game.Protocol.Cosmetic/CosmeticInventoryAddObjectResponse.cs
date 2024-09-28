using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BF1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CosmeticInventoryAddObjectResponse : IMessage<CosmeticInventoryAddObjectResponse>, IMessage, IEquatable<CosmeticInventoryAddObjectResponse>, IDeepCloneable<CosmeticInventoryAddObjectResponse>, IBufferMessage
{
	[Token(Token = "0x2000BF2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000BF3")]
		public enum Result
		{
			[Token(Token = "0x4002C64")]
			[OriginalName("ERROR")]
			Error,
			[Token(Token = "0x4002C65")]
			[OriginalName("DUPLICATE")]
			Duplicate,
			[Token(Token = "0x4002C66")]
			[OriginalName("SUCCESS")]
			Success
		}
	}

	[Token(Token = "0x4002C5F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CosmeticInventoryAddObjectResponse> _parser;

	[Token(Token = "0x4002C60")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C61")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4002C62")]
	[FieldOffset(Offset = "0x18")]
	private Types.Result result_;

	[Token(Token = "0x17001B8E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CosmeticInventoryAddObjectResponse> Parser
	{
		[Token(Token = "0x6007D73")]
		[Address(RVA = "0xC58C70", Offset = "0xC58070", VA = "0x180C58C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B8F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007D74")]
		[Address(RVA = "0xC58BC0", Offset = "0xC57FC0", VA = "0x180C58BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007D75")]
		[Address(RVA = "0xC58CC0", Offset = "0xC580C0", VA = "0x180C58CC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B91")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Result Result
	{
		[Token(Token = "0x6007D79")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Result);
		}
		[Token(Token = "0x6007D7A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007D76")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryAddObjectResponse()
	{
	}

	[Token(Token = "0x6007D77")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryAddObjectResponse(CosmeticInventoryAddObjectResponse other)
	{
	}

	[Token(Token = "0x6007D78")]
	[Address(RVA = "0xC58950", Offset = "0xC57D50", VA = "0x180C58950", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryAddObjectResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007D7B")]
	[Address(RVA = "0xC589D0", Offset = "0xC57DD0", VA = "0x180C589D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D7C")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CosmeticInventoryAddObjectResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D7D")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007D7E")]
	[Address(RVA = "0xC58A60", Offset = "0xC57E60", VA = "0x180C58A60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007D7F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007D80")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007D81")]
	[Address(RVA = "0xC588C0", Offset = "0xC57CC0", VA = "0x180C588C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007D82")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CosmeticInventoryAddObjectResponse other)
	{
	}

	[Token(Token = "0x6007D83")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007D84")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
