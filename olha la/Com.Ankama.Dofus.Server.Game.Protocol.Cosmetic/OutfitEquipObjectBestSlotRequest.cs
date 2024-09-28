using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C11")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipObjectBestSlotRequest : IMessage<OutfitEquipObjectBestSlotRequest>, IMessage, IEquatable<OutfitEquipObjectBestSlotRequest>, IDeepCloneable<OutfitEquipObjectBestSlotRequest>, IBufferMessage
{
	[Token(Token = "0x4002CC1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipObjectBestSlotRequest> _parser;

	[Token(Token = "0x4002CC2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CC3")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002CC4")]
	public const int GidFieldNumber = 1;

	[Token(Token = "0x4002CC5")]
	[FieldOffset(Offset = "0x1C")]
	private int gid_;

	[Token(Token = "0x4002CC6")]
	public const int SkinIdFieldNumber = 2;

	[Token(Token = "0x4002CC7")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int SkinIdDefaultValue;

	[Token(Token = "0x4002CC8")]
	[FieldOffset(Offset = "0x20")]
	private int skinId_;

	[Token(Token = "0x17001BD4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEquipObjectBestSlotRequest> Parser
	{
		[Token(Token = "0x6007ED1")]
		[Address(RVA = "0xC63D30", Offset = "0xC63130", VA = "0x180C63D30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007ED2")]
		[Address(RVA = "0xC63C80", Offset = "0xC63080", VA = "0x180C63C80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007ED3")]
		[Address(RVA = "0xC63EB0", Offset = "0xC632B0", VA = "0x180C63EB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Gid
	{
		[Token(Token = "0x6007ED7")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007ED8")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001BD8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkinId
	{
		[Token(Token = "0x6007ED9")]
		[Address(RVA = "0xC63D80", Offset = "0xC63180", VA = "0x180C63D80")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007EDA")]
		[Address(RVA = "0x939960", Offset = "0x938D60", VA = "0x180939960")]
		set
		{
		}
	}

	[Token(Token = "0x17001BD9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSkinId
	{
		[Token(Token = "0x6007EDB")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007ED4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEquipObjectBestSlotRequest()
	{
	}

	[Token(Token = "0x6007ED5")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipObjectBestSlotRequest(OutfitEquipObjectBestSlotRequest other)
	{
	}

	[Token(Token = "0x6007ED6")]
	[Address(RVA = "0xC637F0", Offset = "0xC62BF0", VA = "0x180C637F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipObjectBestSlotRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007EDC")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearSkinId()
	{
	}

	[Token(Token = "0x6007EDD")]
	[Address(RVA = "0xC63880", Offset = "0xC62C80", VA = "0x180C63880", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EDE")]
	[Address(RVA = "0xC63940", Offset = "0xC62D40", VA = "0x180C63940", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitEquipObjectBestSlotRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007EDF")]
	[Address(RVA = "0xC639C0", Offset = "0xC62DC0", VA = "0x180C639C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007EE0")]
	[Address(RVA = "0xC63B10", Offset = "0xC62F10", VA = "0x180C63B10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007EE1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007EE2")]
	[Address(RVA = "0xC63DF0", Offset = "0xC631F0", VA = "0x180C63DF0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007EE3")]
	[Address(RVA = "0xC636E0", Offset = "0xC62AE0", VA = "0x180C636E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007EE4")]
	[Address(RVA = "0xC63AA0", Offset = "0xC62EA0", VA = "0x180C63AA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipObjectBestSlotRequest other)
	{
	}

	[Token(Token = "0x6007EE5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007EE6")]
	[Address(RVA = "0x939700", Offset = "0x938B00", VA = "0x180939700", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
