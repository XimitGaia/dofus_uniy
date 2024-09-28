using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000ABF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapExtendedCoordinates : IMessage<MapExtendedCoordinates>, IMessage, IEquatable<MapExtendedCoordinates>, IDeepCloneable<MapExtendedCoordinates>, IBufferMessage
{
	[Token(Token = "0x400274F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapExtendedCoordinates> _parser;

	[Token(Token = "0x4002750")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002751")]
	public const int WorldXFieldNumber = 1;

	[Token(Token = "0x4002752")]
	[FieldOffset(Offset = "0x18")]
	private int worldX_;

	[Token(Token = "0x4002753")]
	public const int WorldYFieldNumber = 2;

	[Token(Token = "0x4002754")]
	[FieldOffset(Offset = "0x1C")]
	private int worldY_;

	[Token(Token = "0x4002755")]
	public const int MapIdFieldNumber = 3;

	[Token(Token = "0x4002756")]
	[FieldOffset(Offset = "0x20")]
	private long mapId_;

	[Token(Token = "0x4002757")]
	public const int SubAreaIdFieldNumber = 4;

	[Token(Token = "0x4002758")]
	[FieldOffset(Offset = "0x28")]
	private int subAreaId_;

	[Token(Token = "0x17001888")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapExtendedCoordinates> Parser
	{
		[Token(Token = "0x600708A")]
		[Address(RVA = "0xBE3400", Offset = "0xBE2800", VA = "0x180BE3400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001889")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600708B")]
		[Address(RVA = "0xBE3350", Offset = "0xBE2750", VA = "0x180BE3350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700188A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600708C")]
		[Address(RVA = "0xBE3610", Offset = "0xBE2A10", VA = "0x180BE3610", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700188B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WorldX
	{
		[Token(Token = "0x6007090")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007091")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700188C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WorldY
	{
		[Token(Token = "0x6007092")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007093")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700188D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x6007094")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007095")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700188E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SubAreaId
	{
		[Token(Token = "0x6007096")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007097")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x600708D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapExtendedCoordinates()
	{
	}

	[Token(Token = "0x600708E")]
	[Address(RVA = "0xBE32F0", Offset = "0xBE26F0", VA = "0x180BE32F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapExtendedCoordinates(MapExtendedCoordinates other)
	{
	}

	[Token(Token = "0x600708F")]
	[Address(RVA = "0xBE2ED0", Offset = "0xBE22D0", VA = "0x180BE2ED0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapExtendedCoordinates Clone()
	{
		return null;
	}

	[Token(Token = "0x6007098")]
	[Address(RVA = "0xBE2F60", Offset = "0xBE2360", VA = "0x180BE2F60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007099")]
	[Address(RVA = "0xBE3010", Offset = "0xBE2410", VA = "0x180BE3010", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MapExtendedCoordinates other)
	{
		return default(bool);
	}

	[Token(Token = "0x600709A")]
	[Address(RVA = "0xBE3060", Offset = "0xBE2460", VA = "0x180BE3060", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600709B")]
	[Address(RVA = "0xBE3190", Offset = "0xBE2590", VA = "0x180BE3190", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600709C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600709D")]
	[Address(RVA = "0xBE3550", Offset = "0xBE2950", VA = "0x180BE3550", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600709E")]
	[Address(RVA = "0xBE2DC0", Offset = "0xBE21C0", VA = "0x180BE2DC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600709F")]
	[Address(RVA = "0xBE3120", Offset = "0xBE2520", VA = "0x180BE3120", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MapExtendedCoordinates other)
	{
	}

	[Token(Token = "0x60070A0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60070A1")]
	[Address(RVA = "0xBE3450", Offset = "0xBE2850", VA = "0x180BE3450", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
