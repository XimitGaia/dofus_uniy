using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x20003FD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HousesToSellRequest : IMessage<HousesToSellRequest>, IMessage, IEquatable<HousesToSellRequest>, IDeepCloneable<HousesToSellRequest>, IBufferMessage
{
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HousesToSellRequest> _parser;

	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DBB")]
	public const int PageIndexFieldNumber = 1;

	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x18")]
	private int pageIndex_;

	[Token(Token = "0x170008EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HousesToSellRequest> Parser
	{
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x9A4010", Offset = "0x9A3410", VA = "0x1809A4010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x9A3F60", Offset = "0x9A3360", VA = "0x1809A3F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x9A4060", Offset = "0x9A3460", VA = "0x1809A4060", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PageIndex
	{
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60029D6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HousesToSellRequest()
	{
	}

	[Token(Token = "0x60029D7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HousesToSellRequest(HousesToSellRequest other)
	{
	}

	[Token(Token = "0x60029D8")]
	[Address(RVA = "0x9A3CF0", Offset = "0x9A30F0", VA = "0x1809A3CF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HousesToSellRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x9A3D70", Offset = "0x9A3170", VA = "0x1809A3D70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HousesToSellRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60029DE")]
	[Address(RVA = "0x9A3E00", Offset = "0x9A3200", VA = "0x1809A3E00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60029DF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60029E0")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x9A3C60", Offset = "0x9A3060", VA = "0x1809A3C60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HousesToSellRequest other)
	{
	}

	[Token(Token = "0x60029E3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60029E4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
