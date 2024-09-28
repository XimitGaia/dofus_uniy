using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200066E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeReadyRequest : IMessage<ExchangeReadyRequest>, IMessage, IEquatable<ExchangeReadyRequest>, IDeepCloneable<ExchangeReadyRequest>, IBufferMessage
{
	[Token(Token = "0x400167A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeReadyRequest> _parser;

	[Token(Token = "0x400167B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400167C")]
	public const int ReadyFieldNumber = 1;

	[Token(Token = "0x400167D")]
	[FieldOffset(Offset = "0x18")]
	private bool ready_;

	[Token(Token = "0x400167E")]
	public const int StepFieldNumber = 2;

	[Token(Token = "0x400167F")]
	[FieldOffset(Offset = "0x1C")]
	private int step_;

	[Token(Token = "0x17000EC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeReadyRequest> Parser
	{
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0xA96740", Offset = "0xA95B40", VA = "0x180A96740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0xA96690", Offset = "0xA95A90", VA = "0x180A96690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0xA96790", Offset = "0xA95B90", VA = "0x180A96790", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Ready
	{
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000EC4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Step
	{
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60044F6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeReadyRequest()
	{
	}

	[Token(Token = "0x60044F7")]
	[Address(RVA = "0x940340", Offset = "0x93F740", VA = "0x180940340")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeReadyRequest(ExchangeReadyRequest other)
	{
	}

	[Token(Token = "0x60044F8")]
	[Address(RVA = "0xA96350", Offset = "0xA95750", VA = "0x180A96350", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeReadyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60044FD")]
	[Address(RVA = "0xA963E0", Offset = "0xA957E0", VA = "0x180A963E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044FE")]
	[Address(RVA = "0x940080", Offset = "0x93F480", VA = "0x180940080", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeReadyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044FF")]
	[Address(RVA = "0xA96470", Offset = "0xA95870", VA = "0x180A96470", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004500")]
	[Address(RVA = "0xA96530", Offset = "0xA95930", VA = "0x180A96530", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004501")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004502")]
	[Address(RVA = "0xA12A80", Offset = "0xA11E80", VA = "0x180A12A80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004503")]
	[Address(RVA = "0xA962B0", Offset = "0xA956B0", VA = "0x180A962B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004504")]
	[Address(RVA = "0x940180", Offset = "0x93F580", VA = "0x180940180", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeReadyRequest other)
	{
	}

	[Token(Token = "0x6004505")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004506")]
	[Address(RVA = "0x9404A0", Offset = "0x93F8A0", VA = "0x1809404A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
