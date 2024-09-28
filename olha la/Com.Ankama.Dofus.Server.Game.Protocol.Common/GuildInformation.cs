using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A7A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildInformation : IMessage<GuildInformation>, IMessage, IEquatable<GuildInformation>, IDeepCloneable<GuildInformation>, IBufferMessage
{
	[Token(Token = "0x2000A7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000A7C")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class GuildSocialInformation : IMessage<GuildSocialInformation>, IMessage, IEquatable<GuildSocialInformation>, IDeepCloneable<GuildSocialInformation>, IBufferMessage
		{
			[Token(Token = "0x2000A7D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000A7E")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class GuildDetailedInformation : IMessage<GuildDetailedInformation>, IMessage, IEquatable<GuildDetailedInformation>, IDeepCloneable<GuildDetailedInformation>, IBufferMessage
				{
					[Token(Token = "0x4002611")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<GuildDetailedInformation> _parser;

					[Token(Token = "0x4002612")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002613")]
					public const int LeaderIdFieldNumber = 1;

					[Token(Token = "0x4002614")]
					[FieldOffset(Offset = "0x18")]
					private long leaderId_;

					[Token(Token = "0x4002615")]
					public const int MembersCountFieldNumber = 2;

					[Token(Token = "0x4002616")]
					[FieldOffset(Offset = "0x20")]
					private int membersCount_;

					[Token(Token = "0x4002617")]
					public const int LastActivityDayFieldNumber = 3;

					[Token(Token = "0x4002618")]
					[FieldOffset(Offset = "0x24")]
					private int lastActivityDay_;

					[Token(Token = "0x4002619")]
					public const int RecruitmentFieldNumber = 4;

					[Token(Token = "0x400261A")]
					[FieldOffset(Offset = "0x28")]
					private GuildRecruitmentInformation recruitment_;

					[Token(Token = "0x400261B")]
					public const int PendingApplicationsCountFieldNumber = 5;

					[Token(Token = "0x400261C")]
					[FieldOffset(Offset = "0x30")]
					private int pendingApplicationsCount_;

					[Token(Token = "0x400261D")]
					public const int LeaderNameFieldNumber = 6;

					[Token(Token = "0x400261E")]
					[FieldOffset(Offset = "0x8")]
					private static readonly string LeaderNameDefaultValue;

					[Token(Token = "0x400261F")]
					[FieldOffset(Offset = "0x38")]
					private string leaderName_;

					[Token(Token = "0x170017D2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<GuildDetailedInformation> Parser
					{
						[Token(Token = "0x6006DC0")]
						[Address(RVA = "0xBD0F20", Offset = "0xBD0320", VA = "0x180BD0F20")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017D3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6006DC1")]
						[Address(RVA = "0xBD0E30", Offset = "0xBD0230", VA = "0x180BD0E30")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017D4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6006DC2")]
						[Address(RVA = "0xBD1260", Offset = "0xBD0660", VA = "0x180BD1260", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017D5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public long LeaderId
					{
						[Token(Token = "0x6006DC6")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return default(long);
						}
						[Token(Token = "0x6006DC7")]
						[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
						set
						{
						}
					}

					[Token(Token = "0x170017D6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int MembersCount
					{
						[Token(Token = "0x6006DC8")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006DC9")]
						[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
						set
						{
						}
					}

					[Token(Token = "0x170017D7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int LastActivityDay
					{
						[Token(Token = "0x6006DCA")]
						[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006DCB")]
						[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
						set
						{
						}
					}

					[Token(Token = "0x170017D8")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public GuildRecruitmentInformation Recruitment
					{
						[Token(Token = "0x6006DCC")]
						[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
						get
						{
							return null;
						}
						[Token(Token = "0x6006DCD")]
						[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
						set
						{
						}
					}

					[Token(Token = "0x170017D9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int PendingApplicationsCount
					{
						[Token(Token = "0x6006DCE")]
						[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006DCF")]
						[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
						set
						{
						}
					}

					[Token(Token = "0x170017DA")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public string LeaderName
					{
						[Token(Token = "0x6006DD0")]
						[Address(RVA = "0xBD0EC0", Offset = "0xBD02C0", VA = "0x180BD0EC0")]
						get
						{
							return null;
						}
						[Token(Token = "0x6006DD1")]
						[Address(RVA = "0xBD1310", Offset = "0xBD0710", VA = "0x180BD1310")]
						set
						{
						}
					}

					[Token(Token = "0x170017DB")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool HasLeaderName
					{
						[Token(Token = "0x6006DD2")]
						[Address(RVA = "0xBD0EB0", Offset = "0xBD02B0", VA = "0x180BD0EB0")]
						get
						{
							return default(bool);
						}
					}

					[Token(Token = "0x6006DC3")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public GuildDetailedInformation()
					{
					}

					[Token(Token = "0x6006DC4")]
					[Address(RVA = "0xBD0C60", Offset = "0xBD0060", VA = "0x180BD0C60")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public GuildDetailedInformation(GuildDetailedInformation other)
					{
					}

					[Token(Token = "0x6006DC5")]
					[Address(RVA = "0xBD0620", Offset = "0xBCFA20", VA = "0x180BD0620", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public GuildDetailedInformation Clone()
					{
						return null;
					}

					[Token(Token = "0x6006DD3")]
					[Address(RVA = "0xBD0600", Offset = "0xBCFA00", VA = "0x180BD0600")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void ClearLeaderName()
					{
					}

					[Token(Token = "0x6006DD4")]
					[Address(RVA = "0xBD0750", Offset = "0xBCFB50", VA = "0x180BD0750", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006DD5")]
					[Address(RVA = "0xBD0680", Offset = "0xBCFA80", VA = "0x180BD0680", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(GuildDetailedInformation other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006DD6")]
					[Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6006DD7")]
					[Address(RVA = "0xBD0AC0", Offset = "0xBCFEC0", VA = "0x180BD0AC0", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6006DD8")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6006DD9")]
					[Address(RVA = "0xBD1110", Offset = "0xBD0510", VA = "0x180BD1110", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6006DDA")]
					[Address(RVA = "0xBD0450", Offset = "0xBCF850", VA = "0x180BD0450", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6006DDB")]
					[Address(RVA = "0xBD09B0", Offset = "0xBCFDB0", VA = "0x180BD09B0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(GuildDetailedInformation other)
					{
					}

					[Token(Token = "0x6006DDC")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6006DDD")]
					[Address(RVA = "0xBD0F70", Offset = "0xBD0370", VA = "0x180BD0F70", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x400260B")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<GuildSocialInformation> _parser;

			[Token(Token = "0x400260C")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400260D")]
			public const int EmblemFieldNumber = 1;

			[Token(Token = "0x400260E")]
			[FieldOffset(Offset = "0x18")]
			private SocialEmblem emblem_;

			[Token(Token = "0x400260F")]
			public const int DetailedInformationFieldNumber = 2;

			[Token(Token = "0x4002610")]
			[FieldOffset(Offset = "0x20")]
			private Types.GuildDetailedInformation detailedInformation_;

			[Token(Token = "0x170017CD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<GuildSocialInformation> Parser
			{
				[Token(Token = "0x6006DAB")]
				[Address(RVA = "0xBD5D90", Offset = "0xBD5190", VA = "0x180BD5D90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170017CE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006DAC")]
				[Address(RVA = "0xBD5D10", Offset = "0xBD5110", VA = "0x180BD5D10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170017CF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006DAD")]
				[Address(RVA = "0xBD5F30", Offset = "0xBD5330", VA = "0x180BD5F30", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170017D0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SocialEmblem Emblem
			{
				[Token(Token = "0x6006DB1")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006DB2")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x170017D1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.GuildDetailedInformation DetailedInformation
			{
				[Token(Token = "0x6006DB3")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006DB4")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x6006DAE")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public GuildSocialInformation()
			{
			}

			[Token(Token = "0x6006DAF")]
			[Address(RVA = "0xBD5C30", Offset = "0xBD5030", VA = "0x180BD5C30")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public GuildSocialInformation(GuildSocialInformation other)
			{
			}

			[Token(Token = "0x6006DB0")]
			[Address(RVA = "0xBD56F0", Offset = "0xBD4AF0", VA = "0x180BD56F0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public GuildSocialInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x6006DB5")]
			[Address(RVA = "0xBD5800", Offset = "0xBD4C00", VA = "0x180BD5800", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006DB6")]
			[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(GuildSocialInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006DB7")]
			[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006DB8")]
			[Address(RVA = "0xBD5AD0", Offset = "0xBD4ED0", VA = "0x180BD5AD0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006DB9")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006DBA")]
			[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006DBB")]
			[Address(RVA = "0xBD5630", Offset = "0xBD4A30", VA = "0x180BD5630", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006DBC")]
			[Address(RVA = "0xBD58C0", Offset = "0xBD4CC0", VA = "0x180BD58C0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(GuildSocialInformation other)
			{
			}

			[Token(Token = "0x6006DBD")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006DBE")]
			[Address(RVA = "0xBD5DE0", Offset = "0xBD51E0", VA = "0x180BD5DE0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002601")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildInformation> _parser;

	[Token(Token = "0x4002602")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002603")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4002604")]
	[FieldOffset(Offset = "0x18")]
	private int id_;

	[Token(Token = "0x4002605")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4002606")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x4002607")]
	public const int LevelFieldNumber = 3;

	[Token(Token = "0x4002608")]
	[FieldOffset(Offset = "0x28")]
	private int level_;

	[Token(Token = "0x4002609")]
	public const int SocialInformationFieldNumber = 4;

	[Token(Token = "0x400260A")]
	[FieldOffset(Offset = "0x30")]
	private Types.GuildSocialInformation socialInformation_;

	[Token(Token = "0x170017C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildInformation> Parser
	{
		[Token(Token = "0x6006D92")]
		[Address(RVA = "0xBD1C30", Offset = "0xBD1030", VA = "0x180BD1C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006D93")]
		[Address(RVA = "0xBD1B80", Offset = "0xBD0F80", VA = "0x180BD1B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006D94")]
		[Address(RVA = "0xBD1ED0", Offset = "0xBD12D0", VA = "0x180BD1ED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		[Token(Token = "0x6006D98")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006D99")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170017CA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6006D9A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006D9B")]
		[Address(RVA = "0xBD1F10", Offset = "0xBD1310", VA = "0x180BD1F10")]
		set
		{
		}
	}

	[Token(Token = "0x170017CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level
	{
		[Token(Token = "0x6006D9C")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006D9D")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x170017CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.GuildSocialInformation SocialInformation
	{
		[Token(Token = "0x6006D9E")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006D9F")]
		[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
		set
		{
		}
	}

	[Token(Token = "0x6006D95")]
	[Address(RVA = "0xBD1980", Offset = "0xBD0D80", VA = "0x180BD1980")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInformation()
	{
	}

	[Token(Token = "0x6006D96")]
	[Address(RVA = "0xBD19D0", Offset = "0xBD0DD0", VA = "0x180BD19D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformation(GuildInformation other)
	{
	}

	[Token(Token = "0x6006D97")]
	[Address(RVA = "0xBD1490", Offset = "0xBD0890", VA = "0x180BD1490", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006DA0")]
	[Address(RVA = "0xBD1580", Offset = "0xBD0980", VA = "0x180BD1580", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DA1")]
	[Address(RVA = "0xBD14F0", Offset = "0xBD08F0", VA = "0x180BD14F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006DA2")]
	[Address(RVA = "0xBD1650", Offset = "0xBD0A50", VA = "0x180BD1650", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006DA3")]
	[Address(RVA = "0xBD1820", Offset = "0xBD0C20", VA = "0x180BD1820", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006DA4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006DA5")]
	[Address(RVA = "0xBD1E00", Offset = "0xBD1200", VA = "0x180BD1E00", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006DA6")]
	[Address(RVA = "0xBD1380", Offset = "0xBD0780", VA = "0x180BD1380", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006DA7")]
	[Address(RVA = "0xBD1720", Offset = "0xBD0B20", VA = "0x180BD1720", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildInformation other)
	{
	}

	[Token(Token = "0x6006DA8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006DA9")]
	[Address(RVA = "0xBD1C80", Offset = "0xBD1080", VA = "0x180BD1C80", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
