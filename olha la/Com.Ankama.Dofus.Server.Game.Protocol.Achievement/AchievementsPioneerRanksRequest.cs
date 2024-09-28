using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement;

[Token(Token = "0x2000D27")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AchievementsPioneerRanksRequest : IMessage<AchievementsPioneerRanksRequest>, IMessage, IEquatable<AchievementsPioneerRanksRequest>, IDeepCloneable<AchievementsPioneerRanksRequest>, IBufferMessage
{
	[Token(Token = "0x4003038")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AchievementsPioneerRanksRequest> _parser;

	[Token(Token = "0x4003039")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001E3B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AchievementsPioneerRanksRequest> Parser
	{
		[Token(Token = "0x6008A85")]
		[Address(RVA = "0xCA8550", Offset = "0xCA7950", VA = "0x180CA8550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E3C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008A86")]
		[Address(RVA = "0xCA84A0", Offset = "0xCA78A0", VA = "0x180CA84A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E3D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008A87")]
		[Address(RVA = "0xCA85A0", Offset = "0xCA79A0", VA = "0x180CA85A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008A88")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsPioneerRanksRequest()
	{
	}

	[Token(Token = "0x6008A89")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementsPioneerRanksRequest(AchievementsPioneerRanksRequest other)
	{
	}

	[Token(Token = "0x6008A8A")]
	[Address(RVA = "0xCA8240", Offset = "0xCA7640", VA = "0x180CA8240", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementsPioneerRanksRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008A8B")]
	[Address(RVA = "0xCA82C0", Offset = "0xCA76C0", VA = "0x180CA82C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A8C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementsPioneerRanksRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A8D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008A8E")]
	[Address(RVA = "0xCA8340", Offset = "0xCA7740", VA = "0x180CA8340", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008A8F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008A90")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008A91")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008A92")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AchievementsPioneerRanksRequest other)
	{
	}

	[Token(Token = "0x6008A93")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008A94")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
