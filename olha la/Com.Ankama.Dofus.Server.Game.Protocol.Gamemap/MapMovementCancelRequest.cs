using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000518")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapMovementCancelRequest : IMessage<MapMovementCancelRequest>, IMessage, IEquatable<MapMovementCancelRequest>, IDeepCloneable<MapMovementCancelRequest>, IBufferMessage
{
	[Token(Token = "0x4001158")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapMovementCancelRequest> _parser;

	[Token(Token = "0x4001159")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400115A")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x400115B")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x17000B70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapMovementCancelRequest> Parser
	{
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0xA08F10", Offset = "0xA08310", VA = "0x180A08F10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B71")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0xA08E60", Offset = "0xA08260", VA = "0x180A08E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B72")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0xA08F60", Offset = "0xA08360", VA = "0x180A08F60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B73")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60035EC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementCancelRequest()
	{
	}

	[Token(Token = "0x60035ED")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapMovementCancelRequest(MapMovementCancelRequest other)
	{
	}

	[Token(Token = "0x60035EE")]
	[Address(RVA = "0xA08BF0", Offset = "0xA07FF0", VA = "0x180A08BF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapMovementCancelRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60035F1")]
	[Address(RVA = "0xA08C70", Offset = "0xA08070", VA = "0x180A08C70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60035F2")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapMovementCancelRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60035F3")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60035F4")]
	[Address(RVA = "0xA08D00", Offset = "0xA08100", VA = "0x180A08D00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60035F5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60035F6")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60035F7")]
	[Address(RVA = "0xA08B60", Offset = "0xA07F60", VA = "0x180A08B60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60035F8")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapMovementCancelRequest other)
	{
	}

	[Token(Token = "0x60035F9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60035FA")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
