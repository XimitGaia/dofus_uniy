using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug;

[Token(Token = "0x200076B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DumpedEntityStatsEvent : IMessage<DumpedEntityStatsEvent>, IMessage, IEquatable<DumpedEntityStatsEvent>, IDeepCloneable<DumpedEntityStatsEvent>, IBufferMessage
{
	[Token(Token = "0x40019F4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DumpedEntityStatsEvent> _parser;

	[Token(Token = "0x40019F5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019F6")]
	public const int EntityIdFieldNumber = 1;

	[Token(Token = "0x40019F7")]
	[FieldOffset(Offset = "0x18")]
	private long entityId_;

	[Token(Token = "0x40019F8")]
	public const int StatsFieldNumber = 2;

	[Token(Token = "0x40019F9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<CharacterCharacteristic> _repeated_stats_codec;

	[Token(Token = "0x40019FA")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<CharacterCharacteristic> stats_;

	[Token(Token = "0x170010F4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DumpedEntityStatsEvent> Parser
	{
		[Token(Token = "0x6004F46")]
		[Address(RVA = "0xADC1A0", Offset = "0xADB5A0", VA = "0x180ADC1A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004F47")]
		[Address(RVA = "0xADC0F0", Offset = "0xADB4F0", VA = "0x180ADC0F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004F48")]
		[Address(RVA = "0xADC3F0", Offset = "0xADB7F0", VA = "0x180ADC3F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EntityId
	{
		[Token(Token = "0x6004F4C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170010F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharacterCharacteristic> Stats
	{
		[Token(Token = "0x6004F4E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F49")]
	[Address(RVA = "0xADC070", Offset = "0xADB470", VA = "0x180ADC070")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DumpedEntityStatsEvent()
	{
	}

	[Token(Token = "0x6004F4A")]
	[Address(RVA = "0xADBFD0", Offset = "0xADB3D0", VA = "0x180ADBFD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DumpedEntityStatsEvent(DumpedEntityStatsEvent other)
	{
	}

	[Token(Token = "0x6004F4B")]
	[Address(RVA = "0xADBB00", Offset = "0xADAF00", VA = "0x180ADBB00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DumpedEntityStatsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004F4F")]
	[Address(RVA = "0xADBBC0", Offset = "0xADAFC0", VA = "0x180ADBBC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F50")]
	[Address(RVA = "0xADBCA0", Offset = "0xADB0A0", VA = "0x180ADBCA0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DumpedEntityStatsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F51")]
	[Address(RVA = "0x97D020", Offset = "0x97C420", VA = "0x18097D020", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004F52")]
	[Address(RVA = "0xADBDD0", Offset = "0xADB1D0", VA = "0x180ADBDD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004F53")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004F54")]
	[Address(RVA = "0xADC320", Offset = "0xADB720", VA = "0x180ADC320", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004F55")]
	[Address(RVA = "0xADBA20", Offset = "0xADAE20", VA = "0x180ADBA20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004F56")]
	[Address(RVA = "0xADBD40", Offset = "0xADB140", VA = "0x180ADBD40", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DumpedEntityStatsEvent other)
	{
	}

	[Token(Token = "0x6004F57")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004F58")]
	[Address(RVA = "0xADC1F0", Offset = "0xADB5F0", VA = "0x180ADC1F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
