using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000C2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorPresetsEvent : IMessage<TaxCollectorPresetsEvent>, IMessage, IEquatable<TaxCollectorPresetsEvent>, IDeepCloneable<TaxCollectorPresetsEvent>, IBufferMessage
{
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorPresetsEvent> _parser;

	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002A7")]
	public const int PresetsFieldNumber = 1;

	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TaxCollectorPreset> _repeated_presets_codec;

	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<TaxCollectorPreset> presets_;

	[Token(Token = "0x17000197")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorPresetsEvent> Parser
	{
		[Token(Token = "0x6000767")]
		[Address(RVA = "0xA6A050", Offset = "0xA69450", VA = "0x180A6A050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000198")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000768")]
		[Address(RVA = "0xA69FA0", Offset = "0xA693A0", VA = "0x180A69FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000199")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000769")]
		[Address(RVA = "0xA6A260", Offset = "0xA69660", VA = "0x180A6A260", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700019A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<TaxCollectorPreset> Presets
	{
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0xA69F20", Offset = "0xA69320", VA = "0x180A69F20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetsEvent()
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0xA69E90", Offset = "0xA69290", VA = "0x180A69E90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetsEvent(TaxCollectorPresetsEvent other)
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0xA699E0", Offset = "0xA68DE0", VA = "0x180A699E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorPresetsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0xA69B30", Offset = "0xA68F30", VA = "0x180A69B30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0xA69AA0", Offset = "0xA68EA0", VA = "0x180A69AA0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorPresetsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0xA69C90", Offset = "0xA69090", VA = "0x180A69C90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0xA6A1B0", Offset = "0xA695B0", VA = "0x180A6A1B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0xA69940", Offset = "0xA68D40", VA = "0x180A69940", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0xA69C10", Offset = "0xA69010", VA = "0x180A69C10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorPresetsEvent other)
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0xA6A0A0", Offset = "0xA694A0", VA = "0x180A6A0A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
