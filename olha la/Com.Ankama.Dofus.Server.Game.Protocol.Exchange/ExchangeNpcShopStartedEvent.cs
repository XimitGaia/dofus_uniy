using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006D9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeNpcShopStartedEvent : IMessage<ExchangeNpcShopStartedEvent>, IMessage, IEquatable<ExchangeNpcShopStartedEvent>, IDeepCloneable<ExchangeNpcShopStartedEvent>, IBufferMessage
{
	[Token(Token = "0x400180D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeNpcShopStartedEvent> _parser;

	[Token(Token = "0x400180E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400180F")]
	public const int NpcSellerIdFieldNumber = 1;

	[Token(Token = "0x4001810")]
	[FieldOffset(Offset = "0x18")]
	private long npcSellerId_;

	[Token(Token = "0x4001811")]
	public const int TokenIdFieldNumber = 2;

	[Token(Token = "0x4001812")]
	[FieldOffset(Offset = "0x20")]
	private int tokenId_;

	[Token(Token = "0x4001813")]
	public const int ObjectsFieldNumber = 3;

	[Token(Token = "0x4001814")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ItemMinimalInformation> _repeated_objects_codec;

	[Token(Token = "0x4001815")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<ItemMinimalInformation> objects_;

	[Token(Token = "0x17000FBF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeNpcShopStartedEvent> Parser
	{
		[Token(Token = "0x60049AD")]
		[Address(RVA = "0xAA95C0", Offset = "0xAA89C0", VA = "0x180AA95C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60049AE")]
		[Address(RVA = "0xAA9510", Offset = "0xAA8910", VA = "0x180AA9510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FC1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60049AF")]
		[Address(RVA = "0xAA9860", Offset = "0xAA8C60", VA = "0x180AA9860", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000FC2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long NpcSellerId
	{
		[Token(Token = "0x60049B3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60049B4")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000FC3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TokenId
	{
		[Token(Token = "0x60049B5")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60049B6")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000FC4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemMinimalInformation> Objects
	{
		[Token(Token = "0x60049B7")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60049B0")]
	[Address(RVA = "0xAA93F0", Offset = "0xAA87F0", VA = "0x180AA93F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeNpcShopStartedEvent()
	{
	}

	[Token(Token = "0x60049B1")]
	[Address(RVA = "0xAA9470", Offset = "0xAA8870", VA = "0x180AA9470")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeNpcShopStartedEvent(ExchangeNpcShopStartedEvent other)
	{
	}

	[Token(Token = "0x60049B2")]
	[Address(RVA = "0xAA8E40", Offset = "0xAA8240", VA = "0x180AA8E40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeNpcShopStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60049B8")]
	[Address(RVA = "0xAA8F10", Offset = "0xAA8310", VA = "0x180AA8F10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60049B9")]
	[Address(RVA = "0xAA9000", Offset = "0xAA8400", VA = "0x180AA9000", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeNpcShopStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60049BA")]
	[Address(RVA = "0xAA90A0", Offset = "0xAA84A0", VA = "0x180AA90A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60049BB")]
	[Address(RVA = "0xAA91F0", Offset = "0xAA85F0", VA = "0x180AA91F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60049BC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60049BD")]
	[Address(RVA = "0xAA9760", Offset = "0xAA8B60", VA = "0x180AA9760", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60049BE")]
	[Address(RVA = "0xAA8D30", Offset = "0xAA8130", VA = "0x180AA8D30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60049BF")]
	[Address(RVA = "0xAA9150", Offset = "0xAA8550", VA = "0x180AA9150", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeNpcShopStartedEvent other)
	{
	}

	[Token(Token = "0x60049C0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60049C1")]
	[Address(RVA = "0xAA9610", Offset = "0xAA8A10", VA = "0x180AA9610", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
