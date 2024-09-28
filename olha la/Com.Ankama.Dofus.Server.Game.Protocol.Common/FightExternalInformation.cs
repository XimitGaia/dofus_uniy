using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A23")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightExternalInformation : IMessage<FightExternalInformation>, IMessage, IEquatable<FightExternalInformation>, IDeepCloneable<FightExternalInformation>, IBufferMessage
{
	[Token(Token = "0x2000A24")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000A25")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class FightTeamsWithOptions : IMessage<FightTeamsWithOptions>, IMessage, IEquatable<FightTeamsWithOptions>, IDeepCloneable<FightTeamsWithOptions>, IBufferMessage
		{
			[Token(Token = "0x4002478")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<FightTeamsWithOptions> _parser;

			[Token(Token = "0x4002479")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400247A")]
			public const int FightTeamFieldNumber = 1;

			[Token(Token = "0x400247B")]
			[FieldOffset(Offset = "0x18")]
			private FightTeamInformation fightTeam_;

			[Token(Token = "0x400247C")]
			public const int FightTeamOptionsFieldNumber = 2;

			[Token(Token = "0x400247D")]
			[FieldOffset(Offset = "0x20")]
			private FightOptionsInformation fightTeamOptions_;

			[Token(Token = "0x170016DE")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<FightTeamsWithOptions> Parser
			{
				[Token(Token = "0x60069F9")]
				[Address(RVA = "0xBC0DC0", Offset = "0xBC01C0", VA = "0x180BC0DC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170016DF")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60069FA")]
				[Address(RVA = "0xBC0D40", Offset = "0xBC0140", VA = "0x180BC0D40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170016E0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60069FB")]
				[Address(RVA = "0xBC0F60", Offset = "0xBC0360", VA = "0x180BC0F60", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170016E1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public FightTeamInformation FightTeam
			{
				[Token(Token = "0x60069FF")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006A00")]
				[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
				set
				{
				}
			}

			[Token(Token = "0x170016E2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightOptionsInformation FightTeamOptions
			{
				[Token(Token = "0x6006A01")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6006A02")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x60069FC")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightTeamsWithOptions()
			{
			}

			[Token(Token = "0x60069FD")]
			[Address(RVA = "0xBC0BF0", Offset = "0xBBFFF0", VA = "0x180BC0BF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightTeamsWithOptions(FightTeamsWithOptions other)
			{
			}

			[Token(Token = "0x60069FE")]
			[Address(RVA = "0xBC06D0", Offset = "0xBBFAD0", VA = "0x180BC06D0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public FightTeamsWithOptions Clone()
			{
				return null;
			}

			[Token(Token = "0x6006A03")]
			[Address(RVA = "0xBC0850", Offset = "0xBBFC50", VA = "0x180BC0850", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006A04")]
			[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(FightTeamsWithOptions other)
			{
				return default(bool);
			}

			[Token(Token = "0x6006A05")]
			[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6006A06")]
			[Address(RVA = "0xBC0A90", Offset = "0xBBFE90", VA = "0x180BC0A90", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6006A07")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6006A08")]
			[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6006A09")]
			[Address(RVA = "0xBC0610", Offset = "0xBBFA10", VA = "0x180BC0610", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6006A0A")]
			[Address(RVA = "0xBC0910", Offset = "0xBBFD10", VA = "0x180BC0910", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(FightTeamsWithOptions other)
			{
			}

			[Token(Token = "0x6006A0B")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6006A0C")]
			[Address(RVA = "0xBC0E10", Offset = "0xBC0210", VA = "0x180BC0E10", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400246B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightExternalInformation> _parser;

	[Token(Token = "0x400246C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400246D")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x400246E")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x400246F")]
	public const int FightTypeFieldNumber = 2;

	[Token(Token = "0x4002470")]
	[FieldOffset(Offset = "0x1C")]
	private FightType fightType_;

	[Token(Token = "0x4002471")]
	public const int FightStartFieldNumber = 3;

	[Token(Token = "0x4002472")]
	[FieldOffset(Offset = "0x20")]
	private long fightStart_;

	[Token(Token = "0x4002473")]
	public const int FightSpectatorLockedFieldNumber = 4;

	[Token(Token = "0x4002474")]
	[FieldOffset(Offset = "0x28")]
	private bool fightSpectatorLocked_;

	[Token(Token = "0x4002475")]
	public const int FightTeamsWithOptionsFieldNumber = 5;

	[Token(Token = "0x4002476")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.FightTeamsWithOptions> _repeated_fightTeamsWithOptions_codec;

	[Token(Token = "0x4002477")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<Types.FightTeamsWithOptions> fightTeamsWithOptions_;

	[Token(Token = "0x170016D6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightExternalInformation> Parser
	{
		[Token(Token = "0x60069DF")]
		[Address(RVA = "0xBB5FE0", Offset = "0xBB53E0", VA = "0x180BB5FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016D7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60069E0")]
		[Address(RVA = "0xBB5F30", Offset = "0xBB5330", VA = "0x180BB5F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016D8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60069E1")]
		[Address(RVA = "0xBB6300", Offset = "0xBB5700", VA = "0x180BB6300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016D9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FightId
	{
		[Token(Token = "0x60069E5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60069E6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170016DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightType FightType
	{
		[Token(Token = "0x60069E7")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(FightType);
		}
		[Token(Token = "0x60069E8")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170016DB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long FightStart
	{
		[Token(Token = "0x60069E9")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60069EA")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170016DC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool FightSpectatorLocked
	{
		[Token(Token = "0x60069EB")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60069EC")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x170016DD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.FightTeamsWithOptions> FightTeamsWithOptions
	{
		[Token(Token = "0x60069ED")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60069E2")]
	[Address(RVA = "0xBB5E00", Offset = "0xBB5200", VA = "0x180BB5E00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightExternalInformation()
	{
	}

	[Token(Token = "0x60069E3")]
	[Address(RVA = "0xBB5E80", Offset = "0xBB5280", VA = "0x180BB5E80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightExternalInformation(FightExternalInformation other)
	{
	}

	[Token(Token = "0x60069E4")]
	[Address(RVA = "0xBB57C0", Offset = "0xBB4BC0", VA = "0x180BB57C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightExternalInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60069EE")]
	[Address(RVA = "0xBB5890", Offset = "0xBB4C90", VA = "0x180BB5890", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60069EF")]
	[Address(RVA = "0xBB5990", Offset = "0xBB4D90", VA = "0x180BB5990", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightExternalInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60069F0")]
	[Address(RVA = "0xBB5A40", Offset = "0xBB4E40", VA = "0x180BB5A40", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60069F1")]
	[Address(RVA = "0xBB5C00", Offset = "0xBB5000", VA = "0x180BB5C00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60069F2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60069F3")]
	[Address(RVA = "0xBB61C0", Offset = "0xBB55C0", VA = "0x180BB61C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60069F4")]
	[Address(RVA = "0xBB5680", Offset = "0xBB4A80", VA = "0x180BB5680", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60069F5")]
	[Address(RVA = "0xBB5B50", Offset = "0xBB4F50", VA = "0x180BB5B50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightExternalInformation other)
	{
	}

	[Token(Token = "0x60069F6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60069F7")]
	[Address(RVA = "0xBB6030", Offset = "0xBB5430", VA = "0x180BB6030", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
