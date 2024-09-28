using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000685")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseListRequest : IMessage<ExchangeBidHouseListRequest>, IMessage, IEquatable<ExchangeBidHouseListRequest>, IDeepCloneable<ExchangeBidHouseListRequest>, IBufferMessage
{
	[Token(Token = "0x40016D3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseListRequest> _parser;

	[Token(Token = "0x40016D4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016D5")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x40016D6")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x40016D7")]
	public const int FollowFieldNumber = 2;

	[Token(Token = "0x40016D8")]
	[FieldOffset(Offset = "0x1C")]
	private bool follow_;

	[Token(Token = "0x17000EF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseListRequest> Parser
	{
		[Token(Token = "0x60045DC")]
		[Address(RVA = "0xA87510", Offset = "0xA86910", VA = "0x180A87510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EF1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60045DD")]
		[Address(RVA = "0xA87460", Offset = "0xA86860", VA = "0x180A87460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EF2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60045DE")]
		[Address(RVA = "0xA87560", Offset = "0xA86960", VA = "0x180A87560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EF3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x60045E2")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60045E3")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000EF4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Follow
	{
		[Token(Token = "0x60045E4")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60045E5")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x60045DF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseListRequest()
	{
	}

	[Token(Token = "0x60045E0")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseListRequest(ExchangeBidHouseListRequest other)
	{
	}

	[Token(Token = "0x60045E1")]
	[Address(RVA = "0xA87120", Offset = "0xA86520", VA = "0x180A87120", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseListRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60045E6")]
	[Address(RVA = "0xA871B0", Offset = "0xA865B0", VA = "0x180A871B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045E7")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseListRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60045E8")]
	[Address(RVA = "0xA87240", Offset = "0xA86640", VA = "0x180A87240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60045E9")]
	[Address(RVA = "0xA87300", Offset = "0xA86700", VA = "0x180A87300", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60045EA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60045EB")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60045EC")]
	[Address(RVA = "0xA87090", Offset = "0xA86490", VA = "0x180A87090", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60045ED")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseListRequest other)
	{
	}

	[Token(Token = "0x60045EE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60045EF")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
