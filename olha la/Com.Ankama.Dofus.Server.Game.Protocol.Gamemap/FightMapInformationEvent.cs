using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000545")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightMapInformationEvent : IMessage<FightMapInformationEvent>, IMessage, IEquatable<FightMapInformationEvent>, IDeepCloneable<FightMapInformationEvent>, IBufferMessage
{
	[Token(Token = "0x2000546")]
	public enum SpecificComplementaryInformationOneofCase
	{
		[Token(Token = "0x4001215")]
		None = 0,
		[Token(Token = "0x4001216")]
		Coordinates = 3,
		[Token(Token = "0x4001217")]
		BreachInformation = 4,
		[Token(Token = "0x4001218")]
		AnomalyInformation = 5
	}

	[Token(Token = "0x4001209")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightMapInformationEvent> _parser;

	[Token(Token = "0x400120A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400120B")]
	public const int SubareaIdFieldNumber = 1;

	[Token(Token = "0x400120C")]
	[FieldOffset(Offset = "0x18")]
	private int subareaId_;

	[Token(Token = "0x400120D")]
	public const int MapIdFieldNumber = 2;

	[Token(Token = "0x400120E")]
	[FieldOffset(Offset = "0x20")]
	private long mapId_;

	[Token(Token = "0x400120F")]
	public const int CoordinatesFieldNumber = 3;

	[Token(Token = "0x4001210")]
	public const int BreachInformationFieldNumber = 4;

	[Token(Token = "0x4001211")]
	public const int AnomalyInformationFieldNumber = 5;

	[Token(Token = "0x4001212")]
	[FieldOffset(Offset = "0x28")]
	private object specificComplementaryInformation_;

	[Token(Token = "0x4001213")]
	[FieldOffset(Offset = "0x30")]
	private SpecificComplementaryInformationOneofCase specificComplementaryInformationCase_;

	[Token(Token = "0x17000BE1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightMapInformationEvent> Parser
	{
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x9FA040", Offset = "0x9F9440", VA = "0x1809FA040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BE2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x9F9F90", Offset = "0x9F9390", VA = "0x1809F9F90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BE3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x9FA4F0", Offset = "0x9F98F0", VA = "0x1809FA4F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BE4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SubareaId
	{
		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x60037F8")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60037F9")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCoordinates Coordinates
	{
		[Token(Token = "0x60037FA")]
		[Address(RVA = "0x9F9F30", Offset = "0x9F9330", VA = "0x1809F9F30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60037FB")]
		[Address(RVA = "0x91BB80", Offset = "0x91AF80", VA = "0x18091BB80")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapComplementaryBreachInformation BreachInformation
	{
		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x9F9ED0", Offset = "0x9F92D0", VA = "0x1809F9ED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x91BB40", Offset = "0x91AF40", VA = "0x18091BB40")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapComplementaryAnomalyInformation AnomalyInformation
	{
		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x9F9E70", Offset = "0x9F9270", VA = "0x1809F9E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x9FA5D0", Offset = "0x9F99D0", VA = "0x1809FA5D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpecificComplementaryInformationOneofCase SpecificComplementaryInformationCase
	{
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(SpecificComplementaryInformationOneofCase);
		}
	}

	[Token(Token = "0x60037F3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightMapInformationEvent()
	{
	}

	[Token(Token = "0x60037F4")]
	[Address(RVA = "0x9F9C30", Offset = "0x9F9030", VA = "0x1809F9C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightMapInformationEvent(FightMapInformationEvent other)
	{
	}

	[Token(Token = "0x60037F5")]
	[Address(RVA = "0x9F93F0", Offset = "0x9F87F0", VA = "0x1809F93F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightMapInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003801")]
	[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearSpecificComplementaryInformation()
	{
	}

	[Token(Token = "0x6003802")]
	[Address(RVA = "0x9F9560", Offset = "0x9F8960", VA = "0x1809F9560", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003803")]
	[Address(RVA = "0x9F9450", Offset = "0x9F8850", VA = "0x1809F9450", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightMapInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003804")]
	[Address(RVA = "0x9F96A0", Offset = "0x9F8AA0", VA = "0x1809F96A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003805")]
	[Address(RVA = "0x9F9AD0", Offset = "0x9F8ED0", VA = "0x1809F9AD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003806")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003807")]
	[Address(RVA = "0x9FA330", Offset = "0x9F9730", VA = "0x1809FA330", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003808")]
	[Address(RVA = "0x9F91E0", Offset = "0x9F85E0", VA = "0x1809F91E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003809")]
	[Address(RVA = "0x9F9880", Offset = "0x9F8C80", VA = "0x1809F9880", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightMapInformationEvent other)
	{
	}

	[Token(Token = "0x600380A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600380B")]
	[Address(RVA = "0x9FA090", Offset = "0x9F9490", VA = "0x1809FA090", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
