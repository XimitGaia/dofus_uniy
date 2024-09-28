using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008DC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeNumberEvent : IMessage<ChallengeNumberEvent>, IMessage, IEquatable<ChallengeNumberEvent>, IDeepCloneable<ChallengeNumberEvent>, IBufferMessage
{
	[Token(Token = "0x4001E76")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeNumberEvent> _parser;

	[Token(Token = "0x4001E77")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E78")]
	public const int ChallengeNumberFieldNumber = 1;

	[Token(Token = "0x4001E79")]
	[FieldOffset(Offset = "0x18")]
	private int challengeNumber_;

	[Token(Token = "0x170013E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeNumberEvent> Parser
	{
		[Token(Token = "0x6005DBF")]
		[Address(RVA = "0xB5AE80", Offset = "0xB5A280", VA = "0x180B5AE80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005DC0")]
		[Address(RVA = "0xB5ADD0", Offset = "0xB5A1D0", VA = "0x180B5ADD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005DC1")]
		[Address(RVA = "0xB5AED0", Offset = "0xB5A2D0", VA = "0x180B5AED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ChallengeNumber
	{
		[Token(Token = "0x6005DC5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005DC6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005DC2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeNumberEvent()
	{
	}

	[Token(Token = "0x6005DC3")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeNumberEvent(ChallengeNumberEvent other)
	{
	}

	[Token(Token = "0x6005DC4")]
	[Address(RVA = "0xB5AB60", Offset = "0xB59F60", VA = "0x180B5AB60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeNumberEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005DC7")]
	[Address(RVA = "0xB5ABE0", Offset = "0xB59FE0", VA = "0x180B5ABE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DC8")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeNumberEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DC9")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005DCA")]
	[Address(RVA = "0xB5AC70", Offset = "0xB5A070", VA = "0x180B5AC70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005DCB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005DCC")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005DCD")]
	[Address(RVA = "0xB5AAD0", Offset = "0xB59ED0", VA = "0x180B5AAD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005DCE")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChallengeNumberEvent other)
	{
	}

	[Token(Token = "0x6005DCF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005DD0")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
