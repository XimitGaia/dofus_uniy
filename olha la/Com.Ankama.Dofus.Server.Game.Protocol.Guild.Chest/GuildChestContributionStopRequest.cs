using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004DE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestContributionStopRequest : IMessage<GuildChestContributionStopRequest>, IMessage, IEquatable<GuildChestContributionStopRequest>, IDeepCloneable<GuildChestContributionStopRequest>, IBufferMessage
{
	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestContributionStopRequest> _parser;

	[Token(Token = "0x400109A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000AE9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildChestContributionStopRequest> Parser
	{
		[Token(Token = "0x6003365")]
		[Address(RVA = "0x9EBB40", Offset = "0x9EAF40", VA = "0x1809EBB40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AEA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003366")]
		[Address(RVA = "0x9EBA90", Offset = "0x9EAE90", VA = "0x1809EBA90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AEB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003367")]
		[Address(RVA = "0x9EBB90", Offset = "0x9EAF90", VA = "0x1809EBB90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003368")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestContributionStopRequest()
	{
	}

	[Token(Token = "0x6003369")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestContributionStopRequest(GuildChestContributionStopRequest other)
	{
	}

	[Token(Token = "0x600336A")]
	[Address(RVA = "0x9EB830", Offset = "0x9EAC30", VA = "0x1809EB830", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestContributionStopRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600336B")]
	[Address(RVA = "0x9EB8B0", Offset = "0x9EACB0", VA = "0x1809EB8B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600336C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestContributionStopRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600336D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600336E")]
	[Address(RVA = "0x9EB930", Offset = "0x9EAD30", VA = "0x1809EB930", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600336F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003370")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003371")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003372")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestContributionStopRequest other)
	{
	}

	[Token(Token = "0x6003373")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003374")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
