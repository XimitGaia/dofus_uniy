using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x200026E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyKickRequest : IMessage<PartyKickRequest>, IMessage, IEquatable<PartyKickRequest>, IDeepCloneable<PartyKickRequest>, IBufferMessage
{
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyKickRequest> _parser;

	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000836")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000838")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17000545")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyKickRequest> Parser
	{
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0xCF9DA0", Offset = "0xCF91A0", VA = "0x180CF9DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000546")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60018CB")]
		[Address(RVA = "0xCF9CF0", Offset = "0xCF90F0", VA = "0x180CF9CF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000547")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0xCF9DF0", Offset = "0xCF91F0", VA = "0x180CF9DF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000548")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartyId
	{
		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000549")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyKickRequest()
	{
	}

	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyKickRequest(PartyKickRequest other)
	{
	}

	[Token(Token = "0x60018CF")]
	[Address(RVA = "0xCF9A60", Offset = "0xCF8E60", VA = "0x180CF9A60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyKickRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60018D4")]
	[Address(RVA = "0xCF9AF0", Offset = "0xCF8EF0", VA = "0x180CF9AF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyKickRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60018D6")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60018D7")]
	[Address(RVA = "0xCF9B90", Offset = "0xCF8F90", VA = "0x180CF9B90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60018D9")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60018DA")]
	[Address(RVA = "0xCF99A0", Offset = "0xCF8DA0", VA = "0x180CF99A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PartyKickRequest other)
	{
	}

	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
