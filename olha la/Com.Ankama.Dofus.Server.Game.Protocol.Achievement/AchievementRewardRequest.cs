using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D17")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementRewardRequest : IMessage<AchievementRewardRequest>, IMessage, IEquatable<AchievementRewardRequest>, IDeepCloneable<AchievementRewardRequest>, IBufferMessage
{
	[Token(Token = "0x4003007")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementRewardRequest> _parser;

	[Token(Token = "0x4003008")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003009")]
	public const int AchievementIdFieldNumber = 1;

	[Token(Token = "0x400300A")]
	[FieldOffset(Offset = "0x18")]
	private int achievementId_;

	[Token(Token = "0x17001E18")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementRewardRequest> Parser
	{
		[Token(Token = "0x60089D2")]
		[Address(RVA = "0xCA49A0", Offset = "0xCA3DA0", VA = "0x180CA49A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E19")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60089D3")]
		[Address(RVA = "0xCA48F0", Offset = "0xCA3CF0", VA = "0x180CA48F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E1A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60089D4")]
		[Address(RVA = "0xCA49F0", Offset = "0xCA3DF0", VA = "0x180CA49F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E1B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AchievementId
	{
		[Token(Token = "0x60089D8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60089D9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60089D5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementRewardRequest()
	{
	}

	[Token(Token = "0x60089D6")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementRewardRequest(AchievementRewardRequest other)
	{
	}

	[Token(Token = "0x60089D7")]
	[Address(RVA = "0xCA4680", Offset = "0xCA3A80", VA = "0x180CA4680", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementRewardRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60089DA")]
	[Address(RVA = "0xCA4700", Offset = "0xCA3B00", VA = "0x180CA4700", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60089DB")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementRewardRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60089DC")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60089DD")]
	[Address(RVA = "0xCA4790", Offset = "0xCA3B90", VA = "0x180CA4790", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60089DE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60089DF")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60089E0")]
	[Address(RVA = "0xCA45F0", Offset = "0xCA39F0", VA = "0x180CA45F0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60089E1")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AchievementRewardRequest other)
	{
	}

	[Token(Token = "0x60089E2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60089E3")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
