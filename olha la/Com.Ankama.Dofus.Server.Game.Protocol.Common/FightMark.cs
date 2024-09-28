using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A4D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightMark : IMessage<FightMark>, IMessage, IEquatable<FightMark>, IDeepCloneable<FightMark>, IBufferMessage
{
	[Token(Token = "0x2000A4E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000A4F")]
		public enum MarkType
		{
			[Token(Token = "0x4002549")]
			[OriginalName("GLYPH")]
			Glyph,
			[Token(Token = "0x400254A")]
			[OriginalName("TRAP")]
			Trap,
			[Token(Token = "0x400254B")]
			[OriginalName("WALL")]
			Wall,
			[Token(Token = "0x400254C")]
			[OriginalName("PORTAL")]
			Portal,
			[Token(Token = "0x400254D")]
			[OriginalName("RUNE")]
			Rune
		}

		[Token(Token = "0x2000A50")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class MarkedCell : IMessage<MarkedCell>, IMessage, IEquatable<MarkedCell>, IDeepCloneable<MarkedCell>, IBufferMessage
		{
			[Token(Token = "0x2000A51")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000A52")]
				public enum MarkCellsType
				{
					[Token(Token = "0x4002559")]
					[OriginalName("CELLS_CIRCLE")]
					CellsCircle,
					[Token(Token = "0x400255A")]
					[OriginalName("CELLS_CROSS")]
					CellsCross,
					[Token(Token = "0x400255B")]
					[OriginalName("CELLS_SQUARE")]
					CellsSquare
				}
			}

			[Token(Token = "0x400254E")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<MarkedCell> _parser;

			[Token(Token = "0x400254F")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002550")]
			public const int IdFieldNumber = 1;

			[Token(Token = "0x4002551")]
			[FieldOffset(Offset = "0x18")]
			private int id_;

			[Token(Token = "0x4002552")]
			public const int ZoneSizeFieldNumber = 2;

			[Token(Token = "0x4002553")]
			[FieldOffset(Offset = "0x1C")]
			private int zoneSize_;

			[Token(Token = "0x4002554")]
			public const int ColorFieldNumber = 3;

			[Token(Token = "0x4002555")]
			[FieldOffset(Offset = "0x20")]
			private int color_;

			[Token(Token = "0x4002556")]
			public const int CellsTypeFieldNumber = 4;

			[Token(Token = "0x4002557")]
			[FieldOffset(Offset = "0x24")]
			private Types.MarkCellsType cellsType_;

			[Token(Token = "0x1700175B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<MarkedCell> Parser
			{
				[Token(Token = "0x6006BDD")]
				[Address(RVA = "0xBD6390", Offset = "0xBD5790", VA = "0x180BD6390")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700175C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006BDE")]
				[Address(RVA = "0xBD6310", Offset = "0xBD5710", VA = "0x180BD6310")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700175D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006BDF")]
				[Address(RVA = "0xBD63E0", Offset = "0xBD57E0", VA = "0x180BD63E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700175E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Id
			{
				[Token(Token = "0x6006BE3")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006BE4")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x1700175F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ZoneSize
			{
				[Token(Token = "0x6006BE5")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006BE6")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17001760")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Color
			{
				[Token(Token = "0x6006BE7")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006BE8")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17001761")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.MarkCellsType CellsType
			{
				[Token(Token = "0x6006BE9")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(Types.MarkCellsType);
				}
				[Token(Token = "0x6006BEA")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x6006BE0")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MarkedCell()
			{
			}

			[Token(Token = "0x6006BE1")]
			[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MarkedCell(MarkedCell other)
			{
			}

			[Token(Token = "0x6006BE2")]
			[Address(RVA = "0xBD6080", Offset = "0xBD5480", VA = "0x180BD6080", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MarkedCell Clone()
			{
				return null;
			}

			[Token(Token = "0x6006BEB")]
			[Address(RVA = "0xBD6110", Offset = "0xBD5510", VA = "0x180BD6110", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006BEC")]
			[Address(RVA = "0xBA0E80", Offset = "0xBA0280", VA = "0x180BA0E80", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(MarkedCell other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006BED")]
			[Address(RVA = "0xBA0EC0", Offset = "0xBA02C0", VA = "0x180BA0EC0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006BEE")]
			[Address(RVA = "0xBD61B0", Offset = "0xBD55B0", VA = "0x180BD61B0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006BEF")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006BF0")]
			[Address(RVA = "0xBA1320", Offset = "0xBA0720", VA = "0x180BA1320", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006BF1")]
			[Address(RVA = "0xBD5F70", Offset = "0xBD5370", VA = "0x180BD5F70", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006BF2")]
			[Address(RVA = "0xBA0F80", Offset = "0xBA0380", VA = "0x180BA0F80", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(MarkedCell other)
			{
			}

			[Token(Token = "0x6006BF3")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006BF4")]
			[Address(RVA = "0xBA1220", Offset = "0xBA0620", VA = "0x180BA1220", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002533")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightMark> _parser;

	[Token(Token = "0x4002534")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002535")]
	public const int AuthorIdFieldNumber = 1;

	[Token(Token = "0x4002536")]
	[FieldOffset(Offset = "0x18")]
	private long authorId_;

	[Token(Token = "0x4002537")]
	public const int TeamFieldNumber = 2;

	[Token(Token = "0x4002538")]
	[FieldOffset(Offset = "0x20")]
	private Team team_;

	[Token(Token = "0x4002539")]
	public const int SpellIdFieldNumber = 3;

	[Token(Token = "0x400253A")]
	[FieldOffset(Offset = "0x24")]
	private int spellId_;

	[Token(Token = "0x400253B")]
	public const int SpellLevelFieldNumber = 4;

	[Token(Token = "0x400253C")]
	[FieldOffset(Offset = "0x28")]
	private int spellLevel_;

	[Token(Token = "0x400253D")]
	public const int MarkIdFieldNumber = 5;

	[Token(Token = "0x400253E")]
	[FieldOffset(Offset = "0x2C")]
	private int markId_;

	[Token(Token = "0x400253F")]
	public const int MarkTypeFieldNumber = 6;

	[Token(Token = "0x4002540")]
	[FieldOffset(Offset = "0x30")]
	private Types.MarkType markType_;

	[Token(Token = "0x4002541")]
	public const int MarkImpactCellFieldNumber = 7;

	[Token(Token = "0x4002542")]
	[FieldOffset(Offset = "0x34")]
	private int markImpactCell_;

	[Token(Token = "0x4002543")]
	public const int CellsFieldNumber = 8;

	[Token(Token = "0x4002544")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.MarkedCell> _repeated_cells_codec;

	[Token(Token = "0x4002545")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<Types.MarkedCell> cells_;

	[Token(Token = "0x4002546")]
	public const int ActiveFieldNumber = 9;

	[Token(Token = "0x4002547")]
	[FieldOffset(Offset = "0x40")]
	private bool active_;

	[Token(Token = "0x1700174F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightMark> Parser
	{
		[Token(Token = "0x6006BBB")]
		[Address(RVA = "0xBCB290", Offset = "0xBCA690", VA = "0x180BCB290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001750")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006BBC")]
		[Address(RVA = "0xBCB1E0", Offset = "0xBCA5E0", VA = "0x180BCB1E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001751")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006BBD")]
		[Address(RVA = "0xBCB6B0", Offset = "0xBCAAB0", VA = "0x180BCB6B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001752")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long AuthorId
	{
		[Token(Token = "0x6006BC1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006BC2")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001753")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Team Team
	{
		[Token(Token = "0x6006BC3")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x6006BC4")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001754")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BC6")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001755")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellLevel
	{
		[Token(Token = "0x6006BC7")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BC8")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001756")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MarkId
	{
		[Token(Token = "0x6006BC9")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BCA")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x17001757")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.MarkType MarkType
	{
		[Token(Token = "0x6006BCB")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(Types.MarkType);
		}
		[Token(Token = "0x6006BCC")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17001758")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MarkImpactCell
	{
		[Token(Token = "0x6006BCD")]
		[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BCE")]
		[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
		set
		{
		}
	}

	[Token(Token = "0x17001759")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.MarkedCell> Cells
	{
		[Token(Token = "0x6006BCF")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700175A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Active
	{
		[Token(Token = "0x6006BD0")]
		[Address(RVA = "0x871BC0", Offset = "0x870FC0", VA = "0x180871BC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006BD1")]
		[Address(RVA = "0x96EC00", Offset = "0x96E000", VA = "0x18096EC00")]
		set
		{
		}
	}

	[Token(Token = "0x6006BBE")]
	[Address(RVA = "0xBCB0A0", Offset = "0xBCA4A0", VA = "0x180BCB0A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightMark()
	{
	}

	[Token(Token = "0x6006BBF")]
	[Address(RVA = "0xBCB120", Offset = "0xBCA520", VA = "0x180BCB120")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightMark(FightMark other)
	{
	}

	[Token(Token = "0x6006BC0")]
	[Address(RVA = "0xBCA940", Offset = "0xBC9D40", VA = "0x180BCA940", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightMark Clone()
	{
		return null;
	}

	[Token(Token = "0x6006BD2")]
	[Address(RVA = "0xBCAA30", Offset = "0xBC9E30", VA = "0x180BCAA30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006BD3")]
	[Address(RVA = "0xBCAB60", Offset = "0xBC9F60", VA = "0x180BCAB60", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightMark other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006BD4")]
	[Address(RVA = "0xBCAC40", Offset = "0xBCA040", VA = "0x180BCAC40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006BD5")]
	[Address(RVA = "0xBCAEA0", Offset = "0xBCA2A0", VA = "0x180BCAEA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006BD6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006BD7")]
	[Address(RVA = "0xBCB4F0", Offset = "0xBCA8F0", VA = "0x180BCB4F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006BD8")]
	[Address(RVA = "0xBCA750", Offset = "0xBC9B50", VA = "0x180BCA750", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006BD9")]
	[Address(RVA = "0xBCADC0", Offset = "0xBCA1C0", VA = "0x180BCADC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightMark other)
	{
	}

	[Token(Token = "0x6006BDA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006BDB")]
	[Address(RVA = "0xBCB2E0", Offset = "0xBCA6E0", VA = "0x180BCB2E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
