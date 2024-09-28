using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000727")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectAveragePricesEvent : IMessage<ObjectAveragePricesEvent>, IMessage, IEquatable<ObjectAveragePricesEvent>, IDeepCloneable<ObjectAveragePricesEvent>, IBufferMessage
{
	[Token(Token = "0x2000728")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000729")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ObjectAveragePrice : IMessage<ObjectAveragePrice>, IMessage, IEquatable<ObjectAveragePrice>, IDeepCloneable<ObjectAveragePrice>, IBufferMessage
		{
			[Token(Token = "0x400193B")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ObjectAveragePrice> _parser;

			[Token(Token = "0x400193C")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400193D")]
			public const int ObjectGidFieldNumber = 1;

			[Token(Token = "0x400193E")]
			[FieldOffset(Offset = "0x18")]
			private int objectGid_;

			[Token(Token = "0x400193F")]
			public const int AveragePriceFieldNumber = 2;

			[Token(Token = "0x4001940")]
			[FieldOffset(Offset = "0x20")]
			private long averagePrice_;

			[Token(Token = "0x17001079")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ObjectAveragePrice> Parser
			{
				[Token(Token = "0x6004CF3")]
				[Address(RVA = "0xAC3BF0", Offset = "0xAC2FF0", VA = "0x180AC3BF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700107A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6004CF4")]
				[Address(RVA = "0xAC3B70", Offset = "0xAC2F70", VA = "0x180AC3B70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700107B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6004CF5")]
				[Address(RVA = "0xAC3C40", Offset = "0xAC3040", VA = "0x180AC3C40", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700107C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ObjectGid
			{
				[Token(Token = "0x6004CF9")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6004CFA")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x1700107D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long AveragePrice
			{
				[Token(Token = "0x6004CFB")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6004CFC")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x6004CF6")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectAveragePrice()
			{
			}

			[Token(Token = "0x6004CF7")]
			[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectAveragePrice(ObjectAveragePrice other)
			{
			}

			[Token(Token = "0x6004CF8")]
			[Address(RVA = "0xAC38E0", Offset = "0xAC2CE0", VA = "0x180AC38E0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectAveragePrice Clone()
			{
				return null;
			}

			[Token(Token = "0x6004CFD")]
			[Address(RVA = "0xAC3970", Offset = "0xAC2D70", VA = "0x180AC3970", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004CFE")]
			[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ObjectAveragePrice other)
			{
				return default(bool);
			}

			[Token(Token = "0x6004CFF")]
			[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6004D00")]
			[Address(RVA = "0xAC3A10", Offset = "0xAC2E10", VA = "0x180AC3A10", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6004D01")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6004D02")]
			[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6004D03")]
			[Address(RVA = "0xAC3820", Offset = "0xAC2C20", VA = "0x180AC3820", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6004D04")]
			[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ObjectAveragePrice other)
			{
			}

			[Token(Token = "0x6004D05")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6004D06")]
			[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001936")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectAveragePricesEvent> _parser;

	[Token(Token = "0x4001937")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001938")]
	public const int ObjectsAveragePricesFieldNumber = 1;

	[Token(Token = "0x4001939")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.ObjectAveragePrice> _repeated_objectsAveragePrices_codec;

	[Token(Token = "0x400193A")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.ObjectAveragePrice> objectsAveragePrices_;

	[Token(Token = "0x17001075")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectAveragePricesEvent> Parser
	{
		[Token(Token = "0x6004CE1")]
		[Address(RVA = "0xAC4840", Offset = "0xAC3C40", VA = "0x180AC4840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001076")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004CE2")]
		[Address(RVA = "0xAC4790", Offset = "0xAC3B90", VA = "0x180AC4790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001077")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004CE3")]
		[Address(RVA = "0xAC4A50", Offset = "0xAC3E50", VA = "0x180AC4A50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001078")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.ObjectAveragePrice> ObjectsAveragePrices
	{
		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004CE4")]
	[Address(RVA = "0xAC4680", Offset = "0xAC3A80", VA = "0x180AC4680")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectAveragePricesEvent()
	{
	}

	[Token(Token = "0x6004CE5")]
	[Address(RVA = "0xAC4700", Offset = "0xAC3B00", VA = "0x180AC4700")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectAveragePricesEvent(ObjectAveragePricesEvent other)
	{
	}

	[Token(Token = "0x6004CE6")]
	[Address(RVA = "0xAC41D0", Offset = "0xAC35D0", VA = "0x180AC41D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectAveragePricesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004CE8")]
	[Address(RVA = "0xAC4290", Offset = "0xAC3690", VA = "0x180AC4290", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CE9")]
	[Address(RVA = "0xAC4370", Offset = "0xAC3770", VA = "0x180AC4370", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectAveragePricesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004CEA")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004CEB")]
	[Address(RVA = "0xAC4480", Offset = "0xAC3880", VA = "0x180AC4480", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004CEC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004CED")]
	[Address(RVA = "0xAC49A0", Offset = "0xAC3DA0", VA = "0x180AC49A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004CEE")]
	[Address(RVA = "0xAC4130", Offset = "0xAC3530", VA = "0x180AC4130", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004CEF")]
	[Address(RVA = "0xAC4400", Offset = "0xAC3800", VA = "0x180AC4400", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectAveragePricesEvent other)
	{
	}

	[Token(Token = "0x6004CF0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004CF1")]
	[Address(RVA = "0xAC4890", Offset = "0xAC3C90", VA = "0x180AC4890", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
