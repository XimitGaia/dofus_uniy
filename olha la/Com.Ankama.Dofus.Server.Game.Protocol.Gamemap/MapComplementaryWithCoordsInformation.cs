using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200054A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapComplementaryWithCoordsInformation : IMessage<MapComplementaryWithCoordsInformation>, IMessage, IEquatable<MapComplementaryWithCoordsInformation>, IDeepCloneable<MapComplementaryWithCoordsInformation>, IBufferMessage
{
	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapComplementaryWithCoordsInformation> _parser;

	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001221")]
	public const int CoordinatesFieldNumber = 1;

	[Token(Token = "0x4001222")]
	[FieldOffset(Offset = "0x18")]
	private MapCoordinates coordinates_;

	[Token(Token = "0x17000BEE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapComplementaryWithCoordsInformation> Parser
	{
		[Token(Token = "0x6003826")]
		[Address(RVA = "0xA07080", Offset = "0xA06480", VA = "0x180A07080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BEF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003827")]
		[Address(RVA = "0xA06FD0", Offset = "0xA063D0", VA = "0x180A06FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003828")]
		[Address(RVA = "0xA071D0", Offset = "0xA065D0", VA = "0x180A071D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BF1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCoordinates Coordinates
	{
		[Token(Token = "0x600382C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6003829")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryWithCoordsInformation()
	{
	}

	[Token(Token = "0x600382A")]
	[Address(RVA = "0xA06F60", Offset = "0xA06360", VA = "0x180A06F60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapComplementaryWithCoordsInformation(MapComplementaryWithCoordsInformation other)
	{
	}

	[Token(Token = "0x600382B")]
	[Address(RVA = "0xA06BE0", Offset = "0xA05FE0", VA = "0x180A06BE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryWithCoordsInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600382E")]
	[Address(RVA = "0xA06C80", Offset = "0xA06080", VA = "0x180A06C80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600382F")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapComplementaryWithCoordsInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003830")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003831")]
	[Address(RVA = "0xA06E00", Offset = "0xA06200", VA = "0x180A06E00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003832")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003833")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003834")]
	[Address(RVA = "0xA06B50", Offset = "0xA05F50", VA = "0x180A06B50", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003835")]
	[Address(RVA = "0xA06D30", Offset = "0xA06130", VA = "0x180A06D30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapComplementaryWithCoordsInformation other)
	{
	}

	[Token(Token = "0x6003836")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003837")]
	[Address(RVA = "0xA070D0", Offset = "0xA064D0", VA = "0x180A070D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
