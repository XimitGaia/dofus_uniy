using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006AF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeStartedWithStorageEvent : IMessage<ExchangeStartedWithStorageEvent>, IMessage, IEquatable<ExchangeStartedWithStorageEvent>, IDeepCloneable<ExchangeStartedWithStorageEvent>, IBufferMessage
{
	[Token(Token = "0x400176D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeStartedWithStorageEvent> _parser;

	[Token(Token = "0x400176E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400176F")]
	public const int ExchangeTypeFieldNumber = 1;

	[Token(Token = "0x4001770")]
	[FieldOffset(Offset = "0x18")]
	private ExchangeType exchangeType_;

	[Token(Token = "0x4001771")]
	public const int StorageMaxSlotFieldNumber = 2;

	[Token(Token = "0x4001772")]
	[FieldOffset(Offset = "0x1C")]
	private int storageMaxSlot_;

	[Token(Token = "0x17000F5B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeStartedWithStorageEvent> Parser
	{
		[Token(Token = "0x60047D5")]
		[Address(RVA = "0xAACF00", Offset = "0xAAC300", VA = "0x180AACF00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F5C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60047D6")]
		[Address(RVA = "0xAACE50", Offset = "0xAAC250", VA = "0x180AACE50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F5D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60047D7")]
		[Address(RVA = "0xAACF50", Offset = "0xAAC350", VA = "0x180AACF50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F5E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeType ExchangeType
	{
		[Token(Token = "0x60047DB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ExchangeType);
		}
		[Token(Token = "0x60047DC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000F5F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StorageMaxSlot
	{
		[Token(Token = "0x60047DD")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60047DE")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60047D8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeStartedWithStorageEvent()
	{
	}

	[Token(Token = "0x60047D9")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeStartedWithStorageEvent(ExchangeStartedWithStorageEvent other)
	{
	}

	[Token(Token = "0x60047DA")]
	[Address(RVA = "0xAACBD0", Offset = "0xAABFD0", VA = "0x180AACBD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeStartedWithStorageEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60047DF")]
	[Address(RVA = "0xAACC60", Offset = "0xAAC060", VA = "0x180AACC60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60047E0")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeStartedWithStorageEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60047E1")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60047E2")]
	[Address(RVA = "0xAACCF0", Offset = "0xAAC0F0", VA = "0x180AACCF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60047E3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60047E4")]
	[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60047E5")]
	[Address(RVA = "0xAACB10", Offset = "0xAABF10", VA = "0x180AACB10", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60047E6")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeStartedWithStorageEvent other)
	{
	}

	[Token(Token = "0x60047E7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60047E8")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
