using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000625")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightSpectatorJoinEvent : IMessage<FightSpectatorJoinEvent>, IMessage, IEquatable<FightSpectatorJoinEvent>, IDeepCloneable<FightSpectatorJoinEvent>, IBufferMessage
{
	[Token(Token = "0x40015A4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightSpectatorJoinEvent> _parser;

	[Token(Token = "0x40015A5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015A6")]
	public const int FightJoinEventFieldNumber = 1;

	[Token(Token = "0x40015A7")]
	[FieldOffset(Offset = "0x18")]
	private FightJoinEvent fightJoinEvent_;

	[Token(Token = "0x40015A8")]
	public const int NamedPartyTeamsFieldNumber = 2;

	[Token(Token = "0x40015A9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<NamedPartyTeam> _repeated_namedPartyTeams_codec;

	[Token(Token = "0x40015AA")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<NamedPartyTeam> namedPartyTeams_;

	[Token(Token = "0x17000E21")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightSpectatorJoinEvent> Parser
	{
		[Token(Token = "0x60041C2")]
		[Address(RVA = "0xA82F60", Offset = "0xA82360", VA = "0x180A82F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E22")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60041C3")]
		[Address(RVA = "0xA82EB0", Offset = "0xA822B0", VA = "0x180A82EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E23")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60041C4")]
		[Address(RVA = "0xA831F0", Offset = "0xA825F0", VA = "0x180A831F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E24")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinEvent FightJoinEvent
	{
		[Token(Token = "0x60041C8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60041C9")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000E25")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NamedPartyTeam> NamedPartyTeams
	{
		[Token(Token = "0x60041CA")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041C5")]
	[Address(RVA = "0xA82CF0", Offset = "0xA820F0", VA = "0x180A82CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSpectatorJoinEvent()
	{
	}

	[Token(Token = "0x60041C6")]
	[Address(RVA = "0xA82D70", Offset = "0xA82170", VA = "0x180A82D70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSpectatorJoinEvent(FightSpectatorJoinEvent other)
	{
	}

	[Token(Token = "0x60041C7")]
	[Address(RVA = "0xA825F0", Offset = "0xA819F0", VA = "0x180A825F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSpectatorJoinEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60041CB")]
	[Address(RVA = "0xA82810", Offset = "0xA81C10", VA = "0x180A82810", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60041CC")]
	[Address(RVA = "0xA82760", Offset = "0xA81B60", VA = "0x180A82760", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightSpectatorJoinEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60041CD")]
	[Address(RVA = "0xA82900", Offset = "0xA81D00", VA = "0x180A82900", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60041CE")]
	[Address(RVA = "0xA82AF0", Offset = "0xA81EF0", VA = "0x180A82AF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60041CF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60041D0")]
	[Address(RVA = "0xA83120", Offset = "0xA82520", VA = "0x180A83120", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60041D1")]
	[Address(RVA = "0xA82510", Offset = "0xA81910", VA = "0x180A82510", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60041D2")]
	[Address(RVA = "0xA82990", Offset = "0xA81D90", VA = "0x180A82990", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightSpectatorJoinEvent other)
	{
	}

	[Token(Token = "0x60041D3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60041D4")]
	[Address(RVA = "0xA82FB0", Offset = "0xA823B0", VA = "0x180A82FB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
