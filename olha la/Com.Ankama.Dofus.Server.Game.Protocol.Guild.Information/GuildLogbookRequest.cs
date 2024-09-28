using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x2000484")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildLogbookRequest : IMessage<GuildLogbookRequest>, IMessage, IEquatable<GuildLogbookRequest>, IDeepCloneable<GuildLogbookRequest>, IBufferMessage
{
	[Token(Token = "0x4000F66")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildLogbookRequest> _parser;

	[Token(Token = "0x4000F67")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000A1B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildLogbookRequest> Parser
	{
		[Token(Token = "0x6002F85")]
		[Address(RVA = "0x9D3D20", Offset = "0x9D3120", VA = "0x1809D3D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002F86")]
		[Address(RVA = "0x9D3C70", Offset = "0x9D3070", VA = "0x1809D3C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x9D3D70", Offset = "0x9D3170", VA = "0x1809D3D70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002F88")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLogbookRequest()
	{
	}

	[Token(Token = "0x6002F89")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLogbookRequest(GuildLogbookRequest other)
	{
	}

	[Token(Token = "0x6002F8A")]
	[Address(RVA = "0x9D3A10", Offset = "0x9D2E10", VA = "0x1809D3A10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLogbookRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x9D3A90", Offset = "0x9D2E90", VA = "0x1809D3A90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildLogbookRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F8D")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002F8E")]
	[Address(RVA = "0x9D3B10", Offset = "0x9D2F10", VA = "0x1809D3B10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002F8F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002F90")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002F91")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002F92")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildLogbookRequest other)
	{
	}

	[Token(Token = "0x6002F93")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002F94")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
