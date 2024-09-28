using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party;

[Token(Token = "0x2000266")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyFollowMemberRequest : IMessage<PartyFollowMemberRequest>, IMessage, IEquatable<PartyFollowMemberRequest>, IDeepCloneable<PartyFollowMemberRequest>, IBufferMessage
{
	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyFollowMemberRequest> _parser;

	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x400081B")]
	public const int PartyIdFieldNumber = 1;

	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x1C")]
	private int partyId_;

	[Token(Token = "0x400081D")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x400081F")]
	public const int EnabledFieldNumber = 3;

	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x8")]
	private static readonly bool EnabledDefaultValue;

	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x28")]
	private bool enabled_;

	[Token(Token = "0x17000531")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PartyFollowMemberRequest> Parser
	{
		[Token(Token = "0x600186A")]
		[Address(RVA = "0xCF2E80", Offset = "0xCF2280", VA = "0x180CF2E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000532")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600186B")]
		[Address(RVA = "0xCF2D60", Offset = "0xCF2160", VA = "0x180CF2D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000533")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600186C")]
		[Address(RVA = "0xCF30A0", Offset = "0xCF24A0", VA = "0x180CF30A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000534")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PartyId
	{
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000535")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001873")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000536")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Enabled
	{
		[Token(Token = "0x6001874")]
		[Address(RVA = "0xCF2E10", Offset = "0xCF2210", VA = "0x180CF2E10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001875")]
		[Address(RVA = "0xCF3180", Offset = "0xCF2580", VA = "0x180CF3180")]
		set
		{
		}
	}

	[Token(Token = "0x17000537")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasEnabled
	{
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600186D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyFollowMemberRequest()
	{
	}

	[Token(Token = "0x600186E")]
	[Address(RVA = "0xCF2CF0", Offset = "0xCF20F0", VA = "0x180CF2CF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyFollowMemberRequest(PartyFollowMemberRequest other)
	{
	}

	[Token(Token = "0x600186F")]
	[Address(RVA = "0xCF2800", Offset = "0xCF1C00", VA = "0x180CF2800", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyFollowMemberRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001877")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEnabled()
	{
	}

	[Token(Token = "0x6001878")]
	[Address(RVA = "0xCF2920", Offset = "0xCF1D20", VA = "0x180CF2920", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001879")]
	[Address(RVA = "0xCF2890", Offset = "0xCF1C90", VA = "0x180CF2890", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PartyFollowMemberRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600187A")]
	[Address(RVA = "0xCF29E0", Offset = "0xCF1DE0", VA = "0x180CF29E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600187B")]
	[Address(RVA = "0xCF2B80", Offset = "0xCF1F80", VA = "0x180CF2B80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600187C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600187D")]
	[Address(RVA = "0xCF2FB0", Offset = "0xCF23B0", VA = "0x180CF2FB0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600187E")]
	[Address(RVA = "0xCF2730", Offset = "0xCF1B30", VA = "0x180CF2730", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600187F")]
	[Address(RVA = "0xCF2B10", Offset = "0xCF1F10", VA = "0x180CF2B10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyFollowMemberRequest other)
	{
	}

	[Token(Token = "0x6001880")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001881")]
	[Address(RVA = "0xCF2ED0", Offset = "0xCF22D0", VA = "0x180CF2ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
