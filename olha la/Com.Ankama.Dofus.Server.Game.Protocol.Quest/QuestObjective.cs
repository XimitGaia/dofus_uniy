using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x20001AD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestObjective : IMessage<QuestObjective>, IMessage, IEquatable<QuestObjective>, IDeepCloneable<QuestObjective>, IBufferMessage
{
	[Token(Token = "0x20001AE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20001AF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Completion : IMessage<Completion>, IMessage, IEquatable<Completion>, IDeepCloneable<Completion>, IBufferMessage
		{
			[Token(Token = "0x40005B8")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Completion> _parser;

			[Token(Token = "0x40005B9")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40005BA")]
			public const int CurrentCompletionFieldNumber = 1;

			[Token(Token = "0x40005BB")]
			[FieldOffset(Offset = "0x18")]
			private int currentCompletion_;

			[Token(Token = "0x40005BC")]
			public const int MaxCompletionFieldNumber = 2;

			[Token(Token = "0x40005BD")]
			[FieldOffset(Offset = "0x1C")]
			private int maxCompletion_;

			[Token(Token = "0x170003A7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Completion> Parser
			{
				[Token(Token = "0x600111B")]
				[Address(RVA = "0xCC0DA0", Offset = "0xCC01A0", VA = "0x180CC0DA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003A8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600111C")]
				[Address(RVA = "0xCC0D20", Offset = "0xCC0120", VA = "0x180CC0D20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003A9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600111D")]
				[Address(RVA = "0xCC0DF0", Offset = "0xCC01F0", VA = "0x180CC0DF0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003AA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CurrentCompletion
			{
				[Token(Token = "0x6001121")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001122")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x170003AB")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int MaxCompletion
			{
				[Token(Token = "0x6001123")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6001124")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x600111E")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Completion()
			{
			}

			[Token(Token = "0x600111F")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Completion(Completion other)
			{
			}

			[Token(Token = "0x6001120")]
			[Address(RVA = "0xCC0AA0", Offset = "0xCBFEA0", VA = "0x180CC0AA0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Completion Clone()
			{
				return null;
			}

			[Token(Token = "0x6001125")]
			[Address(RVA = "0xCC0B30", Offset = "0xCBFF30", VA = "0x180CC0B30", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001126")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Completion other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001127")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001128")]
			[Address(RVA = "0xCC0BC0", Offset = "0xCBFFC0", VA = "0x180CC0BC0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001129")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600112A")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600112B")]
			[Address(RVA = "0xCC09E0", Offset = "0xCBFDE0", VA = "0x180CC09E0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600112C")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Completion other)
			{
			}

			[Token(Token = "0x600112D")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600112E")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestObjective> _parser;

	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40005AF")]
	public const int ObjectiveIdFieldNumber = 1;

	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x18")]
	private int objectiveId_;

	[Token(Token = "0x40005B1")]
	public const int ObjectiveReachedFieldNumber = 2;

	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x1C")]
	private bool objectiveReached_;

	[Token(Token = "0x40005B3")]
	public const int DialogParamsFieldNumber = 3;

	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_dialogParams_codec;

	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<string> dialogParams_;

	[Token(Token = "0x40005B6")]
	public const int CompletionFieldNumber = 4;

	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x28")]
	private Types.Completion completion_;

	[Token(Token = "0x170003A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestObjective> Parser
	{
		[Token(Token = "0x6001103")]
		[Address(RVA = "0xCD3850", Offset = "0xCD2C50", VA = "0x180CD3850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001104")]
		[Address(RVA = "0xCD37A0", Offset = "0xCD2BA0", VA = "0x180CD37A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001105")]
		[Address(RVA = "0xCD3B70", Offset = "0xCD2F70", VA = "0x180CD3B70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectiveId
	{
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170003A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ObjectiveReached
	{
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x170003A5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> DialogParams
	{
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Completion Completion
	{
		[Token(Token = "0x600110E")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600110F")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6001106")]
	[Address(RVA = "0xCD35F0", Offset = "0xCD29F0", VA = "0x180CD35F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestObjective()
	{
	}

	[Token(Token = "0x6001107")]
	[Address(RVA = "0xCD3670", Offset = "0xCD2A70", VA = "0x180CD3670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestObjective(QuestObjective other)
	{
	}

	[Token(Token = "0x6001108")]
	[Address(RVA = "0xCD2F00", Offset = "0xCD2300", VA = "0x180CD2F00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestObjective Clone()
	{
		return null;
	}

	[Token(Token = "0x6001110")]
	[Address(RVA = "0xCD3060", Offset = "0xCD2460", VA = "0x180CD3060", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001111")]
	[Address(RVA = "0xCD3160", Offset = "0xCD2560", VA = "0x180CD3160", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestObjective other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001112")]
	[Address(RVA = "0xCD3220", Offset = "0xCD2620", VA = "0x180CD3220", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001113")]
	[Address(RVA = "0xCD3460", Offset = "0xCD2860", VA = "0x180CD3460", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001114")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001115")]
	[Address(RVA = "0xCD3A50", Offset = "0xCD2E50", VA = "0x180CD3A50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001116")]
	[Address(RVA = "0xCD2DE0", Offset = "0xCD21E0", VA = "0x180CD2DE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001117")]
	[Address(RVA = "0xCD3320", Offset = "0xCD2720", VA = "0x180CD3320", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestObjective other)
	{
	}

	[Token(Token = "0x6001118")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001119")]
	[Address(RVA = "0xCD38A0", Offset = "0xCD2CA0", VA = "0x180CD38A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
