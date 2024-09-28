using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C05")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipTitleRequest : IMessage<OutfitEquipTitleRequest>, IMessage, IEquatable<OutfitEquipTitleRequest>, IDeepCloneable<OutfitEquipTitleRequest>, IBufferMessage
{
	[Token(Token = "0x4002C98")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipTitleRequest> _parser;

	[Token(Token = "0x4002C99")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C9A")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002C9B")]
	public const int TitleIdFieldNumber = 1;

	[Token(Token = "0x4002C9C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int TitleIdDefaultValue;

	[Token(Token = "0x4002C9D")]
	[FieldOffset(Offset = "0x1C")]
	private int titleId_;

	[Token(Token = "0x17001BB6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEquipTitleRequest> Parser
	{
		[Token(Token = "0x6007E41")]
		[Address(RVA = "0xC67960", Offset = "0xC66D60", VA = "0x180C67960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BB7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007E42")]
		[Address(RVA = "0xC678B0", Offset = "0xC66CB0", VA = "0x180C678B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BB8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007E43")]
		[Address(RVA = "0xC67AC0", Offset = "0xC66EC0", VA = "0x180C67AC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BB9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TitleId
	{
		[Token(Token = "0x6007E47")]
		[Address(RVA = "0xC679B0", Offset = "0xC66DB0", VA = "0x180C679B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E48")]
		[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
		set
		{
		}
	}

	[Token(Token = "0x17001BBA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasTitleId
	{
		[Token(Token = "0x6007E49")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007E44")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipTitleRequest()
	{
	}

	[Token(Token = "0x6007E45")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipTitleRequest(OutfitEquipTitleRequest other)
	{
	}

	[Token(Token = "0x6007E46")]
	[Address(RVA = "0xC67470", Offset = "0xC66870", VA = "0x180C67470", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipTitleRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007E4A")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearTitleId()
	{
	}

	[Token(Token = "0x6007E4B")]
	[Address(RVA = "0xC67570", Offset = "0xC66970", VA = "0x180C67570", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E4C")]
	[Address(RVA = "0xC67500", Offset = "0xC66900", VA = "0x180C67500", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEquipTitleRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E4D")]
	[Address(RVA = "0xC67620", Offset = "0xC66A20", VA = "0x180C67620", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007E4E")]
	[Address(RVA = "0xC67740", Offset = "0xC66B40", VA = "0x180C67740", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007E4F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007E50")]
	[Address(RVA = "0xC67A20", Offset = "0xC66E20", VA = "0x180C67A20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007E51")]
	[Address(RVA = "0xC673A0", Offset = "0xC667A0", VA = "0x180C673A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007E52")]
	[Address(RVA = "0xC676E0", Offset = "0xC66AE0", VA = "0x180C676E0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OutfitEquipTitleRequest other)
	{
	}

	[Token(Token = "0x6007E53")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007E54")]
	[Address(RVA = "0xAB9600", Offset = "0xAB8A00", VA = "0x180AB9600", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
