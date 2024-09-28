using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004B6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildInvitationStateRecruiterEvent : IMessage<GuildInvitationStateRecruiterEvent>, IMessage, IEquatable<GuildInvitationStateRecruiterEvent>, IDeepCloneable<GuildInvitationStateRecruiterEvent>, IBufferMessage
{
	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildInvitationStateRecruiterEvent> _parser;

	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400101A")]
	public const int RecruitedNameFieldNumber = 1;

	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0x18")]
	private string recruitedName_;

	[Token(Token = "0x400101C")]
	public const int InvitationStateFieldNumber = 2;

	[Token(Token = "0x400101D")]
	[FieldOffset(Offset = "0x20")]
	private SocialGroupInvitationState invitationState_;

	[Token(Token = "0x17000A8D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildInvitationStateRecruiterEvent> Parser
	{
		[Token(Token = "0x60031A7")]
		[Address(RVA = "0x9D0BF0", Offset = "0x9CFFF0", VA = "0x1809D0BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A8E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60031A8")]
		[Address(RVA = "0x9D0B40", Offset = "0x9CFF40", VA = "0x1809D0B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A8F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60031A9")]
		[Address(RVA = "0x9D0D10", Offset = "0x9D0110", VA = "0x1809D0D10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RecruitedName
	{
		[Token(Token = "0x60031AD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031AE")]
		[Address(RVA = "0x9D0DF0", Offset = "0x9D01F0", VA = "0x1809D0DF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A91")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialGroupInvitationState InvitationState
	{
		[Token(Token = "0x60031AF")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(SocialGroupInvitationState);
		}
		[Token(Token = "0x60031B0")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60031AA")]
	[Address(RVA = "0x9D0A40", Offset = "0x9CFE40", VA = "0x1809D0A40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitationStateRecruiterEvent()
	{
	}

	[Token(Token = "0x60031AB")]
	[Address(RVA = "0x9D0A90", Offset = "0x9CFE90", VA = "0x1809D0A90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInvitationStateRecruiterEvent(GuildInvitationStateRecruiterEvent other)
	{
	}

	[Token(Token = "0x60031AC")]
	[Address(RVA = "0x9D06F0", Offset = "0x9CFAF0", VA = "0x1809D06F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInvitationStateRecruiterEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60031B1")]
	[Address(RVA = "0x9D07C0", Offset = "0x9CFBC0", VA = "0x1809D07C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60031B2")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildInvitationStateRecruiterEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60031B3")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60031B4")]
	[Address(RVA = "0x9D08E0", Offset = "0x9CFCE0", VA = "0x1809D08E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60031B5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60031B6")]
	[Address(RVA = "0x958970", Offset = "0x957D70", VA = "0x180958970", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60031B7")]
	[Address(RVA = "0x9D0630", Offset = "0x9CFA30", VA = "0x1809D0630", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60031B8")]
	[Address(RVA = "0x9D0870", Offset = "0x9CFC70", VA = "0x1809D0870", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildInvitationStateRecruiterEvent other)
	{
	}

	[Token(Token = "0x60031B9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60031BA")]
	[Address(RVA = "0x9D0C40", Offset = "0x9D0040", VA = "0x1809D0C40", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
