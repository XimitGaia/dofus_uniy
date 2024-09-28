using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200052A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapMovementRefusedEvent : IMessage<MapMovementRefusedEvent>, IMessage, IEquatable<MapMovementRefusedEvent>, IDeepCloneable<MapMovementRefusedEvent>, IBufferMessage
{
	[Token(Token = "0x4001181")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapMovementRefusedEvent> _parser;

	[Token(Token = "0x4001182")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001183")]
	public const int CellXFieldNumber = 1;

	[Token(Token = "0x4001184")]
	[FieldOffset(Offset = "0x18")]
	private int cellX_;

	[Token(Token = "0x4001185")]
	public const int CellYFieldNumber = 2;

	[Token(Token = "0x4001186")]
	[FieldOffset(Offset = "0x1C")]
	private int cellY_;

	[Token(Token = "0x17000B92")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapMovementRefusedEvent> Parser
	{
		[Token(Token = "0x60036AB")]
		[Address(RVA = "0xA0A6B0", Offset = "0xA09AB0", VA = "0x180A0A6B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B93")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60036AC")]
		[Address(RVA = "0xA0A600", Offset = "0xA09A00", VA = "0x180A0A600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B94")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60036AD")]
		[Address(RVA = "0xA0A700", Offset = "0xA09B00", VA = "0x180A0A700", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B95")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CellX
	{
		[Token(Token = "0x60036B1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60036B2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000B96")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellY
	{
		[Token(Token = "0x60036B3")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60036B4")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60036AE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementRefusedEvent()
	{
	}

	[Token(Token = "0x60036AF")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementRefusedEvent(MapMovementRefusedEvent other)
	{
	}

	[Token(Token = "0x60036B0")]
	[Address(RVA = "0xA0A380", Offset = "0xA09780", VA = "0x180A0A380", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapMovementRefusedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60036B5")]
	[Address(RVA = "0xA0A410", Offset = "0xA09810", VA = "0x180A0A410", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60036B6")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapMovementRefusedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60036B7")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60036B8")]
	[Address(RVA = "0xA0A4A0", Offset = "0xA098A0", VA = "0x180A0A4A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60036B9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60036BA")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60036BB")]
	[Address(RVA = "0xA0A2C0", Offset = "0xA096C0", VA = "0x180A0A2C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60036BC")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MapMovementRefusedEvent other)
	{
	}

	[Token(Token = "0x60036BD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60036BE")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
