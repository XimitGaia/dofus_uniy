using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000664")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangePlayerRequest : IMessage<ExchangePlayerRequest>, IMessage, IEquatable<ExchangePlayerRequest>, IDeepCloneable<ExchangePlayerRequest>, IBufferMessage
{
	[Token(Token = "0x4001661")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangePlayerRequest> _parser;

	[Token(Token = "0x4001662")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001663")]
	public const int TargetIdFieldNumber = 1;

	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0x18")]
	private long targetId_;

	[Token(Token = "0x17000EAC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ExchangePlayerRequest> Parser
	{
		[Token(Token = "0x6004485")]
		[Address(RVA = "0xA95B70", Offset = "0xA94F70", VA = "0x180A95B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EAD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004486")]
		[Address(RVA = "0xA95AC0", Offset = "0xA94EC0", VA = "0x180A95AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EAE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004487")]
		[Address(RVA = "0xA95BC0", Offset = "0xA94FC0", VA = "0x180A95BC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EAF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetId
	{
		[Token(Token = "0x600448B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600448C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6004488")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangePlayerRequest()
	{
	}

	[Token(Token = "0x6004489")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangePlayerRequest(ExchangePlayerRequest other)
	{
	}

	[Token(Token = "0x600448A")]
	[Address(RVA = "0xA95850", Offset = "0xA94C50", VA = "0x180A95850", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangePlayerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600448D")]
	[Address(RVA = "0xA958D0", Offset = "0xA94CD0", VA = "0x180A958D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600448E")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangePlayerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600448F")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004490")]
	[Address(RVA = "0xA95960", Offset = "0xA94D60", VA = "0x180A95960", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004491")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004492")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004493")]
	[Address(RVA = "0xA957C0", Offset = "0xA94BC0", VA = "0x180A957C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004494")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangePlayerRequest other)
	{
	}

	[Token(Token = "0x6004495")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004496")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
