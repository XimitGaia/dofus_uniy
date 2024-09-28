using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006FA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeTypesItemsExchangerDescriptionForUserEvent : IMessage<ExchangeTypesItemsExchangerDescriptionForUserEvent>, IMessage, IEquatable<ExchangeTypesItemsExchangerDescriptionForUserEvent>, IDeepCloneable<ExchangeTypesItemsExchangerDescriptionForUserEvent>, IBufferMessage
{
	[Token(Token = "0x20006FB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20006FC")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class BidExchangerObject : IMessage<BidExchangerObject>, IMessage, IEquatable<BidExchangerObject>, IDeepCloneable<BidExchangerObject>, IBufferMessage
		{
			[Token(Token = "0x4001894")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<BidExchangerObject> _parser;

			[Token(Token = "0x4001895")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001896")]
			public const int UidFieldNumber = 1;

			[Token(Token = "0x4001897")]
			[FieldOffset(Offset = "0x18")]
			private int uid_;

			[Token(Token = "0x4001898")]
			public const int GidFieldNumber = 2;

			[Token(Token = "0x4001899")]
			[FieldOffset(Offset = "0x1C")]
			private int gid_;

			[Token(Token = "0x400189A")]
			public const int TypeFieldNumber = 3;

			[Token(Token = "0x400189B")]
			[FieldOffset(Offset = "0x20")]
			private int type_;

			[Token(Token = "0x400189C")]
			public const int EffectsFieldNumber = 4;

			[Token(Token = "0x400189D")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

			[Token(Token = "0x400189E")]
			[FieldOffset(Offset = "0x28")]
			private readonly RepeatedField<ObjectEffect> effects_;

			[Token(Token = "0x400189F")]
			public const int PricesFieldNumber = 5;

			[Token(Token = "0x40018A0")]
			[FieldOffset(Offset = "0x10")]
			private static readonly FieldCodec<long> _repeated_prices_codec;

			[Token(Token = "0x40018A1")]
			[FieldOffset(Offset = "0x30")]
			private readonly RepeatedField<long> prices_;

			[Token(Token = "0x1700100F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<BidExchangerObject> Parser
			{
				[Token(Token = "0x6004B06")]
				[Address(RVA = "0xA9C800", Offset = "0xA9BC00", VA = "0x180A9C800")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001010")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6004B07")]
				[Address(RVA = "0xA9C780", Offset = "0xA9BB80", VA = "0x180A9C780")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001011")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6004B08")]
				[Address(RVA = "0xA9CB80", Offset = "0xA9BF80", VA = "0x180A9CB80", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001012")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Uid
			{
				[Token(Token = "0x6004B0C")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004B0D")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17001013")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Gid
			{
				[Token(Token = "0x6004B0E")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004B0F")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17001014")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Type
			{
				[Token(Token = "0x6004B10")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004B11")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17001015")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<ObjectEffect> Effects
			{
				[Token(Token = "0x6004B12")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001016")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<long> Prices
			{
				[Token(Token = "0x6004B13")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004B09")]
			[Address(RVA = "0xA9C530", Offset = "0xA9B930", VA = "0x180A9C530")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public BidExchangerObject()
			{
			}

			[Token(Token = "0x6004B0A")]
			[Address(RVA = "0xA9C5F0", Offset = "0xA9B9F0", VA = "0x180A9C5F0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public BidExchangerObject(BidExchangerObject other)
			{
			}

			[Token(Token = "0x6004B0B")]
			[Address(RVA = "0xA9BD90", Offset = "0xA9B190", VA = "0x180A9BD90", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public BidExchangerObject Clone()
			{
				return null;
			}

			[Token(Token = "0x6004B14")]
			[Address(RVA = "0xA9BF50", Offset = "0xA9B350", VA = "0x180A9BF50", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004B15")]
			[Address(RVA = "0xA9C070", Offset = "0xA9B470", VA = "0x180A9C070", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(BidExchangerObject other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004B16")]
			[Address(RVA = "0xA9C140", Offset = "0xA9B540", VA = "0x180A9C140", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6004B17")]
			[Address(RVA = "0xA9C2F0", Offset = "0xA9B6F0", VA = "0x180A9C2F0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6004B18")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6004B19")]
			[Address(RVA = "0xA9CA30", Offset = "0xA9BE30", VA = "0x180A9CA30", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6004B1A")]
			[Address(RVA = "0xA9BC20", Offset = "0xA9B020", VA = "0x180A9BC20", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6004B1B")]
			[Address(RVA = "0xA9C230", Offset = "0xA9B630", VA = "0x180A9C230", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(BidExchangerObject other)
			{
			}

			[Token(Token = "0x6004B1C")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6004B1D")]
			[Address(RVA = "0xA9C850", Offset = "0xA9BC50", VA = "0x180A9C850", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400188B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeTypesItemsExchangerDescriptionForUserEvent> _parser;

	[Token(Token = "0x400188C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400188D")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x400188E")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x400188F")]
	public const int ObjectTypeFieldNumber = 2;

	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x1C")]
	private int objectType_;

	[Token(Token = "0x4001891")]
	public const int ItemDescriptionsFieldNumber = 3;

	[Token(Token = "0x4001892")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.BidExchangerObject> _repeated_itemDescriptions_codec;

	[Token(Token = "0x4001893")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.BidExchangerObject> itemDescriptions_;

	[Token(Token = "0x17001009")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeTypesItemsExchangerDescriptionForUserEvent> Parser
	{
		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0xAAF980", Offset = "0xAAED80", VA = "0x180AAF980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700100A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0xAAF8D0", Offset = "0xAAECD0", VA = "0x180AAF8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700100B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0xAAFC10", Offset = "0xAAF010", VA = "0x180AAFC10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700100C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700100D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectType
	{
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700100E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.BidExchangerObject> ItemDescriptions
	{
		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004AF3")]
	[Address(RVA = "0xAAF740", Offset = "0xAAEB40", VA = "0x180AAF740")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeTypesItemsExchangerDescriptionForUserEvent()
	{
	}

	[Token(Token = "0x6004AF4")]
	[Address(RVA = "0xAAF7C0", Offset = "0xAAEBC0", VA = "0x180AAF7C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTypesItemsExchangerDescriptionForUserEvent(ExchangeTypesItemsExchangerDescriptionForUserEvent other)
	{
	}

	[Token(Token = "0x6004AF5")]
	[Address(RVA = "0xAAF1F0", Offset = "0xAAE5F0", VA = "0x180AAF1F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTypesItemsExchangerDescriptionForUserEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004AFB")]
	[Address(RVA = "0xAAF320", Offset = "0xAAE720", VA = "0x180AAF320", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AFC")]
	[Address(RVA = "0xAAF410", Offset = "0xAAE810", VA = "0x180AAF410", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeTypesItemsExchangerDescriptionForUserEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AFD")]
	[Address(RVA = "0x9C6C20", Offset = "0x9C6020", VA = "0x1809C6C20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004AFE")]
	[Address(RVA = "0xAAF540", Offset = "0xAAE940", VA = "0x180AAF540", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004AFF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004B00")]
	[Address(RVA = "0xAAFB20", Offset = "0xAAEF20", VA = "0x180AAFB20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004B01")]
	[Address(RVA = "0xAAF0E0", Offset = "0xAAE4E0", VA = "0x180AAF0E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004B02")]
	[Address(RVA = "0xAAF4B0", Offset = "0xAAE8B0", VA = "0x180AAF4B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeTypesItemsExchangerDescriptionForUserEvent other)
	{
	}

	[Token(Token = "0x6004B03")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004B04")]
	[Address(RVA = "0xAAF9D0", Offset = "0xAAEDD0", VA = "0x180AAF9D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
