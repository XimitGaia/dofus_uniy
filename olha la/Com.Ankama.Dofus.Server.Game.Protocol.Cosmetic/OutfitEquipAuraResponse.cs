using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C01")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipAuraResponse : IMessage<OutfitEquipAuraResponse>, IMessage, IEquatable<OutfitEquipAuraResponse>, IDeepCloneable<OutfitEquipAuraResponse>, IBufferMessage
{
	[Token(Token = "0x4002C8C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipAuraResponse> _parser;

	[Token(Token = "0x4002C8D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C8E")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002C8F")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x17001BAD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEquipAuraResponse> Parser
	{
		[Token(Token = "0x6007E13")]
		[Address(RVA = "0xC62BE0", Offset = "0xC61FE0", VA = "0x180C62BE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BAE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007E14")]
		[Address(RVA = "0xC62B30", Offset = "0xC61F30", VA = "0x180C62B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BAF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007E15")]
		[Address(RVA = "0xC62C30", Offset = "0xC62030", VA = "0x180C62C30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6007E19")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007E1A")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007E16")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipAuraResponse()
	{
	}

	[Token(Token = "0x6007E17")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipAuraResponse(OutfitEquipAuraResponse other)
	{
	}

	[Token(Token = "0x6007E18")]
	[Address(RVA = "0xC62820", Offset = "0xC61C20", VA = "0x180C62820", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipAuraResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007E1B")]
	[Address(RVA = "0xC628A0", Offset = "0xC61CA0", VA = "0x180C628A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E1C")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEquipAuraResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E1D")]
	[Address(RVA = "0xC62930", Offset = "0xC61D30", VA = "0x180C62930", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007E1E")]
	[Address(RVA = "0xC629D0", Offset = "0xC61DD0", VA = "0x180C629D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007E1F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007E20")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007E21")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007E22")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipAuraResponse other)
	{
	}

	[Token(Token = "0x6007E23")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007E24")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
