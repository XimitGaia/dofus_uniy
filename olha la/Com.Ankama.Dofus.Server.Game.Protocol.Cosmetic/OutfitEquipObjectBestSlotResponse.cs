using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C13")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipObjectBestSlotResponse : IMessage<OutfitEquipObjectBestSlotResponse>, IMessage, IEquatable<OutfitEquipObjectBestSlotResponse>, IDeepCloneable<OutfitEquipObjectBestSlotResponse>, IBufferMessage
{
	[Token(Token = "0x4002CCA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipObjectBestSlotResponse> _parser;

	[Token(Token = "0x4002CCB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CCC")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002CCD")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4002CCE")]
	[FieldOffset(Offset = "0x1C")]
	private bool success_;

	[Token(Token = "0x4002CCF")]
	public const int SlotFieldNumber = 2;

	[Token(Token = "0x4002CD0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ObjectSlot SlotDefaultValue;

	[Token(Token = "0x4002CD1")]
	[FieldOffset(Offset = "0x20")]
	private ObjectSlot slot_;

	[Token(Token = "0x17001BDA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEquipObjectBestSlotResponse> Parser
	{
		[Token(Token = "0x6007EEB")]
		[Address(RVA = "0xC64640", Offset = "0xC63A40", VA = "0x180C64640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007EEC")]
		[Address(RVA = "0xC64590", Offset = "0xC63990", VA = "0x180C64590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007EED")]
		[Address(RVA = "0xC64880", Offset = "0xC63C80", VA = "0x180C64880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x6007EF1")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007EF2")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x17001BDE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectSlot Slot
	{
		[Token(Token = "0x6007EF3")]
		[Address(RVA = "0xC64690", Offset = "0xC63A90", VA = "0x180C64690")]
		get
		{
			return default(ObjectSlot);
		}
		[Token(Token = "0x6007EF4")]
		[Address(RVA = "0x939960", Offset = "0x938D60", VA = "0x180939960")]
		set
		{
		}
	}

	[Token(Token = "0x17001BDF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSlot
	{
		[Token(Token = "0x6007EF5")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007EEE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipObjectBestSlotResponse()
	{
	}

	[Token(Token = "0x6007EEF")]
	[Address(RVA = "0xC64530", Offset = "0xC63930", VA = "0x180C64530")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipObjectBestSlotResponse(OutfitEquipObjectBestSlotResponse other)
	{
	}

	[Token(Token = "0x6007EF0")]
	[Address(RVA = "0xC64070", Offset = "0xC63470", VA = "0x180C64070", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipObjectBestSlotResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007EF6")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearSlot()
	{
	}

	[Token(Token = "0x6007EF7")]
	[Address(RVA = "0xC64100", Offset = "0xC63500", VA = "0x180C64100", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EF8")]
	[Address(RVA = "0xC641C0", Offset = "0xC635C0", VA = "0x180C641C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitEquipObjectBestSlotResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EF9")]
	[Address(RVA = "0xC64240", Offset = "0xC63640", VA = "0x180C64240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007EFA")]
	[Address(RVA = "0xC643C0", Offset = "0xC637C0", VA = "0x180C643C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007EFB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007EFC")]
	[Address(RVA = "0xC647C0", Offset = "0xC63BC0", VA = "0x180C647C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007EFD")]
	[Address(RVA = "0xC63F90", Offset = "0xC63390", VA = "0x180C63F90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007EFE")]
	[Address(RVA = "0xC64350", Offset = "0xC63750", VA = "0x180C64350", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipObjectBestSlotResponse other)
	{
	}

	[Token(Token = "0x6007EFF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007F00")]
	[Address(RVA = "0xC64700", Offset = "0xC63B00", VA = "0x180C64700", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
