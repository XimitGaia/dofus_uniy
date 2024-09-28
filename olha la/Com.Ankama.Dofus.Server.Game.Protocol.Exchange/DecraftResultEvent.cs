using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200072E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DecraftResultEvent : IMessage<DecraftResultEvent>, IMessage, IEquatable<DecraftResultEvent>, IDeepCloneable<DecraftResultEvent>, IBufferMessage
{
	[Token(Token = "0x200072F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000730")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class DecraftedItem : IMessage<DecraftedItem>, IMessage, IEquatable<DecraftedItem>, IDeepCloneable<DecraftedItem>, IBufferMessage
		{
			[Token(Token = "0x2000731")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000732")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class Rune : IMessage<Rune>, IMessage, IEquatable<Rune>, IDeepCloneable<Rune>, IBufferMessage
				{
					[Token(Token = "0x400195A")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<Rune> _parser;

					[Token(Token = "0x400195B")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x400195C")]
					public const int RuneIdFieldNumber = 1;

					[Token(Token = "0x400195D")]
					[FieldOffset(Offset = "0x18")]
					private int runeId_;

					[Token(Token = "0x400195E")]
					public const int QuantityFieldNumber = 2;

					[Token(Token = "0x400195F")]
					[FieldOffset(Offset = "0x1C")]
					private int quantity_;

					[Token(Token = "0x1700108E")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<Rune> Parser
					{
						[Token(Token = "0x6004D50")]
						[Address(RVA = "0xAC5D80", Offset = "0xAC5180", VA = "0x180AC5D80")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700108F")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6004D51")]
						[Address(RVA = "0xAC5D00", Offset = "0xAC5100", VA = "0x180AC5D00")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001090")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6004D52")]
						[Address(RVA = "0xAC5DD0", Offset = "0xAC51D0", VA = "0x180AC5DD0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001091")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int RuneId
					{
						[Token(Token = "0x6004D56")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6004D57")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17001092")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int Quantity
					{
						[Token(Token = "0x6004D58")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6004D59")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x6004D53")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Rune()
					{
					}

					[Token(Token = "0x6004D54")]
					[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Rune(Rune other)
					{
					}

					[Token(Token = "0x6004D55")]
					[Address(RVA = "0xAC5A80", Offset = "0xAC4E80", VA = "0x180AC5A80", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Rune Clone()
					{
						return null;
					}

					[Token(Token = "0x6004D5A")]
					[Address(RVA = "0xAC5B10", Offset = "0xAC4F10", VA = "0x180AC5B10", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6004D5B")]
					[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(Rune other)
					{
						return default(bool);
					}

					[Token(Token = "0x6004D5C")]
					[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6004D5D")]
					[Address(RVA = "0xAC5BA0", Offset = "0xAC4FA0", VA = "0x180AC5BA0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6004D5E")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6004D5F")]
					[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6004D60")]
					[Address(RVA = "0xAC59C0", Offset = "0xAC4DC0", VA = "0x180AC59C0", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6004D61")]
					[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(Rune other)
					{
					}

					[Token(Token = "0x6004D62")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6004D63")]
					[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x400194F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<DecraftedItem> _parser;

			[Token(Token = "0x4001950")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001951")]
			public const int ObjectUidFieldNumber = 1;

			[Token(Token = "0x4001952")]
			[FieldOffset(Offset = "0x18")]
			private int objectUid_;

			[Token(Token = "0x4001953")]
			public const int BonusMinFieldNumber = 2;

			[Token(Token = "0x4001954")]
			[FieldOffset(Offset = "0x1C")]
			private float bonusMin_;

			[Token(Token = "0x4001955")]
			public const int BonusMaxFieldNumber = 3;

			[Token(Token = "0x4001956")]
			[FieldOffset(Offset = "0x20")]
			private float bonusMax_;

			[Token(Token = "0x4001957")]
			public const int RunesFieldNumber = 4;

			[Token(Token = "0x4001958")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<Types.Rune> _repeated_runes_codec;

			[Token(Token = "0x4001959")]
			[FieldOffset(Offset = "0x28")]
			private readonly RepeatedField<Types.Rune> runes_;

			[Token(Token = "0x17001087")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<DecraftedItem> Parser
			{
				[Token(Token = "0x6004D38")]
				[Address(RVA = "0xAB3570", Offset = "0xAB2970", VA = "0x180AB3570")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001088")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6004D39")]
				[Address(RVA = "0xAB34F0", Offset = "0xAB28F0", VA = "0x180AB34F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001089")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6004D3A")]
				[Address(RVA = "0xAB3860", Offset = "0xAB2C60", VA = "0x180AB3860", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700108A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ObjectUid
			{
				[Token(Token = "0x6004D3E")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004D3F")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x1700108B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public float BonusMin
			{
				[Token(Token = "0x6004D40")]
				[Address(RVA = "0x8998E0", Offset = "0x898CE0", VA = "0x1808998E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6004D41")]
				[Address(RVA = "0xAB38B0", Offset = "0xAB2CB0", VA = "0x180AB38B0")]
				set
				{
				}
			}

			[Token(Token = "0x1700108C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public float BonusMax
			{
				[Token(Token = "0x6004D42")]
				[Address(RVA = "0xAB34E0", Offset = "0xAB28E0", VA = "0x180AB34E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6004D43")]
				[Address(RVA = "0xAB38A0", Offset = "0xAB2CA0", VA = "0x180AB38A0")]
				set
				{
				}
			}

			[Token(Token = "0x1700108D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<Types.Rune> Runes
			{
				[Token(Token = "0x6004D44")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004D3B")]
			[Address(RVA = "0xAB33C0", Offset = "0xAB27C0", VA = "0x180AB33C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DecraftedItem()
			{
			}

			[Token(Token = "0x6004D3C")]
			[Address(RVA = "0xAB3440", Offset = "0xAB2840", VA = "0x180AB3440")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DecraftedItem(DecraftedItem other)
			{
			}

			[Token(Token = "0x6004D3D")]
			[Address(RVA = "0xAB2BB0", Offset = "0xAB1FB0", VA = "0x180AB2BB0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DecraftedItem Clone()
			{
				return null;
			}

			[Token(Token = "0x6004D45")]
			[Address(RVA = "0xAB2C80", Offset = "0xAB2080", VA = "0x180AB2C80", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004D46")]
			[Address(RVA = "0xAB2E10", Offset = "0xAB2210", VA = "0x180AB2E10", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(DecraftedItem other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004D47")]
			[Address(RVA = "0xAB2F50", Offset = "0xAB2350", VA = "0x180AB2F50", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6004D48")]
			[Address(RVA = "0xAB31C0", Offset = "0xAB25C0", VA = "0x180AB31C0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6004D49")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6004D4A")]
			[Address(RVA = "0xAB3730", Offset = "0xAB2B30", VA = "0x180AB3730", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6004D4B")]
			[Address(RVA = "0xAB2AB0", Offset = "0xAB1EB0", VA = "0x180AB2AB0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6004D4C")]
			[Address(RVA = "0xAB3110", Offset = "0xAB2510", VA = "0x180AB3110", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(DecraftedItem other)
			{
			}

			[Token(Token = "0x6004D4D")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6004D4E")]
			[Address(RVA = "0xAB35C0", Offset = "0xAB29C0", VA = "0x180AB35C0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400194A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DecraftResultEvent> _parser;

	[Token(Token = "0x400194B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400194C")]
	public const int ResultsFieldNumber = 1;

	[Token(Token = "0x400194D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.DecraftedItem> _repeated_results_codec;

	[Token(Token = "0x400194E")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.DecraftedItem> results_;

	[Token(Token = "0x17001083")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DecraftResultEvent> Parser
	{
		[Token(Token = "0x6004D26")]
		[Address(RVA = "0xAB2860", Offset = "0xAB1C60", VA = "0x180AB2860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001084")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004D27")]
		[Address(RVA = "0xAB27B0", Offset = "0xAB1BB0", VA = "0x180AB27B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001085")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004D28")]
		[Address(RVA = "0xAB2A70", Offset = "0xAB1E70", VA = "0x180AB2A70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001086")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.DecraftedItem> Results
	{
		[Token(Token = "0x6004D2C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004D29")]
	[Address(RVA = "0xAB2730", Offset = "0xAB1B30", VA = "0x180AB2730")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DecraftResultEvent()
	{
	}

	[Token(Token = "0x6004D2A")]
	[Address(RVA = "0xAB26A0", Offset = "0xAB1AA0", VA = "0x180AB26A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DecraftResultEvent(DecraftResultEvent other)
	{
	}

	[Token(Token = "0x6004D2B")]
	[Address(RVA = "0xAB21F0", Offset = "0xAB15F0", VA = "0x180AB21F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DecraftResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004D2D")]
	[Address(RVA = "0xAB2340", Offset = "0xAB1740", VA = "0x180AB2340", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D2E")]
	[Address(RVA = "0xAB22B0", Offset = "0xAB16B0", VA = "0x180AB22B0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DecraftResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D2F")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004D30")]
	[Address(RVA = "0xAB24A0", Offset = "0xAB18A0", VA = "0x180AB24A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004D31")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004D32")]
	[Address(RVA = "0xAB29C0", Offset = "0xAB1DC0", VA = "0x180AB29C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004D33")]
	[Address(RVA = "0xAB2150", Offset = "0xAB1550", VA = "0x180AB2150", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004D34")]
	[Address(RVA = "0xAB2420", Offset = "0xAB1820", VA = "0x180AB2420", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DecraftResultEvent other)
	{
	}

	[Token(Token = "0x6004D35")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004D36")]
	[Address(RVA = "0xAB28B0", Offset = "0xAB1CB0", VA = "0x180AB28B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
