using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol;

[Token(Token = "0x2000011")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IBufferMessage
{
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Request> _parser;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000038")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x18")]
	private int uid_;

	[Token(Token = "0x400003A")]
	public const int ContentFieldNumber = 2;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x20")]
	private Any content_;

	[Token(Token = "0x17000015")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Request> Parser
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x940D20", Offset = "0x940120", VA = "0x180940D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x940C70", Offset = "0x940070", VA = "0x180940C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000017")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x940F10", Offset = "0x940310", VA = "0x180940F10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Uid
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Any Content
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Request()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x940C00", Offset = "0x940000", VA = "0x180940C00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Request(Request other)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x940780", Offset = "0x93FB80", VA = "0x180940780", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Request Clone()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x940890", Offset = "0x93FC90", VA = "0x180940890", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(Request other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x940AA0", Offset = "0x93FEA0", VA = "0x180940AA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x9406C0", Offset = "0x93FAC0", VA = "0x1809406C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x9409D0", Offset = "0x93FDD0", VA = "0x1809409D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Request other)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x940D70", Offset = "0x940170", VA = "0x180940D70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
