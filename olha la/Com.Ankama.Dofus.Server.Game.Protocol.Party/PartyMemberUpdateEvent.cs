using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000286")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyMemberUpdateEvent : IMessage<PartyMemberUpdateEvent>, IMessage, IEquatable<PartyMemberUpdateEvent>, IDeepCloneable<PartyMemberUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyMemberUpdateEvent> _parser;

	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008B9")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x40008BB")]
	public const int MemberFieldNumber = 2;

	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0x20")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character member_;

	[Token(Token = "0x1700058E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyMemberUpdateEvent> Parser
	{
		[Token(Token = "0x60019F2")]
		[Address(RVA = "0xD14DB0", Offset = "0xD141B0", VA = "0x180D14DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0xD14D00", Offset = "0xD14100", VA = "0x180D14D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000590")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0xD14F20", Offset = "0xD14320", VA = "0x180D14F20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000591")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000592")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character Member
	{
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyMemberUpdateEvent()
	{
	}

	[Token(Token = "0x60019F6")]
	[Address(RVA = "0xD14C90", Offset = "0xD14090", VA = "0x180D14C90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyMemberUpdateEvent(PartyMemberUpdateEvent other)
	{
	}

	[Token(Token = "0x60019F7")]
	[Address(RVA = "0xD14910", Offset = "0xD13D10", VA = "0x180D14910", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyMemberUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60019FC")]
	[Address(RVA = "0xD149B0", Offset = "0xD13DB0", VA = "0x180D149B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyMemberUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60019FF")]
	[Address(RVA = "0xD14B30", Offset = "0xD13F30", VA = "0x180D14B30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001A02")]
	[Address(RVA = "0xD14850", Offset = "0xD13C50", VA = "0x180D14850", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001A03")]
	[Address(RVA = "0xD14A60", Offset = "0xD13E60", VA = "0x180D14A60", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyMemberUpdateEvent other)
	{
	}

	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001A05")]
	[Address(RVA = "0xD14E00", Offset = "0xD14200", VA = "0x180D14E00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
