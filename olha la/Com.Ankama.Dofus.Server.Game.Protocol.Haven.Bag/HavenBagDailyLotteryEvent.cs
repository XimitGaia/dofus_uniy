using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200043F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagDailyLotteryEvent : IMessage<HavenBagDailyLotteryEvent>, IMessage, IEquatable<HavenBagDailyLotteryEvent>, IDeepCloneable<HavenBagDailyLotteryEvent>, IBufferMessage
{
	[Token(Token = "0x2000440")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000441")]
		public enum DailyLotteryResult
		{
			[Token(Token = "0x4000EB4")]
			[OriginalName("HAVEN_BAG_DAILY_LOTTERY_OK")]
			HavenBagDailyLotteryOk,
			[Token(Token = "0x4000EB5")]
			[OriginalName("HAVEN_BAG_DAILY_LOTTERY_ALREADY_USED")]
			HavenBagDailyLotteryAlreadyUsed,
			[Token(Token = "0x4000EB6")]
			[OriginalName("HAVEN_BAG_DAILY_LOTTERY_ERROR")]
			HavenBagDailyLotteryError
		}
	}

	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagDailyLotteryEvent> _parser;

	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4000EAE")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x1C")]
	private Types.DailyLotteryResult result_;

	[Token(Token = "0x4000EB0")]
	public const int GameActionIdFieldNumber = 2;

	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x8")]
	private static readonly long GameActionIdDefaultValue;

	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0x20")]
	private long gameActionId_;

	[Token(Token = "0x17000991")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HavenBagDailyLotteryEvent> Parser
	{
		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x9B9070", Offset = "0x9B8470", VA = "0x1809B9070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000992")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002CC5")]
		[Address(RVA = "0x9B8F50", Offset = "0x9B8350", VA = "0x1809B8F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000993")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x9B9240", Offset = "0x9B8640", VA = "0x1809B9240", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000994")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.DailyLotteryResult Result
	{
		[Token(Token = "0x6002CCA")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.DailyLotteryResult);
		}
		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000995")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long GameActionId
	{
		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x9B9000", Offset = "0x9B8400", VA = "0x1809B9000")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x9B9320", Offset = "0x9B8720", VA = "0x1809B9320")]
		set
		{
		}
	}

	[Token(Token = "0x17000996")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasGameActionId
	{
		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002CC7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagDailyLotteryEvent()
	{
	}

	[Token(Token = "0x6002CC8")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagDailyLotteryEvent(HavenBagDailyLotteryEvent other)
	{
	}

	[Token(Token = "0x6002CC9")]
	[Address(RVA = "0x9B8AC0", Offset = "0x9B7EC0", VA = "0x1809B8AC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagDailyLotteryEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002CCF")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGameActionId()
	{
	}

	[Token(Token = "0x6002CD0")]
	[Address(RVA = "0x9B8B50", Offset = "0x9B7F50", VA = "0x1809B8B50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CD1")]
	[Address(RVA = "0x9B8C10", Offset = "0x9B8010", VA = "0x1809B8C10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagDailyLotteryEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CD2")]
	[Address(RVA = "0x9B8C90", Offset = "0x9B8090", VA = "0x1809B8C90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002CD3")]
	[Address(RVA = "0x9B8DE0", Offset = "0x9B81E0", VA = "0x1809B8DE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002CD4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002CD5")]
	[Address(RVA = "0x9B9180", Offset = "0x9B8580", VA = "0x1809B9180", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002CD6")]
	[Address(RVA = "0x9B89B0", Offset = "0x9B7DB0", VA = "0x1809B89B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002CD7")]
	[Address(RVA = "0x9B8D70", Offset = "0x9B8170", VA = "0x1809B8D70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagDailyLotteryEvent other)
	{
	}

	[Token(Token = "0x6002CD8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002CD9")]
	[Address(RVA = "0x9B90C0", Offset = "0x9B84C0", VA = "0x1809B90C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
