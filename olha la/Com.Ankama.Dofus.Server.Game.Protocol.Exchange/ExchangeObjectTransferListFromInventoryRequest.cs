using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000656")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectTransferListFromInventoryRequest : IMessage<ExchangeObjectTransferListFromInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferListFromInventoryRequest>, IDeepCloneable<ExchangeObjectTransferListFromInventoryRequest>, IBufferMessage
{
	[Token(Token = "0x4001641")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectTransferListFromInventoryRequest> _parser;

	[Token(Token = "0x4001642")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001643")]
	public const int ObjectsUidFieldNumber = 1;

	[Token(Token = "0x4001644")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_objectsUid_codec;

	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> objectsUid_;

	[Token(Token = "0x17000E92")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectTransferListFromInventoryRequest> Parser
	{
		[Token(Token = "0x60043F0")]
		[Address(RVA = "0xA903A0", Offset = "0xA8F7A0", VA = "0x180A903A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E93")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60043F1")]
		[Address(RVA = "0xA902F0", Offset = "0xA8F6F0", VA = "0x180A902F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E94")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60043F2")]
		[Address(RVA = "0xA905C0", Offset = "0xA8F9C0", VA = "0x180A905C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E95")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ObjectsUid
	{
		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60043F3")]
	[Address(RVA = "0xA901E0", Offset = "0xA8F5E0", VA = "0x180A901E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferListFromInventoryRequest()
	{
	}

	[Token(Token = "0x60043F4")]
	[Address(RVA = "0xA90260", Offset = "0xA8F660", VA = "0x180A90260")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferListFromInventoryRequest(ExchangeObjectTransferListFromInventoryRequest other)
	{
	}

	[Token(Token = "0x60043F5")]
	[Address(RVA = "0xA8FDA0", Offset = "0xA8F1A0", VA = "0x180A8FDA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferListFromInventoryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60043F7")]
	[Address(RVA = "0xA8FEF0", Offset = "0xA8F2F0", VA = "0x180A8FEF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043F8")]
	[Address(RVA = "0xA8FE60", Offset = "0xA8F260", VA = "0x180A8FE60", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeObjectTransferListFromInventoryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60043F9")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60043FA")]
	[Address(RVA = "0xA90050", Offset = "0xA8F450", VA = "0x180A90050", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60043FB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60043FC")]
	[Address(RVA = "0xA90510", Offset = "0xA8F910", VA = "0x180A90510", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60043FD")]
	[Address(RVA = "0xA8FD00", Offset = "0xA8F100", VA = "0x180A8FD00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60043FE")]
	[Address(RVA = "0xA8FFD0", Offset = "0xA8F3D0", VA = "0x180A8FFD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectTransferListFromInventoryRequest other)
	{
	}

	[Token(Token = "0x60043FF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004400")]
	[Address(RVA = "0xA903F0", Offset = "0xA8F7F0", VA = "0x180A903F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
