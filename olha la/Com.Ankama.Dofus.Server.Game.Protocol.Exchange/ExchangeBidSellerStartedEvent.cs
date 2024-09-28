using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006EA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidSellerStartedEvent : IMessage<ExchangeBidSellerStartedEvent>, IMessage, IEquatable<ExchangeBidSellerStartedEvent>, IDeepCloneable<ExchangeBidSellerStartedEvent>, IBufferMessage
{
	[Token(Token = "0x20006EB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20006EC")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ItemToSellInBid : IMessage<ItemToSellInBid>, IMessage, IEquatable<ItemToSellInBid>, IDeepCloneable<ItemToSellInBid>, IBufferMessage
		{
			[Token(Token = "0x4001857")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ItemToSellInBid> _parser;

			[Token(Token = "0x4001858")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001859")]
			public const int ItemFieldNumber = 1;

			[Token(Token = "0x400185A")]
			[FieldOffset(Offset = "0x18")]
			private BidItem item_;

			[Token(Token = "0x400185B")]
			public const int PriceFieldNumber = 2;

			[Token(Token = "0x400185C")]
			[FieldOffset(Offset = "0x20")]
			private long price_;

			[Token(Token = "0x400185D")]
			public const int UnsoldDelayFieldNumber = 3;

			[Token(Token = "0x400185E")]
			[FieldOffset(Offset = "0x28")]
			private int unsoldDelay_;

			[Token(Token = "0x17000FE8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ItemToSellInBid> Parser
			{
				[Token(Token = "0x6004A5A")]
				[Address(RVA = "0xAB0320", Offset = "0xAAF720", VA = "0x180AB0320")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000FE9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6004A5B")]
				[Address(RVA = "0xAB02A0", Offset = "0xAAF6A0", VA = "0x180AB02A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000FEA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6004A5C")]
				[Address(RVA = "0xAB0550", Offset = "0xAAF950", VA = "0x180AB0550", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000FEB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public BidItem Item
			{
				[Token(Token = "0x6004A60")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004A61")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17000FEC")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long Price
			{
				[Token(Token = "0x6004A62")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6004A63")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x17000FED")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int UnsoldDelay
			{
				[Token(Token = "0x6004A64")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004A65")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x6004A5D")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ItemToSellInBid()
			{
			}

			[Token(Token = "0x6004A5E")]
			[Address(RVA = "0xAB0220", Offset = "0xAAF620", VA = "0x180AB0220")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ItemToSellInBid(ItemToSellInBid other)
			{
			}

			[Token(Token = "0x6004A5F")]
			[Address(RVA = "0xAAFD40", Offset = "0xAAF140", VA = "0x180AAFD40", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ItemToSellInBid Clone()
			{
				return null;
			}

			[Token(Token = "0x6004A66")]
			[Address(RVA = "0xAAFE70", Offset = "0xAAF270", VA = "0x180AAFE70", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004A67")]
			[Address(RVA = "0xAAFDF0", Offset = "0xAAF1F0", VA = "0x180AAFDF0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ItemToSellInBid other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004A68")]
			[Address(RVA = "0xAAFF30", Offset = "0xAAF330", VA = "0x180AAFF30", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6004A69")]
			[Address(RVA = "0xAB00C0", Offset = "0xAAF4C0", VA = "0x180AB00C0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6004A6A")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6004A6B")]
			[Address(RVA = "0xAB04B0", Offset = "0xAAF8B0", VA = "0x180AB04B0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6004A6C")]
			[Address(RVA = "0xAAFC50", Offset = "0xAAF050", VA = "0x180AAFC50", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6004A6D")]
			[Address(RVA = "0xAAFFE0", Offset = "0xAAF3E0", VA = "0x180AAFFE0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ItemToSellInBid other)
			{
			}

			[Token(Token = "0x6004A6E")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6004A6F")]
			[Address(RVA = "0xAB0370", Offset = "0xAAF770", VA = "0x180AB0370", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001850")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidSellerStartedEvent> _parser;

	[Token(Token = "0x4001851")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001852")]
	public const int SellingConditionsFieldNumber = 1;

	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x18")]
	private SellingConditions sellingConditions_;

	[Token(Token = "0x4001854")]
	public const int ItemsFieldNumber = 2;

	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.ItemToSellInBid> _repeated_items_codec;

	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.ItemToSellInBid> items_;

	[Token(Token = "0x17000FE3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeBidSellerStartedEvent> Parser
	{
		[Token(Token = "0x6004A46")]
		[Address(RVA = "0xAA51D0", Offset = "0xAA45D0", VA = "0x180AA51D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FE4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004A47")]
		[Address(RVA = "0xAA5120", Offset = "0xAA4520", VA = "0x180AA5120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FE5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004A48")]
		[Address(RVA = "0xAA5460", Offset = "0xAA4860", VA = "0x180AA5460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FE6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SellingConditions SellingConditions
	{
		[Token(Token = "0x6004A4C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004A4D")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000FE7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.ItemToSellInBid> Items
	{
		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004A49")]
	[Address(RVA = "0xAA4FE0", Offset = "0xAA43E0", VA = "0x180AA4FE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidSellerStartedEvent()
	{
	}

	[Token(Token = "0x6004A4A")]
	[Address(RVA = "0xAA5060", Offset = "0xAA4460", VA = "0x180AA5060")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidSellerStartedEvent(ExchangeBidSellerStartedEvent other)
	{
	}

	[Token(Token = "0x6004A4B")]
	[Address(RVA = "0xAA4A70", Offset = "0xAA3E70", VA = "0x180AA4A70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidSellerStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004A4F")]
	[Address(RVA = "0xAA4C00", Offset = "0xAA4000", VA = "0x180AA4C00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A50")]
	[Address(RVA = "0xAA4B50", Offset = "0xAA3F50", VA = "0x180AA4B50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidSellerStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A51")]
	[Address(RVA = "0xA82900", Offset = "0xA81D00", VA = "0x180A82900", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004A52")]
	[Address(RVA = "0xAA4DE0", Offset = "0xAA41E0", VA = "0x180AA4DE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004A53")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004A54")]
	[Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004A55")]
	[Address(RVA = "0xAA4990", Offset = "0xAA3D90", VA = "0x180AA4990", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004A56")]
	[Address(RVA = "0xAA4CF0", Offset = "0xAA40F0", VA = "0x180AA4CF0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidSellerStartedEvent other)
	{
	}

	[Token(Token = "0x6004A57")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004A58")]
	[Address(RVA = "0xAA5220", Offset = "0xAA4620", VA = "0x180AA5220", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
