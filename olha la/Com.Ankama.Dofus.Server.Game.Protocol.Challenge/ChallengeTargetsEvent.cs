using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge;

[Token(Token = "0x20008D8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeTargetsEvent : IMessage<ChallengeTargetsEvent>, IMessage, IEquatable<ChallengeTargetsEvent>, IDeepCloneable<ChallengeTargetsEvent>, IBufferMessage
{
	[Token(Token = "0x4001E6A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeTargetsEvent> _parser;

	[Token(Token = "0x4001E6B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E6C")]
	public const int ChallengeFieldNumber = 2;

	[Token(Token = "0x4001E6D")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge challenge_;

	[Token(Token = "0x170013D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeTargetsEvent> Parser
	{
		[Token(Token = "0x6005D91")]
		[Address(RVA = "0xB5EE20", Offset = "0xB5E220", VA = "0x180B5EE20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005D92")]
		[Address(RVA = "0xB5ED70", Offset = "0xB5E170", VA = "0x180B5ED70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005D93")]
		[Address(RVA = "0xB5EFD0", Offset = "0xB5E3D0", VA = "0x180B5EFD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Challenge Challenge
	{
		[Token(Token = "0x6005D97")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D98")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6005D94")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeTargetsEvent()
	{
	}

	[Token(Token = "0x6005D95")]
	[Address(RVA = "0xB58A00", Offset = "0xB57E00", VA = "0x180B58A00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeTargetsEvent(ChallengeTargetsEvent other)
	{
	}

	[Token(Token = "0x6005D96")]
	[Address(RVA = "0xB5E9F0", Offset = "0xB5DDF0", VA = "0x180B5E9F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeTargetsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005D99")]
	[Address(RVA = "0xB5EA90", Offset = "0xB5DE90", VA = "0x180B5EA90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D9A")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeTargetsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D9B")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005D9C")]
	[Address(RVA = "0xB5EC10", Offset = "0xB5E010", VA = "0x180B5EC10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005D9D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005D9E")]
	[Address(RVA = "0xB5EF70", Offset = "0xB5E370", VA = "0x180B5EF70", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005D9F")]
	[Address(RVA = "0xB5E960", Offset = "0xB5DD60", VA = "0x180B5E960", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005DA0")]
	[Address(RVA = "0xB5EB40", Offset = "0xB5DF40", VA = "0x180B5EB40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeTargetsEvent other)
	{
	}

	[Token(Token = "0x6005DA1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005DA2")]
	[Address(RVA = "0xB5EE70", Offset = "0xB5E270", VA = "0x180B5EE70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
