using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000999")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachBranch : IMessage<BreachBranch>, IMessage, IEquatable<BreachBranch>, IDeepCloneable<BreachBranch>, IBufferMessage
{
	[Token(Token = "0x200099A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200099B")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ExtendedBreachBranch : IMessage<ExtendedBreachBranch>, IMessage, IEquatable<ExtendedBreachBranch>, IDeepCloneable<ExtendedBreachBranch>, IBufferMessage
		{
			[Token(Token = "0x40021C0")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ExtendedBreachBranch> _parser;

			[Token(Token = "0x40021C1")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40021C2")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x40021C3")]
			public const int RewardsFieldNumber = 1;

			[Token(Token = "0x40021C4")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<BreachReward> _repeated_rewards_codec;

			[Token(Token = "0x40021C5")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<BreachReward> rewards_;

			[Token(Token = "0x40021C6")]
			public const int ModifierFieldNumber = 2;

			[Token(Token = "0x40021C7")]
			[FieldOffset(Offset = "0x28")]
			private int modifier_;

			[Token(Token = "0x40021C8")]
			public const int PriceFieldNumber = 3;

			[Token(Token = "0x40021C9")]
			[FieldOffset(Offset = "0x2C")]
			private int price_;

			[Token(Token = "0x40021CA")]
			public const int UnlockPriceFieldNumber = 4;

			[Token(Token = "0x40021CB")]
			[FieldOffset(Offset = "0x10")]
			private static readonly int UnlockPriceDefaultValue;

			[Token(Token = "0x40021CC")]
			[FieldOffset(Offset = "0x30")]
			private int unlockPrice_;

			[Token(Token = "0x17001557")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ExtendedBreachBranch> Parser
			{
				[Token(Token = "0x6006426")]
				[Address(RVA = "0xB99ED0", Offset = "0xB992D0", VA = "0x180B99ED0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001558")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006427")]
				[Address(RVA = "0xB99E50", Offset = "0xB99250", VA = "0x180B99E50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001559")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006428")]
				[Address(RVA = "0xB9A270", Offset = "0xB99670", VA = "0x180B9A270", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700155A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<BreachReward> Rewards
			{
				[Token(Token = "0x600642C")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700155B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Modifier
			{
				[Token(Token = "0x600642D")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600642E")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x1700155C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Price
			{
				[Token(Token = "0x600642F")]
				[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006430")]
				[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
				set
				{
				}
			}

			[Token(Token = "0x1700155D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int UnlockPrice
			{
				[Token(Token = "0x6006431")]
				[Address(RVA = "0xB99F20", Offset = "0xB99320", VA = "0x180B99F20")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006432")]
				[Address(RVA = "0xA4D370", Offset = "0xA4C770", VA = "0x180A4D370")]
				set
				{
				}
			}

			[Token(Token = "0x1700155E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasUnlockPrice
			{
				[Token(Token = "0x6006433")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6006429")]
			[Address(RVA = "0xB99D20", Offset = "0xB99120", VA = "0x180B99D20")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ExtendedBreachBranch()
			{
			}

			[Token(Token = "0x600642A")]
			[Address(RVA = "0xB99DA0", Offset = "0xB991A0", VA = "0x180B99DA0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExtendedBreachBranch(ExtendedBreachBranch other)
			{
			}

			[Token(Token = "0x600642B")]
			[Address(RVA = "0xB99690", Offset = "0xB98A90", VA = "0x180B99690", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExtendedBreachBranch Clone()
			{
				return null;
			}

			[Token(Token = "0x6006434")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearUnlockPrice()
			{
			}

			[Token(Token = "0x6006435")]
			[Address(RVA = "0xB99760", Offset = "0xB98B60", VA = "0x180B99760", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006436")]
			[Address(RVA = "0xB99870", Offset = "0xB98C70", VA = "0x180B99870", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ExtendedBreachBranch other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006437")]
			[Address(RVA = "0xB99940", Offset = "0xB98D40", VA = "0x180B99940", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006438")]
			[Address(RVA = "0xB99B00", Offset = "0xB98F00", VA = "0x180B99B00", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006439")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600643A")]
			[Address(RVA = "0xB9A100", Offset = "0xB99500", VA = "0x180B9A100", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600643B")]
			[Address(RVA = "0xB99500", Offset = "0xB98900", VA = "0x180B99500", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600643C")]
			[Address(RVA = "0xB99A50", Offset = "0xB98E50", VA = "0x180B99A50", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ExtendedBreachBranch other)
			{
			}

			[Token(Token = "0x600643D")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600643E")]
			[Address(RVA = "0xB99F90", Offset = "0xB99390", VA = "0x180B99F90", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40021AC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachBranch> _parser;

	[Token(Token = "0x40021AD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40021AE")]
	public const int RoomFieldNumber = 1;

	[Token(Token = "0x40021AF")]
	[FieldOffset(Offset = "0x18")]
	private int room_;

	[Token(Token = "0x40021B0")]
	public const int ElementFieldNumber = 2;

	[Token(Token = "0x40021B1")]
	[FieldOffset(Offset = "0x1C")]
	private int element_;

	[Token(Token = "0x40021B2")]
	public const int BossesFieldNumber = 3;

	[Token(Token = "0x40021B3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<MonsterInGroupInformation> _repeated_bosses_codec;

	[Token(Token = "0x40021B4")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<MonsterInGroupInformation> bosses_;

	[Token(Token = "0x40021B5")]
	public const int MapIdFieldNumber = 4;

	[Token(Token = "0x40021B6")]
	[FieldOffset(Offset = "0x28")]
	private long mapId_;

	[Token(Token = "0x40021B7")]
	public const int ScoreFieldNumber = 5;

	[Token(Token = "0x40021B8")]
	[FieldOffset(Offset = "0x30")]
	private int score_;

	[Token(Token = "0x40021B9")]
	public const int RelativeScoreFieldNumber = 6;

	[Token(Token = "0x40021BA")]
	[FieldOffset(Offset = "0x34")]
	private int relativeScore_;

	[Token(Token = "0x40021BB")]
	public const int MonstersFieldNumber = 7;

	[Token(Token = "0x40021BC")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<MonsterInGroupInformation> _repeated_monsters_codec;

	[Token(Token = "0x40021BD")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<MonsterInGroupInformation> monsters_;

	[Token(Token = "0x40021BE")]
	public const int ExtendedInformationFieldNumber = 8;

	[Token(Token = "0x40021BF")]
	[FieldOffset(Offset = "0x40")]
	private Types.ExtendedBreachBranch extendedInformation_;

	[Token(Token = "0x1700154C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachBranch> Parser
	{
		[Token(Token = "0x6006407")]
		[Address(RVA = "0xB8F960", Offset = "0xB8ED60", VA = "0x180B8F960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006408")]
		[Address(RVA = "0xB8F8B0", Offset = "0xB8ECB0", VA = "0x180B8F8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006409")]
		[Address(RVA = "0xB8FDF0", Offset = "0xB8F1F0", VA = "0x180B8FDF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Room
	{
		[Token(Token = "0x600640D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600640E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001550")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Element
	{
		[Token(Token = "0x600640F")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006410")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001551")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonsterInGroupInformation> Bosses
	{
		[Token(Token = "0x6006411")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001552")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x6006412")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006413")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17001553")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Score
	{
		[Token(Token = "0x6006414")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006415")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17001554")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RelativeScore
	{
		[Token(Token = "0x6006416")]
		[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006417")]
		[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
		set
		{
		}
	}

	[Token(Token = "0x17001555")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterInGroupInformation> Monsters
	{
		[Token(Token = "0x6006418")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001556")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ExtendedBreachBranch ExtendedInformation
	{
		[Token(Token = "0x6006419")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600641A")]
		[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
		set
		{
		}
	}

	[Token(Token = "0x600640A")]
	[Address(RVA = "0xB8F800", Offset = "0xB8EC00", VA = "0x180B8F800")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBranch()
	{
	}

	[Token(Token = "0x600640B")]
	[Address(RVA = "0xB8F640", Offset = "0xB8EA40", VA = "0x180B8F640")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBranch(BreachBranch other)
	{
	}

	[Token(Token = "0x600640C")]
	[Address(RVA = "0xB8EE00", Offset = "0xB8E200", VA = "0x180B8EE00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachBranch Clone()
	{
		return null;
	}

	[Token(Token = "0x600641B")]
	[Address(RVA = "0xB8EF60", Offset = "0xB8E360", VA = "0x180B8EF60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600641C")]
	[Address(RVA = "0xB8EE60", Offset = "0xB8E260", VA = "0x180B8EE60", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachBranch other)
	{
		return default(bool);
	}

	[Token(Token = "0x600641D")]
	[Address(RVA = "0xB8F0B0", Offset = "0xB8E4B0", VA = "0x180B8F0B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600641E")]
	[Address(RVA = "0xB8F3C0", Offset = "0xB8E7C0", VA = "0x180B8F3C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600641F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006420")]
	[Address(RVA = "0xB8FC20", Offset = "0xB8F020", VA = "0x180B8FC20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006421")]
	[Address(RVA = "0xB8EC00", Offset = "0xB8E000", VA = "0x180B8EC00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006422")]
	[Address(RVA = "0xB8F1E0", Offset = "0xB8E5E0", VA = "0x180B8F1E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachBranch other)
	{
	}

	[Token(Token = "0x6006423")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006424")]
	[Address(RVA = "0xB8F9B0", Offset = "0xB8EDB0", VA = "0x180B8F9B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
