using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D11")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementDetailsRequest : IMessage<AchievementDetailsRequest>, IMessage, IEquatable<AchievementDetailsRequest>, IDeepCloneable<AchievementDetailsRequest>, IBufferMessage
{
	[Token(Token = "0x4002FFA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementDetailsRequest> _parser;

	[Token(Token = "0x4002FFB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FFC")]
	public const int AchievementIdFieldNumber = 1;

	[Token(Token = "0x4002FFD")]
	[FieldOffset(Offset = "0x18")]
	private int achievementId_;

	[Token(Token = "0x17001E0D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementDetailsRequest> Parser
	{
		[Token(Token = "0x6008992")]
		[Address(RVA = "0xCA1150", Offset = "0xCA0550", VA = "0x180CA1150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E0E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008993")]
		[Address(RVA = "0xCA10A0", Offset = "0xCA04A0", VA = "0x180CA10A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008994")]
		[Address(RVA = "0xCA11A0", Offset = "0xCA05A0", VA = "0x180CA11A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AchievementId
	{
		[Token(Token = "0x6008998")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008999")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6008995")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementDetailsRequest()
	{
	}

	[Token(Token = "0x6008996")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementDetailsRequest(AchievementDetailsRequest other)
	{
	}

	[Token(Token = "0x6008997")]
	[Address(RVA = "0xCA0E30", Offset = "0xCA0230", VA = "0x180CA0E30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementDetailsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600899A")]
	[Address(RVA = "0xCA0EB0", Offset = "0xCA02B0", VA = "0x180CA0EB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600899B")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AchievementDetailsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600899C")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600899D")]
	[Address(RVA = "0xCA0F40", Offset = "0xCA0340", VA = "0x180CA0F40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600899E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600899F")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60089A0")]
	[Address(RVA = "0xCA0DA0", Offset = "0xCA01A0", VA = "0x180CA0DA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60089A1")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementDetailsRequest other)
	{
	}

	[Token(Token = "0x60089A2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60089A3")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
