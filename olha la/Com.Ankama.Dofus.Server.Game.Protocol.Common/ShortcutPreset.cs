using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000ABB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutPreset : IMessage<ShortcutPreset>, IMessage, IEquatable<ShortcutPreset>, IDeepCloneable<ShortcutPreset>, IBufferMessage
{
	[Token(Token = "0x4002741")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutPreset> _parser;

	[Token(Token = "0x4002742")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002743")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x4002744")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x4002745")]
	public const int TypeFieldNumber = 2;

	[Token(Token = "0x4002746")]
	[FieldOffset(Offset = "0x20")]
	private PresetType type_;

	[Token(Token = "0x1700187E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShortcutPreset> Parser
	{
		[Token(Token = "0x600705A")]
		[Address(RVA = "0xBEA900", Offset = "0xBE9D00", VA = "0x180BEA900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700187F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600705B")]
		[Address(RVA = "0xBEA850", Offset = "0xBE9C50", VA = "0x180BEA850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001880")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600705C")]
		[Address(RVA = "0xBEAA20", Offset = "0xBE9E20", VA = "0x180BEAA20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001881")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PresetUuid
	{
		[Token(Token = "0x6007060")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007061")]
		[Address(RVA = "0xBEAB00", Offset = "0xBE9F00", VA = "0x180BEAB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001882")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetType Type
	{
		[Token(Token = "0x6007062")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(PresetType);
		}
		[Token(Token = "0x6007063")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600705D")]
	[Address(RVA = "0xBEA750", Offset = "0xBE9B50", VA = "0x180BEA750")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutPreset()
	{
	}

	[Token(Token = "0x600705E")]
	[Address(RVA = "0xBEA7A0", Offset = "0xBE9BA0", VA = "0x180BEA7A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutPreset(ShortcutPreset other)
	{
	}

	[Token(Token = "0x600705F")]
	[Address(RVA = "0xBEA400", Offset = "0xBE9800", VA = "0x180BEA400", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutPreset Clone()
	{
		return null;
	}

	[Token(Token = "0x6007064")]
	[Address(RVA = "0xBEA4D0", Offset = "0xBE98D0", VA = "0x180BEA4D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007065")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShortcutPreset other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007066")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007067")]
	[Address(RVA = "0xBEA5F0", Offset = "0xBE99F0", VA = "0x180BEA5F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007068")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007069")]
	[Address(RVA = "0x958970", Offset = "0x957D70", VA = "0x180958970", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600706A")]
	[Address(RVA = "0xBEA340", Offset = "0xBE9740", VA = "0x180BEA340", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600706B")]
	[Address(RVA = "0xBEA580", Offset = "0xBE9980", VA = "0x180BEA580", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ShortcutPreset other)
	{
	}

	[Token(Token = "0x600706C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600706D")]
	[Address(RVA = "0xBEA950", Offset = "0xBE9D50", VA = "0x180BEA950", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
