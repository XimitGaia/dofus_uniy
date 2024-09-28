using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200024B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetOutfitUpdateRequest : IMessage<PresetOutfitUpdateRequest>, IMessage, IEquatable<PresetOutfitUpdateRequest>, IDeepCloneable<PresetOutfitUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetOutfitUpdateRequest> _parser;

	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007C1")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x40007C3")]
	public const int OutfitUuidFieldNumber = 2;

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string OutfitUuidDefaultValue;

	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x20")]
	private string outfitUuid_;

	[Token(Token = "0x170004F8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetOutfitUpdateRequest> Parser
	{
		[Token(Token = "0x6001753")]
		[Address(RVA = "0xD02810", Offset = "0xD01C10", VA = "0x180D02810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001754")]
		[Address(RVA = "0xD02700", Offset = "0xD01B00", VA = "0x180D02700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001755")]
		[Address(RVA = "0xD02A30", Offset = "0xD01E30", VA = "0x180D02A30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PresetUuid
	{
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600175A")]
		[Address(RVA = "0xD02B80", Offset = "0xD01F80", VA = "0x180D02B80")]
		set
		{
		}
	}

	[Token(Token = "0x170004FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string OutfitUuid
	{
		[Token(Token = "0x600175B")]
		[Address(RVA = "0xD027B0", Offset = "0xD01BB0", VA = "0x180D027B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600175C")]
		[Address(RVA = "0xD02B10", Offset = "0xD01F10", VA = "0x180D02B10")]
		set
		{
		}
	}

	[Token(Token = "0x170004FD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasOutfitUuid
	{
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x916800", Offset = "0x915C00", VA = "0x180916800")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001756")]
	[Address(RVA = "0xD02600", Offset = "0xD01A00", VA = "0x180D02600")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOutfitUpdateRequest()
	{
	}

	[Token(Token = "0x6001757")]
	[Address(RVA = "0xD02650", Offset = "0xD01A50", VA = "0x180D02650")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetOutfitUpdateRequest(PresetOutfitUpdateRequest other)
	{
	}

	[Token(Token = "0x6001758")]
	[Address(RVA = "0xD020A0", Offset = "0xD014A0", VA = "0x180D020A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOutfitUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600175E")]
	[Address(RVA = "0x915FF0", Offset = "0x9153F0", VA = "0x180915FF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearOutfitUuid()
	{
	}

	[Token(Token = "0x600175F")]
	[Address(RVA = "0xD02220", Offset = "0xD01620", VA = "0x180D02220", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001760")]
	[Address(RVA = "0xD02180", Offset = "0xD01580", VA = "0x180D02180", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetOutfitUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001761")]
	[Address(RVA = "0xD02300", Offset = "0xD01700", VA = "0x180D02300", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001762")]
	[Address(RVA = "0xD02460", Offset = "0xD01860", VA = "0x180D02460", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001763")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001764")]
	[Address(RVA = "0xD02950", Offset = "0xD01D50", VA = "0x180D02950", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001765")]
	[Address(RVA = "0xD01F90", Offset = "0xD01390", VA = "0x180D01F90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001766")]
	[Address(RVA = "0xD023E0", Offset = "0xD017E0", VA = "0x180D023E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetOutfitUpdateRequest other)
	{
	}

	[Token(Token = "0x6001767")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001768")]
	[Address(RVA = "0xD02860", Offset = "0xD01C60", VA = "0x180D02860", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
