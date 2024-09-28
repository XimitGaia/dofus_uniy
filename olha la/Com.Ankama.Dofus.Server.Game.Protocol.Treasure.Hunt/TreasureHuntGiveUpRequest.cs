using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt;

[Token(Token = "0x2000026")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureHuntGiveUpRequest : IMessage<TreasureHuntGiveUpRequest>, IMessage, IEquatable<TreasureHuntGiveUpRequest>, IDeepCloneable<TreasureHuntGiveUpRequest>, IBufferMessage
{
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TreasureHuntGiveUpRequest> _parser;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000079")]
	public const int QuestTypeFieldNumber = 1;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x18")]
	private TreasureHuntType questType_;

	[Token(Token = "0x1700003D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TreasureHuntGiveUpRequest> Parser
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x9493B0", Offset = "0x9487B0", VA = "0x1809493B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x949300", Offset = "0x948700", VA = "0x180949300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000040")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntType QuestType
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(TreasureHuntType);
		}
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TreasureHuntGiveUpRequest()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntGiveUpRequest(TreasureHuntGiveUpRequest other)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x949090", Offset = "0x948490", VA = "0x180949090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureHuntGiveUpRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x949110", Offset = "0x948510", VA = "0x180949110", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureHuntGiveUpRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x949000", Offset = "0x948400", VA = "0x180949000", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TreasureHuntGiveUpRequest other)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
