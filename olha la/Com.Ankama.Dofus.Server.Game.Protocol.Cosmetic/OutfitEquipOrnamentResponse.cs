using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C0B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipOrnamentResponse : IMessage<OutfitEquipOrnamentResponse>, IMessage, IEquatable<OutfitEquipOrnamentResponse>, IDeepCloneable<OutfitEquipOrnamentResponse>, IBufferMessage
{
	[Token(Token = "0x4002CAB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipOrnamentResponse> _parser;

	[Token(Token = "0x4002CAC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CAD")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002CAE")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001BC4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OutfitEquipOrnamentResponse> Parser
	{
		[Token(Token = "0x6007E87")]
		[Address(RVA = "0xC665B0", Offset = "0xC659B0", VA = "0x180C665B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BC5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007E88")]
		[Address(RVA = "0xC66500", Offset = "0xC65900", VA = "0x180C66500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BC6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007E89")]
		[Address(RVA = "0xC66600", Offset = "0xC65A00", VA = "0x180C66600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BC7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6007E8D")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007E8E")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007E8A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipOrnamentResponse()
	{
	}

	[Token(Token = "0x6007E8B")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipOrnamentResponse(OutfitEquipOrnamentResponse other)
	{
	}

	[Token(Token = "0x6007E8C")]
	[Address(RVA = "0xC661F0", Offset = "0xC655F0", VA = "0x180C661F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipOrnamentResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007E8F")]
	[Address(RVA = "0xC66270", Offset = "0xC65670", VA = "0x180C66270", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E90")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitEquipOrnamentResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E91")]
	[Address(RVA = "0xC66300", Offset = "0xC65700", VA = "0x180C66300", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007E92")]
	[Address(RVA = "0xC663A0", Offset = "0xC657A0", VA = "0x180C663A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007E93")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007E94")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007E95")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007E96")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipOrnamentResponse other)
	{
	}

	[Token(Token = "0x6007E97")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007E98")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
