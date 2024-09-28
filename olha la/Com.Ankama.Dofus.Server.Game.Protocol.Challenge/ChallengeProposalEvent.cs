using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008DE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeProposalEvent : IMessage<ChallengeProposalEvent>, IMessage, IEquatable<ChallengeProposalEvent>, IDeepCloneable<ChallengeProposalEvent>, IBufferMessage
{
	[Token(Token = "0x4001E7B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeProposalEvent> _parser;

	[Token(Token = "0x4001E7C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E7D")]
	public const int ChallengeProposalsFieldNumber = 1;

	[Token(Token = "0x4001E7E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge> _repeated_challengeProposals_codec;

	[Token(Token = "0x4001E7F")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge> challengeProposals_;

	[Token(Token = "0x4001E80")]
	public const int TimerFieldNumber = 2;

	[Token(Token = "0x4001E81")]
	[FieldOffset(Offset = "0x20")]
	private long timer_;

	[Token(Token = "0x170013E6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeProposalEvent> Parser
	{
		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0xB5B730", Offset = "0xB5AB30", VA = "0x180B5B730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013E7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0xB5B680", Offset = "0xB5AA80", VA = "0x180B5B680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0xB5B980", Offset = "0xB5AD80", VA = "0x180B5B980", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013E9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge> ChallengeProposals
	{
		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013EA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Timer
	{
		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6005DD8")]
	[Address(RVA = "0xB5B560", Offset = "0xB5A960", VA = "0x180B5B560")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeProposalEvent()
	{
	}

	[Token(Token = "0x6005DD9")]
	[Address(RVA = "0xB5B5E0", Offset = "0xB5A9E0", VA = "0x180B5B5E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeProposalEvent(ChallengeProposalEvent other)
	{
	}

	[Token(Token = "0x6005DDA")]
	[Address(RVA = "0xB5B090", Offset = "0xB5A490", VA = "0x180B5B090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeProposalEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005DDE")]
	[Address(RVA = "0xB5B1F0", Offset = "0xB5A5F0", VA = "0x180B5B1F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DDF")]
	[Address(RVA = "0xB5B150", Offset = "0xB5A550", VA = "0x180B5B150", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeProposalEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005DE0")]
	[Address(RVA = "0x983110", Offset = "0x982510", VA = "0x180983110", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005DE1")]
	[Address(RVA = "0xB5B360", Offset = "0xB5A760", VA = "0x180B5B360", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005DE2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005DE3")]
	[Address(RVA = "0xB5B8B0", Offset = "0xB5ACB0", VA = "0x180B5B8B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005DE4")]
	[Address(RVA = "0xB5AFB0", Offset = "0xB5A3B0", VA = "0x180B5AFB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005DE5")]
	[Address(RVA = "0xB5B2D0", Offset = "0xB5A6D0", VA = "0x180B5B2D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeProposalEvent other)
	{
	}

	[Token(Token = "0x6005DE6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005DE7")]
	[Address(RVA = "0xB5B780", Offset = "0xB5AB80", VA = "0x180B5B780", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
