using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008E0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeSelectedEvent : IMessage<ChallengeSelectedEvent>, IMessage, IEquatable<ChallengeSelectedEvent>, IDeepCloneable<ChallengeSelectedEvent>, IBufferMessage
{
	[Token(Token = "0x4001E83")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeSelectedEvent> _parser;

	[Token(Token = "0x4001E84")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E85")]
	public const int ChallengeFieldNumber = 1;

	[Token(Token = "0x4001E86")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge challenge_;

	[Token(Token = "0x170013EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeSelectedEvent> Parser
	{
		[Token(Token = "0x6005DEC")]
		[Address(RVA = "0xB5E250", Offset = "0xB5D650", VA = "0x180B5E250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005DED")]
		[Address(RVA = "0xB5E1A0", Offset = "0xB5D5A0", VA = "0x180B5E1A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013ED")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005DEE")]
		[Address(RVA = "0xB5E3A0", Offset = "0xB5D7A0", VA = "0x180B5E3A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge Challenge
	{
		[Token(Token = "0x6005DF2")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005DF3")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6005DEF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeSelectedEvent()
	{
	}

	[Token(Token = "0x6005DF0")]
	[Address(RVA = "0xB58A00", Offset = "0xB57E00", VA = "0x180B58A00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeSelectedEvent(ChallengeSelectedEvent other)
	{
	}

	[Token(Token = "0x6005DF1")]
	[Address(RVA = "0xB5DE20", Offset = "0xB5D220", VA = "0x180B5DE20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeSelectedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005DF4")]
	[Address(RVA = "0xB5DEC0", Offset = "0xB5D2C0", VA = "0x180B5DEC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DF5")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeSelectedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DF6")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005DF7")]
	[Address(RVA = "0xB5E040", Offset = "0xB5D440", VA = "0x180B5E040", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005DF8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005DF9")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005DFA")]
	[Address(RVA = "0xB5DD90", Offset = "0xB5D190", VA = "0x180B5DD90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005DFB")]
	[Address(RVA = "0xB5DF70", Offset = "0xB5D370", VA = "0x180B5DF70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeSelectedEvent other)
	{
	}

	[Token(Token = "0x6005DFC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005DFD")]
	[Address(RVA = "0xB5E2A0", Offset = "0xB5D6A0", VA = "0x180B5E2A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
