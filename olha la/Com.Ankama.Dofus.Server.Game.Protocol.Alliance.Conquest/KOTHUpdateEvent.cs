using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CEB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class KOTHUpdateEvent : IMessage<KOTHUpdateEvent>, IMessage, IEquatable<KOTHUpdateEvent>, IDeepCloneable<KOTHUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x2000CEC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000CED")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class KOTHAllianceInformation : IMessage<KOTHAllianceInformation>, IMessage, IEquatable<KOTHAllianceInformation>, IDeepCloneable<KOTHAllianceInformation>, IBufferMessage
		{
			[Token(Token = "0x2000CEE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000CEF")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class KOTHAllianceRoleNumber : IMessage<KOTHAllianceRoleNumber>, IMessage, IEquatable<KOTHAllianceRoleNumber>, IDeepCloneable<KOTHAllianceRoleNumber>, IBufferMessage
				{
					[Token(Token = "0x4002F9F")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<KOTHAllianceRoleNumber> _parser;

					[Token(Token = "0x4002FA0")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002FA1")]
					public const int MemberCountFieldNumber = 1;

					[Token(Token = "0x4002FA2")]
					[FieldOffset(Offset = "0x18")]
					private long memberCount_;

					[Token(Token = "0x4002FA3")]
					public const int KothRoleFieldNumber = 2;

					[Token(Token = "0x4002FA4")]
					[FieldOffset(Offset = "0x20")]
					private int kothRole_;

					[Token(Token = "0x17001DD1")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<KOTHAllianceRoleNumber> Parser
					{
						[Token(Token = "0x6008860")]
						[Address(RVA = "0xCB2E20", Offset = "0xCB2220", VA = "0x180CB2E20")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001DD2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6008861")]
						[Address(RVA = "0xCB2DA0", Offset = "0xCB21A0", VA = "0x180CB2DA0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001DD3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6008862")]
						[Address(RVA = "0xCB2E70", Offset = "0xCB2270", VA = "0x180CB2E70", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001DD4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public long MemberCount
					{
						[Token(Token = "0x6008866")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return default(long);
						}
						[Token(Token = "0x6008867")]
						[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
						set
						{
						}
					}

					[Token(Token = "0x17001DD5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int KothRole
					{
						[Token(Token = "0x6008868")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6008869")]
						[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
						set
						{
						}
					}

					[Token(Token = "0x6008863")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public KOTHAllianceRoleNumber()
					{
					}

					[Token(Token = "0x6008864")]
					[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public KOTHAllianceRoleNumber(KOTHAllianceRoleNumber other)
					{
					}

					[Token(Token = "0x6008865")]
					[Address(RVA = "0xCB2B10", Offset = "0xCB1F10", VA = "0x180CB2B10", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public KOTHAllianceRoleNumber Clone()
					{
						return null;
					}

					[Token(Token = "0x600886A")]
					[Address(RVA = "0xCB2BA0", Offset = "0xCB1FA0", VA = "0x180CB2BA0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x600886B")]
					[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(KOTHAllianceRoleNumber other)
					{
						return default(bool);
					}

					[Token(Token = "0x600886C")]
					[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x600886D")]
					[Address(RVA = "0xCB2C40", Offset = "0xCB2040", VA = "0x180CB2C40", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x600886E")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x600886F")]
					[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6008870")]
					[Address(RVA = "0xCB2A50", Offset = "0xCB1E50", VA = "0x180CB2A50", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6008871")]
					[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(KOTHAllianceRoleNumber other)
					{
					}

					[Token(Token = "0x6008872")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6008873")]
					[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000CF1")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class KOTHScore : IMessage<KOTHScore>, IMessage, IEquatable<KOTHScore>, IDeepCloneable<KOTHScore>, IBufferMessage
				{
					[Token(Token = "0x2000CF2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static class Types
					{
						[Token(Token = "0x2000CF3")]
						public enum KOTHScoreType
						{
							[Token(Token = "0x4002FAF")]
							[OriginalName("FIGHT")]
							Fight,
							[Token(Token = "0x4002FB0")]
							[OriginalName("DOMINATION")]
							Domination,
							[Token(Token = "0x4002FB1")]
							[OriginalName("PRISM")]
							Prism
						}
					}

					[Token(Token = "0x4002FA6")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<KOTHScore> _parser;

					[Token(Token = "0x4002FA7")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002FA8")]
					public const int ScoreTypeFieldNumber = 1;

					[Token(Token = "0x4002FA9")]
					[FieldOffset(Offset = "0x18")]
					private Types.KOTHScoreType scoreType_;

					[Token(Token = "0x4002FAA")]
					public const int RoundScoresFieldNumber = 2;

					[Token(Token = "0x4002FAB")]
					[FieldOffset(Offset = "0x1C")]
					private int roundScores_;

					[Token(Token = "0x4002FAC")]
					public const int CumulatedScoresFieldNumber = 3;

					[Token(Token = "0x4002FAD")]
					[FieldOffset(Offset = "0x20")]
					private int cumulatedScores_;

					[Token(Token = "0x17001DD6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<KOTHScore> Parser
					{
						[Token(Token = "0x6008878")]
						[Address(RVA = "0xCB3A00", Offset = "0xCB2E00", VA = "0x180CB3A00")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001DD7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6008879")]
						[Address(RVA = "0xCB3980", Offset = "0xCB2D80", VA = "0x180CB3980")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001DD8")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x600887A")]
						[Address(RVA = "0xCB3A50", Offset = "0xCB2E50", VA = "0x180CB3A50", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001DD9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Types.KOTHScoreType ScoreType
					{
						[Token(Token = "0x600887E")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(Types.KOTHScoreType);
						}
						[Token(Token = "0x600887F")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17001DDA")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int RoundScores
					{
						[Token(Token = "0x6008880")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6008881")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x17001DDB")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CumulatedScores
					{
						[Token(Token = "0x6008882")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6008883")]
						[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
						set
						{
						}
					}

					[Token(Token = "0x600887B")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public KOTHScore()
					{
					}

					[Token(Token = "0x600887C")]
					[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public KOTHScore(KOTHScore other)
					{
					}

					[Token(Token = "0x600887D")]
					[Address(RVA = "0xCB36F0", Offset = "0xCB2AF0", VA = "0x180CB36F0", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public KOTHScore Clone()
					{
						return null;
					}

					[Token(Token = "0x6008884")]
					[Address(RVA = "0xCB3780", Offset = "0xCB2B80", VA = "0x180CB3780", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6008885")]
					[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(KOTHScore other)
					{
						return default(bool);
					}

					[Token(Token = "0x6008886")]
					[Address(RVA = "0x998170", Offset = "0x997570", VA = "0x180998170", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6008887")]
					[Address(RVA = "0xCB3820", Offset = "0xCB2C20", VA = "0x180CB3820", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6008888")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6008889")]
					[Address(RVA = "0x998470", Offset = "0x997870", VA = "0x180998470", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x600888A")]
					[Address(RVA = "0xCB3610", Offset = "0xCB2A10", VA = "0x180CB3610", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x600888B")]
					[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(KOTHScore other)
					{
					}

					[Token(Token = "0x600888C")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x600888D")]
					[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4002F91")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<KOTHAllianceInformation> _parser;

			[Token(Token = "0x4002F92")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002F93")]
			public const int AllianceFieldNumber = 1;

			[Token(Token = "0x4002F94")]
			[FieldOffset(Offset = "0x18")]
			private AllianceInformation alliance_;

			[Token(Token = "0x4002F95")]
			public const int MemberCountFieldNumber = 2;

			[Token(Token = "0x4002F96")]
			[FieldOffset(Offset = "0x20")]
			private long memberCount_;

			[Token(Token = "0x4002F97")]
			public const int KothRolesFieldNumber = 3;

			[Token(Token = "0x4002F98")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<Types.KOTHAllianceRoleNumber> _repeated_kothRoles_codec;

			[Token(Token = "0x4002F99")]
			[FieldOffset(Offset = "0x28")]
			private readonly RepeatedField<Types.KOTHAllianceRoleNumber> kothRoles_;

			[Token(Token = "0x4002F9A")]
			public const int ScoresFieldNumber = 4;

			[Token(Token = "0x4002F9B")]
			[FieldOffset(Offset = "0x10")]
			private static readonly FieldCodec<Types.KOTHScore> _repeated_scores_codec;

			[Token(Token = "0x4002F9C")]
			[FieldOffset(Offset = "0x30")]
			private readonly RepeatedField<Types.KOTHScore> scores_;

			[Token(Token = "0x4002F9D")]
			public const int MatchDominationScoresFieldNumber = 5;

			[Token(Token = "0x4002F9E")]
			[FieldOffset(Offset = "0x38")]
			private int matchDominationScores_;

			[Token(Token = "0x17001DC9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<KOTHAllianceInformation> Parser
			{
				[Token(Token = "0x6008847")]
				[Address(RVA = "0xCB2660", Offset = "0xCB1A60", VA = "0x180CB2660")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001DCA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6008848")]
				[Address(RVA = "0xCB25E0", Offset = "0xCB19E0", VA = "0x180CB25E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001DCB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6008849")]
				[Address(RVA = "0xCB2A10", Offset = "0xCB1E10", VA = "0x180CB2A10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001DCC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AllianceInformation Alliance
			{
				[Token(Token = "0x600884D")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x600884E")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17001DCD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long MemberCount
			{
				[Token(Token = "0x600884F")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6008850")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x17001DCE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<Types.KOTHAllianceRoleNumber> KothRoles
			{
				[Token(Token = "0x6008851")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001DCF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<Types.KOTHScore> Scores
			{
				[Token(Token = "0x6008852")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001DD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MatchDominationScores
			{
				[Token(Token = "0x6008853")]
				[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6008854")]
				[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
				set
				{
				}
			}

			[Token(Token = "0x600884A")]
			[Address(RVA = "0xCB2420", Offset = "0xCB1820", VA = "0x180CB2420")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public KOTHAllianceInformation()
			{
			}

			[Token(Token = "0x600884B")]
			[Address(RVA = "0xCB24E0", Offset = "0xCB18E0", VA = "0x180CB24E0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public KOTHAllianceInformation(KOTHAllianceInformation other)
			{
			}

			[Token(Token = "0x600884C")]
			[Address(RVA = "0xCB1C00", Offset = "0xCB1000", VA = "0x180CB1C00", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public KOTHAllianceInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x6008855")]
			[Address(RVA = "0xCB1E10", Offset = "0xCB1210", VA = "0x180CB1E10", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6008856")]
			[Address(RVA = "0xCB1D30", Offset = "0xCB1130", VA = "0x180CB1D30", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(KOTHAllianceInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x6008857")]
			[Address(RVA = "0xCB1F40", Offset = "0xCB1340", VA = "0x180CB1F40", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6008858")]
			[Address(RVA = "0xCB2170", Offset = "0xCB1570", VA = "0x180CB2170", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6008859")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600885A")]
			[Address(RVA = "0xCB28C0", Offset = "0xCB1CC0", VA = "0x180CB28C0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600885B")]
			[Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600885C")]
			[Address(RVA = "0xCB2040", Offset = "0xCB1440", VA = "0x180CB2040", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(KOTHAllianceInformation other)
			{
			}

			[Token(Token = "0x600885D")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600885E")]
			[Address(RVA = "0xCB26B0", Offset = "0xCB1AB0", VA = "0x180CB26B0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002F88")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<KOTHUpdateEvent> _parser;

	[Token(Token = "0x4002F89")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F8A")]
	public const int KothAllianceInformationFieldNumber = 1;

	[Token(Token = "0x4002F8B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.KOTHAllianceInformation> _repeated_kothAllianceInformation_codec;

	[Token(Token = "0x4002F8C")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.KOTHAllianceInformation> kothAllianceInformation_;

	[Token(Token = "0x4002F8D")]
	public const int StartingAvaTimestampFieldNumber = 2;

	[Token(Token = "0x4002F8E")]
	[FieldOffset(Offset = "0x20")]
	private string startingAvaTimestamp_;

	[Token(Token = "0x4002F8F")]
	public const int NextTickTimeFieldNumber = 3;

	[Token(Token = "0x4002F90")]
	[FieldOffset(Offset = "0x28")]
	private long nextTickTime_;

	[Token(Token = "0x17001DC3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<KOTHUpdateEvent> Parser
	{
		[Token(Token = "0x6008831")]
		[Address(RVA = "0xCB43F0", Offset = "0xCB37F0", VA = "0x180CB43F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DC4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008832")]
		[Address(RVA = "0xCB4340", Offset = "0xCB3740", VA = "0x180CB4340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DC5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008833")]
		[Address(RVA = "0xCB46A0", Offset = "0xCB3AA0", VA = "0x180CB46A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DC6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.KOTHAllianceInformation> KothAllianceInformation
	{
		[Token(Token = "0x6008837")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DC7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string StartingAvaTimestamp
	{
		[Token(Token = "0x6008838")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008839")]
		[Address(RVA = "0xCB46E0", Offset = "0xCB3AE0", VA = "0x180CB46E0")]
		set
		{
		}
	}

	[Token(Token = "0x17001DC8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NextTickTime
	{
		[Token(Token = "0x600883A")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600883B")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6008834")]
	[Address(RVA = "0xCB41F0", Offset = "0xCB35F0", VA = "0x180CB41F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public KOTHUpdateEvent()
	{
	}

	[Token(Token = "0x6008835")]
	[Address(RVA = "0xCB4290", Offset = "0xCB3690", VA = "0x180CB4290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public KOTHUpdateEvent(KOTHUpdateEvent other)
	{
	}

	[Token(Token = "0x6008836")]
	[Address(RVA = "0xCB3C20", Offset = "0xCB3020", VA = "0x180CB3C20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOTHUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600883C")]
	[Address(RVA = "0xCB3DA0", Offset = "0xCB31A0", VA = "0x180CB3DA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600883D")]
	[Address(RVA = "0xCB3CF0", Offset = "0xCB30F0", VA = "0x180CB3CF0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KOTHUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600883E")]
	[Address(RVA = "0xCB3E90", Offset = "0xCB3290", VA = "0x180CB3E90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600883F")]
	[Address(RVA = "0xCB3FF0", Offset = "0xCB33F0", VA = "0x180CB3FF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008840")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008841")]
	[Address(RVA = "0xCB45A0", Offset = "0xCB39A0", VA = "0x180CB45A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008842")]
	[Address(RVA = "0xCB3B00", Offset = "0xCB2F00", VA = "0x180CB3B00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008843")]
	[Address(RVA = "0xCB3F40", Offset = "0xCB3340", VA = "0x180CB3F40", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(KOTHUpdateEvent other)
	{
	}

	[Token(Token = "0x6008844")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008845")]
	[Address(RVA = "0xCB4440", Offset = "0xCB3840", VA = "0x180CB4440", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
