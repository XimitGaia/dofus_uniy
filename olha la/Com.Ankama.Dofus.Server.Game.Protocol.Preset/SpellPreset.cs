using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001DB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellPreset : IMessage<SpellPreset>, IMessage, IEquatable<SpellPreset>, IDeepCloneable<SpellPreset>, IBufferMessage
{
	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellPreset> _parser;

	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400065C")]
	public const int SpellPositionsByIdFieldNumber = 1;

	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MapField<int, SpellPositions>.Codec _map_spellPositionsById_codec;

	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x18")]
	private readonly MapField<int, SpellPositions> spellPositionsById_;

	[Token(Token = "0x17000411")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpellPreset> Parser
	{
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0xCD6F00", Offset = "0xCD6300", VA = "0x180CD6F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000412")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0xCD6E50", Offset = "0xCD6250", VA = "0x180CD6E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000413")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0xCD7110", Offset = "0xCD6510", VA = "0x180CD7110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000414")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, SpellPositions> SpellPositionsById
	{
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60012F9")]
	[Address(RVA = "0xCD6DD0", Offset = "0xCD61D0", VA = "0x180CD6DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellPreset()
	{
	}

	[Token(Token = "0x60012FA")]
	[Address(RVA = "0xCD6D40", Offset = "0xCD6140", VA = "0x180CD6D40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellPreset(SpellPreset other)
	{
	}

	[Token(Token = "0x60012FB")]
	[Address(RVA = "0xCD6820", Offset = "0xCD5C20", VA = "0x180CD6820", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellPreset Clone()
	{
		return null;
	}

	[Token(Token = "0x60012FD")]
	[Address(RVA = "0xCD6970", Offset = "0xCD5D70", VA = "0x180CD6970", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012FE")]
	[Address(RVA = "0xCD68E0", Offset = "0xCD5CE0", VA = "0x180CD68E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SpellPreset other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001300")]
	[Address(RVA = "0xCD6AD0", Offset = "0xCD5ED0", VA = "0x180CD6AD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001301")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001302")]
	[Address(RVA = "0xCD7060", Offset = "0xCD6460", VA = "0x180CD7060", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001303")]
	[Address(RVA = "0xCD6780", Offset = "0xCD5B80", VA = "0x180CD6780", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001304")]
	[Address(RVA = "0xCD6A50", Offset = "0xCD5E50", VA = "0x180CD6A50", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SpellPreset other)
	{
	}

	[Token(Token = "0x6001305")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001306")]
	[Address(RVA = "0xCD6F50", Offset = "0xCD6350", VA = "0x180CD6F50", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
