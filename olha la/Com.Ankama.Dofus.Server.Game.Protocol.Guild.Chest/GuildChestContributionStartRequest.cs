using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004DC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestContributionStartRequest : IMessage<GuildChestContributionStartRequest>, IMessage, IEquatable<GuildChestContributionStartRequest>, IDeepCloneable<GuildChestContributionStartRequest>, IBufferMessage
{
	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestContributionStartRequest> _parser;

	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000AE6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildChestContributionStartRequest> Parser
	{
		[Token(Token = "0x6003351")]
		[Address(RVA = "0x9EB700", Offset = "0x9EAB00", VA = "0x1809EB700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AE7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003352")]
		[Address(RVA = "0x9EB650", Offset = "0x9EAA50", VA = "0x1809EB650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AE8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003353")]
		[Address(RVA = "0x9EB750", Offset = "0x9EAB50", VA = "0x1809EB750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003354")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestContributionStartRequest()
	{
	}

	[Token(Token = "0x6003355")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestContributionStartRequest(GuildChestContributionStartRequest other)
	{
	}

	[Token(Token = "0x6003356")]
	[Address(RVA = "0x9EB3F0", Offset = "0x9EA7F0", VA = "0x1809EB3F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestContributionStartRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003357")]
	[Address(RVA = "0x9EB470", Offset = "0x9EA870", VA = "0x1809EB470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003358")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestContributionStartRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003359")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600335A")]
	[Address(RVA = "0x9EB4F0", Offset = "0x9EA8F0", VA = "0x1809EB4F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600335B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600335C")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600335D")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600335E")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestContributionStartRequest other)
	{
	}

	[Token(Token = "0x600335F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003360")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
