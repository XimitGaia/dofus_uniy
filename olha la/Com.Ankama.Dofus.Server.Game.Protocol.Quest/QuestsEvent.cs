using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x2000195")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestsEvent : IMessage<QuestsEvent>, IMessage, IEquatable<QuestsEvent>, IDeepCloneable<QuestsEvent>, IBufferMessage
{
	[Token(Token = "0x2000196")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000197")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class QuestFinished : IMessage<QuestFinished>, IMessage, IEquatable<QuestFinished>, IDeepCloneable<QuestFinished>, IBufferMessage
		{
			[Token(Token = "0x4000568")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<QuestFinished> _parser;

			[Token(Token = "0x4000569")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400056A")]
			public const int QuestIdFieldNumber = 1;

			[Token(Token = "0x400056B")]
			[FieldOffset(Offset = "0x18")]
			private int questId_;

			[Token(Token = "0x400056C")]
			public const int FinishedCountFieldNumber = 2;

			[Token(Token = "0x400056D")]
			[FieldOffset(Offset = "0x1C")]
			private int finishedCount_;

			[Token(Token = "0x17000370")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<QuestFinished> Parser
			{
				[Token(Token = "0x6001016")]
				[Address(RVA = "0xC49490", Offset = "0xC48890", VA = "0x180C49490")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000371")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001017")]
				[Address(RVA = "0xC49410", Offset = "0xC48810", VA = "0x180C49410")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000372")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6001018")]
				[Address(RVA = "0xC494E0", Offset = "0xC488E0", VA = "0x180C494E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000373")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int QuestId
			{
				[Token(Token = "0x600101C")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600101D")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000374")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int FinishedCount
			{
				[Token(Token = "0x600101E")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600101F")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x6001019")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public QuestFinished()
			{
			}

			[Token(Token = "0x600101A")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public QuestFinished(QuestFinished other)
			{
			}

			[Token(Token = "0x600101B")]
			[Address(RVA = "0xC49190", Offset = "0xC48590", VA = "0x180C49190", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public QuestFinished Clone()
			{
				return null;
			}

			[Token(Token = "0x6001020")]
			[Address(RVA = "0xC49220", Offset = "0xC48620", VA = "0x180C49220", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001021")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(QuestFinished other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001022")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001023")]
			[Address(RVA = "0xC492B0", Offset = "0xC486B0", VA = "0x180C492B0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001024")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001025")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001026")]
			[Address(RVA = "0xC490D0", Offset = "0xC484D0", VA = "0x180C490D0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001027")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(QuestFinished other)
			{
			}

			[Token(Token = "0x6001028")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6001029")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestsEvent> _parser;

	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x400055C")]
	public const int FinishedQuestsFieldNumber = 1;

	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.QuestFinished> _repeated_finishedQuests_codec;

	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.QuestFinished> finishedQuests_;

	[Token(Token = "0x400055F")]
	public const int ActiveQuestsFieldNumber = 2;

	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<QuestActive> _repeated_activeQuests_codec;

	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<QuestActive> activeQuests_;

	[Token(Token = "0x4000562")]
	public const int ReinitializedDoneQuestsIdFieldNumber = 3;

	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<int> _repeated_reinitializedDoneQuestsId_codec;

	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<int> reinitializedDoneQuestsId_;

	[Token(Token = "0x4000565")]
	public const int PlayerIdFieldNumber = 4;

	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x20")]
	private static readonly long PlayerIdDefaultValue;

	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x38")]
	private long playerId_;

	[Token(Token = "0x17000368")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestsEvent> Parser
	{
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0xC4F410", Offset = "0xC4E810", VA = "0x180C4F410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000369")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0xC4F360", Offset = "0xC4E760", VA = "0x180C4F360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700036A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001000")]
		[Address(RVA = "0xC4F870", Offset = "0xC4EC70", VA = "0x180C4F870", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700036B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.QuestFinished> FinishedQuests
	{
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700036C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<QuestActive> ActiveQuests
	{
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700036D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ReinitializedDoneQuestsId
	{
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700036E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x6001007")]
		[Address(RVA = "0xC4F460", Offset = "0xC4E860", VA = "0x180C4F460")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001008")]
		[Address(RVA = "0xAEFA30", Offset = "0xAEEE30", VA = "0x180AEFA30")]
		set
		{
		}
	}

	[Token(Token = "0x1700036F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPlayerId
	{
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001001")]
	[Address(RVA = "0xC4F160", Offset = "0xC4E560", VA = "0x180C4F160")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestsEvent()
	{
	}

	[Token(Token = "0x6001002")]
	[Address(RVA = "0xC4F260", Offset = "0xC4E660", VA = "0x180C4F260")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestsEvent(QuestsEvent other)
	{
	}

	[Token(Token = "0x6001003")]
	[Address(RVA = "0xC4E890", Offset = "0xC4DC90", VA = "0x180C4E890", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600100A")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPlayerId()
	{
	}

	[Token(Token = "0x600100B")]
	[Address(RVA = "0xC4EAE0", Offset = "0xC4DEE0", VA = "0x180C4EAE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600100C")]
	[Address(RVA = "0xC4E9C0", Offset = "0xC4DDC0", VA = "0x180C4E9C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600100D")]
	[Address(RVA = "0xC4EC40", Offset = "0xC4E040", VA = "0x180C4EC40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600100E")]
	[Address(RVA = "0xC4EE60", Offset = "0xC4E260", VA = "0x180C4EE60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600100F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001010")]
	[Address(RVA = "0xC4F6D0", Offset = "0xC4EAD0", VA = "0x180C4F6D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001011")]
	[Address(RVA = "0xC4E6E0", Offset = "0xC4DAE0", VA = "0x180C4E6E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001012")]
	[Address(RVA = "0xC4ED70", Offset = "0xC4E170", VA = "0x180C4ED70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestsEvent other)
	{
	}

	[Token(Token = "0x6001013")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001014")]
	[Address(RVA = "0xC4F4D0", Offset = "0xC4E8D0", VA = "0x180C4F4D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
