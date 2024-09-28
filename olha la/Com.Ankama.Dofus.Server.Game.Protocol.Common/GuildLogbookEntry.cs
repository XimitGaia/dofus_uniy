using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A84")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildLogbookEntry : IMessage<GuildLogbookEntry>, IMessage, IEquatable<GuildLogbookEntry>, IDeepCloneable<GuildLogbookEntry>, IBufferMessage
{
	[Token(Token = "0x2000A85")]
	public enum ActivityOneofCase
	{
		[Token(Token = "0x4002654")]
		None = 0,
		[Token(Token = "0x4002655")]
		ChestActivity = 3,
		[Token(Token = "0x4002656")]
		PaddockActivity = 4,
		[Token(Token = "0x4002657")]
		PlayerFlowActivity = 5,
		[Token(Token = "0x4002658")]
		LevelUpActivity = 6,
		[Token(Token = "0x4002659")]
		UnlockNewTabActivity = 7,
		[Token(Token = "0x400265A")]
		RankActivity = 8,
		[Token(Token = "0x400265B")]
		PlayerRankUpdateActivity = 9
	}

	[Token(Token = "0x2000A86")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000A87")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class ChestActivity : IMessage<ChestActivity>, IMessage, IEquatable<ChestActivity>, IDeepCloneable<ChestActivity>, IBufferMessage
		{
			[Token(Token = "0x2000A88")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000A89")]
				public enum ChestEventType
				{
					[Token(Token = "0x400266D")]
					[OriginalName("DEPOSIT")]
					Deposit,
					[Token(Token = "0x400266E")]
					[OriginalName("WITHDRAW")]
					Withdraw,
					[Token(Token = "0x400266F")]
					[OriginalName("TRANSFER")]
					Transfer
				}
			}

			[Token(Token = "0x400265C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<ChestActivity> _parser;

			[Token(Token = "0x400265D")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400265E")]
			public const int PlayerIdFieldNumber = 1;

			[Token(Token = "0x400265F")]
			[FieldOffset(Offset = "0x18")]
			private long playerId_;

			[Token(Token = "0x4002660")]
			public const int PlayerNameFieldNumber = 2;

			[Token(Token = "0x4002661")]
			[FieldOffset(Offset = "0x20")]
			private string playerName_;

			[Token(Token = "0x4002662")]
			public const int EventTypeFieldNumber = 3;

			[Token(Token = "0x4002663")]
			[FieldOffset(Offset = "0x28")]
			private Types.ChestEventType eventType_;

			[Token(Token = "0x4002664")]
			public const int QuantityFieldNumber = 4;

			[Token(Token = "0x4002665")]
			[FieldOffset(Offset = "0x2C")]
			private int quantity_;

			[Token(Token = "0x4002666")]
			public const int ObjectFieldNumber = 5;

			[Token(Token = "0x4002667")]
			[FieldOffset(Offset = "0x30")]
			private ObjectItem object_;

			[Token(Token = "0x4002668")]
			public const int SourceTabIdFieldNumber = 6;

			[Token(Token = "0x4002669")]
			[FieldOffset(Offset = "0x38")]
			private int sourceTabId_;

			[Token(Token = "0x400266A")]
			public const int DestinationTabIdFieldNumber = 7;

			[Token(Token = "0x400266B")]
			[FieldOffset(Offset = "0x3C")]
			private int destinationTabId_;

			[Token(Token = "0x170017FA")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<ChestActivity> Parser
			{
				[Token(Token = "0x6006E3B")]
				[Address(RVA = "0xBDA870", Offset = "0xBD9C70", VA = "0x180BDA870")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170017FB")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006E3C")]
				[Address(RVA = "0xBDA7F0", Offset = "0xBD9BF0", VA = "0x180BDA7F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170017FC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006E3D")]
				[Address(RVA = "0xBDABC0", Offset = "0xBD9FC0", VA = "0x180BDABC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170017FD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long PlayerId
			{
				[Token(Token = "0x6006E41")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006E42")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x170017FE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string PlayerName
			{
				[Token(Token = "0x6006E43")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006E44")]
				[Address(RVA = "0xBDAC70", Offset = "0xBDA070", VA = "0x180BDAC70")]
				set
				{
				}
			}

			[Token(Token = "0x170017FF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.ChestEventType EventType
			{
				[Token(Token = "0x6006E45")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(Types.ChestEventType);
				}
				[Token(Token = "0x6006E46")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x17001800")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Quantity
			{
				[Token(Token = "0x6006E47")]
				[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006E48")]
				[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
				set
				{
				}
			}

			[Token(Token = "0x17001801")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ObjectItem Object
			{
				[Token(Token = "0x6006E49")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006E4A")]
				[Address(RVA = "0xA34B30", Offset = "0xA33F30", VA = "0x180A34B30")]
				set
				{
				}
			}

			[Token(Token = "0x17001802")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int SourceTabId
			{
				[Token(Token = "0x6006E4B")]
				[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006E4C")]
				[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
				set
				{
				}
			}

			[Token(Token = "0x17001803")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int DestinationTabId
			{
				[Token(Token = "0x6006E4D")]
				[Address(RVA = "0x946B90", Offset = "0x945F90", VA = "0x180946B90")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006E4E")]
				[Address(RVA = "0x9470F0", Offset = "0x9464F0", VA = "0x1809470F0")]
				set
				{
				}
			}

			[Token(Token = "0x6006E3E")]
			[Address(RVA = "0xBDA7A0", Offset = "0xBD9BA0", VA = "0x180BDA7A0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ChestActivity()
			{
			}

			[Token(Token = "0x6006E3F")]
			[Address(RVA = "0xBDA6C0", Offset = "0xBD9AC0", VA = "0x180BDA6C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ChestActivity(ChestActivity other)
			{
			}

			[Token(Token = "0x6006E40")]
			[Address(RVA = "0xBDA080", Offset = "0xBD9480", VA = "0x180BDA080", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public ChestActivity Clone()
			{
				return null;
			}

			[Token(Token = "0x6006E4F")]
			[Address(RVA = "0xBDA190", Offset = "0xBD9590", VA = "0x180BDA190", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006E50")]
			[Address(RVA = "0xBDA280", Offset = "0xBD9680", VA = "0x180BDA280", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(ChestActivity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006E51")]
			[Address(RVA = "0xBDA320", Offset = "0xBD9720", VA = "0x180BDA320", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006E52")]
			[Address(RVA = "0xBDA560", Offset = "0xBD9960", VA = "0x180BDA560", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006E53")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006E54")]
			[Address(RVA = "0xBDAA90", Offset = "0xBD9E90", VA = "0x180BDAA90", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006E55")]
			[Address(RVA = "0xBD9EF0", Offset = "0xBD92F0", VA = "0x180BD9EF0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006E56")]
			[Address(RVA = "0xBDA440", Offset = "0xBD9840", VA = "0x180BDA440", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(ChestActivity other)
			{
			}

			[Token(Token = "0x6006E57")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006E58")]
			[Address(RVA = "0xBDA8C0", Offset = "0xBD9CC0", VA = "0x180BDA8C0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000A8B")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PaddockActivity : IMessage<PaddockActivity>, IMessage, IEquatable<PaddockActivity>, IDeepCloneable<PaddockActivity>, IBufferMessage
		{
			[Token(Token = "0x2000A8C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000A8D")]
				public enum PaddockCommercialEventType
				{
					[Token(Token = "0x400267E")]
					[OriginalName("BUY")]
					Buy,
					[Token(Token = "0x400267F")]
					[OriginalName("PUT_ON_SELL")]
					PutOnSell,
					[Token(Token = "0x4002680")]
					[OriginalName("SOLD")]
					Sold
				}
			}

			[Token(Token = "0x4002671")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PaddockActivity> _parser;

			[Token(Token = "0x4002672")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002673")]
			public const int PlayerIdFieldNumber = 1;

			[Token(Token = "0x4002674")]
			[FieldOffset(Offset = "0x18")]
			private long playerId_;

			[Token(Token = "0x4002675")]
			public const int PlayerNameFieldNumber = 2;

			[Token(Token = "0x4002676")]
			[FieldOffset(Offset = "0x20")]
			private string playerName_;

			[Token(Token = "0x4002677")]
			public const int PaddockCoordinatesFieldNumber = 3;

			[Token(Token = "0x4002678")]
			[FieldOffset(Offset = "0x28")]
			private MapExtendedCoordinates paddockCoordinates_;

			[Token(Token = "0x4002679")]
			public const int FarmIdFieldNumber = 4;

			[Token(Token = "0x400267A")]
			[FieldOffset(Offset = "0x30")]
			private long farmId_;

			[Token(Token = "0x400267B")]
			public const int PaddockCommercialEventTypeFieldNumber = 5;

			[Token(Token = "0x400267C")]
			[FieldOffset(Offset = "0x38")]
			private Types.PaddockCommercialEventType paddockCommercialEventType_;

			[Token(Token = "0x17001804")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<PaddockActivity> Parser
			{
				[Token(Token = "0x6006E5D")]
				[Address(RVA = "0xBE63E0", Offset = "0xBE57E0", VA = "0x180BE63E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001805")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006E5E")]
				[Address(RVA = "0xBE6360", Offset = "0xBE5760", VA = "0x180BE6360")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001806")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006E5F")]
				[Address(RVA = "0xBE66C0", Offset = "0xBE5AC0", VA = "0x180BE66C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001807")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long PlayerId
			{
				[Token(Token = "0x6006E63")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006E64")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17001808")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string PlayerName
			{
				[Token(Token = "0x6006E65")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006E66")]
				[Address(RVA = "0xBE6770", Offset = "0xBE5B70", VA = "0x180BE6770")]
				set
				{
				}
			}

			[Token(Token = "0x17001809")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public MapExtendedCoordinates PaddockCoordinates
			{
				[Token(Token = "0x6006E67")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006E68")]
				[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
				set
				{
				}
			}

			[Token(Token = "0x1700180A")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long FarmId
			{
				[Token(Token = "0x6006E69")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006E6A")]
				[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
				set
				{
				}
			}

			[Token(Token = "0x1700180B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.PaddockCommercialEventType PaddockCommercialEventType
			{
				[Token(Token = "0x6006E6B")]
				[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
				get
				{
					return default(Types.PaddockCommercialEventType);
				}
				[Token(Token = "0x6006E6C")]
				[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
				set
				{
				}
			}

			[Token(Token = "0x6006E60")]
			[Address(RVA = "0xBE61C0", Offset = "0xBE55C0", VA = "0x180BE61C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockActivity()
			{
			}

			[Token(Token = "0x6006E61")]
			[Address(RVA = "0xBE6210", Offset = "0xBE5610", VA = "0x180BE6210")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockActivity(PaddockActivity other)
			{
			}

			[Token(Token = "0x6006E62")]
			[Address(RVA = "0xBE5B20", Offset = "0xBE4F20", VA = "0x180BE5B20", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PaddockActivity Clone()
			{
				return null;
			}

			[Token(Token = "0x6006E6D")]
			[Address(RVA = "0xBE5D30", Offset = "0xBE5130", VA = "0x180BE5D30", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006E6E")]
			[Address(RVA = "0xBE5C90", Offset = "0xBE5090", VA = "0x180BE5C90", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PaddockActivity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006E6F")]
			[Address(RVA = "0xBE5E10", Offset = "0xBE5210", VA = "0x180BE5E10", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006E70")]
			[Address(RVA = "0xBE6060", Offset = "0xBE5460", VA = "0x180BE6060", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006E71")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006E72")]
			[Address(RVA = "0xBE65D0", Offset = "0xBE59D0", VA = "0x180BE65D0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006E73")]
			[Address(RVA = "0xBE59E0", Offset = "0xBE4DE0", VA = "0x180BE59E0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006E74")]
			[Address(RVA = "0xBE5F00", Offset = "0xBE5300", VA = "0x180BE5F00", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(PaddockActivity other)
			{
			}

			[Token(Token = "0x6006E75")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006E76")]
			[Address(RVA = "0xBE6430", Offset = "0xBE5830", VA = "0x180BE6430", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000A8F")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PlayerFlowActivity : IMessage<PlayerFlowActivity>, IMessage, IEquatable<PlayerFlowActivity>, IDeepCloneable<PlayerFlowActivity>, IBufferMessage
		{
			[Token(Token = "0x2000A90")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000A91")]
				public enum PlayerFlowEventType
				{
					[Token(Token = "0x400268B")]
					[OriginalName("JOIN")]
					Join,
					[Token(Token = "0x400268C")]
					[OriginalName("LEAVE")]
					Leave,
					[Token(Token = "0x400268D")]
					[OriginalName("APPLY_REFUSED")]
					ApplyRefused
				}
			}

			[Token(Token = "0x4002682")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PlayerFlowActivity> _parser;

			[Token(Token = "0x4002683")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002684")]
			public const int PlayerIdFieldNumber = 1;

			[Token(Token = "0x4002685")]
			[FieldOffset(Offset = "0x18")]
			private long playerId_;

			[Token(Token = "0x4002686")]
			public const int PlayerNameFieldNumber = 2;

			[Token(Token = "0x4002687")]
			[FieldOffset(Offset = "0x20")]
			private string playerName_;

			[Token(Token = "0x4002688")]
			public const int PlayerFlowEventTypeFieldNumber = 3;

			[Token(Token = "0x4002689")]
			[FieldOffset(Offset = "0x28")]
			private Types.PlayerFlowEventType playerFlowEventType_;

			[Token(Token = "0x1700180C")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<PlayerFlowActivity> Parser
			{
				[Token(Token = "0x6006E7B")]
				[Address(RVA = "0xBE6EF0", Offset = "0xBE62F0", VA = "0x180BE6EF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700180D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006E7C")]
				[Address(RVA = "0xBE6E70", Offset = "0xBE6270", VA = "0x180BE6E70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700180E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006E7D")]
				[Address(RVA = "0xBE70E0", Offset = "0xBE64E0", VA = "0x180BE70E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700180F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long PlayerId
			{
				[Token(Token = "0x6006E81")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006E82")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17001810")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public string PlayerName
			{
				[Token(Token = "0x6006E83")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006E84")]
				[Address(RVA = "0xBE7190", Offset = "0xBE6590", VA = "0x180BE7190")]
				set
				{
				}
			}

			[Token(Token = "0x17001811")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.PlayerFlowEventType PlayerFlowEventType
			{
				[Token(Token = "0x6006E85")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(Types.PlayerFlowEventType);
				}
				[Token(Token = "0x6006E86")]
				[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
				set
				{
				}
			}

			[Token(Token = "0x6006E7E")]
			[Address(RVA = "0xBE6D70", Offset = "0xBE6170", VA = "0x180BE6D70")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PlayerFlowActivity()
			{
			}

			[Token(Token = "0x6006E7F")]
			[Address(RVA = "0xBE6DC0", Offset = "0xBE61C0", VA = "0x180BE6DC0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PlayerFlowActivity(PlayerFlowActivity other)
			{
			}

			[Token(Token = "0x6006E80")]
			[Address(RVA = "0xBE68C0", Offset = "0xBE5CC0", VA = "0x180BE68C0", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PlayerFlowActivity Clone()
			{
				return null;
			}

			[Token(Token = "0x6006E87")]
			[Address(RVA = "0xBE69A0", Offset = "0xBE5DA0", VA = "0x180BE69A0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006E88")]
			[Address(RVA = "0xBE6A60", Offset = "0xBE5E60", VA = "0x180BE6A60", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(PlayerFlowActivity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006E89")]
			[Address(RVA = "0xBE6AE0", Offset = "0xBE5EE0", VA = "0x180BE6AE0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006E8A")]
			[Address(RVA = "0xBE6C10", Offset = "0xBE6010", VA = "0x180BE6C10", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006E8B")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006E8C")]
			[Address(RVA = "0xBE7030", Offset = "0xBE6430", VA = "0x180BE7030", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006E8D")]
			[Address(RVA = "0xBE67E0", Offset = "0xBE5BE0", VA = "0x180BE67E0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006E8E")]
			[Address(RVA = "0xBE6B90", Offset = "0xBE5F90", VA = "0x180BE6B90", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(PlayerFlowActivity other)
			{
			}

			[Token(Token = "0x6006E8F")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006E90")]
			[Address(RVA = "0xBE6F40", Offset = "0xBE6340", VA = "0x180BE6F40", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000A93")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class LevelUpActivity : IMessage<LevelUpActivity>, IMessage, IEquatable<LevelUpActivity>, IDeepCloneable<LevelUpActivity>, IBufferMessage
		{
			[Token(Token = "0x400268F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<LevelUpActivity> _parser;

			[Token(Token = "0x4002690")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002691")]
			public const int NewGuildLevelFieldNumber = 1;

			[Token(Token = "0x4002692")]
			[FieldOffset(Offset = "0x18")]
			private int newGuildLevel_;

			[Token(Token = "0x17001812")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<LevelUpActivity> Parser
			{
				[Token(Token = "0x6006E95")]
				[Address(RVA = "0xBE27A0", Offset = "0xBE1BA0", VA = "0x180BE27A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001813")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006E96")]
				[Address(RVA = "0xBE2720", Offset = "0xBE1B20", VA = "0x180BE2720")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001814")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006E97")]
				[Address(RVA = "0xBE27F0", Offset = "0xBE1BF0", VA = "0x180BE27F0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001815")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int NewGuildLevel
			{
				[Token(Token = "0x6006E9B")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6006E9C")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x6006E98")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public LevelUpActivity()
			{
			}

			[Token(Token = "0x6006E99")]
			[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public LevelUpActivity(LevelUpActivity other)
			{
			}

			[Token(Token = "0x6006E9A")]
			[Address(RVA = "0xBE24B0", Offset = "0xBE18B0", VA = "0x180BE24B0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public LevelUpActivity Clone()
			{
				return null;
			}

			[Token(Token = "0x6006E9D")]
			[Address(RVA = "0xBE2530", Offset = "0xBE1930", VA = "0x180BE2530", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006E9E")]
			[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(LevelUpActivity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006E9F")]
			[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006EA0")]
			[Address(RVA = "0xBE25C0", Offset = "0xBE19C0", VA = "0x180BE25C0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006EA1")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006EA2")]
			[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006EA3")]
			[Address(RVA = "0xBE2420", Offset = "0xBE1820", VA = "0x180BE2420", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006EA4")]
			[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(LevelUpActivity other)
			{
			}

			[Token(Token = "0x6006EA5")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006EA6")]
			[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000A95")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class UnlockNewTabActivity : IMessage<UnlockNewTabActivity>, IMessage, IEquatable<UnlockNewTabActivity>, IDeepCloneable<UnlockNewTabActivity>, IBufferMessage
		{
			[Token(Token = "0x4002694")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<UnlockNewTabActivity> _parser;

			[Token(Token = "0x4002695")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x17001816")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<UnlockNewTabActivity> Parser
			{
				[Token(Token = "0x6006EAB")]
				[Address(RVA = "0xBEEEF0", Offset = "0xBEE2F0", VA = "0x180BEEEF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001817")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006EAC")]
				[Address(RVA = "0xBEEE70", Offset = "0xBEE270", VA = "0x180BEEE70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001818")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006EAD")]
				[Address(RVA = "0xBEEF40", Offset = "0xBEE340", VA = "0x180BEEF40", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006EAE")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public UnlockNewTabActivity()
			{
			}

			[Token(Token = "0x6006EAF")]
			[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public UnlockNewTabActivity(UnlockNewTabActivity other)
			{
			}

			[Token(Token = "0x6006EB0")]
			[Address(RVA = "0xBEEC10", Offset = "0xBEE010", VA = "0x180BEEC10", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public UnlockNewTabActivity Clone()
			{
				return null;
			}

			[Token(Token = "0x6006EB1")]
			[Address(RVA = "0xBEEC90", Offset = "0xBEE090", VA = "0x180BEEC90", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006EB2")]
			[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(UnlockNewTabActivity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006EB3")]
			[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006EB4")]
			[Address(RVA = "0xBEED10", Offset = "0xBEE110", VA = "0x180BEED10", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006EB5")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006EB6")]
			[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006EB7")]
			[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006EB8")]
			[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(UnlockNewTabActivity other)
			{
			}

			[Token(Token = "0x6006EB9")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006EBA")]
			[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000A97")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class RankActivity : IMessage<RankActivity>, IMessage, IEquatable<RankActivity>, IDeepCloneable<RankActivity>, IBufferMessage
		{
			[Token(Token = "0x2000A98")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000A99")]
				public enum RankActivityType
				{
					[Token(Token = "0x400269E")]
					[OriginalName("CREATION")]
					Creation,
					[Token(Token = "0x400269F")]
					[OriginalName("UPDATE")]
					Update,
					[Token(Token = "0x40026A0")]
					[OriginalName("DELETE")]
					Delete
				}
			}

			[Token(Token = "0x4002697")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<RankActivity> _parser;

			[Token(Token = "0x4002698")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4002699")]
			public const int RankActivityTypeFieldNumber = 1;

			[Token(Token = "0x400269A")]
			[FieldOffset(Offset = "0x18")]
			private Types.RankActivityType rankActivityType_;

			[Token(Token = "0x400269B")]
			public const int RankInformationFieldNumber = 2;

			[Token(Token = "0x400269C")]
			[FieldOffset(Offset = "0x20")]
			private RankInformation rankInformation_;

			[Token(Token = "0x17001819")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<RankActivity> Parser
			{
				[Token(Token = "0x6006EBF")]
				[Address(RVA = "0xBE8550", Offset = "0xBE7950", VA = "0x180BE8550")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700181A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006EC0")]
				[Address(RVA = "0xBE84D0", Offset = "0xBE78D0", VA = "0x180BE84D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700181B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006EC1")]
				[Address(RVA = "0xBE86C0", Offset = "0xBE7AC0", VA = "0x180BE86C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700181C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Types.RankActivityType RankActivityType
			{
				[Token(Token = "0x6006EC5")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(Types.RankActivityType);
				}
				[Token(Token = "0x6006EC6")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x1700181D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RankInformation RankInformation
			{
				[Token(Token = "0x6006EC7")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006EC8")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x6006EC2")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RankActivity()
			{
			}

			[Token(Token = "0x6006EC3")]
			[Address(RVA = "0xBE8460", Offset = "0xBE7860", VA = "0x180BE8460")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RankActivity(RankActivity other)
			{
			}

			[Token(Token = "0x6006EC4")]
			[Address(RVA = "0xBE80E0", Offset = "0xBE74E0", VA = "0x180BE80E0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RankActivity Clone()
			{
				return null;
			}

			[Token(Token = "0x6006EC9")]
			[Address(RVA = "0xBE8180", Offset = "0xBE7580", VA = "0x180BE8180", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006ECA")]
			[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(RankActivity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006ECB")]
			[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006ECC")]
			[Address(RVA = "0xBE8300", Offset = "0xBE7700", VA = "0x180BE8300", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006ECD")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006ECE")]
			[Address(RVA = "0x996700", Offset = "0x995B00", VA = "0x180996700", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006ECF")]
			[Address(RVA = "0xBE8020", Offset = "0xBE7420", VA = "0x180BE8020", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006ED0")]
			[Address(RVA = "0xBE8230", Offset = "0xBE7630", VA = "0x180BE8230", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(RankActivity other)
			{
			}

			[Token(Token = "0x6006ED1")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006ED2")]
			[Address(RVA = "0xBE85A0", Offset = "0xBE79A0", VA = "0x180BE85A0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000A9B")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PlayerRankUpdateActivity : IMessage<PlayerRankUpdateActivity>, IMessage, IEquatable<PlayerRankUpdateActivity>, IDeepCloneable<PlayerRankUpdateActivity>, IBufferMessage
		{
			[Token(Token = "0x40026A2")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PlayerRankUpdateActivity> _parser;

			[Token(Token = "0x40026A3")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40026A4")]
			public const int RankInformationFieldNumber = 1;

			[Token(Token = "0x40026A5")]
			[FieldOffset(Offset = "0x18")]
			private RankInformation rankInformation_;

			[Token(Token = "0x40026A6")]
			public const int SourcePlayerIdFieldNumber = 2;

			[Token(Token = "0x40026A7")]
			[FieldOffset(Offset = "0x20")]
			private long sourcePlayerId_;

			[Token(Token = "0x40026A8")]
			public const int TargetPlayerIdFieldNumber = 3;

			[Token(Token = "0x40026A9")]
			[FieldOffset(Offset = "0x28")]
			private long targetPlayerId_;

			[Token(Token = "0x40026AA")]
			public const int SourcePlayerNameFieldNumber = 4;

			[Token(Token = "0x40026AB")]
			[FieldOffset(Offset = "0x30")]
			private string sourcePlayerName_;

			[Token(Token = "0x40026AC")]
			public const int TargetPlayerNameFieldNumber = 5;

			[Token(Token = "0x40026AD")]
			[FieldOffset(Offset = "0x38")]
			private string targetPlayerName_;

			[Token(Token = "0x1700181E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<PlayerRankUpdateActivity> Parser
			{
				[Token(Token = "0x6006ED7")]
				[Address(RVA = "0xBE7B80", Offset = "0xBE6F80", VA = "0x180BE7B80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700181F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6006ED8")]
				[Address(RVA = "0xBE7B00", Offset = "0xBE6F00", VA = "0x180BE7B00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001820")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6006ED9")]
				[Address(RVA = "0xBE7E90", Offset = "0xBE7290", VA = "0x180BE7E90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001821")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RankInformation RankInformation
			{
				[Token(Token = "0x6006EDD")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006EDE")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17001822")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long SourcePlayerId
			{
				[Token(Token = "0x6006EDF")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006EE0")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x17001823")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long TargetPlayerId
			{
				[Token(Token = "0x6006EE1")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6006EE2")]
				[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
				set
				{
				}
			}

			[Token(Token = "0x17001824")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string SourcePlayerName
			{
				[Token(Token = "0x6006EE3")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006EE4")]
				[Address(RVA = "0xBE7F40", Offset = "0xBE7340", VA = "0x180BE7F40")]
				set
				{
				}
			}

			[Token(Token = "0x17001825")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string TargetPlayerName
			{
				[Token(Token = "0x6006EE5")]
				[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006EE6")]
				[Address(RVA = "0xBE7FB0", Offset = "0xBE73B0", VA = "0x180BE7FB0")]
				set
				{
				}
			}

			[Token(Token = "0x6006EDA")]
			[Address(RVA = "0xBE7980", Offset = "0xBE6D80", VA = "0x180BE7980")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PlayerRankUpdateActivity()
			{
			}

			[Token(Token = "0x6006EDB")]
			[Address(RVA = "0xBE79F0", Offset = "0xBE6DF0", VA = "0x180BE79F0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PlayerRankUpdateActivity(PlayerRankUpdateActivity other)
			{
			}

			[Token(Token = "0x6006EDC")]
			[Address(RVA = "0xBE7340", Offset = "0xBE6740", VA = "0x180BE7340", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PlayerRankUpdateActivity Clone()
			{
				return null;
			}

			[Token(Token = "0x6006EE7")]
			[Address(RVA = "0xBE7480", Offset = "0xBE6880", VA = "0x180BE7480", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006EE8")]
			[Address(RVA = "0xBE7570", Offset = "0xBE6970", VA = "0x180BE7570", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(PlayerRankUpdateActivity other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006EE9")]
			[Address(RVA = "0xBE7610", Offset = "0xBE6A10", VA = "0x180BE7610", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006EEA")]
			[Address(RVA = "0xBE7820", Offset = "0xBE6C20", VA = "0x180BE7820", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006EEB")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006EEC")]
			[Address(RVA = "0xBE7D90", Offset = "0xBE7190", VA = "0x180BE7D90", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006EED")]
			[Address(RVA = "0xBE7200", Offset = "0xBE6600", VA = "0x180BE7200", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006EEE")]
			[Address(RVA = "0xBE7700", Offset = "0xBE6B00", VA = "0x180BE7700", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(PlayerRankUpdateActivity other)
			{
			}

			[Token(Token = "0x6006EEF")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006EF0")]
			[Address(RVA = "0xBE7BD0", Offset = "0xBE6FD0", VA = "0x180BE7BD0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002644")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildLogbookEntry> _parser;

	[Token(Token = "0x4002645")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002646")]
	public const int GuildIdFieldNumber = 1;

	[Token(Token = "0x4002647")]
	[FieldOffset(Offset = "0x18")]
	private int guildId_;

	[Token(Token = "0x4002648")]
	public const int DateFieldNumber = 2;

	[Token(Token = "0x4002649")]
	[FieldOffset(Offset = "0x20")]
	private long date_;

	[Token(Token = "0x400264A")]
	public const int ChestActivityFieldNumber = 3;

	[Token(Token = "0x400264B")]
	public const int PaddockActivityFieldNumber = 4;

	[Token(Token = "0x400264C")]
	public const int PlayerFlowActivityFieldNumber = 5;

	[Token(Token = "0x400264D")]
	public const int LevelUpActivityFieldNumber = 6;

	[Token(Token = "0x400264E")]
	public const int UnlockNewTabActivityFieldNumber = 7;

	[Token(Token = "0x400264F")]
	public const int RankActivityFieldNumber = 8;

	[Token(Token = "0x4002650")]
	public const int PlayerRankUpdateActivityFieldNumber = 9;

	[Token(Token = "0x4002651")]
	[FieldOffset(Offset = "0x28")]
	private object activity_;

	[Token(Token = "0x4002652")]
	[FieldOffset(Offset = "0x30")]
	private ActivityOneofCase activityCase_;

	[Token(Token = "0x170017ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildLogbookEntry> Parser
	{
		[Token(Token = "0x6006E16")]
		[Address(RVA = "0xBD3330", Offset = "0xBD2730", VA = "0x180BD3330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017EE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006E17")]
		[Address(RVA = "0xBD31C0", Offset = "0xBD25C0", VA = "0x180BD31C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006E18")]
		[Address(RVA = "0xBD3CF0", Offset = "0xBD30F0", VA = "0x180BD3CF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildId
	{
		[Token(Token = "0x6006E1C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006E1D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170017F1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Date
	{
		[Token(Token = "0x6006E1E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006E1F")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170017F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ChestActivity ChestActivity
	{
		[Token(Token = "0x6006E20")]
		[Address(RVA = "0xBD3160", Offset = "0xBD2560", VA = "0x180BD3160")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E21")]
		[Address(RVA = "0x91BB80", Offset = "0x91AF80", VA = "0x18091BB80")]
		set
		{
		}
	}

	[Token(Token = "0x170017F3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PaddockActivity PaddockActivity
	{
		[Token(Token = "0x6006E22")]
		[Address(RVA = "0xBD32D0", Offset = "0xBD26D0", VA = "0x180BD32D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E23")]
		[Address(RVA = "0x91BB40", Offset = "0x91AF40", VA = "0x18091BB40")]
		set
		{
		}
	}

	[Token(Token = "0x170017F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.PlayerFlowActivity PlayerFlowActivity
	{
		[Token(Token = "0x6006E24")]
		[Address(RVA = "0xBD3380", Offset = "0xBD2780", VA = "0x180BD3380")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E25")]
		[Address(RVA = "0x9FA5D0", Offset = "0x9F99D0", VA = "0x1809FA5D0")]
		set
		{
		}
	}

	[Token(Token = "0x170017F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.LevelUpActivity LevelUpActivity
	{
		[Token(Token = "0x6006E26")]
		[Address(RVA = "0xBD3270", Offset = "0xBD2670", VA = "0x180BD3270")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E27")]
		[Address(RVA = "0xA1ADB0", Offset = "0xA1A1B0", VA = "0x180A1ADB0")]
		set
		{
		}
	}

	[Token(Token = "0x170017F6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.UnlockNewTabActivity UnlockNewTabActivity
	{
		[Token(Token = "0x6006E28")]
		[Address(RVA = "0xBD34A0", Offset = "0xBD28A0", VA = "0x180BD34A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E29")]
		[Address(RVA = "0xA1ADF0", Offset = "0xA1A1F0", VA = "0x180A1ADF0")]
		set
		{
		}
	}

	[Token(Token = "0x170017F7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.RankActivity RankActivity
	{
		[Token(Token = "0x6006E2A")]
		[Address(RVA = "0xBD3440", Offset = "0xBD2840", VA = "0x180BD3440")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E2B")]
		[Address(RVA = "0xA1AE30", Offset = "0xA1A230", VA = "0x180A1AE30")]
		set
		{
		}
	}

	[Token(Token = "0x170017F8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PlayerRankUpdateActivity PlayerRankUpdateActivity
	{
		[Token(Token = "0x6006E2C")]
		[Address(RVA = "0xBD33E0", Offset = "0xBD27E0", VA = "0x180BD33E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E2D")]
		[Address(RVA = "0xA1ACB0", Offset = "0xA1A0B0", VA = "0x180A1ACB0")]
		set
		{
		}
	}

	[Token(Token = "0x170017F9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityOneofCase ActivityCase
	{
		[Token(Token = "0x6006E2E")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(ActivityOneofCase);
		}
	}

	[Token(Token = "0x6006E19")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildLogbookEntry()
	{
	}

	[Token(Token = "0x6006E1A")]
	[Address(RVA = "0xBD2F20", Offset = "0xBD2320", VA = "0x180BD2F20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildLogbookEntry(GuildLogbookEntry other)
	{
	}

	[Token(Token = "0x6006E1B")]
	[Address(RVA = "0xBD2360", Offset = "0xBD1760", VA = "0x180BD2360", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLogbookEntry Clone()
	{
		return null;
	}

	[Token(Token = "0x6006E2F")]
	[Address(RVA = "0x91A760", Offset = "0x919B60", VA = "0x18091A760")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearActivity()
	{
	}

	[Token(Token = "0x6006E30")]
	[Address(RVA = "0xBD23C0", Offset = "0xBD17C0", VA = "0x180BD23C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006E31")]
	[Address(RVA = "0xBD2420", Offset = "0xBD1820", VA = "0x180BD2420", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildLogbookEntry other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006E32")]
	[Address(RVA = "0xBD25E0", Offset = "0xBD19E0", VA = "0x180BD25E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006E33")]
	[Address(RVA = "0xBD2DC0", Offset = "0xBD21C0", VA = "0x180BD2DC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006E34")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006E35")]
	[Address(RVA = "0xBD3980", Offset = "0xBD2D80", VA = "0x180BD3980", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006E36")]
	[Address(RVA = "0xBD1F80", Offset = "0xBD1380", VA = "0x180BD1F80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006E37")]
	[Address(RVA = "0xBD2980", Offset = "0xBD1D80", VA = "0x180BD2980", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildLogbookEntry other)
	{
	}

	[Token(Token = "0x6006E38")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006E39")]
	[Address(RVA = "0xBD3500", Offset = "0xBD2900", VA = "0x180BD3500", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
