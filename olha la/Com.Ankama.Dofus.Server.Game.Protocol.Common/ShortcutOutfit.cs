using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AB9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutOutfit : IMessage<ShortcutOutfit>, IMessage, IEquatable<ShortcutOutfit>, IDeepCloneable<ShortcutOutfit>, IBufferMessage
{
	[Token(Token = "0x400273C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutOutfit> _parser;

	[Token(Token = "0x400273D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400273E")]
	public const int OutfitUuidFieldNumber = 1;

	[Token(Token = "0x400273F")]
	[FieldOffset(Offset = "0x18")]
	private string outfitUuid_;

	[Token(Token = "0x1700187A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShortcutOutfit> Parser
	{
		[Token(Token = "0x6007044")]
		[Address(RVA = "0xBEA0E0", Offset = "0xBE94E0", VA = "0x180BEA0E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700187B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007045")]
		[Address(RVA = "0xBEA030", Offset = "0xBE9430", VA = "0x180BEA030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700187C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007046")]
		[Address(RVA = "0xBEA1F0", Offset = "0xBE95F0", VA = "0x180BEA1F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700187D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string OutfitUuid
	{
		[Token(Token = "0x600704A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600704B")]
		[Address(RVA = "0xBEA2D0", Offset = "0xBE96D0", VA = "0x180BEA2D0")]
		set
		{
		}
	}

	[Token(Token = "0x6007047")]
	[Address(RVA = "0xBE9F40", Offset = "0xBE9340", VA = "0x180BE9F40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutOutfit()
	{
	}

	[Token(Token = "0x6007048")]
	[Address(RVA = "0xBE9F90", Offset = "0xBE9390", VA = "0x180BE9F90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutOutfit(ShortcutOutfit other)
	{
	}

	[Token(Token = "0x6007049")]
	[Address(RVA = "0xBE9C00", Offset = "0xBE9000", VA = "0x180BE9C00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutOutfit Clone()
	{
		return null;
	}

	[Token(Token = "0x600704C")]
	[Address(RVA = "0xBE9CD0", Offset = "0xBE90D0", VA = "0x180BE9CD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600704D")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShortcutOutfit other)
	{
		return default(bool);
	}

	[Token(Token = "0x600704E")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600704F")]
	[Address(RVA = "0xBE9DE0", Offset = "0xBE91E0", VA = "0x180BE9DE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007050")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007051")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007052")]
	[Address(RVA = "0xBE9B70", Offset = "0xBE8F70", VA = "0x180BE9B70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007053")]
	[Address(RVA = "0xBE9D80", Offset = "0xBE9180", VA = "0x180BE9D80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ShortcutOutfit other)
	{
	}

	[Token(Token = "0x6007054")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007055")]
	[Address(RVA = "0xBEA130", Offset = "0xBE9530", VA = "0x180BEA130", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
