using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006B1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeStartedWithMultiTabStorageEvent : IMessage<ExchangeStartedWithMultiTabStorageEvent>, IMessage, IEquatable<ExchangeStartedWithMultiTabStorageEvent>, IDeepCloneable<ExchangeStartedWithMultiTabStorageEvent>, IBufferMessage
{
	[Token(Token = "0x4001774")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeStartedWithMultiTabStorageEvent> _parser;

	[Token(Token = "0x4001775")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001776")]
	public const int ExchangeTypeFieldNumber = 1;

	[Token(Token = "0x4001777")]
	[FieldOffset(Offset = "0x18")]
	private ExchangeType exchangeType_;

	[Token(Token = "0x4001778")]
	public const int StorageMaxSlotFieldNumber = 2;

	[Token(Token = "0x4001779")]
	[FieldOffset(Offset = "0x1C")]
	private int storageMaxSlot_;

	[Token(Token = "0x400177A")]
	public const int TabNumberFieldNumber = 3;

	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0x20")]
	private int tabNumber_;

	[Token(Token = "0x17000F60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeStartedWithMultiTabStorageEvent> Parser
	{
		[Token(Token = "0x60047ED")]
		[Address(RVA = "0xAABE90", Offset = "0xAAB290", VA = "0x180AABE90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F61")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60047EE")]
		[Address(RVA = "0xAABDE0", Offset = "0xAAB1E0", VA = "0x180AABDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F62")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60047EF")]
		[Address(RVA = "0xAABEE0", Offset = "0xAAB2E0", VA = "0x180AABEE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F63")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeType ExchangeType
	{
		[Token(Token = "0x60047F3")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ExchangeType);
		}
		[Token(Token = "0x60047F4")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000F64")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StorageMaxSlot
	{
		[Token(Token = "0x60047F5")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60047F6")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000F65")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TabNumber
	{
		[Token(Token = "0x60047F7")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60047F8")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60047F0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedWithMultiTabStorageEvent()
	{
	}

	[Token(Token = "0x60047F1")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedWithMultiTabStorageEvent(ExchangeStartedWithMultiTabStorageEvent other)
	{
	}

	[Token(Token = "0x60047F2")]
	[Address(RVA = "0xAABB50", Offset = "0xAAAF50", VA = "0x180AABB50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedWithMultiTabStorageEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60047F9")]
	[Address(RVA = "0xAABBE0", Offset = "0xAAAFE0", VA = "0x180AABBE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60047FA")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ExchangeStartedWithMultiTabStorageEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60047FB")]
	[Address(RVA = "0x998170", Offset = "0x997570", VA = "0x180998170", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60047FC")]
	[Address(RVA = "0xAABC80", Offset = "0xAAB080", VA = "0x180AABC80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60047FD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60047FE")]
	[Address(RVA = "0x998470", Offset = "0x997870", VA = "0x180998470", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60047FF")]
	[Address(RVA = "0xAABA70", Offset = "0xAAAE70", VA = "0x180AABA70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004800")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeStartedWithMultiTabStorageEvent other)
	{
	}

	[Token(Token = "0x6004801")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004802")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
