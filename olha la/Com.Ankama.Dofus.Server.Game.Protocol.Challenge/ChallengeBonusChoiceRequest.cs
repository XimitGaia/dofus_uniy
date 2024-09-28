using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008D4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBonusChoiceRequest : IMessage<ChallengeBonusChoiceRequest>, IMessage, IEquatable<ChallengeBonusChoiceRequest>, IDeepCloneable<ChallengeBonusChoiceRequest>, IBufferMessage
{
	[Token(Token = "0x4001E5F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeBonusChoiceRequest> _parser;

	[Token(Token = "0x4001E60")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E61")]
	public const int ChallengeBonusFieldNumber = 1;

	[Token(Token = "0x4001E62")]
	[FieldOffset(Offset = "0x18")]
	private ChallengeBonus challengeBonus_;

	[Token(Token = "0x170013D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBonusChoiceRequest> Parser
	{
		[Token(Token = "0x6005D66")]
		[Address(RVA = "0xB59100", Offset = "0xB58500", VA = "0x180B59100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013D2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005D67")]
		[Address(RVA = "0xB59050", Offset = "0xB58450", VA = "0x180B59050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013D3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005D68")]
		[Address(RVA = "0xB59150", Offset = "0xB58550", VA = "0x180B59150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeBonus ChallengeBonus
	{
		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ChallengeBonus);
		}
		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005D69")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBonusChoiceRequest()
	{
	}

	[Token(Token = "0x6005D6A")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBonusChoiceRequest(ChallengeBonusChoiceRequest other)
	{
	}

	[Token(Token = "0x6005D6B")]
	[Address(RVA = "0xB58DE0", Offset = "0xB581E0", VA = "0x180B58DE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBonusChoiceRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005D6E")]
	[Address(RVA = "0xB58E60", Offset = "0xB58260", VA = "0x180B58E60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D6F")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBonusChoiceRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D70")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005D71")]
	[Address(RVA = "0xB58EF0", Offset = "0xB582F0", VA = "0x180B58EF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005D72")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005D73")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005D74")]
	[Address(RVA = "0xB58D50", Offset = "0xB58150", VA = "0x180B58D50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005D75")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBonusChoiceRequest other)
	{
	}

	[Token(Token = "0x6005D76")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005D77")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
