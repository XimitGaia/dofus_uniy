using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200028E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyLeaderUpdateEvent : IMessage<PartyLeaderUpdateEvent>, IMessage, IEquatable<PartyLeaderUpdateEvent>, IDeepCloneable<PartyLeaderUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyLeaderUpdateEvent> _parser;

	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40008DF")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x40008E1")]
	public const int PartyLeaderIdFieldNumber = 2;

	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x20")]
	private long partyLeaderId_;

	[Token(Token = "0x170005A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyLeaderUpdateEvent> Parser
	{
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0xD11550", Offset = "0xD10950", VA = "0x180D11550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0xD114A0", Offset = "0xD108A0", VA = "0x180D114A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0xD115A0", Offset = "0xD109A0", VA = "0x180D115A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170005AB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PartyLeaderId
	{
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyLeaderUpdateEvent()
	{
	}

	[Token(Token = "0x6001A60")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyLeaderUpdateEvent(PartyLeaderUpdateEvent other)
	{
	}

	[Token(Token = "0x6001A61")]
	[Address(RVA = "0xD11210", Offset = "0xD10610", VA = "0x180D11210", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyLeaderUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001A66")]
	[Address(RVA = "0xD112A0", Offset = "0xD106A0", VA = "0x180D112A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A67")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyLeaderUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A68")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001A69")]
	[Address(RVA = "0xD11340", Offset = "0xD10740", VA = "0x180D11340", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0xD11150", Offset = "0xD10550", VA = "0x180D11150", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyLeaderUpdateEvent other)
	{
	}

	[Token(Token = "0x6001A6E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
