using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x200004B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntFlagAnswerEvent : IMessage<TreasureHuntFlagAnswerEvent>, IMessage, IEquatable<TreasureHuntFlagAnswerEvent>, IDeepCloneable<TreasureHuntFlagAnswerEvent>, IBufferMessage
{
	[Token(Token = "0x200004C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200004D")]
		public enum FlagResult
		{
			[Token(Token = "0x4000102")]
			[OriginalName("ERROR_UNDEFINED")]
			ErrorUndefined,
			[Token(Token = "0x4000103")]
			[OriginalName("OK")]
			Ok,
			[Token(Token = "0x4000104")]
			[OriginalName("WRONG")]
			Wrong,
			[Token(Token = "0x4000105")]
			[OriginalName("TOO_MANY")]
			TooMany,
			[Token(Token = "0x4000106")]
			[OriginalName("ERROR_IMPOSSIBLE")]
			ErrorImpossible,
			[Token(Token = "0x4000107")]
			[OriginalName("WRONG_INDEX")]
			WrongIndex,
			[Token(Token = "0x4000108")]
			[OriginalName("SAME_MAP")]
			SameMap
		}
	}

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntFlagAnswerEvent> _parser;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40000FB")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x18")]
	private TreasureHuntType questType_;

	[Token(Token = "0x40000FD")]
	public const int ResultFieldNumber = 2;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x1C")]
	private Types.FlagResult result_;

	[Token(Token = "0x40000FF")]
	public const int IndexFieldNumber = 3;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x20")]
	private int index_;

	[Token(Token = "0x17000087")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TreasureHuntFlagAnswerEvent> Parser
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x947B90", Offset = "0x946F90", VA = "0x180947B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000088")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x947AE0", Offset = "0x946EE0", VA = "0x180947AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000089")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x947D50", Offset = "0x947150", VA = "0x180947D50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700008B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.FlagResult Result
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.FlagResult);
		}
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700008C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Index
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntFlagAnswerEvent()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntFlagAnswerEvent(TreasureHuntFlagAnswerEvent other)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x9476F0", Offset = "0x946AF0", VA = "0x1809476F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntFlagAnswerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x947780", Offset = "0x946B80", VA = "0x180947780", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureHuntFlagAnswerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x947860", Offset = "0x946C60", VA = "0x180947860", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x947980", Offset = "0x946D80", VA = "0x180947980", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x947CB0", Offset = "0x9470B0", VA = "0x180947CB0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x947610", Offset = "0x946A10", VA = "0x180947610", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TreasureHuntFlagAnswerEvent other)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
