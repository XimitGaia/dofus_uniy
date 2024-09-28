using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x200012B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpouseInformationEvent : IMessage<SpouseInformationEvent>, IMessage, IEquatable<SpouseInformationEvent>, IDeepCloneable<SpouseInformationEvent>, IBufferMessage
{
	[Token(Token = "0x200012C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200012D")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Online : IMessage<Online>, IMessage, IEquatable<Online>, IDeepCloneable<Online>, IBufferMessage
		{
			[Token(Token = "0x4000409")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Online> _parser;

			[Token(Token = "0x400040A")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400040B")]
			public const int MapIdFieldNumber = 1;

			[Token(Token = "0x400040C")]
			[FieldOffset(Offset = "0x18")]
			private long mapId_;

			[Token(Token = "0x400040D")]
			public const int SubAreaIdFieldNumber = 2;

			[Token(Token = "0x400040E")]
			[FieldOffset(Offset = "0x20")]
			private int subAreaId_;

			[Token(Token = "0x400040F")]
			public const int AreaIdFieldNumber = 3;

			[Token(Token = "0x4000410")]
			[FieldOffset(Offset = "0x24")]
			private int areaId_;

			[Token(Token = "0x4000411")]
			public const int InFightFieldNumber = 4;

			[Token(Token = "0x4000412")]
			[FieldOffset(Offset = "0x28")]
			private bool inFight_;

			[Token(Token = "0x4000413")]
			public const int FollowingFieldNumber = 5;

			[Token(Token = "0x4000414")]
			[FieldOffset(Offset = "0x29")]
			private bool following_;

			[Token(Token = "0x1700027E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Online> Parser
			{
				[Token(Token = "0x6000BA7")]
				[Address(RVA = "0xB68C00", Offset = "0xB68000", VA = "0x180B68C00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700027F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6000BA8")]
				[Address(RVA = "0xB68B80", Offset = "0xB67F80", VA = "0x180B68B80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000280")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6000BA9")]
				[Address(RVA = "0xB68E50", Offset = "0xB68250", VA = "0x180B68E50", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000281")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long MapId
			{
				[Token(Token = "0x6000BAD")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000BAE")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000282")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SubAreaId
			{
				[Token(Token = "0x6000BAF")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000BB0")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17000283")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int AreaId
			{
				[Token(Token = "0x6000BB1")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000BB2")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x17000284")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool InFight
			{
				[Token(Token = "0x6000BB3")]
				[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BB4")]
				[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
				set
				{
				}
			}

			[Token(Token = "0x17000285")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Following
			{
				[Token(Token = "0x6000BB5")]
				[Address(RVA = "0x9A1B80", Offset = "0x9A0F80", VA = "0x1809A1B80")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BB6")]
				[Address(RVA = "0x9A1E90", Offset = "0x9A1290", VA = "0x1809A1E90")]
				set
				{
				}
			}

			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Online()
			{
			}

			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0xB68B10", Offset = "0xB67F10", VA = "0x180B68B10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Online(Online other)
			{
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0xB68660", Offset = "0xB67A60", VA = "0x180B68660", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Online Clone()
			{
				return null;
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0xB68700", Offset = "0xB67B00", VA = "0x180B68700", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0xB687B0", Offset = "0xB67BB0", VA = "0x180B687B0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Online other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0xB68800", Offset = "0xB67C00", VA = "0x180B68800", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0xB689B0", Offset = "0xB67DB0", VA = "0x180B689B0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0xB68D70", Offset = "0xB68170", VA = "0x180B68D70", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0xB68560", Offset = "0xB67960", VA = "0x180B68560", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0xB68930", Offset = "0xB67D30", VA = "0x180B68930", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Online other)
			{
			}

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0xB68C50", Offset = "0xB68050", VA = "0x180B68C50", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpouseInformationEvent> _parser;

	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003F3")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x18")]
	private long accountId_;

	[Token(Token = "0x40003F5")]
	public const int CharacterIdFieldNumber = 2;

	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x20")]
	private long characterId_;

	[Token(Token = "0x40003F7")]
	public const int CharacterNameFieldNumber = 3;

	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x28")]
	private string characterName_;

	[Token(Token = "0x40003F9")]
	public const int CharacterLevelFieldNumber = 4;

	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x30")]
	private int characterLevel_;

	[Token(Token = "0x40003FB")]
	public const int BreedIdFieldNumber = 5;

	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x34")]
	private int breedId_;

	[Token(Token = "0x40003FD")]
	public const int GenderFieldNumber = 6;

	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x38")]
	private Gender gender_;

	[Token(Token = "0x40003FF")]
	public const int GuildFieldNumber = 7;

	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x40")]
	private GuildInformation guild_;

	[Token(Token = "0x4000401")]
	public const int AllianceFieldNumber = 8;

	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x48")]
	private AllianceInformation alliance_;

	[Token(Token = "0x4000403")]
	public const int AlignmentFieldNumber = 9;

	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x50")]
	private Alignment alignment_;

	[Token(Token = "0x4000405")]
	public const int EntityLookFieldNumber = 10;

	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x58")]
	private EntityLook entityLook_;

	[Token(Token = "0x4000407")]
	public const int OnlineFieldNumber = 11;

	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x60")]
	private Types.Online online_;

	[Token(Token = "0x17000270")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SpouseInformationEvent> Parser
	{
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0xB74000", Offset = "0xB73400", VA = "0x180B74000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000271")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0xB73F50", Offset = "0xB73350", VA = "0x180B73F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000272")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0xB74510", Offset = "0xB73910", VA = "0x180B74510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000273")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long AccountId
	{
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000274")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000275")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CharacterName
	{
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0xB74550", Offset = "0xB73950", VA = "0x180B74550")]
		set
		{
		}
	}

	[Token(Token = "0x17000276")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CharacterLevel
	{
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x17000277")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BreedId
	{
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x946BA0", Offset = "0x945FA0", VA = "0x180946BA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x947100", Offset = "0x946500", VA = "0x180947100")]
		set
		{
		}
	}

	[Token(Token = "0x17000278")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Gender Gender
	{
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(Gender);
		}
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x17000279")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInformation Guild
	{
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
		set
		{
		}
	}

	[Token(Token = "0x1700027A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation Alliance
	{
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x92EFD0", Offset = "0x92E3D0", VA = "0x18092EFD0")]
		set
		{
		}
	}

	[Token(Token = "0x1700027B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Alignment Alignment
	{
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x874EA0", Offset = "0x8742A0", VA = "0x180874EA0")]
		get
		{
			return default(Alignment);
		}
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x874F70", Offset = "0x874370", VA = "0x180874F70")]
		set
		{
		}
	}

	[Token(Token = "0x1700027C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityLook EntityLook
	{
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x912510", Offset = "0x911910", VA = "0x180912510")]
		set
		{
		}
	}

	[Token(Token = "0x1700027D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Online Online
	{
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x7D7250", Offset = "0x7D6650", VA = "0x1807D7250")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0xB745C0", Offset = "0xB739C0", VA = "0x180B745C0")]
		set
		{
		}
	}

	[Token(Token = "0x6000B83")]
	[Address(RVA = "0xB73D30", Offset = "0xB73130", VA = "0x180B73D30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpouseInformationEvent()
	{
	}

	[Token(Token = "0x6000B84")]
	[Address(RVA = "0xB73D80", Offset = "0xB73180", VA = "0x180B73D80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpouseInformationEvent(SpouseInformationEvent other)
	{
	}

	[Token(Token = "0x6000B85")]
	[Address(RVA = "0xB734D0", Offset = "0xB728D0", VA = "0x180B734D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpouseInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0xB73530", Offset = "0xB72930", VA = "0x180B73530", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0xB73680", Offset = "0xB72A80", VA = "0x180B73680", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpouseInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0xB73790", Offset = "0xB72B90", VA = "0x180B73790", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000B9F")]
	[Address(RVA = "0xB73BD0", Offset = "0xB72FD0", VA = "0x180B73BD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0xB74350", Offset = "0xB73750", VA = "0x180B74350", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0xB73290", Offset = "0xB72690", VA = "0x180B73290", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0xB73930", Offset = "0xB72D30", VA = "0x180B73930", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpouseInformationEvent other)
	{
	}

	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0xB74050", Offset = "0xB73450", VA = "0x180B74050", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
