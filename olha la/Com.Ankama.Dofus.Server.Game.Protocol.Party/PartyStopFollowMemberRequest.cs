using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000268")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyStopFollowMemberRequest : IMessage<PartyStopFollowMemberRequest>, IMessage, IEquatable<PartyStopFollowMemberRequest>, IDeepCloneable<PartyStopFollowMemberRequest>, IBufferMessage
{
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyStopFollowMemberRequest> _parser;

	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000825")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000827")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17000538")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyStopFollowMemberRequest> Parser
	{
		[Token(Token = "0x6001886")]
		[Address(RVA = "0xD004E0", Offset = "0xCFF8E0", VA = "0x180D004E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000539")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001887")]
		[Address(RVA = "0xD00430", Offset = "0xCFF830", VA = "0x180D00430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001888")]
		[Address(RVA = "0xD00530", Offset = "0xCFF930", VA = "0x180D00530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700053C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001889")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyStopFollowMemberRequest()
	{
	}

	[Token(Token = "0x600188A")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyStopFollowMemberRequest(PartyStopFollowMemberRequest other)
	{
	}

	[Token(Token = "0x600188B")]
	[Address(RVA = "0xD001A0", Offset = "0xCFF5A0", VA = "0x180D001A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyStopFollowMemberRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001890")]
	[Address(RVA = "0xD00230", Offset = "0xCFF630", VA = "0x180D00230", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001891")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyStopFollowMemberRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001892")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001893")]
	[Address(RVA = "0xD002D0", Offset = "0xCFF6D0", VA = "0x180D002D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001894")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001895")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001896")]
	[Address(RVA = "0xD000E0", Offset = "0xCFF4E0", VA = "0x180D000E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001897")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyStopFollowMemberRequest other)
	{
	}

	[Token(Token = "0x6001898")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001899")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
