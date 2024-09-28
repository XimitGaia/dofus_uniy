using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000270")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyPledgeLoyaltyRequest : IMessage<PartyPledgeLoyaltyRequest>, IMessage, IEquatable<PartyPledgeLoyaltyRequest>, IDeepCloneable<PartyPledgeLoyaltyRequest>, IBufferMessage
{
	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyPledgeLoyaltyRequest> _parser;

	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400083D")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x400083F")]
	public const int LoyalFieldNumber = 2;

	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x1C")]
	private bool loyal_;

	[Token(Token = "0x1700054A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyPledgeLoyaltyRequest> Parser
	{
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0xCFB540", Offset = "0xCFA940", VA = "0x180CFB540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0xCFB490", Offset = "0xCFA890", VA = "0x180CFB490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0xCFB590", Offset = "0xCFA990", VA = "0x180CFB590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700054E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Loyal
	{
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyPledgeLoyaltyRequest()
	{
	}

	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyPledgeLoyaltyRequest(PartyPledgeLoyaltyRequest other)
	{
	}

	[Token(Token = "0x60018E7")]
	[Address(RVA = "0xCFB150", Offset = "0xCFA550", VA = "0x180CFB150", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyPledgeLoyaltyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60018EC")]
	[Address(RVA = "0xCFB1E0", Offset = "0xCFA5E0", VA = "0x180CFB1E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyPledgeLoyaltyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60018EE")]
	[Address(RVA = "0xCFB270", Offset = "0xCFA670", VA = "0x180CFB270", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60018EF")]
	[Address(RVA = "0xCFB330", Offset = "0xCFA730", VA = "0x180CFB330", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60018F0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60018F1")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60018F2")]
	[Address(RVA = "0xCFB0C0", Offset = "0xCFA4C0", VA = "0x180CFB0C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60018F3")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyPledgeLoyaltyRequest other)
	{
	}

	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
