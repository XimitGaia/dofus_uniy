using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200029C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyMemberInFightEvent : IMessage<PartyMemberInFightEvent>, IMessage, IEquatable<PartyMemberInFightEvent>, IDeepCloneable<PartyMemberInFightEvent>, IBufferMessage
{
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyMemberInFightEvent> _parser;

	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000910")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000912")]
	public const int ReasonFieldNumber = 2;

	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x1C")]
	private PartyMemberInFightCause reason_;

	[Token(Token = "0x4000914")]
	public const int MemberIdFieldNumber = 3;

	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x20")]
	private long memberId_;

	[Token(Token = "0x4000916")]
	public const int MemberAccountIdFieldNumber = 4;

	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x28")]
	private long memberAccountId_;

	[Token(Token = "0x4000918")]
	public const int MemberNameFieldNumber = 5;

	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x30")]
	private string memberName_;

	[Token(Token = "0x400091A")]
	public const int FightIdFieldNumber = 6;

	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x38")]
	private int fightId_;

	[Token(Token = "0x400091C")]
	public const int TimeBeforeFightStartFieldNumber = 7;

	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x3C")]
	private int timeBeforeFightStart_;

	[Token(Token = "0x400091E")]
	public const int StandardFightMapFieldNumber = 8;

	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x40")]
	private MapExtendedCoordinates standardFightMap_;

	[Token(Token = "0x170005CA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyMemberInFightEvent> Parser
	{
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0xD13A00", Offset = "0xD12E00", VA = "0x180D13A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0xD13950", Offset = "0xD12D50", VA = "0x180D13950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0xD13DA0", Offset = "0xD131A0", VA = "0x180D13DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005CE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyMemberInFightCause Reason
	{
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(PartyMemberInFightCause);
		}
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170005CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MemberId
	{
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170005D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MemberAccountId
	{
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x170005D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MemberName
	{
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0xD13E80", Offset = "0xD13280", VA = "0x180D13E80")]
		set
		{
		}
	}

	[Token(Token = "0x170005D2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x170005D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TimeBeforeFightStart
	{
		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x946B90", Offset = "0x945F90", VA = "0x180946B90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x9470F0", Offset = "0x9464F0", VA = "0x1809470F0")]
		set
		{
		}
	}

	[Token(Token = "0x170005D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapExtendedCoordinates StandardFightMap
	{
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D6110", VA = "0x1807D6D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x7D6D20", Offset = "0x7D6120", VA = "0x1807D6D20")]
		set
		{
		}
	}

	[Token(Token = "0x6001B07")]
	[Address(RVA = "0xD13810", Offset = "0xD12C10", VA = "0x180D13810")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyMemberInFightEvent()
	{
	}

	[Token(Token = "0x6001B08")]
	[Address(RVA = "0xD13860", Offset = "0xD12C60", VA = "0x180D13860")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyMemberInFightEvent(PartyMemberInFightEvent other)
	{
	}

	[Token(Token = "0x6001B09")]
	[Address(RVA = "0xD13170", Offset = "0xD12570", VA = "0x180D13170", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberInFightEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0xD13290", Offset = "0xD12690", VA = "0x180D13290", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0xD13390", Offset = "0xD12790", VA = "0x180D13390", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyMemberInFightEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0xD13440", Offset = "0xD12840", VA = "0x180D13440", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0xD136B0", Offset = "0xD12AB0", VA = "0x180D136B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0xD13C40", Offset = "0xD13040", VA = "0x180D13C40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001B20")]
	[Address(RVA = "0xD12FB0", Offset = "0xD123B0", VA = "0x180D12FB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001B21")]
	[Address(RVA = "0xD13580", Offset = "0xD12980", VA = "0x180D13580", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyMemberInFightEvent other)
	{
	}

	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001B23")]
	[Address(RVA = "0xD13A50", Offset = "0xD12E50", VA = "0x180D13A50", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
