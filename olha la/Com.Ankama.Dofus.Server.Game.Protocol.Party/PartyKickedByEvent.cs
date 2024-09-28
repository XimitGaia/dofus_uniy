using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000294")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyKickedByEvent : IMessage<PartyKickedByEvent>, IMessage, IEquatable<PartyKickedByEvent>, IDeepCloneable<PartyKickedByEvent>, IBufferMessage
{
	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyKickedByEvent> _parser;

	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008F6")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x40008F8")]
	public const int KickerIdFieldNumber = 2;

	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x20")]
	private long kickerId_;

	[Token(Token = "0x170005B7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyKickedByEvent> Parser
	{
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0xD11020", Offset = "0xD10420", VA = "0x180D11020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0xD10F70", Offset = "0xD10370", VA = "0x180D10F70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0xD11070", Offset = "0xD10470", VA = "0x180D11070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005BB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long KickerId
	{
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyKickedByEvent()
	{
	}

	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyKickedByEvent(PartyKickedByEvent other)
	{
	}

	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0xD10CE0", Offset = "0xD100E0", VA = "0x180D10CE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyKickedByEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001AB0")]
	[Address(RVA = "0xD10D70", Offset = "0xD10170", VA = "0x180D10D70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AB1")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyKickedByEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0xD10E10", Offset = "0xD10210", VA = "0x180D10E10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001AB4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001AB5")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001AB6")]
	[Address(RVA = "0xD10C20", Offset = "0xD10020", VA = "0x180D10C20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001AB7")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyKickedByEvent other)
	{
	}

	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
