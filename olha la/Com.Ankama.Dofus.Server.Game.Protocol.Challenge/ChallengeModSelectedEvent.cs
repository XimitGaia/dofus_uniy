using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008E4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeModSelectedEvent : IMessage<ChallengeModSelectedEvent>, IMessage, IEquatable<ChallengeModSelectedEvent>, IDeepCloneable<ChallengeModSelectedEvent>, IBufferMessage
{
	[Token(Token = "0x4001E8D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeModSelectedEvent> _parser;

	[Token(Token = "0x4001E8E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E8F")]
	public const int ChallengeModFieldNumber = 1;

	[Token(Token = "0x4001E90")]
	[FieldOffset(Offset = "0x18")]
	private ChallengeMod challengeMod_;

	[Token(Token = "0x170013F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeModSelectedEvent> Parser
	{
		[Token(Token = "0x6005E18")]
		[Address(RVA = "0xB5A9A0", Offset = "0xB59DA0", VA = "0x180B5A9A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005E19")]
		[Address(RVA = "0xB5A8F0", Offset = "0xB59CF0", VA = "0x180B5A8F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0xB5A9F0", Offset = "0xB59DF0", VA = "0x180B5A9F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeMod ChallengeMod
	{
		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ChallengeMod);
		}
		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005E1B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeModSelectedEvent()
	{
	}

	[Token(Token = "0x6005E1C")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeModSelectedEvent(ChallengeModSelectedEvent other)
	{
	}

	[Token(Token = "0x6005E1D")]
	[Address(RVA = "0xB5A680", Offset = "0xB59A80", VA = "0x180B5A680", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeModSelectedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005E20")]
	[Address(RVA = "0xB5A700", Offset = "0xB59B00", VA = "0x180B5A700", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E21")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeModSelectedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E22")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005E23")]
	[Address(RVA = "0xB5A790", Offset = "0xB59B90", VA = "0x180B5A790", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005E24")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005E25")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005E26")]
	[Address(RVA = "0xB5A5F0", Offset = "0xB599F0", VA = "0x180B5A5F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005E27")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeModSelectedEvent other)
	{
	}

	[Token(Token = "0x6005E28")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005E29")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
