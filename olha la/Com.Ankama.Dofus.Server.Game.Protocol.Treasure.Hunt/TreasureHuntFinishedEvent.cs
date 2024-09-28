using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x2000045")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntFinishedEvent : IMessage<TreasureHuntFinishedEvent>, IMessage, IEquatable<TreasureHuntFinishedEvent>, IDeepCloneable<TreasureHuntFinishedEvent>, IBufferMessage
{
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntFinishedEvent> _parser;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40000E3")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x18")]
	private TreasureHuntType questType_;

	[Token(Token = "0x1700007C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TreasureHuntFinishedEvent> Parser
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x9474E0", Offset = "0x9468E0", VA = "0x1809474E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x947430", Offset = "0x946830", VA = "0x180947430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x947530", Offset = "0x946930", VA = "0x180947530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntFinishedEvent()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntFinishedEvent(TreasureHuntFinishedEvent other)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x9471C0", Offset = "0x9465C0", VA = "0x1809471C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntFinishedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x947240", Offset = "0x946640", VA = "0x180947240", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureHuntFinishedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x9472D0", Offset = "0x9466D0", VA = "0x1809472D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x947130", Offset = "0x946530", VA = "0x180947130", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TreasureHuntFinishedEvent other)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
