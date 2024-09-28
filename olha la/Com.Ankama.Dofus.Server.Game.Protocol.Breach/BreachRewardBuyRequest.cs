using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008EF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachRewardBuyRequest : IMessage<BreachRewardBuyRequest>, IMessage, IEquatable<BreachRewardBuyRequest>, IDeepCloneable<BreachRewardBuyRequest>, IBufferMessage
{
	[Token(Token = "0x4001EA3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachRewardBuyRequest> _parser;

	[Token(Token = "0x4001EA4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EA5")]
	public const int RewardIdFieldNumber = 1;

	[Token(Token = "0x4001EA6")]
	[FieldOffset(Offset = "0x18")]
	private int rewardId_;

	[Token(Token = "0x17001406")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BreachRewardBuyRequest> Parser
	{
		[Token(Token = "0x6005E84")]
		[Address(RVA = "0xB550A0", Offset = "0xB544A0", VA = "0x180B550A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001407")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005E85")]
		[Address(RVA = "0xB54FF0", Offset = "0xB543F0", VA = "0x180B54FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001408")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005E86")]
		[Address(RVA = "0xB550F0", Offset = "0xB544F0", VA = "0x180B550F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001409")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardId
	{
		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005E87")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachRewardBuyRequest()
	{
	}

	[Token(Token = "0x6005E88")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRewardBuyRequest(BreachRewardBuyRequest other)
	{
	}

	[Token(Token = "0x6005E89")]
	[Address(RVA = "0xB54D80", Offset = "0xB54180", VA = "0x180B54D80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachRewardBuyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005E8C")]
	[Address(RVA = "0xB54E00", Offset = "0xB54200", VA = "0x180B54E00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E8D")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BreachRewardBuyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005E8E")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005E8F")]
	[Address(RVA = "0xB54E90", Offset = "0xB54290", VA = "0x180B54E90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005E90")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005E91")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005E92")]
	[Address(RVA = "0xB54CF0", Offset = "0xB540F0", VA = "0x180B54CF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005E93")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BreachRewardBuyRequest other)
	{
	}

	[Token(Token = "0x6005E94")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005E95")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
