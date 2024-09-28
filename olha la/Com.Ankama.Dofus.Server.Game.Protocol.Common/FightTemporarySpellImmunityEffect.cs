using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A49")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTemporarySpellImmunityEffect : IMessage<FightTemporarySpellImmunityEffect>, IMessage, IEquatable<FightTemporarySpellImmunityEffect>, IDeepCloneable<FightTemporarySpellImmunityEffect>, IBufferMessage
{
	[Token(Token = "0x4002523")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTemporarySpellImmunityEffect> _parser;

	[Token(Token = "0x4002524")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002525")]
	public const int ImmuneSpellIdFieldNumber = 1;

	[Token(Token = "0x4002526")]
	[FieldOffset(Offset = "0x18")]
	private int immuneSpellId_;

	[Token(Token = "0x17001744")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTemporarySpellImmunityEffect> Parser
	{
		[Token(Token = "0x6006B89")]
		[Address(RVA = "0xBCE950", Offset = "0xBCDD50", VA = "0x180BCE950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001745")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006B8A")]
		[Address(RVA = "0xBCE8A0", Offset = "0xBCDCA0", VA = "0x180BCE8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001746")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006B8B")]
		[Address(RVA = "0xBCE9A0", Offset = "0xBCDDA0", VA = "0x180BCE9A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001747")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ImmuneSpellId
	{
		[Token(Token = "0x6006B8F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006B90")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6006B8C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTemporarySpellImmunityEffect()
	{
	}

	[Token(Token = "0x6006B8D")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTemporarySpellImmunityEffect(FightTemporarySpellImmunityEffect other)
	{
	}

	[Token(Token = "0x6006B8E")]
	[Address(RVA = "0xBCE630", Offset = "0xBCDA30", VA = "0x180BCE630", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTemporarySpellImmunityEffect Clone()
	{
		return null;
	}

	[Token(Token = "0x6006B91")]
	[Address(RVA = "0xBCE6B0", Offset = "0xBCDAB0", VA = "0x180BCE6B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B92")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTemporarySpellImmunityEffect other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006B93")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006B94")]
	[Address(RVA = "0xBCE740", Offset = "0xBCDB40", VA = "0x180BCE740", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006B95")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006B96")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006B97")]
	[Address(RVA = "0xBCE5A0", Offset = "0xBCD9A0", VA = "0x180BCE5A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006B98")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTemporarySpellImmunityEffect other)
	{
	}

	[Token(Token = "0x6006B99")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006B9A")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
