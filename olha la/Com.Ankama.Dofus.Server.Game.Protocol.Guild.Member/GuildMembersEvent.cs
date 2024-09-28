using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x2000477")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMembersEvent : IMessage<GuildMembersEvent>, IMessage, IEquatable<GuildMembersEvent>, IDeepCloneable<GuildMembersEvent>, IBufferMessage
{
	[Token(Token = "0x4000F42")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMembersEvent> _parser;

	[Token(Token = "0x4000F43")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F44")]
	public const int MembersFieldNumber = 1;

	[Token(Token = "0x4000F45")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> _repeated_members_codec;

	[Token(Token = "0x4000F46")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> members_;

	[Token(Token = "0x17000A00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildMembersEvent> Parser
	{
		[Token(Token = "0x6002EFC")]
		[Address(RVA = "0x9D7EA0", Offset = "0x9D72A0", VA = "0x1809D7EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A01")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002EFD")]
		[Address(RVA = "0x9D7DF0", Offset = "0x9D71F0", VA = "0x1809D7DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A02")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002EFE")]
		[Address(RVA = "0x9D80B0", Offset = "0x9D74B0", VA = "0x1809D80B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A03")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> Members
	{
		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002EFF")]
	[Address(RVA = "0x9D7D70", Offset = "0x9D7170", VA = "0x1809D7D70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMembersEvent()
	{
	}

	[Token(Token = "0x6002F00")]
	[Address(RVA = "0x9D7CE0", Offset = "0x9D70E0", VA = "0x1809D7CE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMembersEvent(GuildMembersEvent other)
	{
	}

	[Token(Token = "0x6002F01")]
	[Address(RVA = "0x9D7830", Offset = "0x9D6C30", VA = "0x1809D7830", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMembersEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002F03")]
	[Address(RVA = "0x9D7980", Offset = "0x9D6D80", VA = "0x1809D7980", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F04")]
	[Address(RVA = "0x9D78F0", Offset = "0x9D6CF0", VA = "0x1809D78F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMembersEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F05")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002F06")]
	[Address(RVA = "0x9D7AE0", Offset = "0x9D6EE0", VA = "0x1809D7AE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002F07")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002F08")]
	[Address(RVA = "0x9D8000", Offset = "0x9D7400", VA = "0x1809D8000", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002F09")]
	[Address(RVA = "0x9D7790", Offset = "0x9D6B90", VA = "0x1809D7790", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002F0A")]
	[Address(RVA = "0x9D7A60", Offset = "0x9D6E60", VA = "0x1809D7A60", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildMembersEvent other)
	{
	}

	[Token(Token = "0x6002F0B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002F0C")]
	[Address(RVA = "0x9D7EF0", Offset = "0x9D72F0", VA = "0x1809D7EF0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
