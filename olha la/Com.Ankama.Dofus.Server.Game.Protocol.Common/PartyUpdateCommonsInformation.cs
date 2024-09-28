using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009D2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PartyUpdateCommonsInformation : IMessage<PartyUpdateCommonsInformation>, IMessage, IEquatable<PartyUpdateCommonsInformation>, IDeepCloneable<PartyUpdateCommonsInformation>, IBufferMessage
{
	[Token(Token = "0x40022C5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PartyUpdateCommonsInformation> _parser;

	[Token(Token = "0x40022C6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40022C7")]
	public const int LifePointFieldNumber = 1;

	[Token(Token = "0x40022C8")]
	[FieldOffset(Offset = "0x18")]
	private int lifePoint_;

	[Token(Token = "0x40022C9")]
	public const int MaxLifePointsFieldNumber = 2;

	[Token(Token = "0x40022CA")]
	[FieldOffset(Offset = "0x1C")]
	private int maxLifePoints_;

	[Token(Token = "0x40022CB")]
	public const int ProspectingFieldNumber = 3;

	[Token(Token = "0x40022CC")]
	[FieldOffset(Offset = "0x20")]
	private int prospecting_;

	[Token(Token = "0x40022CD")]
	public const int RegenRateFieldNumber = 4;

	[Token(Token = "0x40022CE")]
	[FieldOffset(Offset = "0x24")]
	private int regenRate_;

	[Token(Token = "0x170015E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PartyUpdateCommonsInformation> Parser
	{
		[Token(Token = "0x600663E")]
		[Address(RVA = "0xBADCF0", Offset = "0xBAD0F0", VA = "0x180BADCF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600663F")]
		[Address(RVA = "0xBADC40", Offset = "0xBAD040", VA = "0x180BADC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006640")]
		[Address(RVA = "0xBADE00", Offset = "0xBAD200", VA = "0x180BADE00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LifePoint
	{
		[Token(Token = "0x6006644")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006645")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170015EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxLifePoints
	{
		[Token(Token = "0x6006646")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006647")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170015EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Prospecting
	{
		[Token(Token = "0x6006648")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006649")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170015EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RegenRate
	{
		[Token(Token = "0x600664A")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600664B")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6006641")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PartyUpdateCommonsInformation()
	{
	}

	[Token(Token = "0x6006642")]
	[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyUpdateCommonsInformation(PartyUpdateCommonsInformation other)
	{
	}

	[Token(Token = "0x6006643")]
	[Address(RVA = "0xBAD8F0", Offset = "0xBACCF0", VA = "0x180BAD8F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PartyUpdateCommonsInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600664C")]
	[Address(RVA = "0xBAD980", Offset = "0xBACD80", VA = "0x180BAD980", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600664D")]
	[Address(RVA = "0xBA0E80", Offset = "0xBA0280", VA = "0x180BA0E80", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PartyUpdateCommonsInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600664E")]
	[Address(RVA = "0xBADA20", Offset = "0xBACE20", VA = "0x180BADA20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600664F")]
	[Address(RVA = "0xBADAE0", Offset = "0xBACEE0", VA = "0x180BADAE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006650")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006651")]
	[Address(RVA = "0xBADD40", Offset = "0xBAD140", VA = "0x180BADD40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006652")]
	[Address(RVA = "0xBAD7E0", Offset = "0xBACBE0", VA = "0x180BAD7E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006653")]
	[Address(RVA = "0xBA0F80", Offset = "0xBA0380", VA = "0x180BA0F80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PartyUpdateCommonsInformation other)
	{
	}

	[Token(Token = "0x6006654")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006655")]
	[Address(RVA = "0xBA1220", Offset = "0xBA0620", VA = "0x180BA1220", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
