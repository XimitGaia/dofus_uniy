using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x2000911")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachRewardBoughtEvent : IMessage<BreachRewardBoughtEvent>, IMessage, IEquatable<BreachRewardBoughtEvent>, IDeepCloneable<BreachRewardBoughtEvent>, IBufferMessage
{
	[Token(Token = "0x4001F01")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachRewardBoughtEvent> _parser;

	[Token(Token = "0x4001F02")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001F03")]
	public const int RewardIdFieldNumber = 1;

	[Token(Token = "0x4001F04")]
	[FieldOffset(Offset = "0x18")]
	private int rewardId_;

	[Token(Token = "0x4001F05")]
	public const int BoughtFieldNumber = 2;

	[Token(Token = "0x4001F06")]
	[FieldOffset(Offset = "0x1C")]
	private bool bought_;

	[Token(Token = "0x17001449")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachRewardBoughtEvent> Parser
	{
		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0xB54BC0", Offset = "0xB53FC0", VA = "0x180B54BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0xB54B10", Offset = "0xB53F10", VA = "0x180B54B10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0xB54C10", Offset = "0xB54010", VA = "0x180B54C10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700144C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardId
	{
		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700144D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Bought
	{
		[Token(Token = "0x6005FED")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005FEE")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6005FE8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachRewardBoughtEvent()
	{
	}

	[Token(Token = "0x6005FE9")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRewardBoughtEvent(BreachRewardBoughtEvent other)
	{
	}

	[Token(Token = "0x6005FEA")]
	[Address(RVA = "0xB547D0", Offset = "0xB53BD0", VA = "0x180B547D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachRewardBoughtEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005FEF")]
	[Address(RVA = "0xB54860", Offset = "0xB53C60", VA = "0x180B54860", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FF0")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BreachRewardBoughtEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FF1")]
	[Address(RVA = "0xB548F0", Offset = "0xB53CF0", VA = "0x180B548F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005FF2")]
	[Address(RVA = "0xB549B0", Offset = "0xB53DB0", VA = "0x180B549B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005FF3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005FF4")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005FF5")]
	[Address(RVA = "0xB54740", Offset = "0xB53B40", VA = "0x180B54740", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005FF6")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachRewardBoughtEvent other)
	{
	}

	[Token(Token = "0x6005FF7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005FF8")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
