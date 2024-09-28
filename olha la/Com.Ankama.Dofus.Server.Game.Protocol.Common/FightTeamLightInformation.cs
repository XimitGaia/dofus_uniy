using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A28")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTeamLightInformation : IMessage<FightTeamLightInformation>, IMessage, IEquatable<FightTeamLightInformation>, IDeepCloneable<FightTeamLightInformation>, IBufferMessage
{
	[Token(Token = "0x4002480")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTeamLightInformation> _parser;

	[Token(Token = "0x4002481")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002482")]
	public const int TeamMembersCountFieldNumber = 1;

	[Token(Token = "0x4002483")]
	[FieldOffset(Offset = "0x18")]
	private int teamMembersCount_;

	[Token(Token = "0x4002484")]
	public const int AverageLevelFieldNumber = 2;

	[Token(Token = "0x4002485")]
	[FieldOffset(Offset = "0x1C")]
	private int averageLevel_;

	[Token(Token = "0x4002486")]
	public const int HasFriendFieldNumber = 3;

	[Token(Token = "0x4002487")]
	[FieldOffset(Offset = "0x20")]
	private bool hasFriend_;

	[Token(Token = "0x4002488")]
	public const int HasGuildMemberFieldNumber = 4;

	[Token(Token = "0x4002489")]
	[FieldOffset(Offset = "0x21")]
	private bool hasGuildMember_;

	[Token(Token = "0x400248A")]
	public const int HasAllianceMemberFieldNumber = 5;

	[Token(Token = "0x400248B")]
	[FieldOffset(Offset = "0x22")]
	private bool hasAllianceMember_;

	[Token(Token = "0x400248C")]
	public const int HasGroupMemberFieldNumber = 6;

	[Token(Token = "0x400248D")]
	[FieldOffset(Offset = "0x23")]
	private bool hasGroupMember_;

	[Token(Token = "0x400248E")]
	public const int HasMyTaxCollectorFieldNumber = 7;

	[Token(Token = "0x400248F")]
	[FieldOffset(Offset = "0x24")]
	private bool hasMyTaxCollector_;

	[Token(Token = "0x170016E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTeamLightInformation> Parser
	{
		[Token(Token = "0x6006A14")]
		[Address(RVA = "0xBBB990", Offset = "0xBBAD90", VA = "0x180BBB990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006A15")]
		[Address(RVA = "0xBBB8D0", Offset = "0xBBACD0", VA = "0x180BBB8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006A16")]
		[Address(RVA = "0xBBBC80", Offset = "0xBBB080", VA = "0x180BBBC80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016E6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TeamMembersCount
	{
		[Token(Token = "0x6006A1A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006A1B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170016E7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AverageLevel
	{
		[Token(Token = "0x6006A1C")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006A1D")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170016E8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFriend
	{
		[Token(Token = "0x6006A1E")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006A1F")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x170016E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGuildMember
	{
		[Token(Token = "0x6006A20")]
		[Address(RVA = "0x911F20", Offset = "0x911320", VA = "0x180911F20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006A21")]
		[Address(RVA = "0x99BC90", Offset = "0x99B090", VA = "0x18099BC90")]
		set
		{
		}
	}

	[Token(Token = "0x170016EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAllianceMember
	{
		[Token(Token = "0x6006A22")]
		[Address(RVA = "0x911F30", Offset = "0x911330", VA = "0x180911F30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006A23")]
		[Address(RVA = "0xBBBD60", Offset = "0xBBB160", VA = "0x180BBBD60")]
		set
		{
		}
	}

	[Token(Token = "0x170016EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGroupMember
	{
		[Token(Token = "0x6006A24")]
		[Address(RVA = "0xBBB980", Offset = "0xBBAD80", VA = "0x180BBB980")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006A25")]
		[Address(RVA = "0xBBBD70", Offset = "0xBBB170", VA = "0x180BBBD70")]
		set
		{
		}
	}

	[Token(Token = "0x170016EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMyTaxCollector
	{
		[Token(Token = "0x6006A26")]
		[Address(RVA = "0xA7E460", Offset = "0xA7D860", VA = "0x180A7E460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006A27")]
		[Address(RVA = "0xA7E710", Offset = "0xA7DB10", VA = "0x180A7E710")]
		set
		{
		}
	}

	[Token(Token = "0x6006A17")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTeamLightInformation()
	{
	}

	[Token(Token = "0x6006A18")]
	[Address(RVA = "0xBBB850", Offset = "0xBBAC50", VA = "0x180BBB850")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamLightInformation(FightTeamLightInformation other)
	{
	}

	[Token(Token = "0x6006A19")]
	[Address(RVA = "0xBBB2E0", Offset = "0xBBA6E0", VA = "0x180BBB2E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTeamLightInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6006A28")]
	[Address(RVA = "0xBBB3F0", Offset = "0xBBA7F0", VA = "0x180BBB3F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A29")]
	[Address(RVA = "0xBBB390", Offset = "0xBBA790", VA = "0x180BBB390", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTeamLightInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A2A")]
	[Address(RVA = "0xBBB4B0", Offset = "0xBBA8B0", VA = "0x180BBB4B0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006A2B")]
	[Address(RVA = "0xBBB6F0", Offset = "0xBBAAF0", VA = "0x180BBB6F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006A2C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006A2D")]
	[Address(RVA = "0xBBBB60", Offset = "0xBBAF60", VA = "0x180BBBB60", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006A2E")]
	[Address(RVA = "0xBBB1F0", Offset = "0xBBA5F0", VA = "0x180BBB1F0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006A2F")]
	[Address(RVA = "0xBBB650", Offset = "0xBBAA50", VA = "0x180BBB650", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightTeamLightInformation other)
	{
	}

	[Token(Token = "0x6006A30")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006A31")]
	[Address(RVA = "0xBBB9E0", Offset = "0xBBADE0", VA = "0x180BBB9E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
