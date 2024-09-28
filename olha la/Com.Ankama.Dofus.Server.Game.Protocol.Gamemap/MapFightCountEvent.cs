using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000536")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapFightCountEvent : IMessage<MapFightCountEvent>, IMessage, IEquatable<MapFightCountEvent>, IDeepCloneable<MapFightCountEvent>, IBufferMessage
{
	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapFightCountEvent> _parser;

	[Token(Token = "0x40011B1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40011B2")]
	public const int FightCountFieldNumber = 1;

	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x18")]
	private int fightCount_;

	[Token(Token = "0x17000BB2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapFightCountEvent> Parser
	{
		[Token(Token = "0x600373E")]
		[Address(RVA = "0xA08550", Offset = "0xA07950", VA = "0x180A08550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BB3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600373F")]
		[Address(RVA = "0xA084A0", Offset = "0xA078A0", VA = "0x180A084A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BB4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003740")]
		[Address(RVA = "0xA085A0", Offset = "0xA079A0", VA = "0x180A085A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BB5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightCount
	{
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003741")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapFightCountEvent()
	{
	}

	[Token(Token = "0x6003742")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapFightCountEvent(MapFightCountEvent other)
	{
	}

	[Token(Token = "0x6003743")]
	[Address(RVA = "0xA08230", Offset = "0xA07630", VA = "0x180A08230", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapFightCountEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003746")]
	[Address(RVA = "0xA082B0", Offset = "0xA076B0", VA = "0x180A082B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003747")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapFightCountEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003748")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003749")]
	[Address(RVA = "0xA08340", Offset = "0xA07740", VA = "0x180A08340", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600374A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600374B")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600374C")]
	[Address(RVA = "0xA081A0", Offset = "0xA075A0", VA = "0x180A081A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600374D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapFightCountEvent other)
	{
	}

	[Token(Token = "0x600374E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600374F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
