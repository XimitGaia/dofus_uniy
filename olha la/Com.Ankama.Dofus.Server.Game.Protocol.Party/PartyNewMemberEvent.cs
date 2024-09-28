using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000288")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyNewMemberEvent : IMessage<PartyNewMemberEvent>, IMessage, IEquatable<PartyNewMemberEvent>, IDeepCloneable<PartyNewMemberEvent>, IBufferMessage
{
	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyNewMemberEvent> _parser;

	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008C0")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x40008C2")]
	public const int MemberFieldNumber = 2;

	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0x20")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character member_;

	[Token(Token = "0x17000593")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyNewMemberEvent> Parser
	{
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0xD17740", Offset = "0xD16B40", VA = "0x180D17740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000594")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0xD17690", Offset = "0xD16A90", VA = "0x180D17690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000595")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0xD178B0", Offset = "0xD16CB0", VA = "0x180D178B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000596")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000597")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character Member
	{
		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyNewMemberEvent()
	{
	}

	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0xD14C90", Offset = "0xD14090", VA = "0x180D14C90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyNewMemberEvent(PartyNewMemberEvent other)
	{
	}

	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0xD17310", Offset = "0xD16710", VA = "0x180D17310", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyNewMemberEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001A14")]
	[Address(RVA = "0xD173B0", Offset = "0xD167B0", VA = "0x180D173B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyNewMemberEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A16")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001A17")]
	[Address(RVA = "0xD17530", Offset = "0xD16930", VA = "0x180D17530", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0xD17250", Offset = "0xD16650", VA = "0x180D17250", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0xD17460", Offset = "0xD16860", VA = "0x180D17460", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyNewMemberEvent other)
	{
	}

	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0xD17790", Offset = "0xD16B90", VA = "0x180D17790", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
