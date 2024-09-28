using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006E8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeTaxCollectorShopStartedEvent : IMessage<ExchangeTaxCollectorShopStartedEvent>, IMessage, IEquatable<ExchangeTaxCollectorShopStartedEvent>, IDeepCloneable<ExchangeTaxCollectorShopStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4001848")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeTaxCollectorShopStartedEvent> _parser;

	[Token(Token = "0x4001849")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400184A")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x400184B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x400184C")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x400184D")]
	public const int KamasFieldNumber = 2;

	[Token(Token = "0x400184E")]
	[FieldOffset(Offset = "0x20")]
	private long kamas_;

	[Token(Token = "0x17000FDE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeTaxCollectorShopStartedEvent> Parser
	{
		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0xAAE380", Offset = "0xAAD780", VA = "0x180AAE380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FDF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004A30")]
		[Address(RVA = "0xAAE2D0", Offset = "0xAAD6D0", VA = "0x180AAE2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004A31")]
		[Address(RVA = "0xAAE5D0", Offset = "0xAAD9D0", VA = "0x180AAE5D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FE1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FE2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Kamas
	{
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6004A32")]
	[Address(RVA = "0xAAE1B0", Offset = "0xAAD5B0", VA = "0x180AAE1B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorShopStartedEvent()
	{
	}

	[Token(Token = "0x6004A33")]
	[Address(RVA = "0xAAE230", Offset = "0xAAD630", VA = "0x180AAE230")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorShopStartedEvent(ExchangeTaxCollectorShopStartedEvent other)
	{
	}

	[Token(Token = "0x6004A34")]
	[Address(RVA = "0xAADCE0", Offset = "0xAAD0E0", VA = "0x180AADCE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeTaxCollectorShopStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004A38")]
	[Address(RVA = "0xAADE40", Offset = "0xAAD240", VA = "0x180AADE40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A39")]
	[Address(RVA = "0xAADDA0", Offset = "0xAAD1A0", VA = "0x180AADDA0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeTaxCollectorShopStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A3A")]
	[Address(RVA = "0x983110", Offset = "0x982510", VA = "0x180983110", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004A3B")]
	[Address(RVA = "0xAADFB0", Offset = "0xAAD3B0", VA = "0x180AADFB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004A3C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004A3D")]
	[Address(RVA = "0xAAE500", Offset = "0xAAD900", VA = "0x180AAE500", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004A3E")]
	[Address(RVA = "0xAADC00", Offset = "0xAAD000", VA = "0x180AADC00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004A3F")]
	[Address(RVA = "0xAADF20", Offset = "0xAAD320", VA = "0x180AADF20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeTaxCollectorShopStartedEvent other)
	{
	}

	[Token(Token = "0x6004A40")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004A41")]
	[Address(RVA = "0xAAE3D0", Offset = "0xAAD7D0", VA = "0x180AAE3D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
