using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C03")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitAuraChangedEvent : IMessage<OutfitAuraChangedEvent>, IMessage, IEquatable<OutfitAuraChangedEvent>, IDeepCloneable<OutfitAuraChangedEvent>, IBufferMessage
{
	[Token(Token = "0x4002C91")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitAuraChangedEvent> _parser;

	[Token(Token = "0x4002C92")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C93")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002C94")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x4002C95")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int EmoteIdDefaultValue;

	[Token(Token = "0x4002C96")]
	[FieldOffset(Offset = "0x1C")]
	private int emoteId_;

	[Token(Token = "0x17001BB1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitAuraChangedEvent> Parser
	{
		[Token(Token = "0x6007E29")]
		[Address(RVA = "0xC5FA00", Offset = "0xC5EE00", VA = "0x180C5FA00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BB2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007E2A")]
		[Address(RVA = "0xC5F8E0", Offset = "0xC5ECE0", VA = "0x180C5F8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BB3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007E2B")]
		[Address(RVA = "0xC5FAF0", Offset = "0xC5EEF0", VA = "0x180C5FAF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BB4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EmoteId
	{
		[Token(Token = "0x6007E2F")]
		[Address(RVA = "0xC5F990", Offset = "0xC5ED90", VA = "0x180C5F990")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E30")]
		[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
		set
		{
		}
	}

	[Token(Token = "0x17001BB5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEmoteId
	{
		[Token(Token = "0x6007E31")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007E2C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitAuraChangedEvent()
	{
	}

	[Token(Token = "0x6007E2D")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitAuraChangedEvent(OutfitAuraChangedEvent other)
	{
	}

	[Token(Token = "0x6007E2E")]
	[Address(RVA = "0xC5F4A0", Offset = "0xC5E8A0", VA = "0x180C5F4A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitAuraChangedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007E32")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearEmoteId()
	{
	}

	[Token(Token = "0x6007E33")]
	[Address(RVA = "0xC5F530", Offset = "0xC5E930", VA = "0x180C5F530", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E34")]
	[Address(RVA = "0xC5F5E0", Offset = "0xC5E9E0", VA = "0x180C5F5E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OutfitAuraChangedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007E35")]
	[Address(RVA = "0xC5F650", Offset = "0xC5EA50", VA = "0x180C5F650", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007E36")]
	[Address(RVA = "0xC5F770", Offset = "0xC5EB70", VA = "0x180C5F770", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007E37")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007E38")]
	[Address(RVA = "0xC5FA50", Offset = "0xC5EE50", VA = "0x180C5FA50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007E39")]
	[Address(RVA = "0xC5F3D0", Offset = "0xC5E7D0", VA = "0x180C5F3D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007E3A")]
	[Address(RVA = "0xC5F710", Offset = "0xC5EB10", VA = "0x180C5F710", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitAuraChangedEvent other)
	{
	}

	[Token(Token = "0x6007E3B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007E3C")]
	[Address(RVA = "0xAB9600", Offset = "0xAB8A00", VA = "0x180AB9600", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
