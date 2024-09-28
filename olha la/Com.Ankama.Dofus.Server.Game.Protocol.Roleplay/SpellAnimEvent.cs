using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x200017C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellAnimEvent : IMessage<SpellAnimEvent>, IMessage, IEquatable<SpellAnimEvent>, IDeepCloneable<SpellAnimEvent>, IBufferMessage
{
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellAnimEvent> _parser;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400050B")]
	public const int CasterIdFieldNumber = 1;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x18")]
	private long casterId_;

	[Token(Token = "0x400050D")]
	public const int TargetCellIdFieldNumber = 2;

	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x20")]
	private int targetCellId_;

	[Token(Token = "0x400050F")]
	public const int SpellIdFieldNumber = 3;

	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x24")]
	private int spellId_;

	[Token(Token = "0x4000511")]
	public const int SpellLevelFieldNumber = 4;

	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x28")]
	private int spellLevel_;

	[Token(Token = "0x4000513")]
	public const int DirectionFieldNumber = 5;

	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x2C")]
	private Direction direction_;

	[Token(Token = "0x1700032E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SpellAnimEvent> Parser
	{
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0xC554B0", Offset = "0xC548B0", VA = "0x180C554B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700032F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0xC55400", Offset = "0xC54800", VA = "0x180C55400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000330")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0xC556F0", Offset = "0xC54AF0", VA = "0x180C556F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000331")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CasterId
	{
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000332")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TargetCellId
	{
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000333")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000334")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpellLevel
	{
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000335")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Direction Direction
	{
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(Direction);
		}
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellAnimEvent()
	{
	}

	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0xC55390", Offset = "0xC54790", VA = "0x180C55390")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellAnimEvent(SpellAnimEvent other)
	{
	}

	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0xC54F30", Offset = "0xC54330", VA = "0x180C54F30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellAnimEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0xC55020", Offset = "0xC54420", VA = "0x180C55020", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0xC54FD0", Offset = "0xC543D0", VA = "0x180C54FD0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpellAnimEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0xC550D0", Offset = "0xC544D0", VA = "0x180C550D0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0xC55230", Offset = "0xC54630", VA = "0x180C55230", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0xC55610", Offset = "0xC54A10", VA = "0x180C55610", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0xC54DF0", Offset = "0xC541F0", VA = "0x180C54DF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0xC551B0", Offset = "0xC545B0", VA = "0x180C551B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpellAnimEvent other)
	{
	}

	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0xC55500", Offset = "0xC54900", VA = "0x180C55500", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
