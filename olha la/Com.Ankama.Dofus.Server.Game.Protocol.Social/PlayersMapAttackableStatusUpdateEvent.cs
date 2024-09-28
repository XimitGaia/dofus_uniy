using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x200013A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayersMapAttackableStatusUpdateEvent : IMessage<PlayersMapAttackableStatusUpdateEvent>, IMessage, IEquatable<PlayersMapAttackableStatusUpdateEvent>, IDeepCloneable<PlayersMapAttackableStatusUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x200013B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200013C")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class AttackableStatus : IMessage<AttackableStatus>, IMessage, IEquatable<AttackableStatus>, IDeepCloneable<AttackableStatus>, IBufferMessage
		{
			[Token(Token = "0x4000435")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<AttackableStatus> _parser;

			[Token(Token = "0x4000436")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000437")]
			[FieldOffset(Offset = "0x18")]
			private int _hasBits0;

			[Token(Token = "0x4000438")]
			public const int CharacterIdFieldNumber = 1;

			[Token(Token = "0x4000439")]
			[FieldOffset(Offset = "0x20")]
			private long characterId_;

			[Token(Token = "0x400043A")]
			public const int StatusFieldNumber = 2;

			[Token(Token = "0x400043B")]
			[FieldOffset(Offset = "0x28")]
			private Com.Ankama.Dofus.Server.Game.Protocol.Common.AttackableStatus status_;

			[Token(Token = "0x400043C")]
			public const int KothRoleFieldNumber = 3;

			[Token(Token = "0x400043D")]
			[FieldOffset(Offset = "0x2C")]
			private int kothRole_;

			[Token(Token = "0x400043E")]
			public const int PictoScoreFieldNumber = 4;

			[Token(Token = "0x400043F")]
			[FieldOffset(Offset = "0x8")]
			private static readonly int PictoScoreDefaultValue;

			[Token(Token = "0x4000440")]
			[FieldOffset(Offset = "0x30")]
			private int pictoScore_;

			[Token(Token = "0x1700029E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<AttackableStatus> Parser
			{
				[Token(Token = "0x6000C48")]
				[Address(RVA = "0xB64FD0", Offset = "0xB643D0", VA = "0x180B64FD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700029F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6000C49")]
				[Address(RVA = "0xB64F50", Offset = "0xB64350", VA = "0x180B64F50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002A0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6000C4A")]
				[Address(RVA = "0xB651A0", Offset = "0xB645A0", VA = "0x180B651A0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002A1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long CharacterId
			{
				[Token(Token = "0x6000C4E")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000C4F")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x170002A2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Com.Ankama.Dofus.Server.Game.Protocol.Common.AttackableStatus Status
			{
				[Token(Token = "0x6000C50")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(Com.Ankama.Dofus.Server.Game.Protocol.Common.AttackableStatus);
				}
				[Token(Token = "0x6000C51")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x170002A3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int KothRole
			{
				[Token(Token = "0x6000C52")]
				[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000C53")]
				[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
				set
				{
				}
			}

			[Token(Token = "0x170002A4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int PictoScore
			{
				[Token(Token = "0x6000C54")]
				[Address(RVA = "0xB65020", Offset = "0xB64420", VA = "0x180B65020")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000C55")]
				[Address(RVA = "0xA4D370", Offset = "0xA4C770", VA = "0x180A4D370")]
				set
				{
				}
			}

			[Token(Token = "0x170002A5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasPictoScore
			{
				[Token(Token = "0x6000C56")]
				[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AttackableStatus()
			{
			}

			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0xA4CEA0", Offset = "0xA4C2A0", VA = "0x180A4CEA0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AttackableStatus(AttackableStatus other)
			{
			}

			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0xB64A50", Offset = "0xB63E50", VA = "0x180B64A50", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public AttackableStatus Clone()
			{
				return null;
			}

			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearPictoScore()
			{
			}

			[Token(Token = "0x6000C58")]
			[Address(RVA = "0xB64AF0", Offset = "0xB63EF0", VA = "0x180B64AF0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C59")]
			[Address(RVA = "0xB64BC0", Offset = "0xB63FC0", VA = "0x180B64BC0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(AttackableStatus other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0xB64C50", Offset = "0xB64050", VA = "0x180B64C50", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0xB64DE0", Offset = "0xB641E0", VA = "0x180B64DE0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0xB65090", Offset = "0xB64490", VA = "0x180B65090", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0xB648F0", Offset = "0xB63CF0", VA = "0x180B648F0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0xB64D60", Offset = "0xB64160", VA = "0x180B64D60", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(AttackableStatus other)
			{
			}

			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6000C61")]
			[Address(RVA = "0xA4D080", Offset = "0xA4C480", VA = "0x180A4D080", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayersMapAttackableStatusUpdateEvent> _parser;

	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000432")]
	public const int PvpPlayersFieldNumber = 1;

	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.AttackableStatus> _repeated_pvpPlayers_codec;

	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.AttackableStatus> pvpPlayers_;

	[Token(Token = "0x1700029A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PlayersMapAttackableStatusUpdateEvent> Parser
	{
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0xB69610", Offset = "0xB68A10", VA = "0x180B69610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0xB69560", Offset = "0xB68960", VA = "0x180B69560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0xB69820", Offset = "0xB68C20", VA = "0x180B69820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.AttackableStatus> PvpPlayers
	{
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000C39")]
	[Address(RVA = "0xB694E0", Offset = "0xB688E0", VA = "0x180B694E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayersMapAttackableStatusUpdateEvent()
	{
	}

	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0xB69450", Offset = "0xB68850", VA = "0x180B69450")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayersMapAttackableStatusUpdateEvent(PlayersMapAttackableStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0xB68FA0", Offset = "0xB683A0", VA = "0x180B68FA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayersMapAttackableStatusUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0xB690F0", Offset = "0xB684F0", VA = "0x180B690F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0xB69060", Offset = "0xB68460", VA = "0x180B69060", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayersMapAttackableStatusUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000C40")]
	[Address(RVA = "0xB69250", Offset = "0xB68650", VA = "0x180B69250", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0xB69770", Offset = "0xB68B70", VA = "0x180B69770", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000C43")]
	[Address(RVA = "0xB68F00", Offset = "0xB68300", VA = "0x180B68F00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000C44")]
	[Address(RVA = "0xB691D0", Offset = "0xB685D0", VA = "0x180B691D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayersMapAttackableStatusUpdateEvent other)
	{
	}

	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0xB69660", Offset = "0xB68A60", VA = "0x180B69660", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
