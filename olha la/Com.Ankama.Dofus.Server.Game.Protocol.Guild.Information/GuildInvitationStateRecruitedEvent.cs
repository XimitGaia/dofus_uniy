using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004B8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildInvitationStateRecruitedEvent : IMessage<GuildInvitationStateRecruitedEvent>, IMessage, IEquatable<GuildInvitationStateRecruitedEvent>, IDeepCloneable<GuildInvitationStateRecruitedEvent>, IBufferMessage
{
	[Token(Token = "0x400101F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildInvitationStateRecruitedEvent> _parser;

	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001021")]
	public const int InvitationStateFieldNumber = 1;

	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x18")]
	private SocialGroupInvitationState invitationState_;

	[Token(Token = "0x17000A92")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildInvitationStateRecruitedEvent> Parser
	{
		[Token(Token = "0x60031BF")]
		[Address(RVA = "0x9D0500", Offset = "0x9CF900", VA = "0x1809D0500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A93")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60031C0")]
		[Address(RVA = "0x9D0450", Offset = "0x9CF850", VA = "0x1809D0450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A94")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60031C1")]
		[Address(RVA = "0x9D0550", Offset = "0x9CF950", VA = "0x1809D0550", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A95")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialGroupInvitationState InvitationState
	{
		[Token(Token = "0x60031C5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialGroupInvitationState);
		}
		[Token(Token = "0x60031C6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60031C2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitationStateRecruitedEvent()
	{
	}

	[Token(Token = "0x60031C3")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitationStateRecruitedEvent(GuildInvitationStateRecruitedEvent other)
	{
	}

	[Token(Token = "0x60031C4")]
	[Address(RVA = "0x9D01E0", Offset = "0x9CF5E0", VA = "0x1809D01E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitationStateRecruitedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60031C7")]
	[Address(RVA = "0x9D0260", Offset = "0x9CF660", VA = "0x1809D0260", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60031C8")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildInvitationStateRecruitedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60031C9")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60031CA")]
	[Address(RVA = "0x9D02F0", Offset = "0x9CF6F0", VA = "0x1809D02F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60031CB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60031CC")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60031CD")]
	[Address(RVA = "0x9D0150", Offset = "0x9CF550", VA = "0x1809D0150", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60031CE")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildInvitationStateRecruitedEvent other)
	{
	}

	[Token(Token = "0x60031CF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
