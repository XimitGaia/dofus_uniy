using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x2000110")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellsEvent : IMessage<ForgettableSpellsEvent>, IMessage, IEquatable<ForgettableSpellsEvent>, IDeepCloneable<ForgettableSpellsEvent>, IBufferMessage
{
	[Token(Token = "0x2000111")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000112")]
		public enum Action
		{
			[Token(Token = "0x400039D")]
			[OriginalName("DISPATCH")]
			Dispatch,
			[Token(Token = "0x400039E")]
			[OriginalName("UPDATE")]
			Update
		}
	}

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellsEvent> _parser;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000397")]
	public const int ActionFieldNumber = 1;

	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x18")]
	private Types.Action action_;

	[Token(Token = "0x4000399")]
	public const int SpellsFieldNumber = 2;

	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<SpellItem> _repeated_spells_codec;

	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<SpellItem> spells_;

	[Token(Token = "0x17000236")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ForgettableSpellsEvent> Parser
	{
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xB67310", Offset = "0xB66710", VA = "0x180B67310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000237")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xB67260", Offset = "0xB66660", VA = "0x180B67260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000238")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xB67560", Offset = "0xB66960", VA = "0x180B67560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000239")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Action Action
	{
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Action);
		}
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700023A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SpellItem> Spells
	{
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A79")]
	[Address(RVA = "0xB67150", Offset = "0xB66550", VA = "0x180B67150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellsEvent()
	{
	}

	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0xB671D0", Offset = "0xB665D0", VA = "0x180B671D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellsEvent(ForgettableSpellsEvent other)
	{
	}

	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0xB66C80", Offset = "0xB66080", VA = "0x180B66C80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0xB66D40", Offset = "0xB66140", VA = "0x180B66D40", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A80")]
	[Address(RVA = "0xB66E20", Offset = "0xB66220", VA = "0x180B66E20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000A82")]
	[Address(RVA = "0xB66F50", Offset = "0xB66350", VA = "0x180B66F50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000A84")]
	[Address(RVA = "0xB67490", Offset = "0xB66890", VA = "0x180B67490", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000A85")]
	[Address(RVA = "0xB66BA0", Offset = "0xB65FA0", VA = "0x180B66BA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000A86")]
	[Address(RVA = "0xB66EC0", Offset = "0xB662C0", VA = "0x180B66EC0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ForgettableSpellsEvent other)
	{
	}

	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000A88")]
	[Address(RVA = "0xB67360", Offset = "0xB66760", VA = "0x180B67360", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
