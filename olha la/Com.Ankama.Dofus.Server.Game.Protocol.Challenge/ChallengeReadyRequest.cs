using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008D2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeReadyRequest : IMessage<ChallengeReadyRequest>, IMessage, IEquatable<ChallengeReadyRequest>, IDeepCloneable<ChallengeReadyRequest>, IBufferMessage
{
	[Token(Token = "0x4001E5A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeReadyRequest> _parser;

	[Token(Token = "0x4001E5B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E5C")]
	public const int ChallengeModFieldNumber = 1;

	[Token(Token = "0x4001E5D")]
	[FieldOffset(Offset = "0x18")]
	private ChallengeMod challengeMod_;

	[Token(Token = "0x170013CD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChallengeReadyRequest> Parser
	{
		[Token(Token = "0x6005D50")]
		[Address(RVA = "0xB5BE10", Offset = "0xB5B210", VA = "0x180B5BE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013CE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005D51")]
		[Address(RVA = "0xB5BD60", Offset = "0xB5B160", VA = "0x180B5BD60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005D52")]
		[Address(RVA = "0xB5BE60", Offset = "0xB5B260", VA = "0x180B5BE60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeMod ChallengeMod
	{
		[Token(Token = "0x6005D56")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ChallengeMod);
		}
		[Token(Token = "0x6005D57")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005D53")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeReadyRequest()
	{
	}

	[Token(Token = "0x6005D54")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeReadyRequest(ChallengeReadyRequest other)
	{
	}

	[Token(Token = "0x6005D55")]
	[Address(RVA = "0xB5BAF0", Offset = "0xB5AEF0", VA = "0x180B5BAF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeReadyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005D58")]
	[Address(RVA = "0xB5BB70", Offset = "0xB5AF70", VA = "0x180B5BB70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D59")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeReadyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D5A")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005D5B")]
	[Address(RVA = "0xB5BC00", Offset = "0xB5B000", VA = "0x180B5BC00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005D5C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005D5D")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005D5E")]
	[Address(RVA = "0xB5BA60", Offset = "0xB5AE60", VA = "0x180B5BA60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005D5F")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChallengeReadyRequest other)
	{
	}

	[Token(Token = "0x6005D60")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005D61")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
