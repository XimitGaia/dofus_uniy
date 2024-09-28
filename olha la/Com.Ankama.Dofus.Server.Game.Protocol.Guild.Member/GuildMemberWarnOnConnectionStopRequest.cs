using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x2000473")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMemberWarnOnConnectionStopRequest : IMessage<GuildMemberWarnOnConnectionStopRequest>, IMessage, IEquatable<GuildMemberWarnOnConnectionStopRequest>, IDeepCloneable<GuildMemberWarnOnConnectionStopRequest>, IBufferMessage
{
	[Token(Token = "0x4000F38")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMemberWarnOnConnectionStopRequest> _parser;

	[Token(Token = "0x4000F39")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170009F8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildMemberWarnOnConnectionStopRequest> Parser
	{
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x9D7660", Offset = "0x9D6A60", VA = "0x1809D7660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x9D75B0", Offset = "0x9D69B0", VA = "0x1809D75B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009FA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x9D76B0", Offset = "0x9D6AB0", VA = "0x1809D76B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberWarnOnConnectionStopRequest()
	{
	}

	[Token(Token = "0x6002ED4")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberWarnOnConnectionStopRequest(GuildMemberWarnOnConnectionStopRequest other)
	{
	}

	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x9D7350", Offset = "0x9D6750", VA = "0x1809D7350", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberWarnOnConnectionStopRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x9D73D0", Offset = "0x9D67D0", VA = "0x1809D73D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMemberWarnOnConnectionStopRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x9D7450", Offset = "0x9D6850", VA = "0x1809D7450", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002EDA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002EDB")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002EDC")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002EDD")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMemberWarnOnConnectionStopRequest other)
	{
	}

	[Token(Token = "0x6002EDE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002EDF")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
