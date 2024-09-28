using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006C3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseUnsoldItemsEvent : IMessage<ExchangeBidHouseUnsoldItemsEvent>, IMessage, IEquatable<ExchangeBidHouseUnsoldItemsEvent>, IDeepCloneable<ExchangeBidHouseUnsoldItemsEvent>, IBufferMessage
{
	[Token(Token = "0x40017C3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseUnsoldItemsEvent> _parser;

	[Token(Token = "0x40017C4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017C5")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectGidWithQuantity> _repeated_objects_codec;

	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectGidWithQuantity> objects_;

	[Token(Token = "0x17000F93")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseUnsoldItemsEvent> Parser
	{
		[Token(Token = "0x60048CD")]
		[Address(RVA = "0xAA3B60", Offset = "0xAA2F60", VA = "0x180AA3B60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F94")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60048CE")]
		[Address(RVA = "0xAA3AB0", Offset = "0xAA2EB0", VA = "0x180AA3AB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F95")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60048CF")]
		[Address(RVA = "0xAA3D70", Offset = "0xAA3170", VA = "0x180AA3D70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F96")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectGidWithQuantity> Objects
	{
		[Token(Token = "0x60048D3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60048D0")]
	[Address(RVA = "0xAA3A30", Offset = "0xAA2E30", VA = "0x180AA3A30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseUnsoldItemsEvent()
	{
	}

	[Token(Token = "0x60048D1")]
	[Address(RVA = "0xAA39A0", Offset = "0xAA2DA0", VA = "0x180AA39A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseUnsoldItemsEvent(ExchangeBidHouseUnsoldItemsEvent other)
	{
	}

	[Token(Token = "0x60048D2")]
	[Address(RVA = "0xAA34F0", Offset = "0xAA28F0", VA = "0x180AA34F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseUnsoldItemsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60048D4")]
	[Address(RVA = "0xAA35B0", Offset = "0xAA29B0", VA = "0x180AA35B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60048D5")]
	[Address(RVA = "0xAA3690", Offset = "0xAA2A90", VA = "0x180AA3690", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseUnsoldItemsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60048D6")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60048D7")]
	[Address(RVA = "0xAA37A0", Offset = "0xAA2BA0", VA = "0x180AA37A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60048D8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60048D9")]
	[Address(RVA = "0xAA3CC0", Offset = "0xAA30C0", VA = "0x180AA3CC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60048DA")]
	[Address(RVA = "0xAA3450", Offset = "0xAA2850", VA = "0x180AA3450", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60048DB")]
	[Address(RVA = "0xAA3720", Offset = "0xAA2B20", VA = "0x180AA3720", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseUnsoldItemsEvent other)
	{
	}

	[Token(Token = "0x60048DC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60048DD")]
	[Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
