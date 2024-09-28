using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x2000567")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionSpamEvent : IMessage<GameActionSpamEvent>, IMessage, IEquatable<GameActionSpamEvent>, IDeepCloneable<GameActionSpamEvent>, IBufferMessage
{
	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionSpamEvent> _parser;

	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400128D")]
	public const int CellsFieldNumber = 1;

	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_cells_codec;

	[Token(Token = "0x400128F")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> cells_;

	[Token(Token = "0x17000C2D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GameActionSpamEvent> Parser
	{
		[Token(Token = "0x600394A")]
		[Address(RVA = "0xA24AF0", Offset = "0xA23EF0", VA = "0x180A24AF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C2E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600394B")]
		[Address(RVA = "0xA24A40", Offset = "0xA23E40", VA = "0x180A24A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C2F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600394C")]
		[Address(RVA = "0xA24D10", Offset = "0xA24110", VA = "0x180A24D10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Cells
	{
		[Token(Token = "0x6003950")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600394D")]
	[Address(RVA = "0xA24930", Offset = "0xA23D30", VA = "0x180A24930")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionSpamEvent()
	{
	}

	[Token(Token = "0x600394E")]
	[Address(RVA = "0xA249B0", Offset = "0xA23DB0", VA = "0x180A249B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionSpamEvent(GameActionSpamEvent other)
	{
	}

	[Token(Token = "0x600394F")]
	[Address(RVA = "0xA244F0", Offset = "0xA238F0", VA = "0x180A244F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionSpamEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003951")]
	[Address(RVA = "0xA245B0", Offset = "0xA239B0", VA = "0x180A245B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003952")]
	[Address(RVA = "0xA24690", Offset = "0xA23A90", VA = "0x180A24690", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionSpamEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003953")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003954")]
	[Address(RVA = "0xA247A0", Offset = "0xA23BA0", VA = "0x180A247A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003955")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003956")]
	[Address(RVA = "0xA24C60", Offset = "0xA24060", VA = "0x180A24C60", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003957")]
	[Address(RVA = "0xA24450", Offset = "0xA23850", VA = "0x180A24450", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003958")]
	[Address(RVA = "0xA24720", Offset = "0xA23B20", VA = "0x180A24720", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionSpamEvent other)
	{
	}

	[Token(Token = "0x6003959")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600395A")]
	[Address(RVA = "0xA24B40", Offset = "0xA23F40", VA = "0x180A24B40", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
