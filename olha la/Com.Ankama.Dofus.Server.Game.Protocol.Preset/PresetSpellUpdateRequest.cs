using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200021A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetSpellUpdateRequest : IMessage<PresetSpellUpdateRequest>, IMessage, IEquatable<PresetSpellUpdateRequest>, IDeepCloneable<PresetSpellUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x200021B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200021C")]
		public enum Target
		{
			[Token(Token = "0x400072E")]
			[OriginalName("CHARACTER")]
			Character,
			[Token(Token = "0x400072F")]
			[OriginalName("FORGETTABLE_BASE")]
			ForgettableBase,
			[Token(Token = "0x4000730")]
			[OriginalName("FORGETTABLE_SPELL")]
			ForgettableSpell
		}
	}

	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetSpellUpdateRequest> _parser;

	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000727")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x4000729")]
	public const int TargetFieldNumber = 2;

	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x20")]
	private Types.Target target_;

	[Token(Token = "0x400072B")]
	public const int SpellPresetFieldNumber = 3;

	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x28")]
	private SpellPreset spellPreset_;

	[Token(Token = "0x17000492")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetSpellUpdateRequest> Parser
	{
		[Token(Token = "0x6001562")]
		[Address(RVA = "0xCE75B0", Offset = "0xCE69B0", VA = "0x180CE75B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000493")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001563")]
		[Address(RVA = "0xCE7500", Offset = "0xCE6900", VA = "0x180CE7500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000494")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001564")]
		[Address(RVA = "0xCE7810", Offset = "0xCE6C10", VA = "0x180CE7810", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000495")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PresetUuid
	{
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001569")]
		[Address(RVA = "0xCE78F0", Offset = "0xCE6CF0", VA = "0x180CE78F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000496")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Target Target
	{
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Types.Target);
		}
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000497")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellPreset SpellPreset
	{
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600156D")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6001565")]
	[Address(RVA = "0xCE74B0", Offset = "0xCE68B0", VA = "0x180CE74B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSpellUpdateRequest()
	{
	}

	[Token(Token = "0x6001566")]
	[Address(RVA = "0xCE73E0", Offset = "0xCE67E0", VA = "0x180CE73E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSpellUpdateRequest(PresetSpellUpdateRequest other)
	{
	}

	[Token(Token = "0x6001567")]
	[Address(RVA = "0xCE6FD0", Offset = "0xCE63D0", VA = "0x180CE6FD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSpellUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600156E")]
	[Address(RVA = "0xCE70C0", Offset = "0xCE64C0", VA = "0x180CE70C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600156F")]
	[Address(RVA = "0xBBC040", Offset = "0xBBB440", VA = "0x180BBC040", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetSpellUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001570")]
	[Address(RVA = "0xBBC190", Offset = "0xBBB590", VA = "0x180BBC190", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001571")]
	[Address(RVA = "0xCE7280", Offset = "0xCE6680", VA = "0x180CE7280", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001572")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001573")]
	[Address(RVA = "0xCE7760", Offset = "0xCE6B60", VA = "0x180CE7760", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001574")]
	[Address(RVA = "0xCE6EE0", Offset = "0xCE62E0", VA = "0x180CE6EE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001575")]
	[Address(RVA = "0xCE7190", Offset = "0xCE6590", VA = "0x180CE7190", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetSpellUpdateRequest other)
	{
	}

	[Token(Token = "0x6001576")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001577")]
	[Address(RVA = "0xCE7600", Offset = "0xCE6A00", VA = "0x180CE7600", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
