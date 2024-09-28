using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000697")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectRemovedEvent : IMessage<ExchangeObjectRemovedEvent>, IMessage, IEquatable<ExchangeObjectRemovedEvent>, IDeepCloneable<ExchangeObjectRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x400170D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectRemovedEvent> _parser;

	[Token(Token = "0x400170E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400170F")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x18")]
	private bool remote_;

	[Token(Token = "0x4001711")]
	public const int BidItemUidFieldNumber = 2;

	[Token(Token = "0x4001712")]
	[FieldOffset(Offset = "0x1C")]
	private int bidItemUid_;

	[Token(Token = "0x17000F1A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeObjectRemovedEvent> Parser
	{
		[Token(Token = "0x60046AD")]
		[Address(RVA = "0xA8E510", Offset = "0xA8D910", VA = "0x180A8E510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F1B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60046AE")]
		[Address(RVA = "0xA8E460", Offset = "0xA8D860", VA = "0x180A8E460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F1C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60046AF")]
		[Address(RVA = "0xA8E560", Offset = "0xA8D960", VA = "0x180A8E560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F1D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Remote
	{
		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F1E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BidItemUid
	{
		[Token(Token = "0x60046B5")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60046B0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectRemovedEvent()
	{
	}

	[Token(Token = "0x60046B1")]
	[Address(RVA = "0x940340", Offset = "0x93F740", VA = "0x180940340")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectRemovedEvent(ExchangeObjectRemovedEvent other)
	{
	}

	[Token(Token = "0x60046B2")]
	[Address(RVA = "0xA8E120", Offset = "0xA8D520", VA = "0x180A8E120", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60046B7")]
	[Address(RVA = "0xA8E1B0", Offset = "0xA8D5B0", VA = "0x180A8E1B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046B8")]
	[Address(RVA = "0x940080", Offset = "0x93F480", VA = "0x180940080", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60046B9")]
	[Address(RVA = "0xA8E240", Offset = "0xA8D640", VA = "0x180A8E240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60046BA")]
	[Address(RVA = "0xA8E300", Offset = "0xA8D700", VA = "0x180A8E300", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60046BB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60046BC")]
	[Address(RVA = "0xA12A80", Offset = "0xA11E80", VA = "0x180A12A80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60046BD")]
	[Address(RVA = "0xA8E080", Offset = "0xA8D480", VA = "0x180A8E080", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60046BE")]
	[Address(RVA = "0x940180", Offset = "0x93F580", VA = "0x180940180", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectRemovedEvent other)
	{
	}

	[Token(Token = "0x60046BF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60046C0")]
	[Address(RVA = "0x9404A0", Offset = "0x93F8A0", VA = "0x1809404A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
