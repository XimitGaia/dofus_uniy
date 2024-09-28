using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000516")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapMovementRequest : IMessage<MapMovementRequest>, IMessage, IEquatable<MapMovementRequest>, IDeepCloneable<MapMovementRequest>, IBufferMessage
{
	[Token(Token = "0x400114E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapMovementRequest> _parser;

	[Token(Token = "0x400114F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001150")]
	public const int KeyCellsFieldNumber = 1;

	[Token(Token = "0x4001151")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_keyCells_codec;

	[Token(Token = "0x4001152")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> keyCells_;

	[Token(Token = "0x4001153")]
	public const int MapIdFieldNumber = 2;

	[Token(Token = "0x4001154")]
	[FieldOffset(Offset = "0x20")]
	private long mapId_;

	[Token(Token = "0x4001155")]
	public const int CautiousFieldNumber = 3;

	[Token(Token = "0x4001156")]
	[FieldOffset(Offset = "0x28")]
	private bool cautious_;

	[Token(Token = "0x17000B6A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapMovementRequest> Parser
	{
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0xA0B010", Offset = "0xA0A410", VA = "0x180A0B010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B6B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0xA0AF60", Offset = "0xA0A360", VA = "0x180A0AF60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B6C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0xA0B2C0", Offset = "0xA0A6C0", VA = "0x180A0B2C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B6D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> KeyCells
	{
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B6E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B6F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Cautious
	{
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x60035D3")]
	[Address(RVA = "0xA0AE40", Offset = "0xA0A240", VA = "0x180A0AE40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementRequest()
	{
	}

	[Token(Token = "0x60035D4")]
	[Address(RVA = "0xA0AEC0", Offset = "0xA0A2C0", VA = "0x180A0AEC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementRequest(MapMovementRequest other)
	{
	}

	[Token(Token = "0x60035D5")]
	[Address(RVA = "0xA0A8D0", Offset = "0xA09CD0", VA = "0x180A0A8D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60035DB")]
	[Address(RVA = "0xA0A9A0", Offset = "0xA09DA0", VA = "0x180A0A9A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60035DC")]
	[Address(RVA = "0xA0AA90", Offset = "0xA09E90", VA = "0x180A0AA90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapMovementRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60035DD")]
	[Address(RVA = "0xA0AB30", Offset = "0xA09F30", VA = "0x180A0AB30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60035DE")]
	[Address(RVA = "0xA0ACB0", Offset = "0xA0A0B0", VA = "0x180A0ACB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60035DF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60035E0")]
	[Address(RVA = "0xA0B1C0", Offset = "0xA0A5C0", VA = "0x180A0B1C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60035E1")]
	[Address(RVA = "0xA0A7E0", Offset = "0xA09BE0", VA = "0x180A0A7E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60035E2")]
	[Address(RVA = "0xA0AC10", Offset = "0xA0A010", VA = "0x180A0AC10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapMovementRequest other)
	{
	}

	[Token(Token = "0x60035E3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60035E4")]
	[Address(RVA = "0xA0B060", Offset = "0xA0A460", VA = "0x180A0B060", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
