using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000220")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetStatUpdateRequest : IMessage<PresetStatUpdateRequest>, IMessage, IEquatable<PresetStatUpdateRequest>, IDeepCloneable<PresetStatUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetStatUpdateRequest> _parser;

	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000739")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x400073B")]
	public const int StatByIdFieldNumber = 2;

	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MapField<int, int>.Codec _map_statById_codec;

	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x20")]
	private readonly MapField<int, int> statById_;

	[Token(Token = "0x1700049C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetStatUpdateRequest> Parser
	{
		[Token(Token = "0x6001592")]
		[Address(RVA = "0xCE8630", Offset = "0xCE7A30", VA = "0x180CE8630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001593")]
		[Address(RVA = "0xCE8580", Offset = "0xCE7980", VA = "0x180CE8580")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001594")]
		[Address(RVA = "0xCE88B0", Offset = "0xCE7CB0", VA = "0x180CE88B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PresetUuid
	{
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001599")]
		[Address(RVA = "0xCE8990", Offset = "0xCE7D90", VA = "0x180CE8990")]
		set
		{
		}
	}

	[Token(Token = "0x170004A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, int> StatById
	{
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001595")]
	[Address(RVA = "0xCE84E0", Offset = "0xCE78E0", VA = "0x180CE84E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetStatUpdateRequest()
	{
	}

	[Token(Token = "0x6001596")]
	[Address(RVA = "0xCE8440", Offset = "0xCE7840", VA = "0x180CE8440")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetStatUpdateRequest(PresetStatUpdateRequest other)
	{
	}

	[Token(Token = "0x6001597")]
	[Address(RVA = "0xCE7F40", Offset = "0xCE7340", VA = "0x180CE7F40", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetStatUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600159B")]
	[Address(RVA = "0xCE8010", Offset = "0xCE7410", VA = "0x180CE8010", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600159C")]
	[Address(RVA = "0xCE8100", Offset = "0xCE7500", VA = "0x180CE8100", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetStatUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600159D")]
	[Address(RVA = "0xA68490", Offset = "0xA67890", VA = "0x180A68490", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600159E")]
	[Address(RVA = "0xCE8250", Offset = "0xCE7650", VA = "0x180CE8250", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600159F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60015A0")]
	[Address(RVA = "0xCE87D0", Offset = "0xCE7BD0", VA = "0x180CE87D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60015A1")]
	[Address(RVA = "0xCE7E50", Offset = "0xCE7250", VA = "0x180CE7E50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60015A2")]
	[Address(RVA = "0xCE81B0", Offset = "0xCE75B0", VA = "0x180CE81B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetStatUpdateRequest other)
	{
	}

	[Token(Token = "0x60015A3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60015A4")]
	[Address(RVA = "0xCE8680", Offset = "0xCE7A80", VA = "0x180CE8680", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
