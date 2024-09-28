using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A78")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightCharacteristics : IMessage<FightCharacteristics>, IMessage, IEquatable<FightCharacteristics>, IDeepCloneable<FightCharacteristics>, IBufferMessage
{
	[Token(Token = "0x40025F5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightCharacteristics> _parser;

	[Token(Token = "0x40025F6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40025F7")]
	public const int CharacteristicsFieldNumber = 1;

	[Token(Token = "0x40025F8")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<CharacterCharacteristic> _repeated_characteristics_codec;

	[Token(Token = "0x40025F9")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<CharacterCharacteristic> characteristics_;

	[Token(Token = "0x40025FA")]
	public const int SummonerFieldNumber = 2;

	[Token(Token = "0x40025FB")]
	[FieldOffset(Offset = "0x20")]
	private long summoner_;

	[Token(Token = "0x40025FC")]
	public const int SummonedFieldNumber = 3;

	[Token(Token = "0x40025FD")]
	[FieldOffset(Offset = "0x28")]
	private bool summoned_;

	[Token(Token = "0x40025FE")]
	public const int InvisibilityStateFieldNumber = 4;

	[Token(Token = "0x40025FF")]
	[FieldOffset(Offset = "0x2C")]
	private FightInvisibilityState invisibilityState_;

	[Token(Token = "0x170017BF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightCharacteristics> Parser
	{
		[Token(Token = "0x6006D77")]
		[Address(RVA = "0xBC9450", Offset = "0xBC8850", VA = "0x180BC9450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006D78")]
		[Address(RVA = "0xBC93A0", Offset = "0xBC87A0", VA = "0x180BC93A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006D79")]
		[Address(RVA = "0xBC9740", Offset = "0xBC8B40", VA = "0x180BC9740", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharacterCharacteristic> Characteristics
	{
		[Token(Token = "0x6006D7D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Summoner
	{
		[Token(Token = "0x6006D7E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170017C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Summoned
	{
		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006D81")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x170017C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightInvisibilityState InvisibilityState
	{
		[Token(Token = "0x6006D82")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(FightInvisibilityState);
		}
		[Token(Token = "0x6006D83")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x6006D7A")]
	[Address(RVA = "0xBC9320", Offset = "0xBC8720", VA = "0x180BC9320")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightCharacteristics()
	{
	}

	[Token(Token = "0x6006D7B")]
	[Address(RVA = "0xBC9280", Offset = "0xBC8680", VA = "0x180BC9280")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightCharacteristics(FightCharacteristics other)
	{
	}

	[Token(Token = "0x6006D7C")]
	[Address(RVA = "0xBC8C70", Offset = "0xBC8070", VA = "0x180BC8C70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightCharacteristics Clone()
	{
		return null;
	}

	[Token(Token = "0x6006D84")]
	[Address(RVA = "0xBC8DF0", Offset = "0xBC81F0", VA = "0x180BC8DF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D85")]
	[Address(RVA = "0xBC8D40", Offset = "0xBC8140", VA = "0x180BC8D40", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightCharacteristics other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D86")]
	[Address(RVA = "0xBC8EE0", Offset = "0xBC82E0", VA = "0x180BC8EE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006D87")]
	[Address(RVA = "0xBC9080", Offset = "0xBC8480", VA = "0x180BC9080", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006D88")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006D89")]
	[Address(RVA = "0xBC9620", Offset = "0xBC8A20", VA = "0x180BC9620", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006D8A")]
	[Address(RVA = "0xBC8B50", Offset = "0xBC7F50", VA = "0x180BC8B50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006D8B")]
	[Address(RVA = "0xBC8FE0", Offset = "0xBC83E0", VA = "0x180BC8FE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightCharacteristics other)
	{
	}

	[Token(Token = "0x6006D8C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006D8D")]
	[Address(RVA = "0xBC94A0", Offset = "0xBC88A0", VA = "0x180BC94A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
