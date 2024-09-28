using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AAF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutObjectItem : IMessage<ShortcutObjectItem>, IMessage, IEquatable<ShortcutObjectItem>, IDeepCloneable<ShortcutObjectItem>, IBufferMessage
{
	[Token(Token = "0x400271B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutObjectItem> _parser;

	[Token(Token = "0x400271C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400271D")]
	public const int ItemUidFieldNumber = 1;

	[Token(Token = "0x400271E")]
	[FieldOffset(Offset = "0x18")]
	private int itemUid_;

	[Token(Token = "0x400271F")]
	public const int ItemGidFieldNumber = 2;

	[Token(Token = "0x4002720")]
	[FieldOffset(Offset = "0x1C")]
	private int itemGid_;

	[Token(Token = "0x17001862")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShortcutObjectItem> Parser
	{
		[Token(Token = "0x6006FCE")]
		[Address(RVA = "0xBE9A40", Offset = "0xBE8E40", VA = "0x180BE9A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001863")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006FCF")]
		[Address(RVA = "0xBE9990", Offset = "0xBE8D90", VA = "0x180BE9990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001864")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006FD0")]
		[Address(RVA = "0xBE9A90", Offset = "0xBE8E90", VA = "0x180BE9A90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001865")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemUid
	{
		[Token(Token = "0x6006FD4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006FD5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001866")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemGid
	{
		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006FD7")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6006FD1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutObjectItem()
	{
	}

	[Token(Token = "0x6006FD2")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutObjectItem(ShortcutObjectItem other)
	{
	}

	[Token(Token = "0x6006FD3")]
	[Address(RVA = "0xBE9710", Offset = "0xBE8B10", VA = "0x180BE9710", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutObjectItem Clone()
	{
		return null;
	}

	[Token(Token = "0x6006FD8")]
	[Address(RVA = "0xBE97A0", Offset = "0xBE8BA0", VA = "0x180BE97A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FD9")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShortcutObjectItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FDA")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006FDB")]
	[Address(RVA = "0xBE9830", Offset = "0xBE8C30", VA = "0x180BE9830", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006FDC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006FDD")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006FDE")]
	[Address(RVA = "0xBE9650", Offset = "0xBE8A50", VA = "0x180BE9650", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006FDF")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ShortcutObjectItem other)
	{
	}

	[Token(Token = "0x6006FE0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006FE1")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
