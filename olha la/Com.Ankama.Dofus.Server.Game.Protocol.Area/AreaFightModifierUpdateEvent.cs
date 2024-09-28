using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Area;

[Token(Token = "0x2000BDC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AreaFightModifierUpdateEvent : IMessage<AreaFightModifierUpdateEvent>, IMessage, IEquatable<AreaFightModifierUpdateEvent>, IDeepCloneable<AreaFightModifierUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4002C0C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AreaFightModifierUpdateEvent> _parser;

	[Token(Token = "0x4002C0D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C0E")]
	public const int SpellPairsFieldNumber = 1;

	[Token(Token = "0x4002C0F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_spellPairs_codec;

	[Token(Token = "0x4002C10")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> spellPairs_;

	[Token(Token = "0x17001B65")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AreaFightModifierUpdateEvent> Parser
	{
		[Token(Token = "0x6007CA6")]
		[Address(RVA = "0xC2D450", Offset = "0xC2C850", VA = "0x180C2D450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B66")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007CA7")]
		[Address(RVA = "0xC2D3A0", Offset = "0xC2C7A0", VA = "0x180C2D3A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B67")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007CA8")]
		[Address(RVA = "0xC2D670", Offset = "0xC2CA70", VA = "0x180C2D670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B68")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SpellPairs
	{
		[Token(Token = "0x6007CAC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007CA9")]
	[Address(RVA = "0xC2D320", Offset = "0xC2C720", VA = "0x180C2D320")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaFightModifierUpdateEvent()
	{
	}

	[Token(Token = "0x6007CAA")]
	[Address(RVA = "0xC2D290", Offset = "0xC2C690", VA = "0x180C2D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaFightModifierUpdateEvent(AreaFightModifierUpdateEvent other)
	{
	}

	[Token(Token = "0x6007CAB")]
	[Address(RVA = "0xC2CE50", Offset = "0xC2C250", VA = "0x180C2CE50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AreaFightModifierUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007CAD")]
	[Address(RVA = "0xC2CFA0", Offset = "0xC2C3A0", VA = "0x180C2CFA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CAE")]
	[Address(RVA = "0xC2CF10", Offset = "0xC2C310", VA = "0x180C2CF10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AreaFightModifierUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CAF")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007CB0")]
	[Address(RVA = "0xC2D100", Offset = "0xC2C500", VA = "0x180C2D100", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007CB1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007CB2")]
	[Address(RVA = "0xC2D5C0", Offset = "0xC2C9C0", VA = "0x180C2D5C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007CB3")]
	[Address(RVA = "0xC2CDB0", Offset = "0xC2C1B0", VA = "0x180C2CDB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007CB4")]
	[Address(RVA = "0xC2D080", Offset = "0xC2C480", VA = "0x180C2D080", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AreaFightModifierUpdateEvent other)
	{
	}

	[Token(Token = "0x6007CB5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007CB6")]
	[Address(RVA = "0xC2D4A0", Offset = "0xC2C8A0", VA = "0x180C2D4A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
