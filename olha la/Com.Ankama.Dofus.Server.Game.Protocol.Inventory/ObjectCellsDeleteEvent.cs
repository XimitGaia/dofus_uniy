using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003A3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectCellsDeleteEvent : IMessage<ObjectCellsDeleteEvent>, IMessage, IEquatable<ObjectCellsDeleteEvent>, IDeepCloneable<ObjectCellsDeleteEvent>, IBufferMessage
{
	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectCellsDeleteEvent> _parser;

	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C87")]
	public const int CellsIdFieldNumber = 1;

	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_cellsId_codec;

	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> cellsId_;

	[Token(Token = "0x17000819")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectCellsDeleteEvent> Parser
	{
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x98BEE0", Offset = "0x98B2E0", VA = "0x18098BEE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x98BE30", Offset = "0x98B230", VA = "0x18098BE30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x98C100", Offset = "0x98B500", VA = "0x18098C100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> CellsId
	{
		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025D4")]
	[Address(RVA = "0x98BD20", Offset = "0x98B120", VA = "0x18098BD20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectCellsDeleteEvent()
	{
	}

	[Token(Token = "0x60025D5")]
	[Address(RVA = "0x98BDA0", Offset = "0x98B1A0", VA = "0x18098BDA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectCellsDeleteEvent(ObjectCellsDeleteEvent other)
	{
	}

	[Token(Token = "0x60025D6")]
	[Address(RVA = "0x98B8E0", Offset = "0x98ACE0", VA = "0x18098B8E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectCellsDeleteEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60025D8")]
	[Address(RVA = "0x98BA30", Offset = "0x98AE30", VA = "0x18098BA30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60025D9")]
	[Address(RVA = "0x98B9A0", Offset = "0x98ADA0", VA = "0x18098B9A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectCellsDeleteEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60025DA")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60025DB")]
	[Address(RVA = "0x98BB90", Offset = "0x98AF90", VA = "0x18098BB90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60025DC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x98C050", Offset = "0x98B450", VA = "0x18098C050", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60025DE")]
	[Address(RVA = "0x98B840", Offset = "0x98AC40", VA = "0x18098B840", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60025DF")]
	[Address(RVA = "0x98BB10", Offset = "0x98AF10", VA = "0x18098BB10", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectCellsDeleteEvent other)
	{
	}

	[Token(Token = "0x60025E0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x98BF30", Offset = "0x98B330", VA = "0x18098BF30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
