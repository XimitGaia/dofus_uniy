using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006C7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeReadyEvent : IMessage<ExchangeReadyEvent>, IMessage, IEquatable<ExchangeReadyEvent>, IDeepCloneable<ExchangeReadyEvent>, IBufferMessage
{
	[Token(Token = "0x40017CF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeReadyEvent> _parser;

	[Token(Token = "0x40017D0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017D1")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x40017D2")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x40017D3")]
	public const int ReadyFieldNumber = 2;

	[Token(Token = "0x40017D4")]
	[FieldOffset(Offset = "0x20")]
	private bool ready_;

	[Token(Token = "0x17000F9B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeReadyEvent> Parser
	{
		[Token(Token = "0x60048F7")]
		[Address(RVA = "0xAAA2C0", Offset = "0xAA96C0", VA = "0x180AAA2C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F9C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60048F8")]
		[Address(RVA = "0xAAA210", Offset = "0xAA9610", VA = "0x180AAA210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60048F9")]
		[Address(RVA = "0xAAA310", Offset = "0xAA9710", VA = "0x180AAA310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F9E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x60048FD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000F9F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Ready
	{
		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004900")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x60048FA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeReadyEvent()
	{
	}

	[Token(Token = "0x60048FB")]
	[Address(RVA = "0x9D4B00", Offset = "0x9D3F00", VA = "0x1809D4B00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeReadyEvent(ExchangeReadyEvent other)
	{
	}

	[Token(Token = "0x60048FC")]
	[Address(RVA = "0xAA9EB0", Offset = "0xAA92B0", VA = "0x180AA9EB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeReadyEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004901")]
	[Address(RVA = "0xAA9F40", Offset = "0xAA9340", VA = "0x180AA9F40", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004902")]
	[Address(RVA = "0x9D4790", Offset = "0x9D3B90", VA = "0x1809D4790", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeReadyEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004903")]
	[Address(RVA = "0xAA9FE0", Offset = "0xAA93E0", VA = "0x180AA9FE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004904")]
	[Address(RVA = "0xAAA0B0", Offset = "0xAA94B0", VA = "0x180AAA0B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004905")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004906")]
	[Address(RVA = "0x9D4D20", Offset = "0x9D4120", VA = "0x1809D4D20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004907")]
	[Address(RVA = "0xAA9E20", Offset = "0xAA9220", VA = "0x180AA9E20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004908")]
	[Address(RVA = "0x9D4940", Offset = "0x9D3D40", VA = "0x1809D4940", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeReadyEvent other)
	{
	}

	[Token(Token = "0x6004909")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600490A")]
	[Address(RVA = "0x9D4C60", Offset = "0x9D4060", VA = "0x1809D4C60", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
