using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B6E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakTransactionValidationEvent : IMessage<BakTransactionValidationEvent>, IMessage, IEquatable<BakTransactionValidationEvent>, IDeepCloneable<BakTransactionValidationEvent>, IBufferMessage
{
	[Token(Token = "0x2000B6F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000B70")]
		public enum BidValidation
		{
			[Token(Token = "0x4002ABD")]
			[OriginalName("BID_GENERIC_ERROR")]
			BidGenericError,
			[Token(Token = "0x4002ABE")]
			[OriginalName("BID_BUFFER_OVERLOAD")]
			BidBufferOverload,
			[Token(Token = "0x4002ABF")]
			[OriginalName("BID_OFFER_DOESNT_EXIST")]
			BidOfferDoesntExist,
			[Token(Token = "0x4002AC0")]
			[OriginalName("BID_OFFER_ALREADY_EXISTS")]
			BidOfferAlreadyExists,
			[Token(Token = "0x4002AC1")]
			[OriginalName("BID_NOT_ENOUGH_KAMAS")]
			BidNotEnoughKamas,
			[Token(Token = "0x4002AC2")]
			[OriginalName("BID_NOT_ENOUGH_OGRINES")]
			BidNotEnoughOgrines,
			[Token(Token = "0x4002AC3")]
			[OriginalName("BID_SERVER_MAINTENANCE")]
			BidServerMaintenance,
			[Token(Token = "0x4002AC4")]
			[OriginalName("BID_PLAYER_IN_DEBT")]
			BidPlayerInDebt,
			[Token(Token = "0x4002AC5")]
			[OriginalName("BID_OFFER_IS_YOURS")]
			BidOfferIsYours,
			[Token(Token = "0x4002AC6")]
			[OriginalName("BID_VALIDATION_SUCCESS")]
			Success
		}
	}

	[Token(Token = "0x4002AB6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakTransactionValidationEvent> _parser;

	[Token(Token = "0x4002AB7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002AB8")]
	public const int BidActionFieldNumber = 1;

	[Token(Token = "0x4002AB9")]
	[FieldOffset(Offset = "0x18")]
	private BidAction bidAction_;

	[Token(Token = "0x4002ABA")]
	public const int ResultFieldNumber = 2;

	[Token(Token = "0x4002ABB")]
	[FieldOffset(Offset = "0x1C")]
	private Types.BidValidation result_;

	[Token(Token = "0x17001A86")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BakTransactionValidationEvent> Parser
	{
		[Token(Token = "0x6007869")]
		[Address(RVA = "0xC205B0", Offset = "0xC1F9B0", VA = "0x180C205B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A87")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600786A")]
		[Address(RVA = "0xC20500", Offset = "0xC1F900", VA = "0x180C20500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A88")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600786B")]
		[Address(RVA = "0xC20600", Offset = "0xC1FA00", VA = "0x180C20600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A89")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BidAction BidAction
	{
		[Token(Token = "0x600786F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(BidAction);
		}
		[Token(Token = "0x6007870")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001A8A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.BidValidation Result
	{
		[Token(Token = "0x6007871")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.BidValidation);
		}
		[Token(Token = "0x6007872")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600786C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakTransactionValidationEvent()
	{
	}

	[Token(Token = "0x600786D")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakTransactionValidationEvent(BakTransactionValidationEvent other)
	{
	}

	[Token(Token = "0x600786E")]
	[Address(RVA = "0xC20280", Offset = "0xC1F680", VA = "0x180C20280", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakTransactionValidationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007873")]
	[Address(RVA = "0xC20310", Offset = "0xC1F710", VA = "0x180C20310", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007874")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BakTransactionValidationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007875")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007876")]
	[Address(RVA = "0xC203A0", Offset = "0xC1F7A0", VA = "0x180C203A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007877")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007878")]
	[Address(RVA = "0x944F10", Offset = "0x944310", VA = "0x180944F10", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007879")]
	[Address(RVA = "0xC201C0", Offset = "0xC1F5C0", VA = "0x180C201C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600787A")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakTransactionValidationEvent other)
	{
	}

	[Token(Token = "0x600787B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600787C")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
