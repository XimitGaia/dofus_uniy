using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005ED")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTurnEvent : IMessage<FightTurnEvent>, IMessage, IEquatable<FightTurnEvent>, IDeepCloneable<FightTurnEvent>, IBufferMessage
{
	[Token(Token = "0x40014C1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTurnEvent> _parser;

	[Token(Token = "0x40014C2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014C3")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40014C4")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x40014C5")]
	[FieldOffset(Offset = "0x20")]
	private long characterId_;

	[Token(Token = "0x40014C6")]
	public const int BaseTimeFieldNumber = 2;

	[Token(Token = "0x40014C7")]
	[FieldOffset(Offset = "0x28")]
	private int baseTime_;

	[Token(Token = "0x40014C8")]
	public const int ExtraTimeFieldNumber = 3;

	[Token(Token = "0x40014C9")]
	[FieldOffset(Offset = "0x2C")]
	private int extraTime_;

	[Token(Token = "0x40014CA")]
	public const int RemainingTimeFieldNumber = 4;

	[Token(Token = "0x40014CB")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int RemainingTimeDefaultValue;

	[Token(Token = "0x40014CC")]
	[FieldOffset(Offset = "0x30")]
	private int remainingTime_;

	[Token(Token = "0x17000D98")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTurnEvent> Parser
	{
		[Token(Token = "0x6003F4B")]
		[Address(RVA = "0xA4CFC0", Offset = "0xA4C3C0", VA = "0x180A4CFC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D99")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003F4C")]
		[Address(RVA = "0xA4CF10", Offset = "0xA4C310", VA = "0x180A4CF10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D9A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003F4D")]
		[Address(RVA = "0xA4D290", Offset = "0xA4C690", VA = "0x180A4D290", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D9B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003F52")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000D9C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BaseTime
	{
		[Token(Token = "0x6003F53")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000D9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ExtraTime
	{
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17000D9E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RemainingTime
	{
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0xA4D010", Offset = "0xA4C410", VA = "0x180A4D010")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0xA4D370", Offset = "0xA4C770", VA = "0x180A4D370")]
		set
		{
		}
	}

	[Token(Token = "0x17000D9F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasRemainingTime
	{
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003F4E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnEvent()
	{
	}

	[Token(Token = "0x6003F4F")]
	[Address(RVA = "0xA4CEA0", Offset = "0xA4C2A0", VA = "0x180A4CEA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnEvent(FightTurnEvent other)
	{
	}

	[Token(Token = "0x6003F50")]
	[Address(RVA = "0xA4C9A0", Offset = "0xA4BDA0", VA = "0x180A4C9A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003F5A")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRemainingTime()
	{
	}

	[Token(Token = "0x6003F5B")]
	[Address(RVA = "0xA4CAD0", Offset = "0xA4BED0", VA = "0x180A4CAD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F5C")]
	[Address(RVA = "0xA4CA40", Offset = "0xA4BE40", VA = "0x180A4CA40", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTurnEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F5D")]
	[Address(RVA = "0xA4CBA0", Offset = "0xA4BFA0", VA = "0x180A4CBA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003F5E")]
	[Address(RVA = "0xA4CD30", Offset = "0xA4C130", VA = "0x180A4CD30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003F5F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003F60")]
	[Address(RVA = "0xA4D180", Offset = "0xA4C580", VA = "0x180A4D180", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003F61")]
	[Address(RVA = "0xA4C840", Offset = "0xA4BC40", VA = "0x180A4C840", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003F62")]
	[Address(RVA = "0xA4CCB0", Offset = "0xA4C0B0", VA = "0x180A4CCB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTurnEvent other)
	{
	}

	[Token(Token = "0x6003F63")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003F64")]
	[Address(RVA = "0xA4D080", Offset = "0xA4C480", VA = "0x180A4D080", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
