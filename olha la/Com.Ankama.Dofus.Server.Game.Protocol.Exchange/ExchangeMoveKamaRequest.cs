using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200065C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMoveKamaRequest : IMessage<ExchangeMoveKamaRequest>, IMessage, IEquatable<ExchangeMoveKamaRequest>, IDeepCloneable<ExchangeMoveKamaRequest>, IBufferMessage
{
	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMoveKamaRequest> _parser;

	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001651")]
	public const int QuantityFieldNumber = 1;

	[Token(Token = "0x4001652")]
	[FieldOffset(Offset = "0x18")]
	private long quantity_;

	[Token(Token = "0x17000E9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMoveKamaRequest> Parser
	{
		[Token(Token = "0x600442F")]
		[Address(RVA = "0xA8BFB0", Offset = "0xA8B3B0", VA = "0x180A8BFB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E9E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004430")]
		[Address(RVA = "0xA8BF00", Offset = "0xA8B300", VA = "0x180A8BF00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E9F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004431")]
		[Address(RVA = "0xA8C000", Offset = "0xA8B400", VA = "0x180A8C000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Quantity
	{
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6004432")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMoveKamaRequest()
	{
	}

	[Token(Token = "0x6004433")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMoveKamaRequest(ExchangeMoveKamaRequest other)
	{
	}

	[Token(Token = "0x6004434")]
	[Address(RVA = "0xA8BC90", Offset = "0xA8B090", VA = "0x180A8BC90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMoveKamaRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004437")]
	[Address(RVA = "0xA8BD10", Offset = "0xA8B110", VA = "0x180A8BD10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004438")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMoveKamaRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004439")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600443A")]
	[Address(RVA = "0xA8BDA0", Offset = "0xA8B1A0", VA = "0x180A8BDA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600443B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600443C")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600443D")]
	[Address(RVA = "0xA8BC00", Offset = "0xA8B000", VA = "0x180A8BC00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600443E")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMoveKamaRequest other)
	{
	}

	[Token(Token = "0x600443F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004440")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
