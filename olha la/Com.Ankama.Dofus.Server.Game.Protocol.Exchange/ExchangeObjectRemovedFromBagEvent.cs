using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200069F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectRemovedFromBagEvent : IMessage<ExchangeObjectRemovedFromBagEvent>, IMessage, IEquatable<ExchangeObjectRemovedFromBagEvent>, IDeepCloneable<ExchangeObjectRemovedFromBagEvent>, IBufferMessage
{
	[Token(Token = "0x400172B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectRemovedFromBagEvent> _parser;

	[Token(Token = "0x400172C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400172D")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x400172E")]
	[FieldOffset(Offset = "0x18")]
	private bool remote_;

	[Token(Token = "0x400172F")]
	public const int ObjectUidFieldNumber = 2;

	[Token(Token = "0x4001730")]
	[FieldOffset(Offset = "0x1C")]
	private int objectUid_;

	[Token(Token = "0x17000F2E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeObjectRemovedFromBagEvent> Parser
	{
		[Token(Token = "0x600470B")]
		[Address(RVA = "0xA8EAD0", Offset = "0xA8DED0", VA = "0x180A8EAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F2F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600470C")]
		[Address(RVA = "0xA8EA20", Offset = "0xA8DE20", VA = "0x180A8EA20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600470D")]
		[Address(RVA = "0xA8EB20", Offset = "0xA8DF20", VA = "0x180A8EB20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F31")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Remote
	{
		[Token(Token = "0x6004711")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004712")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F32")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectUid
	{
		[Token(Token = "0x6004713")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004714")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600470E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectRemovedFromBagEvent()
	{
	}

	[Token(Token = "0x600470F")]
	[Address(RVA = "0x940340", Offset = "0x93F740", VA = "0x180940340")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectRemovedFromBagEvent(ExchangeObjectRemovedFromBagEvent other)
	{
	}

	[Token(Token = "0x6004710")]
	[Address(RVA = "0xA8E6E0", Offset = "0xA8DAE0", VA = "0x180A8E6E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectRemovedFromBagEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004715")]
	[Address(RVA = "0xA8E770", Offset = "0xA8DB70", VA = "0x180A8E770", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004716")]
	[Address(RVA = "0x940080", Offset = "0x93F480", VA = "0x180940080", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectRemovedFromBagEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004717")]
	[Address(RVA = "0xA8E800", Offset = "0xA8DC00", VA = "0x180A8E800", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004718")]
	[Address(RVA = "0xA8E8C0", Offset = "0xA8DCC0", VA = "0x180A8E8C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004719")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600471A")]
	[Address(RVA = "0xA12A80", Offset = "0xA11E80", VA = "0x180A12A80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600471B")]
	[Address(RVA = "0xA8E640", Offset = "0xA8DA40", VA = "0x180A8E640", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600471C")]
	[Address(RVA = "0x940180", Offset = "0x93F580", VA = "0x180940180", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ExchangeObjectRemovedFromBagEvent other)
	{
	}

	[Token(Token = "0x600471D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600471E")]
	[Address(RVA = "0x9404A0", Offset = "0x93F8A0", VA = "0x1809404A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
