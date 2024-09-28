using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004E9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestTabLastContributionDateEvent : IMessage<GuildChestTabLastContributionDateEvent>, IMessage, IEquatable<GuildChestTabLastContributionDateEvent>, IDeepCloneable<GuildChestTabLastContributionDateEvent>, IBufferMessage
{
	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestTabLastContributionDateEvent> _parser;

	[Token(Token = "0x40010B2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010B3")]
	public const int LastContributionDateFieldNumber = 1;

	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0x18")]
	private long lastContributionDate_;

	[Token(Token = "0x17000AFC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildChestTabLastContributionDateEvent> Parser
	{
		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x9F0F60", Offset = "0x9F0360", VA = "0x1809F0F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AFD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x9F0EB0", Offset = "0x9F02B0", VA = "0x1809F0EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AFE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x9F0FB0", Offset = "0x9F03B0", VA = "0x1809F0FB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AFF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LastContributionDate
	{
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60033D7")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x60033D3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabLastContributionDateEvent()
	{
	}

	[Token(Token = "0x60033D4")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestTabLastContributionDateEvent(GuildChestTabLastContributionDateEvent other)
	{
	}

	[Token(Token = "0x60033D5")]
	[Address(RVA = "0x9F0C40", Offset = "0x9F0040", VA = "0x1809F0C40", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestTabLastContributionDateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60033D8")]
	[Address(RVA = "0x9F0CC0", Offset = "0x9F00C0", VA = "0x1809F0CC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60033D9")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestTabLastContributionDateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60033DA")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60033DB")]
	[Address(RVA = "0x9F0D50", Offset = "0x9F0150", VA = "0x1809F0D50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60033DC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60033DD")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60033DE")]
	[Address(RVA = "0x9F0BB0", Offset = "0x9EFFB0", VA = "0x1809F0BB0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60033DF")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestTabLastContributionDateEvent other)
	{
	}

	[Token(Token = "0x60033E0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60033E1")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
