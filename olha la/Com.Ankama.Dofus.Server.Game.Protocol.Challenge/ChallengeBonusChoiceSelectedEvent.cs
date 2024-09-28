using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008E6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBonusChoiceSelectedEvent : IMessage<ChallengeBonusChoiceSelectedEvent>, IMessage, IEquatable<ChallengeBonusChoiceSelectedEvent>, IDeepCloneable<ChallengeBonusChoiceSelectedEvent>, IBufferMessage
{
	[Token(Token = "0x4001E92")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeBonusChoiceSelectedEvent> _parser;

	[Token(Token = "0x4001E93")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E94")]
	public const int ChallengeBonusFieldNumber = 1;

	[Token(Token = "0x4001E95")]
	[FieldOffset(Offset = "0x18")]
	private ChallengeBonus challengeBonus_;

	[Token(Token = "0x170013F7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChallengeBonusChoiceSelectedEvent> Parser
	{
		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0xB595E0", Offset = "0xB589E0", VA = "0x180B595E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0xB59530", Offset = "0xB58930", VA = "0x180B59530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0xB59630", Offset = "0xB58A30", VA = "0x180B59630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeBonus ChallengeBonus
	{
		[Token(Token = "0x6005E34")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ChallengeBonus);
		}
		[Token(Token = "0x6005E35")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005E31")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBonusChoiceSelectedEvent()
	{
	}

	[Token(Token = "0x6005E32")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeBonusChoiceSelectedEvent(ChallengeBonusChoiceSelectedEvent other)
	{
	}

	[Token(Token = "0x6005E33")]
	[Address(RVA = "0xB592C0", Offset = "0xB586C0", VA = "0x180B592C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeBonusChoiceSelectedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005E36")]
	[Address(RVA = "0xB59340", Offset = "0xB58740", VA = "0x180B59340", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E37")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ChallengeBonusChoiceSelectedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E38")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005E39")]
	[Address(RVA = "0xB593D0", Offset = "0xB587D0", VA = "0x180B593D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005E3A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005E3B")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005E3C")]
	[Address(RVA = "0xB59230", Offset = "0xB58630", VA = "0x180B59230", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005E3D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBonusChoiceSelectedEvent other)
	{
	}

	[Token(Token = "0x6005E3E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005E3F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
