using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006E6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMountStockStartedEvent : IMessage<ExchangeMountStockStartedEvent>, IMessage, IEquatable<ExchangeMountStockStartedEvent>, IDeepCloneable<ExchangeMountStockStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4001842")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMountStockStartedEvent> _parser;

	[Token(Token = "0x4001843")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001844")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4001845")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x4001846")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x17000FDA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeMountStockStartedEvent> Parser
	{
		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0xAA81B0", Offset = "0xAA75B0", VA = "0x180AA81B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FDB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0xAA8100", Offset = "0xAA7500", VA = "0x180AA8100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FDC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0xAA83C0", Offset = "0xAA77C0", VA = "0x180AA83C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FDD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004A1D")]
	[Address(RVA = "0xAA7FF0", Offset = "0xAA73F0", VA = "0x180AA7FF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountStockStartedEvent()
	{
	}

	[Token(Token = "0x6004A1E")]
	[Address(RVA = "0xAA8070", Offset = "0xAA7470", VA = "0x180AA8070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountStockStartedEvent(ExchangeMountStockStartedEvent other)
	{
	}

	[Token(Token = "0x6004A1F")]
	[Address(RVA = "0xAA7B40", Offset = "0xAA6F40", VA = "0x180AA7B40", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMountStockStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004A21")]
	[Address(RVA = "0xAA7C00", Offset = "0xAA7000", VA = "0x180AA7C00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A22")]
	[Address(RVA = "0xAA7CE0", Offset = "0xAA70E0", VA = "0x180AA7CE0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMountStockStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A23")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004A24")]
	[Address(RVA = "0xAA7DF0", Offset = "0xAA71F0", VA = "0x180AA7DF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004A25")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004A26")]
	[Address(RVA = "0xAA8310", Offset = "0xAA7710", VA = "0x180AA8310", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004A27")]
	[Address(RVA = "0xAA7AA0", Offset = "0xAA6EA0", VA = "0x180AA7AA0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004A28")]
	[Address(RVA = "0xAA7D70", Offset = "0xAA7170", VA = "0x180AA7D70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeMountStockStartedEvent other)
	{
	}

	[Token(Token = "0x6004A29")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004A2A")]
	[Address(RVA = "0xAA8200", Offset = "0xAA7600", VA = "0x180AA8200", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
