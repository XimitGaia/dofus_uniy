using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D29")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementsPioneerRanksResponse : IMessage<AchievementsPioneerRanksResponse>, IMessage, IEquatable<AchievementsPioneerRanksResponse>, IDeepCloneable<AchievementsPioneerRanksResponse>, IBufferMessage
{
	[Token(Token = "0x2000D2A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000D2B")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class AchievementPioneerRank : IMessage<AchievementPioneerRank>, IMessage, IEquatable<AchievementPioneerRank>, IDeepCloneable<AchievementPioneerRank>, IBufferMessage
		{
			[Token(Token = "0x4003040")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<AchievementPioneerRank> _parser;

			[Token(Token = "0x4003041")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4003042")]
			public const int AchievementIdFieldNumber = 1;

			[Token(Token = "0x4003043")]
			[FieldOffset(Offset = "0x18")]
			private int achievementId_;

			[Token(Token = "0x4003044")]
			public const int PioneerRankFieldNumber = 2;

			[Token(Token = "0x4003045")]
			[FieldOffset(Offset = "0x1C")]
			private int pioneerRank_;

			[Token(Token = "0x17001E42")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<AchievementPioneerRank> Parser
			{
				[Token(Token = "0x6008AAB")]
				[Address(RVA = "0xCA2770", Offset = "0xCA1B70", VA = "0x180CA2770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001E43")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6008AAC")]
				[Address(RVA = "0xCA26F0", Offset = "0xCA1AF0", VA = "0x180CA26F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001E44")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6008AAD")]
				[Address(RVA = "0xCA27C0", Offset = "0xCA1BC0", VA = "0x180CA27C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001E45")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int AchievementId
			{
				[Token(Token = "0x6008AB1")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6008AB2")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17001E46")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int PioneerRank
			{
				[Token(Token = "0x6008AB3")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6008AB4")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x6008AAE")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AchievementPioneerRank()
			{
			}

			[Token(Token = "0x6008AAF")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AchievementPioneerRank(AchievementPioneerRank other)
			{
			}

			[Token(Token = "0x6008AB0")]
			[Address(RVA = "0xCA2470", Offset = "0xCA1870", VA = "0x180CA2470", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public AchievementPioneerRank Clone()
			{
				return null;
			}

			[Token(Token = "0x6008AB5")]
			[Address(RVA = "0xCA2500", Offset = "0xCA1900", VA = "0x180CA2500", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6008AB6")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(AchievementPioneerRank other)
			{
				return default(bool);
			}

			[Token(Token = "0x6008AB7")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6008AB8")]
			[Address(RVA = "0xCA2590", Offset = "0xCA1990", VA = "0x180CA2590", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6008AB9")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6008ABA")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6008ABB")]
			[Address(RVA = "0xCA23B0", Offset = "0xCA17B0", VA = "0x180CA23B0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6008ABC")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(AchievementPioneerRank other)
			{
			}

			[Token(Token = "0x6008ABD")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6008ABE")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400303B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementsPioneerRanksResponse> _parser;

	[Token(Token = "0x400303C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400303D")]
	public const int AchievementsPioneerRanksFieldNumber = 1;

	[Token(Token = "0x400303E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.AchievementPioneerRank> _repeated_achievementsPioneerRanks_codec;

	[Token(Token = "0x400303F")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.AchievementPioneerRank> achievementsPioneerRanks_;

	[Token(Token = "0x17001E3E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementsPioneerRanksResponse> Parser
	{
		[Token(Token = "0x6008A99")]
		[Address(RVA = "0xCA8D90", Offset = "0xCA8190", VA = "0x180CA8D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E3F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008A9A")]
		[Address(RVA = "0xCA8CE0", Offset = "0xCA80E0", VA = "0x180CA8CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008A9B")]
		[Address(RVA = "0xCA8FA0", Offset = "0xCA83A0", VA = "0x180CA8FA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E41")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.AchievementPioneerRank> AchievementsPioneerRanks
	{
		[Token(Token = "0x6008A9F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008A9C")]
	[Address(RVA = "0xCA8C60", Offset = "0xCA8060", VA = "0x180CA8C60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsPioneerRanksResponse()
	{
	}

	[Token(Token = "0x6008A9D")]
	[Address(RVA = "0xCA8BD0", Offset = "0xCA7FD0", VA = "0x180CA8BD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsPioneerRanksResponse(AchievementsPioneerRanksResponse other)
	{
	}

	[Token(Token = "0x6008A9E")]
	[Address(RVA = "0xCA8720", Offset = "0xCA7B20", VA = "0x180CA8720", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsPioneerRanksResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6008AA0")]
	[Address(RVA = "0xCA8870", Offset = "0xCA7C70", VA = "0x180CA8870", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008AA1")]
	[Address(RVA = "0xCA87E0", Offset = "0xCA7BE0", VA = "0x180CA87E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AchievementsPioneerRanksResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008AA2")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008AA3")]
	[Address(RVA = "0xCA89D0", Offset = "0xCA7DD0", VA = "0x180CA89D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008AA4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008AA5")]
	[Address(RVA = "0xCA8EF0", Offset = "0xCA82F0", VA = "0x180CA8EF0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008AA6")]
	[Address(RVA = "0xCA8680", Offset = "0xCA7A80", VA = "0x180CA8680", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008AA7")]
	[Address(RVA = "0xCA8950", Offset = "0xCA7D50", VA = "0x180CA8950", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AchievementsPioneerRanksResponse other)
	{
	}

	[Token(Token = "0x6008AA8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008AA9")]
	[Address(RVA = "0xCA8DE0", Offset = "0xCA81E0", VA = "0x180CA8DE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
