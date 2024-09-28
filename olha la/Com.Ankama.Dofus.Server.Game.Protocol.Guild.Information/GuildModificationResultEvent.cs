using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004B2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildModificationResultEvent : IMessage<GuildModificationResultEvent>, IMessage, IEquatable<GuildModificationResultEvent>, IDeepCloneable<GuildModificationResultEvent>, IBufferMessage
{
	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildModificationResultEvent> _parser;

	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400100E")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x400100F")]
	[FieldOffset(Offset = "0x18")]
	private SocialGroupOperationResult result_;

	[Token(Token = "0x17000A84")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildModificationResultEvent> Parser
	{
		[Token(Token = "0x6003179")]
		[Address(RVA = "0x9D9BC0", Offset = "0x9D8FC0", VA = "0x1809D9BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A85")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600317A")]
		[Address(RVA = "0x9D9B10", Offset = "0x9D8F10", VA = "0x1809D9B10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A86")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600317B")]
		[Address(RVA = "0x9D9C10", Offset = "0x9D9010", VA = "0x1809D9C10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A87")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialGroupOperationResult Result
	{
		[Token(Token = "0x600317F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialGroupOperationResult);
		}
		[Token(Token = "0x6003180")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600317C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationResultEvent()
	{
	}

	[Token(Token = "0x600317D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildModificationResultEvent(GuildModificationResultEvent other)
	{
	}

	[Token(Token = "0x600317E")]
	[Address(RVA = "0x9D98A0", Offset = "0x9D8CA0", VA = "0x1809D98A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildModificationResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003181")]
	[Address(RVA = "0x9D9920", Offset = "0x9D8D20", VA = "0x1809D9920", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003182")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildModificationResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003183")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003184")]
	[Address(RVA = "0x9D99B0", Offset = "0x9D8DB0", VA = "0x1809D99B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003185")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003186")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003187")]
	[Address(RVA = "0x9D9810", Offset = "0x9D8C10", VA = "0x1809D9810", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003188")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildModificationResultEvent other)
	{
	}

	[Token(Token = "0x6003189")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600318A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
