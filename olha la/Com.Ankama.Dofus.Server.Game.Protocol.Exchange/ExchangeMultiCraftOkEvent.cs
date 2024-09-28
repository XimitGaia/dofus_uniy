using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006DB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMultiCraftOkEvent : IMessage<ExchangeMultiCraftOkEvent>, IMessage, IEquatable<ExchangeMultiCraftOkEvent>, IDeepCloneable<ExchangeMultiCraftOkEvent>, IBufferMessage
{
	[Token(Token = "0x4001817")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMultiCraftOkEvent> _parser;

	[Token(Token = "0x4001818")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001819")]
	public const int InitiatorIdFieldNumber = 1;

	[Token(Token = "0x400181A")]
	[FieldOffset(Offset = "0x18")]
	private long initiatorId_;

	[Token(Token = "0x400181B")]
	public const int OtherIdFieldNumber = 2;

	[Token(Token = "0x400181C")]
	[FieldOffset(Offset = "0x20")]
	private long otherId_;

	[Token(Token = "0x400181D")]
	public const int RoleFieldNumber = 3;

	[Token(Token = "0x400181E")]
	[FieldOffset(Offset = "0x28")]
	private ExchangeType role_;

	[Token(Token = "0x17000FC5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMultiCraftOkEvent> Parser
	{
		[Token(Token = "0x60049C6")]
		[Address(RVA = "0xAA8A90", Offset = "0xAA7E90", VA = "0x180AA8A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FC6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60049C7")]
		[Address(RVA = "0xAA89E0", Offset = "0xAA7DE0", VA = "0x180AA89E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FC7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60049C8")]
		[Address(RVA = "0xAA8C50", Offset = "0xAA8050", VA = "0x180AA8C50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FC8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long InitiatorId
	{
		[Token(Token = "0x60049CC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60049CD")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000FC9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long OtherId
	{
		[Token(Token = "0x60049CE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000FCA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeType Role
	{
		[Token(Token = "0x60049D0")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(ExchangeType);
		}
		[Token(Token = "0x60049D1")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x60049C9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftOkEvent()
	{
	}

	[Token(Token = "0x60049CA")]
	[Address(RVA = "0xAA8980", Offset = "0xAA7D80", VA = "0x180AA8980")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMultiCraftOkEvent(ExchangeMultiCraftOkEvent other)
	{
	}

	[Token(Token = "0x60049CB")]
	[Address(RVA = "0xAA8590", Offset = "0xAA7990", VA = "0x180AA8590", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMultiCraftOkEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60049D2")]
	[Address(RVA = "0xAA8620", Offset = "0xAA7A20", VA = "0x180AA8620", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60049D3")]
	[Address(RVA = "0xAA86C0", Offset = "0xAA7AC0", VA = "0x180AA86C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeMultiCraftOkEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60049D4")]
	[Address(RVA = "0xAA8700", Offset = "0xAA7B00", VA = "0x180AA8700", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60049D5")]
	[Address(RVA = "0xAA8820", Offset = "0xAA7C20", VA = "0x180AA8820", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60049D6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60049D7")]
	[Address(RVA = "0xAA8BB0", Offset = "0xAA7FB0", VA = "0x180AA8BB0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60049D8")]
	[Address(RVA = "0xAA84A0", Offset = "0xAA78A0", VA = "0x180AA84A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60049D9")]
	[Address(RVA = "0xAA87B0", Offset = "0xAA7BB0", VA = "0x180AA87B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMultiCraftOkEvent other)
	{
	}

	[Token(Token = "0x60049DA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60049DB")]
	[Address(RVA = "0xAA8AE0", Offset = "0xAA7EE0", VA = "0x180AA8AE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
