using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B72")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakBuyValidationEvent : IMessage<BakBuyValidationEvent>, IMessage, IEquatable<BakBuyValidationEvent>, IDeepCloneable<BakBuyValidationEvent>, IBufferMessage
{
	[Token(Token = "0x4002AC8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakBuyValidationEvent> _parser;

	[Token(Token = "0x4002AC9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002ACA")]
	public const int TransactionValidationFieldNumber = 1;

	[Token(Token = "0x4002ACB")]
	[FieldOffset(Offset = "0x18")]
	private BakTransactionValidationEvent transactionValidation_;

	[Token(Token = "0x4002ACC")]
	public const int AmountFieldNumber = 2;

	[Token(Token = "0x4002ACD")]
	[FieldOffset(Offset = "0x20")]
	private long amount_;

	[Token(Token = "0x4002ACE")]
	public const int EmailFieldNumber = 3;

	[Token(Token = "0x4002ACF")]
	[FieldOffset(Offset = "0x28")]
	private string email_;

	[Token(Token = "0x17001A8B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BakBuyValidationEvent> Parser
	{
		[Token(Token = "0x6007881")]
		[Address(RVA = "0xC1CE00", Offset = "0xC1C200", VA = "0x180C1CE00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A8C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007882")]
		[Address(RVA = "0xC1CD50", Offset = "0xC1C150", VA = "0x180C1CD50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A8D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007883")]
		[Address(RVA = "0xC1D050", Offset = "0xC1C450", VA = "0x180C1D050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A8E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BakTransactionValidationEvent TransactionValidation
	{
		[Token(Token = "0x6007887")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007888")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A8F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Amount
	{
		[Token(Token = "0x6007889")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600788A")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Email
	{
		[Token(Token = "0x600788B")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600788C")]
		[Address(RVA = "0xC1D130", Offset = "0xC1C530", VA = "0x180C1D130")]
		set
		{
		}
	}

	[Token(Token = "0x6007884")]
	[Address(RVA = "0xC1CD00", Offset = "0xC1C100", VA = "0x180C1CD00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakBuyValidationEvent()
	{
	}

	[Token(Token = "0x6007885")]
	[Address(RVA = "0xC1CBC0", Offset = "0xC1BFC0", VA = "0x180C1CBC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakBuyValidationEvent(BakBuyValidationEvent other)
	{
	}

	[Token(Token = "0x6007886")]
	[Address(RVA = "0xC1C5C0", Offset = "0xC1B9C0", VA = "0x180C1C5C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakBuyValidationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600788D")]
	[Address(RVA = "0xC1C730", Offset = "0xC1BB30", VA = "0x180C1C730", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600788E")]
	[Address(RVA = "0xC1C800", Offset = "0xC1BC00", VA = "0x180C1C800", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BakBuyValidationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600788F")]
	[Address(RVA = "0xC1C880", Offset = "0xC1BC80", VA = "0x180C1C880", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007890")]
	[Address(RVA = "0xC1CA60", Offset = "0xC1BE60", VA = "0x180C1CA60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007891")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007892")]
	[Address(RVA = "0xC1CFA0", Offset = "0xC1C3A0", VA = "0x180C1CFA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007893")]
	[Address(RVA = "0xC1C4D0", Offset = "0xC1B8D0", VA = "0x180C1C4D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007894")]
	[Address(RVA = "0xC1C930", Offset = "0xC1BD30", VA = "0x180C1C930", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakBuyValidationEvent other)
	{
	}

	[Token(Token = "0x6007895")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007896")]
	[Address(RVA = "0xC1CE50", Offset = "0xC1C250", VA = "0x180C1CE50", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
