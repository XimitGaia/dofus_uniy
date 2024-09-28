using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B6C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakTransactionValidationRequest : IMessage<BakTransactionValidationRequest>, IMessage, IEquatable<BakTransactionValidationRequest>, IDeepCloneable<BakTransactionValidationRequest>, IBufferMessage
{
	[Token(Token = "0x4002AB1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakTransactionValidationRequest> _parser;

	[Token(Token = "0x4002AB2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002AB3")]
	public const int TransactionUuidFieldNumber = 1;

	[Token(Token = "0x4002AB4")]
	[FieldOffset(Offset = "0x18")]
	private string transactionUuid_;

	[Token(Token = "0x17001A82")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BakTransactionValidationRequest> Parser
	{
		[Token(Token = "0x6007853")]
		[Address(RVA = "0xC20C50", Offset = "0xC20050", VA = "0x180C20C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A83")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007854")]
		[Address(RVA = "0xC20BA0", Offset = "0xC1FFA0", VA = "0x180C20BA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A84")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007855")]
		[Address(RVA = "0xC20D60", Offset = "0xC20160", VA = "0x180C20D60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A85")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TransactionUuid
	{
		[Token(Token = "0x6007859")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600785A")]
		[Address(RVA = "0xC20E40", Offset = "0xC20240", VA = "0x180C20E40")]
		set
		{
		}
	}

	[Token(Token = "0x6007856")]
	[Address(RVA = "0xC20AB0", Offset = "0xC1FEB0", VA = "0x180C20AB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakTransactionValidationRequest()
	{
	}

	[Token(Token = "0x6007857")]
	[Address(RVA = "0xC20B00", Offset = "0xC1FF00", VA = "0x180C20B00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakTransactionValidationRequest(BakTransactionValidationRequest other)
	{
	}

	[Token(Token = "0x6007858")]
	[Address(RVA = "0xC20770", Offset = "0xC1FB70", VA = "0x180C20770", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BakTransactionValidationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600785B")]
	[Address(RVA = "0xC20840", Offset = "0xC1FC40", VA = "0x180C20840", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600785C")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BakTransactionValidationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600785D")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600785E")]
	[Address(RVA = "0xC20950", Offset = "0xC1FD50", VA = "0x180C20950", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600785F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007860")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007861")]
	[Address(RVA = "0xC206E0", Offset = "0xC1FAE0", VA = "0x180C206E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007862")]
	[Address(RVA = "0xC208F0", Offset = "0xC1FCF0", VA = "0x180C208F0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BakTransactionValidationRequest other)
	{
	}

	[Token(Token = "0x6007863")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007864")]
	[Address(RVA = "0xC20CA0", Offset = "0xC200A0", VA = "0x180C20CA0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
