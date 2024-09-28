using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x20005C0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionUpdateEffectTriggerCountEvent : IMessage<GameActionUpdateEffectTriggerCountEvent>, IMessage, IEquatable<GameActionUpdateEffectTriggerCountEvent>, IDeepCloneable<GameActionUpdateEffectTriggerCountEvent>, IBufferMessage
{
	[Token(Token = "0x20005C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20005C2")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class FightEffectTriggerCount : IMessage<FightEffectTriggerCount>, IMessage, IEquatable<FightEffectTriggerCount>, IDeepCloneable<FightEffectTriggerCount>, IBufferMessage
		{
			[Token(Token = "0x4001414")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<FightEffectTriggerCount> _parser;

			[Token(Token = "0x4001415")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001416")]
			public const int EffectIdFieldNumber = 1;

			[Token(Token = "0x4001417")]
			[FieldOffset(Offset = "0x18")]
			private int effectId_;

			[Token(Token = "0x4001418")]
			public const int TargetIdFieldNumber = 2;

			[Token(Token = "0x4001419")]
			[FieldOffset(Offset = "0x20")]
			private long targetId_;

			[Token(Token = "0x400141A")]
			public const int CountFieldNumber = 3;

			[Token(Token = "0x400141B")]
			[FieldOffset(Offset = "0x28")]
			private int count_;

			[Token(Token = "0x17000D2A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<FightEffectTriggerCount> Parser
			{
				[Token(Token = "0x6003D78")]
				[Address(RVA = "0xA2AF90", Offset = "0xA2A390", VA = "0x180A2AF90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D2B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003D79")]
				[Address(RVA = "0xA2AF10", Offset = "0xA2A310", VA = "0x180A2AF10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D2C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003D7A")]
				[Address(RVA = "0xA2AFE0", Offset = "0xA2A3E0", VA = "0x180A2AFE0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D2D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int EffectId
			{
				[Token(Token = "0x6003D7E")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003D7F")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000D2E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003D80")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003D81")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x17000D2F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Count
			{
				[Token(Token = "0x6003D82")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003D83")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x6003D7B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FightEffectTriggerCount()
			{
			}

			[Token(Token = "0x6003D7C")]
			[Address(RVA = "0x963AD0", Offset = "0x962ED0", VA = "0x180963AD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FightEffectTriggerCount(FightEffectTriggerCount other)
			{
			}

			[Token(Token = "0x6003D7D")]
			[Address(RVA = "0xA2AC80", Offset = "0xA2A080", VA = "0x180A2AC80", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FightEffectTriggerCount Clone()
			{
				return null;
			}

			[Token(Token = "0x6003D84")]
			[Address(RVA = "0xA2AD10", Offset = "0xA2A110", VA = "0x180A2AD10", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D85")]
			[Address(RVA = "0x963810", Offset = "0x962C10", VA = "0x180963810", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(FightEffectTriggerCount other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D86")]
			[Address(RVA = "0x963850", Offset = "0x962C50", VA = "0x180963850", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003D87")]
			[Address(RVA = "0xA2ADB0", Offset = "0xA2A1B0", VA = "0x180A2ADB0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003D88")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003D89")]
			[Address(RVA = "0x963D00", Offset = "0x963100", VA = "0x180963D00", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003D8A")]
			[Address(RVA = "0xA2ABA0", Offset = "0xA29FA0", VA = "0x180A2ABA0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003D8B")]
			[Address(RVA = "0x963900", Offset = "0x962D00", VA = "0x180963900", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(FightEffectTriggerCount other)
			{
			}

			[Token(Token = "0x6003D8C")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003D8D")]
			[Address(RVA = "0x963C30", Offset = "0x963030", VA = "0x180963C30", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionUpdateEffectTriggerCountEvent> _parser;

	[Token(Token = "0x4001410")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001411")]
	public const int EffectsCountOnTargetFieldNumber = 1;

	[Token(Token = "0x4001412")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.FightEffectTriggerCount> _repeated_effectsCountOnTarget_codec;

	[Token(Token = "0x4001413")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.FightEffectTriggerCount> effectsCountOnTarget_;

	[Token(Token = "0x17000D26")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameActionUpdateEffectTriggerCountEvent> Parser
	{
		[Token(Token = "0x6003D66")]
		[Address(RVA = "0xA2B7A0", Offset = "0xA2ABA0", VA = "0x180A2B7A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D27")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003D67")]
		[Address(RVA = "0xA2B6F0", Offset = "0xA2AAF0", VA = "0x180A2B6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D28")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003D68")]
		[Address(RVA = "0xA2B9B0", Offset = "0xA2ADB0", VA = "0x180A2B9B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D29")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.FightEffectTriggerCount> EffectsCountOnTarget
	{
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D69")]
	[Address(RVA = "0xA2B5E0", Offset = "0xA2A9E0", VA = "0x180A2B5E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GameActionUpdateEffectTriggerCountEvent()
	{
	}

	[Token(Token = "0x6003D6A")]
	[Address(RVA = "0xA2B660", Offset = "0xA2AA60", VA = "0x180A2B660")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionUpdateEffectTriggerCountEvent(GameActionUpdateEffectTriggerCountEvent other)
	{
	}

	[Token(Token = "0x6003D6B")]
	[Address(RVA = "0xA2B130", Offset = "0xA2A530", VA = "0x180A2B130", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionUpdateEffectTriggerCountEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003D6D")]
	[Address(RVA = "0xA2B280", Offset = "0xA2A680", VA = "0x180A2B280", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003D6E")]
	[Address(RVA = "0xA2B1F0", Offset = "0xA2A5F0", VA = "0x180A2B1F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionUpdateEffectTriggerCountEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003D6F")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003D70")]
	[Address(RVA = "0xA2B3E0", Offset = "0xA2A7E0", VA = "0x180A2B3E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003D71")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003D72")]
	[Address(RVA = "0xA2B900", Offset = "0xA2AD00", VA = "0x180A2B900", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003D73")]
	[Address(RVA = "0xA2B090", Offset = "0xA2A490", VA = "0x180A2B090", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003D74")]
	[Address(RVA = "0xA2B360", Offset = "0xA2A760", VA = "0x180A2B360", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionUpdateEffectTriggerCountEvent other)
	{
	}

	[Token(Token = "0x6003D75")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003D76")]
	[Address(RVA = "0xA2B7F0", Offset = "0xA2ABF0", VA = "0x180A2B7F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
