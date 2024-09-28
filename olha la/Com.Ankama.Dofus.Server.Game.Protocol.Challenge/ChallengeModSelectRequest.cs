using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008D0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeModSelectRequest : IMessage<ChallengeModSelectRequest>, IMessage, IEquatable<ChallengeModSelectRequest>, IDeepCloneable<ChallengeModSelectRequest>, IBufferMessage
{
	[Token(Token = "0x4001E55")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeModSelectRequest> _parser;

	[Token(Token = "0x4001E56")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E57")]
	public const int ChallengeModFieldNumber = 1;

	[Token(Token = "0x4001E58")]
	[FieldOffset(Offset = "0x18")]
	private ChallengeMod challengeMod_;

	[Token(Token = "0x170013C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeModSelectRequest> Parser
	{
		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0xB5A4C0", Offset = "0xB598C0", VA = "0x180B5A4C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013CA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0xB5A410", Offset = "0xB59810", VA = "0x180B5A410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0xB5A510", Offset = "0xB59910", VA = "0x180B5A510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeMod ChallengeMod
	{
		[Token(Token = "0x6005D40")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ChallengeMod);
		}
		[Token(Token = "0x6005D41")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005D3D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeModSelectRequest()
	{
	}

	[Token(Token = "0x6005D3E")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeModSelectRequest(ChallengeModSelectRequest other)
	{
	}

	[Token(Token = "0x6005D3F")]
	[Address(RVA = "0xB5A1A0", Offset = "0xB595A0", VA = "0x180B5A1A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeModSelectRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005D42")]
	[Address(RVA = "0xB5A220", Offset = "0xB59620", VA = "0x180B5A220", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D43")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeModSelectRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D44")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005D45")]
	[Address(RVA = "0xB5A2B0", Offset = "0xB596B0", VA = "0x180B5A2B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005D46")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005D47")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005D48")]
	[Address(RVA = "0xB5A110", Offset = "0xB59510", VA = "0x180B5A110", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005D49")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeModSelectRequest other)
	{
	}

	[Token(Token = "0x6005D4A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005D4B")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
