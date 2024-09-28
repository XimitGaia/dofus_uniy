using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C29")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipResponse : IMessage<OutfitEquipResponse>, IMessage, IEquatable<OutfitEquipResponse>, IDeepCloneable<OutfitEquipResponse>, IBufferMessage
{
	[Token(Token = "0x4002D15")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipResponse> _parser;

	[Token(Token = "0x4002D16")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D17")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002D18")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001C10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OutfitEquipResponse> Parser
	{
		[Token(Token = "0x6007FF1")]
		[Address(RVA = "0xC67270", Offset = "0xC66670", VA = "0x180C67270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007FF2")]
		[Address(RVA = "0xC671C0", Offset = "0xC665C0", VA = "0x180C671C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007FF3")]
		[Address(RVA = "0xC672C0", Offset = "0xC666C0", VA = "0x180C672C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C13")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6007FF7")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007FF8")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007FF4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipResponse()
	{
	}

	[Token(Token = "0x6007FF5")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipResponse(OutfitEquipResponse other)
	{
	}

	[Token(Token = "0x6007FF6")]
	[Address(RVA = "0xC66EB0", Offset = "0xC662B0", VA = "0x180C66EB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007FF9")]
	[Address(RVA = "0xC66F30", Offset = "0xC66330", VA = "0x180C66F30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FFA")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitEquipResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007FFB")]
	[Address(RVA = "0xC66FC0", Offset = "0xC663C0", VA = "0x180C66FC0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007FFC")]
	[Address(RVA = "0xC67060", Offset = "0xC66460", VA = "0x180C67060", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007FFD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007FFE")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007FFF")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008000")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OutfitEquipResponse other)
	{
	}

	[Token(Token = "0x6008001")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008002")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
