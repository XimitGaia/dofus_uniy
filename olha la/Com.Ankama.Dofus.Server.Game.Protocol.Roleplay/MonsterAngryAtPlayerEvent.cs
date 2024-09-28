using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000174")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonsterAngryAtPlayerEvent : IMessage<MonsterAngryAtPlayerEvent>, IMessage, IEquatable<MonsterAngryAtPlayerEvent>, IDeepCloneable<MonsterAngryAtPlayerEvent>, IBufferMessage
{
	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MonsterAngryAtPlayerEvent> _parser;

	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004EF")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x40004F1")]
	public const int MonsterGroupIdFieldNumber = 2;

	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x20")]
	private long monsterGroupId_;

	[Token(Token = "0x40004F3")]
	public const int AngryStartTimeFieldNumber = 3;

	[Token(Token = "0x40004F4")]
	[FieldOffset(Offset = "0x28")]
	private long angryStartTime_;

	[Token(Token = "0x40004F5")]
	public const int AttackTimeFieldNumber = 4;

	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0x30")]
	private long attackTime_;

	[Token(Token = "0x1700031A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MonsterAngryAtPlayerEvent> Parser
	{
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0xC46B80", Offset = "0xC45F80", VA = "0x180C46B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700031B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0xC46AD0", Offset = "0xC45ED0", VA = "0x180C46AD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700031C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0xC46D90", Offset = "0xC46190", VA = "0x180C46D90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700031D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700031E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MonsterGroupId
	{
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700031F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AngryStartTime
	{
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000320")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AttackTime
	{
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterAngryAtPlayerEvent()
	{
	}

	[Token(Token = "0x6000E87")]
	[Address(RVA = "0xC46A60", Offset = "0xC45E60", VA = "0x180C46A60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterAngryAtPlayerEvent(MonsterAngryAtPlayerEvent other)
	{
	}

	[Token(Token = "0x6000E88")]
	[Address(RVA = "0xC46610", Offset = "0xC45A10", VA = "0x180C46610", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterAngryAtPlayerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000E91")]
	[Address(RVA = "0xC466B0", Offset = "0xC45AB0", VA = "0x180C466B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E92")]
	[Address(RVA = "0xC46760", Offset = "0xC45B60", VA = "0x180C46760", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MonsterAngryAtPlayerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E93")]
	[Address(RVA = "0xC467B0", Offset = "0xC45BB0", VA = "0x180C467B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000E94")]
	[Address(RVA = "0xC46900", Offset = "0xC45D00", VA = "0x180C46900", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000E96")]
	[Address(RVA = "0xC46CD0", Offset = "0xC460D0", VA = "0x180C46CD0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000E97")]
	[Address(RVA = "0xC464F0", Offset = "0xC458F0", VA = "0x180C464F0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000E98")]
	[Address(RVA = "0xC46880", Offset = "0xC45C80", VA = "0x180C46880", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MonsterAngryAtPlayerEvent other)
	{
	}

	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0xC46BD0", Offset = "0xC45FD0", VA = "0x180C46BD0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
