using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000540")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapComplementaryInformationEvent : IMessage<MapComplementaryInformationEvent>, IMessage, IEquatable<MapComplementaryInformationEvent>, IDeepCloneable<MapComplementaryInformationEvent>, IBufferMessage
{
	[Token(Token = "0x2000541")]
	public enum SpecificComplementaryInformationOneofCase
	{
		[Token(Token = "0x40011FC")]
		None = 0,
		[Token(Token = "0x40011FD")]
		InHouseInformation = 10,
		[Token(Token = "0x40011FE")]
		Coordinates = 11,
		[Token(Token = "0x40011FF")]
		BreachInformation = 12,
		[Token(Token = "0x4001200")]
		AnomalyInformation = 13,
		[Token(Token = "0x4001201")]
		HavenBagInformation = 14
	}

	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapComplementaryInformationEvent> _parser;

	[Token(Token = "0x40011DB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40011DC")]
	public const int SubareaIdFieldNumber = 1;

	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x18")]
	private int subareaId_;

	[Token(Token = "0x40011DE")]
	public const int MapIdFieldNumber = 2;

	[Token(Token = "0x40011DF")]
	[FieldOffset(Offset = "0x20")]
	private long mapId_;

	[Token(Token = "0x40011E0")]
	public const int HousesFieldNumber = 3;

	[Token(Token = "0x40011E1")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> _repeated_houses_codec;

	[Token(Token = "0x40011E2")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> houses_;

	[Token(Token = "0x40011E3")]
	public const int ActorsFieldNumber = 4;

	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<ActorPositionInformation> _repeated_actors_codec;

	[Token(Token = "0x40011E5")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<ActorPositionInformation> actors_;

	[Token(Token = "0x40011E6")]
	public const int InteractiveElementsFieldNumber = 5;

	[Token(Token = "0x40011E7")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<InteractiveElement> _repeated_interactiveElements_codec;

	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<InteractiveElement> interactiveElements_;

	[Token(Token = "0x40011E9")]
	public const int StatedElementsFieldNumber = 6;

	[Token(Token = "0x40011EA")]
	[FieldOffset(Offset = "0x20")]
	private static readonly FieldCodec<StatedElement> _repeated_statedElements_codec;

	[Token(Token = "0x40011EB")]
	[FieldOffset(Offset = "0x40")]
	private readonly RepeatedField<StatedElement> statedElements_;

	[Token(Token = "0x40011EC")]
	public const int ObstaclesFieldNumber = 7;

	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x28")]
	private static readonly FieldCodec<MapObstacle> _repeated_obstacles_codec;

	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0x48")]
	private readonly RepeatedField<MapObstacle> obstacles_;

	[Token(Token = "0x40011EF")]
	public const int FightsFieldNumber = 8;

	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x30")]
	private static readonly FieldCodec<FightCommonInformation> _repeated_fights_codec;

	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x50")]
	private readonly RepeatedField<FightCommonInformation> fights_;

	[Token(Token = "0x40011F2")]
	public const int HasAggressiveMonstersFieldNumber = 9;

	[Token(Token = "0x40011F3")]
	[FieldOffset(Offset = "0x58")]
	private bool hasAggressiveMonsters_;

	[Token(Token = "0x40011F4")]
	public const int InHouseInformationFieldNumber = 10;

	[Token(Token = "0x40011F5")]
	public const int CoordinatesFieldNumber = 11;

	[Token(Token = "0x40011F6")]
	public const int BreachInformationFieldNumber = 12;

	[Token(Token = "0x40011F7")]
	public const int AnomalyInformationFieldNumber = 13;

	[Token(Token = "0x40011F8")]
	public const int HavenBagInformationFieldNumber = 14;

	[Token(Token = "0x40011F9")]
	[FieldOffset(Offset = "0x60")]
	private object specificComplementaryInformation_;

	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0x68")]
	private SpecificComplementaryInformationOneofCase specificComplementaryInformationCase_;

	[Token(Token = "0x17000BCB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapComplementaryInformationEvent> Parser
	{
		[Token(Token = "0x60037AF")]
		[Address(RVA = "0xA05E50", Offset = "0xA05250", VA = "0x180A05E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BCC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60037B0")]
		[Address(RVA = "0xA05CE0", Offset = "0xA050E0", VA = "0x180A05CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BCD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60037B1")]
		[Address(RVA = "0xA06930", Offset = "0xA05D30", VA = "0x180A06930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BCE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubareaId
	{
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000BCF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> Houses
	{
		[Token(Token = "0x60037B9")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BD1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ActorPositionInformation> Actors
	{
		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BD2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<InteractiveElement> InteractiveElements
	{
		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BD3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<StatedElement> StatedElements
	{
		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BD4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MapObstacle> Obstacles
	{
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BD5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FightCommonInformation> Fights
	{
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BD6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasAggressiveMonsters
	{
		[Token(Token = "0x60037BF")]
		[Address(RVA = "0x874E60", Offset = "0x874260", VA = "0x180874E60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x874F50", Offset = "0x874350", VA = "0x180874F50")]
		set
		{
		}
	}

	[Token(Token = "0x17000BD7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapComplementaryInHouseInformation InHouseInformation
	{
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0xA05DF0", Offset = "0xA051F0", VA = "0x180A05DF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60037C2")]
		[Address(RVA = "0xA06B10", Offset = "0xA05F10", VA = "0x180A06B10")]
		set
		{
		}
	}

	[Token(Token = "0x17000BD8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCoordinates Coordinates
	{
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0xA05C80", Offset = "0xA05080", VA = "0x180A05C80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0xA06A90", Offset = "0xA05E90", VA = "0x180A06A90")]
		set
		{
		}
	}

	[Token(Token = "0x17000BD9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapComplementaryBreachInformation BreachInformation
	{
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0xA05C20", Offset = "0xA05020", VA = "0x180A05C20")]
		get
		{
			return null;
		}
		[Token(Token = "0x60037C6")]
		[Address(RVA = "0xA06A50", Offset = "0xA05E50", VA = "0x180A06A50")]
		set
		{
		}
	}

	[Token(Token = "0x17000BDA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryAnomalyInformation AnomalyInformation
	{
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0xA05BC0", Offset = "0xA04FC0", VA = "0x180A05BC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0xA06A10", Offset = "0xA05E10", VA = "0x180A06A10")]
		set
		{
		}
	}

	[Token(Token = "0x17000BDB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryHavenBagInformation HavenBagInformation
	{
		[Token(Token = "0x60037C9")]
		[Address(RVA = "0xA05D90", Offset = "0xA05190", VA = "0x180A05D90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60037CA")]
		[Address(RVA = "0xA06AD0", Offset = "0xA05ED0", VA = "0x180A06AD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BDC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpecificComplementaryInformationOneofCase SpecificComplementaryInformationCase
	{
		[Token(Token = "0x60037CB")]
		[Address(RVA = "0x878BB0", Offset = "0x877FB0", VA = "0x180878BB0")]
		get
		{
			return default(SpecificComplementaryInformationOneofCase);
		}
	}

	[Token(Token = "0x60037B2")]
	[Address(RVA = "0xA059E0", Offset = "0xA04DE0", VA = "0x180A059E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryInformationEvent()
	{
	}

	[Token(Token = "0x60037B3")]
	[Address(RVA = "0xA05600", Offset = "0xA04A00", VA = "0x180A05600")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryInformationEvent(MapComplementaryInformationEvent other)
	{
	}

	[Token(Token = "0x60037B4")]
	[Address(RVA = "0xA044F0", Offset = "0xA038F0", VA = "0x180A044F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapComplementaryInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60037CC")]
	[Address(RVA = "0xA044D0", Offset = "0xA038D0", VA = "0x180A044D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearSpecificComplementaryInformation()
	{
	}

	[Token(Token = "0x60037CD")]
	[Address(RVA = "0xA04800", Offset = "0xA03C00", VA = "0x180A04800", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60037CE")]
	[Address(RVA = "0xA04550", Offset = "0xA03950", VA = "0x180A04550", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapComplementaryInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60037CF")]
	[Address(RVA = "0xA04860", Offset = "0xA03C60", VA = "0x180A04860", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60037D0")]
	[Address(RVA = "0xA050A0", Offset = "0xA044A0", VA = "0x180A050A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60037D1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60037D2")]
	[Address(RVA = "0xA064E0", Offset = "0xA058E0", VA = "0x180A064E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60037D3")]
	[Address(RVA = "0xA04050", Offset = "0xA03450", VA = "0x180A04050", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60037D4")]
	[Address(RVA = "0xA04C40", Offset = "0xA04040", VA = "0x180A04C40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapComplementaryInformationEvent other)
	{
	}

	[Token(Token = "0x60037D5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60037D6")]
	[Address(RVA = "0xA05EA0", Offset = "0xA052A0", VA = "0x180A05EA0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
