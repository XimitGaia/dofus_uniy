using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x2000804")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendInformation : IMessage<FriendInformation>, IMessage, IEquatable<FriendInformation>, IDeepCloneable<FriendInformation>, IBufferMessage
{
	[Token(Token = "0x2000805")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000806")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class FriendOnlineInformation : IMessage<FriendOnlineInformation>, IMessage, IEquatable<FriendOnlineInformation>, IDeepCloneable<FriendOnlineInformation>, IBufferMessage
		{
			[Token(Token = "0x4001BB4")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<FriendOnlineInformation> _parser;

			[Token(Token = "0x4001BB5")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001BB6")]
			public const int CharacterIdFieldNumber = 1;

			[Token(Token = "0x4001BB7")]
			[FieldOffset(Offset = "0x18")]
			private long characterId_;

			[Token(Token = "0x4001BB8")]
			public const int CharacterNameFieldNumber = 2;

			[Token(Token = "0x4001BB9")]
			[FieldOffset(Offset = "0x20")]
			private string characterName_;

			[Token(Token = "0x4001BBA")]
			public const int CharacterLevelFieldNumber = 3;

			[Token(Token = "0x4001BBB")]
			[FieldOffset(Offset = "0x28")]
			private int characterLevel_;

			[Token(Token = "0x4001BBC")]
			public const int AlignmentFieldNumber = 4;

			[Token(Token = "0x4001BBD")]
			[FieldOffset(Offset = "0x2C")]
			private Alignment alignment_;

			[Token(Token = "0x4001BBE")]
			public const int BreedIdFieldNumber = 5;

			[Token(Token = "0x4001BBF")]
			[FieldOffset(Offset = "0x30")]
			private int breedId_;

			[Token(Token = "0x4001BC0")]
			public const int GenderFieldNumber = 6;

			[Token(Token = "0x4001BC1")]
			[FieldOffset(Offset = "0x34")]
			private Gender gender_;

			[Token(Token = "0x4001BC2")]
			public const int MoodSmileyIdFieldNumber = 7;

			[Token(Token = "0x4001BC3")]
			[FieldOffset(Offset = "0x38")]
			private int moodSmileyId_;

			[Token(Token = "0x4001BC4")]
			public const int HavenBagSharedFieldNumber = 8;

			[Token(Token = "0x4001BC5")]
			[FieldOffset(Offset = "0x3C")]
			private bool havenBagShared_;

			[Token(Token = "0x4001BC6")]
			public const int StatusFieldNumber = 9;

			[Token(Token = "0x4001BC7")]
			[FieldOffset(Offset = "0x40")]
			private CharacterStatus status_;

			[Token(Token = "0x4001BC8")]
			public const int GuildFieldNumber = 10;

			[Token(Token = "0x4001BC9")]
			[FieldOffset(Offset = "0x48")]
			private GuildInformation guild_;

			[Token(Token = "0x17001221")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<FriendOnlineInformation> Parser
			{
				[Token(Token = "0x600552E")]
				[Address(RVA = "0xAF1480", Offset = "0xAF0880", VA = "0x180AF1480")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001222")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600552F")]
				[Address(RVA = "0xAF13F0", Offset = "0xAF07F0", VA = "0x180AF13F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001223")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6005530")]
				[Address(RVA = "0xAF18E0", Offset = "0xAF0CE0", VA = "0x180AF18E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001224")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long CharacterId
			{
				[Token(Token = "0x6005534")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6005535")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17001225")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string CharacterName
			{
				[Token(Token = "0x6005536")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005537")]
				[Address(RVA = "0xAF1990", Offset = "0xAF0D90", VA = "0x180AF1990")]
				set
				{
				}
			}

			[Token(Token = "0x17001226")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CharacterLevel
			{
				[Token(Token = "0x6005538")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6005539")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x17001227")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Alignment Alignment
			{
				[Token(Token = "0x600553A")]
				[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
				get
				{
					return default(Alignment);
				}
				[Token(Token = "0x600553B")]
				[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
				set
				{
				}
			}

			[Token(Token = "0x17001228")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int BreedId
			{
				[Token(Token = "0x600553C")]
				[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600553D")]
				[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
				set
				{
				}
			}

			[Token(Token = "0x17001229")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Gender Gender
			{
				[Token(Token = "0x600553E")]
				[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
				get
				{
					return default(Gender);
				}
				[Token(Token = "0x600553F")]
				[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
				set
				{
				}
			}

			[Token(Token = "0x1700122A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MoodSmileyId
			{
				[Token(Token = "0x6005540")]
				[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6005541")]
				[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
				set
				{
				}
			}

			[Token(Token = "0x1700122B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HavenBagShared
			{
				[Token(Token = "0x6005542")]
				[Address(RVA = "0xAF1470", Offset = "0xAF0870", VA = "0x180AF1470")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6005543")]
				[Address(RVA = "0xAF1A00", Offset = "0xAF0E00", VA = "0x180AF1A00")]
				set
				{
				}
			}

			[Token(Token = "0x1700122C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public CharacterStatus Status
			{
				[Token(Token = "0x6005544")]
				[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005545")]
				[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
				set
				{
				}
			}

			[Token(Token = "0x1700122D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public GuildInformation Guild
			{
				[Token(Token = "0x6005546")]
				[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
				get
				{
					return null;
				}
				[Token(Token = "0x6005547")]
				[Address(RVA = "0x92EFD0", Offset = "0x92E3D0", VA = "0x18092EFD0")]
				set
				{
				}
			}

			[Token(Token = "0x6005531")]
			[Address(RVA = "0xAF13A0", Offset = "0xAF07A0", VA = "0x180AF13A0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FriendOnlineInformation()
			{
			}

			[Token(Token = "0x6005532")]
			[Address(RVA = "0xAF1280", Offset = "0xAF0680", VA = "0x180AF1280")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FriendOnlineInformation(FriendOnlineInformation other)
			{
			}

			[Token(Token = "0x6005533")]
			[Address(RVA = "0xAF0A90", Offset = "0xAEFE90", VA = "0x180AF0A90", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FriendOnlineInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x6005548")]
			[Address(RVA = "0xAF0BD0", Offset = "0xAEFFD0", VA = "0x180AF0BD0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6005549")]
			[Address(RVA = "0xAF0D00", Offset = "0xAF0100", VA = "0x180AF0D00", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(FriendOnlineInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x600554A")]
			[Address(RVA = "0xAF0DE0", Offset = "0xAF01E0", VA = "0x180AF0DE0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600554B")]
			[Address(RVA = "0xAF1120", Offset = "0xAF0520", VA = "0x180AF1120", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600554C")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600554D")]
			[Address(RVA = "0xAF1740", Offset = "0xAF0B40", VA = "0x180AF1740", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600554E")]
			[Address(RVA = "0xAF08A0", Offset = "0xAEFCA0", VA = "0x180AF08A0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600554F")]
			[Address(RVA = "0xAF0F90", Offset = "0xAF0390", VA = "0x180AF0F90", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(FriendOnlineInformation other)
			{
			}

			[Token(Token = "0x6005550")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6005551")]
			[Address(RVA = "0xAF14D0", Offset = "0xAF08D0", VA = "0x180AF14D0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001B9D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendInformation> _parser;

	[Token(Token = "0x4001B9E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B9F")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4001BA0")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x4001BA1")]
	[FieldOffset(Offset = "0x20")]
	private long accountId_;

	[Token(Token = "0x4001BA2")]
	public const int AccountTagFieldNumber = 2;

	[Token(Token = "0x4001BA3")]
	[FieldOffset(Offset = "0x28")]
	private AccountTag accountTag_;

	[Token(Token = "0x4001BA4")]
	public const int StateFieldNumber = 3;

	[Token(Token = "0x4001BA5")]
	[FieldOffset(Offset = "0x30")]
	private CharacterState state_;

	[Token(Token = "0x4001BA6")]
	public const int DurationSinceLastConnectionHoursFieldNumber = 4;

	[Token(Token = "0x4001BA7")]
	[FieldOffset(Offset = "0x8")]
	private static readonly long DurationSinceLastConnectionHoursDefaultValue;

	[Token(Token = "0x4001BA8")]
	[FieldOffset(Offset = "0x38")]
	private long durationSinceLastConnectionHours_;

	[Token(Token = "0x4001BA9")]
	public const int AchievementPointsFieldNumber = 5;

	[Token(Token = "0x4001BAA")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int AchievementPointsDefaultValue;

	[Token(Token = "0x4001BAB")]
	[FieldOffset(Offset = "0x40")]
	private int achievementPoints_;

	[Token(Token = "0x4001BAC")]
	public const int LeagueIdFieldNumber = 6;

	[Token(Token = "0x4001BAD")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int LeagueIdDefaultValue;

	[Token(Token = "0x4001BAE")]
	[FieldOffset(Offset = "0x44")]
	private int leagueId_;

	[Token(Token = "0x4001BAF")]
	public const int LadderPositionFieldNumber = 7;

	[Token(Token = "0x4001BB0")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int LadderPositionDefaultValue;

	[Token(Token = "0x4001BB1")]
	[FieldOffset(Offset = "0x48")]
	private int ladderPosition_;

	[Token(Token = "0x4001BB2")]
	public const int OnlineInformationFieldNumber = 8;

	[Token(Token = "0x4001BB3")]
	[FieldOffset(Offset = "0x50")]
	private Types.FriendOnlineInformation onlineInformation_;

	[Token(Token = "0x17001212")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendInformation> Parser
	{
		[Token(Token = "0x6005505")]
		[Address(RVA = "0xAEF4F0", Offset = "0xAEE8F0", VA = "0x180AEF4F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001213")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005506")]
		[Address(RVA = "0xAEF2C0", Offset = "0xAEE6C0", VA = "0x180AEF2C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001214")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005507")]
		[Address(RVA = "0xAEF9E0", Offset = "0xAEEDE0", VA = "0x180AEF9E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001215")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long AccountId
	{
		[Token(Token = "0x600550B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600550C")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001216")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountTag AccountTag
	{
		[Token(Token = "0x600550D")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600550E")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x17001217")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterState State
	{
		[Token(Token = "0x600550F")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(CharacterState);
		}
		[Token(Token = "0x6005510")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17001218")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long DurationSinceLastConnectionHours
	{
		[Token(Token = "0x6005511")]
		[Address(RVA = "0xAEF370", Offset = "0xAEE770", VA = "0x180AEF370")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005512")]
		[Address(RVA = "0xAEFA30", Offset = "0xAEEE30", VA = "0x180AEFA30")]
		set
		{
		}
	}

	[Token(Token = "0x17001219")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDurationSinceLastConnectionHours
	{
		[Token(Token = "0x6005513")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700121A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AchievementPoints
	{
		[Token(Token = "0x6005515")]
		[Address(RVA = "0xAEF250", Offset = "0xAEE650", VA = "0x180AEF250")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005516")]
		[Address(RVA = "0xAEFA20", Offset = "0xAEEE20", VA = "0x180AEFA20")]
		set
		{
		}
	}

	[Token(Token = "0x1700121B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasAchievementPoints
	{
		[Token(Token = "0x6005517")]
		[Address(RVA = "0xAEF3E0", Offset = "0xAEE7E0", VA = "0x180AEF3E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700121C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LeagueId
	{
		[Token(Token = "0x6005519")]
		[Address(RVA = "0xAEF480", Offset = "0xAEE880", VA = "0x180AEF480")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600551A")]
		[Address(RVA = "0xAEFA50", Offset = "0xAEEE50", VA = "0x180AEFA50")]
		set
		{
		}
	}

	[Token(Token = "0x1700121D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasLeagueId
	{
		[Token(Token = "0x600551B")]
		[Address(RVA = "0xAEF400", Offset = "0xAEE800", VA = "0x180AEF400")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700121E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LadderPosition
	{
		[Token(Token = "0x600551D")]
		[Address(RVA = "0xAEF410", Offset = "0xAEE810", VA = "0x180AEF410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600551E")]
		[Address(RVA = "0xAEFA40", Offset = "0xAEEE40", VA = "0x180AEFA40")]
		set
		{
		}
	}

	[Token(Token = "0x1700121F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLadderPosition
	{
		[Token(Token = "0x600551F")]
		[Address(RVA = "0xAEF3F0", Offset = "0xAEE7F0", VA = "0x180AEF3F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.FriendOnlineInformation OnlineInformation
	{
		[Token(Token = "0x6005521")]
		[Address(RVA = "0x87D8B0", Offset = "0x87CCB0", VA = "0x18087D8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005522")]
		[Address(RVA = "0x912500", Offset = "0x911900", VA = "0x180912500")]
		set
		{
		}
	}

	[Token(Token = "0x6005508")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendInformation()
	{
	}

	[Token(Token = "0x6005509")]
	[Address(RVA = "0xAEF050", Offset = "0xAEE450", VA = "0x180AEF050")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendInformation(FriendInformation other)
	{
	}

	[Token(Token = "0x600550A")]
	[Address(RVA = "0xAEE7C0", Offset = "0xAEDBC0", VA = "0x180AEE7C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6005514")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearDurationSinceLastConnectionHours()
	{
	}

	[Token(Token = "0x6005518")]
	[Address(RVA = "0xAEE790", Offset = "0xAEDB90", VA = "0x180AEE790")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearAchievementPoints()
	{
	}

	[Token(Token = "0x600551C")]
	[Address(RVA = "0xAEE7B0", Offset = "0xAEDBB0", VA = "0x180AEE7B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearLeagueId()
	{
	}

	[Token(Token = "0x6005520")]
	[Address(RVA = "0xAEE7A0", Offset = "0xAEDBA0", VA = "0x180AEE7A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearLadderPosition()
	{
	}

	[Token(Token = "0x6005523")]
	[Address(RVA = "0xAEE940", Offset = "0xAEDD40", VA = "0x180AEE940", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005524")]
	[Address(RVA = "0xAEE820", Offset = "0xAEDC20", VA = "0x180AEE820", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FriendInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005525")]
	[Address(RVA = "0xAEEAA0", Offset = "0xAEDEA0", VA = "0x180AEEAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005526")]
	[Address(RVA = "0xAEEEB0", Offset = "0xAEE2B0", VA = "0x180AEEEB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005527")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005528")]
	[Address(RVA = "0xAEF760", Offset = "0xAEEB60", VA = "0x180AEF760", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005529")]
	[Address(RVA = "0xAEE490", Offset = "0xAED890", VA = "0x180AEE490", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600552A")]
	[Address(RVA = "0xAEED10", Offset = "0xAEE110", VA = "0x180AEED10", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FriendInformation other)
	{
	}

	[Token(Token = "0x600552B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600552C")]
	[Address(RVA = "0xAEF540", Offset = "0xAEE940", VA = "0x180AEF540", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
