using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008CC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeSelectionRequest : IMessage<ChallengeSelectionRequest>, IMessage, IEquatable<ChallengeSelectionRequest>, IDeepCloneable<ChallengeSelectionRequest>, IBufferMessage
{
	[Token(Token = "0x4001E4B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeSelectionRequest> _parser;

	[Token(Token = "0x4001E4C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E4D")]
	public const int ChallengeIdFieldNumber = 1;

	[Token(Token = "0x4001E4E")]
	[FieldOffset(Offset = "0x18")]
	private int challengeId_;

	[Token(Token = "0x170013C1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChallengeSelectionRequest> Parser
	{
		[Token(Token = "0x6005D0E")]
		[Address(RVA = "0xB5E830", Offset = "0xB5DC30", VA = "0x180B5E830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005D0F")]
		[Address(RVA = "0xB5E780", Offset = "0xB5DB80", VA = "0x180B5E780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005D10")]
		[Address(RVA = "0xB5E880", Offset = "0xB5DC80", VA = "0x180B5E880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChallengeId
	{
		[Token(Token = "0x6005D14")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005D15")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005D11")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeSelectionRequest()
	{
	}

	[Token(Token = "0x6005D12")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeSelectionRequest(ChallengeSelectionRequest other)
	{
	}

	[Token(Token = "0x6005D13")]
	[Address(RVA = "0xB5E510", Offset = "0xB5D910", VA = "0x180B5E510", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeSelectionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005D16")]
	[Address(RVA = "0xB5E590", Offset = "0xB5D990", VA = "0x180B5E590", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D17")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeSelectionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D18")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005D19")]
	[Address(RVA = "0xB5E620", Offset = "0xB5DA20", VA = "0x180B5E620", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005D1A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005D1B")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005D1C")]
	[Address(RVA = "0xB5E480", Offset = "0xB5D880", VA = "0x180B5E480", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005D1D")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeSelectionRequest other)
	{
	}

	[Token(Token = "0x6005D1E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005D1F")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
