using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x20000FE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellVariantActivationRequest : IMessage<SpellVariantActivationRequest>, IMessage, IEquatable<SpellVariantActivationRequest>, IDeepCloneable<SpellVariantActivationRequest>, IBufferMessage
{
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellVariantActivationRequest> _parser;

	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400035B")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x17000213")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpellVariantActivationRequest> Parser
	{
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xB72400", Offset = "0xB71800", VA = "0x180B72400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000214")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xB72350", Offset = "0xB71750", VA = "0x180B72350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000215")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xB72450", Offset = "0xB71850", VA = "0x180B72450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000216")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellVariantActivationRequest()
	{
	}

	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellVariantActivationRequest(SpellVariantActivationRequest other)
	{
	}

	[Token(Token = "0x60009D4")]
	[Address(RVA = "0xB720E0", Offset = "0xB714E0", VA = "0x180B720E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellVariantActivationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60009D7")]
	[Address(RVA = "0xB72160", Offset = "0xB71560", VA = "0x180B72160", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SpellVariantActivationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60009DA")]
	[Address(RVA = "0xB721F0", Offset = "0xB715F0", VA = "0x180B721F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60009DD")]
	[Address(RVA = "0xB72050", Offset = "0xB71450", VA = "0x180B72050", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SpellVariantActivationRequest other)
	{
	}

	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
