using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000687")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseTypeRequest : IMessage<ExchangeBidHouseTypeRequest>, IMessage, IEquatable<ExchangeBidHouseTypeRequest>, IDeepCloneable<ExchangeBidHouseTypeRequest>, IBufferMessage
{
	[Token(Token = "0x40016DA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseTypeRequest> _parser;

	[Token(Token = "0x40016DB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016DC")]
	public const int TypeIdFieldNumber = 1;

	[Token(Token = "0x40016DD")]
	[FieldOffset(Offset = "0x18")]
	private int typeId_;

	[Token(Token = "0x40016DE")]
	public const int FollowFieldNumber = 2;

	[Token(Token = "0x40016DF")]
	[FieldOffset(Offset = "0x1C")]
	private bool follow_;

	[Token(Token = "0x17000EF5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseTypeRequest> Parser
	{
		[Token(Token = "0x60045F4")]
		[Address(RVA = "0xA88550", Offset = "0xA87950", VA = "0x180A88550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EF6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60045F5")]
		[Address(RVA = "0xA884A0", Offset = "0xA878A0", VA = "0x180A884A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EF7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60045F6")]
		[Address(RVA = "0xA885A0", Offset = "0xA879A0", VA = "0x180A885A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EF8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TypeId
	{
		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000EF9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Follow
	{
		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x60045F7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseTypeRequest()
	{
	}

	[Token(Token = "0x60045F8")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseTypeRequest(ExchangeBidHouseTypeRequest other)
	{
	}

	[Token(Token = "0x60045F9")]
	[Address(RVA = "0xA88160", Offset = "0xA87560", VA = "0x180A88160", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseTypeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60045FE")]
	[Address(RVA = "0xA881F0", Offset = "0xA875F0", VA = "0x180A881F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045FF")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseTypeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004600")]
	[Address(RVA = "0xA88280", Offset = "0xA87680", VA = "0x180A88280", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004601")]
	[Address(RVA = "0xA88340", Offset = "0xA87740", VA = "0x180A88340", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004602")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004603")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004604")]
	[Address(RVA = "0xA880D0", Offset = "0xA874D0", VA = "0x180A880D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004605")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeBidHouseTypeRequest other)
	{
	}

	[Token(Token = "0x6004606")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004607")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
