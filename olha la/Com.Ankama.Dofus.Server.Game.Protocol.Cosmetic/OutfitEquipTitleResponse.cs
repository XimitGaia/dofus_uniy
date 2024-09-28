using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C07")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipTitleResponse : IMessage<OutfitEquipTitleResponse>, IMessage, IEquatable<OutfitEquipTitleResponse>, IDeepCloneable<OutfitEquipTitleResponse>, IBufferMessage
{
	[Token(Token = "0x4002C9F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipTitleResponse> _parser;

	[Token(Token = "0x4002CA0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CA1")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002CA2")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001BBB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEquipTitleResponse> Parser
	{
		[Token(Token = "0x6007E59")]
		[Address(RVA = "0xC67F60", Offset = "0xC67360", VA = "0x180C67F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BBC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007E5A")]
		[Address(RVA = "0xC67EB0", Offset = "0xC672B0", VA = "0x180C67EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BBD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007E5B")]
		[Address(RVA = "0xC67FB0", Offset = "0xC673B0", VA = "0x180C67FB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BBE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6007E5F")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007E60")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007E5C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipTitleResponse()
	{
	}

	[Token(Token = "0x6007E5D")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipTitleResponse(OutfitEquipTitleResponse other)
	{
	}

	[Token(Token = "0x6007E5E")]
	[Address(RVA = "0xC67BA0", Offset = "0xC66FA0", VA = "0x180C67BA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipTitleResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007E61")]
	[Address(RVA = "0xC67C20", Offset = "0xC67020", VA = "0x180C67C20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E62")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEquipTitleResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E63")]
	[Address(RVA = "0xC67CB0", Offset = "0xC670B0", VA = "0x180C67CB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007E64")]
	[Address(RVA = "0xC67D50", Offset = "0xC67150", VA = "0x180C67D50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007E65")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007E66")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007E67")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007E68")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipTitleResponse other)
	{
	}

	[Token(Token = "0x6007E69")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007E6A")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
