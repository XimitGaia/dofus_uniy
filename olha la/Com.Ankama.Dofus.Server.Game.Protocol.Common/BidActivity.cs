using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x200091C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BidActivity : IMessage<BidActivity>, IMessage, IEquatable<BidActivity>, IDeepCloneable<BidActivity>, IBufferMessage
{
	[Token(Token = "0x200091D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200091E")]
		public enum Type
		{
			[Token(Token = "0x4001F2B")]
			[OriginalName("SELL")]
			Sell,
			[Token(Token = "0x4001F2C")]
			[OriginalName("BUY")]
			Buy,
			[Token(Token = "0x4001F2D")]
			[OriginalName("EXPIRE")]
			Expire
		}
	}

	[Token(Token = "0x4001F1E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BidActivity> _parser;

	[Token(Token = "0x4001F1F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001F20")]
	public const int BidIdFieldNumber = 1;

	[Token(Token = "0x4001F21")]
	[FieldOffset(Offset = "0x18")]
	private int bidId_;

	[Token(Token = "0x4001F22")]
	public const int TypeFieldNumber = 2;

	[Token(Token = "0x4001F23")]
	[FieldOffset(Offset = "0x1C")]
	private Types.Type type_;

	[Token(Token = "0x4001F24")]
	public const int CreatedAtFieldNumber = 3;

	[Token(Token = "0x4001F25")]
	[FieldOffset(Offset = "0x20")]
	private string createdAt_;

	[Token(Token = "0x4001F26")]
	public const int ObjectFieldNumber = 4;

	[Token(Token = "0x4001F27")]
	[FieldOffset(Offset = "0x28")]
	private ItemMinimalInformation object_;

	[Token(Token = "0x4001F28")]
	public const int PriceFieldNumber = 5;

	[Token(Token = "0x4001F29")]
	[FieldOffset(Offset = "0x30")]
	private long price_;

	[Token(Token = "0x1700145F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BidActivity> Parser
	{
		[Token(Token = "0x6006056")]
		[Address(RVA = "0xB4D150", Offset = "0xB4C550", VA = "0x180B4D150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001460")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006057")]
		[Address(RVA = "0xB4D0A0", Offset = "0xB4C4A0", VA = "0x180B4D0A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001461")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006058")]
		[Address(RVA = "0xB4D430", Offset = "0xB4C830", VA = "0x180B4D430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001462")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BidId
	{
		[Token(Token = "0x600605C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600605D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001463")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Type Type
	{
		[Token(Token = "0x600605E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.Type);
		}
		[Token(Token = "0x600605F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001464")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CreatedAt
	{
		[Token(Token = "0x6006060")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006061")]
		[Address(RVA = "0xB4D510", Offset = "0xB4C910", VA = "0x180B4D510")]
		set
		{
		}
	}

	[Token(Token = "0x17001465")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemMinimalInformation Object
	{
		[Token(Token = "0x6006062")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006063")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x17001466")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Price
	{
		[Token(Token = "0x6006064")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006065")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x6006059")]
	[Address(RVA = "0xB4D050", Offset = "0xB4C450", VA = "0x180B4D050")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidActivity()
	{
	}

	[Token(Token = "0x600605A")]
	[Address(RVA = "0xB4CF70", Offset = "0xB4C370", VA = "0x180B4CF70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidActivity(BidActivity other)
	{
	}

	[Token(Token = "0x600605B")]
	[Address(RVA = "0xB4C9A0", Offset = "0xB4BDA0", VA = "0x180B4C9A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BidActivity Clone()
	{
		return null;
	}

	[Token(Token = "0x6006066")]
	[Address(RVA = "0xB4CAA0", Offset = "0xB4BEA0", VA = "0x180B4CAA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006067")]
	[Address(RVA = "0xB4CB80", Offset = "0xB4BF80", VA = "0x180B4CB80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BidActivity other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006068")]
	[Address(RVA = "0xB4CC10", Offset = "0xB4C010", VA = "0x180B4CC10", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006069")]
	[Address(RVA = "0xB4CE10", Offset = "0xB4C210", VA = "0x180B4CE10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600606A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600606B")]
	[Address(RVA = "0xB4D340", Offset = "0xB4C740", VA = "0x180B4D340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600606C")]
	[Address(RVA = "0xB4C860", Offset = "0xB4BC60", VA = "0x180B4C860", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600606D")]
	[Address(RVA = "0xB4CD00", Offset = "0xB4C100", VA = "0x180B4CD00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BidActivity other)
	{
	}

	[Token(Token = "0x600606E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600606F")]
	[Address(RVA = "0xB4D1A0", Offset = "0xB4C5A0", VA = "0x180B4D1A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
