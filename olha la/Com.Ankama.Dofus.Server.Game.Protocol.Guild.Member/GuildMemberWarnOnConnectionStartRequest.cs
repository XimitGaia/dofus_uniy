using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x2000471")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMemberWarnOnConnectionStartRequest : IMessage<GuildMemberWarnOnConnectionStartRequest>, IMessage, IEquatable<GuildMemberWarnOnConnectionStartRequest>, IDeepCloneable<GuildMemberWarnOnConnectionStartRequest>, IBufferMessage
{
	[Token(Token = "0x4000F35")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMemberWarnOnConnectionStartRequest> _parser;

	[Token(Token = "0x4000F36")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170009F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildMemberWarnOnConnectionStartRequest> Parser
	{
		[Token(Token = "0x6002EBC")]
		[Address(RVA = "0x9D7220", Offset = "0x9D6620", VA = "0x1809D7220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0x9D7170", Offset = "0x9D6570", VA = "0x1809D7170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002EBE")]
		[Address(RVA = "0x9D7270", Offset = "0x9D6670", VA = "0x1809D7270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002EBF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberWarnOnConnectionStartRequest()
	{
	}

	[Token(Token = "0x6002EC0")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberWarnOnConnectionStartRequest(GuildMemberWarnOnConnectionStartRequest other)
	{
	}

	[Token(Token = "0x6002EC1")]
	[Address(RVA = "0x9D6F10", Offset = "0x9D6310", VA = "0x1809D6F10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberWarnOnConnectionStartRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002EC2")]
	[Address(RVA = "0x9D6F90", Offset = "0x9D6390", VA = "0x1809D6F90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EC3")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildMemberWarnOnConnectionStartRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EC4")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002EC5")]
	[Address(RVA = "0x9D7010", Offset = "0x9D6410", VA = "0x1809D7010", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002EC6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002EC7")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002EC8")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002EC9")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildMemberWarnOnConnectionStartRequest other)
	{
	}

	[Token(Token = "0x6002ECA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002ECB")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
