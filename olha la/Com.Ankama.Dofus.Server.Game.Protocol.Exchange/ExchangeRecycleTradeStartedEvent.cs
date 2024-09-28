using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006D7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeRecycleTradeStartedEvent : IMessage<ExchangeRecycleTradeStartedEvent>, IMessage, IEquatable<ExchangeRecycleTradeStartedEvent>, IDeepCloneable<ExchangeRecycleTradeStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4001800")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeRecycleTradeStartedEvent> _parser;

	[Token(Token = "0x4001801")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001802")]
	public const int PercentToPrismFieldNumber = 1;

	[Token(Token = "0x4001803")]
	[FieldOffset(Offset = "0x18")]
	private int percentToPrism_;

	[Token(Token = "0x4001804")]
	public const int PercentToPlayerFieldNumber = 2;

	[Token(Token = "0x4001805")]
	[FieldOffset(Offset = "0x1C")]
	private int percentToPlayer_;

	[Token(Token = "0x4001806")]
	public const int AdjacentSubareasPossessedFieldNumber = 3;

	[Token(Token = "0x4001807")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_adjacentSubareasPossessed_codec;

	[Token(Token = "0x4001808")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> adjacentSubareasPossessed_;

	[Token(Token = "0x4001809")]
	public const int AdjacentSubareasNotPossessedFieldNumber = 4;

	[Token(Token = "0x400180A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_adjacentSubareasNotPossessed_codec;

	[Token(Token = "0x400180B")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<int> adjacentSubareasNotPossessed_;

	[Token(Token = "0x17000FB8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeRecycleTradeStartedEvent> Parser
	{
		[Token(Token = "0x6004993")]
		[Address(RVA = "0xAAAD50", Offset = "0xAAA150", VA = "0x180AAAD50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FB9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004994")]
		[Address(RVA = "0xAAACA0", Offset = "0xAAA0A0", VA = "0x180AAACA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FBA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004995")]
		[Address(RVA = "0xAAB070", Offset = "0xAAA470", VA = "0x180AAB070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FBB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PercentToPrism
	{
		[Token(Token = "0x6004999")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600499A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000FBC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PercentToPlayer
	{
		[Token(Token = "0x600499B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600499C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000FBD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> AdjacentSubareasPossessed
	{
		[Token(Token = "0x600499D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FBE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> AdjacentSubareasNotPossessed
	{
		[Token(Token = "0x600499E")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004996")]
	[Address(RVA = "0xAAABF0", Offset = "0xAA9FF0", VA = "0x180AAABF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeRecycleTradeStartedEvent()
	{
	}

	[Token(Token = "0x6004997")]
	[Address(RVA = "0xAAAB30", Offset = "0xAA9F30", VA = "0x180AAAB30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeRecycleTradeStartedEvent(ExchangeRecycleTradeStartedEvent other)
	{
	}

	[Token(Token = "0x6004998")]
	[Address(RVA = "0xAAA530", Offset = "0xAA9930", VA = "0x180AAA530", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeRecycleTradeStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600499F")]
	[Address(RVA = "0xAAA6E0", Offset = "0xAA9AE0", VA = "0x180AAA6E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60049A0")]
	[Address(RVA = "0xAAA620", Offset = "0xAA9A20", VA = "0x180AAA620", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeRecycleTradeStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60049A1")]
	[Address(RVA = "0xAAA7F0", Offset = "0xAA9BF0", VA = "0x180AAA7F0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60049A2")]
	[Address(RVA = "0xAAA970", Offset = "0xAA9D70", VA = "0x180AAA970", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60049A3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60049A4")]
	[Address(RVA = "0xAAAF50", Offset = "0xAAA350", VA = "0x180AAAF50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60049A5")]
	[Address(RVA = "0xAAA3F0", Offset = "0xAA97F0", VA = "0x180AAA3F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60049A6")]
	[Address(RVA = "0xAAA8C0", Offset = "0xAA9CC0", VA = "0x180AAA8C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeRecycleTradeStartedEvent other)
	{
	}

	[Token(Token = "0x60049A7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60049A8")]
	[Address(RVA = "0xAAADA0", Offset = "0xAAA1A0", VA = "0x180AAADA0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
