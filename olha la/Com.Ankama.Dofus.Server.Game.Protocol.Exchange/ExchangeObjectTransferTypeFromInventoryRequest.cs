using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000658")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectTransferTypeFromInventoryRequest : IMessage<ExchangeObjectTransferTypeFromInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferTypeFromInventoryRequest>, IDeepCloneable<ExchangeObjectTransferTypeFromInventoryRequest>, IBufferMessage
{
	[Token(Token = "0x4001647")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectTransferTypeFromInventoryRequest> _parser;

	[Token(Token = "0x4001648")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001649")]
	public const int ObjectTypeFieldNumber = 1;

	[Token(Token = "0x400164A")]
	[FieldOffset(Offset = "0x18")]
	private int objectType_;

	[Token(Token = "0x17000E96")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectTransferTypeFromInventoryRequest> Parser
	{
		[Token(Token = "0x6004405")]
		[Address(RVA = "0xA91DF0", Offset = "0xA911F0", VA = "0x180A91DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E97")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004406")]
		[Address(RVA = "0xA91D40", Offset = "0xA91140", VA = "0x180A91D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E98")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004407")]
		[Address(RVA = "0xA91E40", Offset = "0xA91240", VA = "0x180A91E40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E99")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectType
	{
		[Token(Token = "0x600440B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600440C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004408")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferTypeFromInventoryRequest()
	{
	}

	[Token(Token = "0x6004409")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectTransferTypeFromInventoryRequest(ExchangeObjectTransferTypeFromInventoryRequest other)
	{
	}

	[Token(Token = "0x600440A")]
	[Address(RVA = "0xA91AD0", Offset = "0xA90ED0", VA = "0x180A91AD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeObjectTransferTypeFromInventoryRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600440D")]
	[Address(RVA = "0xA91B50", Offset = "0xA90F50", VA = "0x180A91B50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600440E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectTransferTypeFromInventoryRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600440F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004410")]
	[Address(RVA = "0xA91BE0", Offset = "0xA90FE0", VA = "0x180A91BE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004411")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004412")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004413")]
	[Address(RVA = "0xA91A40", Offset = "0xA90E40", VA = "0x180A91A40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004414")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectTransferTypeFromInventoryRequest other)
	{
	}

	[Token(Token = "0x6004415")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004416")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
