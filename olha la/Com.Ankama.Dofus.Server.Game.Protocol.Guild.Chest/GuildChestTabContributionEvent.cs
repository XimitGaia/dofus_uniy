using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004EB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestTabContributionEvent : IMessage<GuildChestTabContributionEvent>, IMessage, IEquatable<GuildChestTabContributionEvent>, IDeepCloneable<GuildChestTabContributionEvent>, IBufferMessage
{
	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestTabContributionEvent> _parser;

	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010B8")]
	public const int TabNumberFieldNumber = 1;

	[Token(Token = "0x40010B9")]
	[FieldOffset(Offset = "0x18")]
	private int tabNumber_;

	[Token(Token = "0x40010BA")]
	public const int RequiredAmountFieldNumber = 2;

	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x20")]
	private long requiredAmount_;

	[Token(Token = "0x40010BC")]
	public const int CurrentAmountFieldNumber = 3;

	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x28")]
	private long currentAmount_;

	[Token(Token = "0x40010BE")]
	public const int ChestContributionEnrollmentDelayFieldNumber = 4;

	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x30")]
	private long chestContributionEnrollmentDelay_;

	[Token(Token = "0x40010C0")]
	public const int ChestContributionDelayFieldNumber = 5;

	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x38")]
	private long chestContributionDelay_;

	[Token(Token = "0x17000B00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildChestTabContributionEvent> Parser
	{
		[Token(Token = "0x60033E6")]
		[Address(RVA = "0x9EFAD0", Offset = "0x9EEED0", VA = "0x1809EFAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B01")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x9EFA20", Offset = "0x9EEE20", VA = "0x1809EFA20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B02")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x9EFD20", Offset = "0x9EF120", VA = "0x1809EFD20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B03")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TabNumber
	{
		[Token(Token = "0x60033EC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000B04")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long RequiredAmount
	{
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B05")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CurrentAmount
	{
		[Token(Token = "0x60033F0")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60033F1")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000B06")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ChestContributionEnrollmentDelay
	{
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B07")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ChestContributionDelay
	{
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x9EFE00", Offset = "0x9EF200", VA = "0x1809EFE00")]
		set
		{
		}
	}

	[Token(Token = "0x60033E9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabContributionEvent()
	{
	}

	[Token(Token = "0x60033EA")]
	[Address(RVA = "0x9EF9B0", Offset = "0x9EEDB0", VA = "0x1809EF9B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestTabContributionEvent(GuildChestTabContributionEvent other)
	{
	}

	[Token(Token = "0x60033EB")]
	[Address(RVA = "0x9EF540", Offset = "0x9EE940", VA = "0x1809EF540", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabContributionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60033F6")]
	[Address(RVA = "0x9EF630", Offset = "0x9EEA30", VA = "0x1809EF630", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60033F7")]
	[Address(RVA = "0x9EF5E0", Offset = "0x9EE9E0", VA = "0x1809EF5E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestTabContributionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60033F8")]
	[Address(RVA = "0x9EF6E0", Offset = "0x9EEAE0", VA = "0x1809EF6E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60033F9")]
	[Address(RVA = "0x9EF850", Offset = "0x9EEC50", VA = "0x1809EF850", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60033FA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60033FB")]
	[Address(RVA = "0x9EFC40", Offset = "0x9EF040", VA = "0x1809EFC40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60033FC")]
	[Address(RVA = "0x9EF400", Offset = "0x9EE800", VA = "0x1809EF400", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60033FD")]
	[Address(RVA = "0x9EF7C0", Offset = "0x9EEBC0", VA = "0x1809EF7C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildChestTabContributionEvent other)
	{
	}

	[Token(Token = "0x60033FE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60033FF")]
	[Address(RVA = "0x9EFB20", Offset = "0x9EEF20", VA = "0x1809EFB20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
