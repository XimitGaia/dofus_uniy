using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004E4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestTabContributionsEvent : IMessage<GuildChestTabContributionsEvent>, IMessage, IEquatable<GuildChestTabContributionsEvent>, IDeepCloneable<GuildChestTabContributionsEvent>, IBufferMessage
{
	[Token(Token = "0x20004E5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20004E6")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Contribution : IMessage<Contribution>, IMessage, IEquatable<Contribution>, IDeepCloneable<Contribution>, IBufferMessage
		{
			[Token(Token = "0x40010A7")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Contribution> _parser;

			[Token(Token = "0x40010A8")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40010A9")]
			public const int ContributorIdFieldNumber = 1;

			[Token(Token = "0x40010AA")]
			[FieldOffset(Offset = "0x18")]
			private long contributorId_;

			[Token(Token = "0x40010AB")]
			public const int ContributorNameFieldNumber = 2;

			[Token(Token = "0x40010AC")]
			[FieldOffset(Offset = "0x20")]
			private string contributorName_;

			[Token(Token = "0x40010AD")]
			public const int AmountFieldNumber = 3;

			[Token(Token = "0x40010AE")]
			[FieldOffset(Offset = "0x28")]
			private long amount_;

			[Token(Token = "0x17000AF6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Contribution> Parser
			{
				[Token(Token = "0x60033B3")]
				[Address(RVA = "0x9E2680", Offset = "0x9E1A80", VA = "0x1809E2680")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000AF7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60033B4")]
				[Address(RVA = "0x9E2600", Offset = "0x9E1A00", VA = "0x1809E2600")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000AF8")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60033B5")]
				[Address(RVA = "0x9E2870", Offset = "0x9E1C70", VA = "0x1809E2870", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000AF9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long ContributorId
			{
				[Token(Token = "0x60033B9")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60033BA")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x17000AFA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string ContributorName
			{
				[Token(Token = "0x60033BB")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x60033BC")]
				[Address(RVA = "0x9E2920", Offset = "0x9E1D20", VA = "0x1809E2920")]
				set
				{
				}
			}

			[Token(Token = "0x17000AFB")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long Amount
			{
				[Token(Token = "0x60033BD")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60033BE")]
				[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
				set
				{
				}
			}

			[Token(Token = "0x60033B6")]
			[Address(RVA = "0x9E2500", Offset = "0x9E1900", VA = "0x1809E2500")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Contribution()
			{
			}

			[Token(Token = "0x60033B7")]
			[Address(RVA = "0x9E2550", Offset = "0x9E1950", VA = "0x1809E2550")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public Contribution(Contribution other)
			{
			}

			[Token(Token = "0x60033B8")]
			[Address(RVA = "0x9E2050", Offset = "0x9E1450", VA = "0x1809E2050", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Contribution Clone()
			{
				return null;
			}

			[Token(Token = "0x60033BF")]
			[Address(RVA = "0x9E2130", Offset = "0x9E1530", VA = "0x1809E2130", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60033C0")]
			[Address(RVA = "0x9E21F0", Offset = "0x9E15F0", VA = "0x1809E21F0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Contribution other)
			{
				return default(bool);
			}

			[Token(Token = "0x60033C1")]
			[Address(RVA = "0x9E2270", Offset = "0x9E1670", VA = "0x1809E2270", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60033C2")]
			[Address(RVA = "0x9E23A0", Offset = "0x9E17A0", VA = "0x1809E23A0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60033C3")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60033C4")]
			[Address(RVA = "0x9E27C0", Offset = "0x9E1BC0", VA = "0x1809E27C0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60033C5")]
			[Address(RVA = "0x9E1F60", Offset = "0x9E1360", VA = "0x1809E1F60", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60033C6")]
			[Address(RVA = "0x9E2320", Offset = "0x9E1720", VA = "0x1809E2320", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Contribution other)
			{
			}

			[Token(Token = "0x60033C7")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60033C8")]
			[Address(RVA = "0x9E26D0", Offset = "0x9E1AD0", VA = "0x1809E26D0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestTabContributionsEvent> _parser;

	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010A4")]
	public const int ContributionsFieldNumber = 1;

	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.Contribution> _repeated_contributions_codec;

	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Types.Contribution> contributions_;

	[Token(Token = "0x17000AF2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildChestTabContributionsEvent> Parser
	{
		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x9F0520", Offset = "0x9EF920", VA = "0x1809F0520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AF3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x9F0470", Offset = "0x9EF870", VA = "0x1809F0470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AF4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x9F0730", Offset = "0x9EFB30", VA = "0x1809F0730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AF5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Types.Contribution> Contributions
	{
		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60033A4")]
	[Address(RVA = "0x9F0360", Offset = "0x9EF760", VA = "0x1809F0360")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabContributionsEvent()
	{
	}

	[Token(Token = "0x60033A5")]
	[Address(RVA = "0x9F03E0", Offset = "0x9EF7E0", VA = "0x1809F03E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabContributionsEvent(GuildChestTabContributionsEvent other)
	{
	}

	[Token(Token = "0x60033A6")]
	[Address(RVA = "0x9EFEB0", Offset = "0x9EF2B0", VA = "0x1809EFEB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabContributionsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60033A8")]
	[Address(RVA = "0x9EFF70", Offset = "0x9EF370", VA = "0x1809EFF70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x9F0050", Offset = "0x9EF450", VA = "0x1809F0050", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildChestTabContributionsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60033AA")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60033AB")]
	[Address(RVA = "0x9F0160", Offset = "0x9EF560", VA = "0x1809F0160", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60033AC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60033AD")]
	[Address(RVA = "0x9F0680", Offset = "0x9EFA80", VA = "0x1809F0680", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60033AE")]
	[Address(RVA = "0x9EFE10", Offset = "0x9EF210", VA = "0x1809EFE10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60033AF")]
	[Address(RVA = "0x9F00E0", Offset = "0x9EF4E0", VA = "0x1809F00E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestTabContributionsEvent other)
	{
	}

	[Token(Token = "0x60033B0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60033B1")]
	[Address(RVA = "0x9F0570", Offset = "0x9EF970", VA = "0x1809F0570", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
