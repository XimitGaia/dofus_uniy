using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x200002C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntAnswerEvent : IMessage<TreasureHuntAnswerEvent>, IMessage, IEquatable<TreasureHuntAnswerEvent>, IDeepCloneable<TreasureHuntAnswerEvent>, IBufferMessage
{
	[Token(Token = "0x200002D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200002E")]
		public enum Result
		{
			[Token(Token = "0x400008E")]
			[OriginalName("ERROR_UNDEFINED")]
			ErrorUndefined,
			[Token(Token = "0x400008F")]
			[OriginalName("ERROR_NO_QUEST_FOUND")]
			ErrorNoQuestFound,
			[Token(Token = "0x4000090")]
			[OriginalName("ERROR_ALREADY_HAVE_QUEST")]
			ErrorAlreadyHaveQuest,
			[Token(Token = "0x4000091")]
			[OriginalName("ERROR_NOT_AVAILABLE")]
			ErrorNotAvailable,
			[Token(Token = "0x4000092")]
			[OriginalName("ERROR_DAILY_LIMIT_EXCEEDED")]
			ErrorDailyLimitExceeded,
			[Token(Token = "0x4000093")]
			[OriginalName("OK")]
			Ok
		}
	}

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntAnswerEvent> _parser;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000089")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x18")]
	private TreasureHuntType questType_;

	[Token(Token = "0x400008B")]
	public const int ResultFieldNumber = 2;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x1C")]
	private Types.Result result_;

	[Token(Token = "0x17000049")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TreasureHuntAnswerEvent> Parser
	{
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x944EC0", Offset = "0x9442C0", VA = "0x180944EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x944E10", Offset = "0x944210", VA = "0x180944E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x944F90", Offset = "0x944390", VA = "0x180944F90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Result Result
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.Result);
		}
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntAnswerEvent()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntAnswerEvent(TreasureHuntAnswerEvent other)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x944B90", Offset = "0x943F90", VA = "0x180944B90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntAnswerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x944C20", Offset = "0x944020", VA = "0x180944C20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TreasureHuntAnswerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x944CB0", Offset = "0x9440B0", VA = "0x180944CB0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x944F10", Offset = "0x944310", VA = "0x180944F10", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x944AD0", Offset = "0x943ED0", VA = "0x180944AD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TreasureHuntAnswerEvent other)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
