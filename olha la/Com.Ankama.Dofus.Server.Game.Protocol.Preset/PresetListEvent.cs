using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000251")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetListEvent : IMessage<PresetListEvent>, IMessage, IEquatable<PresetListEvent>, IDeepCloneable<PresetListEvent>, IBufferMessage
{
	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetListEvent> _parser;

	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007DA")]
	public const int CharacterPresetInfoByIdFieldNumber = 1;

	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MapField<string, CharacterPresetInfo>.Codec _map_characterPresetInfoById_codec;

	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x18")]
	private readonly MapField<string, CharacterPresetInfo> characterPresetInfoById_;

	[Token(Token = "0x40007DD")]
	public const int ForgettableSpellPresetInfoByIdFieldNumber = 2;

	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x10")]
	private static readonly MapField<string, ForgettableSpellPresetInfo>.Codec _map_forgettableSpellPresetInfoById_codec;

	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x20")]
	private readonly MapField<string, ForgettableSpellPresetInfo> forgettableSpellPresetInfoById_;

	[Token(Token = "0x17000509")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetListEvent> Parser
	{
		[Token(Token = "0x600179E")]
		[Address(RVA = "0xD01C00", Offset = "0xD01000", VA = "0x180D01C00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600179F")]
		[Address(RVA = "0xD01B50", Offset = "0xD00F50", VA = "0x180D01B50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0xD01EB0", Offset = "0xD012B0", VA = "0x180D01EB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, CharacterPresetInfo> CharacterPresetInfoById
	{
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, ForgettableSpellPresetInfo> ForgettableSpellPresetInfoById
	{
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60017A1")]
	[Address(RVA = "0xD019D0", Offset = "0xD00DD0", VA = "0x180D019D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetListEvent()
	{
	}

	[Token(Token = "0x60017A2")]
	[Address(RVA = "0xD01A90", Offset = "0xD00E90", VA = "0x180D01A90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetListEvent(PresetListEvent other)
	{
	}

	[Token(Token = "0x60017A3")]
	[Address(RVA = "0xD012F0", Offset = "0xD006F0", VA = "0x180D012F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60017A6")]
	[Address(RVA = "0xD013E0", Offset = "0xD007E0", VA = "0x180D013E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60017A7")]
	[Address(RVA = "0xD014E0", Offset = "0xD008E0", VA = "0x180D014E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60017A9")]
	[Address(RVA = "0xD01640", Offset = "0xD00A40", VA = "0x180D01640", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60017AB")]
	[Address(RVA = "0xD01DC0", Offset = "0xD011C0", VA = "0x180D01DC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60017AC")]
	[Address(RVA = "0xD01210", Offset = "0xD00610", VA = "0x180D01210", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60017AD")]
	[Address(RVA = "0xD015A0", Offset = "0xD009A0", VA = "0x180D015A0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetListEvent other)
	{
	}

	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60017AF")]
	[Address(RVA = "0xD01C50", Offset = "0xD01050", VA = "0x180D01C50", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
