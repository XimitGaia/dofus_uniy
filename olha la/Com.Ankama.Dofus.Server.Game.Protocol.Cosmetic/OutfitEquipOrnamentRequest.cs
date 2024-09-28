using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C09")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEquipOrnamentRequest : IMessage<OutfitEquipOrnamentRequest>, IMessage, IEquatable<OutfitEquipOrnamentRequest>, IDeepCloneable<OutfitEquipOrnamentRequest>, IBufferMessage
{
	[Token(Token = "0x4002CA4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEquipOrnamentRequest> _parser;

	[Token(Token = "0x4002CA5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002CA6")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002CA7")]
	public const int OrnamentIdFieldNumber = 1;

	[Token(Token = "0x4002CA8")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int OrnamentIdDefaultValue;

	[Token(Token = "0x4002CA9")]
	[FieldOffset(Offset = "0x1C")]
	private int ornamentId_;

	[Token(Token = "0x17001BBF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OutfitEquipOrnamentRequest> Parser
	{
		[Token(Token = "0x6007E6F")]
		[Address(RVA = "0xC66020", Offset = "0xC65420", VA = "0x180C66020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007E70")]
		[Address(RVA = "0xC65F00", Offset = "0xC65300", VA = "0x180C65F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BC1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007E71")]
		[Address(RVA = "0xC66110", Offset = "0xC65510", VA = "0x180C66110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BC2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OrnamentId
	{
		[Token(Token = "0x6007E75")]
		[Address(RVA = "0xC65FB0", Offset = "0xC653B0", VA = "0x180C65FB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E76")]
		[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
		set
		{
		}
	}

	[Token(Token = "0x17001BC3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasOrnamentId
	{
		[Token(Token = "0x6007E77")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007E72")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipOrnamentRequest()
	{
	}

	[Token(Token = "0x6007E73")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipOrnamentRequest(OutfitEquipOrnamentRequest other)
	{
	}

	[Token(Token = "0x6007E74")]
	[Address(RVA = "0xC65AC0", Offset = "0xC64EC0", VA = "0x180C65AC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEquipOrnamentRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007E78")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearOrnamentId()
	{
	}

	[Token(Token = "0x6007E79")]
	[Address(RVA = "0xC65BC0", Offset = "0xC64FC0", VA = "0x180C65BC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E7A")]
	[Address(RVA = "0xC65B50", Offset = "0xC64F50", VA = "0x180C65B50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEquipOrnamentRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E7B")]
	[Address(RVA = "0xC65C70", Offset = "0xC65070", VA = "0x180C65C70", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007E7C")]
	[Address(RVA = "0xC65D90", Offset = "0xC65190", VA = "0x180C65D90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007E7D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007E7E")]
	[Address(RVA = "0xC66070", Offset = "0xC65470", VA = "0x180C66070", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007E7F")]
	[Address(RVA = "0xC659F0", Offset = "0xC64DF0", VA = "0x180C659F0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007E80")]
	[Address(RVA = "0xC65D30", Offset = "0xC65130", VA = "0x180C65D30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEquipOrnamentRequest other)
	{
	}

	[Token(Token = "0x6007E81")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007E82")]
	[Address(RVA = "0xAB9600", Offset = "0xAB8A00", VA = "0x180AB9600", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
