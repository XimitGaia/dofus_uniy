using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BF7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CosmeticInventoryPopObjectResponse : IMessage<CosmeticInventoryPopObjectResponse>, IMessage, IEquatable<CosmeticInventoryPopObjectResponse>, IDeepCloneable<CosmeticInventoryPopObjectResponse>, IBufferMessage
{
	[Token(Token = "0x4002C6D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CosmeticInventoryPopObjectResponse> _parser;

	[Token(Token = "0x4002C6E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C6F")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002C70")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001B96")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CosmeticInventoryPopObjectResponse> Parser
	{
		[Token(Token = "0x6007D9F")]
		[Address(RVA = "0xC5B530", Offset = "0xC5A930", VA = "0x180C5B530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B97")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007DA0")]
		[Address(RVA = "0xC5B480", Offset = "0xC5A880", VA = "0x180C5B480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B98")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007DA1")]
		[Address(RVA = "0xC5B580", Offset = "0xC5A980", VA = "0x180C5B580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B99")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6007DA5")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007DA6")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007DA2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryPopObjectResponse()
	{
	}

	[Token(Token = "0x6007DA3")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryPopObjectResponse(CosmeticInventoryPopObjectResponse other)
	{
	}

	[Token(Token = "0x6007DA4")]
	[Address(RVA = "0xC5B170", Offset = "0xC5A570", VA = "0x180C5B170", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryPopObjectResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007DA7")]
	[Address(RVA = "0xC5B1F0", Offset = "0xC5A5F0", VA = "0x180C5B1F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007DA8")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CosmeticInventoryPopObjectResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007DA9")]
	[Address(RVA = "0xC5B280", Offset = "0xC5A680", VA = "0x180C5B280", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007DAA")]
	[Address(RVA = "0xC5B320", Offset = "0xC5A720", VA = "0x180C5B320", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007DAB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007DAC")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007DAD")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007DAE")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CosmeticInventoryPopObjectResponse other)
	{
	}

	[Token(Token = "0x6007DAF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007DB0")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
