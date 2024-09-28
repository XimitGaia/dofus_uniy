using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000621")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightStartingEvent : IMessage<FightStartingEvent>, IMessage, IEquatable<FightStartingEvent>, IDeepCloneable<FightStartingEvent>, IBufferMessage
{
	[Token(Token = "0x4001585")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightStartingEvent> _parser;

	[Token(Token = "0x4001586")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001587")]
	public const int FightTypeFieldNumber = 1;

	[Token(Token = "0x4001588")]
	[FieldOffset(Offset = "0x18")]
	private FightType fightType_;

	[Token(Token = "0x4001589")]
	public const int FightIdFieldNumber = 2;

	[Token(Token = "0x400158A")]
	[FieldOffset(Offset = "0x1C")]
	private int fightId_;

	[Token(Token = "0x400158B")]
	public const int AttackerIdFieldNumber = 3;

	[Token(Token = "0x400158C")]
	[FieldOffset(Offset = "0x20")]
	private long attackerId_;

	[Token(Token = "0x400158D")]
	public const int DefenderIdFieldNumber = 4;

	[Token(Token = "0x400158E")]
	[FieldOffset(Offset = "0x28")]
	private long defenderId_;

	[Token(Token = "0x400158F")]
	public const int ContainBossFieldNumber = 5;

	[Token(Token = "0x4001590")]
	[FieldOffset(Offset = "0x30")]
	private bool containBoss_;

	[Token(Token = "0x4001591")]
	public const int MonstersFieldNumber = 6;

	[Token(Token = "0x4001592")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_monsters_codec;

	[Token(Token = "0x4001593")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<int> monsters_;

	[Token(Token = "0x17000E0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightStartingEvent> Parser
	{
		[Token(Token = "0x6004183")]
		[Address(RVA = "0xA84090", Offset = "0xA83490", VA = "0x180A84090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004184")]
		[Address(RVA = "0xA83FE0", Offset = "0xA833E0", VA = "0x180A83FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004185")]
		[Address(RVA = "0xA84400", Offset = "0xA83800", VA = "0x180A84400", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightType FightType
	{
		[Token(Token = "0x6004189")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(FightType);
		}
		[Token(Token = "0x600418A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E13")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x600418B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000E14")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AttackerId
	{
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000E15")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long DefenderId
	{
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004190")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000E16")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool ContainBoss
	{
		[Token(Token = "0x6004191")]
		[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004192")]
		[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000E17")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Monsters
	{
		[Token(Token = "0x6004193")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004186")]
	[Address(RVA = "0xA83EB0", Offset = "0xA832B0", VA = "0x180A83EB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightStartingEvent()
	{
	}

	[Token(Token = "0x6004187")]
	[Address(RVA = "0xA83F30", Offset = "0xA83330", VA = "0x180A83F30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStartingEvent(FightStartingEvent other)
	{
	}

	[Token(Token = "0x6004188")]
	[Address(RVA = "0xA83880", Offset = "0xA82C80", VA = "0x180A83880", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightStartingEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004194")]
	[Address(RVA = "0xA83960", Offset = "0xA82D60", VA = "0x180A83960", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004195")]
	[Address(RVA = "0xA83A70", Offset = "0xA82E70", VA = "0x180A83A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightStartingEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004196")]
	[Address(RVA = "0xA83B30", Offset = "0xA82F30", VA = "0x180A83B30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004197")]
	[Address(RVA = "0xA83D20", Offset = "0xA83120", VA = "0x180A83D20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004198")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004199")]
	[Address(RVA = "0xA842A0", Offset = "0xA836A0", VA = "0x180A842A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600419A")]
	[Address(RVA = "0xA83710", Offset = "0xA82B10", VA = "0x180A83710", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600419B")]
	[Address(RVA = "0xA83C60", Offset = "0xA83060", VA = "0x180A83C60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightStartingEvent other)
	{
	}

	[Token(Token = "0x600419C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600419D")]
	[Address(RVA = "0xA840E0", Offset = "0xA834E0", VA = "0x180A840E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
