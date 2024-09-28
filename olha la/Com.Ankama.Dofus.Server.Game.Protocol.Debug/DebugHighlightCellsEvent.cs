using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug;

[Token(Token = "0x200076D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DebugHighlightCellsEvent : IMessage<DebugHighlightCellsEvent>, IMessage, IEquatable<DebugHighlightCellsEvent>, IDeepCloneable<DebugHighlightCellsEvent>, IBufferMessage
{
	[Token(Token = "0x40019FC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DebugHighlightCellsEvent> _parser;

	[Token(Token = "0x40019FD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019FE")]
	public const int ColorFieldNumber = 1;

	[Token(Token = "0x40019FF")]
	[FieldOffset(Offset = "0x18")]
	private long color_;

	[Token(Token = "0x4001A00")]
	public const int CellsFieldNumber = 2;

	[Token(Token = "0x4001A01")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_cells_codec;

	[Token(Token = "0x4001A02")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> cells_;

	[Token(Token = "0x170010F9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DebugHighlightCellsEvent> Parser
	{
		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0xAD86D0", Offset = "0xAD7AD0", VA = "0x180AD86D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010FA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0xAD8620", Offset = "0xAD7A20", VA = "0x180AD8620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010FB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004F5F")]
		[Address(RVA = "0xAD8920", Offset = "0xAD7D20", VA = "0x180AD8920", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010FC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Color
	{
		[Token(Token = "0x6004F63")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004F64")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170010FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Cells
	{
		[Token(Token = "0x6004F65")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F60")]
	[Address(RVA = "0xAD8500", Offset = "0xAD7900", VA = "0x180AD8500")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DebugHighlightCellsEvent()
	{
	}

	[Token(Token = "0x6004F61")]
	[Address(RVA = "0xAD8580", Offset = "0xAD7980", VA = "0x180AD8580")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DebugHighlightCellsEvent(DebugHighlightCellsEvent other)
	{
	}

	[Token(Token = "0x6004F62")]
	[Address(RVA = "0xAD80A0", Offset = "0xAD74A0", VA = "0x180AD80A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DebugHighlightCellsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004F66")]
	[Address(RVA = "0xAD8160", Offset = "0xAD7560", VA = "0x180AD8160", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F67")]
	[Address(RVA = "0xAD8240", Offset = "0xAD7640", VA = "0x180AD8240", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DebugHighlightCellsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F68")]
	[Address(RVA = "0x97D020", Offset = "0x97C420", VA = "0x18097D020", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004F69")]
	[Address(RVA = "0xAD8370", Offset = "0xAD7770", VA = "0x180AD8370", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004F6A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004F6B")]
	[Address(RVA = "0xAD8850", Offset = "0xAD7C50", VA = "0x180AD8850", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004F6C")]
	[Address(RVA = "0xAD7FC0", Offset = "0xAD73C0", VA = "0x180AD7FC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004F6D")]
	[Address(RVA = "0xAD82E0", Offset = "0xAD76E0", VA = "0x180AD82E0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DebugHighlightCellsEvent other)
	{
	}

	[Token(Token = "0x6004F6E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004F6F")]
	[Address(RVA = "0xAD8720", Offset = "0xAD7B20", VA = "0x180AD8720", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
