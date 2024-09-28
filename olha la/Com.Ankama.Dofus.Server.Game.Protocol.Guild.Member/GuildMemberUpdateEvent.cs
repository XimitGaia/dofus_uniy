using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member;

[Token(Token = "0x2000479")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMemberUpdateEvent : IMessage<GuildMemberUpdateEvent>, IMessage, IEquatable<GuildMemberUpdateEvent>, IDeepCloneable<GuildMemberUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000F48")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMemberUpdateEvent> _parser;

	[Token(Token = "0x4000F49")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000F4A")]
	public const int MemberFieldNumber = 1;

	[Token(Token = "0x4000F4B")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character member_;

	[Token(Token = "0x17000A04")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildMemberUpdateEvent> Parser
	{
		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x9D6CE0", Offset = "0x9D60E0", VA = "0x1809D6CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A05")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002F12")]
		[Address(RVA = "0x9D6C30", Offset = "0x9D6030", VA = "0x1809D6C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A06")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002F13")]
		[Address(RVA = "0x9D6E30", Offset = "0x9D6230", VA = "0x1809D6E30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A07")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character Member
	{
		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002F18")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002F14")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberUpdateEvent()
	{
	}

	[Token(Token = "0x6002F15")]
	[Address(RVA = "0x9BD2D0", Offset = "0x9BC6D0", VA = "0x1809BD2D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMemberUpdateEvent(GuildMemberUpdateEvent other)
	{
	}

	[Token(Token = "0x6002F16")]
	[Address(RVA = "0x9D68B0", Offset = "0x9D5CB0", VA = "0x1809D68B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMemberUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002F19")]
	[Address(RVA = "0x9D6950", Offset = "0x9D5D50", VA = "0x1809D6950", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMemberUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0x9D6AD0", Offset = "0x9D5ED0", VA = "0x1809D6AD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002F1D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002F1E")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002F1F")]
	[Address(RVA = "0x9D6820", Offset = "0x9D5C20", VA = "0x1809D6820", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002F20")]
	[Address(RVA = "0x9D6A00", Offset = "0x9D5E00", VA = "0x1809D6A00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMemberUpdateEvent other)
	{
	}

	[Token(Token = "0x6002F21")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002F22")]
	[Address(RVA = "0x9D6D30", Offset = "0x9D6130", VA = "0x1809D6D30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
