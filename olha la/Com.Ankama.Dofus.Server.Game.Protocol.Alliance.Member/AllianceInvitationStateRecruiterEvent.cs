using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C92")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceInvitationStateRecruiterEvent : IMessage<AllianceInvitationStateRecruiterEvent>, IMessage, IEquatable<AllianceInvitationStateRecruiterEvent>, IDeepCloneable<AllianceInvitationStateRecruiterEvent>, IBufferMessage
{
	[Token(Token = "0x4002E61")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceInvitationStateRecruiterEvent> _parser;

	[Token(Token = "0x4002E62")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E63")]
	public const int RecruitedNameFieldNumber = 1;

	[Token(Token = "0x4002E64")]
	[FieldOffset(Offset = "0x18")]
	private string recruitedName_;

	[Token(Token = "0x4002E65")]
	public const int InvitationStateFieldNumber = 2;

	[Token(Token = "0x4002E66")]
	[FieldOffset(Offset = "0x20")]
	private SocialGroupInvitationState invitationState_;

	[Token(Token = "0x17001CF9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceInvitationStateRecruiterEvent> Parser
	{
		[Token(Token = "0x6008459")]
		[Address(RVA = "0xC95130", Offset = "0xC94530", VA = "0x180C95130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CFA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600845A")]
		[Address(RVA = "0xC95080", Offset = "0xC94480", VA = "0x180C95080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CFB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600845B")]
		[Address(RVA = "0xC95250", Offset = "0xC94650", VA = "0x180C95250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CFC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RecruitedName
	{
		[Token(Token = "0x600845F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008460")]
		[Address(RVA = "0xC95330", Offset = "0xC94730", VA = "0x180C95330")]
		set
		{
		}
	}

	[Token(Token = "0x17001CFD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialGroupInvitationState InvitationState
	{
		[Token(Token = "0x6008461")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(SocialGroupInvitationState);
		}
		[Token(Token = "0x6008462")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600845C")]
	[Address(RVA = "0xC94F80", Offset = "0xC94380", VA = "0x180C94F80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInvitationStateRecruiterEvent()
	{
	}

	[Token(Token = "0x600845D")]
	[Address(RVA = "0xC94FD0", Offset = "0xC943D0", VA = "0x180C94FD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInvitationStateRecruiterEvent(AllianceInvitationStateRecruiterEvent other)
	{
	}

	[Token(Token = "0x600845E")]
	[Address(RVA = "0xC94C30", Offset = "0xC94030", VA = "0x180C94C30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInvitationStateRecruiterEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008463")]
	[Address(RVA = "0xC94D00", Offset = "0xC94100", VA = "0x180C94D00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008464")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceInvitationStateRecruiterEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008465")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008466")]
	[Address(RVA = "0xC94E20", Offset = "0xC94220", VA = "0x180C94E20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008467")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008468")]
	[Address(RVA = "0x958970", Offset = "0x957D70", VA = "0x180958970", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008469")]
	[Address(RVA = "0xC94B70", Offset = "0xC93F70", VA = "0x180C94B70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600846A")]
	[Address(RVA = "0xC94DB0", Offset = "0xC941B0", VA = "0x180C94DB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceInvitationStateRecruiterEvent other)
	{
	}

	[Token(Token = "0x600846B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600846C")]
	[Address(RVA = "0xC95180", Offset = "0xC94580", VA = "0x180C95180", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
