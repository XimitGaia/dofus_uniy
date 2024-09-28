using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x2000104")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ApplySpellModifierEvent : IMessage<ApplySpellModifierEvent>, IMessage, IEquatable<ApplySpellModifierEvent>, IDeepCloneable<ApplySpellModifierEvent>, IBufferMessage
{
	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ApplySpellModifierEvent> _parser;

	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400036B")]
	public const int ActorIdFieldNumber = 1;

	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x18")]
	private long actorId_;

	[Token(Token = "0x400036D")]
	public const int ModifierFieldNumber = 2;

	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x20")]
	private SpellModifier modifier_;

	[Token(Token = "0x1700021C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ApplySpellModifierEvent> Parser
	{
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xB646A0", Offset = "0xB63AA0", VA = "0x180B646A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xB645F0", Offset = "0xB639F0", VA = "0x180B645F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xB64810", Offset = "0xB63C10", VA = "0x180B64810", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ActorId
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellModifier Modifier
	{
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ApplySpellModifierEvent()
	{
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0xB64570", Offset = "0xB63970", VA = "0x180B64570")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ApplySpellModifierEvent(ApplySpellModifierEvent other)
	{
	}

	[Token(Token = "0x6000A02")]
	[Address(RVA = "0xB641D0", Offset = "0xB635D0", VA = "0x180B641D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ApplySpellModifierEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0xB64270", Offset = "0xB63670", VA = "0x180B64270", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x953270", Offset = "0x952670", VA = "0x180953270", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ApplySpellModifierEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x9533A0", Offset = "0x9527A0", VA = "0x1809533A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0xB64410", Offset = "0xB63810", VA = "0x180B64410", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x953910", Offset = "0x952D10", VA = "0x180953910", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0xB64110", Offset = "0xB63510", VA = "0x180B64110", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0xB64330", Offset = "0xB63730", VA = "0x180B64330", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ApplySpellModifierEvent other)
	{
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000A10")]
	[Address(RVA = "0xB646F0", Offset = "0xB63AF0", VA = "0x180B646F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
