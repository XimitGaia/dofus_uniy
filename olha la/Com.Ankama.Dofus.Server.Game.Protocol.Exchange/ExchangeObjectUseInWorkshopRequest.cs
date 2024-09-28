using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000644")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectUseInWorkshopRequest : IMessage<ExchangeObjectUseInWorkshopRequest>, IMessage, IEquatable<ExchangeObjectUseInWorkshopRequest>, IDeepCloneable<ExchangeObjectUseInWorkshopRequest>, IBufferMessage
{
	[Token(Token = "0x400160A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectUseInWorkshopRequest> _parser;

	[Token(Token = "0x400160B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400160C")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x400160D")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x400160E")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x400160F")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x17000E6A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectUseInWorkshopRequest> Parser
	{
		[Token(Token = "0x6004324")]
		[Address(RVA = "0xA6FBA0", Offset = "0xA6EFA0", VA = "0x180A6FBA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E6B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004325")]
		[Address(RVA = "0xA6FAF0", Offset = "0xA6EEF0", VA = "0x180A6FAF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E6C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004326")]
		[Address(RVA = "0xA6FBF0", Offset = "0xA6EFF0", VA = "0x180A6FBF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E6D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x600432A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600432B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E6E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x600432C")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600432D")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6004327")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectUseInWorkshopRequest()
	{
	}

	[Token(Token = "0x6004328")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectUseInWorkshopRequest(ExchangeObjectUseInWorkshopRequest other)
	{
	}

	[Token(Token = "0x6004329")]
	[Address(RVA = "0xA6F870", Offset = "0xA6EC70", VA = "0x180A6F870", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectUseInWorkshopRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600432E")]
	[Address(RVA = "0xA6F900", Offset = "0xA6ED00", VA = "0x180A6F900", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600432F")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectUseInWorkshopRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004330")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004331")]
	[Address(RVA = "0xA6F990", Offset = "0xA6ED90", VA = "0x180A6F990", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004332")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004333")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004334")]
	[Address(RVA = "0xA6F7B0", Offset = "0xA6EBB0", VA = "0x180A6F7B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004335")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectUseInWorkshopRequest other)
	{
	}

	[Token(Token = "0x6004336")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004337")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
