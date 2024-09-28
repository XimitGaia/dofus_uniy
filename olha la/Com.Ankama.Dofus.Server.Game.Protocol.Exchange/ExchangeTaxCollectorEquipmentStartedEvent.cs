using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006D1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeTaxCollectorEquipmentStartedEvent : IMessage<ExchangeTaxCollectorEquipmentStartedEvent>, IMessage, IEquatable<ExchangeTaxCollectorEquipmentStartedEvent>, IDeepCloneable<ExchangeTaxCollectorEquipmentStartedEvent>, IBufferMessage
{
	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeTaxCollectorEquipmentStartedEvent> _parser;

	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017F5")]
	public const int TaxCollectorInformationFieldNumber = 1;

	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0x18")]
	private TaxCollectorInformation taxCollectorInformation_;

	[Token(Token = "0x17000FAD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeTaxCollectorEquipmentStartedEvent> Parser
	{
		[Token(Token = "0x6004953")]
		[Address(RVA = "0xAAD9D0", Offset = "0xAACDD0", VA = "0x180AAD9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FAE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004954")]
		[Address(RVA = "0xAAD920", Offset = "0xAACD20", VA = "0x180AAD920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FAF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004955")]
		[Address(RVA = "0xAADB20", Offset = "0xAACF20", VA = "0x180AADB20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorInformation TaxCollectorInformation
	{
		[Token(Token = "0x6004959")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600495A")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6004956")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeTaxCollectorEquipmentStartedEvent()
	{
	}

	[Token(Token = "0x6004957")]
	[Address(RVA = "0xA6A750", Offset = "0xA69B50", VA = "0x180A6A750")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorEquipmentStartedEvent(ExchangeTaxCollectorEquipmentStartedEvent other)
	{
	}

	[Token(Token = "0x6004958")]
	[Address(RVA = "0xAAD5A0", Offset = "0xAAC9A0", VA = "0x180AAD5A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeTaxCollectorEquipmentStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600495B")]
	[Address(RVA = "0xAAD640", Offset = "0xAACA40", VA = "0x180AAD640", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600495C")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeTaxCollectorEquipmentStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600495D")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600495E")]
	[Address(RVA = "0xAAD7C0", Offset = "0xAACBC0", VA = "0x180AAD7C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600495F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004960")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004961")]
	[Address(RVA = "0xAAD510", Offset = "0xAAC910", VA = "0x180AAD510", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004962")]
	[Address(RVA = "0xAAD6F0", Offset = "0xAACAF0", VA = "0x180AAD6F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeTaxCollectorEquipmentStartedEvent other)
	{
	}

	[Token(Token = "0x6004963")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004964")]
	[Address(RVA = "0xAADA20", Offset = "0xAACE20", VA = "0x180AADA20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
