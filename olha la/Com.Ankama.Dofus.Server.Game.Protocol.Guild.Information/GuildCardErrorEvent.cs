using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004CA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildCardErrorEvent : IMessage<GuildCardErrorEvent>, IMessage, IEquatable<GuildCardErrorEvent>, IDeepCloneable<GuildCardErrorEvent>, IBufferMessage
{
	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildCardErrorEvent> _parser;

	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400105F")]
	public const int GuildIdFieldNumber = 1;

	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0x18")]
	private int guildId_;

	[Token(Token = "0x17000ABE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildCardErrorEvent> Parser
	{
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x9EA670", Offset = "0x9E9A70", VA = "0x1809EA670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ABF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003295")]
		[Address(RVA = "0x9EA5C0", Offset = "0x9E99C0", VA = "0x1809EA5C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003296")]
		[Address(RVA = "0x9EA6C0", Offset = "0x9E9AC0", VA = "0x1809EA6C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AC1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildId
	{
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600329B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6003297")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCardErrorEvent()
	{
	}

	[Token(Token = "0x6003298")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCardErrorEvent(GuildCardErrorEvent other)
	{
	}

	[Token(Token = "0x6003299")]
	[Address(RVA = "0x9EA350", Offset = "0x9E9750", VA = "0x1809EA350", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCardErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600329C")]
	[Address(RVA = "0x9EA3D0", Offset = "0x9E97D0", VA = "0x1809EA3D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600329D")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildCardErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600329E")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600329F")]
	[Address(RVA = "0x9EA460", Offset = "0x9E9860", VA = "0x1809EA460", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60032A0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60032A1")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60032A2")]
	[Address(RVA = "0x9EA2C0", Offset = "0x9E96C0", VA = "0x1809EA2C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60032A3")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildCardErrorEvent other)
	{
	}

	[Token(Token = "0x60032A4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60032A5")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
