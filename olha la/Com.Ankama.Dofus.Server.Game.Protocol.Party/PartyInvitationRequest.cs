using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200025A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyInvitationRequest : IMessage<PartyInvitationRequest>, IMessage, IEquatable<PartyInvitationRequest>, IDeepCloneable<PartyInvitationRequest>, IBufferMessage
{
	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyInvitationRequest> _parser;

	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007F6")]
	public const int TargetFieldNumber = 1;

	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x18")]
	private PlayerSearch target_;

	[Token(Token = "0x40007F8")]
	public const int PartyTypeFieldNumber = 2;

	[Token(Token = "0x40007F9")]
	[FieldOffset(Offset = "0x20")]
	private PartyType partyType_;

	[Token(Token = "0x17000516")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyInvitationRequest> Parser
	{
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0xCF7D50", Offset = "0xCF7150", VA = "0x180CF7D50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000517")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0xCF7CA0", Offset = "0xCF70A0", VA = "0x180CF7CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000518")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0xCF7EC0", Offset = "0xCF72C0", VA = "0x180CF7EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000519")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerSearch Target
	{
		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700051A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyType PartyType
	{
		[Token(Token = "0x60017E8")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(PartyType);
		}
		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60017E3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationRequest()
	{
	}

	[Token(Token = "0x60017E4")]
	[Address(RVA = "0xCF7C20", Offset = "0xCF7020", VA = "0x180CF7C20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationRequest(PartyInvitationRequest other)
	{
	}

	[Token(Token = "0x60017E5")]
	[Address(RVA = "0xCF7890", Offset = "0xCF6C90", VA = "0x180CF7890", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyInvitationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60017EA")]
	[Address(RVA = "0xCF7940", Offset = "0xCF6D40", VA = "0x180CF7940", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyInvitationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60017ED")]
	[Address(RVA = "0xCF7AC0", Offset = "0xCF6EC0", VA = "0x180CF7AC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60017EF")]
	[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60017F0")]
	[Address(RVA = "0xCF77D0", Offset = "0xCF6BD0", VA = "0x180CF77D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60017F1")]
	[Address(RVA = "0xCF79F0", Offset = "0xCF6DF0", VA = "0x180CF79F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyInvitationRequest other)
	{
	}

	[Token(Token = "0x60017F2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60017F3")]
	[Address(RVA = "0xCF7DA0", Offset = "0xCF71A0", VA = "0x180CF7DA0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
