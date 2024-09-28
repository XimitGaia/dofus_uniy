using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BFF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipAuraRequest : IMessage<OutfitEquipAuraRequest>, IMessage, IEquatable<OutfitEquipAuraRequest>, IDeepCloneable<OutfitEquipAuraRequest>, IBufferMessage
{
	[Token(Token = "0x4002C85")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipAuraRequest> _parser;

	[Token(Token = "0x4002C86")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C87")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002C88")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x4002C89")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int EmoteIdDefaultValue;

	[Token(Token = "0x4002C8A")]
	[FieldOffset(Offset = "0x1C")]
	private int emoteId_;

	[Token(Token = "0x17001BA8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OutfitEquipAuraRequest> Parser
	{
		[Token(Token = "0x6007DFB")]
		[Address(RVA = "0xC62650", Offset = "0xC61A50", VA = "0x180C62650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BA9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007DFC")]
		[Address(RVA = "0xC62530", Offset = "0xC61930", VA = "0x180C62530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BAA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007DFD")]
		[Address(RVA = "0xC62740", Offset = "0xC61B40", VA = "0x180C62740", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BAB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EmoteId
	{
		[Token(Token = "0x6007E01")]
		[Address(RVA = "0xC625E0", Offset = "0xC619E0", VA = "0x180C625E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E02")]
		[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
		set
		{
		}
	}

	[Token(Token = "0x17001BAC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEmoteId
	{
		[Token(Token = "0x6007E03")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007DFE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipAuraRequest()
	{
	}

	[Token(Token = "0x6007DFF")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipAuraRequest(OutfitEquipAuraRequest other)
	{
	}

	[Token(Token = "0x6007E00")]
	[Address(RVA = "0xC620F0", Offset = "0xC614F0", VA = "0x180C620F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipAuraRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007E04")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEmoteId()
	{
	}

	[Token(Token = "0x6007E05")]
	[Address(RVA = "0xC621F0", Offset = "0xC615F0", VA = "0x180C621F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E06")]
	[Address(RVA = "0xC62180", Offset = "0xC61580", VA = "0x180C62180", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitEquipAuraRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E07")]
	[Address(RVA = "0xC622A0", Offset = "0xC616A0", VA = "0x180C622A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007E08")]
	[Address(RVA = "0xC623C0", Offset = "0xC617C0", VA = "0x180C623C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007E09")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007E0A")]
	[Address(RVA = "0xC626A0", Offset = "0xC61AA0", VA = "0x180C626A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007E0B")]
	[Address(RVA = "0xC62020", Offset = "0xC61420", VA = "0x180C62020", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007E0C")]
	[Address(RVA = "0xC62360", Offset = "0xC61760", VA = "0x180C62360", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipAuraRequest other)
	{
	}

	[Token(Token = "0x6007E0D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007E0E")]
	[Address(RVA = "0xAB9600", Offset = "0xAB8A00", VA = "0x180AB9600", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
