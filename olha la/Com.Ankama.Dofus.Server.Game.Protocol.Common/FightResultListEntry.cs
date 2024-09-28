using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A5B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightResultListEntry : IMessage<FightResultListEntry>, IMessage, IEquatable<FightResultListEntry>, IDeepCloneable<FightResultListEntry>, IBufferMessage
{
	[Token(Token = "0x2000A5C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000A5D")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class FightLoot : IMessage<FightLoot>, IMessage, IEquatable<FightLoot>, IDeepCloneable<FightLoot>, IBufferMessage
		{
			[Token(Token = "0x2000A5E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000A5F")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class Object : IMessage<Object>, IMessage, IEquatable<Object>, IDeepCloneable<Object>, IBufferMessage
				{
					[Token(Token = "0x400258B")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<Object> _parser;

					[Token(Token = "0x400258C")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x400258D")]
					public const int IdFieldNumber = 1;

					[Token(Token = "0x400258E")]
					[FieldOffset(Offset = "0x18")]
					private int id_;

					[Token(Token = "0x400258F")]
					public const int QuantityFieldNumber = 2;

					[Token(Token = "0x4002590")]
					[FieldOffset(Offset = "0x1C")]
					private int quantity_;

					[Token(Token = "0x4002591")]
					public const int PriorityHintFieldNumber = 3;

					[Token(Token = "0x4002592")]
					[FieldOffset(Offset = "0x20")]
					private int priorityHint_;

					[Token(Token = "0x17001780")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<Object> Parser
					{
						[Token(Token = "0x6006C76")]
						[Address(RVA = "0xBD74D0", Offset = "0xBD68D0", VA = "0x180BD74D0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001781")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6006C77")]
						[Address(RVA = "0xBD7450", Offset = "0xBD6850", VA = "0x180BD7450")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001782")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6006C78")]
						[Address(RVA = "0xBD7520", Offset = "0xBD6920", VA = "0x180BD7520", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001783")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int Id
					{
						[Token(Token = "0x6006C7C")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006C7D")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17001784")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int Quantity
					{
						[Token(Token = "0x6006C7E")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006C7F")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x17001785")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int PriorityHint
					{
						[Token(Token = "0x6006C80")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006C81")]
						[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
						set
						{
						}
					}

					[Token(Token = "0x6006C79")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Object()
					{
					}

					[Token(Token = "0x6006C7A")]
					[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Object(Object other)
					{
					}

					[Token(Token = "0x6006C7B")]
					[Address(RVA = "0xBD71C0", Offset = "0xBD65C0", VA = "0x180BD71C0", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Object Clone()
					{
						return null;
					}

					[Token(Token = "0x6006C82")]
					[Address(RVA = "0xBD7250", Offset = "0xBD6650", VA = "0x180BD7250", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006C83")]
					[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(Object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006C84")]
					[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6006C85")]
					[Address(RVA = "0xBD72F0", Offset = "0xBD66F0", VA = "0x180BD72F0", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6006C86")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6006C87")]
					[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6006C88")]
					[Address(RVA = "0xBD70E0", Offset = "0xBD64E0", VA = "0x180BD70E0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6006C89")]
					[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(Object other)
					{
					}

					[Token(Token = "0x6006C8A")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6006C8B")]
					[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4002584")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<FightLoot> _parser;

			[Token(Token = "0x4002585")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002586")]
			public const int ObjectsFieldNumber = 1;

			[Token(Token = "0x4002587")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<Types.Object> _repeated_objects_codec;

			[Token(Token = "0x4002588")]
			[FieldOffset(Offset = "0x18")]
			private readonly RepeatedField<Types.Object> objects_;

			[Token(Token = "0x4002589")]
			public const int KamasFieldNumber = 2;

			[Token(Token = "0x400258A")]
			[FieldOffset(Offset = "0x20")]
			private long kamas_;

			[Token(Token = "0x1700177B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<FightLoot> Parser
			{
				[Token(Token = "0x6006C62")]
				[Address(RVA = "0xBCA4C0", Offset = "0xBC98C0", VA = "0x180BCA4C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700177C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006C63")]
				[Address(RVA = "0xBCA440", Offset = "0xBC9840", VA = "0x180BCA440")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700177D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006C64")]
				[Address(RVA = "0xBCA710", Offset = "0xBC9B10", VA = "0x180BCA710", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700177E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<Types.Object> Objects
			{
				[Token(Token = "0x6006C68")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700177F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long Kamas
			{
				[Token(Token = "0x6006C69")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006C6A")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x6006C65")]
			[Address(RVA = "0xBCA3C0", Offset = "0xBC97C0", VA = "0x180BCA3C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightLoot()
			{
			}

			[Token(Token = "0x6006C66")]
			[Address(RVA = "0xBCA320", Offset = "0xBC9720", VA = "0x180BCA320")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightLoot(FightLoot other)
			{
			}

			[Token(Token = "0x6006C67")]
			[Address(RVA = "0xBC9E50", Offset = "0xBC9250", VA = "0x180BC9E50", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightLoot Clone()
			{
				return null;
			}

			[Token(Token = "0x6006C6B")]
			[Address(RVA = "0xBC9F10", Offset = "0xBC9310", VA = "0x180BC9F10", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006C6C")]
			[Address(RVA = "0xBC9FF0", Offset = "0xBC93F0", VA = "0x180BC9FF0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(FightLoot other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006C6D")]
			[Address(RVA = "0x983110", Offset = "0x982510", VA = "0x180983110", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006C6E")]
			[Address(RVA = "0xBCA120", Offset = "0xBC9520", VA = "0x180BCA120", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006C6F")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006C70")]
			[Address(RVA = "0xBCA640", Offset = "0xBC9A40", VA = "0x180BCA640", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006C71")]
			[Address(RVA = "0xBC9D70", Offset = "0xBC9170", VA = "0x180BC9D70", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006C72")]
			[Address(RVA = "0xBCA090", Offset = "0xBC9490", VA = "0x180BCA090", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(FightLoot other)
			{
			}

			[Token(Token = "0x6006C73")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006C74")]
			[Address(RVA = "0xBCA510", Offset = "0xBC9910", VA = "0x180BCA510", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000A62")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class FighterListEntry : IMessage<FighterListEntry>, IMessage, IEquatable<FighterListEntry>, IDeepCloneable<FighterListEntry>, IBufferMessage
		{
			[Token(Token = "0x2000A63")]
			public enum ComplementOneofCase
			{
				[Token(Token = "0x40025A1")]
				None = 0,
				[Token(Token = "0x40025A2")]
				PlayerListEntry = 3,
				[Token(Token = "0x40025A3")]
				MutantListEntry = 4,
				[Token(Token = "0x40025A4")]
				TaxCollectorListEntry = 5
			}

			[Token(Token = "0x2000A64")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000A65")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class PlayerListEntry : IMessage<PlayerListEntry>, IMessage, IEquatable<PlayerListEntry>, IDeepCloneable<PlayerListEntry>, IBufferMessage
				{
					[Token(Token = "0x2000A66")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static class Types
					{
						[Token(Token = "0x2000A67")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class FightResultAdditionalData : IMessage<FightResultAdditionalData>, IMessage, IEquatable<FightResultAdditionalData>, IDeepCloneable<FightResultAdditionalData>, IBufferMessage
						{
							[Token(Token = "0x2000A68")]
							public enum AdditionalDataOneofCase
							{
								[Token(Token = "0x40025B3")]
								None,
								[Token(Token = "0x40025B4")]
								ExperienceData,
								[Token(Token = "0x40025B5")]
								PvpData
							}

							[Token(Token = "0x2000A69")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static class Types
							{
								[Token(Token = "0x2000A6A")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class ExperienceData : IMessage<ExperienceData>, IMessage, IEquatable<ExperienceData>, IDeepCloneable<ExperienceData>, IBufferMessage
								{
									[Token(Token = "0x40025B6")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<ExperienceData> _parser;

									[Token(Token = "0x40025B7")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x40025B8")]
									public const int ExperienceFieldNumber = 1;

									[Token(Token = "0x40025B9")]
									[FieldOffset(Offset = "0x18")]
									private long experience_;

									[Token(Token = "0x40025BA")]
									public const int ShowExperienceFieldNumber = 2;

									[Token(Token = "0x40025BB")]
									[FieldOffset(Offset = "0x20")]
									private bool showExperience_;

									[Token(Token = "0x40025BC")]
									public const int ExperienceLevelFloorFieldNumber = 3;

									[Token(Token = "0x40025BD")]
									[FieldOffset(Offset = "0x28")]
									private long experienceLevelFloor_;

									[Token(Token = "0x40025BE")]
									public const int ShowExperienceLevelFloorFieldNumber = 4;

									[Token(Token = "0x40025BF")]
									[FieldOffset(Offset = "0x30")]
									private bool showExperienceLevelFloor_;

									[Token(Token = "0x40025C0")]
									public const int ExperienceNextLevelFloorFieldNumber = 5;

									[Token(Token = "0x40025C1")]
									[FieldOffset(Offset = "0x38")]
									private long experienceNextLevelFloor_;

									[Token(Token = "0x40025C2")]
									public const int ShowExperienceNextLevelFloorFieldNumber = 6;

									[Token(Token = "0x40025C3")]
									[FieldOffset(Offset = "0x40")]
									private bool showExperienceNextLevelFloor_;

									[Token(Token = "0x40025C4")]
									public const int ExperienceFightDeltaFieldNumber = 7;

									[Token(Token = "0x40025C5")]
									[FieldOffset(Offset = "0x48")]
									private long experienceFightDelta_;

									[Token(Token = "0x40025C6")]
									public const int ShowExperienceFightDeltaFieldNumber = 8;

									[Token(Token = "0x40025C7")]
									[FieldOffset(Offset = "0x50")]
									private bool showExperienceFightDelta_;

									[Token(Token = "0x40025C8")]
									public const int ExperienceForGuildFieldNumber = 9;

									[Token(Token = "0x40025C9")]
									[FieldOffset(Offset = "0x58")]
									private long experienceForGuild_;

									[Token(Token = "0x40025CA")]
									public const int ShowExperienceForGuildFieldNumber = 10;

									[Token(Token = "0x40025CB")]
									[FieldOffset(Offset = "0x60")]
									private bool showExperienceForGuild_;

									[Token(Token = "0x40025CC")]
									public const int ExperienceForMountFieldNumber = 11;

									[Token(Token = "0x40025CD")]
									[FieldOffset(Offset = "0x68")]
									private long experienceForMount_;

									[Token(Token = "0x40025CE")]
									public const int ShowExperienceForMountFieldNumber = 12;

									[Token(Token = "0x40025CF")]
									[FieldOffset(Offset = "0x70")]
									private bool showExperienceForMount_;

									[Token(Token = "0x40025D0")]
									public const int ReRollExperienceMultiplierFieldNumber = 13;

									[Token(Token = "0x40025D1")]
									[FieldOffset(Offset = "0x74")]
									private int reRollExperienceMultiplier_;

									[Token(Token = "0x1700179A")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<ExperienceData> Parser
									{
										[Token(Token = "0x6006CDB")]
										[Address(RVA = "0xBC85C0", Offset = "0xBC79C0", VA = "0x180BC85C0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700179B")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x6006CDC")]
										[Address(RVA = "0xBC8540", Offset = "0xBC7940", VA = "0x180BC8540")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700179C")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x6006CDD")]
										[Address(RVA = "0xBC8A60", Offset = "0xBC7E60", VA = "0x180BC8A60", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700179D")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public long Experience
									{
										[Token(Token = "0x6006CE1")]
										[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
										get
										{
											return default(long);
										}
										[Token(Token = "0x6006CE2")]
										[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
										set
										{
										}
									}

									[Token(Token = "0x1700179E")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool ShowExperience
									{
										[Token(Token = "0x6006CE3")]
										[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
										get
										{
											return default(bool);
										}
										[Token(Token = "0x6006CE4")]
										[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
										set
										{
										}
									}

									[Token(Token = "0x1700179F")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public long ExperienceLevelFloor
									{
										[Token(Token = "0x6006CE5")]
										[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
										get
										{
											return default(long);
										}
										[Token(Token = "0x6006CE6")]
										[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
										set
										{
										}
									}

									[Token(Token = "0x170017A0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool ShowExperienceLevelFloor
									{
										[Token(Token = "0x6006CE7")]
										[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
										get
										{
											return default(bool);
										}
										[Token(Token = "0x6006CE8")]
										[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
										set
										{
										}
									}

									[Token(Token = "0x170017A1")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public long ExperienceNextLevelFloor
									{
										[Token(Token = "0x6006CE9")]
										[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
										get
										{
											return default(long);
										}
										[Token(Token = "0x6006CEA")]
										[Address(RVA = "0x9EFE00", Offset = "0x9EF200", VA = "0x1809EFE00")]
										set
										{
										}
									}

									[Token(Token = "0x170017A2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool ShowExperienceNextLevelFloor
									{
										[Token(Token = "0x6006CEB")]
										[Address(RVA = "0x871BC0", Offset = "0x870FC0", VA = "0x180871BC0")]
										get
										{
											return default(bool);
										}
										[Token(Token = "0x6006CEC")]
										[Address(RVA = "0x96EC00", Offset = "0x96E000", VA = "0x18096EC00")]
										set
										{
										}
									}

									[Token(Token = "0x170017A3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public long ExperienceFightDelta
									{
										[Token(Token = "0x6006CED")]
										[Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
										get
										{
											return default(long);
										}
										[Token(Token = "0x6006CEE")]
										[Address(RVA = "0xB9E9F0", Offset = "0xB9DDF0", VA = "0x180B9E9F0")]
										set
										{
										}
									}

									[Token(Token = "0x170017A4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool ShowExperienceFightDelta
									{
										[Token(Token = "0x6006CEF")]
										[Address(RVA = "0x873220", Offset = "0x872620", VA = "0x180873220")]
										get
										{
											return default(bool);
										}
										[Token(Token = "0x6006CF0")]
										[Address(RVA = "0x873280", Offset = "0x872680", VA = "0x180873280")]
										set
										{
										}
									}

									[Token(Token = "0x170017A5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public long ExperienceForGuild
									{
										[Token(Token = "0x6006CF1")]
										[Address(RVA = "0x9124F0", Offset = "0x9118F0", VA = "0x1809124F0")]
										get
										{
											return default(long);
										}
										[Token(Token = "0x6006CF2")]
										[Address(RVA = "0xBC8B10", Offset = "0xBC7F10", VA = "0x180BC8B10")]
										set
										{
										}
									}

									[Token(Token = "0x170017A6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool ShowExperienceForGuild
									{
										[Token(Token = "0x6006CF3")]
										[Address(RVA = "0xBC8620", Offset = "0xBC7A20", VA = "0x180BC8620")]
										get
										{
											return default(bool);
										}
										[Token(Token = "0x6006CF4")]
										[Address(RVA = "0xBC8B40", Offset = "0xBC7F40", VA = "0x180BC8B40")]
										set
										{
										}
									}

									[Token(Token = "0x170017A7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public long ExperienceForMount
									{
										[Token(Token = "0x6006CF5")]
										[Address(RVA = "0x8E5D30", Offset = "0x8E5130", VA = "0x1808E5D30")]
										get
										{
											return default(long);
										}
										[Token(Token = "0x6006CF6")]
										[Address(RVA = "0xBC8B20", Offset = "0xBC7F20", VA = "0x180BC8B20")]
										set
										{
										}
									}

									[Token(Token = "0x170017A8")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public bool ShowExperienceForMount
									{
										[Token(Token = "0x6006CF7")]
										[Address(RVA = "0x878B10", Offset = "0x877F10", VA = "0x180878B10")]
										get
										{
											return default(bool);
										}
										[Token(Token = "0x6006CF8")]
										[Address(RVA = "0x878BC0", Offset = "0x877FC0", VA = "0x180878BC0")]
										set
										{
										}
									}

									[Token(Token = "0x170017A9")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int ReRollExperienceMultiplier
									{
										[Token(Token = "0x6006CF9")]
										[Address(RVA = "0xBC8610", Offset = "0xBC7A10", VA = "0x180BC8610")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006CFA")]
										[Address(RVA = "0xBC8B30", Offset = "0xBC7F30", VA = "0x180BC8B30")]
										set
										{
										}
									}

									[Token(Token = "0x6006CDE")]
									[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public ExperienceData()
									{
									}

									[Token(Token = "0x6006CDF")]
									[Address(RVA = "0xBC8490", Offset = "0xBC7890", VA = "0x180BC8490")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public ExperienceData(ExperienceData other)
									{
									}

									[Token(Token = "0x6006CE0")]
									[Address(RVA = "0xBC7D60", Offset = "0xBC7160", VA = "0x180BC7D60", Slot = "10")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public ExperienceData Clone()
									{
										return null;
									}

									[Token(Token = "0x6006CFB")]
									[Address(RVA = "0xBC7E40", Offset = "0xBC7240", VA = "0x180BC7E40", Slot = "0")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006CFC")]
									[Address(RVA = "0xBC7F60", Offset = "0xBC7360", VA = "0x180BC7F60", Slot = "9")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public bool Equals(ExperienceData other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006CFD")]
									[Address(RVA = "0xBC8010", Offset = "0xBC7410", VA = "0x180BC8010", Slot = "2")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x6006CFE")]
									[Address(RVA = "0xBC8330", Offset = "0xBC7730", VA = "0x180BC8330", Slot = "3")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x6006CFF")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x6006D00")]
									[Address(RVA = "0xBC8870", Offset = "0xBC7C70", VA = "0x180BC8870", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006D01")]
									[Address(RVA = "0xBC7B90", Offset = "0xBC6F90", VA = "0x180BC7B90", Slot = "7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x6006D02")]
									[Address(RVA = "0xBC8240", Offset = "0xBC7640", VA = "0x180BC8240", Slot = "4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(ExperienceData other)
									{
									}

									[Token(Token = "0x6006D03")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x6006D04")]
									[Address(RVA = "0xBC8630", Offset = "0xBC7A30", VA = "0x180BC8630", Slot = "11")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}

								[Token(Token = "0x2000A6C")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class PvpData : IMessage<PvpData>, IMessage, IEquatable<PvpData>, IDeepCloneable<PvpData>, IBufferMessage
								{
									[Token(Token = "0x40025D3")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<PvpData> _parser;

									[Token(Token = "0x40025D4")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x40025D5")]
									public const int GradeFieldNumber = 1;

									[Token(Token = "0x40025D6")]
									[FieldOffset(Offset = "0x18")]
									private int grade_;

									[Token(Token = "0x40025D7")]
									public const int MinHonorForGradeFieldNumber = 2;

									[Token(Token = "0x40025D8")]
									[FieldOffset(Offset = "0x1C")]
									private int minHonorForGrade_;

									[Token(Token = "0x40025D9")]
									public const int MaxHonorForGradeFieldNumber = 3;

									[Token(Token = "0x40025DA")]
									[FieldOffset(Offset = "0x20")]
									private int maxHonorForGrade_;

									[Token(Token = "0x40025DB")]
									public const int HonorFieldNumber = 4;

									[Token(Token = "0x40025DC")]
									[FieldOffset(Offset = "0x24")]
									private int honor_;

									[Token(Token = "0x40025DD")]
									public const int HonorDeltaFieldNumber = 5;

									[Token(Token = "0x40025DE")]
									[FieldOffset(Offset = "0x28")]
									private int honorDelta_;

									[Token(Token = "0x170017AA")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<PvpData> Parser
									{
										[Token(Token = "0x6006D09")]
										[Address(RVA = "0xBD8400", Offset = "0xBD7800", VA = "0x180BD8400")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170017AB")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x6006D0A")]
										[Address(RVA = "0xBD8380", Offset = "0xBD7780", VA = "0x180BD8380")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170017AC")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x6006D0B")]
										[Address(RVA = "0xBD8450", Offset = "0xBD7850", VA = "0x180BD8450", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170017AD")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int Grade
									{
										[Token(Token = "0x6006D0F")]
										[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006D10")]
										[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
										set
										{
										}
									}

									[Token(Token = "0x170017AE")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int MinHonorForGrade
									{
										[Token(Token = "0x6006D11")]
										[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006D12")]
										[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
										set
										{
										}
									}

									[Token(Token = "0x170017AF")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int MaxHonorForGrade
									{
										[Token(Token = "0x6006D13")]
										[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006D14")]
										[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
										set
										{
										}
									}

									[Token(Token = "0x170017B0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int Honor
									{
										[Token(Token = "0x6006D15")]
										[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006D16")]
										[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
										set
										{
										}
									}

									[Token(Token = "0x170017B1")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int HonorDelta
									{
										[Token(Token = "0x6006D17")]
										[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006D18")]
										[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
										set
										{
										}
									}

									[Token(Token = "0x6006D0C")]
									[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public PvpData()
									{
									}

									[Token(Token = "0x6006D0D")]
									[Address(RVA = "0xA55430", Offset = "0xA54830", VA = "0x180A55430")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public PvpData(PvpData other)
									{
									}

									[Token(Token = "0x6006D0E")]
									[Address(RVA = "0xBD80D0", Offset = "0xBD74D0", VA = "0x180BD80D0", Slot = "10")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public PvpData Clone()
									{
										return null;
									}

									[Token(Token = "0x6006D19")]
									[Address(RVA = "0xBD8170", Offset = "0xBD7570", VA = "0x180BD8170", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006D1A")]
									[Address(RVA = "0xA55120", Offset = "0xA54520", VA = "0x180A55120", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(PvpData other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006D1B")]
									[Address(RVA = "0xA55170", Offset = "0xA54570", VA = "0x180A55170", Slot = "2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x6006D1C")]
									[Address(RVA = "0xBD8220", Offset = "0xBD7620", VA = "0x180BD8220", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x6006D1D")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x6006D1E")]
									[Address(RVA = "0xA556B0", Offset = "0xA54AB0", VA = "0x180A556B0", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006D1F")]
									[Address(RVA = "0xBD7FA0", Offset = "0xBD73A0", VA = "0x180BD7FA0", Slot = "7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x6006D20")]
									[Address(RVA = "0xA55250", Offset = "0xA54650", VA = "0x180A55250", Slot = "4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(PvpData other)
									{
									}

									[Token(Token = "0x6006D21")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x6006D22")]
									[Address(RVA = "0xA555A0", Offset = "0xA549A0", VA = "0x180A555A0", Slot = "11")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}
							}

							[Token(Token = "0x40025AC")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<FightResultAdditionalData> _parser;

							[Token(Token = "0x40025AD")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x40025AE")]
							public const int ExperienceDataFieldNumber = 1;

							[Token(Token = "0x40025AF")]
							public const int PvpDataFieldNumber = 2;

							[Token(Token = "0x40025B0")]
							[FieldOffset(Offset = "0x18")]
							private object additionalData_;

							[Token(Token = "0x40025B1")]
							[FieldOffset(Offset = "0x20")]
							private AdditionalDataOneofCase additionalDataCase_;

							[Token(Token = "0x17001794")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<FightResultAdditionalData> Parser
							{
								[Token(Token = "0x6006CC4")]
								[Address(RVA = "0xBCC3A0", Offset = "0xBCB7A0", VA = "0x180BCC3A0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001795")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x6006CC5")]
								[Address(RVA = "0xBCC2C0", Offset = "0xBCB6C0", VA = "0x180BCC2C0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001796")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x6006CC6")]
								[Address(RVA = "0xBCC700", Offset = "0xBCBB00", VA = "0x180BCC700", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001797")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.ExperienceData ExperienceData
							{
								[Token(Token = "0x6006CCA")]
								[Address(RVA = "0xBCC340", Offset = "0xBCB740", VA = "0x180BCC340")]
								get
								{
									return null;
								}
								[Token(Token = "0x6006CCB")]
								[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
								set
								{
								}
							}

							[Token(Token = "0x17001798")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.PvpData PvpData
							{
								[Token(Token = "0x6006CCC")]
								[Address(RVA = "0xBCC3F0", Offset = "0xBCB7F0", VA = "0x180BCC3F0")]
								get
								{
									return null;
								}
								[Token(Token = "0x6006CCD")]
								[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
								set
								{
								}
							}

							[Token(Token = "0x17001799")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public AdditionalDataOneofCase AdditionalDataCase
							{
								[Token(Token = "0x6006CCE")]
								[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
								get
								{
									return default(AdditionalDataOneofCase);
								}
							}

							[Token(Token = "0x6006CC7")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public FightResultAdditionalData()
							{
							}

							[Token(Token = "0x6006CC8")]
							[Address(RVA = "0xBCC050", Offset = "0xBCB450", VA = "0x180BCC050")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public FightResultAdditionalData(FightResultAdditionalData other)
							{
							}

							[Token(Token = "0x6006CC9")]
							[Address(RVA = "0xBCB820", Offset = "0xBCAC20", VA = "0x180BCB820", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public FightResultAdditionalData Clone()
							{
								return null;
							}

							[Token(Token = "0x6006CCF")]
							[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void ClearAdditionalData()
							{
							}

							[Token(Token = "0x6006CD0")]
							[Address(RVA = "0xBCB880", Offset = "0xBCAC80", VA = "0x180BCB880", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x6006CD1")]
							[Address(RVA = "0xBCB9F0", Offset = "0xBCADF0", VA = "0x180BCB9F0", Slot = "9")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public bool Equals(FightResultAdditionalData other)
							{
								return default(bool);
							}

							[Token(Token = "0x6006CD2")]
							[Address(RVA = "0xBCBB20", Offset = "0xBCAF20", VA = "0x180BCBB20", Slot = "2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x6006CD3")]
							[Address(RVA = "0xBCBEF0", Offset = "0xBCB2F0", VA = "0x180BCBEF0", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x6006CD4")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x6006CD5")]
							[Address(RVA = "0xBCC5F0", Offset = "0xBCB9F0", VA = "0x180BCC5F0", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x6006CD6")]
							[Address(RVA = "0xBCB6F0", Offset = "0xBCAAF0", VA = "0x180BCB6F0", Slot = "7")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x6006CD7")]
							[Address(RVA = "0xBCBC50", Offset = "0xBCB050", VA = "0x180BCBC50", Slot = "4")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(FightResultAdditionalData other)
							{
							}

							[Token(Token = "0x6006CD8")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x6006CD9")]
							[Address(RVA = "0xBCC450", Offset = "0xBCB850", VA = "0x180BCC450", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}
					}

					[Token(Token = "0x40025A5")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<PlayerListEntry> _parser;

					[Token(Token = "0x40025A6")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40025A7")]
					public const int LevelFieldNumber = 1;

					[Token(Token = "0x40025A8")]
					[FieldOffset(Offset = "0x18")]
					private int level_;

					[Token(Token = "0x40025A9")]
					public const int AdditionalFieldNumber = 2;

					[Token(Token = "0x40025AA")]
					[FieldOffset(Offset = "0x8")]
					private static readonly FieldCodec<Types.FightResultAdditionalData> _repeated_additional_codec;

					[Token(Token = "0x40025AB")]
					[FieldOffset(Offset = "0x20")]
					private readonly RepeatedField<Types.FightResultAdditionalData> additional_;

					[Token(Token = "0x1700178F")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<PlayerListEntry> Parser
					{
						[Token(Token = "0x6006CB0")]
						[Address(RVA = "0xBD7D10", Offset = "0xBD7110", VA = "0x180BD7D10")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001790")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6006CB1")]
						[Address(RVA = "0xBD7C90", Offset = "0xBD7090", VA = "0x180BD7C90")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001791")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6006CB2")]
						[Address(RVA = "0xBD7F60", Offset = "0xBD7360", VA = "0x180BD7F60", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001792")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int Level
					{
						[Token(Token = "0x6006CB6")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006CB7")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17001793")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public RepeatedField<Types.FightResultAdditionalData> Additional
					{
						[Token(Token = "0x6006CB8")]
						[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6006CB3")]
					[Address(RVA = "0xBD7B80", Offset = "0xBD6F80", VA = "0x180BD7B80")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public PlayerListEntry()
					{
					}

					[Token(Token = "0x6006CB4")]
					[Address(RVA = "0xBD7C00", Offset = "0xBD7000", VA = "0x180BD7C00")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public PlayerListEntry(PlayerListEntry other)
					{
					}

					[Token(Token = "0x6006CB5")]
					[Address(RVA = "0xBD76B0", Offset = "0xBD6AB0", VA = "0x180BD76B0", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public PlayerListEntry Clone()
					{
						return null;
					}

					[Token(Token = "0x6006CB9")]
					[Address(RVA = "0xBD7810", Offset = "0xBD6C10", VA = "0x180BD7810", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006CBA")]
					[Address(RVA = "0xBD7770", Offset = "0xBD6B70", VA = "0x180BD7770", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(PlayerListEntry other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006CBB")]
					[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6006CBC")]
					[Address(RVA = "0xBD7980", Offset = "0xBD6D80", VA = "0x180BD7980", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6006CBD")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6006CBE")]
					[Address(RVA = "0xBD7E90", Offset = "0xBD7290", VA = "0x180BD7E90", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6006CBF")]
					[Address(RVA = "0xBD75D0", Offset = "0xBD69D0", VA = "0x180BD75D0", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6006CC0")]
					[Address(RVA = "0xBD78F0", Offset = "0xBD6CF0", VA = "0x180BD78F0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(PlayerListEntry other)
					{
					}

					[Token(Token = "0x6006CC1")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6006CC2")]
					[Address(RVA = "0xBD7D60", Offset = "0xBD7160", VA = "0x180BD7D60", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000A70")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class MutantListEntry : IMessage<MutantListEntry>, IMessage, IEquatable<MutantListEntry>, IDeepCloneable<MutantListEntry>, IBufferMessage
				{
					[Token(Token = "0x40025E2")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<MutantListEntry> _parser;

					[Token(Token = "0x40025E3")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40025E4")]
					public const int LevelFieldNumber = 1;

					[Token(Token = "0x40025E5")]
					[FieldOffset(Offset = "0x18")]
					private int level_;

					[Token(Token = "0x170017B2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<MutantListEntry> Parser
					{
						[Token(Token = "0x6006D2D")]
						[Address(RVA = "0xBD6810", Offset = "0xBD5C10", VA = "0x180BD6810")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017B3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6006D2E")]
						[Address(RVA = "0xBD6790", Offset = "0xBD5B90", VA = "0x180BD6790")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017B4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6006D2F")]
						[Address(RVA = "0xBD6860", Offset = "0xBD5C60", VA = "0x180BD6860", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017B5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int Level
					{
						[Token(Token = "0x6006D33")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6006D34")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x6006D30")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public MutantListEntry()
					{
					}

					[Token(Token = "0x6006D31")]
					[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public MutantListEntry(MutantListEntry other)
					{
					}

					[Token(Token = "0x6006D32")]
					[Address(RVA = "0xBD6520", Offset = "0xBD5920", VA = "0x180BD6520", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public MutantListEntry Clone()
					{
						return null;
					}

					[Token(Token = "0x6006D35")]
					[Address(RVA = "0xBD65A0", Offset = "0xBD59A0", VA = "0x180BD65A0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006D36")]
					[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(MutantListEntry other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006D37")]
					[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6006D38")]
					[Address(RVA = "0xBD6630", Offset = "0xBD5A30", VA = "0x180BD6630", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6006D39")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6006D3A")]
					[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6006D3B")]
					[Address(RVA = "0xBD6490", Offset = "0xBD5890", VA = "0x180BD6490", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6006D3C")]
					[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(MutantListEntry other)
					{
					}

					[Token(Token = "0x6006D3D")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6006D3E")]
					[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000A72")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class TaxCollectorListEntry : IMessage<TaxCollectorListEntry>, IMessage, IEquatable<TaxCollectorListEntry>, IDeepCloneable<TaxCollectorListEntry>, IBufferMessage
				{
					[Token(Token = "0x40025E7")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<TaxCollectorListEntry> _parser;

					[Token(Token = "0x40025E8")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40025E9")]
					public const int AllianceInformationFieldNumber = 1;

					[Token(Token = "0x40025EA")]
					[FieldOffset(Offset = "0x18")]
					private AllianceInformation allianceInformation_;

					[Token(Token = "0x170017B6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<TaxCollectorListEntry> Parser
					{
						[Token(Token = "0x6006D43")]
						[Address(RVA = "0xBD8A00", Offset = "0xBD7E00", VA = "0x180BD8A00")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017B7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6006D44")]
						[Address(RVA = "0xBD8980", Offset = "0xBD7D80", VA = "0x180BD8980")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017B8")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6006D45")]
						[Address(RVA = "0xBD8B50", Offset = "0xBD7F50", VA = "0x180BD8B50", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170017B9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public AllianceInformation AllianceInformation
					{
						[Token(Token = "0x6006D49")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return null;
						}
						[Token(Token = "0x6006D4A")]
						[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
						set
						{
						}
					}

					[Token(Token = "0x6006D46")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public TaxCollectorListEntry()
					{
					}

					[Token(Token = "0x6006D47")]
					[Address(RVA = "0xBD8910", Offset = "0xBD7D10", VA = "0x180BD8910")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public TaxCollectorListEntry(TaxCollectorListEntry other)
					{
					}

					[Token(Token = "0x6006D48")]
					[Address(RVA = "0xBD8590", Offset = "0xBD7990", VA = "0x180BD8590", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public TaxCollectorListEntry Clone()
					{
						return null;
					}

					[Token(Token = "0x6006D4B")]
					[Address(RVA = "0xBD8630", Offset = "0xBD7A30", VA = "0x180BD8630", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006D4C")]
					[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(TaxCollectorListEntry other)
					{
						return default(bool);
					}

					[Token(Token = "0x6006D4D")]
					[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6006D4E")]
					[Address(RVA = "0xBD87B0", Offset = "0xBD7BB0", VA = "0x180BD87B0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6006D4F")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6006D50")]
					[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6006D51")]
					[Address(RVA = "0xBD8500", Offset = "0xBD7900", VA = "0x180BD8500", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6006D52")]
					[Address(RVA = "0xBD86E0", Offset = "0xBD7AE0", VA = "0x180BD86E0", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(TaxCollectorListEntry other)
					{
					}

					[Token(Token = "0x6006D53")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6006D54")]
					[Address(RVA = "0xBD8A50", Offset = "0xBD7E50", VA = "0x180BD8A50", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4002595")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<FighterListEntry> _parser;

			[Token(Token = "0x4002596")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002597")]
			public const int FighterIdFieldNumber = 1;

			[Token(Token = "0x4002598")]
			[FieldOffset(Offset = "0x18")]
			private long fighterId_;

			[Token(Token = "0x4002599")]
			public const int AliveFieldNumber = 2;

			[Token(Token = "0x400259A")]
			[FieldOffset(Offset = "0x20")]
			private bool alive_;

			[Token(Token = "0x400259B")]
			public const int PlayerListEntryFieldNumber = 3;

			[Token(Token = "0x400259C")]
			public const int MutantListEntryFieldNumber = 4;

			[Token(Token = "0x400259D")]
			public const int TaxCollectorListEntryFieldNumber = 5;

			[Token(Token = "0x400259E")]
			[FieldOffset(Offset = "0x28")]
			private object complement_;

			[Token(Token = "0x400259F")]
			[FieldOffset(Offset = "0x30")]
			private ComplementOneofCase complementCase_;

			[Token(Token = "0x17001786")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<FighterListEntry> Parser
			{
				[Token(Token = "0x6006C93")]
				[Address(RVA = "0xBCFEA0", Offset = "0xBCF2A0", VA = "0x180BCFEA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001787")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006C94")]
				[Address(RVA = "0xBCFDC0", Offset = "0xBCF1C0", VA = "0x180BCFDC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001788")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006C95")]
				[Address(RVA = "0xBD0410", Offset = "0xBCF810", VA = "0x180BD0410", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001789")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long FighterId
			{
				[Token(Token = "0x6006C99")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006C9A")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x1700178A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Alive
			{
				[Token(Token = "0x6006C9B")]
				[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6006C9C")]
				[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
				set
				{
				}
			}

			[Token(Token = "0x1700178B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.PlayerListEntry PlayerListEntry
			{
				[Token(Token = "0x6006C9D")]
				[Address(RVA = "0xBCFEF0", Offset = "0xBCF2F0", VA = "0x180BCFEF0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006C9E")]
				[Address(RVA = "0x91BB80", Offset = "0x91AF80", VA = "0x18091BB80")]
				set
				{
				}
			}

			[Token(Token = "0x1700178C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.MutantListEntry MutantListEntry
			{
				[Token(Token = "0x6006C9F")]
				[Address(RVA = "0xBCFE40", Offset = "0xBCF240", VA = "0x180BCFE40")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006CA0")]
				[Address(RVA = "0x91BB40", Offset = "0x91AF40", VA = "0x18091BB40")]
				set
				{
				}
			}

			[Token(Token = "0x1700178D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.TaxCollectorListEntry TaxCollectorListEntry
			{
				[Token(Token = "0x6006CA1")]
				[Address(RVA = "0xBCFF50", Offset = "0xBCF350", VA = "0x180BCFF50")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006CA2")]
				[Address(RVA = "0x9FA5D0", Offset = "0x9F99D0", VA = "0x1809FA5D0")]
				set
				{
				}
			}

			[Token(Token = "0x1700178E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ComplementOneofCase ComplementCase
			{
				[Token(Token = "0x6006CA3")]
				[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
				get
				{
					return default(ComplementOneofCase);
				}
			}

			[Token(Token = "0x6006C96")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FighterListEntry()
			{
			}

			[Token(Token = "0x6006C97")]
			[Address(RVA = "0xBCFA60", Offset = "0xBCEE60", VA = "0x180BCFA60")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FighterListEntry(FighterListEntry other)
			{
			}

			[Token(Token = "0x6006C98")]
			[Address(RVA = "0xBCF1F0", Offset = "0xBCE5F0", VA = "0x180BCF1F0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FighterListEntry Clone()
			{
				return null;
			}

			[Token(Token = "0x6006CA4")]
			[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearComplement()
			{
			}

			[Token(Token = "0x6006CA5")]
			[Address(RVA = "0xBCF360", Offset = "0xBCE760", VA = "0x180BCF360", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006CA6")]
			[Address(RVA = "0xBCF250", Offset = "0xBCE650", VA = "0x180BCF250", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(FighterListEntry other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006CA7")]
			[Address(RVA = "0xBCF4B0", Offset = "0xBCE8B0", VA = "0x180BCF4B0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006CA8")]
			[Address(RVA = "0xBCF900", Offset = "0xBCED00", VA = "0x180BCF900", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006CA9")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006CAA")]
			[Address(RVA = "0xBD0250", Offset = "0xBCF650", VA = "0x180BD0250", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006CAB")]
			[Address(RVA = "0xBCF000", Offset = "0xBCE400", VA = "0x180BCF000", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006CAC")]
			[Address(RVA = "0xBCF6C0", Offset = "0xBCEAC0", VA = "0x180BCF6C0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(FighterListEntry other)
			{
			}

			[Token(Token = "0x6006CAD")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006CAE")]
			[Address(RVA = "0xBCFFB0", Offset = "0xBCF3B0", VA = "0x180BCFFB0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400257A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightResultListEntry> _parser;

	[Token(Token = "0x400257B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400257C")]
	public const int OutcomeFieldNumber = 1;

	[Token(Token = "0x400257D")]
	[FieldOffset(Offset = "0x18")]
	private FightOutcome outcome_;

	[Token(Token = "0x400257E")]
	public const int WaveFieldNumber = 2;

	[Token(Token = "0x400257F")]
	[FieldOffset(Offset = "0x1C")]
	private int wave_;

	[Token(Token = "0x4002580")]
	public const int RewardsFieldNumber = 3;

	[Token(Token = "0x4002581")]
	[FieldOffset(Offset = "0x20")]
	private Types.FightLoot rewards_;

	[Token(Token = "0x4002582")]
	public const int FighterListEntryFieldNumber = 4;

	[Token(Token = "0x4002583")]
	[FieldOffset(Offset = "0x28")]
	private Types.FighterListEntry fighterListEntry_;

	[Token(Token = "0x17001774")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightResultListEntry> Parser
	{
		[Token(Token = "0x6006C49")]
		[Address(RVA = "0xBCD100", Offset = "0xBCC500", VA = "0x180BCD100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001775")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006C4A")]
		[Address(RVA = "0xBCD050", Offset = "0xBCC450", VA = "0x180BCD050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001776")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006C4B")]
		[Address(RVA = "0xBCD3A0", Offset = "0xBCC7A0", VA = "0x180BCD3A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001777")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOutcome Outcome
	{
		[Token(Token = "0x6006C4F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(FightOutcome);
		}
		[Token(Token = "0x6006C50")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001778")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Wave
	{
		[Token(Token = "0x6006C51")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006C52")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001779")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.FightLoot Rewards
	{
		[Token(Token = "0x6006C53")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006C54")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x1700177A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.FighterListEntry FighterListEntry
	{
		[Token(Token = "0x6006C55")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006C56")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6006C4C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightResultListEntry()
	{
	}

	[Token(Token = "0x6006C4D")]
	[Address(RVA = "0xBCCEC0", Offset = "0xBCC2C0", VA = "0x180BCCEC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightResultListEntry(FightResultListEntry other)
	{
	}

	[Token(Token = "0x6006C4E")]
	[Address(RVA = "0xBCC850", Offset = "0xBCBC50", VA = "0x180BCC850", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightResultListEntry Clone()
	{
		return null;
	}

	[Token(Token = "0x6006C57")]
	[Address(RVA = "0xBCCA10", Offset = "0xBCBE10", VA = "0x180BCCA10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C58")]
	[Address(RVA = "0xBACDC0", Offset = "0xBAC1C0", VA = "0x180BACDC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightResultListEntry other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C59")]
	[Address(RVA = "0xBCCAE0", Offset = "0xBCBEE0", VA = "0x180BCCAE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006C5A")]
	[Address(RVA = "0xBCCD60", Offset = "0xBCC160", VA = "0x180BCCD60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006C5B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006C5C")]
	[Address(RVA = "0xBCD2E0", Offset = "0xBCC6E0", VA = "0x180BCD2E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006C5D")]
	[Address(RVA = "0xBCC740", Offset = "0xBCBB40", VA = "0x180BCC740", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006C5E")]
	[Address(RVA = "0xBCCBB0", Offset = "0xBCBFB0", VA = "0x180BCCBB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightResultListEntry other)
	{
	}

	[Token(Token = "0x6006C5F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006C60")]
	[Address(RVA = "0xBCD150", Offset = "0xBCC550", VA = "0x180BCD150", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
