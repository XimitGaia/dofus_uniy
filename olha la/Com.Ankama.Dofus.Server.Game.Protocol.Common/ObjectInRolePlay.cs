using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AE6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectInRolePlay : IMessage<ObjectInRolePlay>, IMessage, IEquatable<ObjectInRolePlay>, IDeepCloneable<ObjectInRolePlay>, IBufferMessage
{
	[Token(Token = "0x2000AE7")]
	public enum ComplementOneofCase
	{
		[Token(Token = "0x400282C")]
		None = 0,
		[Token(Token = "0x400282D")]
		WithLook = 3,
		[Token(Token = "0x400282E")]
		PaddockItem = 4
	}

	[Token(Token = "0x2000AE8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000AE9")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class WithLook : IMessage<WithLook>, IMessage, IEquatable<WithLook>, IDeepCloneable<WithLook>, IBufferMessage
		{
			[Token(Token = "0x400282F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<WithLook> _parser;

			[Token(Token = "0x4002830")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002831")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4002832")]
			public const int LookFieldNumber = 1;

			[Token(Token = "0x4002833")]
			[FieldOffset(Offset = "0x20")]
			private EntityLook look_;

			[Token(Token = "0x4002834")]
			public const int DirectionFieldNumber = 2;

			[Token(Token = "0x4002835")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Direction DirectionDefaultValue;

			[Token(Token = "0x4002836")]
			[FieldOffset(Offset = "0x28")]
			private Direction direction_;

			[Token(Token = "0x17001911")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<WithLook> Parser
			{
				[Token(Token = "0x600728C")]
				[Address(RVA = "0xC00E90", Offset = "0xC00290", VA = "0x180C00E90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001912")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600728D")]
				[Address(RVA = "0xC00DA0", Offset = "0xC001A0", VA = "0x180C00DA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001913")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600728E")]
				[Address(RVA = "0xC010C0", Offset = "0xC004C0", VA = "0x180C010C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001914")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public EntityLook Look
			{
				[Token(Token = "0x6007292")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007293")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x17001915")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Direction Direction
			{
				[Token(Token = "0x6007294")]
				[Address(RVA = "0xC00E20", Offset = "0xC00220", VA = "0x180C00E20")]
				get
				{
					return default(Direction);
				}
				[Token(Token = "0x6007295")]
				[Address(RVA = "0xA0A2B0", Offset = "0xA096B0", VA = "0x180A0A2B0")]
				set
				{
				}
			}

			[Token(Token = "0x17001916")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasDirection
			{
				[Token(Token = "0x6007296")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600728F")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public WithLook()
			{
			}

			[Token(Token = "0x6007290")]
			[Address(RVA = "0xC00D20", Offset = "0xC00120", VA = "0x180C00D20")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public WithLook(WithLook other)
			{
			}

			[Token(Token = "0x6007291")]
			[Address(RVA = "0xC007E0", Offset = "0xBFFBE0", VA = "0x180C007E0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public WithLook Clone()
			{
				return null;
			}

			[Token(Token = "0x6007297")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearDirection()
			{
			}

			[Token(Token = "0x6007298")]
			[Address(RVA = "0xC00920", Offset = "0xBFFD20", VA = "0x180C00920", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007299")]
			[Address(RVA = "0xC00890", Offset = "0xBFFC90", VA = "0x180C00890", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(WithLook other)
			{
				return default(bool);
			}

			[Token(Token = "0x600729A")]
			[Address(RVA = "0xC009F0", Offset = "0xBFFDF0", VA = "0x180C009F0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600729B")]
			[Address(RVA = "0xC00BB0", Offset = "0xBFFFB0", VA = "0x180C00BB0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600729C")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600729D")]
			[Address(RVA = "0xC01000", Offset = "0xC00400", VA = "0x180C01000", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600729E")]
			[Address(RVA = "0xC006D0", Offset = "0xBFFAD0", VA = "0x180C006D0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600729F")]
			[Address(RVA = "0xC00AD0", Offset = "0xBFFED0", VA = "0x180C00AD0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(WithLook other)
			{
			}

			[Token(Token = "0x60072A0")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60072A1")]
			[Address(RVA = "0xC00EE0", Offset = "0xC002E0", VA = "0x180C00EE0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000AEB")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PaddockItem : IMessage<PaddockItem>, IMessage, IEquatable<PaddockItem>, IDeepCloneable<PaddockItem>, IBufferMessage
		{
			[Token(Token = "0x4002838")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PaddockItem> _parser;

			[Token(Token = "0x4002839")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400283A")]
			public const int DurabilityFieldNumber = 1;

			[Token(Token = "0x400283B")]
			[FieldOffset(Offset = "0x18")]
			private int durability_;

			[Token(Token = "0x400283C")]
			public const int DurabilityMaxFieldNumber = 2;

			[Token(Token = "0x400283D")]
			[FieldOffset(Offset = "0x1C")]
			private int durabilityMax_;

			[Token(Token = "0x17001917")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<PaddockItem> Parser
			{
				[Token(Token = "0x60072A6")]
				[Address(RVA = "0xBFB900", Offset = "0xBFAD00", VA = "0x180BFB900")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001918")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60072A7")]
				[Address(RVA = "0xBFB880", Offset = "0xBFAC80", VA = "0x180BFB880")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001919")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60072A8")]
				[Address(RVA = "0xBFB950", Offset = "0xBFAD50", VA = "0x180BFB950", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700191A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Durability
			{
				[Token(Token = "0x60072AC")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60072AD")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x1700191B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int DurabilityMax
			{
				[Token(Token = "0x60072AE")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60072AF")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x60072A9")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockItem()
			{
			}

			[Token(Token = "0x60072AA")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockItem(PaddockItem other)
			{
			}

			[Token(Token = "0x60072AB")]
			[Address(RVA = "0xBFB600", Offset = "0xBFAA00", VA = "0x180BFB600", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockItem Clone()
			{
				return null;
			}

			[Token(Token = "0x60072B0")]
			[Address(RVA = "0xBFB690", Offset = "0xBFAA90", VA = "0x180BFB690", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60072B1")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(PaddockItem other)
			{
				return default(bool);
			}

			[Token(Token = "0x60072B2")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60072B3")]
			[Address(RVA = "0xBFB720", Offset = "0xBFAB20", VA = "0x180BFB720", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60072B4")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60072B5")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60072B6")]
			[Address(RVA = "0xBFB540", Offset = "0xBFA940", VA = "0x180BFB540", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60072B7")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(PaddockItem other)
			{
			}

			[Token(Token = "0x60072B8")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60072B9")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002821")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectInRolePlay> _parser;

	[Token(Token = "0x4002822")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002823")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x4002824")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x4002825")]
	public const int ObjectGidFieldNumber = 2;

	[Token(Token = "0x4002826")]
	[FieldOffset(Offset = "0x1C")]
	private int objectGid_;

	[Token(Token = "0x4002827")]
	public const int WithLookFieldNumber = 3;

	[Token(Token = "0x4002828")]
	public const int PaddockItemFieldNumber = 4;

	[Token(Token = "0x4002829")]
	[FieldOffset(Offset = "0x20")]
	private object complement_;

	[Token(Token = "0x400282A")]
	[FieldOffset(Offset = "0x28")]
	private ComplementOneofCase complementCase_;

	[Token(Token = "0x17001909")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectInRolePlay> Parser
	{
		[Token(Token = "0x6007271")]
		[Address(RVA = "0xBF84E0", Offset = "0xBF78E0", VA = "0x180BF84E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700190A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007272")]
		[Address(RVA = "0xBF83D0", Offset = "0xBF77D0", VA = "0x180BF83D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700190B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007273")]
		[Address(RVA = "0xBF88F0", Offset = "0xBF7CF0", VA = "0x180BF88F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700190C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x6007277")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007278")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700190D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x6007279")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600727A")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700190E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.WithLook WithLook
	{
		[Token(Token = "0x600727B")]
		[Address(RVA = "0xBF8530", Offset = "0xBF7930", VA = "0x180BF8530")]
		get
		{
			return null;
		}
		[Token(Token = "0x600727C")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x1700190F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PaddockItem PaddockItem
	{
		[Token(Token = "0x600727D")]
		[Address(RVA = "0xBF8480", Offset = "0xBF7880", VA = "0x180BF8480")]
		get
		{
			return null;
		}
		[Token(Token = "0x600727E")]
		[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
		set
		{
		}
	}

	[Token(Token = "0x17001910")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ComplementOneofCase ComplementCase
	{
		[Token(Token = "0x600727F")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(ComplementOneofCase);
		}
	}

	[Token(Token = "0x6007274")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectInRolePlay()
	{
	}

	[Token(Token = "0x6007275")]
	[Address(RVA = "0xBF8180", Offset = "0xBF7580", VA = "0x180BF8180")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectInRolePlay(ObjectInRolePlay other)
	{
	}

	[Token(Token = "0x6007276")]
	[Address(RVA = "0xBF79D0", Offset = "0xBF6DD0", VA = "0x180BF79D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectInRolePlay Clone()
	{
		return null;
	}

	[Token(Token = "0x6007280")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearComplement()
	{
	}

	[Token(Token = "0x6007281")]
	[Address(RVA = "0xBF7B10", Offset = "0xBF6F10", VA = "0x180BF7B10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007282")]
	[Address(RVA = "0xBF7A30", Offset = "0xBF6E30", VA = "0x180BF7A30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectInRolePlay other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007283")]
	[Address(RVA = "0xBF7C30", Offset = "0xBF7030", VA = "0x180BF7C30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007284")]
	[Address(RVA = "0xBF8020", Offset = "0xBF7420", VA = "0x180BF8020", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007285")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007286")]
	[Address(RVA = "0xBF87A0", Offset = "0xBF7BA0", VA = "0x180BF87A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007287")]
	[Address(RVA = "0xBF7840", Offset = "0xBF6C40", VA = "0x180BF7840", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007288")]
	[Address(RVA = "0xBF7D90", Offset = "0xBF7190", VA = "0x180BF7D90", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectInRolePlay other)
	{
	}

	[Token(Token = "0x6007289")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600728A")]
	[Address(RVA = "0xBF8590", Offset = "0xBF7990", VA = "0x180BF8590", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
