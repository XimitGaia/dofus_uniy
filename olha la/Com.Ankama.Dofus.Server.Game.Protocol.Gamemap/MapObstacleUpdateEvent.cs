using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200053E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapObstacleUpdateEvent : IMessage<MapObstacleUpdateEvent>, IMessage, IEquatable<MapObstacleUpdateEvent>, IDeepCloneable<MapObstacleUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapObstacleUpdateEvent> _parser;

	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40011D6")]
	public const int ObstaclesFieldNumber = 1;

	[Token(Token = "0x40011D7")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<MapObstacle> _repeated_obstacles_codec;

	[Token(Token = "0x40011D8")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<MapObstacle> obstacles_;

	[Token(Token = "0x17000BC7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapObstacleUpdateEvent> Parser
	{
		[Token(Token = "0x600379A")]
		[Address(RVA = "0xA0BAB0", Offset = "0xA0AEB0", VA = "0x180A0BAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BC8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600379B")]
		[Address(RVA = "0xA0BA00", Offset = "0xA0AE00", VA = "0x180A0BA00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BC9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600379C")]
		[Address(RVA = "0xA0BCC0", Offset = "0xA0B0C0", VA = "0x180A0BCC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BCA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MapObstacle> Obstacles
	{
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600379D")]
	[Address(RVA = "0xA0B980", Offset = "0xA0AD80", VA = "0x180A0B980")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapObstacleUpdateEvent()
	{
	}

	[Token(Token = "0x600379E")]
	[Address(RVA = "0xA0B8F0", Offset = "0xA0ACF0", VA = "0x180A0B8F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapObstacleUpdateEvent(MapObstacleUpdateEvent other)
	{
	}

	[Token(Token = "0x600379F")]
	[Address(RVA = "0xA0B440", Offset = "0xA0A840", VA = "0x180A0B440", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapObstacleUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60037A1")]
	[Address(RVA = "0xA0B590", Offset = "0xA0A990", VA = "0x180A0B590", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60037A2")]
	[Address(RVA = "0xA0B500", Offset = "0xA0A900", VA = "0x180A0B500", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapObstacleUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60037A3")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60037A4")]
	[Address(RVA = "0xA0B6F0", Offset = "0xA0AAF0", VA = "0x180A0B6F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60037A5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60037A6")]
	[Address(RVA = "0xA0BC10", Offset = "0xA0B010", VA = "0x180A0BC10", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60037A7")]
	[Address(RVA = "0xA0B3A0", Offset = "0xA0A7A0", VA = "0x180A0B3A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60037A8")]
	[Address(RVA = "0xA0B670", Offset = "0xA0AA70", VA = "0x180A0B670", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapObstacleUpdateEvent other)
	{
	}

	[Token(Token = "0x60037A9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60037AA")]
	[Address(RVA = "0xA0BB00", Offset = "0xA0AF00", VA = "0x180A0BB00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
