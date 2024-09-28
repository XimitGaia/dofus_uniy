using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008E2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeAddEvent : IMessage<ChallengeAddEvent>, IMessage, IEquatable<ChallengeAddEvent>, IDeepCloneable<ChallengeAddEvent>, IBufferMessage
{
	[Token(Token = "0x4001E88")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeAddEvent> _parser;

	[Token(Token = "0x4001E89")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E8A")]
	public const int ChallengeFieldNumber = 1;

	[Token(Token = "0x4001E8B")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge challenge_;

	[Token(Token = "0x170013EF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChallengeAddEvent> Parser
	{
		[Token(Token = "0x6005E02")]
		[Address(RVA = "0xB58B20", Offset = "0xB57F20", VA = "0x180B58B20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005E03")]
		[Address(RVA = "0xB58A70", Offset = "0xB57E70", VA = "0x180B58A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005E04")]
		[Address(RVA = "0xB58C70", Offset = "0xB58070", VA = "0x180B58C70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge Challenge
	{
		[Token(Token = "0x6005E08")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005E09")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6005E05")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeAddEvent()
	{
	}

	[Token(Token = "0x6005E06")]
	[Address(RVA = "0xB58A00", Offset = "0xB57E00", VA = "0x180B58A00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeAddEvent(ChallengeAddEvent other)
	{
	}

	[Token(Token = "0x6005E07")]
	[Address(RVA = "0xB58680", Offset = "0xB57A80", VA = "0x180B58680", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeAddEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005E0A")]
	[Address(RVA = "0xB58720", Offset = "0xB57B20", VA = "0x180B58720", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E0B")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeAddEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E0C")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005E0D")]
	[Address(RVA = "0xB588A0", Offset = "0xB57CA0", VA = "0x180B588A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005E0E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005E0F")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005E10")]
	[Address(RVA = "0xB585F0", Offset = "0xB579F0", VA = "0x180B585F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005E11")]
	[Address(RVA = "0xB587D0", Offset = "0xB57BD0", VA = "0x180B587D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeAddEvent other)
	{
	}

	[Token(Token = "0x6005E12")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005E13")]
	[Address(RVA = "0xB58B70", Offset = "0xB57F70", VA = "0x180B58B70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
