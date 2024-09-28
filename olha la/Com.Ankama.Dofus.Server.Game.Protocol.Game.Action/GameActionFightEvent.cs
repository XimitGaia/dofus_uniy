using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x2000569")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionFightEvent : IMessage<GameActionFightEvent>, IMessage, IEquatable<GameActionFightEvent>, IDeepCloneable<GameActionFightEvent>, IBufferMessage
{
	[Token(Token = "0x200056A")]
	public enum ActionOneofCase
	{
		[Token(Token = "0x40012BB")]
		None = 0,
		[Token(Token = "0x40012BC")]
		Slide = 3,
		[Token(Token = "0x40012BD")]
		DodgePointLoss = 4,
		[Token(Token = "0x40012BE")]
		ReflectDamages = 5,
		[Token(Token = "0x40012BF")]
		ReduceDamages = 6,
		[Token(Token = "0x40012C0")]
		ReflectSpell = 7,
		[Token(Token = "0x40012C1")]
		RemovableEffect = 8,
		[Token(Token = "0x40012C2")]
		LifePointsLost = 9,
		[Token(Token = "0x40012C3")]
		LifePointsGain = 10,
		[Token(Token = "0x40012C4")]
		SpellImmunity = 11,
		[Token(Token = "0x40012C5")]
		SpellCoolDownVariation = 12,
		[Token(Token = "0x40012C6")]
		Vanish = 13,
		[Token(Token = "0x40012C7")]
		Kill = 14,
		[Token(Token = "0x40012C8")]
		Death = 15,
		[Token(Token = "0x40012C9")]
		TargetedAbility = 16,
		[Token(Token = "0x40012CA")]
		Tackled = 17,
		[Token(Token = "0x40012CB")]
		PointsVariation = 18,
		[Token(Token = "0x40012CC")]
		InvisibleDetected = 19,
		[Token(Token = "0x40012CD")]
		TeleportOnSameMap = 20,
		[Token(Token = "0x40012CE")]
		ExchangePositions = 21,
		[Token(Token = "0x40012CF")]
		SpellRemove = 22,
		[Token(Token = "0x40012D0")]
		ModifyEffectsDuration = 23,
		[Token(Token = "0x40012D1")]
		StealKama = 24,
		[Token(Token = "0x40012D2")]
		ChangeLook = 25,
		[Token(Token = "0x40012D3")]
		Invisibility = 26,
		[Token(Token = "0x40012D4")]
		Summons = 27,
		[Token(Token = "0x40012D5")]
		MarkCells = 28,
		[Token(Token = "0x40012D6")]
		UnmarkCells = 29,
		[Token(Token = "0x40012D7")]
		TriggerGlyphTrap = 30,
		[Token(Token = "0x40012D8")]
		ActivateGlyphTrap = 31,
		[Token(Token = "0x40012D9")]
		CarryCharacter = 32,
		[Token(Token = "0x40012DA")]
		ThrowCharacter = 33,
		[Token(Token = "0x40012DB")]
		DropCharacter = 34,
		[Token(Token = "0x40012DC")]
		ExecuteScript = 35
	}

	[Token(Token = "0x200056B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200056C")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class CarryCharacter : IMessage<CarryCharacter>, IMessage, IEquatable<CarryCharacter>, IDeepCloneable<CarryCharacter>, IBufferMessage
		{
			[Token(Token = "0x40012DD")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<CarryCharacter> _parser;

			[Token(Token = "0x40012DE")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40012DF")]
			public const int TargetIdFieldNumber = 3;

			[Token(Token = "0x40012E0")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x40012E1")]
			public const int CellFieldNumber = 4;

			[Token(Token = "0x40012E2")]
			[FieldOffset(Offset = "0x20")]
			private int cell_;

			[Token(Token = "0x17000C58")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<CarryCharacter> Parser
			{
				[Token(Token = "0x60039B8")]
				[Address(RVA = "0xA11510", Offset = "0xA10910", VA = "0x180A11510")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C59")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60039B9")]
				[Address(RVA = "0xA11490", Offset = "0xA10890", VA = "0x180A11490")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C5A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60039BA")]
				[Address(RVA = "0xA11690", Offset = "0xA10A90", VA = "0x180A11690", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C5B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x60039BE")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60039BF")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000C5C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Cell
			{
				[Token(Token = "0x60039C0")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60039C1")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x60039BB")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CarryCharacter()
			{
			}

			[Token(Token = "0x60039BC")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CarryCharacter(CarryCharacter other)
			{
			}

			[Token(Token = "0x60039BD")]
			[Address(RVA = "0xA11200", Offset = "0xA10600", VA = "0x180A11200", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public CarryCharacter Clone()
			{
				return null;
			}

			[Token(Token = "0x60039C2")]
			[Address(RVA = "0xA11290", Offset = "0xA10690", VA = "0x180A11290", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60039C3")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(CarryCharacter other)
			{
				return default(bool);
			}

			[Token(Token = "0x60039C4")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60039C5")]
			[Address(RVA = "0xA11330", Offset = "0xA10730", VA = "0x180A11330", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60039C6")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60039C7")]
			[Address(RVA = "0xA11610", Offset = "0xA10A10", VA = "0x180A11610", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60039C8")]
			[Address(RVA = "0xA11140", Offset = "0xA10540", VA = "0x180A11140", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60039C9")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CarryCharacter other)
			{
			}

			[Token(Token = "0x60039CA")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60039CB")]
			[Address(RVA = "0xA11560", Offset = "0xA10960", VA = "0x180A11560", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200056E")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ThrowCharacter : IMessage<ThrowCharacter>, IMessage, IEquatable<ThrowCharacter>, IDeepCloneable<ThrowCharacter>, IBufferMessage
		{
			[Token(Token = "0x40012E4")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ThrowCharacter> _parser;

			[Token(Token = "0x40012E5")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40012E6")]
			public const int TargetIdFieldNumber = 3;

			[Token(Token = "0x40012E7")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x40012E8")]
			public const int CellFieldNumber = 4;

			[Token(Token = "0x40012E9")]
			[FieldOffset(Offset = "0x20")]
			private int cell_;

			[Token(Token = "0x17000C5D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ThrowCharacter> Parser
			{
				[Token(Token = "0x60039D0")]
				[Address(RVA = "0xA261F0", Offset = "0xA255F0", VA = "0x180A261F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C5E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60039D1")]
				[Address(RVA = "0xA26170", Offset = "0xA25570", VA = "0x180A26170")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C5F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60039D2")]
				[Address(RVA = "0xA26240", Offset = "0xA25640", VA = "0x180A26240", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C60")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x60039D6")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60039D7")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000C61")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Cell
			{
				[Token(Token = "0x60039D8")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60039D9")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x60039D3")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ThrowCharacter()
			{
			}

			[Token(Token = "0x60039D4")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ThrowCharacter(ThrowCharacter other)
			{
			}

			[Token(Token = "0x60039D5")]
			[Address(RVA = "0xA25EE0", Offset = "0xA252E0", VA = "0x180A25EE0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ThrowCharacter Clone()
			{
				return null;
			}

			[Token(Token = "0x60039DA")]
			[Address(RVA = "0xA25F70", Offset = "0xA25370", VA = "0x180A25F70", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60039DB")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ThrowCharacter other)
			{
				return default(bool);
			}

			[Token(Token = "0x60039DC")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60039DD")]
			[Address(RVA = "0xA26010", Offset = "0xA25410", VA = "0x180A26010", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60039DE")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60039DF")]
			[Address(RVA = "0xA11610", Offset = "0xA10A10", VA = "0x180A11610", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60039E0")]
			[Address(RVA = "0xA25E20", Offset = "0xA25220", VA = "0x180A25E20", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60039E1")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ThrowCharacter other)
			{
			}

			[Token(Token = "0x60039E2")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60039E3")]
			[Address(RVA = "0xA11560", Offset = "0xA10960", VA = "0x180A11560", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000570")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class DropCharacter : IMessage<DropCharacter>, IMessage, IEquatable<DropCharacter>, IDeepCloneable<DropCharacter>, IBufferMessage
		{
			[Token(Token = "0x40012EB")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<DropCharacter> _parser;

			[Token(Token = "0x40012EC")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40012ED")]
			public const int TargetIdFieldNumber = 3;

			[Token(Token = "0x40012EE")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x40012EF")]
			public const int CellFieldNumber = 4;

			[Token(Token = "0x40012F0")]
			[FieldOffset(Offset = "0x20")]
			private int cell_;

			[Token(Token = "0x17000C62")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<DropCharacter> Parser
			{
				[Token(Token = "0x60039E8")]
				[Address(RVA = "0xA11B10", Offset = "0xA10F10", VA = "0x180A11B10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C63")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60039E9")]
				[Address(RVA = "0xA11A90", Offset = "0xA10E90", VA = "0x180A11A90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C64")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60039EA")]
				[Address(RVA = "0xA11B60", Offset = "0xA10F60", VA = "0x180A11B60", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C65")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x60039EE")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60039EF")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000C66")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Cell
			{
				[Token(Token = "0x60039F0")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60039F1")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x60039EB")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public DropCharacter()
			{
			}

			[Token(Token = "0x60039EC")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DropCharacter(DropCharacter other)
			{
			}

			[Token(Token = "0x60039ED")]
			[Address(RVA = "0xA11800", Offset = "0xA10C00", VA = "0x180A11800", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DropCharacter Clone()
			{
				return null;
			}

			[Token(Token = "0x60039F2")]
			[Address(RVA = "0xA11890", Offset = "0xA10C90", VA = "0x180A11890", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60039F3")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(DropCharacter other)
			{
				return default(bool);
			}

			[Token(Token = "0x60039F4")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60039F5")]
			[Address(RVA = "0xA11930", Offset = "0xA10D30", VA = "0x180A11930", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60039F6")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60039F7")]
			[Address(RVA = "0xA11610", Offset = "0xA10A10", VA = "0x180A11610", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60039F8")]
			[Address(RVA = "0xA11740", Offset = "0xA10B40", VA = "0x180A11740", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60039F9")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(DropCharacter other)
			{
			}

			[Token(Token = "0x60039FA")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60039FB")]
			[Address(RVA = "0xA11560", Offset = "0xA10960", VA = "0x180A11560", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000572")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ExecuteScript : IMessage<ExecuteScript>, IMessage, IEquatable<ExecuteScript>, IDeepCloneable<ExecuteScript>, IBufferMessage
		{
			[Token(Token = "0x40012F2")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ExecuteScript> _parser;

			[Token(Token = "0x40012F3")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40012F4")]
			public const int ScriptUsageIdFieldNumber = 1;

			[Token(Token = "0x40012F5")]
			[FieldOffset(Offset = "0x18")]
			private int scriptUsageId_;

			[Token(Token = "0x40012F6")]
			public const int CriticalFieldNumber = 2;

			[Token(Token = "0x40012F7")]
			[FieldOffset(Offset = "0x1C")]
			private bool critical_;

			[Token(Token = "0x40012F8")]
			public const int SpellIdFieldNumber = 3;

			[Token(Token = "0x40012F9")]
			[FieldOffset(Offset = "0x20")]
			private int spellId_;

			[Token(Token = "0x40012FA")]
			public const int SpellRankFieldNumber = 4;

			[Token(Token = "0x40012FB")]
			[FieldOffset(Offset = "0x24")]
			private int spellRank_;

			[Token(Token = "0x40012FC")]
			public const int CellFieldNumber = 5;

			[Token(Token = "0x40012FD")]
			[FieldOffset(Offset = "0x28")]
			private int cell_;

			[Token(Token = "0x17000C67")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ExecuteScript> Parser
			{
				[Token(Token = "0x6003A00")]
				[Address(RVA = "0xA122A0", Offset = "0xA116A0", VA = "0x180A122A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C68")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003A01")]
				[Address(RVA = "0xA12220", Offset = "0xA11620", VA = "0x180A12220")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C69")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003A02")]
				[Address(RVA = "0xA124F0", Offset = "0xA118F0", VA = "0x180A124F0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C6A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int ScriptUsageId
			{
				[Token(Token = "0x6003A06")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003A07")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000C6B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Critical
			{
				[Token(Token = "0x6003A08")]
				[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003A09")]
				[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
				set
				{
				}
			}

			[Token(Token = "0x17000C6C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SpellId
			{
				[Token(Token = "0x6003A0A")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003A0B")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17000C6D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SpellRank
			{
				[Token(Token = "0x6003A0C")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003A0D")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x17000C6E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Cell
			{
				[Token(Token = "0x6003A0E")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003A0F")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x6003A03")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExecuteScript()
			{
			}

			[Token(Token = "0x6003A04")]
			[Address(RVA = "0xA121B0", Offset = "0xA115B0", VA = "0x180A121B0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExecuteScript(ExecuteScript other)
			{
			}

			[Token(Token = "0x6003A05")]
			[Address(RVA = "0xA11D20", Offset = "0xA11120", VA = "0x180A11D20", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExecuteScript Clone()
			{
				return null;
			}

			[Token(Token = "0x6003A10")]
			[Address(RVA = "0xA11E10", Offset = "0xA11210", VA = "0x180A11E10", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A11")]
			[Address(RVA = "0xA11DC0", Offset = "0xA111C0", VA = "0x180A11DC0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ExecuteScript other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A12")]
			[Address(RVA = "0xA11EC0", Offset = "0xA112C0", VA = "0x180A11EC0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003A13")]
			[Address(RVA = "0xA12050", Offset = "0xA11450", VA = "0x180A12050", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003A14")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003A15")]
			[Address(RVA = "0xA12410", Offset = "0xA11810", VA = "0x180A12410", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003A16")]
			[Address(RVA = "0xA11C10", Offset = "0xA11010", VA = "0x180A11C10", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003A17")]
			[Address(RVA = "0xA11FD0", Offset = "0xA113D0", VA = "0x180A11FD0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ExecuteScript other)
			{
			}

			[Token(Token = "0x6003A18")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003A19")]
			[Address(RVA = "0xA122F0", Offset = "0xA116F0", VA = "0x180A122F0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000574")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class UnmarkCells : IMessage<UnmarkCells>, IMessage, IEquatable<UnmarkCells>, IDeepCloneable<UnmarkCells>, IBufferMessage
		{
			[Token(Token = "0x40012FF")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<UnmarkCells> _parser;

			[Token(Token = "0x4001300")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001301")]
			public const int MarkIdFieldNumber = 1;

			[Token(Token = "0x4001302")]
			[FieldOffset(Offset = "0x18")]
			private int markId_;

			[Token(Token = "0x17000C6F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<UnmarkCells> Parser
			{
				[Token(Token = "0x6003A1E")]
				[Address(RVA = "0xA27800", Offset = "0xA26C00", VA = "0x180A27800")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C70")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003A1F")]
				[Address(RVA = "0xA27780", Offset = "0xA26B80", VA = "0x180A27780")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C71")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003A20")]
				[Address(RVA = "0xA27850", Offset = "0xA26C50", VA = "0x180A27850", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C72")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MarkId
			{
				[Token(Token = "0x6003A24")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003A25")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x6003A21")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public UnmarkCells()
			{
			}

			[Token(Token = "0x6003A22")]
			[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public UnmarkCells(UnmarkCells other)
			{
			}

			[Token(Token = "0x6003A23")]
			[Address(RVA = "0xA27510", Offset = "0xA26910", VA = "0x180A27510", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public UnmarkCells Clone()
			{
				return null;
			}

			[Token(Token = "0x6003A26")]
			[Address(RVA = "0xA27590", Offset = "0xA26990", VA = "0x180A27590", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A27")]
			[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(UnmarkCells other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A28")]
			[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003A29")]
			[Address(RVA = "0xA27620", Offset = "0xA26A20", VA = "0x180A27620", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003A2A")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003A2B")]
			[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003A2C")]
			[Address(RVA = "0xA27480", Offset = "0xA26880", VA = "0x180A27480", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003A2D")]
			[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(UnmarkCells other)
			{
			}

			[Token(Token = "0x6003A2E")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003A2F")]
			[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000576")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class TriggerGlyphTrap : IMessage<TriggerGlyphTrap>, IMessage, IEquatable<TriggerGlyphTrap>, IDeepCloneable<TriggerGlyphTrap>, IBufferMessage
		{
			[Token(Token = "0x4001304")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<TriggerGlyphTrap> _parser;

			[Token(Token = "0x4001305")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001306")]
			public const int MarkIdFieldNumber = 1;

			[Token(Token = "0x4001307")]
			[FieldOffset(Offset = "0x18")]
			private int markId_;

			[Token(Token = "0x4001308")]
			public const int MarkImpactCellFieldNumber = 2;

			[Token(Token = "0x4001309")]
			[FieldOffset(Offset = "0x1C")]
			private int markImpactCell_;

			[Token(Token = "0x400130A")]
			public const int TriggeringCharacterIdFieldNumber = 3;

			[Token(Token = "0x400130B")]
			[FieldOffset(Offset = "0x20")]
			private long triggeringCharacterId_;

			[Token(Token = "0x17000C73")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<TriggerGlyphTrap> Parser
			{
				[Token(Token = "0x6003A34")]
				[Address(RVA = "0xA266E0", Offset = "0xA25AE0", VA = "0x180A266E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C74")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003A35")]
				[Address(RVA = "0xA26660", Offset = "0xA25A60", VA = "0x180A26660")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C75")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003A36")]
				[Address(RVA = "0xA267D0", Offset = "0xA25BD0", VA = "0x180A267D0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C76")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MarkId
			{
				[Token(Token = "0x6003A3A")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003A3B")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000C77")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MarkImpactCell
			{
				[Token(Token = "0x6003A3C")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003A3D")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17000C78")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TriggeringCharacterId
			{
				[Token(Token = "0x6003A3E")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003A3F")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x6003A37")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TriggerGlyphTrap()
			{
			}

			[Token(Token = "0x6003A38")]
			[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TriggerGlyphTrap(TriggerGlyphTrap other)
			{
			}

			[Token(Token = "0x6003A39")]
			[Address(RVA = "0xA263D0", Offset = "0xA257D0", VA = "0x180A263D0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TriggerGlyphTrap Clone()
			{
				return null;
			}

			[Token(Token = "0x6003A40")]
			[Address(RVA = "0xA26460", Offset = "0xA25860", VA = "0x180A26460", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A41")]
			[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(TriggerGlyphTrap other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A42")]
			[Address(RVA = "0x9625B0", Offset = "0x9619B0", VA = "0x1809625B0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003A43")]
			[Address(RVA = "0xA26500", Offset = "0xA25900", VA = "0x180A26500", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003A44")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003A45")]
			[Address(RVA = "0xA26730", Offset = "0xA25B30", VA = "0x180A26730", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003A46")]
			[Address(RVA = "0xA262F0", Offset = "0xA256F0", VA = "0x180A262F0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003A47")]
			[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(TriggerGlyphTrap other)
			{
			}

			[Token(Token = "0x6003A48")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003A49")]
			[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000578")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ActivateGlyphTrap : IMessage<ActivateGlyphTrap>, IMessage, IEquatable<ActivateGlyphTrap>, IDeepCloneable<ActivateGlyphTrap>, IBufferMessage
		{
			[Token(Token = "0x400130D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ActivateGlyphTrap> _parser;

			[Token(Token = "0x400130E")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400130F")]
			public const int MarkIdFieldNumber = 1;

			[Token(Token = "0x4001310")]
			[FieldOffset(Offset = "0x18")]
			private int markId_;

			[Token(Token = "0x4001311")]
			public const int ActiveFieldNumber = 2;

			[Token(Token = "0x4001312")]
			[FieldOffset(Offset = "0x1C")]
			private bool active_;

			[Token(Token = "0x17000C79")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ActivateGlyphTrap> Parser
			{
				[Token(Token = "0x6003A4E")]
				[Address(RVA = "0xA27DA0", Offset = "0xA271A0", VA = "0x180A27DA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C7A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003A4F")]
				[Address(RVA = "0xA27D20", Offset = "0xA27120", VA = "0x180A27D20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C7B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003A50")]
				[Address(RVA = "0xA27DF0", Offset = "0xA271F0", VA = "0x180A27DF0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C7C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int MarkId
			{
				[Token(Token = "0x6003A54")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003A55")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000C7D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Active
			{
				[Token(Token = "0x6003A56")]
				[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003A57")]
				[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
				set
				{
				}
			}

			[Token(Token = "0x6003A51")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ActivateGlyphTrap()
			{
			}

			[Token(Token = "0x6003A52")]
			[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ActivateGlyphTrap(ActivateGlyphTrap other)
			{
			}

			[Token(Token = "0x6003A53")]
			[Address(RVA = "0xA279E0", Offset = "0xA26DE0", VA = "0x180A279E0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ActivateGlyphTrap Clone()
			{
				return null;
			}

			[Token(Token = "0x6003A58")]
			[Address(RVA = "0xA27A70", Offset = "0xA26E70", VA = "0x180A27A70", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A59")]
			[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ActivateGlyphTrap other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A5A")]
			[Address(RVA = "0xA27B00", Offset = "0xA26F00", VA = "0x180A27B00", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003A5B")]
			[Address(RVA = "0xA27BC0", Offset = "0xA26FC0", VA = "0x180A27BC0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003A5C")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003A5D")]
			[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003A5E")]
			[Address(RVA = "0xA27950", Offset = "0xA26D50", VA = "0x180A27950", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003A5F")]
			[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ActivateGlyphTrap other)
			{
			}

			[Token(Token = "0x6003A60")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003A61")]
			[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200057A")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Invisibility : IMessage<Invisibility>, IMessage, IEquatable<Invisibility>, IDeepCloneable<Invisibility>, IBufferMessage
		{
			[Token(Token = "0x4001314")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Invisibility> _parser;

			[Token(Token = "0x4001315")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001316")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x4001317")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4001318")]
			public const int InvisibilityStateFieldNumber = 2;

			[Token(Token = "0x4001319")]
			[FieldOffset(Offset = "0x20")]
			private FightInvisibilityState invisibilityState_;

			[Token(Token = "0x17000C7E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Invisibility> Parser
			{
				[Token(Token = "0x6003A66")]
				[Address(RVA = "0xA2BDC0", Offset = "0xA2B1C0", VA = "0x180A2BDC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C7F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003A67")]
				[Address(RVA = "0xA2BD40", Offset = "0xA2B140", VA = "0x180A2BD40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C80")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003A68")]
				[Address(RVA = "0xA2BE10", Offset = "0xA2B210", VA = "0x180A2BE10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C81")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003A6C")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003A6D")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000C82")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightInvisibilityState InvisibilityState
			{
				[Token(Token = "0x6003A6E")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(FightInvisibilityState);
				}
				[Token(Token = "0x6003A6F")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003A69")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Invisibility()
			{
			}

			[Token(Token = "0x6003A6A")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Invisibility(Invisibility other)
			{
			}

			[Token(Token = "0x6003A6B")]
			[Address(RVA = "0xA2BAB0", Offset = "0xA2AEB0", VA = "0x180A2BAB0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Invisibility Clone()
			{
				return null;
			}

			[Token(Token = "0x6003A70")]
			[Address(RVA = "0xA2BB40", Offset = "0xA2AF40", VA = "0x180A2BB40", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A71")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Invisibility other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A72")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003A73")]
			[Address(RVA = "0xA2BBE0", Offset = "0xA2AFE0", VA = "0x180A2BBE0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003A74")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003A75")]
			[Address(RVA = "0x948ED0", Offset = "0x9482D0", VA = "0x180948ED0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003A76")]
			[Address(RVA = "0xA2B9F0", Offset = "0xA2ADF0", VA = "0x180A2B9F0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Invisibility other)
			{
			}

			[Token(Token = "0x6003A78")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003A79")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200057C")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Summons : IMessage<Summons>, IMessage, IEquatable<Summons>, IDeepCloneable<Summons>, IBufferMessage
		{
			[Token(Token = "0x200057D")]
			public enum SummonsOneofCase
			{
				[Token(Token = "0x4001322")]
				None,
				[Token(Token = "0x4001323")]
				SummonsByActor,
				[Token(Token = "0x4001324")]
				SummonsByContextInformation
			}

			[Token(Token = "0x200057E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x200057F")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SummonsByActor : IMessage<SummonsByActor>, IMessage, IEquatable<SummonsByActor>, IDeepCloneable<SummonsByActor>, IBufferMessage
				{
					[Token(Token = "0x4001325")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SummonsByActor> _parser;

					[Token(Token = "0x4001326")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4001327")]
					public const int SummonsFieldNumber = 1;

					[Token(Token = "0x4001328")]
					[FieldOffset(Offset = "0x8")]
					private static readonly FieldCodec<ActorPositionInformation> _repeated_summons_codec;

					[Token(Token = "0x4001329")]
					[FieldOffset(Offset = "0x18")]
					private readonly RepeatedField<ActorPositionInformation> summons_;

					[Token(Token = "0x17000C89")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<SummonsByActor> Parser
					{
						[Token(Token = "0x6003A95")]
						[Address(RVA = "0xA35220", Offset = "0xA34620", VA = "0x180A35220")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000C8A")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6003A96")]
						[Address(RVA = "0xA351A0", Offset = "0xA345A0", VA = "0x180A351A0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000C8B")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6003A97")]
						[Address(RVA = "0xA35430", Offset = "0xA34830", VA = "0x180A35430", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000C8C")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public RepeatedField<ActorPositionInformation> Summons
					{
						[Token(Token = "0x6003A9B")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6003A98")]
					[Address(RVA = "0xA35120", Offset = "0xA34520", VA = "0x180A35120")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SummonsByActor()
					{
					}

					[Token(Token = "0x6003A99")]
					[Address(RVA = "0xA35090", Offset = "0xA34490", VA = "0x180A35090")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SummonsByActor(SummonsByActor other)
					{
					}

					[Token(Token = "0x6003A9A")]
					[Address(RVA = "0xA34BE0", Offset = "0xA33FE0", VA = "0x180A34BE0", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SummonsByActor Clone()
					{
						return null;
					}

					[Token(Token = "0x6003A9C")]
					[Address(RVA = "0xA34D30", Offset = "0xA34130", VA = "0x180A34D30", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6003A9D")]
					[Address(RVA = "0xA34CA0", Offset = "0xA340A0", VA = "0x180A34CA0", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SummonsByActor other)
					{
						return default(bool);
					}

					[Token(Token = "0x6003A9E")]
					[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6003A9F")]
					[Address(RVA = "0xA34E90", Offset = "0xA34290", VA = "0x180A34E90", Slot = "3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6003AA0")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6003AA1")]
					[Address(RVA = "0xA35380", Offset = "0xA34780", VA = "0x180A35380", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6003AA2")]
					[Address(RVA = "0xA34B40", Offset = "0xA33F40", VA = "0x180A34B40", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6003AA3")]
					[Address(RVA = "0xA34E10", Offset = "0xA34210", VA = "0x180A34E10", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SummonsByActor other)
					{
					}

					[Token(Token = "0x6003AA4")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6003AA5")]
					[Address(RVA = "0xA35270", Offset = "0xA34670", VA = "0x180A35270", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000581")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SummonsByContextInformation : IMessage<SummonsByContextInformation>, IMessage, IEquatable<SummonsByContextInformation>, IDeepCloneable<SummonsByContextInformation>, IBufferMessage
				{
					[Token(Token = "0x2000582")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static class Types
					{
						[Token(Token = "0x2000583")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class SummonContextInformation : IMessage<SummonContextInformation>, IMessage, IEquatable<SummonContextInformation>, IDeepCloneable<SummonContextInformation>, IBufferMessage
						{
							[Token(Token = "0x4001330")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<SummonContextInformation> _parser;

							[Token(Token = "0x4001331")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x4001332")]
							public const int SpawnInformationFieldNumber = 1;

							[Token(Token = "0x4001333")]
							[FieldOffset(Offset = "0x18")]
							private EntitySpawnInformation spawnInformation_;

							[Token(Token = "0x4001334")]
							public const int WaveFieldNumber = 2;

							[Token(Token = "0x4001335")]
							[FieldOffset(Offset = "0x20")]
							private int wave_;

							[Token(Token = "0x4001336")]
							public const int LookFieldNumber = 3;

							[Token(Token = "0x4001337")]
							[FieldOffset(Offset = "0x28")]
							private EntityLook look_;

							[Token(Token = "0x4001338")]
							public const int CharacteristicsFieldNumber = 4;

							[Token(Token = "0x4001339")]
							[FieldOffset(Offset = "0x30")]
							private FightCharacteristics characteristics_;

							[Token(Token = "0x400133A")]
							public const int SummonsFieldNumber = 5;

							[Token(Token = "0x400133B")]
							[FieldOffset(Offset = "0x8")]
							private static readonly FieldCodec<SpawnInformation> _repeated_summons_codec;

							[Token(Token = "0x400133C")]
							[FieldOffset(Offset = "0x38")]
							private readonly RepeatedField<SpawnInformation> summons_;

							[Token(Token = "0x17000C91")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<SummonContextInformation> Parser
							{
								[Token(Token = "0x6003ABC")]
								[Address(RVA = "0xA346B0", Offset = "0xA33AB0", VA = "0x180A346B0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17000C92")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x6003ABD")]
								[Address(RVA = "0xA34630", Offset = "0xA33A30", VA = "0x180A34630")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17000C93")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x6003ABE")]
								[Address(RVA = "0xA34A80", Offset = "0xA33E80", VA = "0x180A34A80", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x17000C94")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public EntitySpawnInformation SpawnInformation
							{
								[Token(Token = "0x6003AC2")]
								[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
								get
								{
									return null;
								}
								[Token(Token = "0x6003AC3")]
								[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
								set
								{
								}
							}

							[Token(Token = "0x17000C95")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int Wave
							{
								[Token(Token = "0x6003AC4")]
								[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6003AC5")]
								[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
								set
								{
								}
							}

							[Token(Token = "0x17000C96")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public EntityLook Look
							{
								[Token(Token = "0x6003AC6")]
								[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
								get
								{
									return null;
								}
								[Token(Token = "0x6003AC7")]
								[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
								set
								{
								}
							}

							[Token(Token = "0x17000C97")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public FightCharacteristics Characteristics
							{
								[Token(Token = "0x6003AC8")]
								[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
								get
								{
									return null;
								}
								[Token(Token = "0x6003AC9")]
								[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
								set
								{
								}
							}

							[Token(Token = "0x17000C98")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public RepeatedField<SpawnInformation> Summons
							{
								[Token(Token = "0x6003ACA")]
								[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x6003ABF")]
							[Address(RVA = "0xA345B0", Offset = "0xA339B0", VA = "0x180A345B0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public SummonContextInformation()
							{
							}

							[Token(Token = "0x6003AC0")]
							[Address(RVA = "0xA34450", Offset = "0xA33850", VA = "0x180A34450")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public SummonContextInformation(SummonContextInformation other)
							{
							}

							[Token(Token = "0x6003AC1")]
							[Address(RVA = "0xA33C30", Offset = "0xA33030", VA = "0x180A33C30", Slot = "10")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public SummonContextInformation Clone()
							{
								return null;
							}

							[Token(Token = "0x6003ACB")]
							[Address(RVA = "0xA33EA0", Offset = "0xA332A0", VA = "0x180A33EA0", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x6003ACC")]
							[Address(RVA = "0xA33DC0", Offset = "0xA331C0", VA = "0x180A33DC0", Slot = "9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public bool Equals(SummonContextInformation other)
							{
								return default(bool);
							}

							[Token(Token = "0x6003ACD")]
							[Address(RVA = "0xA33FC0", Offset = "0xA333C0", VA = "0x180A33FC0", Slot = "2")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x6003ACE")]
							[Address(RVA = "0xA34250", Offset = "0xA33650", VA = "0x180A34250", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x6003ACF")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x6003AD0")]
							[Address(RVA = "0xA34940", Offset = "0xA33D40", VA = "0x180A34940", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x6003AD1")]
							[Address(RVA = "0xA33AC0", Offset = "0xA32EC0", VA = "0x180A33AC0", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x6003AD2")]
							[Address(RVA = "0xA340A0", Offset = "0xA334A0", VA = "0x180A340A0", Slot = "4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(SummonContextInformation other)
							{
							}

							[Token(Token = "0x6003AD3")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x6003AD4")]
							[Address(RVA = "0xA34700", Offset = "0xA33B00", VA = "0x180A34700", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}
					}

					[Token(Token = "0x400132B")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SummonsByContextInformation> _parser;

					[Token(Token = "0x400132C")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x400132D")]
					public const int SummonsFieldNumber = 1;

					[Token(Token = "0x400132E")]
					[FieldOffset(Offset = "0x8")]
					private static readonly FieldCodec<Types.SummonContextInformation> _repeated_summons_codec;

					[Token(Token = "0x400132F")]
					[FieldOffset(Offset = "0x18")]
					private readonly RepeatedField<Types.SummonContextInformation> summons_;

					[Token(Token = "0x17000C8D")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<SummonsByContextInformation> Parser
					{
						[Token(Token = "0x6003AAA")]
						[Address(RVA = "0xA35BC0", Offset = "0xA34FC0", VA = "0x180A35BC0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000C8E")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6003AAB")]
						[Address(RVA = "0xA35B40", Offset = "0xA34F40", VA = "0x180A35B40")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000C8F")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6003AAC")]
						[Address(RVA = "0xA35DD0", Offset = "0xA351D0", VA = "0x180A35DD0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000C90")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public RepeatedField<Types.SummonContextInformation> Summons
					{
						[Token(Token = "0x6003AB0")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6003AAD")]
					[Address(RVA = "0xA35AC0", Offset = "0xA34EC0", VA = "0x180A35AC0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SummonsByContextInformation()
					{
					}

					[Token(Token = "0x6003AAE")]
					[Address(RVA = "0xA35A30", Offset = "0xA34E30", VA = "0x180A35A30")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public SummonsByContextInformation(SummonsByContextInformation other)
					{
					}

					[Token(Token = "0x6003AAF")]
					[Address(RVA = "0xA35580", Offset = "0xA34980", VA = "0x180A35580", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SummonsByContextInformation Clone()
					{
						return null;
					}

					[Token(Token = "0x6003AB1")]
					[Address(RVA = "0xA356D0", Offset = "0xA34AD0", VA = "0x180A356D0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6003AB2")]
					[Address(RVA = "0xA35640", Offset = "0xA34A40", VA = "0x180A35640", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SummonsByContextInformation other)
					{
						return default(bool);
					}

					[Token(Token = "0x6003AB3")]
					[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6003AB4")]
					[Address(RVA = "0xA35830", Offset = "0xA34C30", VA = "0x180A35830", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6003AB5")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6003AB6")]
					[Address(RVA = "0xA35D20", Offset = "0xA35120", VA = "0x180A35D20", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6003AB7")]
					[Address(RVA = "0xA354E0", Offset = "0xA348E0", VA = "0x180A354E0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6003AB8")]
					[Address(RVA = "0xA357B0", Offset = "0xA34BB0", VA = "0x180A357B0", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(SummonsByContextInformation other)
					{
					}

					[Token(Token = "0x6003AB9")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6003ABA")]
					[Address(RVA = "0xA35C10", Offset = "0xA35010", VA = "0x180A35C10", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x400131B")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Summons> _parser;

			[Token(Token = "0x400131C")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400131D")]
			public const int SummonsByActorFieldNumber = 1;

			[Token(Token = "0x400131E")]
			public const int SummonsByContextInformationFieldNumber = 2;

			[Token(Token = "0x400131F")]
			[FieldOffset(Offset = "0x18")]
			private object summons_;

			[Token(Token = "0x4001320")]
			[FieldOffset(Offset = "0x20")]
			private SummonsOneofCase summonsCase_;

			[Token(Token = "0x17000C83")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Summons> Parser
			{
				[Token(Token = "0x6003A7E")]
				[Address(RVA = "0xA36A70", Offset = "0xA35E70", VA = "0x180A36A70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C84")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003A7F")]
				[Address(RVA = "0xA369F0", Offset = "0xA35DF0", VA = "0x180A369F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C85")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003A80")]
				[Address(RVA = "0xA36E30", Offset = "0xA36230", VA = "0x180A36E30", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C86")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.SummonsByActor SummonsByActor
			{
				[Token(Token = "0x6003A84")]
				[Address(RVA = "0xA36AC0", Offset = "0xA35EC0", VA = "0x180A36AC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003A85")]
				[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
				set
				{
				}
			}

			[Token(Token = "0x17000C87")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.SummonsByContextInformation SummonsByContextInformation
			{
				[Token(Token = "0x6003A86")]
				[Address(RVA = "0xA36B20", Offset = "0xA35F20", VA = "0x180A36B20")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003A87")]
				[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
				set
				{
				}
			}

			[Token(Token = "0x17000C88")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SummonsOneofCase SummonsCase
			{
				[Token(Token = "0x6003A88")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(SummonsOneofCase);
				}
			}

			[Token(Token = "0x6003A81")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Summons()
			{
			}

			[Token(Token = "0x6003A82")]
			[Address(RVA = "0xA36770", Offset = "0xA35B70", VA = "0x180A36770")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Summons(Summons other)
			{
			}

			[Token(Token = "0x6003A83")]
			[Address(RVA = "0xA35F40", Offset = "0xA35340", VA = "0x180A35F40", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Summons Clone()
			{
				return null;
			}

			[Token(Token = "0x6003A89")]
			[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearSummons()
			{
			}

			[Token(Token = "0x6003A8A")]
			[Address(RVA = "0xA360D0", Offset = "0xA354D0", VA = "0x180A360D0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A8B")]
			[Address(RVA = "0xA35FA0", Offset = "0xA353A0", VA = "0x180A35FA0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Summons other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003A8C")]
			[Address(RVA = "0xA36240", Offset = "0xA35640", VA = "0x180A36240", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003A8D")]
			[Address(RVA = "0xA36610", Offset = "0xA35A10", VA = "0x180A36610", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003A8E")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003A8F")]
			[Address(RVA = "0xA36D20", Offset = "0xA36120", VA = "0x180A36D20", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003A90")]
			[Address(RVA = "0xA35E10", Offset = "0xA35210", VA = "0x180A35E10", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003A91")]
			[Address(RVA = "0xA36370", Offset = "0xA35770", VA = "0x180A36370", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Summons other)
			{
			}

			[Token(Token = "0x6003A92")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003A93")]
			[Address(RVA = "0xA36B80", Offset = "0xA35F80", VA = "0x180A36B80", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000587")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class MarkCells : IMessage<MarkCells>, IMessage, IEquatable<MarkCells>, IDeepCloneable<MarkCells>, IBufferMessage
		{
			[Token(Token = "0x4001340")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<MarkCells> _parser;

			[Token(Token = "0x4001341")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001342")]
			public const int MarkFieldNumber = 1;

			[Token(Token = "0x4001343")]
			[FieldOffset(Offset = "0x18")]
			private FightMark mark_;

			[Token(Token = "0x17000C99")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<MarkCells> Parser
			{
				[Token(Token = "0x6003ADF")]
				[Address(RVA = "0xA2DD80", Offset = "0xA2D180", VA = "0x180A2DD80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C9A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003AE0")]
				[Address(RVA = "0xA2DD00", Offset = "0xA2D100", VA = "0x180A2DD00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C9B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003AE1")]
				[Address(RVA = "0xA2DED0", Offset = "0xA2D2D0", VA = "0x180A2DED0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C9C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FightMark Mark
			{
				[Token(Token = "0x6003AE5")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003AE6")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x6003AE2")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MarkCells()
			{
			}

			[Token(Token = "0x6003AE3")]
			[Address(RVA = "0xA2DC90", Offset = "0xA2D090", VA = "0x180A2DC90")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MarkCells(MarkCells other)
			{
			}

			[Token(Token = "0x6003AE4")]
			[Address(RVA = "0xA2D910", Offset = "0xA2CD10", VA = "0x180A2D910", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MarkCells Clone()
			{
				return null;
			}

			[Token(Token = "0x6003AE7")]
			[Address(RVA = "0xA2D9B0", Offset = "0xA2CDB0", VA = "0x180A2D9B0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003AE8")]
			[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(MarkCells other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003AE9")]
			[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0xA2DB30", Offset = "0xA2CF30", VA = "0x180A2DB30", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003AEB")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003AEC")]
			[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003AED")]
			[Address(RVA = "0xA2D880", Offset = "0xA2CC80", VA = "0x180A2D880", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003AEE")]
			[Address(RVA = "0xA2DA60", Offset = "0xA2CE60", VA = "0x180A2DA60", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(MarkCells other)
			{
			}

			[Token(Token = "0x6003AEF")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003AF0")]
			[Address(RVA = "0xA2DDD0", Offset = "0xA2D1D0", VA = "0x180A2DDD0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000589")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ModifyEffectsDuration : IMessage<ModifyEffectsDuration>, IMessage, IEquatable<ModifyEffectsDuration>, IDeepCloneable<ModifyEffectsDuration>, IBufferMessage
		{
			[Token(Token = "0x4001345")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ModifyEffectsDuration> _parser;

			[Token(Token = "0x4001346")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001347")]
			public const int TargetIdFieldNumber = 3;

			[Token(Token = "0x4001348")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4001349")]
			public const int DeltaFieldNumber = 4;

			[Token(Token = "0x400134A")]
			[FieldOffset(Offset = "0x20")]
			private int delta_;

			[Token(Token = "0x17000C9D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ModifyEffectsDuration> Parser
			{
				[Token(Token = "0x6003AF5")]
				[Address(RVA = "0xA2E350", Offset = "0xA2D750", VA = "0x180A2E350")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C9E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003AF6")]
				[Address(RVA = "0xA2E2D0", Offset = "0xA2D6D0", VA = "0x180A2E2D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000C9F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003AF7")]
				[Address(RVA = "0xA2E3A0", Offset = "0xA2D7A0", VA = "0x180A2E3A0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CA0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003AFB")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003AFC")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CA1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Delta
			{
				[Token(Token = "0x6003AFD")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003AFE")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003AF8")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ModifyEffectsDuration()
			{
			}

			[Token(Token = "0x6003AF9")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ModifyEffectsDuration(ModifyEffectsDuration other)
			{
			}

			[Token(Token = "0x6003AFA")]
			[Address(RVA = "0xA2E040", Offset = "0xA2D440", VA = "0x180A2E040", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ModifyEffectsDuration Clone()
			{
				return null;
			}

			[Token(Token = "0x6003AFF")]
			[Address(RVA = "0xA2E0D0", Offset = "0xA2D4D0", VA = "0x180A2E0D0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B00")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ModifyEffectsDuration other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B01")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003B02")]
			[Address(RVA = "0xA2E170", Offset = "0xA2D570", VA = "0x180A2E170", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003B03")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003B04")]
			[Address(RVA = "0xA11610", Offset = "0xA10A10", VA = "0x180A11610", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003B05")]
			[Address(RVA = "0xA2DF80", Offset = "0xA2D380", VA = "0x180A2DF80", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003B06")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ModifyEffectsDuration other)
			{
			}

			[Token(Token = "0x6003B07")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003B08")]
			[Address(RVA = "0xA11560", Offset = "0xA10960", VA = "0x180A11560", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200058B")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class StealKama : IMessage<StealKama>, IMessage, IEquatable<StealKama>, IDeepCloneable<StealKama>, IBufferMessage
		{
			[Token(Token = "0x400134C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<StealKama> _parser;

			[Token(Token = "0x400134D")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400134E")]
			public const int TargetIdFieldNumber = 3;

			[Token(Token = "0x400134F")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4001350")]
			public const int AmountFieldNumber = 4;

			[Token(Token = "0x4001351")]
			[FieldOffset(Offset = "0x20")]
			private long amount_;

			[Token(Token = "0x17000CA2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<StealKama> Parser
			{
				[Token(Token = "0x6003B0D")]
				[Address(RVA = "0xA33890", Offset = "0xA32C90", VA = "0x180A33890")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CA3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003B0E")]
				[Address(RVA = "0xA33810", Offset = "0xA32C10", VA = "0x180A33810")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CA4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003B0F")]
				[Address(RVA = "0xA33A10", Offset = "0xA32E10", VA = "0x180A33A10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CA5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003B13")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003B14")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CA6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long Amount
			{
				[Token(Token = "0x6003B15")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003B16")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x6003B10")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public StealKama()
			{
			}

			[Token(Token = "0x6003B11")]
			[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public StealKama(StealKama other)
			{
			}

			[Token(Token = "0x6003B12")]
			[Address(RVA = "0xA33580", Offset = "0xA32980", VA = "0x180A33580", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public StealKama Clone()
			{
				return null;
			}

			[Token(Token = "0x6003B17")]
			[Address(RVA = "0xA33610", Offset = "0xA32A10", VA = "0x180A33610", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B18")]
			[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(StealKama other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B19")]
			[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003B1A")]
			[Address(RVA = "0xA336B0", Offset = "0xA32AB0", VA = "0x180A336B0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003B1B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003B1C")]
			[Address(RVA = "0xA33990", Offset = "0xA32D90", VA = "0x180A33990", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003B1D")]
			[Address(RVA = "0xA334C0", Offset = "0xA328C0", VA = "0x180A334C0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003B1E")]
			[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(StealKama other)
			{
			}

			[Token(Token = "0x6003B1F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003B20")]
			[Address(RVA = "0xA338E0", Offset = "0xA32CE0", VA = "0x180A338E0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200058D")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ChangeLook : IMessage<ChangeLook>, IMessage, IEquatable<ChangeLook>, IDeepCloneable<ChangeLook>, IBufferMessage
		{
			[Token(Token = "0x4001353")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ChangeLook> _parser;

			[Token(Token = "0x4001354")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001355")]
			public const int TargetIdFieldNumber = 3;

			[Token(Token = "0x4001356")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4001357")]
			public const int LookFieldNumber = 4;

			[Token(Token = "0x4001358")]
			[FieldOffset(Offset = "0x20")]
			private EntityLook look_;

			[Token(Token = "0x17000CA7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ChangeLook> Parser
			{
				[Token(Token = "0x6003B25")]
				[Address(RVA = "0xA28400", Offset = "0xA27800", VA = "0x180A28400")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CA8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003B26")]
				[Address(RVA = "0xA28380", Offset = "0xA27780", VA = "0x180A28380")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CA9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003B27")]
				[Address(RVA = "0xA285F0", Offset = "0xA279F0", VA = "0x180A285F0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CAA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003B2B")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003B2C")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CAB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public EntityLook Look
			{
				[Token(Token = "0x6003B2D")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003B2E")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x6003B28")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ChangeLook()
			{
			}

			[Token(Token = "0x6003B29")]
			[Address(RVA = "0xA28300", Offset = "0xA27700", VA = "0x180A28300")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ChangeLook(ChangeLook other)
			{
			}

			[Token(Token = "0x6003B2A")]
			[Address(RVA = "0xA27F60", Offset = "0xA27360", VA = "0x180A27F60", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ChangeLook Clone()
			{
				return null;
			}

			[Token(Token = "0x6003B2F")]
			[Address(RVA = "0xA28000", Offset = "0xA27400", VA = "0x180A28000", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B30")]
			[Address(RVA = "0x953270", Offset = "0x952670", VA = "0x180953270", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ChangeLook other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B31")]
			[Address(RVA = "0x9533A0", Offset = "0x9527A0", VA = "0x1809533A0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003B32")]
			[Address(RVA = "0xA281A0", Offset = "0xA275A0", VA = "0x180A281A0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003B33")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003B34")]
			[Address(RVA = "0xA28570", Offset = "0xA27970", VA = "0x180A28570", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003B35")]
			[Address(RVA = "0xA27EA0", Offset = "0xA272A0", VA = "0x180A27EA0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003B36")]
			[Address(RVA = "0xA280C0", Offset = "0xA274C0", VA = "0x180A280C0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ChangeLook other)
			{
			}

			[Token(Token = "0x6003B37")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003B38")]
			[Address(RVA = "0xA28450", Offset = "0xA27850", VA = "0x180A28450", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200058F")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class TeleportOnSameMap : IMessage<TeleportOnSameMap>, IMessage, IEquatable<TeleportOnSameMap>, IDeepCloneable<TeleportOnSameMap>, IBufferMessage
		{
			[Token(Token = "0x400135A")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<TeleportOnSameMap> _parser;

			[Token(Token = "0x400135B")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400135C")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x400135D")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x400135E")]
			public const int CellFieldNumber = 2;

			[Token(Token = "0x400135F")]
			[FieldOffset(Offset = "0x20")]
			private int cell_;

			[Token(Token = "0x17000CAC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<TeleportOnSameMap> Parser
			{
				[Token(Token = "0x6003B3D")]
				[Address(RVA = "0xA38DC0", Offset = "0xA381C0", VA = "0x180A38DC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CAD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003B3E")]
				[Address(RVA = "0xA38D40", Offset = "0xA38140", VA = "0x180A38D40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CAE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003B3F")]
				[Address(RVA = "0xA38E10", Offset = "0xA38210", VA = "0x180A38E10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CAF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003B43")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003B44")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CB0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Cell
			{
				[Token(Token = "0x6003B45")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003B46")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003B40")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TeleportOnSameMap()
			{
			}

			[Token(Token = "0x6003B41")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TeleportOnSameMap(TeleportOnSameMap other)
			{
			}

			[Token(Token = "0x6003B42")]
			[Address(RVA = "0xA38AB0", Offset = "0xA37EB0", VA = "0x180A38AB0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TeleportOnSameMap Clone()
			{
				return null;
			}

			[Token(Token = "0x6003B47")]
			[Address(RVA = "0xA38B40", Offset = "0xA37F40", VA = "0x180A38B40", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B48")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(TeleportOnSameMap other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B49")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003B4A")]
			[Address(RVA = "0xA38BE0", Offset = "0xA37FE0", VA = "0x180A38BE0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003B4B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003B4C")]
			[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003B4D")]
			[Address(RVA = "0xA389F0", Offset = "0xA37DF0", VA = "0x180A389F0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003B4E")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(TeleportOnSameMap other)
			{
			}

			[Token(Token = "0x6003B4F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003B50")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000591")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ExchangePositions : IMessage<ExchangePositions>, IMessage, IEquatable<ExchangePositions>, IDeepCloneable<ExchangePositions>, IBufferMessage
		{
			[Token(Token = "0x4001361")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ExchangePositions> _parser;

			[Token(Token = "0x4001362")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001363")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x4001364")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4001365")]
			public const int CasterCellIdFieldNumber = 2;

			[Token(Token = "0x4001366")]
			[FieldOffset(Offset = "0x20")]
			private int casterCellId_;

			[Token(Token = "0x4001367")]
			public const int TargetCellIdFieldNumber = 3;

			[Token(Token = "0x4001368")]
			[FieldOffset(Offset = "0x24")]
			private int targetCellId_;

			[Token(Token = "0x17000CB1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ExchangePositions> Parser
			{
				[Token(Token = "0x6003B55")]
				[Address(RVA = "0xA2AAA0", Offset = "0xA29EA0", VA = "0x180A2AAA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CB2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003B56")]
				[Address(RVA = "0xA2AA20", Offset = "0xA29E20", VA = "0x180A2AA20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CB3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003B57")]
				[Address(RVA = "0xA2AAF0", Offset = "0xA29EF0", VA = "0x180A2AAF0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CB4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003B5B")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003B5C")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CB5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CasterCellId
			{
				[Token(Token = "0x6003B5D")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003B5E")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17000CB6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int TargetCellId
			{
				[Token(Token = "0x6003B5F")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003B60")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x6003B58")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExchangePositions()
			{
			}

			[Token(Token = "0x6003B59")]
			[Address(RVA = "0x9D5350", Offset = "0x9D4750", VA = "0x1809D5350")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExchangePositions(ExchangePositions other)
			{
			}

			[Token(Token = "0x6003B5A")]
			[Address(RVA = "0xA2A790", Offset = "0xA29B90", VA = "0x180A2A790", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ExchangePositions Clone()
			{
				return null;
			}

			[Token(Token = "0x6003B61")]
			[Address(RVA = "0xA2A820", Offset = "0xA29C20", VA = "0x180A2A820", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B62")]
			[Address(RVA = "0x9D4FF0", Offset = "0x9D43F0", VA = "0x1809D4FF0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ExchangePositions other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B63")]
			[Address(RVA = "0x9D50D0", Offset = "0x9D44D0", VA = "0x1809D50D0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003B64")]
			[Address(RVA = "0xA2A8C0", Offset = "0xA29CC0", VA = "0x180A2A8C0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003B65")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003B66")]
			[Address(RVA = "0x9D5580", Offset = "0x9D4980", VA = "0x1809D5580", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003B67")]
			[Address(RVA = "0xA2A6B0", Offset = "0xA29AB0", VA = "0x180A2A6B0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003B68")]
			[Address(RVA = "0x9D5180", Offset = "0x9D4580", VA = "0x1809D5180", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(ExchangePositions other)
			{
			}

			[Token(Token = "0x6003B69")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003B6A")]
			[Address(RVA = "0x9D54B0", Offset = "0x9D48B0", VA = "0x1809D54B0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000593")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SpellRemove : IMessage<SpellRemove>, IMessage, IEquatable<SpellRemove>, IDeepCloneable<SpellRemove>, IBufferMessage
		{
			[Token(Token = "0x2000594")]
			public enum ComplementOneofCase
			{
				[Token(Token = "0x4001375")]
				None = 0,
				[Token(Token = "0x4001376")]
				EffectRemove = 3,
				[Token(Token = "0x4001377")]
				SpellId = 4
			}

			[Token(Token = "0x2000595")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000596")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class EffectRemove : IMessage<EffectRemove>, IMessage, IEquatable<EffectRemove>, IDeepCloneable<EffectRemove>, IBufferMessage
				{
					[Token(Token = "0x4001378")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<EffectRemove> _parser;

					[Token(Token = "0x4001379")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x400137A")]
					public const int EffectFieldNumber = 1;

					[Token(Token = "0x400137B")]
					[FieldOffset(Offset = "0x18")]
					private int effect_;

					[Token(Token = "0x400137C")]
					public const int TriggerFieldNumber = 2;

					[Token(Token = "0x400137D")]
					[FieldOffset(Offset = "0x1C")]
					private bool trigger_;

					[Token(Token = "0x17000CC0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<EffectRemove> Parser
					{
						[Token(Token = "0x6003B8C")]
						[Address(RVA = "0xA29440", Offset = "0xA28840", VA = "0x180A29440")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000CC1")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6003B8D")]
						[Address(RVA = "0xA293C0", Offset = "0xA287C0", VA = "0x180A293C0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000CC2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6003B8E")]
						[Address(RVA = "0xA29490", Offset = "0xA28890", VA = "0x180A29490", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000CC3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int Effect
					{
						[Token(Token = "0x6003B92")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6003B93")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17000CC4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Trigger
					{
						[Token(Token = "0x6003B94")]
						[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
						get
						{
							return default(bool);
						}
						[Token(Token = "0x6003B95")]
						[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
						set
						{
						}
					}

					[Token(Token = "0x6003B8F")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public EffectRemove()
					{
					}

					[Token(Token = "0x6003B90")]
					[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public EffectRemove(EffectRemove other)
					{
					}

					[Token(Token = "0x6003B91")]
					[Address(RVA = "0xA29080", Offset = "0xA28480", VA = "0x180A29080", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public EffectRemove Clone()
					{
						return null;
					}

					[Token(Token = "0x6003B96")]
					[Address(RVA = "0xA29110", Offset = "0xA28510", VA = "0x180A29110", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6003B97")]
					[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(EffectRemove other)
					{
						return default(bool);
					}

					[Token(Token = "0x6003B98")]
					[Address(RVA = "0xA291A0", Offset = "0xA285A0", VA = "0x180A291A0", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6003B99")]
					[Address(RVA = "0xA29260", Offset = "0xA28660", VA = "0x180A29260", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6003B9A")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6003B9B")]
					[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6003B9C")]
					[Address(RVA = "0xA28FF0", Offset = "0xA283F0", VA = "0x180A28FF0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6003B9D")]
					[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(EffectRemove other)
					{
					}

					[Token(Token = "0x6003B9E")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6003B9F")]
					[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x400136A")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SpellRemove> _parser;

			[Token(Token = "0x400136B")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400136C")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x400136D")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x400136E")]
			public const int VerboseCastFieldNumber = 2;

			[Token(Token = "0x400136F")]
			[FieldOffset(Offset = "0x20")]
			private bool verboseCast_;

			[Token(Token = "0x4001370")]
			public const int EffectRemoveFieldNumber = 3;

			[Token(Token = "0x4001371")]
			public const int SpellIdFieldNumber = 4;

			[Token(Token = "0x4001372")]
			[FieldOffset(Offset = "0x28")]
			private object complement_;

			[Token(Token = "0x4001373")]
			[FieldOffset(Offset = "0x30")]
			private ComplementOneofCase complementCase_;

			[Token(Token = "0x17000CB7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SpellRemove> Parser
			{
				[Token(Token = "0x6003B6F")]
				[Address(RVA = "0xA33010", Offset = "0xA32410", VA = "0x180A33010")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CB8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003B70")]
				[Address(RVA = "0xA32F20", Offset = "0xA32320", VA = "0x180A32F20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CB9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003B71")]
				[Address(RVA = "0xA33410", Offset = "0xA32810", VA = "0x180A33410", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CBA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003B75")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003B76")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CBB")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool VerboseCast
			{
				[Token(Token = "0x6003B77")]
				[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003B78")]
				[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
				set
				{
				}
			}

			[Token(Token = "0x17000CBC")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.EffectRemove EffectRemove
			{
				[Token(Token = "0x6003B79")]
				[Address(RVA = "0xA32FA0", Offset = "0xA323A0", VA = "0x180A32FA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003B7A")]
				[Address(RVA = "0x91BB80", Offset = "0x91AF80", VA = "0x18091BB80")]
				set
				{
				}
			}

			[Token(Token = "0x17000CBD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SpellId
			{
				[Token(Token = "0x6003B7B")]
				[Address(RVA = "0xA33060", Offset = "0xA32460", VA = "0x180A33060")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003B7C")]
				[Address(RVA = "0xA33450", Offset = "0xA32850", VA = "0x180A33450")]
				set
				{
				}
			}

			[Token(Token = "0x17000CBE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasSpellId
			{
				[Token(Token = "0x6003B7D")]
				[Address(RVA = "0xA33000", Offset = "0xA32400", VA = "0x180A33000")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000CBF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ComplementOneofCase ComplementCase
			{
				[Token(Token = "0x6003B7F")]
				[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
				get
				{
					return default(ComplementOneofCase);
				}
			}

			[Token(Token = "0x6003B72")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SpellRemove()
			{
			}

			[Token(Token = "0x6003B73")]
			[Address(RVA = "0xA32DB0", Offset = "0xA321B0", VA = "0x180A32DB0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SpellRemove(SpellRemove other)
			{
			}

			[Token(Token = "0x6003B74")]
			[Address(RVA = "0xA32510", Offset = "0xA31910", VA = "0x180A32510", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SpellRemove Clone()
			{
				return null;
			}

			[Token(Token = "0x6003B7E")]
			[Address(RVA = "0xA324F0", Offset = "0xA318F0", VA = "0x180A324F0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearSpellId()
			{
			}

			[Token(Token = "0x6003B80")]
			[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearComplement()
			{
			}

			[Token(Token = "0x6003B81")]
			[Address(RVA = "0xA32770", Offset = "0xA31B70", VA = "0x180A32770", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B82")]
			[Address(RVA = "0xA326A0", Offset = "0xA31AA0", VA = "0x180A326A0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SpellRemove other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B83")]
			[Address(RVA = "0xA32880", Offset = "0xA31C80", VA = "0x180A32880", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003B84")]
			[Address(RVA = "0xA32C50", Offset = "0xA32050", VA = "0x180A32C50", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003B85")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003B86")]
			[Address(RVA = "0xA332A0", Offset = "0xA326A0", VA = "0x180A332A0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003B87")]
			[Address(RVA = "0xA32360", Offset = "0xA31760", VA = "0x180A32360", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003B88")]
			[Address(RVA = "0xA32A20", Offset = "0xA31E20", VA = "0x180A32A20", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SpellRemove other)
			{
			}

			[Token(Token = "0x6003B89")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003B8A")]
			[Address(RVA = "0xA330D0", Offset = "0xA324D0", VA = "0x180A330D0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000599")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Tackled : IMessage<Tackled>, IMessage, IEquatable<Tackled>, IDeepCloneable<Tackled>, IBufferMessage
		{
			[Token(Token = "0x4001380")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Tackled> _parser;

			[Token(Token = "0x4001381")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001382")]
			public const int TacklersIdFieldNumber = 1;

			[Token(Token = "0x4001383")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<long> _repeated_tacklersId_codec;

			[Token(Token = "0x4001384")]
			[FieldOffset(Offset = "0x18")]
			private readonly RepeatedField<long> tacklersId_;

			[Token(Token = "0x17000CC5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Tackled> Parser
			{
				[Token(Token = "0x6003BA7")]
				[Address(RVA = "0xA374E0", Offset = "0xA368E0", VA = "0x180A374E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CC6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003BA8")]
				[Address(RVA = "0xA37460", Offset = "0xA36860", VA = "0x180A37460")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CC7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003BA9")]
				[Address(RVA = "0xA37700", Offset = "0xA36B00", VA = "0x180A37700", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CC8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<long> TacklersId
			{
				[Token(Token = "0x6003BAD")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6003BAA")]
			[Address(RVA = "0xA37350", Offset = "0xA36750", VA = "0x180A37350")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Tackled()
			{
			}

			[Token(Token = "0x6003BAB")]
			[Address(RVA = "0xA373D0", Offset = "0xA367D0", VA = "0x180A373D0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Tackled(Tackled other)
			{
			}

			[Token(Token = "0x6003BAC")]
			[Address(RVA = "0xA36F10", Offset = "0xA36310", VA = "0x180A36F10", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Tackled Clone()
			{
				return null;
			}

			[Token(Token = "0x6003BAE")]
			[Address(RVA = "0xA36FD0", Offset = "0xA363D0", VA = "0x180A36FD0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003BAF")]
			[Address(RVA = "0xA370B0", Offset = "0xA364B0", VA = "0x180A370B0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Tackled other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003BB0")]
			[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003BB1")]
			[Address(RVA = "0xA371C0", Offset = "0xA365C0", VA = "0x180A371C0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003BB2")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003BB3")]
			[Address(RVA = "0xA37650", Offset = "0xA36A50", VA = "0x180A37650", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003BB4")]
			[Address(RVA = "0xA36E70", Offset = "0xA36270", VA = "0x180A36E70", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003BB5")]
			[Address(RVA = "0xA37140", Offset = "0xA36540", VA = "0x180A37140", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Tackled other)
			{
			}

			[Token(Token = "0x6003BB6")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003BB7")]
			[Address(RVA = "0xA37530", Offset = "0xA36930", VA = "0x180A37530", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200059B")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PointsVariation : IMessage<PointsVariation>, IMessage, IEquatable<PointsVariation>, IDeepCloneable<PointsVariation>, IBufferMessage
		{
			[Token(Token = "0x4001386")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PointsVariation> _parser;

			[Token(Token = "0x4001387")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001388")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x4001389")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x400138A")]
			public const int DeltaFieldNumber = 2;

			[Token(Token = "0x400138B")]
			[FieldOffset(Offset = "0x20")]
			private int delta_;

			[Token(Token = "0x17000CC9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<PointsVariation> Parser
			{
				[Token(Token = "0x6003BBC")]
				[Address(RVA = "0xA2E820", Offset = "0xA2DC20", VA = "0x180A2E820")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CCA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003BBD")]
				[Address(RVA = "0xA2E7A0", Offset = "0xA2DBA0", VA = "0x180A2E7A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CCB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003BBE")]
				[Address(RVA = "0xA2E870", Offset = "0xA2DC70", VA = "0x180A2E870", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CCC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003BC2")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003BC3")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CCD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Delta
			{
				[Token(Token = "0x6003BC4")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003BC5")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003BBF")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PointsVariation()
			{
			}

			[Token(Token = "0x6003BC0")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PointsVariation(PointsVariation other)
			{
			}

			[Token(Token = "0x6003BC1")]
			[Address(RVA = "0xA2E510", Offset = "0xA2D910", VA = "0x180A2E510", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PointsVariation Clone()
			{
				return null;
			}

			[Token(Token = "0x6003BC6")]
			[Address(RVA = "0xA2E5A0", Offset = "0xA2D9A0", VA = "0x180A2E5A0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003BC7")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PointsVariation other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003BC8")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003BC9")]
			[Address(RVA = "0xA2E640", Offset = "0xA2DA40", VA = "0x180A2E640", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003BCA")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003BCB")]
			[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003BCC")]
			[Address(RVA = "0xA2E450", Offset = "0xA2D850", VA = "0x180A2E450", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003BCD")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(PointsVariation other)
			{
			}

			[Token(Token = "0x6003BCE")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003BCF")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200059D")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class InvisibleDetected : IMessage<InvisibleDetected>, IMessage, IEquatable<InvisibleDetected>, IDeepCloneable<InvisibleDetected>, IBufferMessage
		{
			[Token(Token = "0x400138D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<InvisibleDetected> _parser;

			[Token(Token = "0x400138E")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400138F")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x4001390")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4001391")]
			public const int CellFieldNumber = 2;

			[Token(Token = "0x4001392")]
			[FieldOffset(Offset = "0x20")]
			private int cell_;

			[Token(Token = "0x17000CCE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<InvisibleDetected> Parser
			{
				[Token(Token = "0x6003BD4")]
				[Address(RVA = "0xA2C290", Offset = "0xA2B690", VA = "0x180A2C290")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CCF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003BD5")]
				[Address(RVA = "0xA2C210", Offset = "0xA2B610", VA = "0x180A2C210")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CD0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003BD6")]
				[Address(RVA = "0xA2C2E0", Offset = "0xA2B6E0", VA = "0x180A2C2E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CD1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003BDA")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003BDB")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CD2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Cell
			{
				[Token(Token = "0x6003BDC")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003BDD")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003BD7")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public InvisibleDetected()
			{
			}

			[Token(Token = "0x6003BD8")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public InvisibleDetected(InvisibleDetected other)
			{
			}

			[Token(Token = "0x6003BD9")]
			[Address(RVA = "0xA2BF80", Offset = "0xA2B380", VA = "0x180A2BF80", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public InvisibleDetected Clone()
			{
				return null;
			}

			[Token(Token = "0x6003BDE")]
			[Address(RVA = "0xA2C010", Offset = "0xA2B410", VA = "0x180A2C010", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003BDF")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(InvisibleDetected other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003BE0")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003BE1")]
			[Address(RVA = "0xA2C0B0", Offset = "0xA2B4B0", VA = "0x180A2C0B0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003BE2")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003BE3")]
			[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003BE4")]
			[Address(RVA = "0xA2BEC0", Offset = "0xA2B2C0", VA = "0x180A2BEC0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003BE5")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(InvisibleDetected other)
			{
			}

			[Token(Token = "0x6003BE6")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003BE7")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200059F")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class TargetedAbility : IMessage<TargetedAbility>, IMessage, IEquatable<TargetedAbility>, IDeepCloneable<TargetedAbility>, IBufferMessage
		{
			[Token(Token = "0x20005A0")]
			public enum FightOneofCase
			{
				[Token(Token = "0x40013A5")]
				None = 0,
				[Token(Token = "0x40013A6")]
				SpellCast = 6,
				[Token(Token = "0x40013A7")]
				WeaponGenericId = 7
			}

			[Token(Token = "0x20005A1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x20005A2")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class SpellCast : IMessage<SpellCast>, IMessage, IEquatable<SpellCast>, IDeepCloneable<SpellCast>, IBufferMessage
				{
					[Token(Token = "0x40013A8")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<SpellCast> _parser;

					[Token(Token = "0x40013A9")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40013AA")]
					public const int SpellIdFieldNumber = 1;

					[Token(Token = "0x40013AB")]
					[FieldOffset(Offset = "0x18")]
					private int spellId_;

					[Token(Token = "0x40013AC")]
					public const int SpellLevelFieldNumber = 2;

					[Token(Token = "0x40013AD")]
					[FieldOffset(Offset = "0x1C")]
					private int spellLevel_;

					[Token(Token = "0x40013AE")]
					public const int PortalsIdFieldNumber = 3;

					[Token(Token = "0x40013AF")]
					[FieldOffset(Offset = "0x8")]
					private static readonly FieldCodec<int> _repeated_portalsId_codec;

					[Token(Token = "0x40013B0")]
					[FieldOffset(Offset = "0x20")]
					private readonly RepeatedField<int> portalsId_;

					[Token(Token = "0x17000CDF")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<SpellCast> Parser
					{
						[Token(Token = "0x6003C0F")]
						[Address(RVA = "0xA31660", Offset = "0xA30A60", VA = "0x180A31660")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000CE0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6003C10")]
						[Address(RVA = "0xA315E0", Offset = "0xA309E0", VA = "0x180A315E0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000CE1")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6003C11")]
						[Address(RVA = "0xA318F0", Offset = "0xA30CF0", VA = "0x180A318F0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000CE2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int SpellId
					{
						[Token(Token = "0x6003C15")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6003C16")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17000CE3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int SpellLevel
					{
						[Token(Token = "0x6003C17")]
						[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6003C18")]
						[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
						set
						{
						}
					}

					[Token(Token = "0x17000CE4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public RepeatedField<int> PortalsId
					{
						[Token(Token = "0x6003C19")]
						[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x6003C12")]
					[Address(RVA = "0xA314C0", Offset = "0xA308C0", VA = "0x180A314C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SpellCast()
					{
					}

					[Token(Token = "0x6003C13")]
					[Address(RVA = "0xA31540", Offset = "0xA30940", VA = "0x180A31540")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SpellCast(SpellCast other)
					{
					}

					[Token(Token = "0x6003C14")]
					[Address(RVA = "0xA31040", Offset = "0xA30440", VA = "0x180A31040", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public SpellCast Clone()
					{
						return null;
					}

					[Token(Token = "0x6003C1A")]
					[Address(RVA = "0xA311B0", Offset = "0xA305B0", VA = "0x180A311B0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6003C1B")]
					[Address(RVA = "0xA31110", Offset = "0xA30510", VA = "0x180A31110", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(SpellCast other)
					{
						return default(bool);
					}

					[Token(Token = "0x6003C1C")]
					[Address(RVA = "0x9C6C20", Offset = "0x9C6020", VA = "0x1809C6C20", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6003C1D")]
					[Address(RVA = "0xA31330", Offset = "0xA30730", VA = "0x180A31330", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6003C1E")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6003C1F")]
					[Address(RVA = "0xA31800", Offset = "0xA30C00", VA = "0x180A31800", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6003C20")]
					[Address(RVA = "0xA30F30", Offset = "0xA30330", VA = "0x180A30F30", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6003C21")]
					[Address(RVA = "0xA312A0", Offset = "0xA306A0", VA = "0x180A312A0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(SpellCast other)
					{
					}

					[Token(Token = "0x6003C22")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6003C23")]
					[Address(RVA = "0xA316B0", Offset = "0xA30AB0", VA = "0x180A316B0", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4001394")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<TargetedAbility> _parser;

			[Token(Token = "0x4001395")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001396")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x4001397")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4001398")]
			public const int DestinationCellFieldNumber = 2;

			[Token(Token = "0x4001399")]
			[FieldOffset(Offset = "0x20")]
			private int destinationCell_;

			[Token(Token = "0x400139A")]
			public const int CriticalFieldNumber = 3;

			[Token(Token = "0x400139B")]
			[FieldOffset(Offset = "0x24")]
			private FightSpellCastCritical critical_;

			[Token(Token = "0x400139C")]
			public const int SilentCastFieldNumber = 4;

			[Token(Token = "0x400139D")]
			[FieldOffset(Offset = "0x28")]
			private bool silentCast_;

			[Token(Token = "0x400139E")]
			public const int VerboseCastFieldNumber = 5;

			[Token(Token = "0x400139F")]
			[FieldOffset(Offset = "0x29")]
			private bool verboseCast_;

			[Token(Token = "0x40013A0")]
			public const int SpellCastFieldNumber = 6;

			[Token(Token = "0x40013A1")]
			public const int WeaponGenericIdFieldNumber = 7;

			[Token(Token = "0x40013A2")]
			[FieldOffset(Offset = "0x30")]
			private object fight_;

			[Token(Token = "0x40013A3")]
			[FieldOffset(Offset = "0x38")]
			private FightOneofCase fightCase_;

			[Token(Token = "0x17000CD3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<TargetedAbility> Parser
			{
				[Token(Token = "0x6003BEC")]
				[Address(RVA = "0xA38420", Offset = "0xA37820", VA = "0x180A38420")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CD4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003BED")]
				[Address(RVA = "0xA38390", Offset = "0xA37790", VA = "0x180A38390")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CD5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003BEE")]
				[Address(RVA = "0xA38900", Offset = "0xA37D00", VA = "0x180A38900", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CD6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003BF2")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003BF3")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CD7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int DestinationCell
			{
				[Token(Token = "0x6003BF4")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003BF5")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17000CD8")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightSpellCastCritical Critical
			{
				[Token(Token = "0x6003BF6")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(FightSpellCastCritical);
				}
				[Token(Token = "0x6003BF7")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x17000CD9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool SilentCast
			{
				[Token(Token = "0x6003BF8")]
				[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003BF9")]
				[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
				set
				{
				}
			}

			[Token(Token = "0x17000CDA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool VerboseCast
			{
				[Token(Token = "0x6003BFA")]
				[Address(RVA = "0x9A1B80", Offset = "0x9A0F80", VA = "0x1809A1B80")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003BFB")]
				[Address(RVA = "0x9A1E90", Offset = "0x9A1290", VA = "0x1809A1E90")]
				set
				{
				}
			}

			[Token(Token = "0x17000CDB")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.SpellCast SpellCast
			{
				[Token(Token = "0x6003BFC")]
				[Address(RVA = "0xA38470", Offset = "0xA37870", VA = "0x180A38470")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003BFD")]
				[Address(RVA = "0xA38940", Offset = "0xA37D40", VA = "0x180A38940")]
				set
				{
				}
			}

			[Token(Token = "0x17000CDC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int WeaponGenericId
			{
				[Token(Token = "0x6003BFE")]
				[Address(RVA = "0xA384D0", Offset = "0xA378D0", VA = "0x180A384D0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003BFF")]
				[Address(RVA = "0xA38980", Offset = "0xA37D80", VA = "0x180A38980")]
				set
				{
				}
			}

			[Token(Token = "0x17000CDD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasWeaponGenericId
			{
				[Token(Token = "0x6003C00")]
				[Address(RVA = "0xA38410", Offset = "0xA37810", VA = "0x180A38410")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000CDE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FightOneofCase FightCase
			{
				[Token(Token = "0x6003C02")]
				[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
				get
				{
					return default(FightOneofCase);
				}
			}

			[Token(Token = "0x6003BEF")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TargetedAbility()
			{
			}

			[Token(Token = "0x6003BF0")]
			[Address(RVA = "0xA381D0", Offset = "0xA375D0", VA = "0x180A381D0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TargetedAbility(TargetedAbility other)
			{
			}

			[Token(Token = "0x6003BF1")]
			[Address(RVA = "0xA379D0", Offset = "0xA36DD0", VA = "0x180A379D0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public TargetedAbility Clone()
			{
				return null;
			}

			[Token(Token = "0x6003C01")]
			[Address(RVA = "0xA379B0", Offset = "0xA36DB0", VA = "0x180A379B0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearWeaponGenericId()
			{
			}

			[Token(Token = "0x6003C03")]
			[Address(RVA = "0xA37990", Offset = "0xA36D90", VA = "0x180A37990")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearFight()
			{
			}

			[Token(Token = "0x6003C04")]
			[Address(RVA = "0xA37B20", Offset = "0xA36F20", VA = "0x180A37B20", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C05")]
			[Address(RVA = "0xA37A30", Offset = "0xA36E30", VA = "0x180A37A30", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(TargetedAbility other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C06")]
			[Address(RVA = "0xA37C50", Offset = "0xA37050", VA = "0x180A37C50", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003C07")]
			[Address(RVA = "0xA38070", Offset = "0xA37470", VA = "0x180A38070", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003C08")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003C09")]
			[Address(RVA = "0xA38730", Offset = "0xA37B30", VA = "0x180A38730", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003C0A")]
			[Address(RVA = "0xA377B0", Offset = "0xA36BB0", VA = "0x180A377B0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003C0B")]
			[Address(RVA = "0xA37E50", Offset = "0xA37250", VA = "0x180A37E50", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(TargetedAbility other)
			{
			}

			[Token(Token = "0x6003C0C")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003C0D")]
			[Address(RVA = "0xA38540", Offset = "0xA37940", VA = "0x180A38540", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005A5")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Vanish : IMessage<Vanish>, IMessage, IEquatable<Vanish>, IDeepCloneable<Vanish>, IBufferMessage
		{
			[Token(Token = "0x40013B3")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Vanish> _parser;

			[Token(Token = "0x40013B4")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013B5")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013B6")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x17000CE5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Vanish> Parser
			{
				[Token(Token = "0x6003C2B")]
				[Address(RVA = "0xA3AEC0", Offset = "0xA3A2C0", VA = "0x180A3AEC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CE6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003C2C")]
				[Address(RVA = "0xA3AE40", Offset = "0xA3A240", VA = "0x180A3AE40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CE7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003C2D")]
				[Address(RVA = "0xA3AF10", Offset = "0xA3A310", VA = "0x180A3AF10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CE8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003C31")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003C32")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x6003C2E")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Vanish()
			{
			}

			[Token(Token = "0x6003C2F")]
			[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Vanish(Vanish other)
			{
			}

			[Token(Token = "0x6003C30")]
			[Address(RVA = "0xA3ABD0", Offset = "0xA39FD0", VA = "0x180A3ABD0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Vanish Clone()
			{
				return null;
			}

			[Token(Token = "0x6003C33")]
			[Address(RVA = "0xA3AC50", Offset = "0xA3A050", VA = "0x180A3AC50", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C34")]
			[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Vanish other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C35")]
			[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003C36")]
			[Address(RVA = "0xA3ACE0", Offset = "0xA3A0E0", VA = "0x180A3ACE0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003C37")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003C38")]
			[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003C39")]
			[Address(RVA = "0xA3AB40", Offset = "0xA39F40", VA = "0x180A3AB40", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003C3A")]
			[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Vanish other)
			{
			}

			[Token(Token = "0x6003C3B")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003C3C")]
			[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005A7")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Kill : IMessage<Kill>, IMessage, IEquatable<Kill>, IDeepCloneable<Kill>, IBufferMessage
		{
			[Token(Token = "0x40013B8")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Kill> _parser;

			[Token(Token = "0x40013B9")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013BA")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013BB")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x17000CE9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Kill> Parser
			{
				[Token(Token = "0x6003C41")]
				[Address(RVA = "0xA2C710", Offset = "0xA2BB10", VA = "0x180A2C710")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CEA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003C42")]
				[Address(RVA = "0xA2C690", Offset = "0xA2BA90", VA = "0x180A2C690")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CEB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003C43")]
				[Address(RVA = "0xA2C760", Offset = "0xA2BB60", VA = "0x180A2C760", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CEC")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003C47")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003C48")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x6003C44")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Kill()
			{
			}

			[Token(Token = "0x6003C45")]
			[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Kill(Kill other)
			{
			}

			[Token(Token = "0x6003C46")]
			[Address(RVA = "0xA2C420", Offset = "0xA2B820", VA = "0x180A2C420", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Kill Clone()
			{
				return null;
			}

			[Token(Token = "0x6003C49")]
			[Address(RVA = "0xA2C4A0", Offset = "0xA2B8A0", VA = "0x180A2C4A0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C4A")]
			[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Kill other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C4B")]
			[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003C4C")]
			[Address(RVA = "0xA2C530", Offset = "0xA2B930", VA = "0x180A2C530", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003C4D")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003C4E")]
			[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003C4F")]
			[Address(RVA = "0xA2C390", Offset = "0xA2B790", VA = "0x180A2C390", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003C50")]
			[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Kill other)
			{
			}

			[Token(Token = "0x6003C51")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003C52")]
			[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005A9")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Death : IMessage<Death>, IMessage, IEquatable<Death>, IDeepCloneable<Death>, IBufferMessage
		{
			[Token(Token = "0x40013BD")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Death> _parser;

			[Token(Token = "0x40013BE")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013BF")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013C0")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x17000CED")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Death> Parser
			{
				[Token(Token = "0x6003C57")]
				[Address(RVA = "0xA28A20", Offset = "0xA27E20", VA = "0x180A28A20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CEE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003C58")]
				[Address(RVA = "0xA289A0", Offset = "0xA27DA0", VA = "0x180A289A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CEF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003C59")]
				[Address(RVA = "0xA28A70", Offset = "0xA27E70", VA = "0x180A28A70", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003C5D")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003C5E")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x6003C5A")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Death()
			{
			}

			[Token(Token = "0x6003C5B")]
			[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Death(Death other)
			{
			}

			[Token(Token = "0x6003C5C")]
			[Address(RVA = "0xA28730", Offset = "0xA27B30", VA = "0x180A28730", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Death Clone()
			{
				return null;
			}

			[Token(Token = "0x6003C5F")]
			[Address(RVA = "0xA287B0", Offset = "0xA27BB0", VA = "0x180A287B0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C60")]
			[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Death other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C61")]
			[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003C62")]
			[Address(RVA = "0xA28840", Offset = "0xA27C40", VA = "0x180A28840", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003C63")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003C64")]
			[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003C65")]
			[Address(RVA = "0xA286A0", Offset = "0xA27AA0", VA = "0x180A286A0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003C66")]
			[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Death other)
			{
			}

			[Token(Token = "0x6003C67")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003C68")]
			[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005AB")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SpellImmunity : IMessage<SpellImmunity>, IMessage, IEquatable<SpellImmunity>, IDeepCloneable<SpellImmunity>, IBufferMessage
		{
			[Token(Token = "0x40013C2")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SpellImmunity> _parser;

			[Token(Token = "0x40013C3")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013C4")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013C5")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x40013C6")]
			public const int SpellIdFieldNumber = 2;

			[Token(Token = "0x40013C7")]
			[FieldOffset(Offset = "0x20")]
			private int spellId_;

			[Token(Token = "0x17000CF1")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SpellImmunity> Parser
			{
				[Token(Token = "0x6003C6D")]
				[Address(RVA = "0xA32260", Offset = "0xA31660", VA = "0x180A32260")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003C6E")]
				[Address(RVA = "0xA321E0", Offset = "0xA315E0", VA = "0x180A321E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003C6F")]
				[Address(RVA = "0xA322B0", Offset = "0xA316B0", VA = "0x180A322B0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003C73")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003C74")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CF5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SpellId
			{
				[Token(Token = "0x6003C75")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003C76")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003C70")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SpellImmunity()
			{
			}

			[Token(Token = "0x6003C71")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SpellImmunity(SpellImmunity other)
			{
			}

			[Token(Token = "0x6003C72")]
			[Address(RVA = "0xA31F50", Offset = "0xA31350", VA = "0x180A31F50", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SpellImmunity Clone()
			{
				return null;
			}

			[Token(Token = "0x6003C77")]
			[Address(RVA = "0xA31FE0", Offset = "0xA313E0", VA = "0x180A31FE0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C78")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SpellImmunity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C79")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003C7A")]
			[Address(RVA = "0xA32080", Offset = "0xA31480", VA = "0x180A32080", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003C7B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003C7C")]
			[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003C7D")]
			[Address(RVA = "0xA31E90", Offset = "0xA31290", VA = "0x180A31E90", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003C7E")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SpellImmunity other)
			{
			}

			[Token(Token = "0x6003C7F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003C80")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005AD")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SpellCoolDownVariation : IMessage<SpellCoolDownVariation>, IMessage, IEquatable<SpellCoolDownVariation>, IDeepCloneable<SpellCoolDownVariation>, IBufferMessage
		{
			[Token(Token = "0x40013C9")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SpellCoolDownVariation> _parser;

			[Token(Token = "0x40013CA")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013CB")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013CC")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x40013CD")]
			public const int SpellIdFieldNumber = 2;

			[Token(Token = "0x40013CE")]
			[FieldOffset(Offset = "0x20")]
			private int spellId_;

			[Token(Token = "0x40013CF")]
			public const int ValueFieldNumber = 3;

			[Token(Token = "0x40013D0")]
			[FieldOffset(Offset = "0x24")]
			private int value_;

			[Token(Token = "0x17000CF6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SpellCoolDownVariation> Parser
			{
				[Token(Token = "0x6003C85")]
				[Address(RVA = "0xA31D90", Offset = "0xA31190", VA = "0x180A31D90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003C86")]
				[Address(RVA = "0xA31D10", Offset = "0xA31110", VA = "0x180A31D10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003C87")]
				[Address(RVA = "0xA31DE0", Offset = "0xA311E0", VA = "0x180A31DE0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CF9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003C8B")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003C8C")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000CFA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SpellId
			{
				[Token(Token = "0x6003C8D")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003C8E")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17000CFB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Value
			{
				[Token(Token = "0x6003C8F")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003C90")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x6003C88")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SpellCoolDownVariation()
			{
			}

			[Token(Token = "0x6003C89")]
			[Address(RVA = "0x9D5350", Offset = "0x9D4750", VA = "0x1809D5350")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SpellCoolDownVariation(SpellCoolDownVariation other)
			{
			}

			[Token(Token = "0x6003C8A")]
			[Address(RVA = "0xA31A80", Offset = "0xA30E80", VA = "0x180A31A80", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SpellCoolDownVariation Clone()
			{
				return null;
			}

			[Token(Token = "0x6003C91")]
			[Address(RVA = "0xA31B10", Offset = "0xA30F10", VA = "0x180A31B10", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C92")]
			[Address(RVA = "0x9D4FF0", Offset = "0x9D43F0", VA = "0x1809D4FF0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SpellCoolDownVariation other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003C93")]
			[Address(RVA = "0x9D50D0", Offset = "0x9D44D0", VA = "0x1809D50D0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003C94")]
			[Address(RVA = "0xA31BB0", Offset = "0xA30FB0", VA = "0x180A31BB0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003C95")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003C96")]
			[Address(RVA = "0x9D5580", Offset = "0x9D4980", VA = "0x1809D5580", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003C97")]
			[Address(RVA = "0xA319A0", Offset = "0xA30DA0", VA = "0x180A319A0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003C98")]
			[Address(RVA = "0x9D5180", Offset = "0x9D4580", VA = "0x1809D5180", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SpellCoolDownVariation other)
			{
			}

			[Token(Token = "0x6003C99")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003C9A")]
			[Address(RVA = "0x9D54B0", Offset = "0x9D48B0", VA = "0x1809D54B0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005AF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class LifePointsLost : IMessage<LifePointsLost>, IMessage, IEquatable<LifePointsLost>, IDeepCloneable<LifePointsLost>, IBufferMessage
		{
			[Token(Token = "0x40013D2")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<LifePointsLost> _parser;

			[Token(Token = "0x40013D3")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013D4")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x40013D5")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013D6")]
			[FieldOffset(Offset = "0x20")]
			private long targetId_;

			[Token(Token = "0x40013D7")]
			public const int LossFieldNumber = 2;

			[Token(Token = "0x40013D8")]
			[FieldOffset(Offset = "0x28")]
			private int loss_;

			[Token(Token = "0x40013D9")]
			public const int PermanentDamagesFieldNumber = 3;

			[Token(Token = "0x40013DA")]
			[FieldOffset(Offset = "0x2C")]
			private int permanentDamages_;

			[Token(Token = "0x40013DB")]
			public const int ElementIdFieldNumber = 4;

			[Token(Token = "0x40013DC")]
			[FieldOffset(Offset = "0x30")]
			private int elementId_;

			[Token(Token = "0x40013DD")]
			public const int ShieldLossFieldNumber = 5;

			[Token(Token = "0x40013DE")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int ShieldLossDefaultValue;

			[Token(Token = "0x40013DF")]
			[FieldOffset(Offset = "0x34")]
			private int shieldLoss_;

			[Token(Token = "0x17000CFC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<LifePointsLost> Parser
			{
				[Token(Token = "0x6003C9F")]
				[Address(RVA = "0xA2D4B0", Offset = "0xA2C8B0", VA = "0x180A2D4B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CFD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003CA0")]
				[Address(RVA = "0xA2D430", Offset = "0xA2C830", VA = "0x180A2D430")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CFE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003CA1")]
				[Address(RVA = "0xA2D7C0", Offset = "0xA2CBC0", VA = "0x180A2D7C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000CFF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003CA5")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003CA6")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x17000D00")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Loss
			{
				[Token(Token = "0x6003CA7")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003CA8")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x17000D01")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int PermanentDamages
			{
				[Token(Token = "0x6003CA9")]
				[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003CAA")]
				[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
				set
				{
				}
			}

			[Token(Token = "0x17000D02")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ElementId
			{
				[Token(Token = "0x6003CAB")]
				[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003CAC")]
				[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
				set
				{
				}
			}

			[Token(Token = "0x17000D03")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ShieldLoss
			{
				[Token(Token = "0x6003CAD")]
				[Address(RVA = "0xA2D500", Offset = "0xA2C900", VA = "0x180A2D500")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003CAE")]
				[Address(RVA = "0xA2D870", Offset = "0xA2CC70", VA = "0x180A2D870")]
				set
				{
				}
			}

			[Token(Token = "0x17000D04")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool HasShieldLoss
			{
				[Token(Token = "0x6003CAF")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6003CA2")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public LifePointsLost()
			{
			}

			[Token(Token = "0x6003CA3")]
			[Address(RVA = "0xA2D3C0", Offset = "0xA2C7C0", VA = "0x180A2D3C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public LifePointsLost(LifePointsLost other)
			{
			}

			[Token(Token = "0x6003CA4")]
			[Address(RVA = "0xA2CE70", Offset = "0xA2C270", VA = "0x180A2CE70", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public LifePointsLost Clone()
			{
				return null;
			}

			[Token(Token = "0x6003CB0")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearShieldLoss()
			{
			}

			[Token(Token = "0x6003CB1")]
			[Address(RVA = "0xA2CF10", Offset = "0xA2C310", VA = "0x180A2CF10", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003CB2")]
			[Address(RVA = "0xA2CFF0", Offset = "0xA2C3F0", VA = "0x180A2CFF0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(LifePointsLost other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003CB3")]
			[Address(RVA = "0xA2D090", Offset = "0xA2C490", VA = "0x180A2D090", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003CB4")]
			[Address(RVA = "0xA2D250", Offset = "0xA2C650", VA = "0x180A2D250", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003CB5")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003CB6")]
			[Address(RVA = "0xA2D690", Offset = "0xA2CA90", VA = "0x180A2D690", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003CB7")]
			[Address(RVA = "0xA2CCE0", Offset = "0xA2C0E0", VA = "0x180A2CCE0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003CB8")]
			[Address(RVA = "0xA2D1C0", Offset = "0xA2C5C0", VA = "0x180A2D1C0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(LifePointsLost other)
			{
			}

			[Token(Token = "0x6003CB9")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003CBA")]
			[Address(RVA = "0xA2D570", Offset = "0xA2C970", VA = "0x180A2D570", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005B1")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class LifePointsGain : IMessage<LifePointsGain>, IMessage, IEquatable<LifePointsGain>, IDeepCloneable<LifePointsGain>, IBufferMessage
		{
			[Token(Token = "0x40013E1")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<LifePointsGain> _parser;

			[Token(Token = "0x40013E2")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013E3")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013E4")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x40013E5")]
			public const int DeltaFieldNumber = 2;

			[Token(Token = "0x40013E6")]
			[FieldOffset(Offset = "0x20")]
			private int delta_;

			[Token(Token = "0x17000D05")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<LifePointsGain> Parser
			{
				[Token(Token = "0x6003CBF")]
				[Address(RVA = "0xA2CBE0", Offset = "0xA2BFE0", VA = "0x180A2CBE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D06")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003CC0")]
				[Address(RVA = "0xA2CB60", Offset = "0xA2BF60", VA = "0x180A2CB60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D07")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003CC1")]
				[Address(RVA = "0xA2CC30", Offset = "0xA2C030", VA = "0x180A2CC30", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D08")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003CC5")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003CC6")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000D09")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Delta
			{
				[Token(Token = "0x6003CC7")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003CC8")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003CC2")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public LifePointsGain()
			{
			}

			[Token(Token = "0x6003CC3")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public LifePointsGain(LifePointsGain other)
			{
			}

			[Token(Token = "0x6003CC4")]
			[Address(RVA = "0xA2C8D0", Offset = "0xA2BCD0", VA = "0x180A2C8D0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public LifePointsGain Clone()
			{
				return null;
			}

			[Token(Token = "0x6003CC9")]
			[Address(RVA = "0xA2C960", Offset = "0xA2BD60", VA = "0x180A2C960", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003CCA")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(LifePointsGain other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003CCB")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003CCC")]
			[Address(RVA = "0xA2CA00", Offset = "0xA2BE00", VA = "0x180A2CA00", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003CCD")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003CCE")]
			[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003CCF")]
			[Address(RVA = "0xA2C810", Offset = "0xA2BC10", VA = "0x180A2C810", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003CD0")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(LifePointsGain other)
			{
			}

			[Token(Token = "0x6003CD1")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003CD2")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005B3")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class RemovableEffect : IMessage<RemovableEffect>, IMessage, IEquatable<RemovableEffect>, IDeepCloneable<RemovableEffect>, IBufferMessage
		{
			[Token(Token = "0x40013E8")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<RemovableEffect> _parser;

			[Token(Token = "0x40013E9")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013EA")]
			public const int EffectFieldNumber = 1;

			[Token(Token = "0x40013EB")]
			[FieldOffset(Offset = "0x18")]
			private FightRemovableEffect effect_;

			[Token(Token = "0x17000D0A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<RemovableEffect> Parser
			{
				[Token(Token = "0x6003CD7")]
				[Address(RVA = "0xA2FBF0", Offset = "0xA2EFF0", VA = "0x180A2FBF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D0B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003CD8")]
				[Address(RVA = "0xA2FB70", Offset = "0xA2EF70", VA = "0x180A2FB70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D0C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003CD9")]
				[Address(RVA = "0xA2FD40", Offset = "0xA2F140", VA = "0x180A2FD40", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D0D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FightRemovableEffect Effect
			{
				[Token(Token = "0x6003CDD")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003CDE")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x6003CDA")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RemovableEffect()
			{
			}

			[Token(Token = "0x6003CDB")]
			[Address(RVA = "0xA2FB00", Offset = "0xA2EF00", VA = "0x180A2FB00")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RemovableEffect(RemovableEffect other)
			{
			}

			[Token(Token = "0x6003CDC")]
			[Address(RVA = "0xA2F780", Offset = "0xA2EB80", VA = "0x180A2F780", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RemovableEffect Clone()
			{
				return null;
			}

			[Token(Token = "0x6003CDF")]
			[Address(RVA = "0xA2F820", Offset = "0xA2EC20", VA = "0x180A2F820", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003CE0")]
			[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(RemovableEffect other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003CE1")]
			[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003CE2")]
			[Address(RVA = "0xA2F9A0", Offset = "0xA2EDA0", VA = "0x180A2F9A0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003CE3")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003CE4")]
			[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003CE5")]
			[Address(RVA = "0xA2F6F0", Offset = "0xA2EAF0", VA = "0x180A2F6F0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003CE6")]
			[Address(RVA = "0xA2F8D0", Offset = "0xA2ECD0", VA = "0x180A2F8D0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(RemovableEffect other)
			{
			}

			[Token(Token = "0x6003CE7")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003CE8")]
			[Address(RVA = "0xA2FC40", Offset = "0xA2F040", VA = "0x180A2FC40", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005B5")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Slide : IMessage<Slide>, IMessage, IEquatable<Slide>, IDeepCloneable<Slide>, IBufferMessage
		{
			[Token(Token = "0x40013ED")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Slide> _parser;

			[Token(Token = "0x40013EE")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013EF")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013F0")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x40013F1")]
			public const int StartCellFieldNumber = 2;

			[Token(Token = "0x40013F2")]
			[FieldOffset(Offset = "0x20")]
			private int startCell_;

			[Token(Token = "0x40013F3")]
			public const int EndCellFieldNumber = 3;

			[Token(Token = "0x40013F4")]
			[FieldOffset(Offset = "0x24")]
			private int endCell_;

			[Token(Token = "0x17000D0E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Slide> Parser
			{
				[Token(Token = "0x6003CED")]
				[Address(RVA = "0xA30E30", Offset = "0xA30230", VA = "0x180A30E30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D0F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003CEE")]
				[Address(RVA = "0xA30DB0", Offset = "0xA301B0", VA = "0x180A30DB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003CEF")]
				[Address(RVA = "0xA30E80", Offset = "0xA30280", VA = "0x180A30E80", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003CF3")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003CF4")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000D12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int StartCell
			{
				[Token(Token = "0x6003CF5")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003CF6")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x17000D13")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int EndCell
			{
				[Token(Token = "0x6003CF7")]
				[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003CF8")]
				[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
				set
				{
				}
			}

			[Token(Token = "0x6003CF0")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Slide()
			{
			}

			[Token(Token = "0x6003CF1")]
			[Address(RVA = "0x9D5350", Offset = "0x9D4750", VA = "0x1809D5350")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Slide(Slide other)
			{
			}

			[Token(Token = "0x6003CF2")]
			[Address(RVA = "0xA30B20", Offset = "0xA2FF20", VA = "0x180A30B20", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Slide Clone()
			{
				return null;
			}

			[Token(Token = "0x6003CF9")]
			[Address(RVA = "0xA30BB0", Offset = "0xA2FFB0", VA = "0x180A30BB0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003CFA")]
			[Address(RVA = "0x9D4FF0", Offset = "0x9D43F0", VA = "0x1809D4FF0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Slide other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003CFB")]
			[Address(RVA = "0x9D50D0", Offset = "0x9D44D0", VA = "0x1809D50D0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003CFC")]
			[Address(RVA = "0xA30C50", Offset = "0xA30050", VA = "0x180A30C50", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003CFD")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003CFE")]
			[Address(RVA = "0x9D5580", Offset = "0x9D4980", VA = "0x1809D5580", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003CFF")]
			[Address(RVA = "0xA30A40", Offset = "0xA2FE40", VA = "0x180A30A40", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003D00")]
			[Address(RVA = "0x9D5180", Offset = "0x9D4580", VA = "0x1809D5180", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Slide other)
			{
			}

			[Token(Token = "0x6003D01")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003D02")]
			[Address(RVA = "0x9D54B0", Offset = "0x9D48B0", VA = "0x1809D54B0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005B7")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class DodgePointLoss : IMessage<DodgePointLoss>, IMessage, IEquatable<DodgePointLoss>, IDeepCloneable<DodgePointLoss>, IBufferMessage
		{
			[Token(Token = "0x40013F6")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<DodgePointLoss> _parser;

			[Token(Token = "0x40013F7")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013F8")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x40013F9")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x40013FA")]
			public const int AmountFieldNumber = 2;

			[Token(Token = "0x40013FB")]
			[FieldOffset(Offset = "0x20")]
			private int amount_;

			[Token(Token = "0x17000D14")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<DodgePointLoss> Parser
			{
				[Token(Token = "0x6003D07")]
				[Address(RVA = "0xA28EF0", Offset = "0xA282F0", VA = "0x180A28EF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D15")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003D08")]
				[Address(RVA = "0xA28E70", Offset = "0xA28270", VA = "0x180A28E70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D16")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003D09")]
				[Address(RVA = "0xA28F40", Offset = "0xA28340", VA = "0x180A28F40", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D17")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003D0D")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003D0E")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000D18")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Amount
			{
				[Token(Token = "0x6003D0F")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003D10")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003D0A")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public DodgePointLoss()
			{
			}

			[Token(Token = "0x6003D0B")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DodgePointLoss(DodgePointLoss other)
			{
			}

			[Token(Token = "0x6003D0C")]
			[Address(RVA = "0xA28BE0", Offset = "0xA27FE0", VA = "0x180A28BE0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public DodgePointLoss Clone()
			{
				return null;
			}

			[Token(Token = "0x6003D11")]
			[Address(RVA = "0xA28C70", Offset = "0xA28070", VA = "0x180A28C70", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D12")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(DodgePointLoss other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D13")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003D14")]
			[Address(RVA = "0xA28D10", Offset = "0xA28110", VA = "0x180A28D10", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003D15")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003D16")]
			[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003D17")]
			[Address(RVA = "0xA28B20", Offset = "0xA27F20", VA = "0x180A28B20", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003D18")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(DodgePointLoss other)
			{
			}

			[Token(Token = "0x6003D19")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003D1A")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005B9")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ReflectDamages : IMessage<ReflectDamages>, IMessage, IEquatable<ReflectDamages>, IDeepCloneable<ReflectDamages>, IBufferMessage
		{
			[Token(Token = "0x40013FD")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ReflectDamages> _parser;

			[Token(Token = "0x40013FE")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40013FF")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x4001400")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x17000D19")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ReflectDamages> Parser
			{
				[Token(Token = "0x6003D1F")]
				[Address(RVA = "0xA2F170", Offset = "0xA2E570", VA = "0x180A2F170")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D1A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003D20")]
				[Address(RVA = "0xA2F0F0", Offset = "0xA2E4F0", VA = "0x180A2F0F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D1B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003D21")]
				[Address(RVA = "0xA2F1C0", Offset = "0xA2E5C0", VA = "0x180A2F1C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D1C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long TargetId
			{
				[Token(Token = "0x6003D25")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003D26")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x6003D22")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReflectDamages()
			{
			}

			[Token(Token = "0x6003D23")]
			[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReflectDamages(ReflectDamages other)
			{
			}

			[Token(Token = "0x6003D24")]
			[Address(RVA = "0xA2EE80", Offset = "0xA2E280", VA = "0x180A2EE80", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReflectDamages Clone()
			{
				return null;
			}

			[Token(Token = "0x6003D27")]
			[Address(RVA = "0xA2EF00", Offset = "0xA2E300", VA = "0x180A2EF00", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D28")]
			[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ReflectDamages other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D29")]
			[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003D2A")]
			[Address(RVA = "0xA2EF90", Offset = "0xA2E390", VA = "0x180A2EF90", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003D2B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003D2C")]
			[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003D2D")]
			[Address(RVA = "0xA2EDF0", Offset = "0xA2E1F0", VA = "0x180A2EDF0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003D2E")]
			[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ReflectDamages other)
			{
			}

			[Token(Token = "0x6003D2F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003D30")]
			[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005BB")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ReduceDamages : IMessage<ReduceDamages>, IMessage, IEquatable<ReduceDamages>, IDeepCloneable<ReduceDamages>, IBufferMessage
		{
			[Token(Token = "0x4001402")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ReduceDamages> _parser;

			[Token(Token = "0x4001403")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001404")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x4001405")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x4001406")]
			public const int AmountFieldNumber = 2;

			[Token(Token = "0x4001407")]
			[FieldOffset(Offset = "0x20")]
			private int amount_;

			[Token(Token = "0x17000D1D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ReduceDamages> Parser
			{
				[Token(Token = "0x6003D35")]
				[Address(RVA = "0xA2ECF0", Offset = "0xA2E0F0", VA = "0x180A2ECF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D1E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003D36")]
				[Address(RVA = "0xA2EC70", Offset = "0xA2E070", VA = "0x180A2EC70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D1F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003D37")]
				[Address(RVA = "0xA2ED40", Offset = "0xA2E140", VA = "0x180A2ED40", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D20")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003D3B")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003D3C")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000D21")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Amount
			{
				[Token(Token = "0x6003D3D")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003D3E")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003D38")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReduceDamages()
			{
			}

			[Token(Token = "0x6003D39")]
			[Address(RVA = "0x948CF0", Offset = "0x9480F0", VA = "0x180948CF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReduceDamages(ReduceDamages other)
			{
			}

			[Token(Token = "0x6003D3A")]
			[Address(RVA = "0xA2E9E0", Offset = "0xA2DDE0", VA = "0x180A2E9E0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReduceDamages Clone()
			{
				return null;
			}

			[Token(Token = "0x6003D3F")]
			[Address(RVA = "0xA2EA70", Offset = "0xA2DE70", VA = "0x180A2EA70", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D40")]
			[Address(RVA = "0x9489C0", Offset = "0x947DC0", VA = "0x1809489C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ReduceDamages other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D41")]
			[Address(RVA = "0x948AA0", Offset = "0x947EA0", VA = "0x180948AA0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003D42")]
			[Address(RVA = "0xA2EB10", Offset = "0xA2DF10", VA = "0x180A2EB10", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003D43")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003D44")]
			[Address(RVA = "0x9E9520", Offset = "0x9E8920", VA = "0x1809E9520", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003D45")]
			[Address(RVA = "0xA2E920", Offset = "0xA2DD20", VA = "0x180A2E920", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003D46")]
			[Address(RVA = "0x948B30", Offset = "0x947F30", VA = "0x180948B30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ReduceDamages other)
			{
			}

			[Token(Token = "0x6003D47")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003D48")]
			[Address(RVA = "0x948E20", Offset = "0x948220", VA = "0x180948E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005BD")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ReflectSpell : IMessage<ReflectSpell>, IMessage, IEquatable<ReflectSpell>, IDeepCloneable<ReflectSpell>, IBufferMessage
		{
			[Token(Token = "0x4001409")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ReflectSpell> _parser;

			[Token(Token = "0x400140A")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400140B")]
			public const int TargetIdFieldNumber = 1;

			[Token(Token = "0x400140C")]
			[FieldOffset(Offset = "0x18")]
			private long targetId_;

			[Token(Token = "0x17000D22")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<ReflectSpell> Parser
			{
				[Token(Token = "0x6003D4D")]
				[Address(RVA = "0xA2F5F0", Offset = "0xA2E9F0", VA = "0x180A2F5F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D23")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003D4E")]
				[Address(RVA = "0xA2F570", Offset = "0xA2E970", VA = "0x180A2F570")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D24")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003D4F")]
				[Address(RVA = "0xA2F640", Offset = "0xA2EA40", VA = "0x180A2F640", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D25")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetId
			{
				[Token(Token = "0x6003D53")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003D54")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x6003D50")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReflectSpell()
			{
			}

			[Token(Token = "0x6003D51")]
			[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReflectSpell(ReflectSpell other)
			{
			}

			[Token(Token = "0x6003D52")]
			[Address(RVA = "0xA2F300", Offset = "0xA2E700", VA = "0x180A2F300", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ReflectSpell Clone()
			{
				return null;
			}

			[Token(Token = "0x6003D55")]
			[Address(RVA = "0xA2F380", Offset = "0xA2E780", VA = "0x180A2F380", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D56")]
			[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(ReflectSpell other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003D57")]
			[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003D58")]
			[Address(RVA = "0xA2F410", Offset = "0xA2E810", VA = "0x180A2F410", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003D59")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003D5A")]
			[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003D5B")]
			[Address(RVA = "0xA2F270", Offset = "0xA2E670", VA = "0x180A2F270", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003D5C")]
			[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(ReflectSpell other)
			{
			}

			[Token(Token = "0x6003D5D")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003D5E")]
			[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionFightEvent> _parser;

	[Token(Token = "0x4001292")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001293")]
	public const int ActionIdFieldNumber = 1;

	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x18")]
	private int actionId_;

	[Token(Token = "0x4001295")]
	public const int SourceIdFieldNumber = 2;

	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0x20")]
	private long sourceId_;

	[Token(Token = "0x4001297")]
	public const int SlideFieldNumber = 3;

	[Token(Token = "0x4001298")]
	public const int DodgePointLossFieldNumber = 4;

	[Token(Token = "0x4001299")]
	public const int ReflectDamagesFieldNumber = 5;

	[Token(Token = "0x400129A")]
	public const int ReduceDamagesFieldNumber = 6;

	[Token(Token = "0x400129B")]
	public const int ReflectSpellFieldNumber = 7;

	[Token(Token = "0x400129C")]
	public const int RemovableEffectFieldNumber = 8;

	[Token(Token = "0x400129D")]
	public const int LifePointsLostFieldNumber = 9;

	[Token(Token = "0x400129E")]
	public const int LifePointsGainFieldNumber = 10;

	[Token(Token = "0x400129F")]
	public const int SpellImmunityFieldNumber = 11;

	[Token(Token = "0x40012A0")]
	public const int SpellCoolDownVariationFieldNumber = 12;

	[Token(Token = "0x40012A1")]
	public const int VanishFieldNumber = 13;

	[Token(Token = "0x40012A2")]
	public const int KillFieldNumber = 14;

	[Token(Token = "0x40012A3")]
	public const int DeathFieldNumber = 15;

	[Token(Token = "0x40012A4")]
	public const int TargetedAbilityFieldNumber = 16;

	[Token(Token = "0x40012A5")]
	public const int TackledFieldNumber = 17;

	[Token(Token = "0x40012A6")]
	public const int PointsVariationFieldNumber = 18;

	[Token(Token = "0x40012A7")]
	public const int InvisibleDetectedFieldNumber = 19;

	[Token(Token = "0x40012A8")]
	public const int TeleportOnSameMapFieldNumber = 20;

	[Token(Token = "0x40012A9")]
	public const int ExchangePositionsFieldNumber = 21;

	[Token(Token = "0x40012AA")]
	public const int SpellRemoveFieldNumber = 22;

	[Token(Token = "0x40012AB")]
	public const int ModifyEffectsDurationFieldNumber = 23;

	[Token(Token = "0x40012AC")]
	public const int StealKamaFieldNumber = 24;

	[Token(Token = "0x40012AD")]
	public const int ChangeLookFieldNumber = 25;

	[Token(Token = "0x40012AE")]
	public const int InvisibilityFieldNumber = 26;

	[Token(Token = "0x40012AF")]
	public const int SummonsFieldNumber = 27;

	[Token(Token = "0x40012B0")]
	public const int MarkCellsFieldNumber = 28;

	[Token(Token = "0x40012B1")]
	public const int UnmarkCellsFieldNumber = 29;

	[Token(Token = "0x40012B2")]
	public const int TriggerGlyphTrapFieldNumber = 30;

	[Token(Token = "0x40012B3")]
	public const int ActivateGlyphTrapFieldNumber = 31;

	[Token(Token = "0x40012B4")]
	public const int CarryCharacterFieldNumber = 32;

	[Token(Token = "0x40012B5")]
	public const int ThrowCharacterFieldNumber = 33;

	[Token(Token = "0x40012B6")]
	public const int DropCharacterFieldNumber = 34;

	[Token(Token = "0x40012B7")]
	public const int ExecuteScriptFieldNumber = 35;

	[Token(Token = "0x40012B8")]
	[FieldOffset(Offset = "0x28")]
	private object action_;

	[Token(Token = "0x40012B9")]
	[FieldOffset(Offset = "0x30")]
	private ActionOneofCase actionCase_;

	[Token(Token = "0x17000C31")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameActionFightEvent> Parser
	{
		[Token(Token = "0x600395F")]
		[Address(RVA = "0xA180C0", Offset = "0xA174C0", VA = "0x180A180C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C32")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003960")]
		[Address(RVA = "0xA17BF0", Offset = "0xA16FF0", VA = "0x180A17BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C33")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003961")]
		[Address(RVA = "0xA1A9B0", Offset = "0xA19DB0", VA = "0x180A1A9B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C34")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ActionId
	{
		[Token(Token = "0x6003965")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003966")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000C35")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long SourceId
	{
		[Token(Token = "0x6003967")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003968")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C36")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Slide Slide
	{
		[Token(Token = "0x6003969")]
		[Address(RVA = "0xA182F0", Offset = "0xA176F0", VA = "0x180A182F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600396A")]
		[Address(RVA = "0x91BB80", Offset = "0x91AF80", VA = "0x18091BB80")]
		set
		{
		}
	}

	[Token(Token = "0x17000C37")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.DodgePointLoss DodgePointLoss
	{
		[Token(Token = "0x600396B")]
		[Address(RVA = "0xA17CA0", Offset = "0xA170A0", VA = "0x180A17CA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x91BB40", Offset = "0x91AF40", VA = "0x18091BB40")]
		set
		{
		}
	}

	[Token(Token = "0x17000C38")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ReflectDamages ReflectDamages
	{
		[Token(Token = "0x600396D")]
		[Address(RVA = "0xA181D0", Offset = "0xA175D0", VA = "0x180A181D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600396E")]
		[Address(RVA = "0x9FA5D0", Offset = "0x9F99D0", VA = "0x1809FA5D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C39")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ReduceDamages ReduceDamages
	{
		[Token(Token = "0x600396F")]
		[Address(RVA = "0xA18170", Offset = "0xA17570", VA = "0x180A18170")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003970")]
		[Address(RVA = "0xA1ADB0", Offset = "0xA1A1B0", VA = "0x180A1ADB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C3A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ReflectSpell ReflectSpell
	{
		[Token(Token = "0x6003971")]
		[Address(RVA = "0xA18230", Offset = "0xA17630", VA = "0x180A18230")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003972")]
		[Address(RVA = "0xA1ADF0", Offset = "0xA1A1F0", VA = "0x180A1ADF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C3B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.RemovableEffect RemovableEffect
	{
		[Token(Token = "0x6003973")]
		[Address(RVA = "0xA18290", Offset = "0xA17690", VA = "0x180A18290")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003974")]
		[Address(RVA = "0xA1AE30", Offset = "0xA1A230", VA = "0x180A1AE30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C3C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.LifePointsLost LifePointsLost
	{
		[Token(Token = "0x6003975")]
		[Address(RVA = "0xA17FA0", Offset = "0xA173A0", VA = "0x180A17FA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003976")]
		[Address(RVA = "0xA1ACB0", Offset = "0xA1A0B0", VA = "0x180A1ACB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C3D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.LifePointsGain LifePointsGain
	{
		[Token(Token = "0x6003977")]
		[Address(RVA = "0xA17F40", Offset = "0xA17340", VA = "0x180A17F40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003978")]
		[Address(RVA = "0xA1AC70", Offset = "0xA1A070", VA = "0x180A1AC70")]
		set
		{
		}
	}

	[Token(Token = "0x17000C3E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SpellImmunity SpellImmunity
	{
		[Token(Token = "0x6003979")]
		[Address(RVA = "0xA183B0", Offset = "0xA177B0", VA = "0x180A183B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600397A")]
		[Address(RVA = "0xA1AEB0", Offset = "0xA1A2B0", VA = "0x180A1AEB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C3F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SpellCoolDownVariation SpellCoolDownVariation
	{
		[Token(Token = "0x600397B")]
		[Address(RVA = "0xA18350", Offset = "0xA17750", VA = "0x180A18350")]
		get
		{
			return null;
		}
		[Token(Token = "0x600397C")]
		[Address(RVA = "0xA1AE70", Offset = "0xA1A270", VA = "0x180A1AE70")]
		set
		{
		}
	}

	[Token(Token = "0x17000C40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Vanish Vanish
	{
		[Token(Token = "0x600397D")]
		[Address(RVA = "0xA18770", Offset = "0xA17B70", VA = "0x180A18770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600397E")]
		[Address(RVA = "0xA1B130", Offset = "0xA1A530", VA = "0x180A1B130")]
		set
		{
		}
	}

	[Token(Token = "0x17000C41")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Kill Kill
	{
		[Token(Token = "0x600397F")]
		[Address(RVA = "0xA17EE0", Offset = "0xA172E0", VA = "0x180A17EE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003980")]
		[Address(RVA = "0xA1AC30", Offset = "0xA1A030", VA = "0x180A1AC30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C42")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Death Death
	{
		[Token(Token = "0x6003981")]
		[Address(RVA = "0xA17B90", Offset = "0xA16F90", VA = "0x180A17B90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003982")]
		[Address(RVA = "0xA1AAB0", Offset = "0xA19EB0", VA = "0x180A1AAB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C43")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.TargetedAbility TargetedAbility
	{
		[Token(Token = "0x6003983")]
		[Address(RVA = "0xA18590", Offset = "0xA17990", VA = "0x180A18590")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003984")]
		[Address(RVA = "0xA1AFF0", Offset = "0xA1A3F0", VA = "0x180A1AFF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C44")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Tackled Tackled
	{
		[Token(Token = "0x6003985")]
		[Address(RVA = "0xA18530", Offset = "0xA17930", VA = "0x180A18530")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003986")]
		[Address(RVA = "0xA1AFB0", Offset = "0xA1A3B0", VA = "0x180A1AFB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C45")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.PointsVariation PointsVariation
	{
		[Token(Token = "0x6003987")]
		[Address(RVA = "0xA18110", Offset = "0xA17510", VA = "0x180A18110")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003988")]
		[Address(RVA = "0xA1AD70", Offset = "0xA1A170", VA = "0x180A1AD70")]
		set
		{
		}
	}

	[Token(Token = "0x17000C46")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.InvisibleDetected InvisibleDetected
	{
		[Token(Token = "0x6003989")]
		[Address(RVA = "0xA17E80", Offset = "0xA17280", VA = "0x180A17E80")]
		get
		{
			return null;
		}
		[Token(Token = "0x600398A")]
		[Address(RVA = "0xA1ABF0", Offset = "0xA19FF0", VA = "0x180A1ABF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C47")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.TeleportOnSameMap TeleportOnSameMap
	{
		[Token(Token = "0x600398B")]
		[Address(RVA = "0xA185F0", Offset = "0xA179F0", VA = "0x180A185F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600398C")]
		[Address(RVA = "0xA1B030", Offset = "0xA1A430", VA = "0x180A1B030")]
		set
		{
		}
	}

	[Token(Token = "0x17000C48")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ExchangePositions ExchangePositions
	{
		[Token(Token = "0x600398D")]
		[Address(RVA = "0xA17D60", Offset = "0xA17160", VA = "0x180A17D60")]
		get
		{
			return null;
		}
		[Token(Token = "0x600398E")]
		[Address(RVA = "0xA1AB30", Offset = "0xA19F30", VA = "0x180A1AB30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C49")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SpellRemove SpellRemove
	{
		[Token(Token = "0x600398F")]
		[Address(RVA = "0xA18410", Offset = "0xA17810", VA = "0x180A18410")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003990")]
		[Address(RVA = "0xA1AEF0", Offset = "0xA1A2F0", VA = "0x180A1AEF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C4A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ModifyEffectsDuration ModifyEffectsDuration
	{
		[Token(Token = "0x6003991")]
		[Address(RVA = "0xA18060", Offset = "0xA17460", VA = "0x180A18060")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003992")]
		[Address(RVA = "0xA1AD30", Offset = "0xA1A130", VA = "0x180A1AD30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C4B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.StealKama StealKama
	{
		[Token(Token = "0x6003993")]
		[Address(RVA = "0xA18470", Offset = "0xA17870", VA = "0x180A18470")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003994")]
		[Address(RVA = "0xA1AF30", Offset = "0xA1A330", VA = "0x180A1AF30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C4C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ChangeLook ChangeLook
	{
		[Token(Token = "0x6003995")]
		[Address(RVA = "0xA17B30", Offset = "0xA16F30", VA = "0x180A17B30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003996")]
		[Address(RVA = "0xA1AA70", Offset = "0xA19E70", VA = "0x180A1AA70")]
		set
		{
		}
	}

	[Token(Token = "0x17000C4D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Invisibility Invisibility
	{
		[Token(Token = "0x6003997")]
		[Address(RVA = "0xA17E20", Offset = "0xA17220", VA = "0x180A17E20")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003998")]
		[Address(RVA = "0xA1ABB0", Offset = "0xA19FB0", VA = "0x180A1ABB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C4E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Summons Summons
	{
		[Token(Token = "0x6003999")]
		[Address(RVA = "0xA184D0", Offset = "0xA178D0", VA = "0x180A184D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600399A")]
		[Address(RVA = "0xA1AF70", Offset = "0xA1A370", VA = "0x180A1AF70")]
		set
		{
		}
	}

	[Token(Token = "0x17000C4F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.MarkCells MarkCells
	{
		[Token(Token = "0x600399B")]
		[Address(RVA = "0xA18000", Offset = "0xA17400", VA = "0x180A18000")]
		get
		{
			return null;
		}
		[Token(Token = "0x600399C")]
		[Address(RVA = "0xA1ACF0", Offset = "0xA1A0F0", VA = "0x180A1ACF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.UnmarkCells UnmarkCells
	{
		[Token(Token = "0x600399D")]
		[Address(RVA = "0xA18710", Offset = "0xA17B10", VA = "0x180A18710")]
		get
		{
			return null;
		}
		[Token(Token = "0x600399E")]
		[Address(RVA = "0xA1B0F0", Offset = "0xA1A4F0", VA = "0x180A1B0F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C51")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.TriggerGlyphTrap TriggerGlyphTrap
	{
		[Token(Token = "0x600399F")]
		[Address(RVA = "0xA186B0", Offset = "0xA17AB0", VA = "0x180A186B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0xA1B0B0", Offset = "0xA1A4B0", VA = "0x180A1B0B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C52")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ActivateGlyphTrap ActivateGlyphTrap
	{
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0xA17A70", Offset = "0xA16E70", VA = "0x180A17A70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039A2")]
		[Address(RVA = "0xA1A9F0", Offset = "0xA19DF0", VA = "0x180A1A9F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C53")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.CarryCharacter CarryCharacter
	{
		[Token(Token = "0x60039A3")]
		[Address(RVA = "0xA17AD0", Offset = "0xA16ED0", VA = "0x180A17AD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0xA1AA30", Offset = "0xA19E30", VA = "0x180A1AA30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C54")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ThrowCharacter ThrowCharacter
	{
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0xA18650", Offset = "0xA17A50", VA = "0x180A18650")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039A6")]
		[Address(RVA = "0xA1B070", Offset = "0xA1A470", VA = "0x180A1B070")]
		set
		{
		}
	}

	[Token(Token = "0x17000C55")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.DropCharacter DropCharacter
	{
		[Token(Token = "0x60039A7")]
		[Address(RVA = "0xA17D00", Offset = "0xA17100", VA = "0x180A17D00")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039A8")]
		[Address(RVA = "0xA1AAF0", Offset = "0xA19EF0", VA = "0x180A1AAF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C56")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ExecuteScript ExecuteScript
	{
		[Token(Token = "0x60039A9")]
		[Address(RVA = "0xA17DC0", Offset = "0xA171C0", VA = "0x180A17DC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039AA")]
		[Address(RVA = "0xA1AB70", Offset = "0xA19F70", VA = "0x180A1AB70")]
		set
		{
		}
	}

	[Token(Token = "0x17000C57")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ActionOneofCase ActionCase
	{
		[Token(Token = "0x60039AB")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(ActionOneofCase);
		}
	}

	[Token(Token = "0x6003962")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionFightEvent()
	{
	}

	[Token(Token = "0x6003963")]
	[Address(RVA = "0xA16F50", Offset = "0xA16350", VA = "0x180A16F50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GameActionFightEvent(GameActionFightEvent other)
	{
	}

	[Token(Token = "0x6003964")]
	[Address(RVA = "0xA145D0", Offset = "0xA139D0", VA = "0x180A145D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionFightEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60039AC")]
	[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAction()
	{
	}

	[Token(Token = "0x60039AD")]
	[Address(RVA = "0xA14C80", Offset = "0xA14080", VA = "0x180A14C80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60039AE")]
	[Address(RVA = "0xA14630", Offset = "0xA13A30", VA = "0x180A14630", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionFightEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60039AF")]
	[Address(RVA = "0xA14CE0", Offset = "0xA140E0", VA = "0x180A14CE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60039B0")]
	[Address(RVA = "0xA16DF0", Offset = "0xA161F0", VA = "0x180A16DF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60039B1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60039B2")]
	[Address(RVA = "0xA19B00", Offset = "0xA18F00", VA = "0x180A19B00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60039B3")]
	[Address(RVA = "0xA13630", Offset = "0xA12A30", VA = "0x180A13630", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60039B4")]
	[Address(RVA = "0xA15C00", Offset = "0xA15000", VA = "0x180A15C00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionFightEvent other)
	{
	}

	[Token(Token = "0x60039B5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60039B6")]
	[Address(RVA = "0xA187D0", Offset = "0xA17BD0", VA = "0x180A187D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
