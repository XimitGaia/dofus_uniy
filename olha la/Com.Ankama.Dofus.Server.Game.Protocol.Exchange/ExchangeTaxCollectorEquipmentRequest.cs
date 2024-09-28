using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200068D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeTaxCollectorEquipmentRequest : IMessage<ExchangeTaxCollectorEquipmentRequest>, IMessage, IEquatable<ExchangeTaxCollectorEquipmentRequest>, IDeepCloneable<ExchangeTaxCollectorEquipmentRequest>, IBufferMessage
{
	[Token(Token = "0x40016EF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeTaxCollectorEquipmentRequest> _parser;

	[Token(Token = "0x40016F0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40016F1")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x40016F2")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x17000F04")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeTaxCollectorEquipmentRequest> Parser
	{
		[Token(Token = "0x600463C")]
		[Address(RVA = "0xA97FD0", Offset = "0xA973D0", VA = "0x180A97FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F05")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600463D")]
		[Address(RVA = "0xA97F20", Offset = "0xA97320", VA = "0x180A97F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F06")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600463E")]
		[Address(RVA = "0xA980E0", Offset = "0xA974E0", VA = "0x180A980E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F07")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TaxCollectorUid
	{
		[Token(Token = "0x6004642")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004643")]
		[Address(RVA = "0xA981C0", Offset = "0xA975C0", VA = "0x180A981C0")]
		set
		{
		}
	}

	[Token(Token = "0x600463F")]
	[Address(RVA = "0xA97E30", Offset = "0xA97230", VA = "0x180A97E30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorEquipmentRequest()
	{
	}

	[Token(Token = "0x6004640")]
	[Address(RVA = "0xA97E80", Offset = "0xA97280", VA = "0x180A97E80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorEquipmentRequest(ExchangeTaxCollectorEquipmentRequest other)
	{
	}

	[Token(Token = "0x6004641")]
	[Address(RVA = "0xA97AF0", Offset = "0xA96EF0", VA = "0x180A97AF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeTaxCollectorEquipmentRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004644")]
	[Address(RVA = "0xA97BC0", Offset = "0xA96FC0", VA = "0x180A97BC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004645")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeTaxCollectorEquipmentRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004646")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004647")]
	[Address(RVA = "0xA97CD0", Offset = "0xA970D0", VA = "0x180A97CD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004648")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004649")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600464A")]
	[Address(RVA = "0xA97A60", Offset = "0xA96E60", VA = "0x180A97A60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600464B")]
	[Address(RVA = "0xA97C70", Offset = "0xA97070", VA = "0x180A97C70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeTaxCollectorEquipmentRequest other)
	{
	}

	[Token(Token = "0x600464C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600464D")]
	[Address(RVA = "0xA98020", Offset = "0xA97420", VA = "0x180A98020", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
