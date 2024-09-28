using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AC7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ItemMinimalInformation : IMessage<ItemMinimalInformation>, IMessage, IEquatable<ItemMinimalInformation>, IDeepCloneable<ItemMinimalInformation>, IBufferMessage
{
	[Token(Token = "0x2000AC8")]
	public enum ComplementOneofCase
	{
		[Token(Token = "0x4002784")]
		None = 0,
		[Token(Token = "0x4002785")]
		Quantity = 3,
		[Token(Token = "0x4002786")]
		ItemToSellInNpcShop = 4
	}

	[Token(Token = "0x2000AC9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000ACA")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ItemToSellInNpcShop : IMessage<ItemToSellInNpcShop>, IMessage, IEquatable<ItemToSellInNpcShop>, IDeepCloneable<ItemToSellInNpcShop>, IBufferMessage
		{
			[Token(Token = "0x4002787")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ItemToSellInNpcShop> _parser;

			[Token(Token = "0x4002788")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002789")]
			public const int PriceFieldNumber = 1;

			[Token(Token = "0x400278A")]
			[FieldOffset(Offset = "0x18")]
			private long price_;

			[Token(Token = "0x400278B")]
			public const int BuyCriterionFieldNumber = 2;

			[Token(Token = "0x400278C")]
			[FieldOffset(Offset = "0x20")]
			private string buyCriterion_;

			[Token(Token = "0x170018AA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ItemToSellInNpcShop> Parser
			{
				[Token(Token = "0x600710D")]
				[Address(RVA = "0xBE21D0", Offset = "0xBE15D0", VA = "0x180BE21D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018AB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600710E")]
				[Address(RVA = "0xBE2150", Offset = "0xBE1550", VA = "0x180BE2150")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018AC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600710F")]
				[Address(RVA = "0xBE2300", Offset = "0xBE1700", VA = "0x180BE2300", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018AD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long Price
			{
				[Token(Token = "0x6007113")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6007114")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x170018AE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string BuyCriterion
			{
				[Token(Token = "0x6007115")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007116")]
				[Address(RVA = "0xBE23B0", Offset = "0xBE17B0", VA = "0x180BE23B0")]
				set
				{
				}
			}

			[Token(Token = "0x6007110")]
			[Address(RVA = "0xBE2100", Offset = "0xBE1500", VA = "0x180BE2100")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ItemToSellInNpcShop()
			{
			}

			[Token(Token = "0x6007111")]
			[Address(RVA = "0xBE2050", Offset = "0xBE1450", VA = "0x180BE2050")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ItemToSellInNpcShop(ItemToSellInNpcShop other)
			{
			}

			[Token(Token = "0x6007112")]
			[Address(RVA = "0xBE1CF0", Offset = "0xBE10F0", VA = "0x180BE1CF0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ItemToSellInNpcShop Clone()
			{
				return null;
			}

			[Token(Token = "0x6007117")]
			[Address(RVA = "0xBE1DC0", Offset = "0xBE11C0", VA = "0x180BE1DC0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007118")]
			[Address(RVA = "0x92C840", Offset = "0x92BC40", VA = "0x18092C840", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ItemToSellInNpcShop other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007119")]
			[Address(RVA = "0x92C8B0", Offset = "0x92BCB0", VA = "0x18092C8B0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600711A")]
			[Address(RVA = "0xBE1EF0", Offset = "0xBE12F0", VA = "0x180BE1EF0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600711B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600711C")]
			[Address(RVA = "0x92CDC0", Offset = "0x92C1C0", VA = "0x18092CDC0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600711D")]
			[Address(RVA = "0xBE1C30", Offset = "0xBE1030", VA = "0x180BE1C30", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600711E")]
			[Address(RVA = "0xBE1E80", Offset = "0xBE1280", VA = "0x180BE1E80", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(ItemToSellInNpcShop other)
			{
			}

			[Token(Token = "0x600711F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007120")]
			[Address(RVA = "0xBE2220", Offset = "0xBE1620", VA = "0x180BE2220", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002778")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ItemMinimalInformation> _parser;

	[Token(Token = "0x4002779")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400277A")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x400277B")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x400277C")]
	public const int EffectsFieldNumber = 2;

	[Token(Token = "0x400277D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x400277E")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x400277F")]
	public const int QuantityFieldNumber = 3;

	[Token(Token = "0x4002780")]
	public const int ItemToSellInNpcShopFieldNumber = 4;

	[Token(Token = "0x4002781")]
	[FieldOffset(Offset = "0x28")]
	private object complement_;

	[Token(Token = "0x4002782")]
	[FieldOffset(Offset = "0x30")]
	private ComplementOneofCase complementCase_;

	[Token(Token = "0x170018A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ItemMinimalInformation> Parser
	{
		[Token(Token = "0x60070F1")]
		[Address(RVA = "0xBE1720", Offset = "0xBE0B20", VA = "0x180BE1720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018A2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60070F2")]
		[Address(RVA = "0xBE1610", Offset = "0xBE0A10", VA = "0x180BE1610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60070F3")]
		[Address(RVA = "0xBE1B80", Offset = "0xBE0F80", VA = "0x180BE1B80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018A4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x60070F7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60070F8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170018A5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x60070F9")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Quantity
	{
		[Token(Token = "0x60070FA")]
		[Address(RVA = "0xBE1770", Offset = "0xBE0B70", VA = "0x180BE1770")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60070FB")]
		[Address(RVA = "0xBE1BC0", Offset = "0xBE0FC0", VA = "0x180BE1BC0")]
		set
		{
		}
	}

	[Token(Token = "0x170018A7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasQuantity
	{
		[Token(Token = "0x60070FC")]
		[Address(RVA = "0xB02E20", Offset = "0xB02220", VA = "0x180B02E20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ItemToSellInNpcShop ItemToSellInNpcShop
	{
		[Token(Token = "0x60070FE")]
		[Address(RVA = "0xBE16C0", Offset = "0xBE0AC0", VA = "0x180BE16C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070FF")]
		[Address(RVA = "0x91BB40", Offset = "0x91AF40", VA = "0x18091BB40")]
		set
		{
		}
	}

	[Token(Token = "0x170018A9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComplementOneofCase ComplementCase
	{
		[Token(Token = "0x6007100")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(ComplementOneofCase);
		}
	}

	[Token(Token = "0x60070F4")]
	[Address(RVA = "0xBE1310", Offset = "0xBE0710", VA = "0x180BE1310")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemMinimalInformation()
	{
	}

	[Token(Token = "0x60070F5")]
	[Address(RVA = "0xBE1390", Offset = "0xBE0790", VA = "0x180BE1390")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemMinimalInformation(ItemMinimalInformation other)
	{
	}

	[Token(Token = "0x60070F6")]
	[Address(RVA = "0xBE0B60", Offset = "0xBDFF60", VA = "0x180BE0B60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemMinimalInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60070FD")]
	[Address(RVA = "0xB02290", Offset = "0xB01690", VA = "0x180B02290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearQuantity()
	{
	}

	[Token(Token = "0x6007101")]
	[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearComplement()
	{
	}

	[Token(Token = "0x6007102")]
	[Address(RVA = "0xBE0CD0", Offset = "0xBE00D0", VA = "0x180BE0CD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007103")]
	[Address(RVA = "0xBE0BC0", Offset = "0xBDFFC0", VA = "0x180BE0BC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ItemMinimalInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007104")]
	[Address(RVA = "0xBE0E10", Offset = "0xBE0210", VA = "0x180BE0E10", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007105")]
	[Address(RVA = "0xBE1110", Offset = "0xBE0510", VA = "0x180BE1110", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007106")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007107")]
	[Address(RVA = "0xBE19C0", Offset = "0xBE0DC0", VA = "0x180BE19C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007108")]
	[Address(RVA = "0xBE0980", Offset = "0xBDFD80", VA = "0x180BE0980", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007109")]
	[Address(RVA = "0xBE0F80", Offset = "0xBE0380", VA = "0x180BE0F80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ItemMinimalInformation other)
	{
	}

	[Token(Token = "0x600710A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600710B")]
	[Address(RVA = "0xBE17E0", Offset = "0xBE0BE0", VA = "0x180BE17E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
