using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200069D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectPutInBagEvent : IMessage<ExchangeObjectPutInBagEvent>, IMessage, IEquatable<ExchangeObjectPutInBagEvent>, IDeepCloneable<ExchangeObjectPutInBagEvent>, IBufferMessage
{
	[Token(Token = "0x4001724")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectPutInBagEvent> _parser;

	[Token(Token = "0x4001725")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001726")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x4001727")]
	[FieldOffset(Offset = "0x18")]
	private bool remote_;

	[Token(Token = "0x4001728")]
	public const int ObjectFieldNumber = 2;

	[Token(Token = "0x4001729")]
	[FieldOffset(Offset = "0x20")]
	private ObjectItemInventory object_;

	[Token(Token = "0x17000F29")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectPutInBagEvent> Parser
	{
		[Token(Token = "0x60046F3")]
		[Address(RVA = "0xA8DE20", Offset = "0xA8D220", VA = "0x180A8DE20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60046F4")]
		[Address(RVA = "0xA8DD70", Offset = "0xA8D170", VA = "0x180A8DD70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60046F5")]
		[Address(RVA = "0xA8DFA0", Offset = "0xA8D3A0", VA = "0x180A8DFA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Remote
	{
		[Token(Token = "0x60046F9")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F2D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory Object
	{
		[Token(Token = "0x60046FB")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60046F6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectPutInBagEvent()
	{
	}

	[Token(Token = "0x60046F7")]
	[Address(RVA = "0xA8CFB0", Offset = "0xA8C3B0", VA = "0x180A8CFB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectPutInBagEvent(ExchangeObjectPutInBagEvent other)
	{
	}

	[Token(Token = "0x60046F8")]
	[Address(RVA = "0xA8D920", Offset = "0xA8CD20", VA = "0x180A8D920", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectPutInBagEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60046FD")]
	[Address(RVA = "0xA8D9C0", Offset = "0xA8CDC0", VA = "0x180A8D9C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046FE")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectPutInBagEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046FF")]
	[Address(RVA = "0xA8DA70", Offset = "0xA8CE70", VA = "0x180A8DA70", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004700")]
	[Address(RVA = "0xA8DC10", Offset = "0xA8D010", VA = "0x180A8DC10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004701")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004702")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004703")]
	[Address(RVA = "0xA8D880", Offset = "0xA8CC80", VA = "0x180A8D880", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004704")]
	[Address(RVA = "0xA8DB30", Offset = "0xA8CF30", VA = "0x180A8DB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeObjectPutInBagEvent other)
	{
	}

	[Token(Token = "0x6004705")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004706")]
	[Address(RVA = "0xA8DE70", Offset = "0xA8D270", VA = "0x180A8DE70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
