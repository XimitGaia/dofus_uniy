using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A3A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightStartingPositions : IMessage<FightStartingPositions>, IMessage, IEquatable<FightStartingPositions>, IDeepCloneable<FightStartingPositions>, IBufferMessage
{
	[Token(Token = "0x40024D7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightStartingPositions> _parser;

	[Token(Token = "0x40024D8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40024D9")]
	public const int ChallengersPositionsFieldNumber = 1;

	[Token(Token = "0x40024DA")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_challengersPositions_codec;

	[Token(Token = "0x40024DB")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> challengersPositions_;

	[Token(Token = "0x40024DC")]
	public const int DefendersPositionsFieldNumber = 2;

	[Token(Token = "0x40024DD")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_defendersPositions_codec;

	[Token(Token = "0x40024DE")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> defendersPositions_;

	[Token(Token = "0x17001719")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightStartingPositions> Parser
	{
		[Token(Token = "0x6006AEF")]
		[Address(RVA = "0xBB9AF0", Offset = "0xBB8EF0", VA = "0x180BB9AF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006AF0")]
		[Address(RVA = "0xBB9A40", Offset = "0xBB8E40", VA = "0x180BB9A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006AF1")]
		[Address(RVA = "0xBB9D80", Offset = "0xBB9180", VA = "0x180BB9D80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ChallengersPositions
	{
		[Token(Token = "0x6006AF5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DefendersPositions
	{
		[Token(Token = "0x6006AF6")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006AF2")]
	[Address(RVA = "0xBB98E0", Offset = "0xBB8CE0", VA = "0x180BB98E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightStartingPositions()
	{
	}

	[Token(Token = "0x6006AF3")]
	[Address(RVA = "0xBB9990", Offset = "0xBB8D90", VA = "0x180BB9990")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightStartingPositions(FightStartingPositions other)
	{
	}

	[Token(Token = "0x6006AF4")]
	[Address(RVA = "0xBB9400", Offset = "0xBB8800", VA = "0x180BB9400", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightStartingPositions Clone()
	{
		return null;
	}

	[Token(Token = "0x6006AF7")]
	[Address(RVA = "0xBB9590", Offset = "0xBB8990", VA = "0x180BB9590", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AF8")]
	[Address(RVA = "0xBB94E0", Offset = "0xBB88E0", VA = "0x180BB94E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightStartingPositions other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006AF9")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006AFA")]
	[Address(RVA = "0xBB9720", Offset = "0xBB8B20", VA = "0x180BB9720", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006AFB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006AFC")]
	[Address(RVA = "0xBB9CA0", Offset = "0xBB90A0", VA = "0x180BB9CA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006AFD")]
	[Address(RVA = "0xBB9320", Offset = "0xBB8720", VA = "0x180BB9320", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006AFE")]
	[Address(RVA = "0xBB9680", Offset = "0xBB8A80", VA = "0x180BB9680", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightStartingPositions other)
	{
	}

	[Token(Token = "0x6006AFF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006B00")]
	[Address(RVA = "0xBB9B40", Offset = "0xBB8F40", VA = "0x180BB9B40", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
