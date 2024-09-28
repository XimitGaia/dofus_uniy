using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009A8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Character : IMessage<Character>, IMessage, IEquatable<Character>, IDeepCloneable<Character>, IBufferMessage
{
	[Token(Token = "0x20009A9")]
	public enum ComplementOneofCase
	{
		[Token(Token = "0x4002209")]
		None = 0,
		[Token(Token = "0x400220A")]
		CharacterBasicInformation = 2,
		[Token(Token = "0x400220B")]
		CharacterRemodelingInformation = 3
	}

	[Token(Token = "0x20009AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20009AB")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class CharacterBasicInformation : IMessage<CharacterBasicInformation>, IMessage, IEquatable<CharacterBasicInformation>, IDeepCloneable<CharacterBasicInformation>, IBufferMessage
		{
			[Token(Token = "0x20009AC")]
			public enum ComplementOneofCase
			{
				[Token(Token = "0x400221A")]
				None = 0,
				[Token(Token = "0x400221B")]
				CharacterLook = 4,
				[Token(Token = "0x400221C")]
				Rank = 5,
				[Token(Token = "0x400221D")]
				SocialMember = 6
			}

			[Token(Token = "0x20009AD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x20009AE")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SocialMember : IMessage<SocialMember>, IMessage, IEquatable<SocialMember>, IDeepCloneable<SocialMember>, IBufferMessage
				{
					[Token(Token = "0x20009AF")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static class Types
					{
						[Token(Token = "0x20009B0")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class GuildMember : IMessage<GuildMember>, IMessage, IEquatable<GuildMember>, IDeepCloneable<GuildMember>, IBufferMessage
						{
							[Token(Token = "0x20009B1")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static class Types
							{
								[Token(Token = "0x20009B2")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class PlayerNote : IMessage<PlayerNote>, IMessage, IEquatable<PlayerNote>, IDeepCloneable<PlayerNote>, IBufferMessage
								{
									[Token(Token = "0x4002246")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<PlayerNote> _parser;

									[Token(Token = "0x4002247")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x4002248")]
									public const int ContentFieldNumber = 1;

									[Token(Token = "0x4002249")]
									[FieldOffset(Offset = "0x18")]
									private string content_;

									[Token(Token = "0x400224A")]
									public const int LastEditDateFieldNumber = 2;

									[Token(Token = "0x400224B")]
									[FieldOffset(Offset = "0x20")]
									private long lastEditDate_;

									[Token(Token = "0x1700159E")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<PlayerNote> Parser
									{
										[Token(Token = "0x6006519")]
										[Address(RVA = "0xB9D4E0", Offset = "0xB9C8E0", VA = "0x180B9D4E0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700159F")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x600651A")]
										[Address(RVA = "0xB9D460", Offset = "0xB9C860", VA = "0x180B9D460")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015A0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x600651B")]
										[Address(RVA = "0xB9D610", Offset = "0xB9CA10", VA = "0x180B9D610", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015A1")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public string Content
									{
										[Token(Token = "0x600651F")]
										[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
										get
										{
											return null;
										}
										[Token(Token = "0x6006520")]
										[Address(RVA = "0xB9D6C0", Offset = "0xB9CAC0", VA = "0x180B9D6C0")]
										set
										{
										}
									}

									[Token(Token = "0x170015A2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public long LastEditDate
									{
										[Token(Token = "0x6006521")]
										[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
										get
										{
											return default(long);
										}
										[Token(Token = "0x6006522")]
										[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
										set
										{
										}
									}

									[Token(Token = "0x600651C")]
									[Address(RVA = "0xB9D410", Offset = "0xB9C810", VA = "0x180B9D410")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public PlayerNote()
									{
									}

									[Token(Token = "0x600651D")]
									[Address(RVA = "0xB9D360", Offset = "0xB9C760", VA = "0x180B9D360")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public PlayerNote(PlayerNote other)
									{
									}

									[Token(Token = "0x600651E")]
									[Address(RVA = "0xB9D000", Offset = "0xB9C400", VA = "0x180B9D000", Slot = "10")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public PlayerNote Clone()
									{
										return null;
									}

									[Token(Token = "0x6006523")]
									[Address(RVA = "0xB9D0D0", Offset = "0xB9C4D0", VA = "0x180B9D0D0", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006524")]
									[Address(RVA = "0xA00460", Offset = "0x9FF860", VA = "0x180A00460", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(PlayerNote other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006525")]
									[Address(RVA = "0xA004D0", Offset = "0x9FF8D0", VA = "0x180A004D0", Slot = "2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x6006526")]
									[Address(RVA = "0xB9D200", Offset = "0xB9C600", VA = "0x180B9D200", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x6006527")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x6006528")]
									[Address(RVA = "0xA00A10", Offset = "0x9FFE10", VA = "0x180A00A10", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006529")]
									[Address(RVA = "0xB9CF40", Offset = "0xB9C340", VA = "0x180B9CF40", Slot = "7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x600652A")]
									[Address(RVA = "0xB9D190", Offset = "0xB9C590", VA = "0x180B9D190", Slot = "4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(PlayerNote other)
									{
									}

									[Token(Token = "0x600652B")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x600652C")]
									[Address(RVA = "0xB9D530", Offset = "0xB9C930", VA = "0x180B9D530", Slot = "11")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}
							}

							[Token(Token = "0x4002236")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<GuildMember> _parser;

							[Token(Token = "0x4002237")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x4002238")]
							public const int GivenExperienceFieldNumber = 1;

							[Token(Token = "0x4002239")]
							[FieldOffset(Offset = "0x18")]
							private long givenExperience_;

							[Token(Token = "0x400223A")]
							public const int ExperienceGivenPercentFieldNumber = 2;

							[Token(Token = "0x400223B")]
							[FieldOffset(Offset = "0x20")]
							private int experienceGivenPercent_;

							[Token(Token = "0x400223C")]
							public const int AlignmentFieldNumber = 3;

							[Token(Token = "0x400223D")]
							[FieldOffset(Offset = "0x24")]
							private Alignment alignment_;

							[Token(Token = "0x400223E")]
							public const int MoodSmileyIdFieldNumber = 4;

							[Token(Token = "0x400223F")]
							[FieldOffset(Offset = "0x28")]
							private int moodSmileyId_;

							[Token(Token = "0x4002240")]
							public const int AchievementPointsFieldNumber = 5;

							[Token(Token = "0x4002241")]
							[FieldOffset(Offset = "0x2C")]
							private int achievementPoints_;

							[Token(Token = "0x4002242")]
							public const int HavenBagSharedFieldNumber = 6;

							[Token(Token = "0x4002243")]
							[FieldOffset(Offset = "0x30")]
							private bool havenBagShared_;

							[Token(Token = "0x4002244")]
							public const int NoteFieldNumber = 7;

							[Token(Token = "0x4002245")]
							[FieldOffset(Offset = "0x38")]
							private Types.PlayerNote note_;

							[Token(Token = "0x17001594")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageParser<GuildMember> Parser
							{
								[Token(Token = "0x60064FA")]
								[Address(RVA = "0xB9AD70", Offset = "0xB9A170", VA = "0x180B9AD70")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001595")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x60064FB")]
								[Address(RVA = "0xB9ACF0", Offset = "0xB9A0F0", VA = "0x180B9ACF0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001596")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x60064FC")]
								[Address(RVA = "0xB9B090", Offset = "0xB9A490", VA = "0x180B9B090", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001597")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public long GivenExperience
							{
								[Token(Token = "0x6006500")]
								[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
								get
								{
									return default(long);
								}
								[Token(Token = "0x6006501")]
								[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
								set
								{
								}
							}

							[Token(Token = "0x17001598")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int ExperienceGivenPercent
							{
								[Token(Token = "0x6006502")]
								[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6006503")]
								[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
								set
								{
								}
							}

							[Token(Token = "0x17001599")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Alignment Alignment
							{
								[Token(Token = "0x6006504")]
								[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
								get
								{
									return default(Alignment);
								}
								[Token(Token = "0x6006505")]
								[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
								set
								{
								}
							}

							[Token(Token = "0x1700159A")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int MoodSmileyId
							{
								[Token(Token = "0x6006506")]
								[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6006507")]
								[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
								set
								{
								}
							}

							[Token(Token = "0x1700159B")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int AchievementPoints
							{
								[Token(Token = "0x6006508")]
								[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6006509")]
								[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
								set
								{
								}
							}

							[Token(Token = "0x1700159C")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public bool HavenBagShared
							{
								[Token(Token = "0x600650A")]
								[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
								get
								{
									return default(bool);
								}
								[Token(Token = "0x600650B")]
								[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
								set
								{
								}
							}

							[Token(Token = "0x1700159D")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public Types.PlayerNote Note
							{
								[Token(Token = "0x600650C")]
								[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
								get
								{
									return null;
								}
								[Token(Token = "0x600650D")]
								[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
								set
								{
								}
							}

							[Token(Token = "0x60064FD")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public GuildMember()
							{
							}

							[Token(Token = "0x60064FE")]
							[Address(RVA = "0xB9ABA0", Offset = "0xB99FA0", VA = "0x180B9ABA0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public GuildMember(GuildMember other)
							{
							}

							[Token(Token = "0x60064FF")]
							[Address(RVA = "0xB9A490", Offset = "0xB99890", VA = "0x180B9A490", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public GuildMember Clone()
							{
								return null;
							}

							[Token(Token = "0x600650E")]
							[Address(RVA = "0xB9A6B0", Offset = "0xB99AB0", VA = "0x180B9A6B0", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x600650F")]
							[Address(RVA = "0xB9A610", Offset = "0xB99A10", VA = "0x180B9A610", Slot = "9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public bool Equals(GuildMember other)
							{
								return default(bool);
							}

							[Token(Token = "0x6006510")]
							[Address(RVA = "0xB9A790", Offset = "0xB99B90", VA = "0x180B9A790", Slot = "2")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x6006511")]
							[Address(RVA = "0xB9AA40", Offset = "0xB99E40", VA = "0x180B9AA40", Slot = "3")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x6006512")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x6006513")]
							[Address(RVA = "0xB9AF70", Offset = "0xB9A370", VA = "0x180B9AF70", Slot = "12")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x6006514")]
							[Address(RVA = "0xB9A320", Offset = "0xB99720", VA = "0x180B9A320", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x6006515")]
							[Address(RVA = "0xB9A8E0", Offset = "0xB99CE0", VA = "0x180B9A8E0", Slot = "4")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(GuildMember other)
							{
							}

							[Token(Token = "0x6006516")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x6006517")]
							[Address(RVA = "0xB9ADC0", Offset = "0xB9A1C0", VA = "0x180B9ADC0", Slot = "11")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}
					}

					[Token(Token = "0x400221E")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SocialMember> _parser;

					[Token(Token = "0x400221F")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002220")]
					[FieldOffset(Offset = "0x18")]
					private int _hasBits0;

					[Token(Token = "0x4002221")]
					public const int BreedIdFieldNumber = 1;

					[Token(Token = "0x4002222")]
					[FieldOffset(Offset = "0x1C")]
					private int breedId_;

					[Token(Token = "0x4002223")]
					public const int GenderFieldNumber = 2;

					[Token(Token = "0x4002224")]
					[FieldOffset(Offset = "0x20")]
					private Gender gender_;

					[Token(Token = "0x4002225")]
					public const int StateFieldNumber = 3;

					[Token(Token = "0x4002226")]
					[FieldOffset(Offset = "0x24")]
					private CharacterState state_;

					[Token(Token = "0x4002227")]
					public const int HoursSinceLastConnectionFieldNumber = 4;

					[Token(Token = "0x4002228")]
					[FieldOffset(Offset = "0x28")]
					private long hoursSinceLastConnection_;

					[Token(Token = "0x4002229")]
					public const int AccountIdFieldNumber = 5;

					[Token(Token = "0x400222A")]
					[FieldOffset(Offset = "0x30")]
					private long accountId_;

					[Token(Token = "0x400222B")]
					public const int StatusFieldNumber = 6;

					[Token(Token = "0x400222C")]
					[FieldOffset(Offset = "0x38")]
					private CharacterStatus status_;

					[Token(Token = "0x400222D")]
					public const int RankIdFieldNumber = 7;

					[Token(Token = "0x400222E")]
					[FieldOffset(Offset = "0x40")]
					private int rankId_;

					[Token(Token = "0x400222F")]
					public const int EnrollmentDateFieldNumber = 8;

					[Token(Token = "0x4002230")]
					[FieldOffset(Offset = "0x48")]
					private long enrollmentDate_;

					[Token(Token = "0x4002231")]
					public const int AvaRoleIdFieldNumber = 9;

					[Token(Token = "0x4002232")]
					[FieldOffset(Offset = "0x8")]
					private static readonly int AvaRoleIdDefaultValue;

					[Token(Token = "0x4002233")]
					[FieldOffset(Offset = "0x50")]
					private int avaRoleId_;

					[Token(Token = "0x4002234")]
					public const int GuildMemberFieldNumber = 10;

					[Token(Token = "0x4002235")]
					[FieldOffset(Offset = "0x58")]
					private Types.GuildMember guildMember_;

					[Token(Token = "0x17001586")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<SocialMember> Parser
					{
						[Token(Token = "0x60064D3")]
						[Address(RVA = "0xB9E540", Offset = "0xB9D940", VA = "0x180B9E540")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001587")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x60064D4")]
						[Address(RVA = "0xB9E4C0", Offset = "0xB9D8C0", VA = "0x180B9E4C0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001588")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x60064D5")]
						[Address(RVA = "0xB9E9B0", Offset = "0xB9DDB0", VA = "0x180B9E9B0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001589")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int BreedId
					{
						[Token(Token = "0x60064D9")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60064DA")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x1700158A")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Gender Gender
					{
						[Token(Token = "0x60064DB")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(Gender);
						}
						[Token(Token = "0x60064DC")]
						[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
						set
						{
						}
					}

					[Token(Token = "0x1700158B")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public CharacterState State
					{
						[Token(Token = "0x60064DD")]
						[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
						get
						{
							return default(CharacterState);
						}
						[Token(Token = "0x60064DE")]
						[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
						set
						{
						}
					}

					[Token(Token = "0x1700158C")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public long HoursSinceLastConnection
					{
						[Token(Token = "0x60064DF")]
						[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
						get
						{
							return default(long);
						}
						[Token(Token = "0x60064E0")]
						[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
						set
						{
						}
					}

					[Token(Token = "0x1700158D")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public long AccountId
					{
						[Token(Token = "0x60064E1")]
						[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
						get
						{
							return default(long);
						}
						[Token(Token = "0x60064E2")]
						[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
						set
						{
						}
					}

					[Token(Token = "0x1700158E")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public CharacterStatus Status
					{
						[Token(Token = "0x60064E3")]
						[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
						get
						{
							return null;
						}
						[Token(Token = "0x60064E4")]
						[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
						set
						{
						}
					}

					[Token(Token = "0x1700158F")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int RankId
					{
						[Token(Token = "0x60064E5")]
						[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60064E6")]
						[Address(RVA = "0x9F30F0", Offset = "0x9F24F0", VA = "0x1809F30F0")]
						set
						{
						}
					}

					[Token(Token = "0x17001590")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public long EnrollmentDate
					{
						[Token(Token = "0x60064E7")]
						[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
						get
						{
							return default(long);
						}
						[Token(Token = "0x60064E8")]
						[Address(RVA = "0xB9E9F0", Offset = "0xB9DDF0", VA = "0x180B9E9F0")]
						set
						{
						}
					}

					[Token(Token = "0x17001591")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int AvaRoleId
					{
						[Token(Token = "0x60064E9")]
						[Address(RVA = "0xB9E450", Offset = "0xB9D850", VA = "0x180B9E450")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60064EA")]
						[Address(RVA = "0x92EF50", Offset = "0x92E350", VA = "0x18092EF50")]
						set
						{
						}
					}

					[Token(Token = "0x17001592")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool HasAvaRoleId
					{
						[Token(Token = "0x60064EB")]
						[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
						get
						{
							return default(bool);
						}
					}

					[Token(Token = "0x17001593")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.GuildMember GuildMember
					{
						[Token(Token = "0x60064ED")]
						[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
						get
						{
							return null;
						}
						[Token(Token = "0x60064EE")]
						[Address(RVA = "0x912510", Offset = "0x911910", VA = "0x180912510")]
						set
						{
						}
					}

					[Token(Token = "0x60064D6")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SocialMember()
					{
					}

					[Token(Token = "0x60064D7")]
					[Address(RVA = "0xB9E220", Offset = "0xB9D620", VA = "0x180B9E220")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SocialMember(SocialMember other)
					{
					}

					[Token(Token = "0x60064D8")]
					[Address(RVA = "0xB9D990", Offset = "0xB9CD90", VA = "0x180B9D990", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SocialMember Clone()
					{
						return null;
					}

					[Token(Token = "0x60064EC")]
					[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void ClearAvaRoleId()
					{
					}

					[Token(Token = "0x60064EF")]
					[Address(RVA = "0xB9D9F0", Offset = "0xB9CDF0", VA = "0x180B9D9F0", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x60064F0")]
					[Address(RVA = "0xB9DB30", Offset = "0xB9CF30", VA = "0x180B9DB30", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SocialMember other)
					{
						return default(bool);
					}

					[Token(Token = "0x60064F1")]
					[Address(RVA = "0xB9DC30", Offset = "0xB9D030", VA = "0x180B9DC30", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60064F2")]
					[Address(RVA = "0xB9E0B0", Offset = "0xB9D4B0", VA = "0x180B9E0B0", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60064F3")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60064F4")]
					[Address(RVA = "0xB9E7E0", Offset = "0xB9DBE0", VA = "0x180B9E7E0", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60064F5")]
					[Address(RVA = "0xB9D730", Offset = "0xB9CB30", VA = "0x180B9D730", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x60064F6")]
					[Address(RVA = "0xB9DDF0", Offset = "0xB9D1F0", VA = "0x180B9DDF0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SocialMember other)
					{
					}

					[Token(Token = "0x60064F7")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x60064F8")]
					[Address(RVA = "0xB9E590", Offset = "0xB9D990", VA = "0x180B9E590", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x20009B6")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class CharacterLook : IMessage<CharacterLook>, IMessage, IEquatable<CharacterLook>, IDeepCloneable<CharacterLook>, IBufferMessage
				{
					[Token(Token = "0x20009B7")]
					public enum ComplementOneofCase
					{
						[Token(Token = "0x400225C")]
						None = 0,
						[Token(Token = "0x400225D")]
						GuildInformation = 3,
						[Token(Token = "0x400225E")]
						AllianceInformation = 4,
						[Token(Token = "0x400225F")]
						Grade = 5,
						[Token(Token = "0x4002260")]
						BaseInformation = 6
					}

					[Token(Token = "0x20009B8")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static class Types
					{
						[Token(Token = "0x20009B9")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class CharacterBaseInformation : IMessage<CharacterBaseInformation>, IMessage, IEquatable<CharacterBaseInformation>, IDeepCloneable<CharacterBaseInformation>, IBufferMessage
						{
							[Token(Token = "0x20009BA")]
							public enum ComplementOneofCase
							{
								[Token(Token = "0x400226B")]
								None = 0,
								[Token(Token = "0x400226C")]
								EpicInformation = 2,
								[Token(Token = "0x400226D")]
								PartyMemberInformation = 3,
								[Token(Token = "0x400226E")]
								PartyInvitationMemberInformation = 4
							}

							[Token(Token = "0x20009BB")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static class Types
							{
								[Token(Token = "0x20009BC")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class CharacterEpicInformation : IMessage<CharacterEpicInformation>, IMessage, IEquatable<CharacterEpicInformation>, IDeepCloneable<CharacterEpicInformation>, IBufferMessage
								{
									[Token(Token = "0x20009BD")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static class Types
									{
										[Token(Token = "0x20009BE")]
										public enum EpicDeathState
										{
											[Token(Token = "0x4002278")]
											[OriginalName("DEATH_STATE_ALIVE")]
											DeathStateAlive,
											[Token(Token = "0x4002279")]
											[OriginalName("DEATH_STATE_DEAD")]
											DeathStateDead,
											[Token(Token = "0x400227A")]
											[OriginalName("DEATH_STATE_WAITING_CONFIRMATION")]
											DeathStateWaitingConfirmation
										}
									}

									[Token(Token = "0x400226F")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<CharacterEpicInformation> _parser;

									[Token(Token = "0x4002270")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x4002271")]
									public const int DeathStateFieldNumber = 1;

									[Token(Token = "0x4002272")]
									[FieldOffset(Offset = "0x18")]
									private Types.EpicDeathState deathState_;

									[Token(Token = "0x4002273")]
									public const int DeathCountFieldNumber = 2;

									[Token(Token = "0x4002274")]
									[FieldOffset(Offset = "0x1C")]
									private int deathCount_;

									[Token(Token = "0x4002275")]
									public const int DeathMaxLevelFieldNumber = 3;

									[Token(Token = "0x4002276")]
									[FieldOffset(Offset = "0x20")]
									private int deathMaxLevel_;

									[Token(Token = "0x170015B6")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<CharacterEpicInformation> Parser
									{
										[Token(Token = "0x6006573")]
										[Address(RVA = "0xB953C0", Offset = "0xB947C0", VA = "0x180B953C0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015B7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x6006574")]
										[Address(RVA = "0xB95340", Offset = "0xB94740", VA = "0x180B95340")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015B8")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x6006575")]
										[Address(RVA = "0xB95410", Offset = "0xB94810", VA = "0x180B95410", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015B9")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public Types.EpicDeathState DeathState
									{
										[Token(Token = "0x6006579")]
										[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
										get
										{
											return default(Types.EpicDeathState);
										}
										[Token(Token = "0x600657A")]
										[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
										set
										{
										}
									}

									[Token(Token = "0x170015BA")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int DeathCount
									{
										[Token(Token = "0x600657B")]
										[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x600657C")]
										[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
										set
										{
										}
									}

									[Token(Token = "0x170015BB")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int DeathMaxLevel
									{
										[Token(Token = "0x600657D")]
										[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x600657E")]
										[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
										set
										{
										}
									}

									[Token(Token = "0x6006576")]
									[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public CharacterEpicInformation()
									{
									}

									[Token(Token = "0x6006577")]
									[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public CharacterEpicInformation(CharacterEpicInformation other)
									{
									}

									[Token(Token = "0x6006578")]
									[Address(RVA = "0xB950B0", Offset = "0xB944B0", VA = "0x180B950B0", Slot = "10")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public CharacterEpicInformation Clone()
									{
										return null;
									}

									[Token(Token = "0x600657F")]
									[Address(RVA = "0xB95140", Offset = "0xB94540", VA = "0x180B95140", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006580")]
									[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public bool Equals(CharacterEpicInformation other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006581")]
									[Address(RVA = "0x998170", Offset = "0x997570", VA = "0x180998170", Slot = "2")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x6006582")]
									[Address(RVA = "0xB951E0", Offset = "0xB945E0", VA = "0x180B951E0", Slot = "3")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x6006583")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x6006584")]
									[Address(RVA = "0x998470", Offset = "0x997870", VA = "0x180998470", Slot = "12")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006585")]
									[Address(RVA = "0xB94FD0", Offset = "0xB943D0", VA = "0x180B94FD0", Slot = "7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x6006586")]
									[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CharacterEpicInformation other)
									{
									}

									[Token(Token = "0x6006587")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x6006588")]
									[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}

								[Token(Token = "0x20009C0")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class PartyMemberInformation : IMessage<PartyMemberInformation>, IMessage, IEquatable<PartyMemberInformation>, IDeepCloneable<PartyMemberInformation>, IBufferMessage
								{
									[Token(Token = "0x400227C")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<PartyMemberInformation> _parser;

									[Token(Token = "0x400227D")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x400227E")]
									[FieldOffset(Offset = "0x18")]
									private int _hasBits0;

									[Token(Token = "0x400227F")]
									public const int CommonsInformationFieldNumber = 1;

									[Token(Token = "0x4002280")]
									[FieldOffset(Offset = "0x20")]
									private PartyUpdateCommonsInformation commonsInformation_;

									[Token(Token = "0x4002281")]
									public const int InitiativeFieldNumber = 2;

									[Token(Token = "0x4002282")]
									[FieldOffset(Offset = "0x28")]
									private int initiative_;

									[Token(Token = "0x4002283")]
									public const int AlignmentFieldNumber = 3;

									[Token(Token = "0x4002284")]
									[FieldOffset(Offset = "0x2C")]
									private Alignment alignment_;

									[Token(Token = "0x4002285")]
									public const int CoordinatesFieldNumber = 4;

									[Token(Token = "0x4002286")]
									[FieldOffset(Offset = "0x30")]
									private MapExtendedCoordinates coordinates_;

									[Token(Token = "0x4002287")]
									public const int StatusFieldNumber = 5;

									[Token(Token = "0x4002288")]
									[FieldOffset(Offset = "0x38")]
									private CharacterStatus status_;

									[Token(Token = "0x4002289")]
									public const int EntitiesFieldNumber = 6;

									[Token(Token = "0x400228A")]
									[FieldOffset(Offset = "0x8")]
									private static readonly FieldCodec<PartyEntity> _repeated_entities_codec;

									[Token(Token = "0x400228B")]
									[FieldOffset(Offset = "0x40")]
									private readonly RepeatedField<PartyEntity> entities_;

									[Token(Token = "0x400228C")]
									public const int RankFieldNumber = 7;

									[Token(Token = "0x400228D")]
									[FieldOffset(Offset = "0x10")]
									private static readonly int RankDefaultValue;

									[Token(Token = "0x400228E")]
									[FieldOffset(Offset = "0x48")]
									private int rank_;

									[Token(Token = "0x170015BC")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<PartyMemberInformation> Parser
									{
										[Token(Token = "0x600658D")]
										[Address(RVA = "0xB9C970", Offset = "0xB9BD70", VA = "0x180B9C970")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015BD")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x600658E")]
										[Address(RVA = "0xB9C8F0", Offset = "0xB9BCF0", VA = "0x180B9C8F0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015BE")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x600658F")]
										[Address(RVA = "0xB9CE80", Offset = "0xB9C280", VA = "0x180B9CE80", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015BF")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public PartyUpdateCommonsInformation CommonsInformation
									{
										[Token(Token = "0x6006593")]
										[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
										get
										{
											return null;
										}
										[Token(Token = "0x6006594")]
										[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
										set
										{
										}
									}

									[Token(Token = "0x170015C0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int Initiative
									{
										[Token(Token = "0x6006595")]
										[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006596")]
										[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
										set
										{
										}
									}

									[Token(Token = "0x170015C1")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Alignment Alignment
									{
										[Token(Token = "0x6006597")]
										[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
										get
										{
											return default(Alignment);
										}
										[Token(Token = "0x6006598")]
										[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
										set
										{
										}
									}

									[Token(Token = "0x170015C2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public MapExtendedCoordinates Coordinates
									{
										[Token(Token = "0x6006599")]
										[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
										get
										{
											return null;
										}
										[Token(Token = "0x600659A")]
										[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
										set
										{
										}
									}

									[Token(Token = "0x170015C3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public CharacterStatus Status
									{
										[Token(Token = "0x600659B")]
										[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
										get
										{
											return null;
										}
										[Token(Token = "0x600659C")]
										[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
										set
										{
										}
									}

									[Token(Token = "0x170015C4")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public RepeatedField<PartyEntity> Entities
									{
										[Token(Token = "0x600659D")]
										[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015C5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int Rank
									{
										[Token(Token = "0x600659E")]
										[Address(RVA = "0xB9C9C0", Offset = "0xB9BDC0", VA = "0x180B9C9C0")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x600659F")]
										[Address(RVA = "0xB9CF30", Offset = "0xB9C330", VA = "0x180B9CF30")]
										set
										{
										}
									}

									[Token(Token = "0x170015C6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool HasRank
									{
										[Token(Token = "0x60065A0")]
										[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
										get
										{
											return default(bool);
										}
									}

									[Token(Token = "0x6006590")]
									[Address(RVA = "0xB9C750", Offset = "0xB9BB50", VA = "0x180B9C750")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public PartyMemberInformation()
									{
									}

									[Token(Token = "0x6006591")]
									[Address(RVA = "0xB9C7D0", Offset = "0xB9BBD0", VA = "0x180B9C7D0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public PartyMemberInformation(PartyMemberInformation other)
									{
									}

									[Token(Token = "0x6006592")]
									[Address(RVA = "0xB9BE30", Offset = "0xB9B230", VA = "0x180B9BE30", Slot = "10")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public PartyMemberInformation Clone()
									{
										return null;
									}

									[Token(Token = "0x60065A1")]
									[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void ClearRank()
									{
									}

									[Token(Token = "0x60065A2")]
									[Address(RVA = "0xB9C0A0", Offset = "0xB9B4A0", VA = "0x180B9C0A0", Slot = "0")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x60065A3")]
									[Address(RVA = "0xB9BF80", Offset = "0xB9B380", VA = "0x180B9BF80", Slot = "9")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public bool Equals(PartyMemberInformation other)
									{
										return default(bool);
									}

									[Token(Token = "0x60065A4")]
									[Address(RVA = "0xB9C1F0", Offset = "0xB9B5F0", VA = "0x180B9C1F0", Slot = "2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x60065A5")]
									[Address(RVA = "0xB9C530", Offset = "0xB9B930", VA = "0x180B9C530", Slot = "3")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x60065A6")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x60065A7")]
									[Address(RVA = "0xB9CCB0", Offset = "0xB9C0B0", VA = "0x180B9CCB0", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x60065A8")]
									[Address(RVA = "0xB9BC20", Offset = "0xB9B020", VA = "0x180B9BC20", Slot = "7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x60065A9")]
									[Address(RVA = "0xB9C360", Offset = "0xB9B760", VA = "0x180B9C360", Slot = "4")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(PartyMemberInformation other)
									{
									}

									[Token(Token = "0x60065AA")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x60065AB")]
									[Address(RVA = "0xB9CA30", Offset = "0xB9BE30", VA = "0x180B9CA30", Slot = "11")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}

								[Token(Token = "0x20009C2")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class PartyInvitationMemberInformation : IMessage<PartyInvitationMemberInformation>, IMessage, IEquatable<PartyInvitationMemberInformation>, IDeepCloneable<PartyInvitationMemberInformation>, IBufferMessage
								{
									[Token(Token = "0x4002290")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<PartyInvitationMemberInformation> _parser;

									[Token(Token = "0x4002291")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x4002292")]
									public const int CoordinatesFieldNumber = 1;

									[Token(Token = "0x4002293")]
									[FieldOffset(Offset = "0x18")]
									private MapExtendedCoordinates coordinates_;

									[Token(Token = "0x4002294")]
									public const int EntitiesFieldNumber = 2;

									[Token(Token = "0x4002295")]
									[FieldOffset(Offset = "0x8")]
									private static readonly FieldCodec<PartyEntity> _repeated_entities_codec;

									[Token(Token = "0x4002296")]
									[FieldOffset(Offset = "0x20")]
									private readonly RepeatedField<PartyEntity> entities_;

									[Token(Token = "0x170015C7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageParser<PartyInvitationMemberInformation> Parser
									{
										[Token(Token = "0x60065B0")]
										[Address(RVA = "0xB9B8E0", Offset = "0xB9ACE0", VA = "0x180B9B8E0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015C8")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x60065B1")]
										[Address(RVA = "0xB9B860", Offset = "0xB9AC60", VA = "0x180B9B860")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015C9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x60065B2")]
										[Address(RVA = "0xB9BB70", Offset = "0xB9AF70", VA = "0x180B9BB70", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170015CA")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public MapExtendedCoordinates Coordinates
									{
										[Token(Token = "0x60065B6")]
										[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
										get
										{
											return null;
										}
										[Token(Token = "0x60065B7")]
										[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
										set
										{
										}
									}

									[Token(Token = "0x170015CB")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public RepeatedField<PartyEntity> Entities
									{
										[Token(Token = "0x60065B8")]
										[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x60065B3")]
									[Address(RVA = "0xB9B7E0", Offset = "0xB9ABE0", VA = "0x180B9B7E0")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public PartyInvitationMemberInformation()
									{
									}

									[Token(Token = "0x60065B4")]
									[Address(RVA = "0xB9B720", Offset = "0xB9AB20", VA = "0x180B9B720")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public PartyInvitationMemberInformation(PartyInvitationMemberInformation other)
									{
									}

									[Token(Token = "0x60065B5")]
									[Address(RVA = "0xB9B1B0", Offset = "0xB9A5B0", VA = "0x180B9B1B0", Slot = "10")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public PartyInvitationMemberInformation Clone()
									{
										return null;
									}

									[Token(Token = "0x60065B9")]
									[Address(RVA = "0xB9B340", Offset = "0xB9A740", VA = "0x180B9B340", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x60065BA")]
									[Address(RVA = "0xB9B290", Offset = "0xB9A690", VA = "0x180B9B290", Slot = "9")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public bool Equals(PartyInvitationMemberInformation other)
									{
										return default(bool);
									}

									[Token(Token = "0x60065BB")]
									[Address(RVA = "0xA82900", Offset = "0xA81D00", VA = "0x180A82900", Slot = "2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x60065BC")]
									[Address(RVA = "0xB9B520", Offset = "0xB9A920", VA = "0x180B9B520", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x60065BD")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x60065BE")]
									[Address(RVA = "0xB9BAA0", Offset = "0xB9AEA0", VA = "0x180B9BAA0", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x60065BF")]
									[Address(RVA = "0xB9B0D0", Offset = "0xB9A4D0", VA = "0x180B9B0D0", Slot = "7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x60065C0")]
									[Address(RVA = "0xB9B430", Offset = "0xB9A830", VA = "0x180B9B430", Slot = "4")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(PartyInvitationMemberInformation other)
									{
									}

									[Token(Token = "0x60065C1")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x60065C2")]
									[Address(RVA = "0xB9B930", Offset = "0xB9AD30", VA = "0x180B9B930", Slot = "11")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}
							}

							[Token(Token = "0x4002261")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<CharacterBaseInformation> _parser;

							[Token(Token = "0x4002262")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x4002263")]
							public const int GenderFieldNumber = 1;

							[Token(Token = "0x4002264")]
							[FieldOffset(Offset = "0x18")]
							private Gender gender_;

							[Token(Token = "0x4002265")]
							public const int EpicInformationFieldNumber = 2;

							[Token(Token = "0x4002266")]
							public const int PartyMemberInformationFieldNumber = 3;

							[Token(Token = "0x4002267")]
							public const int PartyInvitationMemberInformationFieldNumber = 4;

							[Token(Token = "0x4002268")]
							[FieldOffset(Offset = "0x20")]
							private object complement_;

							[Token(Token = "0x4002269")]
							[FieldOffset(Offset = "0x28")]
							private ComplementOneofCase complementCase_;

							[Token(Token = "0x170015AE")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageParser<CharacterBaseInformation> Parser
							{
								[Token(Token = "0x6006558")]
								[Address(RVA = "0xB933E0", Offset = "0xB927E0", VA = "0x180B933E0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170015AF")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x6006559")]
								[Address(RVA = "0xB93300", Offset = "0xB92700", VA = "0x180B93300")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170015B0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x600655A")]
								[Address(RVA = "0xB93920", Offset = "0xB92D20", VA = "0x180B93920", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170015B1")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Gender Gender
							{
								[Token(Token = "0x600655E")]
								[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
								get
								{
									return default(Gender);
								}
								[Token(Token = "0x600655F")]
								[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
								set
								{
								}
							}

							[Token(Token = "0x170015B2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.CharacterEpicInformation EpicInformation
							{
								[Token(Token = "0x6006560")]
								[Address(RVA = "0xB93380", Offset = "0xB92780", VA = "0x180B93380")]
								get
								{
									return null;
								}
								[Token(Token = "0x6006561")]
								[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
								set
								{
								}
							}

							[Token(Token = "0x170015B3")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public Types.PartyMemberInformation PartyMemberInformation
							{
								[Token(Token = "0x6006562")]
								[Address(RVA = "0xB93490", Offset = "0xB92890", VA = "0x180B93490")]
								get
								{
									return null;
								}
								[Token(Token = "0x6006563")]
								[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
								set
								{
								}
							}

							[Token(Token = "0x170015B4")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public Types.PartyInvitationMemberInformation PartyInvitationMemberInformation
							{
								[Token(Token = "0x6006564")]
								[Address(RVA = "0xB93430", Offset = "0xB92830", VA = "0x180B93430")]
								get
								{
									return null;
								}
								[Token(Token = "0x6006565")]
								[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
								set
								{
								}
							}

							[Token(Token = "0x170015B5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public ComplementOneofCase ComplementCase
							{
								[Token(Token = "0x6006566")]
								[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
								get
								{
									return default(ComplementOneofCase);
								}
							}

							[Token(Token = "0x600655B")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public CharacterBaseInformation()
							{
							}

							[Token(Token = "0x600655C")]
							[Address(RVA = "0xB92ED0", Offset = "0xB922D0", VA = "0x180B92ED0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public CharacterBaseInformation(CharacterBaseInformation other)
							{
							}

							[Token(Token = "0x600655D")]
							[Address(RVA = "0xB926D0", Offset = "0xB91AD0", VA = "0x180B926D0", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public CharacterBaseInformation Clone()
							{
								return null;
							}

							[Token(Token = "0x6006567")]
							[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void ClearComplement()
							{
							}

							[Token(Token = "0x6006568")]
							[Address(RVA = "0xB92830", Offset = "0xB91C30", VA = "0x180B92830", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x6006569")]
							[Address(RVA = "0xB92730", Offset = "0xB91B30", VA = "0x180B92730", Slot = "9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public bool Equals(CharacterBaseInformation other)
							{
								return default(bool);
							}

							[Token(Token = "0x600656A")]
							[Address(RVA = "0xB92970", Offset = "0xB91D70", VA = "0x180B92970", Slot = "2")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x600656B")]
							[Address(RVA = "0xB92D70", Offset = "0xB92170", VA = "0x180B92D70", Slot = "3")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x600656C")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x600656D")]
							[Address(RVA = "0xB93780", Offset = "0xB92B80", VA = "0x180B93780", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x600656E")]
							[Address(RVA = "0xB924F0", Offset = "0xB918F0", VA = "0x180B924F0", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x600656F")]
							[Address(RVA = "0xB92B30", Offset = "0xB91F30", VA = "0x180B92B30", Slot = "4")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(CharacterBaseInformation other)
							{
							}

							[Token(Token = "0x6006570")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x6006571")]
							[Address(RVA = "0xB934F0", Offset = "0xB928F0", VA = "0x180B934F0", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}
					}

					[Token(Token = "0x400224F")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<CharacterLook> _parser;

					[Token(Token = "0x4002250")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002251")]
					public const int LookFieldNumber = 1;

					[Token(Token = "0x4002252")]
					[FieldOffset(Offset = "0x18")]
					private EntityLook look_;

					[Token(Token = "0x4002253")]
					public const int BreedIdFieldNumber = 2;

					[Token(Token = "0x4002254")]
					[FieldOffset(Offset = "0x20")]
					private int breedId_;

					[Token(Token = "0x4002255")]
					public const int GuildInformationFieldNumber = 3;

					[Token(Token = "0x4002256")]
					public const int AllianceInformationFieldNumber = 4;

					[Token(Token = "0x4002257")]
					public const int GradeFieldNumber = 5;

					[Token(Token = "0x4002258")]
					public const int BaseInformationFieldNumber = 6;

					[Token(Token = "0x4002259")]
					[FieldOffset(Offset = "0x28")]
					private object complement_;

					[Token(Token = "0x400225A")]
					[FieldOffset(Offset = "0x30")]
					private ComplementOneofCase complementCase_;

					[Token(Token = "0x170015A3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<CharacterLook> Parser
					{
						[Token(Token = "0x6006537")]
						[Address(RVA = "0xB964B0", Offset = "0xB958B0", VA = "0x180B964B0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170015A4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6006538")]
						[Address(RVA = "0xB96350", Offset = "0xB95750", VA = "0x180B96350")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170015A5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6006539")]
						[Address(RVA = "0xB96A10", Offset = "0xB95E10", VA = "0x180B96A10", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170015A6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public EntityLook Look
					{
						[Token(Token = "0x600653D")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return null;
						}
						[Token(Token = "0x600653E")]
						[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
						set
						{
						}
					}

					[Token(Token = "0x170015A7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int BreedId
					{
						[Token(Token = "0x600653F")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006540")]
						[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
						set
						{
						}
					}

					[Token(Token = "0x170015A8")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public GuildInformation GuildInformation
					{
						[Token(Token = "0x6006541")]
						[Address(RVA = "0xB96440", Offset = "0xB95840", VA = "0x180B96440")]
						get
						{
							return null;
						}
						[Token(Token = "0x6006542")]
						[Address(RVA = "0x91BB80", Offset = "0x91AF80", VA = "0x18091BB80")]
						set
						{
						}
					}

					[Token(Token = "0x170015A9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public AllianceInformation AllianceInformation
					{
						[Token(Token = "0x6006543")]
						[Address(RVA = "0xB96290", Offset = "0xB95690", VA = "0x180B96290")]
						get
						{
							return null;
						}
						[Token(Token = "0x6006544")]
						[Address(RVA = "0x91BB40", Offset = "0x91AF40", VA = "0x18091BB40")]
						set
						{
						}
					}

					[Token(Token = "0x170015AA")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int Grade
					{
						[Token(Token = "0x6006545")]
						[Address(RVA = "0xB963D0", Offset = "0xB957D0", VA = "0x180B963D0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006546")]
						[Address(RVA = "0xB96A50", Offset = "0xB95E50", VA = "0x180B96A50")]
						set
						{
						}
					}

					[Token(Token = "0x170015AB")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool HasGrade
					{
						[Token(Token = "0x6006547")]
						[Address(RVA = "0xB964A0", Offset = "0xB958A0", VA = "0x180B964A0")]
						get
						{
							return default(bool);
						}
					}

					[Token(Token = "0x170015AC")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Types.CharacterBaseInformation BaseInformation
					{
						[Token(Token = "0x6006549")]
						[Address(RVA = "0xB962F0", Offset = "0xB956F0", VA = "0x180B962F0")]
						get
						{
							return null;
						}
						[Token(Token = "0x600654A")]
						[Address(RVA = "0xA1ADB0", Offset = "0xA1A1B0", VA = "0x180A1ADB0")]
						set
						{
						}
					}

					[Token(Token = "0x170015AD")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public ComplementOneofCase ComplementCase
					{
						[Token(Token = "0x600654B")]
						[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
						get
						{
							return default(ComplementOneofCase);
						}
					}

					[Token(Token = "0x600653A")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public CharacterLook()
					{
					}

					[Token(Token = "0x600653B")]
					[Address(RVA = "0xB960B0", Offset = "0xB954B0", VA = "0x180B960B0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public CharacterLook(CharacterLook other)
					{
					}

					[Token(Token = "0x600653C")]
					[Address(RVA = "0xB95770", Offset = "0xB94B70", VA = "0x180B95770", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public CharacterLook Clone()
					{
						return null;
					}

					[Token(Token = "0x6006548")]
					[Address(RVA = "0xB95750", Offset = "0xB94B50", VA = "0x180B95750")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void ClearGrade()
					{
					}

					[Token(Token = "0x600654C")]
					[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void ClearComplement()
					{
					}

					[Token(Token = "0x600654D")]
					[Address(RVA = "0xB95900", Offset = "0xB94D00", VA = "0x180B95900", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x600654E")]
					[Address(RVA = "0xB957D0", Offset = "0xB94BD0", VA = "0x180B957D0", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(CharacterLook other)
					{
						return default(bool);
					}

					[Token(Token = "0x600654F")]
					[Address(RVA = "0xB95A70", Offset = "0xB94E70", VA = "0x180B95A70", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6006550")]
					[Address(RVA = "0xB95F50", Offset = "0xB95350", VA = "0x180B95F50", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6006551")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6006552")]
					[Address(RVA = "0xB967D0", Offset = "0xB95BD0", VA = "0x180B967D0", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6006553")]
					[Address(RVA = "0xB954C0", Offset = "0xB948C0", VA = "0x180B954C0", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6006554")]
					[Address(RVA = "0xB95CC0", Offset = "0xB950C0", VA = "0x180B95CC0", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CharacterLook other)
					{
					}

					[Token(Token = "0x6006555")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6006556")]
					[Address(RVA = "0xB96500", Offset = "0xB95900", VA = "0x180B96500", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x400220C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<CharacterBasicInformation> _parser;

			[Token(Token = "0x400220D")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400220E")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x400220F")]
			public const int NameFieldNumber = 1;

			[Token(Token = "0x4002210")]
			[FieldOffset(Offset = "0x20")]
			private string name_;

			[Token(Token = "0x4002211")]
			public const int LevelFieldNumber = 2;

			[Token(Token = "0x4002212")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int LevelDefaultValue;

			[Token(Token = "0x4002213")]
			[FieldOffset(Offset = "0x28")]
			private int level_;

			[Token(Token = "0x4002214")]
			public const int CharacterLookFieldNumber = 4;

			[Token(Token = "0x4002215")]
			public const int RankFieldNumber = 5;

			[Token(Token = "0x4002216")]
			public const int SocialMemberFieldNumber = 6;

			[Token(Token = "0x4002217")]
			[FieldOffset(Offset = "0x30")]
			private object complement_;

			[Token(Token = "0x4002218")]
			[FieldOffset(Offset = "0x38")]
			private ComplementOneofCase complementCase_;

			[Token(Token = "0x1700157C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<CharacterBasicInformation> Parser
			{
				[Token(Token = "0x60064B4")]
				[Address(RVA = "0xB948E0", Offset = "0xB93CE0", VA = "0x180B948E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700157D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60064B5")]
				[Address(RVA = "0xB947F0", Offset = "0xB93BF0", VA = "0x180B947F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700157E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60064B6")]
				[Address(RVA = "0xB94EA0", Offset = "0xB942A0", VA = "0x180B94EA0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700157F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string Name
			{
				[Token(Token = "0x60064BA")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x60064BB")]
				[Address(RVA = "0xB94F20", Offset = "0xB94320", VA = "0x180B94F20")]
				set
				{
				}
			}

			[Token(Token = "0x17001580")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Level
			{
				[Token(Token = "0x60064BC")]
				[Address(RVA = "0xB94870", Offset = "0xB93C70", VA = "0x180B94870")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60064BD")]
				[Address(RVA = "0xA0A2B0", Offset = "0xA096B0", VA = "0x180A0A2B0")]
				set
				{
				}
			}

			[Token(Token = "0x17001581")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasLevel
			{
				[Token(Token = "0x60064BE")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17001582")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.CharacterLook CharacterLook
			{
				[Token(Token = "0x60064C0")]
				[Address(RVA = "0xB94790", Offset = "0xB93B90", VA = "0x180B94790")]
				get
				{
					return null;
				}
				[Token(Token = "0x60064C1")]
				[Address(RVA = "0xB94EE0", Offset = "0xB942E0", VA = "0x180B94EE0")]
				set
				{
				}
			}

			[Token(Token = "0x17001583")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RankInformation Rank
			{
				[Token(Token = "0x60064C2")]
				[Address(RVA = "0xB94930", Offset = "0xB93D30", VA = "0x180B94930")]
				get
				{
					return null;
				}
				[Token(Token = "0x60064C3")]
				[Address(RVA = "0xB94F90", Offset = "0xB94390", VA = "0x180B94F90")]
				set
				{
				}
			}

			[Token(Token = "0x17001584")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.SocialMember SocialMember
			{
				[Token(Token = "0x60064C4")]
				[Address(RVA = "0xB94990", Offset = "0xB93D90", VA = "0x180B94990")]
				get
				{
					return null;
				}
				[Token(Token = "0x60064C5")]
				[Address(RVA = "0xA38940", Offset = "0xA37D40", VA = "0x180A38940")]
				set
				{
				}
			}

			[Token(Token = "0x17001585")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ComplementOneofCase ComplementCase
			{
				[Token(Token = "0x60064C6")]
				[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
				get
				{
					return default(ComplementOneofCase);
				}
			}

			[Token(Token = "0x60064B7")]
			[Address(RVA = "0xB94740", Offset = "0xB93B40", VA = "0x180B94740")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CharacterBasicInformation()
			{
			}

			[Token(Token = "0x60064B8")]
			[Address(RVA = "0xB94490", Offset = "0xB93890", VA = "0x180B94490")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public CharacterBasicInformation(CharacterBasicInformation other)
			{
			}

			[Token(Token = "0x60064B9")]
			[Address(RVA = "0xB93BD0", Offset = "0xB92FD0", VA = "0x180B93BD0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CharacterBasicInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x60064BF")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearLevel()
			{
			}

			[Token(Token = "0x60064C7")]
			[Address(RVA = "0xA37990", Offset = "0xA36D90", VA = "0x180A37990")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearComplement()
			{
			}

			[Token(Token = "0x60064C8")]
			[Address(RVA = "0xB93C30", Offset = "0xB93030", VA = "0x180B93C30", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60064C9")]
			[Address(RVA = "0xB93D90", Offset = "0xB93190", VA = "0x180B93D90", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(CharacterBasicInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x60064CA")]
			[Address(RVA = "0xB93EC0", Offset = "0xB932C0", VA = "0x180B93EC0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60064CB")]
			[Address(RVA = "0xB94320", Offset = "0xB93720", VA = "0x180B94320", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60064CC")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60064CD")]
			[Address(RVA = "0xB94C80", Offset = "0xB94080", VA = "0x180B94C80", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60064CE")]
			[Address(RVA = "0xB93960", Offset = "0xB92D60", VA = "0x180B93960", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60064CF")]
			[Address(RVA = "0xB940F0", Offset = "0xB934F0", VA = "0x180B940F0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CharacterBasicInformation other)
			{
			}

			[Token(Token = "0x60064D0")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60064D1")]
			[Address(RVA = "0xB949F0", Offset = "0xB93DF0", VA = "0x180B949F0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002200")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Character> _parser;

	[Token(Token = "0x4002201")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002202")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4002203")]
	[FieldOffset(Offset = "0x18")]
	private long id_;

	[Token(Token = "0x4002204")]
	public const int CharacterBasicInformationFieldNumber = 2;

	[Token(Token = "0x4002205")]
	public const int CharacterRemodelingInformationFieldNumber = 3;

	[Token(Token = "0x4002206")]
	[FieldOffset(Offset = "0x20")]
	private object complement_;

	[Token(Token = "0x4002207")]
	[FieldOffset(Offset = "0x28")]
	private ComplementOneofCase complementCase_;

	[Token(Token = "0x17001575")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<Character> Parser
	{
		[Token(Token = "0x600649B")]
		[Address(RVA = "0xB98C90", Offset = "0xB98090", VA = "0x180B98C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001576")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600649C")]
		[Address(RVA = "0xB98BE0", Offset = "0xB97FE0", VA = "0x180B98BE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001577")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600649D")]
		[Address(RVA = "0xB98FD0", Offset = "0xB983D0", VA = "0x180B98FD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001578")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Id
	{
		[Token(Token = "0x60064A1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60064A2")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001579")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.CharacterBasicInformation CharacterBasicInformation
	{
		[Token(Token = "0x60064A3")]
		[Address(RVA = "0xB98B20", Offset = "0xB97F20", VA = "0x180B98B20")]
		get
		{
			return null;
		}
		[Token(Token = "0x60064A4")]
		[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
		set
		{
		}
	}

	[Token(Token = "0x1700157A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterRemodelingInformation CharacterRemodelingInformation
	{
		[Token(Token = "0x60064A5")]
		[Address(RVA = "0xB98B80", Offset = "0xB97F80", VA = "0x180B98B80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60064A6")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x1700157B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ComplementOneofCase ComplementCase
	{
		[Token(Token = "0x60064A7")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(ComplementOneofCase);
		}
	}

	[Token(Token = "0x600649E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Character()
	{
	}

	[Token(Token = "0x600649F")]
	[Address(RVA = "0xB98850", Offset = "0xB97C50", VA = "0x180B98850")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Character(Character other)
	{
	}

	[Token(Token = "0x60064A0")]
	[Address(RVA = "0xB98100", Offset = "0xB97500", VA = "0x180B98100", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Character Clone()
	{
		return null;
	}

	[Token(Token = "0x60064A8")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearComplement()
	{
	}

	[Token(Token = "0x60064A9")]
	[Address(RVA = "0xB98160", Offset = "0xB97560", VA = "0x180B98160", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60064AA")]
	[Address(RVA = "0xB98270", Offset = "0xB97670", VA = "0x180B98270", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Character other)
	{
		return default(bool);
	}

	[Token(Token = "0x60064AB")]
	[Address(RVA = "0xB98340", Offset = "0xB97740", VA = "0x180B98340", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60064AC")]
	[Address(RVA = "0xB986F0", Offset = "0xB97AF0", VA = "0x180B986F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60064AD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60064AE")]
	[Address(RVA = "0xB98EA0", Offset = "0xB982A0", VA = "0x180B98EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60064AF")]
	[Address(RVA = "0xB97F90", Offset = "0xB97390", VA = "0x180B97F90", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60064B0")]
	[Address(RVA = "0xB98490", Offset = "0xB97890", VA = "0x180B98490", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(Character other)
	{
	}

	[Token(Token = "0x60064B1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60064B2")]
	[Address(RVA = "0xB98CE0", Offset = "0xB980E0", VA = "0x180B98CE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
