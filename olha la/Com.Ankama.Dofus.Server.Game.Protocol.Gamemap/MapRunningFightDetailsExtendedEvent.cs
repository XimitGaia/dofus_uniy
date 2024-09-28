using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200053C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapRunningFightDetailsExtendedEvent : IMessage<MapRunningFightDetailsExtendedEvent>, IMessage, IEquatable<MapRunningFightDetailsExtendedEvent>, IDeepCloneable<MapRunningFightDetailsExtendedEvent>, IBufferMessage
{
	[Token(Token = "0x40011C6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapRunningFightDetailsExtendedEvent> _parser;

	[Token(Token = "0x40011C7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40011C8")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40011C9")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40011CA")]
	public const int AttackersFieldNumber = 2;

	[Token(Token = "0x40011CB")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FighterLightInformation> _repeated_attackers_codec;

	[Token(Token = "0x40011CC")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<FighterLightInformation> attackers_;

	[Token(Token = "0x40011CD")]
	public const int DefendersFieldNumber = 3;

	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<FighterLightInformation> _repeated_defenders_codec;

	[Token(Token = "0x40011CF")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<FighterLightInformation> defenders_;

	[Token(Token = "0x40011D0")]
	public const int NamedPartyTeamsFieldNumber = 4;

	[Token(Token = "0x40011D1")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<NamedPartyTeam> _repeated_namedPartyTeams_codec;

	[Token(Token = "0x40011D2")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<NamedPartyTeam> namedPartyTeams_;

	[Token(Token = "0x17000BC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapRunningFightDetailsExtendedEvent> Parser
	{
		[Token(Token = "0x6003781")]
		[Address(RVA = "0xA0D650", Offset = "0xA0CA50", VA = "0x180A0D650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BC1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003782")]
		[Address(RVA = "0xA0D5A0", Offset = "0xA0C9A0", VA = "0x180A0D5A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BC2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003783")]
		[Address(RVA = "0xA0D9D0", Offset = "0xA0CDD0", VA = "0x180A0D9D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BC3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FightId
	{
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000BC4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FighterLightInformation> Attackers
	{
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BC5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FighterLightInformation> Defenders
	{
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BC6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<NamedPartyTeam> NamedPartyTeams
	{
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003784")]
	[Address(RVA = "0xA0D4B0", Offset = "0xA0C8B0", VA = "0x180A0D4B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightDetailsExtendedEvent()
	{
	}

	[Token(Token = "0x6003785")]
	[Address(RVA = "0xA0D3C0", Offset = "0xA0C7C0", VA = "0x180A0D3C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapRunningFightDetailsExtendedEvent(MapRunningFightDetailsExtendedEvent other)
	{
	}

	[Token(Token = "0x6003786")]
	[Address(RVA = "0xA0CB90", Offset = "0xA0BF90", VA = "0x180A0CB90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightDetailsExtendedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600378C")]
	[Address(RVA = "0xA0CCB0", Offset = "0xA0C0B0", VA = "0x180A0CCB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600378D")]
	[Address(RVA = "0xA0CDE0", Offset = "0xA0C1E0", VA = "0x180A0CDE0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapRunningFightDetailsExtendedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600378E")]
	[Address(RVA = "0xA0CED0", Offset = "0xA0C2D0", VA = "0x180A0CED0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600378F")]
	[Address(RVA = "0xA0D090", Offset = "0xA0C490", VA = "0x180A0D090", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003790")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003791")]
	[Address(RVA = "0xA0D890", Offset = "0xA0CC90", VA = "0x180A0D890", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003792")]
	[Address(RVA = "0xA0CA40", Offset = "0xA0BE40", VA = "0x180A0CA40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003793")]
	[Address(RVA = "0xA0CFC0", Offset = "0xA0C3C0", VA = "0x180A0CFC0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MapRunningFightDetailsExtendedEvent other)
	{
	}

	[Token(Token = "0x6003794")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003795")]
	[Address(RVA = "0xA0D6A0", Offset = "0xA0CAA0", VA = "0x180A0D6A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
