using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000683")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseSearchRequest : IMessage<ExchangeBidHouseSearchRequest>, IMessage, IEquatable<ExchangeBidHouseSearchRequest>, IDeepCloneable<ExchangeBidHouseSearchRequest>, IBufferMessage
{
	[Token(Token = "0x40016CC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseSearchRequest> _parser;

	[Token(Token = "0x40016CD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016CE")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x40016CF")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x40016D0")]
	public const int FollowFieldNumber = 2;

	[Token(Token = "0x40016D1")]
	[FieldOffset(Offset = "0x1C")]
	private bool follow_;

	[Token(Token = "0x17000EEB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseSearchRequest> Parser
	{
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0xA87FA0", Offset = "0xA873A0", VA = "0x180A87FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EEC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0xA87EF0", Offset = "0xA872F0", VA = "0x180A87EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0xA87FF0", Offset = "0xA873F0", VA = "0x180A87FF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EEE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000EEF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Follow
	{
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60045CD")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x60045C7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseSearchRequest()
	{
	}

	[Token(Token = "0x60045C8")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseSearchRequest(ExchangeBidHouseSearchRequest other)
	{
	}

	[Token(Token = "0x60045C9")]
	[Address(RVA = "0xA87BB0", Offset = "0xA86FB0", VA = "0x180A87BB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseSearchRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60045CE")]
	[Address(RVA = "0xA87C40", Offset = "0xA87040", VA = "0x180A87C40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045CF")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseSearchRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045D0")]
	[Address(RVA = "0xA87CD0", Offset = "0xA870D0", VA = "0x180A87CD0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60045D1")]
	[Address(RVA = "0xA87D90", Offset = "0xA87190", VA = "0x180A87D90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60045D2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60045D3")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60045D4")]
	[Address(RVA = "0xA87B20", Offset = "0xA86F20", VA = "0x180A87B20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60045D5")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseSearchRequest other)
	{
	}

	[Token(Token = "0x60045D6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60045D7")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
