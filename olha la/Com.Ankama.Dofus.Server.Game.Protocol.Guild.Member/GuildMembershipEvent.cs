using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x200047F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMembershipEvent : IMessage<GuildMembershipEvent>, IMessage, IEquatable<GuildMembershipEvent>, IDeepCloneable<GuildMembershipEvent>, IBufferMessage
{
	[Token(Token = "0x4000F57")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMembershipEvent> _parser;

	[Token(Token = "0x4000F58")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F59")]
	public const int GuildInformationFieldNumber = 1;

	[Token(Token = "0x4000F5A")]
	[FieldOffset(Offset = "0x18")]
	private GuildInformation guildInformation_;

	[Token(Token = "0x4000F5B")]
	public const int RankIdFieldNumber = 2;

	[Token(Token = "0x4000F5C")]
	[FieldOffset(Offset = "0x20")]
	private int rankId_;

	[Token(Token = "0x17000A10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildMembershipEvent> Parser
	{
		[Token(Token = "0x6002F53")]
		[Address(RVA = "0x9D8690", Offset = "0x9D7A90", VA = "0x1809D8690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002F54")]
		[Address(RVA = "0x9D85E0", Offset = "0x9D79E0", VA = "0x1809D85E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x9D8800", Offset = "0x9D7C00", VA = "0x1809D8800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A13")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformation GuildInformation
	{
		[Token(Token = "0x6002F59")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A14")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankId
	{
		[Token(Token = "0x6002F5B")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002F5C")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6002F56")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMembershipEvent()
	{
	}

	[Token(Token = "0x6002F57")]
	[Address(RVA = "0x9D20F0", Offset = "0x9D14F0", VA = "0x1809D20F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMembershipEvent(GuildMembershipEvent other)
	{
	}

	[Token(Token = "0x6002F58")]
	[Address(RVA = "0x9D8250", Offset = "0x9D7650", VA = "0x1809D8250", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMembershipEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x9D8300", Offset = "0x9D7700", VA = "0x1809D8300", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildMembershipEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x9D8480", Offset = "0x9D7880", VA = "0x1809D8480", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002F61")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002F62")]
	[Address(RVA = "0x9D2390", Offset = "0x9D1790", VA = "0x1809D2390", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002F63")]
	[Address(RVA = "0x9D8190", Offset = "0x9D7590", VA = "0x1809D8190", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002F64")]
	[Address(RVA = "0x9D83B0", Offset = "0x9D77B0", VA = "0x1809D83B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMembershipEvent other)
	{
	}

	[Token(Token = "0x6002F65")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002F66")]
	[Address(RVA = "0x9D86E0", Offset = "0x9D7AE0", VA = "0x1809D86E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
