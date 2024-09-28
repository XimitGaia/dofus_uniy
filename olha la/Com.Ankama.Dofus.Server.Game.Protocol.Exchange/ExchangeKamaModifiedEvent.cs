using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x20006A3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeKamaModifiedEvent : IMessage<ExchangeKamaModifiedEvent>, IMessage, IEquatable<ExchangeKamaModifiedEvent>, IDeepCloneable<ExchangeKamaModifiedEvent>, IBufferMessage
{
	[Token(Token = "0x4001739")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeKamaModifiedEvent> _parser;

	[Token(Token = "0x400173A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400173B")]
	public const int RemoteFieldNumber = 1;

	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0x18")]
	private bool remote_;

	[Token(Token = "0x400173D")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x400173E")]
	[FieldOffset(Offset = "0x20")]
	private long quantity_;

	[Token(Token = "0x17000F38")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangeKamaModifiedEvent> Parser
	{
		[Token(Token = "0x600473B")]
		[Address(RVA = "0xA8B1B0", Offset = "0xA8A5B0", VA = "0x180A8B1B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F39")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600473C")]
		[Address(RVA = "0xA8B100", Offset = "0xA8A500", VA = "0x180A8B100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600473D")]
		[Address(RVA = "0xA8B200", Offset = "0xA8A600", VA = "0x180A8B200", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Remote
	{
		[Token(Token = "0x6004741")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004742")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F3C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Quantity
	{
		[Token(Token = "0x6004743")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004744")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600473E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeKamaModifiedEvent()
	{
	}

	[Token(Token = "0x600473F")]
	[Address(RVA = "0x9D42F0", Offset = "0x9D36F0", VA = "0x1809D42F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeKamaModifiedEvent(ExchangeKamaModifiedEvent other)
	{
	}

	[Token(Token = "0x6004740")]
	[Address(RVA = "0xA8ADA0", Offset = "0xA8A1A0", VA = "0x180A8ADA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeKamaModifiedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004745")]
	[Address(RVA = "0xA8AE30", Offset = "0xA8A230", VA = "0x180A8AE30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004746")]
	[Address(RVA = "0x9D3F80", Offset = "0x9D3380", VA = "0x1809D3F80", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeKamaModifiedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004747")]
	[Address(RVA = "0xA8AED0", Offset = "0xA8A2D0", VA = "0x180A8AED0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004748")]
	[Address(RVA = "0xA8AFA0", Offset = "0xA8A3A0", VA = "0x180A8AFA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004749")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600474A")]
	[Address(RVA = "0x9D4510", Offset = "0x9D3910", VA = "0x1809D4510", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600474B")]
	[Address(RVA = "0xA8AD00", Offset = "0xA8A100", VA = "0x180A8AD00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600474C")]
	[Address(RVA = "0x9D4130", Offset = "0x9D3530", VA = "0x1809D4130", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeKamaModifiedEvent other)
	{
	}

	[Token(Token = "0x600474D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600474E")]
	[Address(RVA = "0x9D4450", Offset = "0x9D3850", VA = "0x1809D4450", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
