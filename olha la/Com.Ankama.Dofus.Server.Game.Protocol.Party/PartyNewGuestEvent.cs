using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000284")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyNewGuestEvent : IMessage<PartyNewGuestEvent>, IMessage, IEquatable<PartyNewGuestEvent>, IDeepCloneable<PartyNewGuestEvent>, IBufferMessage
{
	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyNewGuestEvent> _parser;

	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008B2")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x40008B4")]
	public const int GuestFieldNumber = 2;

	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x20")]
	private PartyGuest guest_;

	[Token(Token = "0x17000589")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyNewGuestEvent> Parser
	{
		[Token(Token = "0x60019DA")]
		[Address(RVA = "0xD17000", Offset = "0xD16400", VA = "0x180D17000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0xD16F50", Offset = "0xD16350", VA = "0x180D16F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0xD17170", Offset = "0xD16570", VA = "0x180D17170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x60019E0")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700058D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyGuest Guest
	{
		[Token(Token = "0x60019E2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyNewGuestEvent()
	{
	}

	[Token(Token = "0x60019DE")]
	[Address(RVA = "0xD16DB0", Offset = "0xD161B0", VA = "0x180D16DB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyNewGuestEvent(PartyNewGuestEvent other)
	{
	}

	[Token(Token = "0x60019DF")]
	[Address(RVA = "0xD16A70", Offset = "0xD15E70", VA = "0x180D16A70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyNewGuestEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60019E4")]
	[Address(RVA = "0xD16AD0", Offset = "0xD15ED0", VA = "0x180D16AD0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyNewGuestEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60019E7")]
	[Address(RVA = "0xD16C50", Offset = "0xD16050", VA = "0x180D16C50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60019EA")]
	[Address(RVA = "0xD169B0", Offset = "0xD15DB0", VA = "0x180D169B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60019EB")]
	[Address(RVA = "0xD16B80", Offset = "0xD15F80", VA = "0x180D16B80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyNewGuestEvent other)
	{
	}

	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60019ED")]
	[Address(RVA = "0xD17050", Offset = "0xD16450", VA = "0x180D17050", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
