using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A76")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NamedPartyTeamWithOutcome : IMessage<NamedPartyTeamWithOutcome>, IMessage, IEquatable<NamedPartyTeamWithOutcome>, IDeepCloneable<NamedPartyTeamWithOutcome>, IBufferMessage
{
	[Token(Token = "0x40025EE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NamedPartyTeamWithOutcome> _parser;

	[Token(Token = "0x40025EF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40025F0")]
	public const int TeamFieldNumber = 1;

	[Token(Token = "0x40025F1")]
	[FieldOffset(Offset = "0x18")]
	private NamedPartyTeam team_;

	[Token(Token = "0x40025F2")]
	public const int OutcomeFieldNumber = 2;

	[Token(Token = "0x40025F3")]
	[FieldOffset(Offset = "0x20")]
	private FightOutcome outcome_;

	[Token(Token = "0x170017BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NamedPartyTeamWithOutcome> Parser
	{
		[Token(Token = "0x6006D5F")]
		[Address(RVA = "0xBD6E90", Offset = "0xBD6290", VA = "0x180BD6E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006D60")]
		[Address(RVA = "0xBD6DE0", Offset = "0xBD61E0", VA = "0x180BD6DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006D61")]
		[Address(RVA = "0xBD7000", Offset = "0xBD6400", VA = "0x180BD7000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017BD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NamedPartyTeam Team
	{
		[Token(Token = "0x6006D65")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006D66")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x170017BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightOutcome Outcome
	{
		[Token(Token = "0x6006D67")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(FightOutcome);
		}
		[Token(Token = "0x6006D68")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6006D62")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NamedPartyTeamWithOutcome()
	{
	}

	[Token(Token = "0x6006D63")]
	[Address(RVA = "0xBD6D60", Offset = "0xBD6160", VA = "0x180BD6D60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NamedPartyTeamWithOutcome(NamedPartyTeamWithOutcome other)
	{
	}

	[Token(Token = "0x6006D64")]
	[Address(RVA = "0xBD69D0", Offset = "0xBD5DD0", VA = "0x180BD69D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NamedPartyTeamWithOutcome Clone()
	{
		return null;
	}

	[Token(Token = "0x6006D69")]
	[Address(RVA = "0xBD6A80", Offset = "0xBD5E80", VA = "0x180BD6A80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D6A")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(NamedPartyTeamWithOutcome other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D6B")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006D6C")]
	[Address(RVA = "0xBD6C00", Offset = "0xBD6000", VA = "0x180BD6C00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006D6D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006D6E")]
	[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006D6F")]
	[Address(RVA = "0xBD6910", Offset = "0xBD5D10", VA = "0x180BD6910", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006D70")]
	[Address(RVA = "0xBD6B30", Offset = "0xBD5F30", VA = "0x180BD6B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NamedPartyTeamWithOutcome other)
	{
	}

	[Token(Token = "0x6006D71")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006D72")]
	[Address(RVA = "0xBD6EE0", Offset = "0xBD62E0", VA = "0x180BD6EE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
