using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000789")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShowCellRequest : IMessage<ShowCellRequest>, IMessage, IEquatable<ShowCellRequest>, IDeepCloneable<ShowCellRequest>, IBufferMessage
{
	[Token(Token = "0x4001A4A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShowCellRequest> _parser;

	[Token(Token = "0x4001A4B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A4C")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x4001A4D")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x17001127")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShowCellRequest> Parser
	{
		[Token(Token = "0x6005042")]
		[Address(RVA = "0xAE1420", Offset = "0xAE0820", VA = "0x180AE1420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001128")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005043")]
		[Address(RVA = "0xAE1370", Offset = "0xAE0770", VA = "0x180AE1370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001129")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005044")]
		[Address(RVA = "0xAE1470", Offset = "0xAE0870", VA = "0x180AE1470", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700112A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x6005048")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005049")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005045")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShowCellRequest()
	{
	}

	[Token(Token = "0x6005046")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShowCellRequest(ShowCellRequest other)
	{
	}

	[Token(Token = "0x6005047")]
	[Address(RVA = "0xAE1100", Offset = "0xAE0500", VA = "0x180AE1100", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShowCellRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600504A")]
	[Address(RVA = "0xAE1180", Offset = "0xAE0580", VA = "0x180AE1180", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600504B")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShowCellRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600504C")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600504D")]
	[Address(RVA = "0xAE1210", Offset = "0xAE0610", VA = "0x180AE1210", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600504E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600504F")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005050")]
	[Address(RVA = "0xAE1070", Offset = "0xAE0470", VA = "0x180AE1070", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005051")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShowCellRequest other)
	{
	}

	[Token(Token = "0x6005052")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005053")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
