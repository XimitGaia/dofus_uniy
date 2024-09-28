using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000945")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActorPositionInformation : IMessage<ActorPositionInformation>, IMessage, IEquatable<ActorPositionInformation>, IDeepCloneable<ActorPositionInformation>, IBufferMessage
{
	[Token(Token = "0x2000946")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000947")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ActorInformation : IMessage<ActorInformation>, IMessage, IEquatable<ActorInformation>, IDeepCloneable<ActorInformation>, IBufferMessage
		{
			[Token(Token = "0x2000948")]
			public enum InformationOneofCase
			{
				[Token(Token = "0x4002052")]
				None = 0,
				[Token(Token = "0x4002053")]
				RolePlayActor = 2,
				[Token(Token = "0x4002054")]
				Fighter = 3
			}

			[Token(Token = "0x2000949")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x200094A")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class RolePlayActor : IMessage<RolePlayActor>, IMessage, IEquatable<RolePlayActor>, IDeepCloneable<RolePlayActor>, IBufferMessage
				{
					[Token(Token = "0x200094B")]
					public enum ActorOneofCase
					{
						[Token(Token = "0x4002061")]
						None = 0,
						[Token(Token = "0x4002062")]
						NamedActor = 4,
						[Token(Token = "0x4002063")]
						TaxCollectorActor = 5,
						[Token(Token = "0x4002064")]
						MonsterGroupActor = 6,
						[Token(Token = "0x4002065")]
						NpcActor = 7,
						[Token(Token = "0x4002066")]
						PrismActor = 8,
						[Token(Token = "0x4002067")]
						PortalActor = 9,
						[Token(Token = "0x4002068")]
						TreasureHuntNpcId = 10
					}

					[Token(Token = "0x200094C")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static class Types
					{
						[Token(Token = "0x200094D")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class NamedActor : IMessage<NamedActor>, IMessage, IEquatable<NamedActor>, IDeepCloneable<NamedActor>, IBufferMessage
						{
							[Token(Token = "0x200094E")]
							public enum ActorOneofCase
							{
								[Token(Token = "0x4002072")]
								None = 0,
								[Token(Token = "0x4002073")]
								HumanoidInformation = 2,
								[Token(Token = "0x4002074")]
								MountInformation = 3
							}

							[Token(Token = "0x200094F")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static class Types
							{
								[Token(Token = "0x2000950")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class Humanoid : IMessage<Humanoid>, IMessage, IEquatable<Humanoid>, IDeepCloneable<Humanoid>, IBufferMessage
								{
									[Token(Token = "0x2000951")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static class Types
									{
										[Token(Token = "0x2000952")]
										[DebuggerDisplay("{ToString(),nq}")]
										public sealed class HumanOption : IMessage<HumanOption>, IMessage, IEquatable<HumanOption>, IDeepCloneable<HumanOption>, IBufferMessage
										{
											[Token(Token = "0x2000953")]
											public enum OptionOneofCase
											{
												[Token(Token = "0x4002093")]
												None = 0,
												[Token(Token = "0x4002094")]
												Followers = 3,
												[Token(Token = "0x4002095")]
												GuildInformation = 4,
												[Token(Token = "0x4002096")]
												AllianceInformation = 5,
												[Token(Token = "0x4002097")]
												EmoteOption = 6,
												[Token(Token = "0x4002098")]
												TitleOption = 7,
												[Token(Token = "0x4002099")]
												OrnamentOption = 8,
												[Token(Token = "0x400209A")]
												ObjectUseOption = 9,
												[Token(Token = "0x400209B")]
												SkillUseOption = 10,
												[Token(Token = "0x400209C")]
												SpeedMultiplier = 11
											}

											[Token(Token = "0x2000954")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public static class Types
											{
												[Token(Token = "0x2000955")]
												[DebuggerDisplay("{ToString(),nq}")]
												public sealed class FollowingCharactersOption : IMessage<FollowingCharactersOption>, IMessage, IEquatable<FollowingCharactersOption>, IDeepCloneable<FollowingCharactersOption>, IBufferMessage
												{
													[Token(Token = "0x2000956")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public static class Types
													{
														[Token(Token = "0x2000957")]
														[DebuggerDisplay("{ToString(),nq}")]
														public sealed class IndexedEntityLook : IMessage<IndexedEntityLook>, IMessage, IEquatable<IndexedEntityLook>, IDeepCloneable<IndexedEntityLook>, IBufferMessage
														{
															[Token(Token = "0x40020A2")]
															[FieldOffset(Offset = "0x0")]
															private static readonly MessageParser<IndexedEntityLook> _parser;

															[Token(Token = "0x40020A3")]
															[FieldOffset(Offset = "0x10")]
															private UnknownFieldSet _unknownFields;

															[Token(Token = "0x40020A4")]
															public const int LookFieldNumber = 1;

															[Token(Token = "0x40020A5")]
															[FieldOffset(Offset = "0x18")]
															private EntityLook look_;

															[Token(Token = "0x40020A6")]
															public const int IndexFieldNumber = 2;

															[Token(Token = "0x40020A7")]
															[FieldOffset(Offset = "0x20")]
															private int index_;

															[Token(Token = "0x170014A8")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public static MessageParser<IndexedEntityLook> Parser
															{
																[Token(Token = "0x600614E")]
																[Address(RVA = "0xB7FB10", Offset = "0xB7EF10", VA = "0x180B7FB10")]
																get
																{
																	return null;
																}
															}

															[Token(Token = "0x170014A9")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public static MessageDescriptor Descriptor
															{
																[Token(Token = "0x600614F")]
																[Address(RVA = "0xB7FA90", Offset = "0xB7EE90", VA = "0x180B7FA90")]
																get
																{
																	return null;
																}
															}

															[Token(Token = "0x170014AA")]
															[GeneratedCode("protoc", null)]
															[DebuggerNonUserCode]
															private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
															{
																[Token(Token = "0x6006150")]
																[Address(RVA = "0xB7FC80", Offset = "0xB7F080", VA = "0x180B7FC80", Slot = "8")]
																get
																{
																	return null;
																}
															}

															[Token(Token = "0x170014AB")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public EntityLook Look
															{
																[Token(Token = "0x6006154")]
																[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
																get
																{
																	return null;
																}
																[Token(Token = "0x6006155")]
																[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
																set
																{
																}
															}

															[Token(Token = "0x170014AC")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public int Index
															{
																[Token(Token = "0x6006156")]
																[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
																get
																{
																	return default(int);
																}
																[Token(Token = "0x6006157")]
																[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
																set
																{
																}
															}

															[Token(Token = "0x6006151")]
															[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
															[GeneratedCode("protoc", null)]
															[DebuggerNonUserCode]
															public IndexedEntityLook()
															{
															}

															[Token(Token = "0x6006152")]
															[Address(RVA = "0xB7FA10", Offset = "0xB7EE10", VA = "0x180B7FA10")]
															[GeneratedCode("protoc", null)]
															[DebuggerNonUserCode]
															public IndexedEntityLook(IndexedEntityLook other)
															{
															}

															[Token(Token = "0x6006153")]
															[Address(RVA = "0xB7F680", Offset = "0xB7EA80", VA = "0x180B7F680", Slot = "10")]
															[GeneratedCode("protoc", null)]
															[DebuggerNonUserCode]
															public IndexedEntityLook Clone()
															{
																return null;
															}

															[Token(Token = "0x6006158")]
															[Address(RVA = "0xB7F730", Offset = "0xB7EB30", VA = "0x180B7F730", Slot = "0")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public override bool Equals(object other)
															{
																return default(bool);
															}

															[Token(Token = "0x6006159")]
															[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public bool Equals(IndexedEntityLook other)
															{
																return default(bool);
															}

															[Token(Token = "0x600615A")]
															[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public override int GetHashCode()
															{
																return default(int);
															}

															[Token(Token = "0x600615B")]
															[Address(RVA = "0xB7F8B0", Offset = "0xB7ECB0", VA = "0x180B7F8B0", Slot = "3")]
															[GeneratedCode("protoc", null)]
															[DebuggerNonUserCode]
															public override string ToString()
															{
																return null;
															}

															[Token(Token = "0x600615C")]
															[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public void WriteTo(CodedOutputStream output)
															{
															}

															[Token(Token = "0x600615D")]
															[Address(RVA = "0x9D2390", Offset = "0x9D1790", VA = "0x1809D2390", Slot = "12")]
															[GeneratedCode("protoc", null)]
															[DebuggerNonUserCode]
															private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
															{
															}

															[Token(Token = "0x600615E")]
															[Address(RVA = "0xB7F5C0", Offset = "0xB7E9C0", VA = "0x180B7F5C0", Slot = "7")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															public int CalculateSize()
															{
																return default(int);
															}

															[Token(Token = "0x600615F")]
															[Address(RVA = "0xB7F7E0", Offset = "0xB7EBE0", VA = "0x180B7F7E0", Slot = "4")]
															[GeneratedCode("protoc", null)]
															[DebuggerNonUserCode]
															public void MergeFrom(IndexedEntityLook other)
															{
															}

															[Token(Token = "0x6006160")]
															[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
															[GeneratedCode("protoc", null)]
															[DebuggerNonUserCode]
															public void MergeFrom(CodedInputStream input)
															{
															}

															[Token(Token = "0x6006161")]
															[Address(RVA = "0xB7FB60", Offset = "0xB7EF60", VA = "0x180B7FB60", Slot = "11")]
															[DebuggerNonUserCode]
															[GeneratedCode("protoc", null)]
															private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
															{
															}
														}
													}

													[Token(Token = "0x400209D")]
													[FieldOffset(Offset = "0x0")]
													private static readonly MessageParser<FollowingCharactersOption> _parser;

													[Token(Token = "0x400209E")]
													[FieldOffset(Offset = "0x10")]
													private UnknownFieldSet _unknownFields;

													[Token(Token = "0x400209F")]
													public const int FollowingCharactersLooksFieldNumber = 1;

													[Token(Token = "0x40020A0")]
													[FieldOffset(Offset = "0x8")]
													private static readonly FieldCodec<Types.IndexedEntityLook> _repeated_followingCharactersLooks_codec;

													[Token(Token = "0x40020A1")]
													[FieldOffset(Offset = "0x18")]
													private readonly RepeatedField<Types.IndexedEntityLook> followingCharactersLooks_;

													[Token(Token = "0x170014A4")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public static MessageParser<FollowingCharactersOption> Parser
													{
														[Token(Token = "0x600613C")]
														[Address(RVA = "0xB7BA20", Offset = "0xB7AE20", VA = "0x180B7BA20")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014A5")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageDescriptor Descriptor
													{
														[Token(Token = "0x600613D")]
														[Address(RVA = "0xB7B9A0", Offset = "0xB7ADA0", VA = "0x180B7B9A0")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014A6")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
													{
														[Token(Token = "0x600613E")]
														[Address(RVA = "0xB7BC30", Offset = "0xB7B030", VA = "0x180B7BC30", Slot = "8")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014A7")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public RepeatedField<Types.IndexedEntityLook> FollowingCharactersLooks
													{
														[Token(Token = "0x6006142")]
														[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x600613F")]
													[Address(RVA = "0xB7B890", Offset = "0xB7AC90", VA = "0x180B7B890")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public FollowingCharactersOption()
													{
													}

													[Token(Token = "0x6006140")]
													[Address(RVA = "0xB7B910", Offset = "0xB7AD10", VA = "0x180B7B910")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public FollowingCharactersOption(FollowingCharactersOption other)
													{
													}

													[Token(Token = "0x6006141")]
													[Address(RVA = "0xB7B3E0", Offset = "0xB7A7E0", VA = "0x180B7B3E0", Slot = "10")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public FollowingCharactersOption Clone()
													{
														return null;
													}

													[Token(Token = "0x6006143")]
													[Address(RVA = "0xB7B4A0", Offset = "0xB7A8A0", VA = "0x180B7B4A0", Slot = "0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override bool Equals(object other)
													{
														return default(bool);
													}

													[Token(Token = "0x6006144")]
													[Address(RVA = "0xB7B580", Offset = "0xB7A980", VA = "0x180B7B580", Slot = "9")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public bool Equals(FollowingCharactersOption other)
													{
														return default(bool);
													}

													[Token(Token = "0x6006145")]
													[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public override int GetHashCode()
													{
														return default(int);
													}

													[Token(Token = "0x6006146")]
													[Address(RVA = "0xB7B690", Offset = "0xB7AA90", VA = "0x180B7B690", Slot = "3")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override string ToString()
													{
														return null;
													}

													[Token(Token = "0x6006147")]
													[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void WriteTo(CodedOutputStream output)
													{
													}

													[Token(Token = "0x6006148")]
													[Address(RVA = "0xB7BB80", Offset = "0xB7AF80", VA = "0x180B7BB80", Slot = "12")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
													{
													}

													[Token(Token = "0x6006149")]
													[Address(RVA = "0xB7B340", Offset = "0xB7A740", VA = "0x180B7B340", Slot = "7")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int CalculateSize()
													{
														return default(int);
													}

													[Token(Token = "0x600614A")]
													[Address(RVA = "0xB7B610", Offset = "0xB7AA10", VA = "0x180B7B610", Slot = "4")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(FollowingCharactersOption other)
													{
													}

													[Token(Token = "0x600614B")]
													[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void MergeFrom(CodedInputStream input)
													{
													}

													[Token(Token = "0x600614C")]
													[Address(RVA = "0xB7BA70", Offset = "0xB7AE70", VA = "0x180B7BA70", Slot = "11")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
													{
													}
												}

												[Token(Token = "0x200095A")]
												[DebuggerDisplay("{ToString(),nq}")]
												public sealed class AllianceOption : IMessage<AllianceOption>, IMessage, IEquatable<AllianceOption>, IDeepCloneable<AllianceOption>, IBufferMessage
												{
													[Token(Token = "0x40020AA")]
													[FieldOffset(Offset = "0x0")]
													private static readonly MessageParser<AllianceOption> _parser;

													[Token(Token = "0x40020AB")]
													[FieldOffset(Offset = "0x10")]
													private UnknownFieldSet _unknownFields;

													[Token(Token = "0x40020AC")]
													public const int AllianceInformationFieldNumber = 1;

													[Token(Token = "0x40020AD")]
													[FieldOffset(Offset = "0x18")]
													private AllianceInformation allianceInformation_;

													[Token(Token = "0x40020AE")]
													public const int AttackableStatusFieldNumber = 2;

													[Token(Token = "0x40020AF")]
													[FieldOffset(Offset = "0x20")]
													private AttackableStatus attackableStatus_;

													[Token(Token = "0x170014AD")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public static MessageParser<AllianceOption> Parser
													{
														[Token(Token = "0x6006169")]
														[Address(RVA = "0xB780E0", Offset = "0xB774E0", VA = "0x180B780E0")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014AE")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public static MessageDescriptor Descriptor
													{
														[Token(Token = "0x600616A")]
														[Address(RVA = "0xB78060", Offset = "0xB77460", VA = "0x180B78060")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014AF")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
													{
														[Token(Token = "0x600616B")]
														[Address(RVA = "0xB78250", Offset = "0xB77650", VA = "0x180B78250", Slot = "8")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014B0")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public AllianceInformation AllianceInformation
													{
														[Token(Token = "0x600616F")]
														[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
														get
														{
															return null;
														}
														[Token(Token = "0x6006170")]
														[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
														set
														{
														}
													}

													[Token(Token = "0x170014B1")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public AttackableStatus AttackableStatus
													{
														[Token(Token = "0x6006171")]
														[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
														get
														{
															return default(AttackableStatus);
														}
														[Token(Token = "0x6006172")]
														[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
														set
														{
														}
													}

													[Token(Token = "0x600616C")]
													[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public AllianceOption()
													{
													}

													[Token(Token = "0x600616D")]
													[Address(RVA = "0xB77FE0", Offset = "0xB773E0", VA = "0x180B77FE0")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public AllianceOption(AllianceOption other)
													{
													}

													[Token(Token = "0x600616E")]
													[Address(RVA = "0xB77C50", Offset = "0xB77050", VA = "0x180B77C50", Slot = "10")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public AllianceOption Clone()
													{
														return null;
													}

													[Token(Token = "0x6006173")]
													[Address(RVA = "0xB77D00", Offset = "0xB77100", VA = "0x180B77D00", Slot = "0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override bool Equals(object other)
													{
														return default(bool);
													}

													[Token(Token = "0x6006174")]
													[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public bool Equals(AllianceOption other)
													{
														return default(bool);
													}

													[Token(Token = "0x6006175")]
													[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public override int GetHashCode()
													{
														return default(int);
													}

													[Token(Token = "0x6006176")]
													[Address(RVA = "0xB77E80", Offset = "0xB77280", VA = "0x180B77E80", Slot = "3")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override string ToString()
													{
														return null;
													}

													[Token(Token = "0x6006177")]
													[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void WriteTo(CodedOutputStream output)
													{
													}

													[Token(Token = "0x6006178")]
													[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
													{
													}

													[Token(Token = "0x6006179")]
													[Address(RVA = "0xB77B90", Offset = "0xB76F90", VA = "0x180B77B90", Slot = "7")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public int CalculateSize()
													{
														return default(int);
													}

													[Token(Token = "0x600617A")]
													[Address(RVA = "0xB77DB0", Offset = "0xB771B0", VA = "0x180B77DB0", Slot = "4")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void MergeFrom(AllianceOption other)
													{
													}

													[Token(Token = "0x600617B")]
													[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(CodedInputStream input)
													{
													}

													[Token(Token = "0x600617C")]
													[Address(RVA = "0xB78130", Offset = "0xB77530", VA = "0x180B78130", Slot = "11")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
													{
													}
												}

												[Token(Token = "0x200095C")]
												[DebuggerDisplay("{ToString(),nq}")]
												public sealed class EmoteOption : IMessage<EmoteOption>, IMessage, IEquatable<EmoteOption>, IDeepCloneable<EmoteOption>, IBufferMessage
												{
													[Token(Token = "0x40020B1")]
													[FieldOffset(Offset = "0x0")]
													private static readonly MessageParser<EmoteOption> _parser;

													[Token(Token = "0x40020B2")]
													[FieldOffset(Offset = "0x10")]
													private UnknownFieldSet _unknownFields;

													[Token(Token = "0x40020B3")]
													public const int EmoteIdFieldNumber = 1;

													[Token(Token = "0x40020B4")]
													[FieldOffset(Offset = "0x18")]
													private int emoteId_;

													[Token(Token = "0x40020B5")]
													public const int EmoteStartTimeFieldNumber = 2;

													[Token(Token = "0x40020B6")]
													[FieldOffset(Offset = "0x20")]
													private string emoteStartTime_;

													[Token(Token = "0x170014B2")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageParser<EmoteOption> Parser
													{
														[Token(Token = "0x6006181")]
														[Address(RVA = "0xB78890", Offset = "0xB77C90", VA = "0x180B78890")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014B3")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageDescriptor Descriptor
													{
														[Token(Token = "0x6006182")]
														[Address(RVA = "0xB78810", Offset = "0xB77C10", VA = "0x180B78810")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014B4")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
													{
														[Token(Token = "0x6006183")]
														[Address(RVA = "0xB78A40", Offset = "0xB77E40", VA = "0x180B78A40", Slot = "8")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014B5")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public int EmoteId
													{
														[Token(Token = "0x6006187")]
														[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x6006188")]
														[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
														set
														{
														}
													}

													[Token(Token = "0x170014B6")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public string EmoteStartTime
													{
														[Token(Token = "0x6006189")]
														[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
														get
														{
															return null;
														}
														[Token(Token = "0x600618A")]
														[Address(RVA = "0xB78AF0", Offset = "0xB77EF0", VA = "0x180B78AF0")]
														set
														{
														}
													}

													[Token(Token = "0x6006184")]
													[Address(RVA = "0xB787C0", Offset = "0xB77BC0", VA = "0x180B787C0")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public EmoteOption()
													{
													}

													[Token(Token = "0x6006185")]
													[Address(RVA = "0xB78710", Offset = "0xB77B10", VA = "0x180B78710")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public EmoteOption(EmoteOption other)
													{
													}

													[Token(Token = "0x6006186")]
													[Address(RVA = "0xB783C0", Offset = "0xB777C0", VA = "0x180B783C0", Slot = "10")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public EmoteOption Clone()
													{
														return null;
													}

													[Token(Token = "0x600618B")]
													[Address(RVA = "0xB78490", Offset = "0xB77890", VA = "0x180B78490", Slot = "0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override bool Equals(object other)
													{
														return default(bool);
													}

													[Token(Token = "0x600618C")]
													[Address(RVA = "0xAD8B90", Offset = "0xAD7F90", VA = "0x180AD8B90", Slot = "9")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public bool Equals(EmoteOption other)
													{
														return default(bool);
													}

													[Token(Token = "0x600618D")]
													[Address(RVA = "0xAD8CB0", Offset = "0xAD80B0", VA = "0x180AD8CB0", Slot = "2")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override int GetHashCode()
													{
														return default(int);
													}

													[Token(Token = "0x600618E")]
													[Address(RVA = "0xB785B0", Offset = "0xB779B0", VA = "0x180B785B0", Slot = "3")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override string ToString()
													{
														return null;
													}

													[Token(Token = "0x600618F")]
													[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void WriteTo(CodedOutputStream output)
													{
													}

													[Token(Token = "0x6006190")]
													[Address(RVA = "0xB789B0", Offset = "0xB77DB0", VA = "0x180B789B0", Slot = "12")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
													{
													}

													[Token(Token = "0x6006191")]
													[Address(RVA = "0xB78300", Offset = "0xB77700", VA = "0x180B78300", Slot = "7")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public int CalculateSize()
													{
														return default(int);
													}

													[Token(Token = "0x6006192")]
													[Address(RVA = "0xB78540", Offset = "0xB77940", VA = "0x180B78540", Slot = "4")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(EmoteOption other)
													{
													}

													[Token(Token = "0x6006193")]
													[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(CodedInputStream input)
													{
													}

													[Token(Token = "0x6006194")]
													[Address(RVA = "0xB788E0", Offset = "0xB77CE0", VA = "0x180B788E0", Slot = "11")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
													{
													}
												}

												[Token(Token = "0x200095E")]
												[DebuggerDisplay("{ToString(),nq}")]
												public sealed class TitleOption : IMessage<TitleOption>, IMessage, IEquatable<TitleOption>, IDeepCloneable<TitleOption>, IBufferMessage
												{
													[Token(Token = "0x40020B8")]
													[FieldOffset(Offset = "0x0")]
													private static readonly MessageParser<TitleOption> _parser;

													[Token(Token = "0x40020B9")]
													[FieldOffset(Offset = "0x10")]
													private UnknownFieldSet _unknownFields;

													[Token(Token = "0x40020BA")]
													[FieldOffset(Offset = "0x18")]
													private int _hasBits0;

													[Token(Token = "0x40020BB")]
													public const int TitleIdFieldNumber = 1;

													[Token(Token = "0x40020BC")]
													[FieldOffset(Offset = "0x8")]
													private static readonly int TitleIdDefaultValue;

													[Token(Token = "0x40020BD")]
													[FieldOffset(Offset = "0x1C")]
													private int titleId_;

													[Token(Token = "0x40020BE")]
													public const int TitleParameterFieldNumber = 2;

													[Token(Token = "0x40020BF")]
													[FieldOffset(Offset = "0x10")]
													private static readonly string TitleParameterDefaultValue;

													[Token(Token = "0x40020C0")]
													[FieldOffset(Offset = "0x20")]
													private string titleParameter_;

													[Token(Token = "0x170014B7")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageParser<TitleOption> Parser
													{
														[Token(Token = "0x6006199")]
														[Address(RVA = "0xB8ACA0", Offset = "0xB8A0A0", VA = "0x180B8ACA0")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014B8")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageDescriptor Descriptor
													{
														[Token(Token = "0x600619A")]
														[Address(RVA = "0xB8AC20", Offset = "0xB8A020", VA = "0x180B8AC20")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014B9")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
													{
														[Token(Token = "0x600619B")]
														[Address(RVA = "0xB8AFB0", Offset = "0xB8A3B0", VA = "0x180B8AFB0", Slot = "8")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014BA")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int TitleId
													{
														[Token(Token = "0x600619F")]
														[Address(RVA = "0xB8ACF0", Offset = "0xB8A0F0", VA = "0x180B8ACF0")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x60061A0")]
														[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
														set
														{
														}
													}

													[Token(Token = "0x170014BB")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public bool HasTitleId
													{
														[Token(Token = "0x60061A1")]
														[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
														get
														{
															return default(bool);
														}
													}

													[Token(Token = "0x170014BC")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public string TitleParameter
													{
														[Token(Token = "0x60061A3")]
														[Address(RVA = "0xB8AD60", Offset = "0xB8A160", VA = "0x180B8AD60")]
														get
														{
															return null;
														}
														[Token(Token = "0x60061A4")]
														[Address(RVA = "0xB8B060", Offset = "0xB8A460", VA = "0x180B8B060")]
														set
														{
														}
													}

													[Token(Token = "0x170014BD")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public bool HasTitleParameter
													{
														[Token(Token = "0x60061A5")]
														[Address(RVA = "0x916800", Offset = "0x915C00", VA = "0x180916800")]
														get
														{
															return default(bool);
														}
													}

													[Token(Token = "0x600619C")]
													[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public TitleOption()
													{
													}

													[Token(Token = "0x600619D")]
													[Address(RVA = "0xB8ABB0", Offset = "0xB89FB0", VA = "0x180B8ABB0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public TitleOption(TitleOption other)
													{
													}

													[Token(Token = "0x600619E")]
													[Address(RVA = "0xB8A620", Offset = "0xB89A20", VA = "0x180B8A620", Slot = "10")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public TitleOption Clone()
													{
														return null;
													}

													[Token(Token = "0x60061A2")]
													[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void ClearTitleId()
													{
													}

													[Token(Token = "0x60061A6")]
													[Address(RVA = "0x915FF0", Offset = "0x9153F0", VA = "0x180915FF0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void ClearTitleParameter()
													{
													}

													[Token(Token = "0x60061A7")]
													[Address(RVA = "0xB8A770", Offset = "0xB89B70", VA = "0x180B8A770", Slot = "0")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public override bool Equals(object other)
													{
														return default(bool);
													}

													[Token(Token = "0x60061A8")]
													[Address(RVA = "0xB8A6C0", Offset = "0xB89AC0", VA = "0x180B8A6C0", Slot = "9")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public bool Equals(TitleOption other)
													{
														return default(bool);
													}

													[Token(Token = "0x60061A9")]
													[Address(RVA = "0xB8A850", Offset = "0xB89C50", VA = "0x180B8A850", Slot = "2")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public override int GetHashCode()
													{
														return default(int);
													}

													[Token(Token = "0x60061AA")]
													[Address(RVA = "0xB8AA00", Offset = "0xB89E00", VA = "0x180B8AA00", Slot = "3")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public override string ToString()
													{
														return null;
													}

													[Token(Token = "0x60061AB")]
													[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void WriteTo(CodedOutputStream output)
													{
													}

													[Token(Token = "0x60061AC")]
													[Address(RVA = "0xB8AEA0", Offset = "0xB8A2A0", VA = "0x180B8AEA0", Slot = "12")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
													{
													}

													[Token(Token = "0x60061AD")]
													[Address(RVA = "0xB8A4D0", Offset = "0xB898D0", VA = "0x180B8A4D0", Slot = "7")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int CalculateSize()
													{
														return default(int);
													}

													[Token(Token = "0x60061AE")]
													[Address(RVA = "0xB8A980", Offset = "0xB89D80", VA = "0x180B8A980", Slot = "4")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(TitleOption other)
													{
													}

													[Token(Token = "0x60061AF")]
													[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void MergeFrom(CodedInputStream input)
													{
													}

													[Token(Token = "0x60061B0")]
													[Address(RVA = "0xB8ADC0", Offset = "0xB8A1C0", VA = "0x180B8ADC0", Slot = "11")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
													{
													}
												}

												[Token(Token = "0x2000960")]
												[DebuggerDisplay("{ToString(),nq}")]
												public sealed class OrnamentOption : IMessage<OrnamentOption>, IMessage, IEquatable<OrnamentOption>, IDeepCloneable<OrnamentOption>, IBufferMessage
												{
													[Token(Token = "0x40020C2")]
													[FieldOffset(Offset = "0x0")]
													private static readonly MessageParser<OrnamentOption> _parser;

													[Token(Token = "0x40020C3")]
													[FieldOffset(Offset = "0x10")]
													private UnknownFieldSet _unknownFields;

													[Token(Token = "0x40020C4")]
													[FieldOffset(Offset = "0x18")]
													private int _hasBits0;

													[Token(Token = "0x40020C5")]
													public const int OrnamentIdFieldNumber = 1;

													[Token(Token = "0x40020C6")]
													[FieldOffset(Offset = "0x8")]
													private static readonly int OrnamentIdDefaultValue;

													[Token(Token = "0x40020C7")]
													[FieldOffset(Offset = "0x1C")]
													private int ornamentId_;

													[Token(Token = "0x40020C8")]
													public const int PlayerLevelFieldNumber = 2;

													[Token(Token = "0x40020C9")]
													[FieldOffset(Offset = "0x20")]
													private int playerLevel_;

													[Token(Token = "0x40020CA")]
													public const int LeagueIdFieldNumber = 3;

													[Token(Token = "0x40020CB")]
													[FieldOffset(Offset = "0xC")]
													private static readonly int LeagueIdDefaultValue;

													[Token(Token = "0x40020CC")]
													[FieldOffset(Offset = "0x24")]
													private int leagueId_;

													[Token(Token = "0x40020CD")]
													public const int LadderPositionFieldNumber = 4;

													[Token(Token = "0x40020CE")]
													[FieldOffset(Offset = "0x10")]
													private static readonly int LadderPositionDefaultValue;

													[Token(Token = "0x40020CF")]
													[FieldOffset(Offset = "0x28")]
													private int ladderPosition_;

													[Token(Token = "0x170014BE")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageParser<OrnamentOption> Parser
													{
														[Token(Token = "0x60061B5")]
														[Address(RVA = "0xB866E0", Offset = "0xB85AE0", VA = "0x180B866E0")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014BF")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageDescriptor Descriptor
													{
														[Token(Token = "0x60061B6")]
														[Address(RVA = "0xB86510", Offset = "0xB85910", VA = "0x180B86510")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014C0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
													{
														[Token(Token = "0x60061B7")]
														[Address(RVA = "0xB869D0", Offset = "0xB85DD0", VA = "0x180B869D0", Slot = "8")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014C1")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int OrnamentId
													{
														[Token(Token = "0x60061BB")]
														[Address(RVA = "0xB86670", Offset = "0xB85A70", VA = "0x180B86670")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x60061BC")]
														[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
														set
														{
														}
													}

													[Token(Token = "0x170014C2")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public bool HasOrnamentId
													{
														[Token(Token = "0x60061BD")]
														[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
														get
														{
															return default(bool);
														}
													}

													[Token(Token = "0x170014C3")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public int PlayerLevel
													{
														[Token(Token = "0x60061BF")]
														[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x60061C0")]
														[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
														set
														{
														}
													}

													[Token(Token = "0x170014C4")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int LeagueId
													{
														[Token(Token = "0x60061C1")]
														[Address(RVA = "0xB86600", Offset = "0xB85A00", VA = "0x180B86600")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x60061C2")]
														[Address(RVA = "0xB86A90", Offset = "0xB85E90", VA = "0x180B86A90")]
														set
														{
														}
													}

													[Token(Token = "0x170014C5")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public bool HasLeagueId
													{
														[Token(Token = "0x60061C3")]
														[Address(RVA = "0xAEF3E0", Offset = "0xAEE7E0", VA = "0x180AEF3E0")]
														get
														{
															return default(bool);
														}
													}

													[Token(Token = "0x170014C6")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int LadderPosition
													{
														[Token(Token = "0x60061C5")]
														[Address(RVA = "0xB86590", Offset = "0xB85990", VA = "0x180B86590")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x60061C6")]
														[Address(RVA = "0xB86A80", Offset = "0xB85E80", VA = "0x180B86A80")]
														set
														{
														}
													}

													[Token(Token = "0x170014C7")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public bool HasLadderPosition
													{
														[Token(Token = "0x60061C7")]
														[Address(RVA = "0xAEF400", Offset = "0xAEE800", VA = "0x180AEF400")]
														get
														{
															return default(bool);
														}
													}

													[Token(Token = "0x60061B8")]
													[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public OrnamentOption()
													{
													}

													[Token(Token = "0x60061B9")]
													[Address(RVA = "0xA55430", Offset = "0xA54830", VA = "0x180A55430")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public OrnamentOption(OrnamentOption other)
													{
													}

													[Token(Token = "0x60061BA")]
													[Address(RVA = "0xB85ED0", Offset = "0xB852D0", VA = "0x180B85ED0", Slot = "10")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public OrnamentOption Clone()
													{
														return null;
													}

													[Token(Token = "0x60061BE")]
													[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void ClearOrnamentId()
													{
													}

													[Token(Token = "0x60061C4")]
													[Address(RVA = "0xAEE790", Offset = "0xAEDB90", VA = "0x180AEE790")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void ClearLeagueId()
													{
													}

													[Token(Token = "0x60061C8")]
													[Address(RVA = "0xAEE7B0", Offset = "0xAEDBB0", VA = "0x180AEE7B0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void ClearLadderPosition()
													{
													}

													[Token(Token = "0x60061C9")]
													[Address(RVA = "0xB85F70", Offset = "0xB85370", VA = "0x180B85F70", Slot = "0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override bool Equals(object other)
													{
														return default(bool);
													}

													[Token(Token = "0x60061CA")]
													[Address(RVA = "0xB86070", Offset = "0xB85470", VA = "0x180B86070", Slot = "9")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public bool Equals(OrnamentOption other)
													{
														return default(bool);
													}

													[Token(Token = "0x60061CB")]
													[Address(RVA = "0xB86130", Offset = "0xB85530", VA = "0x180B86130", Slot = "2")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public override int GetHashCode()
													{
														return default(int);
													}

													[Token(Token = "0x60061CC")]
													[Address(RVA = "0xB86380", Offset = "0xB85780", VA = "0x180B86380", Slot = "3")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override string ToString()
													{
														return null;
													}

													[Token(Token = "0x60061CD")]
													[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void WriteTo(CodedOutputStream output)
													{
													}

													[Token(Token = "0x60061CE")]
													[Address(RVA = "0xB86830", Offset = "0xB85C30", VA = "0x180B86830", Slot = "12")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
													{
													}

													[Token(Token = "0x60061CF")]
													[Address(RVA = "0xB85CD0", Offset = "0xB850D0", VA = "0x180B85CD0", Slot = "7")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public int CalculateSize()
													{
														return default(int);
													}

													[Token(Token = "0x60061D0")]
													[Address(RVA = "0xB862E0", Offset = "0xB856E0", VA = "0x180B862E0", Slot = "4")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(OrnamentOption other)
													{
													}

													[Token(Token = "0x60061D1")]
													[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(CodedInputStream input)
													{
													}

													[Token(Token = "0x60061D2")]
													[Address(RVA = "0xB86730", Offset = "0xB85B30", VA = "0x180B86730", Slot = "11")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
													{
													}
												}

												[Token(Token = "0x2000962")]
												[DebuggerDisplay("{ToString(),nq}")]
												public sealed class ObjectUseOption : IMessage<ObjectUseOption>, IMessage, IEquatable<ObjectUseOption>, IDeepCloneable<ObjectUseOption>, IBufferMessage
												{
													[Token(Token = "0x40020D1")]
													[FieldOffset(Offset = "0x0")]
													private static readonly MessageParser<ObjectUseOption> _parser;

													[Token(Token = "0x40020D2")]
													[FieldOffset(Offset = "0x10")]
													private UnknownFieldSet _unknownFields;

													[Token(Token = "0x40020D3")]
													public const int DelayedActionTypeFieldNumber = 1;

													[Token(Token = "0x40020D4")]
													[FieldOffset(Offset = "0x18")]
													private DelayedActionType delayedActionType_;

													[Token(Token = "0x40020D5")]
													public const int EndDelayFieldNumber = 2;

													[Token(Token = "0x40020D6")]
													[FieldOffset(Offset = "0x20")]
													private string endDelay_;

													[Token(Token = "0x40020D7")]
													public const int ObjectGidFieldNumber = 3;

													[Token(Token = "0x40020D8")]
													[FieldOffset(Offset = "0x28")]
													private int objectGid_;

													[Token(Token = "0x170014C8")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageParser<ObjectUseOption> Parser
													{
														[Token(Token = "0x60061D7")]
														[Address(RVA = "0xB859C0", Offset = "0xB84DC0", VA = "0x180B859C0")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014C9")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public static MessageDescriptor Descriptor
													{
														[Token(Token = "0x60061D8")]
														[Address(RVA = "0xB85940", Offset = "0xB84D40", VA = "0x180B85940")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014CA")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
													{
														[Token(Token = "0x60061D9")]
														[Address(RVA = "0xB85BB0", Offset = "0xB84FB0", VA = "0x180B85BB0", Slot = "8")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014CB")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public DelayedActionType DelayedActionType
													{
														[Token(Token = "0x60061DD")]
														[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
														get
														{
															return default(DelayedActionType);
														}
														[Token(Token = "0x60061DE")]
														[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
														set
														{
														}
													}

													[Token(Token = "0x170014CC")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public string EndDelay
													{
														[Token(Token = "0x60061DF")]
														[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
														get
														{
															return null;
														}
														[Token(Token = "0x60061E0")]
														[Address(RVA = "0xB85C60", Offset = "0xB85060", VA = "0x180B85C60")]
														set
														{
														}
													}

													[Token(Token = "0x170014CD")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int ObjectGid
													{
														[Token(Token = "0x60061E1")]
														[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x60061E2")]
														[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
														set
														{
														}
													}

													[Token(Token = "0x60061DA")]
													[Address(RVA = "0xB85840", Offset = "0xB84C40", VA = "0x180B85840")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public ObjectUseOption()
													{
													}

													[Token(Token = "0x60061DB")]
													[Address(RVA = "0xB85890", Offset = "0xB84C90", VA = "0x180B85890")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public ObjectUseOption(ObjectUseOption other)
													{
													}

													[Token(Token = "0x60061DC")]
													[Address(RVA = "0xB85390", Offset = "0xB84790", VA = "0x180B85390", Slot = "10")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public ObjectUseOption Clone()
													{
														return null;
													}

													[Token(Token = "0x60061E3")]
													[Address(RVA = "0xB85470", Offset = "0xB84870", VA = "0x180B85470", Slot = "0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override bool Equals(object other)
													{
														return default(bool);
													}

													[Token(Token = "0x60061E4")]
													[Address(RVA = "0xB85530", Offset = "0xB84930", VA = "0x180B85530", Slot = "9")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public bool Equals(ObjectUseOption other)
													{
														return default(bool);
													}

													[Token(Token = "0x60061E5")]
													[Address(RVA = "0xB855B0", Offset = "0xB849B0", VA = "0x180B855B0", Slot = "2")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public override int GetHashCode()
													{
														return default(int);
													}

													[Token(Token = "0x60061E6")]
													[Address(RVA = "0xB856E0", Offset = "0xB84AE0", VA = "0x180B856E0", Slot = "3")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override string ToString()
													{
														return null;
													}

													[Token(Token = "0x60061E7")]
													[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void WriteTo(CodedOutputStream output)
													{
													}

													[Token(Token = "0x60061E8")]
													[Address(RVA = "0xB85B00", Offset = "0xB84F00", VA = "0x180B85B00", Slot = "12")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
													{
													}

													[Token(Token = "0x60061E9")]
													[Address(RVA = "0xB852B0", Offset = "0xB846B0", VA = "0x180B852B0", Slot = "7")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int CalculateSize()
													{
														return default(int);
													}

													[Token(Token = "0x60061EA")]
													[Address(RVA = "0xB85660", Offset = "0xB84A60", VA = "0x180B85660", Slot = "4")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void MergeFrom(ObjectUseOption other)
													{
													}

													[Token(Token = "0x60061EB")]
													[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public void MergeFrom(CodedInputStream input)
													{
													}

													[Token(Token = "0x60061EC")]
													[Address(RVA = "0xB85A10", Offset = "0xB84E10", VA = "0x180B85A10", Slot = "11")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
													{
													}
												}

												[Token(Token = "0x2000964")]
												[DebuggerDisplay("{ToString(),nq}")]
												public sealed class SkillUseOption : IMessage<SkillUseOption>, IMessage, IEquatable<SkillUseOption>, IDeepCloneable<SkillUseOption>, IBufferMessage
												{
													[Token(Token = "0x40020DA")]
													[FieldOffset(Offset = "0x0")]
													private static readonly MessageParser<SkillUseOption> _parser;

													[Token(Token = "0x40020DB")]
													[FieldOffset(Offset = "0x10")]
													private UnknownFieldSet _unknownFields;

													[Token(Token = "0x40020DC")]
													public const int ElementIdFieldNumber = 1;

													[Token(Token = "0x40020DD")]
													[FieldOffset(Offset = "0x18")]
													private int elementId_;

													[Token(Token = "0x40020DE")]
													public const int SkillIdFieldNumber = 2;

													[Token(Token = "0x40020DF")]
													[FieldOffset(Offset = "0x1C")]
													private int skillId_;

													[Token(Token = "0x40020E0")]
													public const int SkillEndTimeFieldNumber = 3;

													[Token(Token = "0x40020E1")]
													[FieldOffset(Offset = "0x20")]
													private string skillEndTime_;

													[Token(Token = "0x170014CE")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public static MessageParser<SkillUseOption> Parser
													{
														[Token(Token = "0x60061F1")]
														[Address(RVA = "0xB89B00", Offset = "0xB88F00", VA = "0x180B89B00")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014CF")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public static MessageDescriptor Descriptor
													{
														[Token(Token = "0x60061F2")]
														[Address(RVA = "0xB89A80", Offset = "0xB88E80", VA = "0x180B89A80")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014D0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
													{
														[Token(Token = "0x60061F3")]
														[Address(RVA = "0xB89C40", Offset = "0xB89040", VA = "0x180B89C40", Slot = "8")]
														get
														{
															return null;
														}
													}

													[Token(Token = "0x170014D1")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public int ElementId
													{
														[Token(Token = "0x60061F7")]
														[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x60061F8")]
														[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
														set
														{
														}
													}

													[Token(Token = "0x170014D2")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public int SkillId
													{
														[Token(Token = "0x60061F9")]
														[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
														get
														{
															return default(int);
														}
														[Token(Token = "0x60061FA")]
														[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
														set
														{
														}
													}

													[Token(Token = "0x170014D3")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public string SkillEndTime
													{
														[Token(Token = "0x60061FB")]
														[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
														get
														{
															return null;
														}
														[Token(Token = "0x60061FC")]
														[Address(RVA = "0xB89CF0", Offset = "0xB890F0", VA = "0x180B89CF0")]
														set
														{
														}
													}

													[Token(Token = "0x60061F4")]
													[Address(RVA = "0xB89980", Offset = "0xB88D80", VA = "0x180B89980")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public SkillUseOption()
													{
													}

													[Token(Token = "0x60061F5")]
													[Address(RVA = "0xB899D0", Offset = "0xB88DD0", VA = "0x180B899D0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public SkillUseOption(SkillUseOption other)
													{
													}

													[Token(Token = "0x60061F6")]
													[Address(RVA = "0xB89600", Offset = "0xB88A00", VA = "0x180B89600", Slot = "10")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public SkillUseOption Clone()
													{
														return null;
													}

													[Token(Token = "0x60061FD")]
													[Address(RVA = "0xB896E0", Offset = "0xB88AE0", VA = "0x180B896E0", Slot = "0")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override bool Equals(object other)
													{
														return default(bool);
													}

													[Token(Token = "0x60061FE")]
													[Address(RVA = "0x9B1620", Offset = "0x9B0A20", VA = "0x1809B1620", Slot = "9")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public bool Equals(SkillUseOption other)
													{
														return default(bool);
													}

													[Token(Token = "0x60061FF")]
													[Address(RVA = "0x9B16A0", Offset = "0x9B0AA0", VA = "0x1809B16A0", Slot = "2")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public override int GetHashCode()
													{
														return default(int);
													}

													[Token(Token = "0x6006200")]
													[Address(RVA = "0xB89820", Offset = "0xB88C20", VA = "0x180B89820", Slot = "3")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public override string ToString()
													{
														return null;
													}

													[Token(Token = "0x6006201")]
													[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void WriteTo(CodedOutputStream output)
													{
													}

													[Token(Token = "0x6006202")]
													[Address(RVA = "0x9B1C20", Offset = "0x9B1020", VA = "0x1809B1C20", Slot = "12")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
													{
													}

													[Token(Token = "0x6006203")]
													[Address(RVA = "0xB89520", Offset = "0xB88920", VA = "0x180B89520", Slot = "7")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													public int CalculateSize()
													{
														return default(int);
													}

													[Token(Token = "0x6006204")]
													[Address(RVA = "0xB897A0", Offset = "0xB88BA0", VA = "0x180B897A0", Slot = "4")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(SkillUseOption other)
													{
													}

													[Token(Token = "0x6006205")]
													[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
													[DebuggerNonUserCode]
													[GeneratedCode("protoc", null)]
													public void MergeFrom(CodedInputStream input)
													{
													}

													[Token(Token = "0x6006206")]
													[Address(RVA = "0xB89B50", Offset = "0xB88F50", VA = "0x180B89B50", Slot = "11")]
													[GeneratedCode("protoc", null)]
													[DebuggerNonUserCode]
													private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
													{
													}
												}
											}

											[Token(Token = "0x4002085")]
											[FieldOffset(Offset = "0x0")]
											private static readonly MessageParser<HumanOption> _parser;

											[Token(Token = "0x4002086")]
											[FieldOffset(Offset = "0x10")]
											private UnknownFieldSet _unknownFields;

											[Token(Token = "0x4002087")]
											public const int FollowersFieldNumber = 3;

											[Token(Token = "0x4002088")]
											public const int GuildInformationFieldNumber = 4;

											[Token(Token = "0x4002089")]
											public const int AllianceInformationFieldNumber = 5;

											[Token(Token = "0x400208A")]
											public const int EmoteOptionFieldNumber = 6;

											[Token(Token = "0x400208B")]
											public const int TitleOptionFieldNumber = 7;

											[Token(Token = "0x400208C")]
											public const int OrnamentOptionFieldNumber = 8;

											[Token(Token = "0x400208D")]
											public const int ObjectUseOptionFieldNumber = 9;

											[Token(Token = "0x400208E")]
											public const int SkillUseOptionFieldNumber = 10;

											[Token(Token = "0x400208F")]
											public const int SpeedMultiplierFieldNumber = 11;

											[Token(Token = "0x4002090")]
											[FieldOffset(Offset = "0x18")]
											private object option_;

											[Token(Token = "0x4002091")]
											[FieldOffset(Offset = "0x20")]
											private OptionOneofCase optionCase_;

											[Token(Token = "0x17001496")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public static MessageParser<HumanOption> Parser
											{
												[Token(Token = "0x6006115")]
												[Address(RVA = "0xB7D7B0", Offset = "0xB7CBB0", VA = "0x180B7D7B0")]
												get
												{
													return null;
												}
											}

											[Token(Token = "0x17001497")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public static MessageDescriptor Descriptor
											{
												[Token(Token = "0x6006116")]
												[Address(RVA = "0xB7D540", Offset = "0xB7C940", VA = "0x180B7D540")]
												get
												{
													return null;
												}
											}

											[Token(Token = "0x17001498")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
											{
												[Token(Token = "0x6006117")]
												[Address(RVA = "0xB7E230", Offset = "0xB7D630", VA = "0x180B7E230", Slot = "8")]
												get
												{
													return null;
												}
											}

											[Token(Token = "0x17001499")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public Types.FollowingCharactersOption Followers
											{
												[Token(Token = "0x600611B")]
												[Address(RVA = "0xB7D620", Offset = "0xB7CA20", VA = "0x180B7D620")]
												get
												{
													return null;
												}
												[Token(Token = "0x600611C")]
												[Address(RVA = "0x919620", Offset = "0x918A20", VA = "0x180919620")]
												set
												{
												}
											}

											[Token(Token = "0x1700149A")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public GuildInformation GuildInformation
											{
												[Token(Token = "0x600611D")]
												[Address(RVA = "0xB7D680", Offset = "0xB7CA80", VA = "0x180B7D680")]
												get
												{
													return null;
												}
												[Token(Token = "0x600611E")]
												[Address(RVA = "0x94E860", Offset = "0x94DC60", VA = "0x18094E860")]
												set
												{
												}
											}

											[Token(Token = "0x1700149B")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public Types.AllianceOption AllianceInformation
											{
												[Token(Token = "0x600611F")]
												[Address(RVA = "0xB7D4E0", Offset = "0xB7C8E0", VA = "0x180B7D4E0")]
												get
												{
													return null;
												}
												[Token(Token = "0x6006120")]
												[Address(RVA = "0x94E820", Offset = "0x94DC20", VA = "0x18094E820")]
												set
												{
												}
											}

											[Token(Token = "0x1700149C")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public Types.EmoteOption EmoteOption
											{
												[Token(Token = "0x6006121")]
												[Address(RVA = "0xB7D5C0", Offset = "0xB7C9C0", VA = "0x180B7D5C0")]
												get
												{
													return null;
												}
												[Token(Token = "0x6006122")]
												[Address(RVA = "0xB7E270", Offset = "0xB7D670", VA = "0x180B7E270")]
												set
												{
												}
											}

											[Token(Token = "0x1700149D")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public Types.TitleOption TitleOption
											{
												[Token(Token = "0x6006123")]
												[Address(RVA = "0xB7D8D0", Offset = "0xB7CCD0", VA = "0x180B7D8D0")]
												get
												{
													return null;
												}
												[Token(Token = "0x6006124")]
												[Address(RVA = "0xB7E3E0", Offset = "0xB7D7E0", VA = "0x180B7E3E0")]
												set
												{
												}
											}

											[Token(Token = "0x1700149E")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public Types.OrnamentOption OrnamentOption
											{
												[Token(Token = "0x6006125")]
												[Address(RVA = "0xB7D750", Offset = "0xB7CB50", VA = "0x180B7D750")]
												get
												{
													return null;
												}
												[Token(Token = "0x6006126")]
												[Address(RVA = "0xB7E2F0", Offset = "0xB7D6F0", VA = "0x180B7E2F0")]
												set
												{
												}
											}

											[Token(Token = "0x1700149F")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public Types.ObjectUseOption ObjectUseOption
											{
												[Token(Token = "0x6006127")]
												[Address(RVA = "0xB7D6F0", Offset = "0xB7CAF0", VA = "0x180B7D6F0")]
												get
												{
													return null;
												}
												[Token(Token = "0x6006128")]
												[Address(RVA = "0xB7E2B0", Offset = "0xB7D6B0", VA = "0x180B7E2B0")]
												set
												{
												}
											}

											[Token(Token = "0x170014A0")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public Types.SkillUseOption SkillUseOption
											{
												[Token(Token = "0x6006129")]
												[Address(RVA = "0xB7D800", Offset = "0xB7CC00", VA = "0x180B7D800")]
												get
												{
													return null;
												}
												[Token(Token = "0x600612A")]
												[Address(RVA = "0xB7E330", Offset = "0xB7D730", VA = "0x180B7E330")]
												set
												{
												}
											}

											[Token(Token = "0x170014A1")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public int SpeedMultiplier
											{
												[Token(Token = "0x600612B")]
												[Address(RVA = "0xB7D860", Offset = "0xB7CC60", VA = "0x180B7D860")]
												get
												{
													return default(int);
												}
												[Token(Token = "0x600612C")]
												[Address(RVA = "0xB7E370", Offset = "0xB7D770", VA = "0x180B7E370")]
												set
												{
												}
											}

											[Token(Token = "0x170014A2")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public bool HasSpeedMultiplier
											{
												[Token(Token = "0x600612D")]
												[Address(RVA = "0xB7D6E0", Offset = "0xB7CAE0", VA = "0x180B7D6E0")]
												get
												{
													return default(bool);
												}
											}

											[Token(Token = "0x170014A3")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public OptionOneofCase OptionCase
											{
												[Token(Token = "0x600612F")]
												[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
												get
												{
													return default(OptionOneofCase);
												}
											}

											[Token(Token = "0x6006118")]
											[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public HumanOption()
											{
											}

											[Token(Token = "0x6006119")]
											[Address(RVA = "0xB7CEB0", Offset = "0xB7C2B0", VA = "0x180B7CEB0")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public HumanOption(HumanOption other)
											{
											}

											[Token(Token = "0x600611A")]
											[Address(RVA = "0xB7C110", Offset = "0xB7B510", VA = "0x180B7C110", Slot = "10")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public HumanOption Clone()
											{
												return null;
											}

											[Token(Token = "0x600612E")]
											[Address(RVA = "0xB7C0F0", Offset = "0xB7B4F0", VA = "0x180B7C0F0")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public void ClearSpeedMultiplier()
											{
											}

											[Token(Token = "0x6006130")]
											[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public void ClearOption()
											{
											}

											[Token(Token = "0x6006131")]
											[Address(RVA = "0xB7C170", Offset = "0xB7B570", VA = "0x180B7C170", Slot = "0")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public override bool Equals(object other)
											{
												return default(bool);
											}

											[Token(Token = "0x6006132")]
											[Address(RVA = "0xB7C1D0", Offset = "0xB7B5D0", VA = "0x180B7C1D0", Slot = "9")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public bool Equals(HumanOption other)
											{
												return default(bool);
											}

											[Token(Token = "0x6006133")]
											[Address(RVA = "0xB7C430", Offset = "0xB7B830", VA = "0x180B7C430", Slot = "2")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public override int GetHashCode()
											{
												return default(int);
											}

											[Token(Token = "0x6006134")]
											[Address(RVA = "0xB7CD50", Offset = "0xB7C150", VA = "0x180B7CD50", Slot = "3")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public override string ToString()
											{
												return null;
											}

											[Token(Token = "0x6006135")]
											[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public void WriteTo(CodedOutputStream output)
											{
											}

											[Token(Token = "0x6006136")]
											[Address(RVA = "0xB7DE10", Offset = "0xB7D210", VA = "0x180B7DE10", Slot = "12")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
											{
											}

											[Token(Token = "0x6006137")]
											[Address(RVA = "0xB7BC70", Offset = "0xB7B070", VA = "0x180B7BC70", Slot = "7")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public int CalculateSize()
											{
												return default(int);
											}

											[Token(Token = "0x6006138")]
											[Address(RVA = "0xB7C880", Offset = "0xB7BC80", VA = "0x180B7C880", Slot = "4")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public void MergeFrom(HumanOption other)
											{
											}

											[Token(Token = "0x6006139")]
											[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public void MergeFrom(CodedInputStream input)
											{
											}

											[Token(Token = "0x600613A")]
											[Address(RVA = "0xB7D930", Offset = "0xB7CD30", VA = "0x180B7D930", Slot = "11")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
											{
											}
										}

										[Token(Token = "0x2000967")]
										[DebuggerDisplay("{ToString(),nq}")]
										public sealed class MutantInformation : IMessage<MutantInformation>, IMessage, IEquatable<MutantInformation>, IDeepCloneable<MutantInformation>, IBufferMessage
										{
											[Token(Token = "0x40020E4")]
											[FieldOffset(Offset = "0x0")]
											private static readonly MessageParser<MutantInformation> _parser;

											[Token(Token = "0x40020E5")]
											[FieldOffset(Offset = "0x10")]
											private UnknownFieldSet _unknownFields;

											[Token(Token = "0x40020E6")]
											public const int MonsterIdFieldNumber = 1;

											[Token(Token = "0x40020E7")]
											[FieldOffset(Offset = "0x18")]
											private int monsterId_;

											[Token(Token = "0x40020E8")]
											public const int PowerLevelFieldNumber = 2;

											[Token(Token = "0x40020E9")]
											[FieldOffset(Offset = "0x1C")]
											private int powerLevel_;

											[Token(Token = "0x170014D4")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public static MessageParser<MutantInformation> Parser
											{
												[Token(Token = "0x600620E")]
												[Address(RVA = "0xB81F80", Offset = "0xB81380", VA = "0x180B81F80")]
												get
												{
													return null;
												}
											}

											[Token(Token = "0x170014D5")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public static MessageDescriptor Descriptor
											{
												[Token(Token = "0x600620F")]
												[Address(RVA = "0xB81F00", Offset = "0xB81300", VA = "0x180B81F00")]
												get
												{
													return null;
												}
											}

											[Token(Token = "0x170014D6")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
											{
												[Token(Token = "0x6006210")]
												[Address(RVA = "0xB81FD0", Offset = "0xB813D0", VA = "0x180B81FD0", Slot = "8")]
												get
												{
													return null;
												}
											}

											[Token(Token = "0x170014D7")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public int MonsterId
											{
												[Token(Token = "0x6006214")]
												[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
												get
												{
													return default(int);
												}
												[Token(Token = "0x6006215")]
												[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
												set
												{
												}
											}

											[Token(Token = "0x170014D8")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public int PowerLevel
											{
												[Token(Token = "0x6006216")]
												[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
												get
												{
													return default(int);
												}
												[Token(Token = "0x6006217")]
												[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
												set
												{
												}
											}

											[Token(Token = "0x6006211")]
											[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public MutantInformation()
											{
											}

											[Token(Token = "0x6006212")]
											[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public MutantInformation(MutantInformation other)
											{
											}

											[Token(Token = "0x6006213")]
											[Address(RVA = "0xB81C80", Offset = "0xB81080", VA = "0x180B81C80", Slot = "10")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public MutantInformation Clone()
											{
												return null;
											}

											[Token(Token = "0x6006218")]
											[Address(RVA = "0xB81D10", Offset = "0xB81110", VA = "0x180B81D10", Slot = "0")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public override bool Equals(object other)
											{
												return default(bool);
											}

											[Token(Token = "0x6006219")]
											[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public bool Equals(MutantInformation other)
											{
												return default(bool);
											}

											[Token(Token = "0x600621A")]
											[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public override int GetHashCode()
											{
												return default(int);
											}

											[Token(Token = "0x600621B")]
											[Address(RVA = "0xB81DA0", Offset = "0xB811A0", VA = "0x180B81DA0", Slot = "3")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public override string ToString()
											{
												return null;
											}

											[Token(Token = "0x600621C")]
											[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											public void WriteTo(CodedOutputStream output)
											{
											}

											[Token(Token = "0x600621D")]
											[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
											{
											}

											[Token(Token = "0x600621E")]
											[Address(RVA = "0xB81BC0", Offset = "0xB80FC0", VA = "0x180B81BC0", Slot = "7")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public int CalculateSize()
											{
												return default(int);
											}

											[Token(Token = "0x600621F")]
											[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public void MergeFrom(MutantInformation other)
											{
											}

											[Token(Token = "0x6006220")]
											[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
											[DebuggerNonUserCode]
											[GeneratedCode("protoc", null)]
											public void MergeFrom(CodedInputStream input)
											{
											}

											[Token(Token = "0x6006221")]
											[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
											[GeneratedCode("protoc", null)]
											[DebuggerNonUserCode]
											private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
											{
											}
										}
									}

									[Token(Token = "0x4002075")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<Humanoid> _parser;

									[Token(Token = "0x4002076")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x4002077")]
									public const int RestrictionsFieldNumber = 1;

									[Token(Token = "0x4002078")]
									[FieldOffset(Offset = "0x8")]
									private static readonly FieldCodec<Restriction> _repeated_restrictions_codec;

									[Token(Token = "0x4002079")]
									[FieldOffset(Offset = "0x18")]
									private readonly RepeatedField<Restriction> restrictions_;

									[Token(Token = "0x400207A")]
									public const int GenderFieldNumber = 2;

									[Token(Token = "0x400207B")]
									[FieldOffset(Offset = "0x20")]
									private Gender gender_;

									[Token(Token = "0x400207C")]
									public const int OptionsFieldNumber = 3;

									[Token(Token = "0x400207D")]
									[FieldOffset(Offset = "0x10")]
									private static readonly FieldCodec<Types.HumanOption> _repeated_options_codec;

									[Token(Token = "0x400207E")]
									[FieldOffset(Offset = "0x28")]
									private readonly RepeatedField<Types.HumanOption> options_;

									[Token(Token = "0x400207F")]
									public const int AccountIdFieldNumber = 4;

									[Token(Token = "0x4002080")]
									[FieldOffset(Offset = "0x30")]
									private long accountId_;

									[Token(Token = "0x4002081")]
									public const int AlignmentInformationFieldNumber = 5;

									[Token(Token = "0x4002082")]
									[FieldOffset(Offset = "0x38")]
									private AlignmentInformation alignmentInformation_;

									[Token(Token = "0x4002083")]
									public const int MutantInformationFieldNumber = 6;

									[Token(Token = "0x4002084")]
									[FieldOffset(Offset = "0x40")]
									private Types.MutantInformation mutantInformation_;

									[Token(Token = "0x1700148D")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<Humanoid> Parser
									{
										[Token(Token = "0x60060FA")]
										[Address(RVA = "0xB7F120", Offset = "0xB7E520", VA = "0x180B7F120")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700148E")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x60060FB")]
										[Address(RVA = "0xB7F0A0", Offset = "0xB7E4A0", VA = "0x180B7F0A0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700148F")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x60060FC")]
										[Address(RVA = "0xB7F580", Offset = "0xB7E980", VA = "0x180B7F580", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001490")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public RepeatedField<Restriction> Restrictions
									{
										[Token(Token = "0x6006100")]
										[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001491")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public Gender Gender
									{
										[Token(Token = "0x6006101")]
										[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
										get
										{
											return default(Gender);
										}
										[Token(Token = "0x6006102")]
										[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
										set
										{
										}
									}

									[Token(Token = "0x17001492")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public RepeatedField<Types.HumanOption> Options
									{
										[Token(Token = "0x6006103")]
										[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001493")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public long AccountId
									{
										[Token(Token = "0x6006104")]
										[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
										get
										{
											return default(long);
										}
										[Token(Token = "0x6006105")]
										[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
										set
										{
										}
									}

									[Token(Token = "0x17001494")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public AlignmentInformation AlignmentInformation
									{
										[Token(Token = "0x6006106")]
										[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
										get
										{
											return null;
										}
										[Token(Token = "0x6006107")]
										[Address(RVA = "0x91A5A0", Offset = "0x9199A0", VA = "0x18091A5A0")]
										set
										{
										}
									}

									[Token(Token = "0x17001495")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public Types.MutantInformation MutantInformation
									{
										[Token(Token = "0x6006108")]
										[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
										get
										{
											return null;
										}
										[Token(Token = "0x6006109")]
										[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
										set
										{
										}
									}

									[Token(Token = "0x60060FD")]
									[Address(RVA = "0xB7EE60", Offset = "0xB7E260", VA = "0x180B7EE60")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Humanoid()
									{
									}

									[Token(Token = "0x60060FE")]
									[Address(RVA = "0xB7EF20", Offset = "0xB7E320", VA = "0x180B7EF20")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Humanoid(Humanoid other)
									{
									}

									[Token(Token = "0x60060FF")]
									[Address(RVA = "0xB7E5E0", Offset = "0xB7D9E0", VA = "0x180B7E5E0", Slot = "10")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Humanoid Clone()
									{
										return null;
									}

									[Token(Token = "0x600610A")]
									[Address(RVA = "0xB7E640", Offset = "0xB7DA40", VA = "0x180B7E640", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x600610B")]
									[Address(RVA = "0xB7E790", Offset = "0xB7DB90", VA = "0x180B7E790", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(Humanoid other)
									{
										return default(bool);
									}

									[Token(Token = "0x600610C")]
									[Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890", Slot = "2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x600610D")]
									[Address(RVA = "0xB7EB60", Offset = "0xB7DF60", VA = "0x180B7EB60", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x600610E")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x600610F")]
									[Address(RVA = "0xB7F3E0", Offset = "0xB7E7E0", VA = "0x180B7F3E0", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006110")]
									[Address(RVA = "0xB7E420", Offset = "0xB7D820", VA = "0x180B7E420", Slot = "7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x6006111")]
									[Address(RVA = "0xB7E9A0", Offset = "0xB7DDA0", VA = "0x180B7E9A0", Slot = "4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(Humanoid other)
									{
									}

									[Token(Token = "0x6006112")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x6006113")]
									[Address(RVA = "0xB7F170", Offset = "0xB7E570", VA = "0x180B7F170", Slot = "11")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}

								[Token(Token = "0x200096A")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class Mount : IMessage<Mount>, IMessage, IEquatable<Mount>, IDeepCloneable<Mount>, IBufferMessage
								{
									[Token(Token = "0x40020EC")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<Mount> _parser;

									[Token(Token = "0x40020ED")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x40020EE")]
									public const int OwnerNameFieldNumber = 1;

									[Token(Token = "0x40020EF")]
									[FieldOffset(Offset = "0x18")]
									private string ownerName_;

									[Token(Token = "0x40020F0")]
									public const int LevelFieldNumber = 2;

									[Token(Token = "0x40020F1")]
									[FieldOffset(Offset = "0x20")]
									private int level_;

									[Token(Token = "0x170014D9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageParser<Mount> Parser
									{
										[Token(Token = "0x600622B")]
										[Address(RVA = "0xB81980", Offset = "0xB80D80", VA = "0x180B81980")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014DA")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x600622C")]
										[Address(RVA = "0xB81900", Offset = "0xB80D00", VA = "0x180B81900")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014DB")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x600622D")]
										[Address(RVA = "0xB81AA0", Offset = "0xB80EA0", VA = "0x180B81AA0", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014DC")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public string OwnerName
									{
										[Token(Token = "0x6006231")]
										[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
										get
										{
											return null;
										}
										[Token(Token = "0x6006232")]
										[Address(RVA = "0xB81B50", Offset = "0xB80F50", VA = "0x180B81B50")]
										set
										{
										}
									}

									[Token(Token = "0x170014DD")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int Level
									{
										[Token(Token = "0x6006233")]
										[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006234")]
										[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
										set
										{
										}
									}

									[Token(Token = "0x600622E")]
									[Address(RVA = "0xB818B0", Offset = "0xB80CB0", VA = "0x180B818B0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Mount()
									{
									}

									[Token(Token = "0x600622F")]
									[Address(RVA = "0xB81800", Offset = "0xB80C00", VA = "0x180B81800")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Mount(Mount other)
									{
									}

									[Token(Token = "0x6006230")]
									[Address(RVA = "0xB814B0", Offset = "0xB808B0", VA = "0x180B814B0", Slot = "10")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public Mount Clone()
									{
										return null;
									}

									[Token(Token = "0x6006235")]
									[Address(RVA = "0xB81580", Offset = "0xB80980", VA = "0x180B81580", Slot = "0")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006236")]
									[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(Mount other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006237")]
									[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x6006238")]
									[Address(RVA = "0xB816A0", Offset = "0xB80AA0", VA = "0x180B816A0", Slot = "3")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x6006239")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x600623A")]
									[Address(RVA = "0x955630", Offset = "0x954A30", VA = "0x180955630", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x600623B")]
									[Address(RVA = "0xB813F0", Offset = "0xB807F0", VA = "0x180B813F0", Slot = "7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x600623C")]
									[Address(RVA = "0xB81630", Offset = "0xB80A30", VA = "0x180B81630", Slot = "4")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(Mount other)
									{
									}

									[Token(Token = "0x600623D")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x600623E")]
									[Address(RVA = "0xB819D0", Offset = "0xB80DD0", VA = "0x180B819D0", Slot = "11")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}
							}

							[Token(Token = "0x4002069")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<NamedActor> _parser;

							[Token(Token = "0x400206A")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x400206B")]
							public const int NameFieldNumber = 1;

							[Token(Token = "0x400206C")]
							[FieldOffset(Offset = "0x18")]
							private string name_;

							[Token(Token = "0x400206D")]
							public const int HumanoidInformationFieldNumber = 2;

							[Token(Token = "0x400206E")]
							public const int MountInformationFieldNumber = 3;

							[Token(Token = "0x400206F")]
							[FieldOffset(Offset = "0x20")]
							private object actor_;

							[Token(Token = "0x4002070")]
							[FieldOffset(Offset = "0x28")]
							private ActorOneofCase actorCase_;

							[Token(Token = "0x17001486")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageParser<NamedActor> Parser
							{
								[Token(Token = "0x60060E1")]
								[Address(RVA = "0xB82E00", Offset = "0xB82200", VA = "0x180B82E00")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001487")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x60060E2")]
								[Address(RVA = "0xB82CC0", Offset = "0xB820C0", VA = "0x180B82CC0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001488")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x60060E3")]
								[Address(RVA = "0xB83170", Offset = "0xB82570", VA = "0x180B83170", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001489")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public string Name
							{
								[Token(Token = "0x60060E7")]
								[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
								get
								{
									return null;
								}
								[Token(Token = "0x60060E8")]
								[Address(RVA = "0xB831B0", Offset = "0xB825B0", VA = "0x180B831B0")]
								set
								{
								}
							}

							[Token(Token = "0x1700148A")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public Types.Humanoid HumanoidInformation
							{
								[Token(Token = "0x60060E9")]
								[Address(RVA = "0xB82D40", Offset = "0xB82140", VA = "0x180B82D40")]
								get
								{
									return null;
								}
								[Token(Token = "0x60060EA")]
								[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
								set
								{
								}
							}

							[Token(Token = "0x1700148B")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.Mount MountInformation
							{
								[Token(Token = "0x60060EB")]
								[Address(RVA = "0xB82DA0", Offset = "0xB821A0", VA = "0x180B82DA0")]
								get
								{
									return null;
								}
								[Token(Token = "0x60060EC")]
								[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
								set
								{
								}
							}

							[Token(Token = "0x1700148C")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public ActorOneofCase ActorCase
							{
								[Token(Token = "0x60060ED")]
								[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
								get
								{
									return default(ActorOneofCase);
								}
							}

							[Token(Token = "0x60060E4")]
							[Address(RVA = "0xB82C70", Offset = "0xB82070", VA = "0x180B82C70")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public NamedActor()
							{
							}

							[Token(Token = "0x60060E5")]
							[Address(RVA = "0xB829E0", Offset = "0xB81DE0", VA = "0x180B829E0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public NamedActor(NamedActor other)
							{
							}

							[Token(Token = "0x60060E6")]
							[Address(RVA = "0xB82200", Offset = "0xB81600", VA = "0x180B82200", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public NamedActor Clone()
							{
								return null;
							}

							[Token(Token = "0x60060EE")]
							[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void ClearActor()
							{
							}

							[Token(Token = "0x60060EF")]
							[Address(RVA = "0xB82260", Offset = "0xB81660", VA = "0x180B82260", Slot = "0")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x60060F0")]
							[Address(RVA = "0xB82380", Offset = "0xB81780", VA = "0x180B82380", Slot = "9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public bool Equals(NamedActor other)
							{
								return default(bool);
							}

							[Token(Token = "0x60060F1")]
							[Address(RVA = "0xB82460", Offset = "0xB81860", VA = "0x180B82460", Slot = "2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x60060F2")]
							[Address(RVA = "0xB82880", Offset = "0xB81C80", VA = "0x180B82880", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x60060F3")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x60060F4")]
							[Address(RVA = "0xB83030", Offset = "0xB82430", VA = "0x180B83030", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x60060F5")]
							[Address(RVA = "0xB82080", Offset = "0xB81480", VA = "0x180B82080", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x60060F6")]
							[Address(RVA = "0xB825C0", Offset = "0xB819C0", VA = "0x180B825C0", Slot = "4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(NamedActor other)
							{
							}

							[Token(Token = "0x60060F7")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x60060F8")]
							[Address(RVA = "0xB82E50", Offset = "0xB82250", VA = "0x180B82E50", Slot = "11")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}

						[Token(Token = "0x200096D")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class TaxCollectorActor : IMessage<TaxCollectorActor>, IMessage, IEquatable<TaxCollectorActor>, IDeepCloneable<TaxCollectorActor>, IBufferMessage
						{
							[Token(Token = "0x40020F4")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<TaxCollectorActor> _parser;

							[Token(Token = "0x40020F5")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x40020F6")]
							public const int IdentificationFieldNumber = 1;

							[Token(Token = "0x40020F7")]
							[FieldOffset(Offset = "0x18")]
							private TaxCollectorStaticInformation identification_;

							[Token(Token = "0x40020F8")]
							public const int AttackFieldNumber = 2;

							[Token(Token = "0x40020F9")]
							[FieldOffset(Offset = "0x20")]
							private int attack_;

							[Token(Token = "0x170014DE")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<TaxCollectorActor> Parser
							{
								[Token(Token = "0x6006246")]
								[Address(RVA = "0xB8A2B0", Offset = "0xB896B0", VA = "0x180B8A2B0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014DF")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x6006247")]
								[Address(RVA = "0xB8A230", Offset = "0xB89630", VA = "0x180B8A230")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014E0")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x6006248")]
								[Address(RVA = "0xB8A420", Offset = "0xB89820", VA = "0x180B8A420", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014E1")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public TaxCollectorStaticInformation Identification
							{
								[Token(Token = "0x600624C")]
								[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
								get
								{
									return null;
								}
								[Token(Token = "0x600624D")]
								[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
								set
								{
								}
							}

							[Token(Token = "0x170014E2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int Attack
							{
								[Token(Token = "0x600624E")]
								[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x600624F")]
								[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
								set
								{
								}
							}

							[Token(Token = "0x6006249")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public TaxCollectorActor()
							{
							}

							[Token(Token = "0x600624A")]
							[Address(RVA = "0xB8A1B0", Offset = "0xB895B0", VA = "0x180B8A1B0")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public TaxCollectorActor(TaxCollectorActor other)
							{
							}

							[Token(Token = "0x600624B")]
							[Address(RVA = "0xB89E20", Offset = "0xB89220", VA = "0x180B89E20", Slot = "10")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public TaxCollectorActor Clone()
							{
								return null;
							}

							[Token(Token = "0x6006250")]
							[Address(RVA = "0xB89ED0", Offset = "0xB892D0", VA = "0x180B89ED0", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x6006251")]
							[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public bool Equals(TaxCollectorActor other)
							{
								return default(bool);
							}

							[Token(Token = "0x6006252")]
							[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x6006253")]
							[Address(RVA = "0xB8A050", Offset = "0xB89450", VA = "0x180B8A050", Slot = "3")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x6006254")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x6006255")]
							[Address(RVA = "0x9D2390", Offset = "0x9D1790", VA = "0x1809D2390", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x6006256")]
							[Address(RVA = "0xB89D60", Offset = "0xB89160", VA = "0x180B89D60", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x6006257")]
							[Address(RVA = "0xB89F80", Offset = "0xB89380", VA = "0x180B89F80", Slot = "4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(TaxCollectorActor other)
							{
							}

							[Token(Token = "0x6006258")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x6006259")]
							[Address(RVA = "0xB8A300", Offset = "0xB89700", VA = "0x180B8A300", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}

						[Token(Token = "0x200096F")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class MonsterGroupActor : IMessage<MonsterGroupActor>, IMessage, IEquatable<MonsterGroupActor>, IDeepCloneable<MonsterGroupActor>, IBufferMessage
						{
							[Token(Token = "0x2000970")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static class Types
							{
								[Token(Token = "0x2000971")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class WaveInformation : IMessage<WaveInformation>, IMessage, IEquatable<WaveInformation>, IDeepCloneable<WaveInformation>, IBufferMessage
								{
									[Token(Token = "0x4002105")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<WaveInformation> _parser;

									[Token(Token = "0x4002106")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x4002107")]
									[FieldOffset(Offset = "0x18")]
									private int _hasBits0;

									[Token(Token = "0x4002108")]
									public const int WaveCountFieldNumber = 1;

									[Token(Token = "0x4002109")]
									[FieldOffset(Offset = "0x8")]
									private static readonly int WaveCountDefaultValue;

									[Token(Token = "0x400210A")]
									[FieldOffset(Offset = "0x1C")]
									private int waveCount_;

									[Token(Token = "0x400210B")]
									public const int AlternativesFieldNumber = 2;

									[Token(Token = "0x400210C")]
									[FieldOffset(Offset = "0x10")]
									private static readonly FieldCodec<MonsterGroupStaticInformation> _repeated_alternatives_codec;

									[Token(Token = "0x400210D")]
									[FieldOffset(Offset = "0x20")]
									private readonly RepeatedField<MonsterGroupStaticInformation> alternatives_;

									[Token(Token = "0x170014EA")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageParser<WaveInformation> Parser
									{
										[Token(Token = "0x6006277")]
										[Address(RVA = "0xB8CB60", Offset = "0xB8BF60", VA = "0x180B8CB60")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014EB")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x6006278")]
										[Address(RVA = "0xB8CAE0", Offset = "0xB8BEE0", VA = "0x180B8CAE0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014EC")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x6006279")]
										[Address(RVA = "0xB8CE70", Offset = "0xB8C270", VA = "0x180B8CE70", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014ED")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int WaveCount
									{
										[Token(Token = "0x600627D")]
										[Address(RVA = "0xB8CBB0", Offset = "0xB8BFB0", VA = "0x180B8CBB0")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x600627E")]
										[Address(RVA = "0xAB9820", Offset = "0xAB8C20", VA = "0x180AB9820")]
										set
										{
										}
									}

									[Token(Token = "0x170014EE")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool HasWaveCount
									{
										[Token(Token = "0x600627F")]
										[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
										get
										{
											return default(bool);
										}
									}

									[Token(Token = "0x170014EF")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public RepeatedField<MonsterGroupStaticInformation> Alternatives
									{
										[Token(Token = "0x6006281")]
										[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x600627A")]
									[Address(RVA = "0xB8CA60", Offset = "0xB8BE60", VA = "0x180B8CA60")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public WaveInformation()
									{
									}

									[Token(Token = "0x600627B")]
									[Address(RVA = "0xB8C9C0", Offset = "0xB8BDC0", VA = "0x180B8C9C0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public WaveInformation(WaveInformation other)
									{
									}

									[Token(Token = "0x600627C")]
									[Address(RVA = "0xB8C3A0", Offset = "0xB8B7A0", VA = "0x180B8C3A0", Slot = "10")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public WaveInformation Clone()
									{
										return null;
									}

									[Token(Token = "0x6006280")]
									[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void ClearWaveCount()
									{
									}

									[Token(Token = "0x6006282")]
									[Address(RVA = "0xB8C470", Offset = "0xB8B870", VA = "0x180B8C470", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006283")]
									[Address(RVA = "0xB8C560", Offset = "0xB8B960", VA = "0x180B8C560", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(WaveInformation other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006284")]
									[Address(RVA = "0xB8C620", Offset = "0xB8BA20", VA = "0x180B8C620", Slot = "2")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x6006285")]
									[Address(RVA = "0xB8C7A0", Offset = "0xB8BBA0", VA = "0x180B8C7A0", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x6006286")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x6006287")]
									[Address(RVA = "0xB8CD50", Offset = "0xB8C150", VA = "0x180B8CD50", Slot = "12")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006288")]
									[Address(RVA = "0xB8C270", Offset = "0xB8B670", VA = "0x180B8C270", Slot = "7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x6006289")]
									[Address(RVA = "0xB8C700", Offset = "0xB8BB00", VA = "0x180B8C700", Slot = "4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(WaveInformation other)
									{
									}

									[Token(Token = "0x600628A")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x600628B")]
									[Address(RVA = "0xB8CC20", Offset = "0xB8C020", VA = "0x180B8CC20", Slot = "11")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}
							}

							[Token(Token = "0x40020FB")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<MonsterGroupActor> _parser;

							[Token(Token = "0x40020FC")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x40020FD")]
							public const int IdentificationFieldNumber = 1;

							[Token(Token = "0x40020FE")]
							[FieldOffset(Offset = "0x18")]
							private MonsterGroupStaticInformation identification_;

							[Token(Token = "0x40020FF")]
							public const int LootShareFieldNumber = 2;

							[Token(Token = "0x4002100")]
							[FieldOffset(Offset = "0x20")]
							private int lootShare_;

							[Token(Token = "0x4002101")]
							public const int AlignmentFieldNumber = 3;

							[Token(Token = "0x4002102")]
							[FieldOffset(Offset = "0x24")]
							private Alignment alignment_;

							[Token(Token = "0x4002103")]
							public const int WaveInformationFieldNumber = 4;

							[Token(Token = "0x4002104")]
							[FieldOffset(Offset = "0x28")]
							private Types.WaveInformation waveInformation_;

							[Token(Token = "0x170014E3")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<MonsterGroupActor> Parser
							{
								[Token(Token = "0x600625E")]
								[Address(RVA = "0xB81110", Offset = "0xB80510", VA = "0x180B81110")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014E4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x600625F")]
								[Address(RVA = "0xB81090", Offset = "0xB80490", VA = "0x180B81090")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014E5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x6006260")]
								[Address(RVA = "0xB813B0", Offset = "0xB807B0", VA = "0x180B813B0", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014E6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public MonsterGroupStaticInformation Identification
							{
								[Token(Token = "0x6006264")]
								[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
								get
								{
									return null;
								}
								[Token(Token = "0x6006265")]
								[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
								set
								{
								}
							}

							[Token(Token = "0x170014E7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int LootShare
							{
								[Token(Token = "0x6006266")]
								[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6006267")]
								[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
								set
								{
								}
							}

							[Token(Token = "0x170014E8")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Alignment Alignment
							{
								[Token(Token = "0x6006268")]
								[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
								get
								{
									return default(Alignment);
								}
								[Token(Token = "0x6006269")]
								[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
								set
								{
								}
							}

							[Token(Token = "0x170014E9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.WaveInformation WaveInformation
							{
								[Token(Token = "0x600626A")]
								[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
								get
								{
									return null;
								}
								[Token(Token = "0x600626B")]
								[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
								set
								{
								}
							}

							[Token(Token = "0x6006261")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public MonsterGroupActor()
							{
							}

							[Token(Token = "0x6006262")]
							[Address(RVA = "0xB80F40", Offset = "0xB80340", VA = "0x180B80F40")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public MonsterGroupActor(MonsterGroupActor other)
							{
							}

							[Token(Token = "0x6006263")]
							[Address(RVA = "0xB80870", Offset = "0xB7FC70", VA = "0x180B80870", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public MonsterGroupActor Clone()
							{
								return null;
							}

							[Token(Token = "0x600626C")]
							[Address(RVA = "0xB809F0", Offset = "0xB7FDF0", VA = "0x180B809F0", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x600626D")]
							[Address(RVA = "0xB80AC0", Offset = "0xB7FEC0", VA = "0x180B80AC0", Slot = "9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public bool Equals(MonsterGroupActor other)
							{
								return default(bool);
							}

							[Token(Token = "0x600626E")]
							[Address(RVA = "0xB80B50", Offset = "0xB7FF50", VA = "0x180B80B50", Slot = "2")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x600626F")]
							[Address(RVA = "0xB80DE0", Offset = "0xB801E0", VA = "0x180B80DE0", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x6006270")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x6006271")]
							[Address(RVA = "0xB812F0", Offset = "0xB806F0", VA = "0x180B812F0", Slot = "12")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x6006272")]
							[Address(RVA = "0xB80760", Offset = "0xB7FB60", VA = "0x180B80760", Slot = "7")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x6006273")]
							[Address(RVA = "0xB80C20", Offset = "0xB80020", VA = "0x180B80C20", Slot = "4")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(MonsterGroupActor other)
							{
							}

							[Token(Token = "0x6006274")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x6006275")]
							[Address(RVA = "0xB81160", Offset = "0xB80560", VA = "0x180B81160", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}

						[Token(Token = "0x2000974")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class NpcStaticInformation : IMessage<NpcStaticInformation>, IMessage, IEquatable<NpcStaticInformation>, IDeepCloneable<NpcStaticInformation>, IBufferMessage
						{
							[Token(Token = "0x2000975")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static class Types
							{
								[Token(Token = "0x2000976")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class Quests : IMessage<Quests>, IMessage, IEquatable<Quests>, IDeepCloneable<Quests>, IBufferMessage
								{
									[Token(Token = "0x400211A")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<Quests> _parser;

									[Token(Token = "0x400211B")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x400211C")]
									public const int QuestsToValidFieldNumber = 1;

									[Token(Token = "0x400211D")]
									[FieldOffset(Offset = "0x8")]
									private static readonly FieldCodec<int> _repeated_questsToValid_codec;

									[Token(Token = "0x400211E")]
									[FieldOffset(Offset = "0x18")]
									private readonly RepeatedField<int> questsToValid_;

									[Token(Token = "0x400211F")]
									public const int QuestsToStartFieldNumber = 2;

									[Token(Token = "0x4002120")]
									[FieldOffset(Offset = "0x10")]
									private static readonly FieldCodec<int> _repeated_questsToStart_codec;

									[Token(Token = "0x4002121")]
									[FieldOffset(Offset = "0x20")]
									private readonly RepeatedField<int> questsToStart_;

									[Token(Token = "0x170014F7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<Quests> Parser
									{
										[Token(Token = "0x60062AC")]
										[Address(RVA = "0xB87240", Offset = "0xB86640", VA = "0x180B87240")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014F8")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x60062AD")]
										[Address(RVA = "0xB871C0", Offset = "0xB865C0", VA = "0x180B871C0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014F9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x60062AE")]
										[Address(RVA = "0xB874D0", Offset = "0xB868D0", VA = "0x180B874D0", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014FA")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public RepeatedField<int> QuestsToValid
									{
										[Token(Token = "0x60062B2")]
										[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x170014FB")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public RepeatedField<int> QuestsToStart
									{
										[Token(Token = "0x60062B3")]
										[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x60062AF")]
									[Address(RVA = "0xB87110", Offset = "0xB86510", VA = "0x180B87110")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Quests()
									{
									}

									[Token(Token = "0x60062B0")]
									[Address(RVA = "0xB87060", Offset = "0xB86460", VA = "0x180B87060")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Quests(Quests other)
									{
									}

									[Token(Token = "0x60062B1")]
									[Address(RVA = "0xB86B80", Offset = "0xB85F80", VA = "0x180B86B80", Slot = "10")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public Quests Clone()
									{
										return null;
									}

									[Token(Token = "0x60062B4")]
									[Address(RVA = "0xB86C60", Offset = "0xB86060", VA = "0x180B86C60", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x60062B5")]
									[Address(RVA = "0xB86D50", Offset = "0xB86150", VA = "0x180B86D50", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(Quests other)
									{
										return default(bool);
									}

									[Token(Token = "0x60062B6")]
									[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x60062B7")]
									[Address(RVA = "0xB86EA0", Offset = "0xB862A0", VA = "0x180B86EA0", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x60062B8")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x60062B9")]
									[Address(RVA = "0xB873F0", Offset = "0xB867F0", VA = "0x180B873F0", Slot = "12")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x60062BA")]
									[Address(RVA = "0xB86AA0", Offset = "0xB85EA0", VA = "0x180B86AA0", Slot = "7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x60062BB")]
									[Address(RVA = "0xB86E00", Offset = "0xB86200", VA = "0x180B86E00", Slot = "4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(Quests other)
									{
									}

									[Token(Token = "0x60062BC")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x60062BD")]
									[Address(RVA = "0xB87290", Offset = "0xB86690", VA = "0x180B87290", Slot = "11")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}
							}

							[Token(Token = "0x4002110")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<NpcStaticInformation> _parser;

							[Token(Token = "0x4002111")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x4002112")]
							public const int NpcIdFieldNumber = 1;

							[Token(Token = "0x4002113")]
							[FieldOffset(Offset = "0x18")]
							private int npcId_;

							[Token(Token = "0x4002114")]
							public const int GenderFieldNumber = 2;

							[Token(Token = "0x4002115")]
							[FieldOffset(Offset = "0x1C")]
							private Gender gender_;

							[Token(Token = "0x4002116")]
							public const int SpecialArtworkIdFieldNumber = 3;

							[Token(Token = "0x4002117")]
							[FieldOffset(Offset = "0x20")]
							private int specialArtworkId_;

							[Token(Token = "0x4002118")]
							public const int QuestsFieldNumber = 4;

							[Token(Token = "0x4002119")]
							[FieldOffset(Offset = "0x28")]
							private Types.Quests quests_;

							[Token(Token = "0x170014F0")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<NpcStaticInformation> Parser
							{
								[Token(Token = "0x6006293")]
								[Address(RVA = "0xB85000", Offset = "0xB84400", VA = "0x180B85000")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014F1")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x6006294")]
								[Address(RVA = "0xB84F80", Offset = "0xB84380", VA = "0x180B84F80")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014F2")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x6006295")]
								[Address(RVA = "0xB85270", Offset = "0xB84670", VA = "0x180B85270", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170014F3")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int NpcId
							{
								[Token(Token = "0x6006299")]
								[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x600629A")]
								[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
								set
								{
								}
							}

							[Token(Token = "0x170014F4")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public Gender Gender
							{
								[Token(Token = "0x600629B")]
								[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
								get
								{
									return default(Gender);
								}
								[Token(Token = "0x600629C")]
								[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
								set
								{
								}
							}

							[Token(Token = "0x170014F5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int SpecialArtworkId
							{
								[Token(Token = "0x600629D")]
								[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x600629E")]
								[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
								set
								{
								}
							}

							[Token(Token = "0x170014F6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.Quests Quests
							{
								[Token(Token = "0x600629F")]
								[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
								get
								{
									return null;
								}
								[Token(Token = "0x60062A0")]
								[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
								set
								{
								}
							}

							[Token(Token = "0x6006296")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public NpcStaticInformation()
							{
							}

							[Token(Token = "0x6006297")]
							[Address(RVA = "0xB84E30", Offset = "0xB84230", VA = "0x180B84E30")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public NpcStaticInformation(NpcStaticInformation other)
							{
							}

							[Token(Token = "0x6006298")]
							[Address(RVA = "0xB84860", Offset = "0xB83C60", VA = "0x180B84860", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public NpcStaticInformation Clone()
							{
								return null;
							}

							[Token(Token = "0x60062A1")]
							[Address(RVA = "0xB849E0", Offset = "0xB83DE0", VA = "0x180B849E0", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x60062A2")]
							[Address(RVA = "0xB7FFB0", Offset = "0xB7F3B0", VA = "0x180B7FFB0", Slot = "9")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public bool Equals(NpcStaticInformation other)
							{
								return default(bool);
							}

							[Token(Token = "0x60062A3")]
							[Address(RVA = "0xB84AA0", Offset = "0xB83EA0", VA = "0x180B84AA0", Slot = "2")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x60062A4")]
							[Address(RVA = "0xB84CD0", Offset = "0xB840D0", VA = "0x180B84CD0", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x60062A5")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x60062A6")]
							[Address(RVA = "0xB851B0", Offset = "0xB845B0", VA = "0x180B851B0", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x60062A7")]
							[Address(RVA = "0xB84750", Offset = "0xB83B50", VA = "0x180B84750", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x60062A8")]
							[Address(RVA = "0xB84B60", Offset = "0xB83F60", VA = "0x180B84B60", Slot = "4")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(NpcStaticInformation other)
							{
							}

							[Token(Token = "0x60062A9")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x60062AA")]
							[Address(RVA = "0xB85050", Offset = "0xB84450", VA = "0x180B85050", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}
					}

					[Token(Token = "0x4002055")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<RolePlayActor> _parser;

					[Token(Token = "0x4002056")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002057")]
					public const int NamedActorFieldNumber = 4;

					[Token(Token = "0x4002058")]
					public const int TaxCollectorActorFieldNumber = 5;

					[Token(Token = "0x4002059")]
					public const int MonsterGroupActorFieldNumber = 6;

					[Token(Token = "0x400205A")]
					public const int NpcActorFieldNumber = 7;

					[Token(Token = "0x400205B")]
					public const int PrismActorFieldNumber = 8;

					[Token(Token = "0x400205C")]
					public const int PortalActorFieldNumber = 9;

					[Token(Token = "0x400205D")]
					public const int TreasureHuntNpcIdFieldNumber = 10;

					[Token(Token = "0x400205E")]
					[FieldOffset(Offset = "0x18")]
					private object actor_;

					[Token(Token = "0x400205F")]
					[FieldOffset(Offset = "0x20")]
					private ActorOneofCase actorCase_;

					[Token(Token = "0x1700147A")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<RolePlayActor> Parser
					{
						[Token(Token = "0x60060BE")]
						[Address(RVA = "0xB88B70", Offset = "0xB87F70", VA = "0x180B88B70")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700147B")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x60060BF")]
						[Address(RVA = "0xB889C0", Offset = "0xB87DC0", VA = "0x180B889C0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700147C")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x60060C0")]
						[Address(RVA = "0xB89470", Offset = "0xB88870", VA = "0x180B89470", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700147D")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.NamedActor NamedActor
					{
						[Token(Token = "0x60060C4")]
						[Address(RVA = "0xB88AB0", Offset = "0xB87EB0", VA = "0x180B88AB0")]
						get
						{
							return null;
						}
						[Token(Token = "0x60060C5")]
						[Address(RVA = "0x94E860", Offset = "0x94DC60", VA = "0x18094E860")]
						set
						{
						}
					}

					[Token(Token = "0x1700147E")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.TaxCollectorActor TaxCollectorActor
					{
						[Token(Token = "0x60060C6")]
						[Address(RVA = "0xB88C80", Offset = "0xB88080", VA = "0x180B88C80")]
						get
						{
							return null;
						}
						[Token(Token = "0x60060C7")]
						[Address(RVA = "0x94E820", Offset = "0x94DC20", VA = "0x18094E820")]
						set
						{
						}
					}

					[Token(Token = "0x1700147F")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.MonsterGroupActor MonsterGroupActor
					{
						[Token(Token = "0x60060C8")]
						[Address(RVA = "0xB88A50", Offset = "0xB87E50", VA = "0x180B88A50")]
						get
						{
							return null;
						}
						[Token(Token = "0x60060C9")]
						[Address(RVA = "0xB7E270", Offset = "0xB7D670", VA = "0x180B7E270")]
						set
						{
						}
					}

					[Token(Token = "0x17001480")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.NpcStaticInformation NpcActor
					{
						[Token(Token = "0x60060CA")]
						[Address(RVA = "0xB88B10", Offset = "0xB87F10", VA = "0x180B88B10")]
						get
						{
							return null;
						}
						[Token(Token = "0x60060CB")]
						[Address(RVA = "0xB7E3E0", Offset = "0xB7D7E0", VA = "0x180B7E3E0")]
						set
						{
						}
					}

					[Token(Token = "0x17001481")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public PrismInformation PrismActor
					{
						[Token(Token = "0x60060CC")]
						[Address(RVA = "0xB88C20", Offset = "0xB88020", VA = "0x180B88C20")]
						get
						{
							return null;
						}
						[Token(Token = "0x60060CD")]
						[Address(RVA = "0xB7E2F0", Offset = "0xB7D6F0", VA = "0x180B7E2F0")]
						set
						{
						}
					}

					[Token(Token = "0x17001482")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public PortalInformation PortalActor
					{
						[Token(Token = "0x60060CE")]
						[Address(RVA = "0xB88BC0", Offset = "0xB87FC0", VA = "0x180B88BC0")]
						get
						{
							return null;
						}
						[Token(Token = "0x60060CF")]
						[Address(RVA = "0xB7E2B0", Offset = "0xB7D6B0", VA = "0x180B7E2B0")]
						set
						{
						}
					}

					[Token(Token = "0x17001483")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int TreasureHuntNpcId
					{
						[Token(Token = "0x60060D0")]
						[Address(RVA = "0xB88CE0", Offset = "0xB880E0", VA = "0x180B88CE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60060D1")]
						[Address(RVA = "0xB894B0", Offset = "0xB888B0", VA = "0x180B894B0")]
						set
						{
						}
					}

					[Token(Token = "0x17001484")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool HasTreasureHuntNpcId
					{
						[Token(Token = "0x60060D2")]
						[Address(RVA = "0xB88A40", Offset = "0xB87E40", VA = "0x180B88A40")]
						get
						{
							return default(bool);
						}
					}

					[Token(Token = "0x17001485")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public ActorOneofCase ActorCase
					{
						[Token(Token = "0x60060D4")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(ActorOneofCase);
						}
					}

					[Token(Token = "0x60060C1")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public RolePlayActor()
					{
					}

					[Token(Token = "0x60060C2")]
					[Address(RVA = "0xB88480", Offset = "0xB87880", VA = "0x180B88480")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public RolePlayActor(RolePlayActor other)
					{
					}

					[Token(Token = "0x60060C3")]
					[Address(RVA = "0xB87930", Offset = "0xB86D30", VA = "0x180B87930", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public RolePlayActor Clone()
					{
						return null;
					}

					[Token(Token = "0x60060D3")]
					[Address(RVA = "0xB87910", Offset = "0xB86D10", VA = "0x180B87910")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void ClearTreasureHuntNpcId()
					{
					}

					[Token(Token = "0x60060D5")]
					[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void ClearActor()
					{
					}

					[Token(Token = "0x60060D6")]
					[Address(RVA = "0xB87B90", Offset = "0xB86F90", VA = "0x180B87B90", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x60060D7")]
					[Address(RVA = "0xB87990", Offset = "0xB86D90", VA = "0x180B87990", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(RolePlayActor other)
					{
						return default(bool);
					}

					[Token(Token = "0x60060D8")]
					[Address(RVA = "0xB87BF0", Offset = "0xB86FF0", VA = "0x180B87BF0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60060D9")]
					[Address(RVA = "0xB88320", Offset = "0xB87720", VA = "0x180B88320", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60060DA")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60060DB")]
					[Address(RVA = "0xB89130", Offset = "0xB88530", VA = "0x180B89130", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60060DC")]
					[Address(RVA = "0xB87580", Offset = "0xB86980", VA = "0x180B87580", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x60060DD")]
					[Address(RVA = "0xB87F60", Offset = "0xB87360", VA = "0x180B87F60", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(RolePlayActor other)
					{
					}

					[Token(Token = "0x60060DE")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x60060DF")]
					[Address(RVA = "0xB88D50", Offset = "0xB88150", VA = "0x180B88D50", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x200097A")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class FightFighterInformation : IMessage<FightFighterInformation>, IMessage, IEquatable<FightFighterInformation>, IDeepCloneable<FightFighterInformation>, IBufferMessage
				{
					[Token(Token = "0x200097B")]
					public enum FighterInformationOneofCase
					{
						[Token(Token = "0x4002136")]
						None = 0,
						[Token(Token = "0x4002137")]
						NamedFighter = 5,
						[Token(Token = "0x4002138")]
						AiFighter = 6,
						[Token(Token = "0x4002139")]
						EntityFighter = 7
					}

					[Token(Token = "0x200097C")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static class Types
					{
						[Token(Token = "0x200097D")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class NamedFighterInformation : IMessage<NamedFighterInformation>, IMessage, IEquatable<NamedFighterInformation>, IDeepCloneable<NamedFighterInformation>, IBufferMessage
						{
							[Token(Token = "0x200097E")]
							public enum FighterInformationOneofCase
							{
								[Token(Token = "0x400214B")]
								None = 0,
								[Token(Token = "0x400214C")]
								CharacterInformation = 6,
								[Token(Token = "0x400214D")]
								MutantInformation = 7
							}

							[Token(Token = "0x200097F")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static class Types
							{
								[Token(Token = "0x2000980")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class FightCharacterInformation : IMessage<FightCharacterInformation>, IMessage, IEquatable<FightCharacterInformation>, IDeepCloneable<FightCharacterInformation>, IBufferMessage
								{
									[Token(Token = "0x400214E")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<FightCharacterInformation> _parser;

									[Token(Token = "0x400214F")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x4002150")]
									public const int LevelFieldNumber = 1;

									[Token(Token = "0x4002151")]
									[FieldOffset(Offset = "0x18")]
									private int level_;

									[Token(Token = "0x4002152")]
									public const int AlignmentInformationFieldNumber = 2;

									[Token(Token = "0x4002153")]
									[FieldOffset(Offset = "0x20")]
									private AlignmentInformation alignmentInformation_;

									[Token(Token = "0x4002154")]
									public const int BreedIdFieldNumber = 3;

									[Token(Token = "0x4002155")]
									[FieldOffset(Offset = "0x28")]
									private int breedId_;

									[Token(Token = "0x4002156")]
									public const int GenderFieldNumber = 4;

									[Token(Token = "0x4002157")]
									[FieldOffset(Offset = "0x2C")]
									private Gender gender_;

									[Token(Token = "0x17001512")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageParser<FightCharacterInformation> Parser
									{
										[Token(Token = "0x6006309")]
										[Address(RVA = "0xB79270", Offset = "0xB78670", VA = "0x180B79270")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001513")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x600630A")]
										[Address(RVA = "0xB791F0", Offset = "0xB785F0", VA = "0x180B791F0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001514")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x600630B")]
										[Address(RVA = "0xB794E0", Offset = "0xB788E0", VA = "0x180B794E0", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001515")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int Level
									{
										[Token(Token = "0x600630F")]
										[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006310")]
										[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
										set
										{
										}
									}

									[Token(Token = "0x17001516")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public AlignmentInformation AlignmentInformation
									{
										[Token(Token = "0x6006311")]
										[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
										get
										{
											return null;
										}
										[Token(Token = "0x6006312")]
										[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
										set
										{
										}
									}

									[Token(Token = "0x17001517")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int BreedId
									{
										[Token(Token = "0x6006313")]
										[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006314")]
										[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
										set
										{
										}
									}

									[Token(Token = "0x17001518")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public Gender Gender
									{
										[Token(Token = "0x6006315")]
										[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
										get
										{
											return default(Gender);
										}
										[Token(Token = "0x6006316")]
										[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
										set
										{
										}
									}

									[Token(Token = "0x600630C")]
									[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public FightCharacterInformation()
									{
									}

									[Token(Token = "0x600630D")]
									[Address(RVA = "0xB79170", Offset = "0xB78570", VA = "0x180B79170")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public FightCharacterInformation(FightCharacterInformation other)
									{
									}

									[Token(Token = "0x600630E")]
									[Address(RVA = "0xB78C70", Offset = "0xB78070", VA = "0x180B78C70", Slot = "10")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public FightCharacterInformation Clone()
									{
										return null;
									}

									[Token(Token = "0x6006317")]
									[Address(RVA = "0xB78DA0", Offset = "0xB781A0", VA = "0x180B78DA0", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006318")]
									[Address(RVA = "0xB78D20", Offset = "0xB78120", VA = "0x180B78D20", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(FightCharacterInformation other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006319")]
									[Address(RVA = "0xB78E60", Offset = "0xB78260", VA = "0x180B78E60", Slot = "2")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x600631A")]
									[Address(RVA = "0xB79010", Offset = "0xB78410", VA = "0x180B79010", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x600631B")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x600631C")]
									[Address(RVA = "0xB79420", Offset = "0xB78820", VA = "0x180B79420", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x600631D")]
									[Address(RVA = "0xB78B60", Offset = "0xB77F60", VA = "0x180B78B60", Slot = "7")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x600631E")]
									[Address(RVA = "0xB78F20", Offset = "0xB78320", VA = "0x180B78F20", Slot = "4")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(FightCharacterInformation other)
									{
									}

									[Token(Token = "0x600631F")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x6006320")]
									[Address(RVA = "0xB792C0", Offset = "0xB786C0", VA = "0x180B792C0", Slot = "11")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}

								[Token(Token = "0x2000982")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class FightMutantInformation : IMessage<FightMutantInformation>, IMessage, IEquatable<FightMutantInformation>, IDeepCloneable<FightMutantInformation>, IBufferMessage
								{
									[Token(Token = "0x4002159")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<FightMutantInformation> _parser;

									[Token(Token = "0x400215A")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x400215B")]
									public const int PowerLevelFieldNumber = 1;

									[Token(Token = "0x400215C")]
									[FieldOffset(Offset = "0x18")]
									private int powerLevel_;

									[Token(Token = "0x17001519")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<FightMutantInformation> Parser
									{
										[Token(Token = "0x6006325")]
										[Address(RVA = "0xB7B240", Offset = "0xB7A640", VA = "0x180B7B240")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700151A")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x6006326")]
										[Address(RVA = "0xB7B1C0", Offset = "0xB7A5C0", VA = "0x180B7B1C0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700151B")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x6006327")]
										[Address(RVA = "0xB7B290", Offset = "0xB7A690", VA = "0x180B7B290", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700151C")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int PowerLevel
									{
										[Token(Token = "0x600632B")]
										[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x600632C")]
										[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
										set
										{
										}
									}

									[Token(Token = "0x6006328")]
									[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public FightMutantInformation()
									{
									}

									[Token(Token = "0x6006329")]
									[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public FightMutantInformation(FightMutantInformation other)
									{
									}

									[Token(Token = "0x600632A")]
									[Address(RVA = "0xB7AF50", Offset = "0xB7A350", VA = "0x180B7AF50", Slot = "10")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public FightMutantInformation Clone()
									{
										return null;
									}

									[Token(Token = "0x600632D")]
									[Address(RVA = "0xB7AFD0", Offset = "0xB7A3D0", VA = "0x180B7AFD0", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x600632E")]
									[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public bool Equals(FightMutantInformation other)
									{
										return default(bool);
									}

									[Token(Token = "0x600632F")]
									[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x6006330")]
									[Address(RVA = "0xB7B060", Offset = "0xB7A460", VA = "0x180B7B060", Slot = "3")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x6006331")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x6006332")]
									[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006333")]
									[Address(RVA = "0xB7AEC0", Offset = "0xB7A2C0", VA = "0x180B7AEC0", Slot = "7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x6006334")]
									[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(FightMutantInformation other)
									{
									}

									[Token(Token = "0x6006335")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x6006336")]
									[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}
							}

							[Token(Token = "0x400213A")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<NamedFighterInformation> _parser;

							[Token(Token = "0x400213B")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x400213C")]
							public const int NameFieldNumber = 1;

							[Token(Token = "0x400213D")]
							[FieldOffset(Offset = "0x18")]
							private string name_;

							[Token(Token = "0x400213E")]
							public const int StatusFieldNumber = 2;

							[Token(Token = "0x400213F")]
							[FieldOffset(Offset = "0x20")]
							private CharacterStatus status_;

							[Token(Token = "0x4002140")]
							public const int LeagueIdFieldNumber = 3;

							[Token(Token = "0x4002141")]
							[FieldOffset(Offset = "0x28")]
							private int leagueId_;

							[Token(Token = "0x4002142")]
							public const int LadderPositionFieldNumber = 4;

							[Token(Token = "0x4002143")]
							[FieldOffset(Offset = "0x2C")]
							private int ladderPosition_;

							[Token(Token = "0x4002144")]
							public const int HiddenInPreFightFieldNumber = 5;

							[Token(Token = "0x4002145")]
							[FieldOffset(Offset = "0x30")]
							private bool hiddenInPreFight_;

							[Token(Token = "0x4002146")]
							public const int CharacterInformationFieldNumber = 6;

							[Token(Token = "0x4002147")]
							public const int MutantInformationFieldNumber = 7;

							[Token(Token = "0x4002148")]
							[FieldOffset(Offset = "0x38")]
							private object fighterInformation_;

							[Token(Token = "0x4002149")]
							[FieldOffset(Offset = "0x40")]
							private FighterInformationOneofCase fighterInformationCase_;

							[Token(Token = "0x17001507")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<NamedFighterInformation> Parser
							{
								[Token(Token = "0x60062E8")]
								[Address(RVA = "0xB841B0", Offset = "0xB835B0", VA = "0x180B841B0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001508")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x60062E9")]
								[Address(RVA = "0xB840D0", Offset = "0xB834D0", VA = "0x180B840D0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001509")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x60062EA")]
								[Address(RVA = "0xB846A0", Offset = "0xB83AA0", VA = "0x180B846A0", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x1700150A")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public string Name
							{
								[Token(Token = "0x60062EE")]
								[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
								get
								{
									return null;
								}
								[Token(Token = "0x60062EF")]
								[Address(RVA = "0xB846E0", Offset = "0xB83AE0", VA = "0x180B846E0")]
								set
								{
								}
							}

							[Token(Token = "0x1700150B")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public CharacterStatus Status
							{
								[Token(Token = "0x60062F0")]
								[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
								get
								{
									return null;
								}
								[Token(Token = "0x60062F1")]
								[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
								set
								{
								}
							}

							[Token(Token = "0x1700150C")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int LeagueId
							{
								[Token(Token = "0x60062F2")]
								[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x60062F3")]
								[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
								set
								{
								}
							}

							[Token(Token = "0x1700150D")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int LadderPosition
							{
								[Token(Token = "0x60062F4")]
								[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x60062F5")]
								[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
								set
								{
								}
							}

							[Token(Token = "0x1700150E")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public bool HiddenInPreFight
							{
								[Token(Token = "0x60062F6")]
								[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
								get
								{
									return default(bool);
								}
								[Token(Token = "0x60062F7")]
								[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
								set
								{
								}
							}

							[Token(Token = "0x1700150F")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.FightCharacterInformation CharacterInformation
							{
								[Token(Token = "0x60062F8")]
								[Address(RVA = "0xB84070", Offset = "0xB83470", VA = "0x180B84070")]
								get
								{
									return null;
								}
								[Token(Token = "0x60062F9")]
								[Address(RVA = "0x95FFD0", Offset = "0x95F3D0", VA = "0x18095FFD0")]
								set
								{
								}
							}

							[Token(Token = "0x17001510")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.FightMutantInformation MutantInformation
							{
								[Token(Token = "0x60062FA")]
								[Address(RVA = "0xB84150", Offset = "0xB83550", VA = "0x180B84150")]
								get
								{
									return null;
								}
								[Token(Token = "0x60062FB")]
								[Address(RVA = "0xB7AE40", Offset = "0xB7A240", VA = "0x180B7AE40")]
								set
								{
								}
							}

							[Token(Token = "0x17001511")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public FighterInformationOneofCase FighterInformationCase
							{
								[Token(Token = "0x60062FC")]
								[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
								get
								{
									return default(FighterInformationOneofCase);
								}
							}

							[Token(Token = "0x60062EB")]
							[Address(RVA = "0xB84020", Offset = "0xB83420", VA = "0x180B84020")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public NamedFighterInformation()
							{
							}

							[Token(Token = "0x60062EC")]
							[Address(RVA = "0xB83D60", Offset = "0xB83160", VA = "0x180B83D60")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public NamedFighterInformation(NamedFighterInformation other)
							{
							}

							[Token(Token = "0x60062ED")]
							[Address(RVA = "0xB83420", Offset = "0xB82820", VA = "0x180B83420", Slot = "10")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public NamedFighterInformation Clone()
							{
								return null;
							}

							[Token(Token = "0x60062FD")]
							[Address(RVA = "0x95F130", Offset = "0x95E530", VA = "0x18095F130")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void ClearFighterInformation()
							{
							}

							[Token(Token = "0x60062FE")]
							[Address(RVA = "0xB83480", Offset = "0xB82880", VA = "0x180B83480", Slot = "0")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x60062FF")]
							[Address(RVA = "0xB835D0", Offset = "0xB829D0", VA = "0x180B835D0", Slot = "9")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public bool Equals(NamedFighterInformation other)
							{
								return default(bool);
							}

							[Token(Token = "0x6006300")]
							[Address(RVA = "0xB836F0", Offset = "0xB82AF0", VA = "0x180B836F0", Slot = "2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x6006301")]
							[Address(RVA = "0xB83C00", Offset = "0xB83000", VA = "0x180B83C00", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x6006302")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x6006303")]
							[Address(RVA = "0xB844D0", Offset = "0xB838D0", VA = "0x180B844D0", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x6006304")]
							[Address(RVA = "0xB83220", Offset = "0xB82620", VA = "0x180B83220", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x6006305")]
							[Address(RVA = "0xB838F0", Offset = "0xB82CF0", VA = "0x180B838F0", Slot = "4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(NamedFighterInformation other)
							{
							}

							[Token(Token = "0x6006306")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x6006307")]
							[Address(RVA = "0xB84200", Offset = "0xB83600", VA = "0x180B84200", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}

						[Token(Token = "0x2000985")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class AIFighterInformation : IMessage<AIFighterInformation>, IMessage, IEquatable<AIFighterInformation>, IDeepCloneable<AIFighterInformation>, IBufferMessage
						{
							[Token(Token = "0x2000986")]
							public enum AiFighterInformationOneofCase
							{
								[Token(Token = "0x4002166")]
								None,
								[Token(Token = "0x4002167")]
								MonsterFighterInformation,
								[Token(Token = "0x4002168")]
								TaxCollectorInformation
							}

							[Token(Token = "0x2000987")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static class Types
							{
								[Token(Token = "0x2000988")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class MonsterFighter : IMessage<MonsterFighter>, IMessage, IEquatable<MonsterFighter>, IDeepCloneable<MonsterFighter>, IBufferMessage
								{
									[Token(Token = "0x4002169")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<MonsterFighter> _parser;

									[Token(Token = "0x400216A")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x400216B")]
									public const int MonsterGidFieldNumber = 1;

									[Token(Token = "0x400216C")]
									[FieldOffset(Offset = "0x18")]
									private int monsterGid_;

									[Token(Token = "0x400216D")]
									public const int CreatureGradeFieldNumber = 2;

									[Token(Token = "0x400216E")]
									[FieldOffset(Offset = "0x1C")]
									private int creatureGrade_;

									[Token(Token = "0x400216F")]
									public const int CreatureLevelFieldNumber = 3;

									[Token(Token = "0x4002170")]
									[FieldOffset(Offset = "0x20")]
									private int creatureLevel_;

									[Token(Token = "0x4002171")]
									public const int AlignmentInformationFieldNumber = 4;

									[Token(Token = "0x4002172")]
									[FieldOffset(Offset = "0x28")]
									private AlignmentInformation alignmentInformation_;

									[Token(Token = "0x17001523")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public static MessageParser<MonsterFighter> Parser
									{
										[Token(Token = "0x6006355")]
										[Address(RVA = "0xB80440", Offset = "0xB7F840", VA = "0x180B80440")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001524")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x6006356")]
										[Address(RVA = "0xB803C0", Offset = "0xB7F7C0", VA = "0x180B803C0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001525")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x6006357")]
										[Address(RVA = "0xB806B0", Offset = "0xB7FAB0", VA = "0x180B806B0", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x17001526")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int MonsterGid
									{
										[Token(Token = "0x600635B")]
										[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x600635C")]
										[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
										set
										{
										}
									}

									[Token(Token = "0x17001527")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CreatureGrade
									{
										[Token(Token = "0x600635D")]
										[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x600635E")]
										[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
										set
										{
										}
									}

									[Token(Token = "0x17001528")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int CreatureLevel
									{
										[Token(Token = "0x600635F")]
										[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006360")]
										[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
										set
										{
										}
									}

									[Token(Token = "0x17001529")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public AlignmentInformation AlignmentInformation
									{
										[Token(Token = "0x6006361")]
										[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
										get
										{
											return null;
										}
										[Token(Token = "0x6006362")]
										[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
										set
										{
										}
									}

									[Token(Token = "0x6006358")]
									[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public MonsterFighter()
									{
									}

									[Token(Token = "0x6006359")]
									[Address(RVA = "0xB80340", Offset = "0xB7F740", VA = "0x180B80340")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public MonsterFighter(MonsterFighter other)
									{
									}

									[Token(Token = "0x600635A")]
									[Address(RVA = "0xB7FE40", Offset = "0xB7F240", VA = "0x180B7FE40", Slot = "10")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public MonsterFighter Clone()
									{
										return null;
									}

									[Token(Token = "0x6006363")]
									[Address(RVA = "0xB7FEF0", Offset = "0xB7F2F0", VA = "0x180B7FEF0", Slot = "0")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006364")]
									[Address(RVA = "0xB7FFB0", Offset = "0xB7F3B0", VA = "0x180B7FFB0", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(MonsterFighter other)
									{
										return default(bool);
									}

									[Token(Token = "0x6006365")]
									[Address(RVA = "0xB80030", Offset = "0xB7F430", VA = "0x180B80030", Slot = "2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x6006366")]
									[Address(RVA = "0xB801E0", Offset = "0xB7F5E0", VA = "0x180B801E0", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x6006367")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x6006368")]
									[Address(RVA = "0xB805F0", Offset = "0xB7F9F0", VA = "0x180B805F0", Slot = "12")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006369")]
									[Address(RVA = "0xB7FD30", Offset = "0xB7F130", VA = "0x180B7FD30", Slot = "7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x600636A")]
									[Address(RVA = "0xB800F0", Offset = "0xB7F4F0", VA = "0x180B800F0", Slot = "4")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(MonsterFighter other)
									{
									}

									[Token(Token = "0x600636B")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x600636C")]
									[Address(RVA = "0xB80490", Offset = "0xB7F890", VA = "0x180B80490", Slot = "11")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}

								[Token(Token = "0x200098A")]
								[DebuggerDisplay("{ToString(),nq}")]
								public sealed class TaxCollectorFighter : IMessage<TaxCollectorFighter>, IMessage, IEquatable<TaxCollectorFighter>, IDeepCloneable<TaxCollectorFighter>, IBufferMessage
								{
									[Token(Token = "0x4002174")]
									[FieldOffset(Offset = "0x0")]
									private static readonly MessageParser<TaxCollectorFighter> _parser;

									[Token(Token = "0x4002175")]
									[FieldOffset(Offset = "0x10")]
									private UnknownFieldSet _unknownFields;

									[Token(Token = "0x4002176")]
									public const int FirstNameIdFieldNumber = 1;

									[Token(Token = "0x4002177")]
									[FieldOffset(Offset = "0x18")]
									private int firstNameId_;

									[Token(Token = "0x4002178")]
									public const int LastNameIdFieldNumber = 2;

									[Token(Token = "0x4002179")]
									[FieldOffset(Offset = "0x1C")]
									private int lastNameId_;

									[Token(Token = "0x1700152A")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageParser<TaxCollectorFighter> Parser
									{
										[Token(Token = "0x6006371")]
										[Address(RVA = "0xB9F7D0", Offset = "0xB9EBD0", VA = "0x180B9F7D0")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700152B")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public static MessageDescriptor Descriptor
									{
										[Token(Token = "0x6006372")]
										[Address(RVA = "0xB9F750", Offset = "0xB9EB50", VA = "0x180B9F750")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700152C")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
									{
										[Token(Token = "0x6006373")]
										[Address(RVA = "0xB9F820", Offset = "0xB9EC20", VA = "0x180B9F820", Slot = "8")]
										get
										{
											return null;
										}
									}

									[Token(Token = "0x1700152D")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int FirstNameId
									{
										[Token(Token = "0x6006377")]
										[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x6006378")]
										[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
										set
										{
										}
									}

									[Token(Token = "0x1700152E")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public int LastNameId
									{
										[Token(Token = "0x6006379")]
										[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
										get
										{
											return default(int);
										}
										[Token(Token = "0x600637A")]
										[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
										set
										{
										}
									}

									[Token(Token = "0x6006374")]
									[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public TaxCollectorFighter()
									{
									}

									[Token(Token = "0x6006375")]
									[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public TaxCollectorFighter(TaxCollectorFighter other)
									{
									}

									[Token(Token = "0x6006376")]
									[Address(RVA = "0xB9F4D0", Offset = "0xB9E8D0", VA = "0x180B9F4D0", Slot = "10")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public TaxCollectorFighter Clone()
									{
										return null;
									}

									[Token(Token = "0x600637B")]
									[Address(RVA = "0xB9F560", Offset = "0xB9E960", VA = "0x180B9F560", Slot = "0")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override bool Equals(object other)
									{
										return default(bool);
									}

									[Token(Token = "0x600637C")]
									[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public bool Equals(TaxCollectorFighter other)
									{
										return default(bool);
									}

									[Token(Token = "0x600637D")]
									[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override int GetHashCode()
									{
										return default(int);
									}

									[Token(Token = "0x600637E")]
									[Address(RVA = "0xB9F5F0", Offset = "0xB9E9F0", VA = "0x180B9F5F0", Slot = "3")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									public override string ToString()
									{
										return null;
									}

									[Token(Token = "0x600637F")]
									[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void WriteTo(CodedOutputStream output)
									{
									}

									[Token(Token = "0x6006380")]
									[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
									{
									}

									[Token(Token = "0x6006381")]
									[Address(RVA = "0xB9F410", Offset = "0xB9E810", VA = "0x180B9F410", Slot = "7")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public int CalculateSize()
									{
										return default(int);
									}

									[Token(Token = "0x6006382")]
									[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(TaxCollectorFighter other)
									{
									}

									[Token(Token = "0x6006383")]
									[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
									[GeneratedCode("protoc", null)]
									[DebuggerNonUserCode]
									public void MergeFrom(CodedInputStream input)
									{
									}

									[Token(Token = "0x6006384")]
									[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
									[DebuggerNonUserCode]
									[GeneratedCode("protoc", null)]
									private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
									{
									}
								}
							}

							[Token(Token = "0x400215F")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<AIFighterInformation> _parser;

							[Token(Token = "0x4002160")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x4002161")]
							public const int MonsterFighterInformationFieldNumber = 1;

							[Token(Token = "0x4002162")]
							public const int TaxCollectorInformationFieldNumber = 2;

							[Token(Token = "0x4002163")]
							[FieldOffset(Offset = "0x18")]
							private object aiFighterInformation_;

							[Token(Token = "0x4002164")]
							[FieldOffset(Offset = "0x20")]
							private AiFighterInformationOneofCase aiFighterInformationCase_;

							[Token(Token = "0x1700151D")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<AIFighterInformation> Parser
							{
								[Token(Token = "0x600633E")]
								[Address(RVA = "0xB777F0", Offset = "0xB76BF0", VA = "0x180B777F0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x1700151E")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x600633F")]
								[Address(RVA = "0xB77710", Offset = "0xB76B10", VA = "0x180B77710")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x1700151F")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x6006340")]
								[Address(RVA = "0xB77B50", Offset = "0xB76F50", VA = "0x180B77B50", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001520")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Types.MonsterFighter MonsterFighterInformation
							{
								[Token(Token = "0x6006344")]
								[Address(RVA = "0xB77790", Offset = "0xB76B90", VA = "0x180B77790")]
								get
								{
									return null;
								}
								[Token(Token = "0x6006345")]
								[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
								set
								{
								}
							}

							[Token(Token = "0x17001521")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public Types.TaxCollectorFighter TaxCollectorInformation
							{
								[Token(Token = "0x6006346")]
								[Address(RVA = "0xB77840", Offset = "0xB76C40", VA = "0x180B77840")]
								get
								{
									return null;
								}
								[Token(Token = "0x6006347")]
								[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
								set
								{
								}
							}

							[Token(Token = "0x17001522")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public AiFighterInformationOneofCase AiFighterInformationCase
							{
								[Token(Token = "0x6006348")]
								[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
								get
								{
									return default(AiFighterInformationOneofCase);
								}
							}

							[Token(Token = "0x6006341")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public AIFighterInformation()
							{
							}

							[Token(Token = "0x6006342")]
							[Address(RVA = "0xB77530", Offset = "0xB76930", VA = "0x180B77530")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public AIFighterInformation(AIFighterInformation other)
							{
							}

							[Token(Token = "0x6006343")]
							[Address(RVA = "0xB76D50", Offset = "0xB76150", VA = "0x180B76D50", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public AIFighterInformation Clone()
							{
								return null;
							}

							[Token(Token = "0x6006349")]
							[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void ClearAiFighterInformation()
							{
							}

							[Token(Token = "0x600634A")]
							[Address(RVA = "0xB76DB0", Offset = "0xB761B0", VA = "0x180B76DB0", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x600634B")]
							[Address(RVA = "0xB76F20", Offset = "0xB76320", VA = "0x180B76F20", Slot = "9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public bool Equals(AIFighterInformation other)
							{
								return default(bool);
							}

							[Token(Token = "0x600634C")]
							[Address(RVA = "0xB77050", Offset = "0xB76450", VA = "0x180B77050", Slot = "2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x600634D")]
							[Address(RVA = "0xB773D0", Offset = "0xB767D0", VA = "0x180B773D0", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x600634E")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x600634F")]
							[Address(RVA = "0xB77A40", Offset = "0xB76E40", VA = "0x180B77A40", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x6006350")]
							[Address(RVA = "0xB76C20", Offset = "0xB76020", VA = "0x180B76C20", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x6006351")]
							[Address(RVA = "0xB77180", Offset = "0xB76580", VA = "0x180B77180", Slot = "4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(AIFighterInformation other)
							{
							}

							[Token(Token = "0x6006352")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x6006353")]
							[Address(RVA = "0xB778A0", Offset = "0xB76CA0", VA = "0x180B778A0", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}

						[Token(Token = "0x200098D")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class EntityFighterInformation : IMessage<EntityFighterInformation>, IMessage, IEquatable<EntityFighterInformation>, IDeepCloneable<EntityFighterInformation>, IBufferMessage
						{
							[Token(Token = "0x400217C")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<EntityFighterInformation> _parser;

							[Token(Token = "0x400217D")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x400217E")]
							public const int EntityModelIdFieldNumber = 1;

							[Token(Token = "0x400217F")]
							[FieldOffset(Offset = "0x18")]
							private int entityModelId_;

							[Token(Token = "0x4002180")]
							public const int LevelFieldNumber = 2;

							[Token(Token = "0x4002181")]
							[FieldOffset(Offset = "0x1C")]
							private int level_;

							[Token(Token = "0x4002182")]
							public const int MasterIdFieldNumber = 3;

							[Token(Token = "0x4002183")]
							[FieldOffset(Offset = "0x20")]
							private long masterId_;

							[Token(Token = "0x1700152F")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageParser<EntityFighterInformation> Parser
							{
								[Token(Token = "0x600638C")]
								[Address(RVA = "0xB99400", Offset = "0xB98800", VA = "0x180B99400")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001530")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x600638D")]
								[Address(RVA = "0xB99380", Offset = "0xB98780", VA = "0x180B99380")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001531")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x600638E")]
								[Address(RVA = "0xB99450", Offset = "0xB98850", VA = "0x180B99450", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17001532")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int EntityModelId
							{
								[Token(Token = "0x6006392")]
								[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6006393")]
								[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
								set
								{
								}
							}

							[Token(Token = "0x17001533")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int Level
							{
								[Token(Token = "0x6006394")]
								[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6006395")]
								[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
								set
								{
								}
							}

							[Token(Token = "0x17001534")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public long MasterId
							{
								[Token(Token = "0x6006396")]
								[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
								get
								{
									return default(long);
								}
								[Token(Token = "0x6006397")]
								[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
								set
								{
								}
							}

							[Token(Token = "0x600638F")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public EntityFighterInformation()
							{
							}

							[Token(Token = "0x6006390")]
							[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public EntityFighterInformation(EntityFighterInformation other)
							{
							}

							[Token(Token = "0x6006391")]
							[Address(RVA = "0xB990F0", Offset = "0xB984F0", VA = "0x180B990F0", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public EntityFighterInformation Clone()
							{
								return null;
							}

							[Token(Token = "0x6006398")]
							[Address(RVA = "0xB99180", Offset = "0xB98580", VA = "0x180B99180", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x6006399")]
							[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public bool Equals(EntityFighterInformation other)
							{
								return default(bool);
							}

							[Token(Token = "0x600639A")]
							[Address(RVA = "0x9625B0", Offset = "0x9619B0", VA = "0x1809625B0", Slot = "2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x600639B")]
							[Address(RVA = "0xB99220", Offset = "0xB98620", VA = "0x180B99220", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x600639C")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x600639D")]
							[Address(RVA = "0xA26730", Offset = "0xA25B30", VA = "0x180A26730", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x600639E")]
							[Address(RVA = "0xB99010", Offset = "0xB98410", VA = "0x180B99010", Slot = "7")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x600639F")]
							[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(EntityFighterInformation other)
							{
							}

							[Token(Token = "0x60063A0")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x60063A1")]
							[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}
					}

					[Token(Token = "0x4002125")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<FightFighterInformation> _parser;

					[Token(Token = "0x4002126")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4002127")]
					public const int SpawnInformationFieldNumber = 1;

					[Token(Token = "0x4002128")]
					[FieldOffset(Offset = "0x18")]
					private SpawnInformation spawnInformation_;

					[Token(Token = "0x4002129")]
					public const int WaveFieldNumber = 2;

					[Token(Token = "0x400212A")]
					[FieldOffset(Offset = "0x20")]
					private int wave_;

					[Token(Token = "0x400212B")]
					public const int StatsFieldNumber = 3;

					[Token(Token = "0x400212C")]
					[FieldOffset(Offset = "0x28")]
					private FightCharacteristics stats_;

					[Token(Token = "0x400212D")]
					public const int PreviousPositionsFieldNumber = 4;

					[Token(Token = "0x400212E")]
					[FieldOffset(Offset = "0x8")]
					private static readonly FieldCodec<int> _repeated_previousPositions_codec;

					[Token(Token = "0x400212F")]
					[FieldOffset(Offset = "0x30")]
					private readonly RepeatedField<int> previousPositions_;

					[Token(Token = "0x4002130")]
					public const int NamedFighterFieldNumber = 5;

					[Token(Token = "0x4002131")]
					public const int AiFighterFieldNumber = 6;

					[Token(Token = "0x4002132")]
					public const int EntityFighterFieldNumber = 7;

					[Token(Token = "0x4002133")]
					[FieldOffset(Offset = "0x38")]
					private object fighterInformation_;

					[Token(Token = "0x4002134")]
					[FieldOffset(Offset = "0x40")]
					private FighterInformationOneofCase fighterInformationCase_;

					[Token(Token = "0x170014FC")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<FightFighterInformation> Parser
					{
						[Token(Token = "0x60062C8")]
						[Address(RVA = "0xB7A7C0", Offset = "0xB79BC0", VA = "0x180B7A7C0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170014FD")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x60062C9")]
						[Address(RVA = "0xB7A680", Offset = "0xB79A80", VA = "0x180B7A680")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170014FE")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x60062CA")]
						[Address(RVA = "0xB7AE00", Offset = "0xB7A200", VA = "0x180B7AE00", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170014FF")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SpawnInformation SpawnInformation
					{
						[Token(Token = "0x60062CE")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return null;
						}
						[Token(Token = "0x60062CF")]
						[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
						set
						{
						}
					}

					[Token(Token = "0x17001500")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int Wave
					{
						[Token(Token = "0x60062D0")]
						[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x60062D1")]
						[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
						set
						{
						}
					}

					[Token(Token = "0x17001501")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public FightCharacteristics Stats
					{
						[Token(Token = "0x60062D2")]
						[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
						get
						{
							return null;
						}
						[Token(Token = "0x60062D3")]
						[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
						set
						{
						}
					}

					[Token(Token = "0x17001502")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public RepeatedField<int> PreviousPositions
					{
						[Token(Token = "0x60062D4")]
						[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17001503")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.NamedFighterInformation NamedFighter
					{
						[Token(Token = "0x60062D5")]
						[Address(RVA = "0xB7A760", Offset = "0xB79B60", VA = "0x180B7A760")]
						get
						{
							return null;
						}
						[Token(Token = "0x60062D6")]
						[Address(RVA = "0xB7AE80", Offset = "0xB7A280", VA = "0x180B7AE80")]
						set
						{
						}
					}

					[Token(Token = "0x17001504")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.AIFighterInformation AiFighter
					{
						[Token(Token = "0x60062D7")]
						[Address(RVA = "0xB7A620", Offset = "0xB79A20", VA = "0x180B7A620")]
						get
						{
							return null;
						}
						[Token(Token = "0x60062D8")]
						[Address(RVA = "0x95FFD0", Offset = "0x95F3D0", VA = "0x18095FFD0")]
						set
						{
						}
					}

					[Token(Token = "0x17001505")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.EntityFighterInformation EntityFighter
					{
						[Token(Token = "0x60062D9")]
						[Address(RVA = "0xB7A700", Offset = "0xB79B00", VA = "0x180B7A700")]
						get
						{
							return null;
						}
						[Token(Token = "0x60062DA")]
						[Address(RVA = "0xB7AE40", Offset = "0xB7A240", VA = "0x180B7AE40")]
						set
						{
						}
					}

					[Token(Token = "0x17001506")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public FighterInformationOneofCase FighterInformationCase
					{
						[Token(Token = "0x60062DB")]
						[Address(RVA = "0x95FB30", Offset = "0x95EF30", VA = "0x18095FB30")]
						get
						{
							return default(FighterInformationOneofCase);
						}
					}

					[Token(Token = "0x60062CB")]
					[Address(RVA = "0xB7A5A0", Offset = "0xB799A0", VA = "0x180B7A5A0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FightFighterInformation()
					{
					}

					[Token(Token = "0x60062CC")]
					[Address(RVA = "0xB7A260", Offset = "0xB79660", VA = "0x180B7A260")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public FightFighterInformation(FightFighterInformation other)
					{
					}

					[Token(Token = "0x60062CD")]
					[Address(RVA = "0xB79830", Offset = "0xB78C30", VA = "0x180B79830", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public FightFighterInformation Clone()
					{
						return null;
					}

					[Token(Token = "0x60062DC")]
					[Address(RVA = "0x95F130", Offset = "0x95E530", VA = "0x18095F130")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void ClearFighterInformation()
					{
					}

					[Token(Token = "0x60062DD")]
					[Address(RVA = "0xB79890", Offset = "0xB78C90", VA = "0x180B79890", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x60062DE")]
					[Address(RVA = "0xB79A40", Offset = "0xB78E40", VA = "0x180B79A40", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(FightFighterInformation other)
					{
						return default(bool);
					}

					[Token(Token = "0x60062DF")]
					[Address(RVA = "0xB79BC0", Offset = "0xB78FC0", VA = "0x180B79BC0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60062E0")]
					[Address(RVA = "0xB7A0D0", Offset = "0xB794D0", VA = "0x180B7A0D0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60062E1")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60062E2")]
					[Address(RVA = "0xB7ABA0", Offset = "0xB79FA0", VA = "0x180B7ABA0", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60062E3")]
					[Address(RVA = "0xB79590", Offset = "0xB78990", VA = "0x180B79590", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x60062E4")]
					[Address(RVA = "0xB79DE0", Offset = "0xB791E0", VA = "0x180B79DE0", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(FightFighterInformation other)
					{
					}

					[Token(Token = "0x60062E5")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x60062E6")]
					[Address(RVA = "0xB7A810", Offset = "0xB79C10", VA = "0x180B7A810", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4002049")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ActorInformation> _parser;

			[Token(Token = "0x400204A")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400204B")]
			public const int LookFieldNumber = 1;

			[Token(Token = "0x400204C")]
			[FieldOffset(Offset = "0x18")]
			private EntityLook look_;

			[Token(Token = "0x400204D")]
			public const int RolePlayActorFieldNumber = 2;

			[Token(Token = "0x400204E")]
			public const int FighterFieldNumber = 3;

			[Token(Token = "0x400204F")]
			[FieldOffset(Offset = "0x20")]
			private object information_;

			[Token(Token = "0x4002050")]
			[FieldOffset(Offset = "0x28")]
			private InformationOneofCase informationCase_;

			[Token(Token = "0x17001473")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ActorInformation> Parser
			{
				[Token(Token = "0x60060A5")]
				[Address(RVA = "0xB4A1E0", Offset = "0xB495E0", VA = "0x180B4A1E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001474")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60060A6")]
				[Address(RVA = "0xB4A100", Offset = "0xB49500", VA = "0x180B4A100")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001475")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60060A7")]
				[Address(RVA = "0xB4A5C0", Offset = "0xB499C0", VA = "0x180B4A5C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001476")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public EntityLook Look
			{
				[Token(Token = "0x60060AB")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x60060AC")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17001477")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.RolePlayActor RolePlayActor
			{
				[Token(Token = "0x60060AD")]
				[Address(RVA = "0xB4A230", Offset = "0xB49630", VA = "0x180B4A230")]
				get
				{
					return null;
				}
				[Token(Token = "0x60060AE")]
				[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
				set
				{
				}
			}

			[Token(Token = "0x17001478")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.FightFighterInformation Fighter
			{
				[Token(Token = "0x60060AF")]
				[Address(RVA = "0xB4A180", Offset = "0xB49580", VA = "0x180B4A180")]
				get
				{
					return null;
				}
				[Token(Token = "0x60060B0")]
				[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
				set
				{
				}
			}

			[Token(Token = "0x17001479")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public InformationOneofCase InformationCase
			{
				[Token(Token = "0x60060B1")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(InformationOneofCase);
				}
			}

			[Token(Token = "0x60060A8")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ActorInformation()
			{
			}

			[Token(Token = "0x60060A9")]
			[Address(RVA = "0xB49F90", Offset = "0xB49390", VA = "0x180B49F90")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ActorInformation(ActorInformation other)
			{
			}

			[Token(Token = "0x60060AA")]
			[Address(RVA = "0xB497D0", Offset = "0xB48BD0", VA = "0x180B497D0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ActorInformation Clone()
			{
				return null;
			}

			[Token(Token = "0x60060B2")]
			[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearInformation()
			{
			}

			[Token(Token = "0x60060B3")]
			[Address(RVA = "0xB49830", Offset = "0xB48C30", VA = "0x180B49830", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60060B4")]
			[Address(RVA = "0xB49950", Offset = "0xB48D50", VA = "0x180B49950", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ActorInformation other)
			{
				return default(bool);
			}

			[Token(Token = "0x60060B5")]
			[Address(RVA = "0xB49A30", Offset = "0xB48E30", VA = "0x180B49A30", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60060B6")]
			[Address(RVA = "0xB49E30", Offset = "0xB49230", VA = "0x180B49E30", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60060B7")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60060B8")]
			[Address(RVA = "0xB4A490", Offset = "0xB49890", VA = "0x180B4A490", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60060B9")]
			[Address(RVA = "0xB49660", Offset = "0xB48A60", VA = "0x180B49660", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60060BA")]
			[Address(RVA = "0xB49B80", Offset = "0xB48F80", VA = "0x180B49B80", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ActorInformation other)
			{
			}

			[Token(Token = "0x60060BB")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60060BC")]
			[Address(RVA = "0xB4A290", Offset = "0xB49690", VA = "0x180B4A290", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002041")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ActorPositionInformation> _parser;

	[Token(Token = "0x4002042")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002043")]
	public const int ActorIdFieldNumber = 1;

	[Token(Token = "0x4002044")]
	[FieldOffset(Offset = "0x18")]
	private long actorId_;

	[Token(Token = "0x4002045")]
	public const int DispositionFieldNumber = 2;

	[Token(Token = "0x4002046")]
	[FieldOffset(Offset = "0x20")]
	private EntityDisposition disposition_;

	[Token(Token = "0x4002047")]
	public const int ActorInformationFieldNumber = 3;

	[Token(Token = "0x4002048")]
	[FieldOffset(Offset = "0x28")]
	private Types.ActorInformation actorInformation_;

	[Token(Token = "0x1700146D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActorPositionInformation> Parser
	{
		[Token(Token = "0x600608E")]
		[Address(RVA = "0xB4AE90", Offset = "0xB4A290", VA = "0x180B4AE90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700146E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600608F")]
		[Address(RVA = "0xB4ADE0", Offset = "0xB4A1E0", VA = "0x180B4ADE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700146F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006090")]
		[Address(RVA = "0xB4B0F0", Offset = "0xB4A4F0", VA = "0x180B4B0F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001470")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ActorId
	{
		[Token(Token = "0x6006094")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006095")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001471")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityDisposition Disposition
	{
		[Token(Token = "0x6006096")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006097")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17001472")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ActorInformation ActorInformation
	{
		[Token(Token = "0x6006098")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006099")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6006091")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActorPositionInformation()
	{
	}

	[Token(Token = "0x6006092")]
	[Address(RVA = "0xB4AD00", Offset = "0xB4A100", VA = "0x180B4AD00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActorPositionInformation(ActorPositionInformation other)
	{
	}

	[Token(Token = "0x6006093")]
	[Address(RVA = "0xB4A760", Offset = "0xB49B60", VA = "0x180B4A760", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActorPositionInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600609A")]
	[Address(RVA = "0xB4A8F0", Offset = "0xB49CF0", VA = "0x180B4A8F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600609B")]
	[Address(RVA = "0xB4A870", Offset = "0xB49C70", VA = "0x180B4A870", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActorPositionInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600609C")]
	[Address(RVA = "0xB4A9C0", Offset = "0xB49DC0", VA = "0x180B4A9C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600609D")]
	[Address(RVA = "0xB4ABA0", Offset = "0xB49FA0", VA = "0x180B4ABA0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600609E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600609F")]
	[Address(RVA = "0xB4B050", Offset = "0xB4A450", VA = "0x180B4B050", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60060A0")]
	[Address(RVA = "0xB4A670", Offset = "0xB49A70", VA = "0x180B4A670", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60060A1")]
	[Address(RVA = "0xB4AA70", Offset = "0xB49E70", VA = "0x180B4AA70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ActorPositionInformation other)
	{
	}

	[Token(Token = "0x60060A2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60060A3")]
	[Address(RVA = "0xB4AEE0", Offset = "0xB4A2E0", VA = "0x180B4AEE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
