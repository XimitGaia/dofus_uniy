using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000650")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectTransferListWithQuantityToInventoryRequest : IMessage<ExchangeObjectTransferListWithQuantityToInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferListWithQuantityToInventoryRequest>, IDeepCloneable<ExchangeObjectTransferListWithQuantityToInventoryRequest>, IBufferMessage
{
	[Token(Token = "0x4001635")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectTransferListWithQuantityToInventoryRequest> _parser;

	[Token(Token = "0x4001636")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001637")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4001638")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectUidWithQuantity> _repeated_objects_codec;

	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectUidWithQuantity> objects_;

	[Token(Token = "0x17000E88")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectTransferListWithQuantityToInventoryRequest> Parser
	{
		[Token(Token = "0x60043B3")]
		[Address(RVA = "0xA91750", Offset = "0xA90B50", VA = "0x180A91750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E89")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60043B4")]
		[Address(RVA = "0xA916A0", Offset = "0xA90AA0", VA = "0x180A916A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E8A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60043B5")]
		[Address(RVA = "0xA91960", Offset = "0xA90D60", VA = "0x180A91960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E8B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectUidWithQuantity> Objects
	{
		[Token(Token = "0x60043B9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60043B6")]
	[Address(RVA = "0xA91620", Offset = "0xA90A20", VA = "0x180A91620")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferListWithQuantityToInventoryRequest()
	{
	}

	[Token(Token = "0x60043B7")]
	[Address(RVA = "0xA91590", Offset = "0xA90990", VA = "0x180A91590")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferListWithQuantityToInventoryRequest(ExchangeObjectTransferListWithQuantityToInventoryRequest other)
	{
	}

	[Token(Token = "0x60043B8")]
	[Address(RVA = "0xA910E0", Offset = "0xA904E0", VA = "0x180A910E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferListWithQuantityToInventoryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60043BA")]
	[Address(RVA = "0xA911A0", Offset = "0xA905A0", VA = "0x180A911A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043BB")]
	[Address(RVA = "0xA91280", Offset = "0xA90680", VA = "0x180A91280", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectTransferListWithQuantityToInventoryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043BC")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60043BD")]
	[Address(RVA = "0xA91390", Offset = "0xA90790", VA = "0x180A91390", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60043BE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60043BF")]
	[Address(RVA = "0xA918B0", Offset = "0xA90CB0", VA = "0x180A918B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60043C0")]
	[Address(RVA = "0xA91040", Offset = "0xA90440", VA = "0x180A91040", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60043C1")]
	[Address(RVA = "0xA91310", Offset = "0xA90710", VA = "0x180A91310", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectTransferListWithQuantityToInventoryRequest other)
	{
	}

	[Token(Token = "0x60043C2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60043C3")]
	[Address(RVA = "0xA917A0", Offset = "0xA90BA0", VA = "0x180A917A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
