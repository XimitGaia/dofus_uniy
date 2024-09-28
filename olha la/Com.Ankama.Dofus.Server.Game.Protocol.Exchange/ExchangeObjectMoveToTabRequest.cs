using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000646")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeObjectMoveToTabRequest : IMessage<ExchangeObjectMoveToTabRequest>, IMessage, IEquatable<ExchangeObjectMoveToTabRequest>, IDeepCloneable<ExchangeObjectMoveToTabRequest>, IBufferMessage
{
	[Token(Token = "0x4001611")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeObjectMoveToTabRequest> _parser;

	[Token(Token = "0x4001612")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001613")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4001615")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x4001617")]
	public const int TabNumberFieldNumber = 3;

	[Token(Token = "0x4001618")]
	[FieldOffset(Offset = "0x20")]
	private int tabNumber_;

	[Token(Token = "0x17000E6F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeObjectMoveToTabRequest> Parser
	{
		[Token(Token = "0x600433C")]
		[Address(RVA = "0xA6F680", Offset = "0xA6EA80", VA = "0x180A6F680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600433D")]
		[Address(RVA = "0xA6F5D0", Offset = "0xA6E9D0", VA = "0x180A6F5D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E71")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600433E")]
		[Address(RVA = "0xA6F6D0", Offset = "0xA6EAD0", VA = "0x180A6F6D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E72")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectUid
	{
		[Token(Token = "0x6004342")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E73")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Quantity
	{
		[Token(Token = "0x6004344")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004345")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000E74")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TabNumber
	{
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004347")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600433F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectMoveToTabRequest()
	{
	}

	[Token(Token = "0x6004340")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectMoveToTabRequest(ExchangeObjectMoveToTabRequest other)
	{
	}

	[Token(Token = "0x6004341")]
	[Address(RVA = "0xA6F340", Offset = "0xA6E740", VA = "0x180A6F340", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeObjectMoveToTabRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004348")]
	[Address(RVA = "0xA6F3D0", Offset = "0xA6E7D0", VA = "0x180A6F3D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004349")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeObjectMoveToTabRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600434A")]
	[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600434B")]
	[Address(RVA = "0xA6F470", Offset = "0xA6E870", VA = "0x180A6F470", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600434C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600434D")]
	[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600434E")]
	[Address(RVA = "0xA6F260", Offset = "0xA6E660", VA = "0x180A6F260", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600434F")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeObjectMoveToTabRequest other)
	{
	}

	[Token(Token = "0x6004350")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004351")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
