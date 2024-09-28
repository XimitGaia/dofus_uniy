using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000534")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapTeleportOnSameEvent : IMessage<MapTeleportOnSameEvent>, IMessage, IEquatable<MapTeleportOnSameEvent>, IDeepCloneable<MapTeleportOnSameEvent>, IBufferMessage
{
	[Token(Token = "0x40011A9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapTeleportOnSameEvent> _parser;

	[Token(Token = "0x40011AA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40011AB")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x40011AC")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x40011AD")]
	public const int CellIdFieldNumber = 2;

	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x20")]
	private int cellId_;

	[Token(Token = "0x17000BAD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapTeleportOnSameEvent> Parser
	{
		[Token(Token = "0x6003726")]
		[Address(RVA = "0xA0F610", Offset = "0xA0EA10", VA = "0x180A0F610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BAE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003727")]
		[Address(RVA = "0xA0F560", Offset = "0xA0E960", VA = "0x180A0F560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BAF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003728")]
		[Address(RVA = "0xA0F660", Offset = "0xA0EA60", VA = "0x180A0F660", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000BB1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CellId
	{
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6003729")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapTeleportOnSameEvent()
	{
	}

	[Token(Token = "0x600372A")]
	[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapTeleportOnSameEvent(MapTeleportOnSameEvent other)
	{
	}

	[Token(Token = "0x600372B")]
	[Address(RVA = "0xA0F2D0", Offset = "0xA0E6D0", VA = "0x180A0F2D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapTeleportOnSameEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003730")]
	[Address(RVA = "0xA0F360", Offset = "0xA0E760", VA = "0x180A0F360", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003731")]
	[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapTeleportOnSameEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003732")]
	[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003733")]
	[Address(RVA = "0xA0F400", Offset = "0xA0E800", VA = "0x180A0F400", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003734")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003735")]
	[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003736")]
	[Address(RVA = "0xA0F210", Offset = "0xA0E610", VA = "0x180A0F210", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003737")]
	[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapTeleportOnSameEvent other)
	{
	}

	[Token(Token = "0x6003738")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003739")]
	[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
