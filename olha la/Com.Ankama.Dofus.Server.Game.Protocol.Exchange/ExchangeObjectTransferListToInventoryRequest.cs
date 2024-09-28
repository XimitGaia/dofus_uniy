using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200064E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectTransferListToInventoryRequest : IMessage<ExchangeObjectTransferListToInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferListToInventoryRequest>, IDeepCloneable<ExchangeObjectTransferListToInventoryRequest>, IBufferMessage
{
	[Token(Token = "0x400162F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectTransferListToInventoryRequest> _parser;

	[Token(Token = "0x4001630")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001631")]
	public const int ObjectsUidFieldNumber = 1;

	[Token(Token = "0x4001632")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_objectsUid_codec;

	[Token(Token = "0x4001633")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> objectsUid_;

	[Token(Token = "0x17000E84")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeObjectTransferListToInventoryRequest> Parser
	{
		[Token(Token = "0x600439E")]
		[Address(RVA = "0xA90D40", Offset = "0xA90140", VA = "0x180A90D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E85")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600439F")]
		[Address(RVA = "0xA90C90", Offset = "0xA90090", VA = "0x180A90C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E86")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0xA90F60", Offset = "0xA90360", VA = "0x180A90F60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E87")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ObjectsUid
	{
		[Token(Token = "0x60043A4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60043A1")]
	[Address(RVA = "0xA90B80", Offset = "0xA8FF80", VA = "0x180A90B80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectTransferListToInventoryRequest()
	{
	}

	[Token(Token = "0x60043A2")]
	[Address(RVA = "0xA90C00", Offset = "0xA90000", VA = "0x180A90C00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectTransferListToInventoryRequest(ExchangeObjectTransferListToInventoryRequest other)
	{
	}

	[Token(Token = "0x60043A3")]
	[Address(RVA = "0xA90740", Offset = "0xA8FB40", VA = "0x180A90740", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferListToInventoryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60043A5")]
	[Address(RVA = "0xA90800", Offset = "0xA8FC00", VA = "0x180A90800", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043A6")]
	[Address(RVA = "0xA908E0", Offset = "0xA8FCE0", VA = "0x180A908E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeObjectTransferListToInventoryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043A7")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60043A8")]
	[Address(RVA = "0xA909F0", Offset = "0xA8FDF0", VA = "0x180A909F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60043A9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60043AA")]
	[Address(RVA = "0xA90EB0", Offset = "0xA902B0", VA = "0x180A90EB0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60043AB")]
	[Address(RVA = "0xA906A0", Offset = "0xA8FAA0", VA = "0x180A906A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60043AC")]
	[Address(RVA = "0xA90970", Offset = "0xA8FD70", VA = "0x180A90970", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeObjectTransferListToInventoryRequest other)
	{
	}

	[Token(Token = "0x60043AD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60043AE")]
	[Address(RVA = "0xA90D90", Offset = "0xA90190", VA = "0x180A90D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
