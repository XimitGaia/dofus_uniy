using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C17")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipFaceResponse : IMessage<OutfitEquipFaceResponse>, IMessage, IEquatable<OutfitEquipFaceResponse>, IDeepCloneable<OutfitEquipFaceResponse>, IBufferMessage
{
	[Token(Token = "0x4002CD8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipFaceResponse> _parser;

	[Token(Token = "0x4002CD9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CDA")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002CDB")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001BE4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OutfitEquipFaceResponse> Parser
	{
		[Token(Token = "0x6007F1B")]
		[Address(RVA = "0xC635B0", Offset = "0xC629B0", VA = "0x180C635B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007F1C")]
		[Address(RVA = "0xC63500", Offset = "0xC62900", VA = "0x180C63500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007F1D")]
		[Address(RVA = "0xC63600", Offset = "0xC62A00", VA = "0x180C63600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6007F21")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007F22")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007F1E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipFaceResponse()
	{
	}

	[Token(Token = "0x6007F1F")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipFaceResponse(OutfitEquipFaceResponse other)
	{
	}

	[Token(Token = "0x6007F20")]
	[Address(RVA = "0xC631F0", Offset = "0xC625F0", VA = "0x180C631F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipFaceResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007F23")]
	[Address(RVA = "0xC63270", Offset = "0xC62670", VA = "0x180C63270", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F24")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEquipFaceResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F25")]
	[Address(RVA = "0xC63300", Offset = "0xC62700", VA = "0x180C63300", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007F26")]
	[Address(RVA = "0xC633A0", Offset = "0xC627A0", VA = "0x180C633A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007F27")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007F28")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007F29")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007F2A")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipFaceResponse other)
	{
	}

	[Token(Token = "0x6007F2B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007F2C")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
