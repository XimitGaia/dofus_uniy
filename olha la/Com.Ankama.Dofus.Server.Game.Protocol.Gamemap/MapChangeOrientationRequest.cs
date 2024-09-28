using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200051C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapChangeOrientationRequest : IMessage<MapChangeOrientationRequest>, IMessage, IEquatable<MapChangeOrientationRequest>, IDeepCloneable<MapChangeOrientationRequest>, IBufferMessage
{
	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapChangeOrientationRequest> _parser;

	[Token(Token = "0x4001161")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001162")]
	public const int DirectionFieldNumber = 1;

	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x18")]
	private Direction direction_;

	[Token(Token = "0x17000B77")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapChangeOrientationRequest> Parser
	{
		[Token(Token = "0x6003613")]
		[Address(RVA = "0xA020D0", Offset = "0xA014D0", VA = "0x180A020D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B78")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003614")]
		[Address(RVA = "0xA02020", Offset = "0xA01420", VA = "0x180A02020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B79")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003615")]
		[Address(RVA = "0xA02120", Offset = "0xA01520", VA = "0x180A02120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B7A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Direction Direction
	{
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Direction);
		}
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003616")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapChangeOrientationRequest()
	{
	}

	[Token(Token = "0x6003617")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapChangeOrientationRequest(MapChangeOrientationRequest other)
	{
	}

	[Token(Token = "0x6003618")]
	[Address(RVA = "0xA01DB0", Offset = "0xA011B0", VA = "0x180A01DB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapChangeOrientationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600361B")]
	[Address(RVA = "0xA01E30", Offset = "0xA01230", VA = "0x180A01E30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600361C")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapChangeOrientationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600361D")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600361E")]
	[Address(RVA = "0xA01EC0", Offset = "0xA012C0", VA = "0x180A01EC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600361F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003620")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003621")]
	[Address(RVA = "0xA01D20", Offset = "0xA01120", VA = "0x180A01D20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003622")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapChangeOrientationRequest other)
	{
	}

	[Token(Token = "0x6003623")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003624")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
