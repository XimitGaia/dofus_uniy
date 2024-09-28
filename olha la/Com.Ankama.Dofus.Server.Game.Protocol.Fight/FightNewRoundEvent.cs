using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005E9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightNewRoundEvent : IMessage<FightNewRoundEvent>, IMessage, IEquatable<FightNewRoundEvent>, IDeepCloneable<FightNewRoundEvent>, IBufferMessage
{
	[Token(Token = "0x40014B3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightNewRoundEvent> _parser;

	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014B5")]
	public const int RoundNumberFieldNumber = 1;

	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0x18")]
	private int roundNumber_;

	[Token(Token = "0x17000D8F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightNewRoundEvent> Parser
	{
		[Token(Token = "0x6003F1F")]
		[Address(RVA = "0xA410F0", Offset = "0xA404F0", VA = "0x180A410F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003F20")]
		[Address(RVA = "0xA41040", Offset = "0xA40440", VA = "0x180A41040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D91")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003F21")]
		[Address(RVA = "0xA41140", Offset = "0xA40540", VA = "0x180A41140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D92")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RoundNumber
	{
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003F22")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightNewRoundEvent()
	{
	}

	[Token(Token = "0x6003F23")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightNewRoundEvent(FightNewRoundEvent other)
	{
	}

	[Token(Token = "0x6003F24")]
	[Address(RVA = "0xA40DD0", Offset = "0xA401D0", VA = "0x180A40DD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightNewRoundEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003F27")]
	[Address(RVA = "0xA40E50", Offset = "0xA40250", VA = "0x180A40E50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F28")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightNewRoundEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F29")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003F2A")]
	[Address(RVA = "0xA40EE0", Offset = "0xA402E0", VA = "0x180A40EE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003F2B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003F2C")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003F2D")]
	[Address(RVA = "0xA40D40", Offset = "0xA40140", VA = "0x180A40D40", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003F2E")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightNewRoundEvent other)
	{
	}

	[Token(Token = "0x6003F2F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003F30")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
