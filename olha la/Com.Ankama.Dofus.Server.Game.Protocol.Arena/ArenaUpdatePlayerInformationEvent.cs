using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000B9A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaUpdatePlayerInformationEvent : IMessage<ArenaUpdatePlayerInformationEvent>, IMessage, IEquatable<ArenaUpdatePlayerInformationEvent>, IDeepCloneable<ArenaUpdatePlayerInformationEvent>, IBufferMessage
{
	[Token(Token = "0x2000B9B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000B9C")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ArenaRank : IMessage<ArenaRank>, IMessage, IEquatable<ArenaRank>, IDeepCloneable<ArenaRank>, IBufferMessage
		{
			[Token(Token = "0x2000B9D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000B9E")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class LeagueRanking : IMessage<LeagueRanking>, IMessage, IEquatable<LeagueRanking>, IDeepCloneable<LeagueRanking>, IBufferMessage
				{
					[Token(Token = "0x4002B5D")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<LeagueRanking> _parser;

					[Token(Token = "0x4002B5E")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002B5F")]
					public const int RatingFieldNumber = 1;

					[Token(Token = "0x4002B60")]
					[FieldOffset(Offset = "0x18")]
					private int rating_;

					[Token(Token = "0x4002B61")]
					public const int LeagueIdFieldNumber = 2;

					[Token(Token = "0x4002B62")]
					[FieldOffset(Offset = "0x1C")]
					private int leagueId_;

					[Token(Token = "0x4002B63")]
					public const int LadderPositionFieldNumber = 3;

					[Token(Token = "0x4002B64")]
					[FieldOffset(Offset = "0x20")]
					private int ladderPosition_;

					[Token(Token = "0x17001AE9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<LeagueRanking> Parser
					{
						[Token(Token = "0x6007A31")]
						[Address(RVA = "0xC37530", Offset = "0xC36930", VA = "0x180C37530")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001AEA")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007A32")]
						[Address(RVA = "0xC374B0", Offset = "0xC368B0", VA = "0x180C374B0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001AEB")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007A33")]
						[Address(RVA = "0xC37580", Offset = "0xC36980", VA = "0x180C37580", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001AEC")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int Rating
					{
						[Token(Token = "0x6007A37")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6007A38")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17001AED")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int LeagueId
					{
						[Token(Token = "0x6007A39")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6007A3A")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x17001AEE")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int LadderPosition
					{
						[Token(Token = "0x6007A3B")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6007A3C")]
						[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
						set
						{
						}
					}

					[Token(Token = "0x6007A34")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public LeagueRanking()
					{
					}

					[Token(Token = "0x6007A35")]
					[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public LeagueRanking(LeagueRanking other)
					{
					}

					[Token(Token = "0x6007A36")]
					[Address(RVA = "0xC37220", Offset = "0xC36620", VA = "0x180C37220", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public LeagueRanking Clone()
					{
						return null;
					}

					[Token(Token = "0x6007A3D")]
					[Address(RVA = "0xC372B0", Offset = "0xC366B0", VA = "0x180C372B0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007A3E")]
					[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(LeagueRanking other)
					{
						return default(bool);
					}

					[Token(Token = "0x6007A3F")]
					[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6007A40")]
					[Address(RVA = "0xC37350", Offset = "0xC36750", VA = "0x180C37350", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6007A41")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007A42")]
					[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007A43")]
					[Address(RVA = "0xC37140", Offset = "0xC36540", VA = "0x180C37140", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007A44")]
					[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(LeagueRanking other)
					{
					}

					[Token(Token = "0x6007A45")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007A46")]
					[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4002B49")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ArenaRank> _parser;

			[Token(Token = "0x4002B4A")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002B4B")]
			public const int ArenaTypeFieldNumber = 1;

			[Token(Token = "0x4002B4C")]
			[FieldOffset(Offset = "0x18")]
			private ArenaType arenaType_;

			[Token(Token = "0x4002B4D")]
			public const int LeagueRankingFieldNumber = 2;

			[Token(Token = "0x4002B4E")]
			[FieldOffset(Offset = "0x20")]
			private Types.LeagueRanking leagueRanking_;

			[Token(Token = "0x4002B4F")]
			public const int BestLeagueIdFieldNumber = 3;

			[Token(Token = "0x4002B50")]
			[FieldOffset(Offset = "0x28")]
			private int bestLeagueId_;

			[Token(Token = "0x4002B51")]
			public const int BestRatingFieldNumber = 4;

			[Token(Token = "0x4002B52")]
			[FieldOffset(Offset = "0x2C")]
			private int bestRating_;

			[Token(Token = "0x4002B53")]
			public const int DailyVictoryCountFieldNumber = 5;

			[Token(Token = "0x4002B54")]
			[FieldOffset(Offset = "0x30")]
			private int dailyVictoryCount_;

			[Token(Token = "0x4002B55")]
			public const int SeasonVictoryCountFieldNumber = 6;

			[Token(Token = "0x4002B56")]
			[FieldOffset(Offset = "0x34")]
			private int seasonVictoryCount_;

			[Token(Token = "0x4002B57")]
			public const int DailyFightCountFieldNumber = 7;

			[Token(Token = "0x4002B58")]
			[FieldOffset(Offset = "0x38")]
			private int dailyFightCount_;

			[Token(Token = "0x4002B59")]
			public const int SeasonFightCountFieldNumber = 8;

			[Token(Token = "0x4002B5A")]
			[FieldOffset(Offset = "0x3C")]
			private int seasonFightCount_;

			[Token(Token = "0x4002B5B")]
			public const int FightNeededForLadderFieldNumber = 9;

			[Token(Token = "0x4002B5C")]
			[FieldOffset(Offset = "0x40")]
			private int fightNeededForLadder_;

			[Token(Token = "0x17001ADD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ArenaRank> Parser
			{
				[Token(Token = "0x6007A0E")]
				[Address(RVA = "0xC31D20", Offset = "0xC31120", VA = "0x180C31D20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001ADE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007A0F")]
				[Address(RVA = "0xC31CA0", Offset = "0xC310A0", VA = "0x180C31CA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001ADF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007A10")]
				[Address(RVA = "0xC320C0", Offset = "0xC314C0", VA = "0x180C320C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001AE0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ArenaType ArenaType
			{
				[Token(Token = "0x6007A14")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(ArenaType);
				}
				[Token(Token = "0x6007A15")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17001AE1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.LeagueRanking LeagueRanking
			{
				[Token(Token = "0x6007A16")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007A17")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x17001AE2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int BestLeagueId
			{
				[Token(Token = "0x6007A18")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007A19")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x17001AE3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int BestRating
			{
				[Token(Token = "0x6007A1A")]
				[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007A1B")]
				[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
				set
				{
				}
			}

			[Token(Token = "0x17001AE4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int DailyVictoryCount
			{
				[Token(Token = "0x6007A1C")]
				[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007A1D")]
				[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
				set
				{
				}
			}

			[Token(Token = "0x17001AE5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SeasonVictoryCount
			{
				[Token(Token = "0x6007A1E")]
				[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007A1F")]
				[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
				set
				{
				}
			}

			[Token(Token = "0x17001AE6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int DailyFightCount
			{
				[Token(Token = "0x6007A20")]
				[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007A21")]
				[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
				set
				{
				}
			}

			[Token(Token = "0x17001AE7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SeasonFightCount
			{
				[Token(Token = "0x6007A22")]
				[Address(RVA = "0x946B90", Offset = "0x945F90", VA = "0x180946B90")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007A23")]
				[Address(RVA = "0x9470F0", Offset = "0x9464F0", VA = "0x1809470F0")]
				set
				{
				}
			}

			[Token(Token = "0x17001AE8")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int FightNeededForLadder
			{
				[Token(Token = "0x6007A24")]
				[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6007A25")]
				[Address(RVA = "0x9F30F0", Offset = "0x9F24F0", VA = "0x1809F30F0")]
				set
				{
				}
			}

			[Token(Token = "0x6007A11")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ArenaRank()
			{
			}

			[Token(Token = "0x6007A12")]
			[Address(RVA = "0xC31B90", Offset = "0xC30F90", VA = "0x180C31B90")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ArenaRank(ArenaRank other)
			{
			}

			[Token(Token = "0x6007A13")]
			[Address(RVA = "0xC314B0", Offset = "0xC308B0", VA = "0x180C314B0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ArenaRank Clone()
			{
				return null;
			}

			[Token(Token = "0x6007A26")]
			[Address(RVA = "0xC316A0", Offset = "0xC30AA0", VA = "0x180C316A0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007A27")]
			[Address(RVA = "0xC315F0", Offset = "0xC309F0", VA = "0x180C315F0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ArenaRank other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007A28")]
			[Address(RVA = "0xC31790", Offset = "0xC30B90", VA = "0x180C31790", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007A29")]
			[Address(RVA = "0xC31A30", Offset = "0xC30E30", VA = "0x180C31A30", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007A2A")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007A2B")]
			[Address(RVA = "0xC31F60", Offset = "0xC31360", VA = "0x180C31F60", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007A2C")]
			[Address(RVA = "0xC312D0", Offset = "0xC306D0", VA = "0x180C312D0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6007A2D")]
			[Address(RVA = "0xC318D0", Offset = "0xC30CD0", VA = "0x180C318D0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(ArenaRank other)
			{
			}

			[Token(Token = "0x6007A2E")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6007A2F")]
			[Address(RVA = "0xC31D70", Offset = "0xC31170", VA = "0x180C31D70", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002B42")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaUpdatePlayerInformationEvent> _parser;

	[Token(Token = "0x4002B43")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B44")]
	public const int ArenaRanksFieldNumber = 1;

	[Token(Token = "0x4002B45")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.ArenaRank> _repeated_arenaRanks_codec;

	[Token(Token = "0x4002B46")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.ArenaRank> arenaRanks_;

	[Token(Token = "0x4002B47")]
	public const int BanEndDateFieldNumber = 2;

	[Token(Token = "0x4002B48")]
	[FieldOffset(Offset = "0x20")]
	private string banEndDate_;

	[Token(Token = "0x17001AD8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaUpdatePlayerInformationEvent> Parser
	{
		[Token(Token = "0x60079FA")]
		[Address(RVA = "0xC350B0", Offset = "0xC344B0", VA = "0x180C350B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AD9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60079FB")]
		[Address(RVA = "0xC35000", Offset = "0xC34400", VA = "0x180C35000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ADA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60079FC")]
		[Address(RVA = "0xC35330", Offset = "0xC34730", VA = "0x180C35330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ADB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.ArenaRank> ArenaRanks
	{
		[Token(Token = "0x6007A00")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ADC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BanEndDate
	{
		[Token(Token = "0x6007A01")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007A02")]
		[Address(RVA = "0xC35370", Offset = "0xC34770", VA = "0x180C35370")]
		set
		{
		}
	}

	[Token(Token = "0x60079FD")]
	[Address(RVA = "0xC34F60", Offset = "0xC34360", VA = "0x180C34F60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaUpdatePlayerInformationEvent()
	{
	}

	[Token(Token = "0x60079FE")]
	[Address(RVA = "0xC34EC0", Offset = "0xC342C0", VA = "0x180C34EC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaUpdatePlayerInformationEvent(ArenaUpdatePlayerInformationEvent other)
	{
	}

	[Token(Token = "0x60079FF")]
	[Address(RVA = "0xC34920", Offset = "0xC33D20", VA = "0x180C34920", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaUpdatePlayerInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007A03")]
	[Address(RVA = "0xC34AA0", Offset = "0xC33EA0", VA = "0x180C34AA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A04")]
	[Address(RVA = "0xC349F0", Offset = "0xC33DF0", VA = "0x180C349F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaUpdatePlayerInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007A05")]
	[Address(RVA = "0xC34B90", Offset = "0xC33F90", VA = "0x180C34B90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007A06")]
	[Address(RVA = "0xC34CC0", Offset = "0xC340C0", VA = "0x180C34CC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007A07")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007A08")]
	[Address(RVA = "0xC35250", Offset = "0xC34650", VA = "0x180C35250", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007A09")]
	[Address(RVA = "0xC34830", Offset = "0xC33C30", VA = "0x180C34830", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007A0A")]
	[Address(RVA = "0xC34C20", Offset = "0xC34020", VA = "0x180C34C20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaUpdatePlayerInformationEvent other)
	{
	}

	[Token(Token = "0x6007A0B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007A0C")]
	[Address(RVA = "0xC35100", Offset = "0xC34500", VA = "0x180C35100", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
