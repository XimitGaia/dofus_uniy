using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C0D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipObjectRequest : IMessage<OutfitEquipObjectRequest>, IMessage, IEquatable<OutfitEquipObjectRequest>, IDeepCloneable<OutfitEquipObjectRequest>, IBufferMessage
{
	[Token(Token = "0x4002CB0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipObjectRequest> _parser;

	[Token(Token = "0x4002CB1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CB2")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002CB3")]
	public const int GidFieldNumber = 1;

	[Token(Token = "0x4002CB4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int GidDefaultValue;

	[Token(Token = "0x4002CB5")]
	[FieldOffset(Offset = "0x1C")]
	private int gid_;

	[Token(Token = "0x4002CB6")]
	public const int SlotFieldNumber = 2;

	[Token(Token = "0x4002CB7")]
	[FieldOffset(Offset = "0x20")]
	private ObjectSlot slot_;

	[Token(Token = "0x4002CB8")]
	public const int SkinIdFieldNumber = 3;

	[Token(Token = "0x4002CB9")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int SkinIdDefaultValue;

	[Token(Token = "0x4002CBA")]
	[FieldOffset(Offset = "0x24")]
	private int skinId_;

	[Token(Token = "0x17001BC8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEquipObjectRequest> Parser
	{
		[Token(Token = "0x6007E9D")]
		[Address(RVA = "0xC65150", Offset = "0xC64550", VA = "0x180C65150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BC9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007E9E")]
		[Address(RVA = "0xC65030", Offset = "0xC64430", VA = "0x180C65030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BCA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007E9F")]
		[Address(RVA = "0xC65420", Offset = "0xC64820", VA = "0x180C65420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BCB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Gid
	{
		[Token(Token = "0x6007EA3")]
		[Address(RVA = "0xC650E0", Offset = "0xC644E0", VA = "0x180C650E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007EA4")]
		[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
		set
		{
		}
	}

	[Token(Token = "0x17001BCC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGid
	{
		[Token(Token = "0x6007EA5")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001BCD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectSlot Slot
	{
		[Token(Token = "0x6007EA7")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ObjectSlot);
		}
		[Token(Token = "0x6007EA8")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001BCE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkinId
	{
		[Token(Token = "0x6007EA9")]
		[Address(RVA = "0xC651A0", Offset = "0xC645A0", VA = "0x180C651A0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007EAA")]
		[Address(RVA = "0xB86A90", Offset = "0xB85E90", VA = "0x180B86A90")]
		set
		{
		}
	}

	[Token(Token = "0x17001BCF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSkinId
	{
		[Token(Token = "0x6007EAB")]
		[Address(RVA = "0xAEF3E0", Offset = "0xAEE7E0", VA = "0x180AEF3E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007EA0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipObjectRequest()
	{
	}

	[Token(Token = "0x6007EA1")]
	[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipObjectRequest(OutfitEquipObjectRequest other)
	{
	}

	[Token(Token = "0x6007EA2")]
	[Address(RVA = "0xC64AE0", Offset = "0xC63EE0", VA = "0x180C64AE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipObjectRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007EA6")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearGid()
	{
	}

	[Token(Token = "0x6007EAC")]
	[Address(RVA = "0xAEE790", Offset = "0xAEDB90", VA = "0x180AEE790")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearSkinId()
	{
	}

	[Token(Token = "0x6007EAD")]
	[Address(RVA = "0xC64C10", Offset = "0xC64010", VA = "0x180C64C10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EAE")]
	[Address(RVA = "0xC64B70", Offset = "0xC63F70", VA = "0x180C64B70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitEquipObjectRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EAF")]
	[Address(RVA = "0xC64CF0", Offset = "0xC640F0", VA = "0x180C64CF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007EB0")]
	[Address(RVA = "0xC64EB0", Offset = "0xC642B0", VA = "0x180C64EB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007EB1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007EB2")]
	[Address(RVA = "0xC652F0", Offset = "0xC646F0", VA = "0x180C652F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007EB3")]
	[Address(RVA = "0xC64960", Offset = "0xC63D60", VA = "0x180C64960", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007EB4")]
	[Address(RVA = "0xC64E30", Offset = "0xC64230", VA = "0x180C64E30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OutfitEquipObjectRequest other)
	{
	}

	[Token(Token = "0x6007EB5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007EB6")]
	[Address(RVA = "0xC65210", Offset = "0xC64610", VA = "0x180C65210", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
