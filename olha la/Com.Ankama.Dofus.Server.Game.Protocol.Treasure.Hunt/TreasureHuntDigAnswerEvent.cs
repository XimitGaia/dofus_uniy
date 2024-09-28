using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x2000047")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntDigAnswerEvent : IMessage<TreasureHuntDigAnswerEvent>, IMessage, IEquatable<TreasureHuntDigAnswerEvent>, IDeepCloneable<TreasureHuntDigAnswerEvent>, IBufferMessage
{
	[Token(Token = "0x2000048")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000049")]
		public enum DigResult
		{
			[Token(Token = "0x40000F1")]
			[OriginalName("ERROR_UNDEFINED")]
			ErrorUndefined,
			[Token(Token = "0x40000F2")]
			[OriginalName("NEW_HINT")]
			NewHint,
			[Token(Token = "0x40000F3")]
			[OriginalName("FINISHED")]
			Finished,
			[Token(Token = "0x40000F4")]
			[OriginalName("WRONG")]
			Wrong,
			[Token(Token = "0x40000F5")]
			[OriginalName("LOST")]
			Lost,
			[Token(Token = "0x40000F6")]
			[OriginalName("ERROR_IMPOSSIBLE")]
			ErrorImpossible,
			[Token(Token = "0x40000F7")]
			[OriginalName("WRONG_AND_YOU_KNOW_IT")]
			WrongAndYouKnowIt
		}
	}

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntDigAnswerEvent> _parser;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40000E9")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x1C")]
	private TreasureHuntType questType_;

	[Token(Token = "0x40000EB")]
	public const int ResultFieldNumber = 2;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x20")]
	private Types.DigResult result_;

	[Token(Token = "0x40000ED")]
	public const int WrongFlagCountFieldNumber = 3;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int WrongFlagCountDefaultValue;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x24")]
	private int wrongFlagCount_;

	[Token(Token = "0x17000080")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TreasureHuntDigAnswerEvent> Parser
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x945760", Offset = "0x944B60", VA = "0x180945760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000081")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x9456B0", Offset = "0x944AB0", VA = "0x1809456B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000082")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x9459D0", Offset = "0x944DD0", VA = "0x1809459D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000083")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000084")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.DigResult Result
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Types.DigResult);
		}
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000085")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WrongFlagCount
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x9457B0", Offset = "0x944BB0", VA = "0x1809457B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x945AB0", Offset = "0x944EB0", VA = "0x180945AB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000086")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasWrongFlagCount
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntDigAnswerEvent()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntDigAnswerEvent(TreasureHuntDigAnswerEvent other)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x9451A0", Offset = "0x9445A0", VA = "0x1809451A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntDigAnswerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearWrongFlagCount()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x9452B0", Offset = "0x9446B0", VA = "0x1809452B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x945230", Offset = "0x944630", VA = "0x180945230", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TreasureHuntDigAnswerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x945370", Offset = "0x944770", VA = "0x180945370", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x9454E0", Offset = "0x9448E0", VA = "0x1809454E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x9458F0", Offset = "0x944CF0", VA = "0x1809458F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x945070", Offset = "0x944470", VA = "0x180945070", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x945470", Offset = "0x944870", VA = "0x180945470", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TreasureHuntDigAnswerEvent other)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x945820", Offset = "0x944C20", VA = "0x180945820", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
