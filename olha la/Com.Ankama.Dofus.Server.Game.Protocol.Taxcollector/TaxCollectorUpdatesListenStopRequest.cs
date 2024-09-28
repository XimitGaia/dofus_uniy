using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x2000092")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorUpdatesListenStopRequest : IMessage<TaxCollectorUpdatesListenStopRequest>, IMessage, IEquatable<TaxCollectorUpdatesListenStopRequest>, IDeepCloneable<TaxCollectorUpdatesListenStopRequest>, IBufferMessage
{
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorUpdatesListenStopRequest> _parser;

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001EA")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x17000122")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorUpdatesListenStopRequest> Parser
	{
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x95A490", Offset = "0x959890", VA = "0x18095A490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000123")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x95A3E0", Offset = "0x9597E0", VA = "0x18095A3E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000124")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x95A5A0", Offset = "0x9599A0", VA = "0x18095A5A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000125")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TaxCollectorUid
	{
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x95A680", Offset = "0x959A80", VA = "0x18095A680")]
		set
		{
		}
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x95A2F0", Offset = "0x9596F0", VA = "0x18095A2F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorUpdatesListenStopRequest()
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x95A340", Offset = "0x959740", VA = "0x18095A340")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorUpdatesListenStopRequest(TaxCollectorUpdatesListenStopRequest other)
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x959FB0", Offset = "0x9593B0", VA = "0x180959FB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorUpdatesListenStopRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x95A080", Offset = "0x959480", VA = "0x18095A080", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorUpdatesListenStopRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x95A190", Offset = "0x959590", VA = "0x18095A190", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x959F20", Offset = "0x959320", VA = "0x180959F20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x95A130", Offset = "0x959530", VA = "0x18095A130", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorUpdatesListenStopRequest other)
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x95A4E0", Offset = "0x9598E0", VA = "0x18095A4E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
