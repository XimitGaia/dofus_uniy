using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008CA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeTargetsRequest : IMessage<ChallengeTargetsRequest>, IMessage, IEquatable<ChallengeTargetsRequest>, IDeepCloneable<ChallengeTargetsRequest>, IBufferMessage
{
	[Token(Token = "0x4001E46")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeTargetsRequest> _parser;

	[Token(Token = "0x4001E47")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E48")]
	public const int ChallengeIdFieldNumber = 1;

	[Token(Token = "0x4001E49")]
	[FieldOffset(Offset = "0x18")]
	private int challengeId_;

	[Token(Token = "0x170013BD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeTargetsRequest> Parser
	{
		[Token(Token = "0x6005CF8")]
		[Address(RVA = "0xB5F460", Offset = "0xB5E860", VA = "0x180B5F460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0xB5F3B0", Offset = "0xB5E7B0", VA = "0x180B5F3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0xB5F4B0", Offset = "0xB5E8B0", VA = "0x180B5F4B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChallengeId
	{
		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005CFB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeTargetsRequest()
	{
	}

	[Token(Token = "0x6005CFC")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeTargetsRequest(ChallengeTargetsRequest other)
	{
	}

	[Token(Token = "0x6005CFD")]
	[Address(RVA = "0xB5F140", Offset = "0xB5E540", VA = "0x180B5F140", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeTargetsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005D00")]
	[Address(RVA = "0xB5F1C0", Offset = "0xB5E5C0", VA = "0x180B5F1C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D01")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeTargetsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D02")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005D03")]
	[Address(RVA = "0xB5F250", Offset = "0xB5E650", VA = "0x180B5F250", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005D04")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005D05")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005D06")]
	[Address(RVA = "0xB5F0B0", Offset = "0xB5E4B0", VA = "0x180B5F0B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005D07")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChallengeTargetsRequest other)
	{
	}

	[Token(Token = "0x6005D08")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005D09")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
