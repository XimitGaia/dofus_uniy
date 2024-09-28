using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002CF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcsMapQuestStatusUpdateEvent : IMessage<NpcsMapQuestStatusUpdateEvent>, IMessage, IEquatable<NpcsMapQuestStatusUpdateEvent>, IDeepCloneable<NpcsMapQuestStatusUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x20002D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20002D1")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class MapNpcQuest : IMessage<MapNpcQuest>, IMessage, IEquatable<MapNpcQuest>, IDeepCloneable<MapNpcQuest>, IBufferMessage
		{
			[Token(Token = "0x20002D2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x20002D3")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class NpcWithQuest : IMessage<NpcWithQuest>, IMessage, IEquatable<NpcWithQuest>, IDeepCloneable<NpcWithQuest>, IBufferMessage
				{
					[Token(Token = "0x40009ED")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<NpcWithQuest> _parser;

					[Token(Token = "0x40009EE")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40009EF")]
					public const int NpcIdFieldNumber = 1;

					[Token(Token = "0x40009F0")]
					[FieldOffset(Offset = "0x18")]
					private int npcId_;

					[Token(Token = "0x40009F1")]
					public const int QuestsToValidateFieldNumber = 2;

					[Token(Token = "0x40009F2")]
					[FieldOffset(Offset = "0x8")]
					private static readonly FieldCodec<int> _repeated_questsToValidate_codec;

					[Token(Token = "0x40009F3")]
					[FieldOffset(Offset = "0x20")]
					private readonly RepeatedField<int> questsToValidate_;

					[Token(Token = "0x40009F4")]
					public const int QuestsToStartFieldNumber = 3;

					[Token(Token = "0x40009F5")]
					[FieldOffset(Offset = "0x10")]
					private static readonly FieldCodec<int> _repeated_questsToStart_codec;

					[Token(Token = "0x40009F6")]
					[FieldOffset(Offset = "0x28")]
					private readonly RepeatedField<int> questsToStart_;

					[Token(Token = "0x17000658")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<NpcWithQuest> Parser
					{
						[Token(Token = "0x6001D64")]
						[Address(RVA = "0xD2B480", Offset = "0xD2A880", VA = "0x180D2B480")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000659")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6001D65")]
						[Address(RVA = "0xD2B400", Offset = "0xD2A800", VA = "0x180D2B400")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700065A")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6001D66")]
						[Address(RVA = "0xD2B760", Offset = "0xD2AB60", VA = "0x180D2B760", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700065B")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int NpcId
					{
						[Token(Token = "0x6001D6A")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6001D6B")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x1700065C")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public RepeatedField<int> QuestsToValidate
					{
						[Token(Token = "0x6001D6C")]
						[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700065D")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public RepeatedField<int> QuestsToStart
					{
						[Token(Token = "0x6001D6D")]
						[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6001D67")]
					[Address(RVA = "0xD2B290", Offset = "0xD2A690", VA = "0x180D2B290")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public NpcWithQuest()
					{
					}

					[Token(Token = "0x6001D68")]
					[Address(RVA = "0xD2B340", Offset = "0xD2A740", VA = "0x180D2B340")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public NpcWithQuest(NpcWithQuest other)
					{
					}

					[Token(Token = "0x6001D69")]
					[Address(RVA = "0xD2AD90", Offset = "0xD2A190", VA = "0x180D2AD90", Slot = "10")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public NpcWithQuest Clone()
					{
						return null;
					}

					[Token(Token = "0x6001D6E")]
					[Address(RVA = "0xD2AF30", Offset = "0xD2A330", VA = "0x180D2AF30", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6001D6F")]
					[Address(RVA = "0xD2AE70", Offset = "0xD2A270", VA = "0x180D2AE70", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(NpcWithQuest other)
					{
						return default(bool);
					}

					[Token(Token = "0x6001D70")]
					[Address(RVA = "0x9A8E80", Offset = "0x9A8280", VA = "0x1809A8E80", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6001D71")]
					[Address(RVA = "0xD2B0D0", Offset = "0xD2A4D0", VA = "0x180D2B0D0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6001D72")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6001D73")]
					[Address(RVA = "0xD2B660", Offset = "0xD2AA60", VA = "0x180D2B660", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6001D74")]
					[Address(RVA = "0xD2AC80", Offset = "0xD2A080", VA = "0x180D2AC80", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6001D75")]
					[Address(RVA = "0xD2B030", Offset = "0xD2A430", VA = "0x180D2B030", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(NpcWithQuest other)
					{
					}

					[Token(Token = "0x6001D76")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6001D77")]
					[Address(RVA = "0xD2B4D0", Offset = "0xD2A8D0", VA = "0x180D2B4D0", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x40009E6")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<MapNpcQuest> _parser;

			[Token(Token = "0x40009E7")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40009E8")]
			public const int MapIdFieldNumber = 1;

			[Token(Token = "0x40009E9")]
			[FieldOffset(Offset = "0x18")]
			private long mapId_;

			[Token(Token = "0x40009EA")]
			public const int NpcsWithQuestsFieldNumber = 2;

			[Token(Token = "0x40009EB")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<Types.NpcWithQuest> _repeated_npcsWithQuests_codec;

			[Token(Token = "0x40009EC")]
			[FieldOffset(Offset = "0x20")]
			private readonly RepeatedField<Types.NpcWithQuest> npcsWithQuests_;

			[Token(Token = "0x17000653")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<MapNpcQuest> Parser
			{
				[Token(Token = "0x6001D50")]
				[Address(RVA = "0xD1B220", Offset = "0xD1A620", VA = "0x180D1B220")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000654")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001D51")]
				[Address(RVA = "0xD1B1A0", Offset = "0xD1A5A0", VA = "0x180D1B1A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000655")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6001D52")]
				[Address(RVA = "0xD1B470", Offset = "0xD1A870", VA = "0x180D1B470", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000656")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long MapId
			{
				[Token(Token = "0x6001D56")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6001D57")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000657")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<Types.NpcWithQuest> NpcsWithQuests
			{
				[Token(Token = "0x6001D58")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001D53")]
			[Address(RVA = "0xD1B120", Offset = "0xD1A520", VA = "0x180D1B120")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MapNpcQuest()
			{
			}

			[Token(Token = "0x6001D54")]
			[Address(RVA = "0xD1B080", Offset = "0xD1A480", VA = "0x180D1B080")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MapNpcQuest(MapNpcQuest other)
			{
			}

			[Token(Token = "0x6001D55")]
			[Address(RVA = "0xD1ABB0", Offset = "0xD19FB0", VA = "0x180D1ABB0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MapNpcQuest Clone()
			{
				return null;
			}

			[Token(Token = "0x6001D59")]
			[Address(RVA = "0xD1AC70", Offset = "0xD1A070", VA = "0x180D1AC70", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001D5A")]
			[Address(RVA = "0xD1AD50", Offset = "0xD1A150", VA = "0x180D1AD50", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(MapNpcQuest other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001D5B")]
			[Address(RVA = "0x97D020", Offset = "0x97C420", VA = "0x18097D020", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001D5C")]
			[Address(RVA = "0xD1AE80", Offset = "0xD1A280", VA = "0x180D1AE80", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001D5D")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001D5E")]
			[Address(RVA = "0xD1B3A0", Offset = "0xD1A7A0", VA = "0x180D1B3A0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001D5F")]
			[Address(RVA = "0xD1AAD0", Offset = "0xD19ED0", VA = "0x180D1AAD0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001D60")]
			[Address(RVA = "0xD1ADF0", Offset = "0xD1A1F0", VA = "0x180D1ADF0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(MapNpcQuest other)
			{
			}

			[Token(Token = "0x6001D61")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6001D62")]
			[Address(RVA = "0xD1B270", Offset = "0xD1A670", VA = "0x180D1B270", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NpcsMapQuestStatusUpdateEvent> _parser;

	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40009E3")]
	public const int MapInformationFieldNumber = 1;

	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.MapNpcQuest> _repeated_mapInformation_codec;

	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.MapNpcQuest> mapInformation_;

	[Token(Token = "0x1700064F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<NpcsMapQuestStatusUpdateEvent> Parser
	{
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0xD2BF20", Offset = "0xD2B320", VA = "0x180D2BF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000650")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0xD2BE70", Offset = "0xD2B270", VA = "0x180D2BE70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000651")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0xD2C130", Offset = "0xD2B530", VA = "0x180D2C130", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000652")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.MapNpcQuest> MapInformation
	{
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001D41")]
	[Address(RVA = "0xD2BDF0", Offset = "0xD2B1F0", VA = "0x180D2BDF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcsMapQuestStatusUpdateEvent()
	{
	}

	[Token(Token = "0x6001D42")]
	[Address(RVA = "0xD2BD60", Offset = "0xD2B160", VA = "0x180D2BD60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NpcsMapQuestStatusUpdateEvent(NpcsMapQuestStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6001D43")]
	[Address(RVA = "0xD2B8B0", Offset = "0xD2ACB0", VA = "0x180D2B8B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcsMapQuestStatusUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001D45")]
	[Address(RVA = "0xD2BA00", Offset = "0xD2AE00", VA = "0x180D2BA00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D46")]
	[Address(RVA = "0xD2B970", Offset = "0xD2AD70", VA = "0x180D2B970", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcsMapQuestStatusUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D47")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D48")]
	[Address(RVA = "0xD2BB60", Offset = "0xD2AF60", VA = "0x180D2BB60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001D49")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0xD2C080", Offset = "0xD2B480", VA = "0x180D2C080", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0xD2B810", Offset = "0xD2AC10", VA = "0x180D2B810", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0xD2BAE0", Offset = "0xD2AEE0", VA = "0x180D2BAE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NpcsMapQuestStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6001D4D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001D4E")]
	[Address(RVA = "0xD2BF70", Offset = "0xD2B370", VA = "0x180D2BF70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
