using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000548")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapComplementaryInHouseInformation : IMessage<MapComplementaryInHouseInformation>, IMessage, IEquatable<MapComplementaryInHouseInformation>, IDeepCloneable<MapComplementaryInHouseInformation>, IBufferMessage
{
	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapComplementaryInHouseInformation> _parser;

	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400121C")]
	public const int CurrentHouseFieldNumber = 1;

	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.House currentHouse_;

	[Token(Token = "0x17000BEA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapComplementaryInHouseInformation> Parser
	{
		[Token(Token = "0x6003810")]
		[Address(RVA = "0xA03E20", Offset = "0xA03220", VA = "0x180A03E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BEB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003811")]
		[Address(RVA = "0xA03D70", Offset = "0xA03170", VA = "0x180A03D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BEC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003812")]
		[Address(RVA = "0xA03F70", Offset = "0xA03370", VA = "0x180A03F70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.House CurrentHouse
	{
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6003813")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryInHouseInformation()
	{
	}

	[Token(Token = "0x6003814")]
	[Address(RVA = "0x9F4300", Offset = "0x9F3700", VA = "0x1809F4300")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryInHouseInformation(MapComplementaryInHouseInformation other)
	{
	}

	[Token(Token = "0x6003815")]
	[Address(RVA = "0xA039F0", Offset = "0xA02DF0", VA = "0x180A039F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapComplementaryInHouseInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6003818")]
	[Address(RVA = "0xA03A90", Offset = "0xA02E90", VA = "0x180A03A90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003819")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapComplementaryInHouseInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600381A")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600381B")]
	[Address(RVA = "0xA03C10", Offset = "0xA03010", VA = "0x180A03C10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600381C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600381D")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600381E")]
	[Address(RVA = "0xA03960", Offset = "0xA02D60", VA = "0x180A03960", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600381F")]
	[Address(RVA = "0xA03B40", Offset = "0xA02F40", VA = "0x180A03B40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapComplementaryInHouseInformation other)
	{
	}

	[Token(Token = "0x6003820")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003821")]
	[Address(RVA = "0xA03E70", Offset = "0xA03270", VA = "0x180A03E70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
