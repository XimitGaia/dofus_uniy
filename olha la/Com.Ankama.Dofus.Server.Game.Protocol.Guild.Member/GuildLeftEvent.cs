using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x200047D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildLeftEvent : IMessage<GuildLeftEvent>, IMessage, IEquatable<GuildLeftEvent>, IDeepCloneable<GuildLeftEvent>, IBufferMessage
{
	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildLeftEvent> _parser;

	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000A0D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildLeftEvent> Parser
	{
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x9D2CE0", Offset = "0x9D20E0", VA = "0x1809D2CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x9D2C30", Offset = "0x9D2030", VA = "0x1809D2C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x9D2D30", Offset = "0x9D2130", VA = "0x1809D2D30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002F42")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLeftEvent()
	{
	}

	[Token(Token = "0x6002F43")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLeftEvent(GuildLeftEvent other)
	{
	}

	[Token(Token = "0x6002F44")]
	[Address(RVA = "0x9D29D0", Offset = "0x9D1DD0", VA = "0x1809D29D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLeftEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x9D2A50", Offset = "0x9D1E50", VA = "0x1809D2A50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildLeftEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F47")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002F48")]
	[Address(RVA = "0x9D2AD0", Offset = "0x9D1ED0", VA = "0x1809D2AD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002F49")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildLeftEvent other)
	{
	}

	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002F4E")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
