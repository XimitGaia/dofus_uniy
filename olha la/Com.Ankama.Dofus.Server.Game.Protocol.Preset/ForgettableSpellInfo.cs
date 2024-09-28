using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001D9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellInfo : IMessage<ForgettableSpellInfo>, IMessage, IEquatable<ForgettableSpellInfo>, IDeepCloneable<ForgettableSpellInfo>, IBufferMessage
{
	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellInfo> _parser;

	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000655")]
	public const int SpellPositionsFieldNumber = 1;

	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x18")]
	private SpellPositions spellPositions_;

	[Token(Token = "0x4000657")]
	public const int IsMissingFieldNumber = 2;

	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x20")]
	private bool isMissing_;

	[Token(Token = "0x1700040C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ForgettableSpellInfo> Parser
	{
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0xCC2E40", Offset = "0xCC2240", VA = "0x180CC2E40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700040D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0xCC2D90", Offset = "0xCC2190", VA = "0x180CC2D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700040E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0xCC2FC0", Offset = "0xCC23C0", VA = "0x180CC2FC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700040F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellPositions SpellPositions
	{
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000410")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsMissing
	{
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellInfo()
	{
	}

	[Token(Token = "0x60012E2")]
	[Address(RVA = "0xCC2C70", Offset = "0xCC2070", VA = "0x180CC2C70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellInfo(ForgettableSpellInfo other)
	{
	}

	[Token(Token = "0x60012E3")]
	[Address(RVA = "0xCC2710", Offset = "0xCC1B10", VA = "0x180CC2710", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellInfo Clone()
	{
		return null;
	}

	[Token(Token = "0x60012E8")]
	[Address(RVA = "0xCC2860", Offset = "0xCC1C60", VA = "0x180CC2860", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x9BD760", Offset = "0x9BCB60", VA = "0x1809BD760", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ForgettableSpellInfo other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012EA")]
	[Address(RVA = "0xCC2910", Offset = "0xCC1D10", VA = "0x180CC2910", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60012EB")]
	[Address(RVA = "0xCC2B10", Offset = "0xCC1F10", VA = "0x180CC2B10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x9BDE30", Offset = "0x9BD230", VA = "0x1809BDE30", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60012EE")]
	[Address(RVA = "0xCC2680", Offset = "0xCC1A80", VA = "0x180CC2680", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60012EF")]
	[Address(RVA = "0xCC29D0", Offset = "0xCC1DD0", VA = "0x180CC29D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ForgettableSpellInfo other)
	{
	}

	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60012F1")]
	[Address(RVA = "0xCC2E90", Offset = "0xCC2290", VA = "0x180CC2E90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
