using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x200049C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildJoinAutomaticallyRequest : IMessage<GuildJoinAutomaticallyRequest>, IMessage, IEquatable<GuildJoinAutomaticallyRequest>, IDeepCloneable<GuildJoinAutomaticallyRequest>, IBufferMessage
{
	[Token(Token = "0x4000FC8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildJoinAutomaticallyRequest> _parser;

	[Token(Token = "0x4000FC9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FCA")]
	public const int GuildIdFieldNumber = 1;

	[Token(Token = "0x4000FCB")]
	[FieldOffset(Offset = "0x18")]
	private int guildId_;

	[Token(Token = "0x17000A53")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildJoinAutomaticallyRequest> Parser
	{
		[Token(Token = "0x6003080")]
		[Address(RVA = "0x9D1B70", Offset = "0x9D0F70", VA = "0x1809D1B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A54")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003081")]
		[Address(RVA = "0x9D1AC0", Offset = "0x9D0EC0", VA = "0x1809D1AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A55")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003082")]
		[Address(RVA = "0x9D1BC0", Offset = "0x9D0FC0", VA = "0x1809D1BC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A56")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildId
	{
		[Token(Token = "0x6003086")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003087")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003083")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildJoinAutomaticallyRequest()
	{
	}

	[Token(Token = "0x6003084")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildJoinAutomaticallyRequest(GuildJoinAutomaticallyRequest other)
	{
	}

	[Token(Token = "0x6003085")]
	[Address(RVA = "0x9D1850", Offset = "0x9D0C50", VA = "0x1809D1850", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildJoinAutomaticallyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003088")]
	[Address(RVA = "0x9D18D0", Offset = "0x9D0CD0", VA = "0x1809D18D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003089")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildJoinAutomaticallyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600308A")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600308B")]
	[Address(RVA = "0x9D1960", Offset = "0x9D0D60", VA = "0x1809D1960", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600308C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600308D")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600308E")]
	[Address(RVA = "0x9D17C0", Offset = "0x9D0BC0", VA = "0x1809D17C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600308F")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildJoinAutomaticallyRequest other)
	{
	}

	[Token(Token = "0x6003090")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003091")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
