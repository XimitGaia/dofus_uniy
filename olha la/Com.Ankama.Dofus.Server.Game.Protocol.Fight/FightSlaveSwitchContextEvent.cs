using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005FA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightSlaveSwitchContextEvent : IMessage<FightSlaveSwitchContextEvent>, IMessage, IEquatable<FightSlaveSwitchContextEvent>, IDeepCloneable<FightSlaveSwitchContextEvent>, IBufferMessage
{
	[Token(Token = "0x40014EC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightSlaveSwitchContextEvent> _parser;

	[Token(Token = "0x40014ED")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014EE")]
	public const int MasterIdFieldNumber = 1;

	[Token(Token = "0x40014EF")]
	[FieldOffset(Offset = "0x18")]
	private long masterId_;

	[Token(Token = "0x40014F0")]
	public const int SlaveIdFieldNumber = 2;

	[Token(Token = "0x40014F1")]
	[FieldOffset(Offset = "0x20")]
	private long slaveId_;

	[Token(Token = "0x40014F2")]
	public const int SlaveTurnFieldNumber = 3;

	[Token(Token = "0x40014F3")]
	[FieldOffset(Offset = "0x28")]
	private int slaveTurn_;

	[Token(Token = "0x40014F4")]
	public const int SlaveSpellsFieldNumber = 4;

	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<SpellItem> _repeated_slaveSpells_codec;

	[Token(Token = "0x40014F6")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<SpellItem> slaveSpells_;

	[Token(Token = "0x40014F7")]
	public const int SlaveStatsFieldNumber = 5;

	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x38")]
	private CharacterCharacteristics slaveStats_;

	[Token(Token = "0x40014F9")]
	public const int ShortcutsFieldNumber = 6;

	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<Shortcut> _repeated_shortcuts_codec;

	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<Shortcut> shortcuts_;

	[Token(Token = "0x17000DB6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightSlaveSwitchContextEvent> Parser
	{
		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0xA4A960", Offset = "0xA49D60", VA = "0x180A4A960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DB7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0xA4A8B0", Offset = "0xA49CB0", VA = "0x180A4A8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DB8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003FDC")]
		[Address(RVA = "0xA4AD70", Offset = "0xA4A170", VA = "0x180A4AD70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DB9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MasterId
	{
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003FE1")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000DBA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long SlaveId
	{
		[Token(Token = "0x6003FE2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000DBB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SlaveTurn
	{
		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000DBC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<SpellItem> SlaveSpells
	{
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DBD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristics SlaveStats
	{
		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000DBE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Shortcut> Shortcuts
	{
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FDD")]
	[Address(RVA = "0xA4A6F0", Offset = "0xA49AF0", VA = "0x180A4A6F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightSlaveSwitchContextEvent()
	{
	}

	[Token(Token = "0x6003FDE")]
	[Address(RVA = "0xA4A7B0", Offset = "0xA49BB0", VA = "0x180A4A7B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSlaveSwitchContextEvent(FightSlaveSwitchContextEvent other)
	{
	}

	[Token(Token = "0x6003FDF")]
	[Address(RVA = "0xA49E80", Offset = "0xA49280", VA = "0x180A49E80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSlaveSwitchContextEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003FEA")]
	[Address(RVA = "0xA4A0B0", Offset = "0xA494B0", VA = "0x180A4A0B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003FEB")]
	[Address(RVA = "0xA49FB0", Offset = "0xA493B0", VA = "0x180A49FB0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightSlaveSwitchContextEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003FEC")]
	[Address(RVA = "0xA4A200", Offset = "0xA49600", VA = "0x180A4A200", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003FED")]
	[Address(RVA = "0xA4A440", Offset = "0xA49840", VA = "0x180A4A440", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003FEE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003FEF")]
	[Address(RVA = "0xA4ABE0", Offset = "0xA49FE0", VA = "0x180A4ABE0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003FF0")]
	[Address(RVA = "0xA49CC0", Offset = "0xA490C0", VA = "0x180A49CC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003FF1")]
	[Address(RVA = "0xA4A300", Offset = "0xA49700", VA = "0x180A4A300", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightSlaveSwitchContextEvent other)
	{
	}

	[Token(Token = "0x6003FF2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003FF3")]
	[Address(RVA = "0xA4A9B0", Offset = "0xA49DB0", VA = "0x180A4A9B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
