using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000ACD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectGidWithQuantity : IMessage<ObjectGidWithQuantity>, IMessage, IEquatable<ObjectGidWithQuantity>, IDeepCloneable<ObjectGidWithQuantity>, IBufferMessage
{
	[Token(Token = "0x2000ACE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000ACF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ObjectPriceDateEffect : IMessage<ObjectPriceDateEffect>, IMessage, IEquatable<ObjectPriceDateEffect>, IDeepCloneable<ObjectPriceDateEffect>, IBufferMessage
		{
			[Token(Token = "0x4002797")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ObjectPriceDateEffect> _parser;

			[Token(Token = "0x4002798")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002799")]
			public const int PriceFieldNumber = 1;

			[Token(Token = "0x400279A")]
			[FieldOffset(Offset = "0x18")]
			private long price_;

			[Token(Token = "0x400279B")]
			public const int EffectsFieldNumber = 2;

			[Token(Token = "0x400279C")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

			[Token(Token = "0x400279D")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<ObjectEffect> effects_;

			[Token(Token = "0x400279E")]
			public const int DateFieldNumber = 3;

			[Token(Token = "0x400279F")]
			[FieldOffset(Offset = "0x28")]
			private long date_;

			[Token(Token = "0x170018B5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ObjectPriceDateEffect> Parser
			{
				[Token(Token = "0x600713F")]
				[Address(RVA = "0xBFACD0", Offset = "0xBFA0D0", VA = "0x180BFACD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018B6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007140")]
				[Address(RVA = "0xBFAC50", Offset = "0xBFA050", VA = "0x180BFAC50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018B7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007141")]
				[Address(RVA = "0xBFAF70", Offset = "0xBFA370", VA = "0x180BFAF70", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018B8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long Price
			{
				[Token(Token = "0x6007145")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6007146")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x170018B9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<ObjectEffect> Effects
			{
				[Token(Token = "0x6007147")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170018BA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long Date
			{
				[Token(Token = "0x6007148")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6007149")]
				[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
				set
				{
				}
			}

			[Token(Token = "0x6007142")]
			[Address(RVA = "0xBFAB30", Offset = "0xBF9F30", VA = "0x180BFAB30")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ObjectPriceDateEffect()
			{
			}

			[Token(Token = "0x6007143")]
			[Address(RVA = "0xBFABB0", Offset = "0xBF9FB0", VA = "0x180BFABB0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectPriceDateEffect(ObjectPriceDateEffect other)
			{
			}

			[Token(Token = "0x6007144")]
			[Address(RVA = "0xBFA570", Offset = "0xBF9970", VA = "0x180BFA570", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectPriceDateEffect Clone()
			{
				return null;
			}

			[Token(Token = "0x600714A")]
			[Address(RVA = "0xBFA640", Offset = "0xBF9A40", VA = "0x180BFA640", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600714B")]
			[Address(RVA = "0xBFA730", Offset = "0xBF9B30", VA = "0x180BFA730", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ObjectPriceDateEffect other)
			{
				return default(bool);
			}

			[Token(Token = "0x600714C")]
			[Address(RVA = "0xBFA7E0", Offset = "0xBF9BE0", VA = "0x180BFA7E0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600714D")]
			[Address(RVA = "0xBFA930", Offset = "0xBF9D30", VA = "0x180BFA930", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600714E")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600714F")]
			[Address(RVA = "0xBFAE70", Offset = "0xBFA270", VA = "0x180BFAE70", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007150")]
			[Address(RVA = "0xBFA460", Offset = "0xBF9860", VA = "0x180BFA460", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007151")]
			[Address(RVA = "0xBFA890", Offset = "0xBF9C90", VA = "0x180BFA890", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(ObjectPriceDateEffect other)
			{
			}

			[Token(Token = "0x6007152")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007153")]
			[Address(RVA = "0xBFAD20", Offset = "0xBFA120", VA = "0x180BFAD20", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400278F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectGidWithQuantity> _parser;

	[Token(Token = "0x4002790")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002791")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x4002792")]
	[FieldOffset(Offset = "0x18")]
	private int objectGid_;

	[Token(Token = "0x4002793")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4002794")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x4002795")]
	public const int PriceDateEffectFieldNumber = 3;

	[Token(Token = "0x4002796")]
	[FieldOffset(Offset = "0x20")]
	private Types.ObjectPriceDateEffect priceDateEffect_;

	[Token(Token = "0x170018AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectGidWithQuantity> Parser
	{
		[Token(Token = "0x6007128")]
		[Address(RVA = "0xBF75D0", Offset = "0xBF69D0", VA = "0x180BF75D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007129")]
		[Address(RVA = "0xBF7520", Offset = "0xBF6920", VA = "0x180BF7520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600712A")]
		[Address(RVA = "0xBF7800", Offset = "0xBF6C00", VA = "0x180BF7800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x600712E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600712F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170018B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x6007130")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007131")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170018B4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ObjectPriceDateEffect PriceDateEffect
	{
		[Token(Token = "0x6007132")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007133")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600712B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectGidWithQuantity()
	{
	}

	[Token(Token = "0x600712C")]
	[Address(RVA = "0xBF73F0", Offset = "0xBF67F0", VA = "0x180BF73F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectGidWithQuantity(ObjectGidWithQuantity other)
	{
	}

	[Token(Token = "0x600712D")]
	[Address(RVA = "0xBF6E70", Offset = "0xBF6270", VA = "0x180BF6E70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectGidWithQuantity Clone()
	{
		return null;
	}

	[Token(Token = "0x6007134")]
	[Address(RVA = "0xBF6FD0", Offset = "0xBF63D0", VA = "0x180BF6FD0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007135")]
	[Address(RVA = "0xBB1B50", Offset = "0xBB0F50", VA = "0x180BB1B50", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectGidWithQuantity other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007136")]
	[Address(RVA = "0xBF7090", Offset = "0xBF6490", VA = "0x180BF7090", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007137")]
	[Address(RVA = "0xBF7290", Offset = "0xBF6690", VA = "0x180BF7290", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007138")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007139")]
	[Address(RVA = "0xBF7760", Offset = "0xBF6B60", VA = "0x180BF7760", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600713A")]
	[Address(RVA = "0xBF6D90", Offset = "0xBF6190", VA = "0x180BF6D90", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600713B")]
	[Address(RVA = "0xBF7140", Offset = "0xBF6540", VA = "0x180BF7140", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectGidWithQuantity other)
	{
	}

	[Token(Token = "0x600713C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600713D")]
	[Address(RVA = "0xBF7620", Offset = "0xBF6A20", VA = "0x180BF7620", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
