using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000532")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapCurrentInstanceEvent : IMessage<MapCurrentInstanceEvent>, IMessage, IEquatable<MapCurrentInstanceEvent>, IDeepCloneable<MapCurrentInstanceEvent>, IBufferMessage
{
	[Token(Token = "0x40011A2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapCurrentInstanceEvent> _parser;

	[Token(Token = "0x40011A3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40011A4")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x40011A5")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x40011A6")]
	public const int InstantiateMapIdFieldNumber = 2;

	[Token(Token = "0x40011A7")]
	[FieldOffset(Offset = "0x20")]
	private long instantiateMapId_;

	[Token(Token = "0x17000BA8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapCurrentInstanceEvent> Parser
	{
		[Token(Token = "0x600370E")]
		[Address(RVA = "0xA07B90", Offset = "0xA06F90", VA = "0x180A07B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BA9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600370F")]
		[Address(RVA = "0xA07AE0", Offset = "0xA06EE0", VA = "0x180A07AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BAA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003710")]
		[Address(RVA = "0xA07BE0", Offset = "0xA06FE0", VA = "0x180A07BE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BAB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000BAC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long InstantiateMapId
	{
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6003711")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCurrentInstanceEvent()
	{
	}

	[Token(Token = "0x6003712")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCurrentInstanceEvent(MapCurrentInstanceEvent other)
	{
	}

	[Token(Token = "0x6003713")]
	[Address(RVA = "0xA07850", Offset = "0xA06C50", VA = "0x180A07850", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapCurrentInstanceEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003718")]
	[Address(RVA = "0xA078E0", Offset = "0xA06CE0", VA = "0x180A078E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003719")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapCurrentInstanceEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600371A")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600371B")]
	[Address(RVA = "0xA07980", Offset = "0xA06D80", VA = "0x180A07980", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600371C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600371D")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600371E")]
	[Address(RVA = "0xA07790", Offset = "0xA06B90", VA = "0x180A07790", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600371F")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MapCurrentInstanceEvent other)
	{
	}

	[Token(Token = "0x6003720")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003721")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
