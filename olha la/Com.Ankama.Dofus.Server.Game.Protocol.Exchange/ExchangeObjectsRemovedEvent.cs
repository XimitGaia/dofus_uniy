using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000699")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectsRemovedEvent : IMessage<ExchangeObjectsRemovedEvent>, IMessage, IEquatable<ExchangeObjectsRemovedEvent>, IDeepCloneable<ExchangeObjectsRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4001714")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectsRemovedEvent> _parser;

	[Token(Token = "0x4001715")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001716")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x18")]
	private bool remote_;

	[Token(Token = "0x4001718")]
	public const int BidItemsUidFieldNumber = 2;

	[Token(Token = "0x4001719")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_bidItemsUid_codec;

	[Token(Token = "0x400171A")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> bidItemsUid_;

	[Token(Token = "0x17000F1F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectsRemovedEvent> Parser
	{
		[Token(Token = "0x60046C5")]
		[Address(RVA = "0xA94540", Offset = "0xA93940", VA = "0x180A94540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60046C6")]
		[Address(RVA = "0xA94490", Offset = "0xA93890", VA = "0x180A94490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F21")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60046C7")]
		[Address(RVA = "0xA94790", Offset = "0xA93B90", VA = "0x180A94790", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F22")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Remote
	{
		[Token(Token = "0x60046CB")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60046CC")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F23")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BidItemsUid
	{
		[Token(Token = "0x60046CD")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60046C8")]
	[Address(RVA = "0xA94410", Offset = "0xA93810", VA = "0x180A94410")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectsRemovedEvent()
	{
	}

	[Token(Token = "0x60046C9")]
	[Address(RVA = "0xA94380", Offset = "0xA93780", VA = "0x180A94380")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectsRemovedEvent(ExchangeObjectsRemovedEvent other)
	{
	}

	[Token(Token = "0x60046CA")]
	[Address(RVA = "0xA93E60", Offset = "0xA93260", VA = "0x180A93E60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectsRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60046CE")]
	[Address(RVA = "0xA93FC0", Offset = "0xA933C0", VA = "0x180A93FC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046CF")]
	[Address(RVA = "0xA93F20", Offset = "0xA93320", VA = "0x180A93F20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectsRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046D0")]
	[Address(RVA = "0xA940A0", Offset = "0xA934A0", VA = "0x180A940A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60046D1")]
	[Address(RVA = "0xA941F0", Offset = "0xA935F0", VA = "0x180A941F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60046D2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60046D3")]
	[Address(RVA = "0xA946C0", Offset = "0xA93AC0", VA = "0x180A946C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60046D4")]
	[Address(RVA = "0xA93DA0", Offset = "0xA931A0", VA = "0x180A93DA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60046D5")]
	[Address(RVA = "0xA94160", Offset = "0xA93560", VA = "0x180A94160", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectsRemovedEvent other)
	{
	}

	[Token(Token = "0x60046D6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60046D7")]
	[Address(RVA = "0xA94590", Offset = "0xA93990", VA = "0x180A94590", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
