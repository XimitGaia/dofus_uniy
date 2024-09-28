using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D25")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementRewardResultEvent : IMessage<AchievementRewardResultEvent>, IMessage, IEquatable<AchievementRewardResultEvent>, IDeepCloneable<AchievementRewardResultEvent>, IBufferMessage
{
	[Token(Token = "0x4003031")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementRewardResultEvent> _parser;

	[Token(Token = "0x4003032")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003033")]
	public const int AchievementIdFieldNumber = 1;

	[Token(Token = "0x4003034")]
	[FieldOffset(Offset = "0x18")]
	private int achievementId_;

	[Token(Token = "0x4003035")]
	public const int SuccessFieldNumber = 2;

	[Token(Token = "0x4003036")]
	[FieldOffset(Offset = "0x1C")]
	private bool success_;

	[Token(Token = "0x17001E36")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementRewardResultEvent> Parser
	{
		[Token(Token = "0x6008A6D")]
		[Address(RVA = "0xCA4F50", Offset = "0xCA4350", VA = "0x180CA4F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E37")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008A6E")]
		[Address(RVA = "0xCA4EA0", Offset = "0xCA42A0", VA = "0x180CA4EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E38")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008A6F")]
		[Address(RVA = "0xCA4FA0", Offset = "0xCA43A0", VA = "0x180CA4FA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E39")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AchievementId
	{
		[Token(Token = "0x6008A73")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008A74")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001E3A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Success
	{
		[Token(Token = "0x6008A75")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008A76")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6008A70")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementRewardResultEvent()
	{
	}

	[Token(Token = "0x6008A71")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementRewardResultEvent(AchievementRewardResultEvent other)
	{
	}

	[Token(Token = "0x6008A72")]
	[Address(RVA = "0xCA4B60", Offset = "0xCA3F60", VA = "0x180CA4B60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementRewardResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008A77")]
	[Address(RVA = "0xCA4BF0", Offset = "0xCA3FF0", VA = "0x180CA4BF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A78")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AchievementRewardResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A79")]
	[Address(RVA = "0xCA4C80", Offset = "0xCA4080", VA = "0x180CA4C80", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008A7A")]
	[Address(RVA = "0xCA4D40", Offset = "0xCA4140", VA = "0x180CA4D40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008A7B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008A7C")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008A7D")]
	[Address(RVA = "0xCA4AD0", Offset = "0xCA3ED0", VA = "0x180CA4AD0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008A7E")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AchievementRewardResultEvent other)
	{
	}

	[Token(Token = "0x6008A7F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008A80")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
