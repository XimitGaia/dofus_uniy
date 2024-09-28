using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x2000106")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RemoveSpellModifierEvent : IMessage<RemoveSpellModifierEvent>, IMessage, IEquatable<RemoveSpellModifierEvent>, IDeepCloneable<RemoveSpellModifierEvent>, IBufferMessage
{
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RemoveSpellModifierEvent> _parser;

	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000372")]
	public const int ActorIdFieldNumber = 1;

	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x18")]
	private long actorId_;

	[Token(Token = "0x4000374")]
	public const int ActionTypeFieldNumber = 2;

	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x20")]
	private SpellModifierActionType actionType_;

	[Token(Token = "0x4000376")]
	public const int ModifierTypeFieldNumber = 3;

	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x24")]
	private SpellModifierType modifierType_;

	[Token(Token = "0x4000378")]
	public const int SpellIdFieldNumber = 4;

	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x28")]
	private int spellId_;

	[Token(Token = "0x17000221")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RemoveSpellModifierEvent> Parser
	{
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xB6A3A0", Offset = "0xB697A0", VA = "0x180B6A3A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000222")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xB6A2F0", Offset = "0xB696F0", VA = "0x180B6A2F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000223")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xB6A5B0", Offset = "0xB699B0", VA = "0x180B6A5B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000224")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ActorId
	{
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000225")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellModifierActionType ActionType
	{
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(SpellModifierActionType);
		}
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000226")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellModifierType ModifierType
	{
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(SpellModifierType);
		}
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000227")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveSpellModifierEvent()
	{
	}

	[Token(Token = "0x6000A19")]
	[Address(RVA = "0xB6A290", Offset = "0xB69690", VA = "0x180B6A290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveSpellModifierEvent(RemoveSpellModifierEvent other)
	{
	}

	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0xB69E60", Offset = "0xB69260", VA = "0x180B69E60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveSpellModifierEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000A23")]
	[Address(RVA = "0xB69F40", Offset = "0xB69340", VA = "0x180B69F40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A24")]
	[Address(RVA = "0xB69EF0", Offset = "0xB692F0", VA = "0x180B69EF0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RemoveSpellModifierEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A25")]
	[Address(RVA = "0xB69FF0", Offset = "0xB693F0", VA = "0x180B69FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000A26")]
	[Address(RVA = "0xB6A130", Offset = "0xB69530", VA = "0x180B6A130", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000A28")]
	[Address(RVA = "0xB6A4F0", Offset = "0xB698F0", VA = "0x180B6A4F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000A29")]
	[Address(RVA = "0xB69D50", Offset = "0xB69150", VA = "0x180B69D50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0xB6A0C0", Offset = "0xB694C0", VA = "0x180B6A0C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(RemoveSpellModifierEvent other)
	{
	}

	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0xB6A3F0", Offset = "0xB697F0", VA = "0x180B6A3F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
