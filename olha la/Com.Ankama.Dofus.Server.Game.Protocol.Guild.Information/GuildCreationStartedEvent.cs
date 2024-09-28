using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004AC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildCreationStartedEvent : IMessage<GuildCreationStartedEvent>, IMessage, IEquatable<GuildCreationStartedEvent>, IDeepCloneable<GuildCreationStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4000FFD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildCreationStartedEvent> _parser;

	[Token(Token = "0x4000FFE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000A78")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildCreationStartedEvent> Parser
	{
		[Token(Token = "0x6003137")]
		[Address(RVA = "0x9CA8D0", Offset = "0x9C9CD0", VA = "0x1809CA8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A79")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003138")]
		[Address(RVA = "0x9CA820", Offset = "0x9C9C20", VA = "0x1809CA820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A7A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003139")]
		[Address(RVA = "0x9CA920", Offset = "0x9C9D20", VA = "0x1809CA920", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600313A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildCreationStartedEvent()
	{
	}

	[Token(Token = "0x600313B")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreationStartedEvent(GuildCreationStartedEvent other)
	{
	}

	[Token(Token = "0x600313C")]
	[Address(RVA = "0x9CA5C0", Offset = "0x9C99C0", VA = "0x1809CA5C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildCreationStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600313D")]
	[Address(RVA = "0x9CA640", Offset = "0x9C9A40", VA = "0x1809CA640", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600313E")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildCreationStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600313F")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003140")]
	[Address(RVA = "0x9CA6C0", Offset = "0x9C9AC0", VA = "0x1809CA6C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003141")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003142")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003143")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003144")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildCreationStartedEvent other)
	{
	}

	[Token(Token = "0x6003145")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003146")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
