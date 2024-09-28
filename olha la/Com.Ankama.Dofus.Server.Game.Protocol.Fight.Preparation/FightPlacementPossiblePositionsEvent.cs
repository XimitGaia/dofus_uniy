using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000627")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPlacementPossiblePositionsEvent : IMessage<FightPlacementPossiblePositionsEvent>, IMessage, IEquatable<FightPlacementPossiblePositionsEvent>, IDeepCloneable<FightPlacementPossiblePositionsEvent>, IBufferMessage
{
	[Token(Token = "0x40015AC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPlacementPossiblePositionsEvent> _parser;

	[Token(Token = "0x40015AD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015AE")]
	public const int StartingPositionsFieldNumber = 1;

	[Token(Token = "0x40015AF")]
	[FieldOffset(Offset = "0x18")]
	private FightStartingPositions startingPositions_;

	[Token(Token = "0x40015B0")]
	public const int TeamFieldNumber = 2;

	[Token(Token = "0x40015B1")]
	[FieldOffset(Offset = "0x20")]
	private Team team_;

	[Token(Token = "0x17000E26")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightPlacementPossiblePositionsEvent> Parser
	{
		[Token(Token = "0x60041D9")]
		[Address(RVA = "0xA7F1D0", Offset = "0xA7E5D0", VA = "0x180A7F1D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E27")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60041DA")]
		[Address(RVA = "0xA7F120", Offset = "0xA7E520", VA = "0x180A7F120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E28")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0xA7F340", Offset = "0xA7E740", VA = "0x180A7F340", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E29")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightStartingPositions StartingPositions
	{
		[Token(Token = "0x60041DF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041E0")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000E2A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Team Team
	{
		[Token(Token = "0x60041E1")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x60041E2")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60041DC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementPossiblePositionsEvent()
	{
	}

	[Token(Token = "0x60041DD")]
	[Address(RVA = "0xA7F0A0", Offset = "0xA7E4A0", VA = "0x180A7F0A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementPossiblePositionsEvent(FightPlacementPossiblePositionsEvent other)
	{
	}

	[Token(Token = "0x60041DE")]
	[Address(RVA = "0xA7ED10", Offset = "0xA7E110", VA = "0x180A7ED10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementPossiblePositionsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60041E3")]
	[Address(RVA = "0xA7EDC0", Offset = "0xA7E1C0", VA = "0x180A7EDC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60041E4")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightPlacementPossiblePositionsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60041E5")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60041E6")]
	[Address(RVA = "0xA7EF40", Offset = "0xA7E340", VA = "0x180A7EF40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60041E7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60041E8")]
	[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60041E9")]
	[Address(RVA = "0xA7EC50", Offset = "0xA7E050", VA = "0x180A7EC50", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60041EA")]
	[Address(RVA = "0xA7EE70", Offset = "0xA7E270", VA = "0x180A7EE70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightPlacementPossiblePositionsEvent other)
	{
	}

	[Token(Token = "0x60041EB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60041EC")]
	[Address(RVA = "0xA7F220", Offset = "0xA7E620", VA = "0x180A7F220", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
