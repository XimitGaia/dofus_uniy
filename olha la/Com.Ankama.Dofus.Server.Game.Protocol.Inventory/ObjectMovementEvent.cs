using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003A5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectMovementEvent : IMessage<ObjectMovementEvent>, IMessage, IEquatable<ObjectMovementEvent>, IDeepCloneable<ObjectMovementEvent>, IBufferMessage
{
	[Token(Token = "0x4000C8B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectMovementEvent> _parser;

	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C8D")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4000C8F")]
	public const int PositionFieldNumber = 2;

	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0x1C")]
	private int position_;

	[Token(Token = "0x1700081D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectMovementEvent> Parser
	{
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x9915F0", Offset = "0x9909F0", VA = "0x1809915F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x991540", Offset = "0x990940", VA = "0x180991540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x991640", Offset = "0x990A40", VA = "0x180991640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000820")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000821")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Position
	{
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60025E9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectMovementEvent()
	{
	}

	[Token(Token = "0x60025EA")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectMovementEvent(ObjectMovementEvent other)
	{
	}

	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x9912C0", Offset = "0x9906C0", VA = "0x1809912C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectMovementEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60025F1")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectMovementEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60025F2")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60025F3")]
	[Address(RVA = "0x9913E0", Offset = "0x9907E0", VA = "0x1809913E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60025F4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60025F5")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60025F6")]
	[Address(RVA = "0x991200", Offset = "0x990600", VA = "0x180991200", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60025F7")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectMovementEvent other)
	{
	}

	[Token(Token = "0x60025F8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60025F9")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
