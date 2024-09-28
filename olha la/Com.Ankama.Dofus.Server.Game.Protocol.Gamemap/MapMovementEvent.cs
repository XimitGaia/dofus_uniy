using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200052C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapMovementEvent : IMessage<MapMovementEvent>, IMessage, IEquatable<MapMovementEvent>, IDeepCloneable<MapMovementEvent>, IBufferMessage
{
	[Token(Token = "0x4001188")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapMovementEvent> _parser;

	[Token(Token = "0x4001189")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400118A")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x400118B")]
	public const int CellsFieldNumber = 1;

	[Token(Token = "0x400118C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_cells_codec;

	[Token(Token = "0x400118D")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> cells_;

	[Token(Token = "0x400118E")]
	public const int DirectionFieldNumber = 2;

	[Token(Token = "0x400118F")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int DirectionDefaultValue;

	[Token(Token = "0x4001190")]
	[FieldOffset(Offset = "0x28")]
	private int direction_;

	[Token(Token = "0x4001191")]
	public const int CharacterIdFieldNumber = 3;

	[Token(Token = "0x4001192")]
	[FieldOffset(Offset = "0x30")]
	private long characterId_;

	[Token(Token = "0x4001193")]
	public const int CautiousFieldNumber = 4;

	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0x38")]
	private bool cautious_;

	[Token(Token = "0x17000B97")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapMovementEvent> Parser
	{
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0xA09E90", Offset = "0xA09290", VA = "0x180A09E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B98")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0xA09D70", Offset = "0xA09170", VA = "0x180A09D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B99")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60036C5")]
		[Address(RVA = "0xA0A1D0", Offset = "0xA095D0", VA = "0x180A0A1D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B9A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Cells
	{
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B9B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Direction
	{
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0xA09E20", Offset = "0xA09220", VA = "0x180A09E20")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0xA0A2B0", Offset = "0xA096B0", VA = "0x180A0A2B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B9C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasDirection
	{
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000B9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B9E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Cautious
	{
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x9C5FF0", Offset = "0x9C53F0", VA = "0x1809C5FF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x9C6730", Offset = "0x9C5B30", VA = "0x1809C6730")]
		set
		{
		}
	}

	[Token(Token = "0x60036C6")]
	[Address(RVA = "0xA09CF0", Offset = "0xA090F0", VA = "0x180A09CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementEvent()
	{
	}

	[Token(Token = "0x60036C7")]
	[Address(RVA = "0xA09C40", Offset = "0xA09040", VA = "0x180A09C40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementEvent(MapMovementEvent other)
	{
	}

	[Token(Token = "0x60036C8")]
	[Address(RVA = "0xA095F0", Offset = "0xA089F0", VA = "0x180A095F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60036CD")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDirection()
	{
	}

	[Token(Token = "0x60036D2")]
	[Address(RVA = "0xA096C0", Offset = "0xA08AC0", VA = "0x180A096C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60036D3")]
	[Address(RVA = "0xA097D0", Offset = "0xA08BD0", VA = "0x180A097D0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapMovementEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60036D4")]
	[Address(RVA = "0xA098A0", Offset = "0xA08CA0", VA = "0x180A098A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60036D5")]
	[Address(RVA = "0xA09AA0", Offset = "0xA08EA0", VA = "0x180A09AA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60036D6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60036D7")]
	[Address(RVA = "0xA0A060", Offset = "0xA09460", VA = "0x180A0A060", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60036D8")]
	[Address(RVA = "0xA09480", Offset = "0xA08880", VA = "0x180A09480", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60036D9")]
	[Address(RVA = "0xA099F0", Offset = "0xA08DF0", VA = "0x180A099F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapMovementEvent other)
	{
	}

	[Token(Token = "0x60036DA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60036DB")]
	[Address(RVA = "0xA09EE0", Offset = "0xA092E0", VA = "0x180A09EE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
