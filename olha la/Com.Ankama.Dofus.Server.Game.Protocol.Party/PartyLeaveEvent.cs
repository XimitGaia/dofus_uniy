using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000292")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyLeaveEvent : IMessage<PartyLeaveEvent>, IMessage, IEquatable<PartyLeaveEvent>, IDeepCloneable<PartyLeaveEvent>, IBufferMessage
{
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyLeaveEvent> _parser;

	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008F1")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x170005B3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyLeaveEvent> Parser
	{
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0xD11A30", Offset = "0xD10E30", VA = "0x180D11A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0xD11980", Offset = "0xD10D80", VA = "0x180D11980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0xD11A80", Offset = "0xD10E80", VA = "0x180D11A80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyLeaveEvent()
	{
	}

	[Token(Token = "0x6001A94")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyLeaveEvent(PartyLeaveEvent other)
	{
	}

	[Token(Token = "0x6001A95")]
	[Address(RVA = "0xD11710", Offset = "0xD10B10", VA = "0x180D11710", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyLeaveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001A98")]
	[Address(RVA = "0xD11790", Offset = "0xD10B90", VA = "0x180D11790", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A99")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyLeaveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001A9B")]
	[Address(RVA = "0xD11820", Offset = "0xD10C20", VA = "0x180D11820", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0xD11680", Offset = "0xD10A80", VA = "0x180D11680", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyLeaveEvent other)
	{
	}

	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
