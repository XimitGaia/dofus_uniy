using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D13")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementsDetailedRequest : IMessage<AchievementsDetailedRequest>, IMessage, IEquatable<AchievementsDetailedRequest>, IDeepCloneable<AchievementsDetailedRequest>, IBufferMessage
{
	[Token(Token = "0x4002FFF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementsDetailedRequest> _parser;

	[Token(Token = "0x4003000")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003001")]
	public const int CategoryIdFieldNumber = 1;

	[Token(Token = "0x4003002")]
	[FieldOffset(Offset = "0x18")]
	private int categoryId_;

	[Token(Token = "0x17001E11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AchievementsDetailedRequest> Parser
	{
		[Token(Token = "0x60089A8")]
		[Address(RVA = "0xCA7710", Offset = "0xCA6B10", VA = "0x180CA7710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60089A9")]
		[Address(RVA = "0xCA7660", Offset = "0xCA6A60", VA = "0x180CA7660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E13")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60089AA")]
		[Address(RVA = "0xCA7760", Offset = "0xCA6B60", VA = "0x180CA7760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E14")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CategoryId
	{
		[Token(Token = "0x60089AE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60089AF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60089AB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsDetailedRequest()
	{
	}

	[Token(Token = "0x60089AC")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsDetailedRequest(AchievementsDetailedRequest other)
	{
	}

	[Token(Token = "0x60089AD")]
	[Address(RVA = "0xCA73F0", Offset = "0xCA67F0", VA = "0x180CA73F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsDetailedRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60089B0")]
	[Address(RVA = "0xCA7470", Offset = "0xCA6870", VA = "0x180CA7470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60089B1")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AchievementsDetailedRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60089B2")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60089B3")]
	[Address(RVA = "0xCA7500", Offset = "0xCA6900", VA = "0x180CA7500", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60089B4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60089B5")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60089B6")]
	[Address(RVA = "0xCA7360", Offset = "0xCA6760", VA = "0x180CA7360", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60089B7")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementsDetailedRequest other)
	{
	}

	[Token(Token = "0x60089B8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60089B9")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
