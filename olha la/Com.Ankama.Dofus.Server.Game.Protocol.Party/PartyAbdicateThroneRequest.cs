using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000264")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyAbdicateThroneRequest : IMessage<PartyAbdicateThroneRequest>, IMessage, IEquatable<PartyAbdicateThroneRequest>, IDeepCloneable<PartyAbdicateThroneRequest>, IBufferMessage
{
	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyAbdicateThroneRequest> _parser;

	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000813")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x18")]
	private int partyId_;

	[Token(Token = "0x4000815")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x1700052C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyAbdicateThroneRequest> Parser
	{
		[Token(Token = "0x6001852")]
		[Address(RVA = "0xCF2600", Offset = "0xCF1A00", VA = "0x180CF2600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001853")]
		[Address(RVA = "0xCF2550", Offset = "0xCF1950", VA = "0x180CF2550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001854")]
		[Address(RVA = "0xCF2650", Offset = "0xCF1A50", VA = "0x180CF2650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001855")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyAbdicateThroneRequest()
	{
	}

	[Token(Token = "0x6001856")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyAbdicateThroneRequest(PartyAbdicateThroneRequest other)
	{
	}

	[Token(Token = "0x6001857")]
	[Address(RVA = "0xCF22C0", Offset = "0xCF16C0", VA = "0x180CF22C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyAbdicateThroneRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600185C")]
	[Address(RVA = "0xCF2350", Offset = "0xCF1750", VA = "0x180CF2350", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600185D")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyAbdicateThroneRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600185E")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600185F")]
	[Address(RVA = "0xCF23F0", Offset = "0xCF17F0", VA = "0x180CF23F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001860")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001861")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001862")]
	[Address(RVA = "0xCF2200", Offset = "0xCF1600", VA = "0x180CF2200", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001863")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyAbdicateThroneRequest other)
	{
	}

	[Token(Token = "0x6001864")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001865")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
