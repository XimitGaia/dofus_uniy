using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008D6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeListEvent : IMessage<ChallengeListEvent>, IMessage, IEquatable<ChallengeListEvent>, IDeepCloneable<ChallengeListEvent>, IBufferMessage
{
	[Token(Token = "0x4001E64")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeListEvent> _parser;

	[Token(Token = "0x4001E65")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E66")]
	public const int ChallengesFieldNumber = 1;

	[Token(Token = "0x4001E67")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge> _repeated_challenges_codec;

	[Token(Token = "0x4001E68")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge> challenges_;

	[Token(Token = "0x170013D5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeListEvent> Parser
	{
		[Token(Token = "0x6005D7C")]
		[Address(RVA = "0xB59E20", Offset = "0xB59220", VA = "0x180B59E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005D7D")]
		[Address(RVA = "0xB59D70", Offset = "0xB59170", VA = "0x180B59D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005D7E")]
		[Address(RVA = "0xB5A030", Offset = "0xB59430", VA = "0x180B5A030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013D8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge> Challenges
	{
		[Token(Token = "0x6005D82")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D7F")]
	[Address(RVA = "0xB59CF0", Offset = "0xB590F0", VA = "0x180B59CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeListEvent()
	{
	}

	[Token(Token = "0x6005D80")]
	[Address(RVA = "0xB59C60", Offset = "0xB59060", VA = "0x180B59C60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeListEvent(ChallengeListEvent other)
	{
	}

	[Token(Token = "0x6005D81")]
	[Address(RVA = "0xB597B0", Offset = "0xB58BB0", VA = "0x180B597B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005D83")]
	[Address(RVA = "0xB59870", Offset = "0xB58C70", VA = "0x180B59870", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D84")]
	[Address(RVA = "0xB59950", Offset = "0xB58D50", VA = "0x180B59950", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D85")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005D86")]
	[Address(RVA = "0xB59A60", Offset = "0xB58E60", VA = "0x180B59A60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005D87")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005D88")]
	[Address(RVA = "0xB59F80", Offset = "0xB59380", VA = "0x180B59F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005D89")]
	[Address(RVA = "0xB59710", Offset = "0xB58B10", VA = "0x180B59710", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005D8A")]
	[Address(RVA = "0xB599E0", Offset = "0xB58DE0", VA = "0x180B599E0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChallengeListEvent other)
	{
	}

	[Token(Token = "0x6005D8B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005D8C")]
	[Address(RVA = "0xB59E70", Offset = "0xB59270", VA = "0x180B59E70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
