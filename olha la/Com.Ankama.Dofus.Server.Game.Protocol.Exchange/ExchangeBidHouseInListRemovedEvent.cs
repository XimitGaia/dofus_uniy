using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006C1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeBidHouseInListRemovedEvent : IMessage<ExchangeBidHouseInListRemovedEvent>, IMessage, IEquatable<ExchangeBidHouseInListRemovedEvent>, IDeepCloneable<ExchangeBidHouseInListRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeBidHouseInListRemovedEvent> _parser;

	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40017BC")]
	public const int BidItemUidFieldNumber = 1;

	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0x18")]
	private int bidItemUid_;

	[Token(Token = "0x40017BE")]
	public const int ObjectGidFieldNumber = 2;

	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0x1C")]
	private int objectGid_;

	[Token(Token = "0x40017C0")]
	public const int ObjectTypeFieldNumber = 3;

	[Token(Token = "0x40017C1")]
	[FieldOffset(Offset = "0x20")]
	private int objectType_;

	[Token(Token = "0x17000F8D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeBidHouseInListRemovedEvent> Parser
	{
		[Token(Token = "0x60048B3")]
		[Address(RVA = "0xAA0C30", Offset = "0xAA0030", VA = "0x180AA0C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F8E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60048B4")]
		[Address(RVA = "0xAA0B80", Offset = "0xA9FF80", VA = "0x180AA0B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F8F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60048B5")]
		[Address(RVA = "0xAA0C80", Offset = "0xAA0080", VA = "0x180AA0C80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BidItemUid
	{
		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60048BA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000F91")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectGid
	{
		[Token(Token = "0x60048BB")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000F92")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectType
	{
		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60048BE")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60048B6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeBidHouseInListRemovedEvent()
	{
	}

	[Token(Token = "0x60048B7")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseInListRemovedEvent(ExchangeBidHouseInListRemovedEvent other)
	{
	}

	[Token(Token = "0x60048B8")]
	[Address(RVA = "0xAA08F0", Offset = "0xA9FCF0", VA = "0x180AA08F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeBidHouseInListRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60048BF")]
	[Address(RVA = "0xAA0980", Offset = "0xA9FD80", VA = "0x180AA0980", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60048C0")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeBidHouseInListRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60048C1")]
	[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60048C2")]
	[Address(RVA = "0xAA0A20", Offset = "0xA9FE20", VA = "0x180AA0A20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60048C3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60048C4")]
	[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60048C5")]
	[Address(RVA = "0xAA0810", Offset = "0xA9FC10", VA = "0x180AA0810", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60048C6")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeBidHouseInListRemovedEvent other)
	{
	}

	[Token(Token = "0x60048C7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60048C8")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
