using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C0F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipObjectResponse : IMessage<OutfitEquipObjectResponse>, IMessage, IEquatable<OutfitEquipObjectResponse>, IDeepCloneable<OutfitEquipObjectResponse>, IBufferMessage
{
	[Token(Token = "0x4002CBC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipObjectResponse> _parser;

	[Token(Token = "0x4002CBD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CBE")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002CBF")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001BD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OutfitEquipObjectResponse> Parser
	{
		[Token(Token = "0x6007EBB")]
		[Address(RVA = "0xC658C0", Offset = "0xC64CC0", VA = "0x180C658C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007EBC")]
		[Address(RVA = "0xC65810", Offset = "0xC64C10", VA = "0x180C65810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007EBD")]
		[Address(RVA = "0xC65910", Offset = "0xC64D10", VA = "0x180C65910", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6007EC1")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007EC2")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007EBE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipObjectResponse()
	{
	}

	[Token(Token = "0x6007EBF")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipObjectResponse(OutfitEquipObjectResponse other)
	{
	}

	[Token(Token = "0x6007EC0")]
	[Address(RVA = "0xC65500", Offset = "0xC64900", VA = "0x180C65500", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipObjectResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007EC3")]
	[Address(RVA = "0xC65580", Offset = "0xC64980", VA = "0x180C65580", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EC4")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEquipObjectResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EC5")]
	[Address(RVA = "0xC65610", Offset = "0xC64A10", VA = "0x180C65610", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007EC6")]
	[Address(RVA = "0xC656B0", Offset = "0xC64AB0", VA = "0x180C656B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007EC7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007EC8")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007EC9")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007ECA")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipObjectResponse other)
	{
	}

	[Token(Token = "0x6007ECB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007ECC")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
