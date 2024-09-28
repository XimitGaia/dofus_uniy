using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006F3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidPriceEvent : IMessage<ExchangeBidPriceEvent>, IMessage, IEquatable<ExchangeBidPriceEvent>, IDeepCloneable<ExchangeBidPriceEvent>, IBufferMessage
{
	[Token(Token = "0x20006F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20006F5")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class BidPriceForSeller : IMessage<BidPriceForSeller>, IMessage, IEquatable<BidPriceForSeller>, IDeepCloneable<BidPriceForSeller>, IBufferMessage
		{
			[Token(Token = "0x400187A")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<BidPriceForSeller> _parser;

			[Token(Token = "0x400187B")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400187C")]
			public const int AllIdenticalFieldNumber = 1;

			[Token(Token = "0x400187D")]
			[FieldOffset(Offset = "0x18")]
			private bool allIdentical_;

			[Token(Token = "0x400187E")]
			public const int MinimalPricesFieldNumber = 2;

			[Token(Token = "0x400187F")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<long> _repeated_minimalPrices_codec;

			[Token(Token = "0x4001880")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<long> minimalPrices_;

			[Token(Token = "0x17000FFF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<BidPriceForSeller> Parser
			{
				[Token(Token = "0x6004ABF")]
				[Address(RVA = "0xA9E040", Offset = "0xA9D440", VA = "0x180A9E040")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001000")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6004AC0")]
				[Address(RVA = "0xA9DFC0", Offset = "0xA9D3C0", VA = "0x180A9DFC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001001")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6004AC1")]
				[Address(RVA = "0xA9E290", Offset = "0xA9D690", VA = "0x180A9E290", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001002")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool AllIdentical
			{
				[Token(Token = "0x6004AC5")]
				[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6004AC6")]
				[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
				set
				{
				}
			}

			[Token(Token = "0x17001003")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<long> MinimalPrices
			{
				[Token(Token = "0x6004AC7")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004AC2")]
			[Address(RVA = "0xA9DEB0", Offset = "0xA9D2B0", VA = "0x180A9DEB0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public BidPriceForSeller()
			{
			}

			[Token(Token = "0x6004AC3")]
			[Address(RVA = "0xA9DF30", Offset = "0xA9D330", VA = "0x180A9DF30")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public BidPriceForSeller(BidPriceForSeller other)
			{
			}

			[Token(Token = "0x6004AC4")]
			[Address(RVA = "0xA9D990", Offset = "0xA9CD90", VA = "0x180A9D990", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public BidPriceForSeller Clone()
			{
				return null;
			}

			[Token(Token = "0x6004AC8")]
			[Address(RVA = "0xA9DAF0", Offset = "0xA9CEF0", VA = "0x180A9DAF0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004AC9")]
			[Address(RVA = "0xA9DA50", Offset = "0xA9CE50", VA = "0x180A9DA50", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(BidPriceForSeller other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004ACA")]
			[Address(RVA = "0xA9DBD0", Offset = "0xA9CFD0", VA = "0x180A9DBD0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6004ACB")]
			[Address(RVA = "0xA9DD20", Offset = "0xA9D120", VA = "0x180A9DD20", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6004ACC")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6004ACD")]
			[Address(RVA = "0xA9E1C0", Offset = "0xA9D5C0", VA = "0x180A9E1C0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6004ACE")]
			[Address(RVA = "0xA9D8D0", Offset = "0xA9CCD0", VA = "0x180A9D8D0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6004ACF")]
			[Address(RVA = "0xA9DC90", Offset = "0xA9D090", VA = "0x180A9DC90", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(BidPriceForSeller other)
			{
			}

			[Token(Token = "0x6004AD0")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6004AD1")]
			[Address(RVA = "0xA9E090", Offset = "0xA9D490", VA = "0x180A9E090", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001872")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidPriceEvent> _parser;

	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001874")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x4001875")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x4001876")]
	public const int AveragePriceFieldNumber = 2;

	[Token(Token = "0x4001877")]
	[FieldOffset(Offset = "0x20")]
	private long averagePrice_;

	[Token(Token = "0x4001878")]
	public const int BidPriceForSellerFieldNumber = 3;

	[Token(Token = "0x4001879")]
	[FieldOffset(Offset = "0x28")]
	private Types.BidPriceForSeller bidPriceForSeller_;

	[Token(Token = "0x17000FF9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidPriceEvent> Parser
	{
		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0xAA4720", Offset = "0xAA3B20", VA = "0x180AA4720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FFA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0xAA4670", Offset = "0xAA3A70", VA = "0x180AA4670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FFB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0xAA4950", Offset = "0xAA3D50", VA = "0x180AA4950", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FFC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AAF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000FFD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AveragePrice
	{
		[Token(Token = "0x6004AB0")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004AB1")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000FFE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.BidPriceForSeller BidPriceForSeller
	{
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6004AAB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidPriceEvent()
	{
	}

	[Token(Token = "0x6004AAC")]
	[Address(RVA = "0xAA4540", Offset = "0xAA3940", VA = "0x180AA4540")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidPriceEvent(ExchangeBidPriceEvent other)
	{
	}

	[Token(Token = "0x6004AAD")]
	[Address(RVA = "0xAA3F40", Offset = "0xAA3340", VA = "0x180AA3F40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidPriceEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004AB4")]
	[Address(RVA = "0xAA40A0", Offset = "0xAA34A0", VA = "0x180AA40A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AB5")]
	[Address(RVA = "0xAA4160", Offset = "0xAA3560", VA = "0x180AA4160", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidPriceEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AB6")]
	[Address(RVA = "0xAA41E0", Offset = "0xAA35E0", VA = "0x180AA41E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004AB7")]
	[Address(RVA = "0xAA43E0", Offset = "0xAA37E0", VA = "0x180AA43E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004AB8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004AB9")]
	[Address(RVA = "0xAA48B0", Offset = "0xAA3CB0", VA = "0x180AA48B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004ABA")]
	[Address(RVA = "0xAA3E50", Offset = "0xAA3250", VA = "0x180AA3E50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004ABB")]
	[Address(RVA = "0xAA4290", Offset = "0xAA3690", VA = "0x180AA4290", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidPriceEvent other)
	{
	}

	[Token(Token = "0x6004ABC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004ABD")]
	[Address(RVA = "0xAA4770", Offset = "0xAA3B70", VA = "0x180AA4770", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
