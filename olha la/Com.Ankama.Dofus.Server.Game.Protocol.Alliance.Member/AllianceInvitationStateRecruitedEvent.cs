using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C94")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceInvitationStateRecruitedEvent : IMessage<AllianceInvitationStateRecruitedEvent>, IMessage, IEquatable<AllianceInvitationStateRecruitedEvent>, IDeepCloneable<AllianceInvitationStateRecruitedEvent>, IBufferMessage
{
	[Token(Token = "0x4002E68")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceInvitationStateRecruitedEvent> _parser;

	[Token(Token = "0x4002E69")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E6A")]
	public const int InvitationStateFieldNumber = 1;

	[Token(Token = "0x4002E6B")]
	[FieldOffset(Offset = "0x18")]
	private SocialGroupInvitationState invitationState_;

	[Token(Token = "0x17001CFE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceInvitationStateRecruitedEvent> Parser
	{
		[Token(Token = "0x6008471")]
		[Address(RVA = "0xC94A40", Offset = "0xC93E40", VA = "0x180C94A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CFF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008472")]
		[Address(RVA = "0xC94990", Offset = "0xC93D90", VA = "0x180C94990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008473")]
		[Address(RVA = "0xC94A90", Offset = "0xC93E90", VA = "0x180C94A90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D01")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialGroupInvitationState InvitationState
	{
		[Token(Token = "0x6008477")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialGroupInvitationState);
		}
		[Token(Token = "0x6008478")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6008474")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitationStateRecruitedEvent()
	{
	}

	[Token(Token = "0x6008475")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitationStateRecruitedEvent(AllianceInvitationStateRecruitedEvent other)
	{
	}

	[Token(Token = "0x6008476")]
	[Address(RVA = "0xC94720", Offset = "0xC93B20", VA = "0x180C94720", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitationStateRecruitedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008479")]
	[Address(RVA = "0xC947A0", Offset = "0xC93BA0", VA = "0x180C947A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600847A")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceInvitationStateRecruitedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600847B")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600847C")]
	[Address(RVA = "0xC94830", Offset = "0xC93C30", VA = "0x180C94830", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600847D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600847E")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600847F")]
	[Address(RVA = "0xC94690", Offset = "0xC93A90", VA = "0x180C94690", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008480")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceInvitationStateRecruitedEvent other)
	{
	}

	[Token(Token = "0x6008481")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008482")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
