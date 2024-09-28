using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200065E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeCraftCountRequest : IMessage<ExchangeCraftCountRequest>, IMessage, IEquatable<ExchangeCraftCountRequest>, IDeepCloneable<ExchangeCraftCountRequest>, IBufferMessage
{
	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeCraftCountRequest> _parser;

	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001656")]
	public const int CountFieldNumber = 1;

	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0x18")]
	private int count_;

	[Token(Token = "0x17000EA1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeCraftCountRequest> Parser
	{
		[Token(Token = "0x6004445")]
		[Address(RVA = "0xA89430", Offset = "0xA88830", VA = "0x180A89430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EA2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004446")]
		[Address(RVA = "0xA89380", Offset = "0xA88780", VA = "0x180A89380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EA3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004447")]
		[Address(RVA = "0xA89480", Offset = "0xA88880", VA = "0x180A89480", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EA4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Count
	{
		[Token(Token = "0x600444B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600444C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004448")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeCraftCountRequest()
	{
	}

	[Token(Token = "0x6004449")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftCountRequest(ExchangeCraftCountRequest other)
	{
	}

	[Token(Token = "0x600444A")]
	[Address(RVA = "0xA89110", Offset = "0xA88510", VA = "0x180A89110", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeCraftCountRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600444D")]
	[Address(RVA = "0xA89190", Offset = "0xA88590", VA = "0x180A89190", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600444E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeCraftCountRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600444F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004450")]
	[Address(RVA = "0xA89220", Offset = "0xA88620", VA = "0x180A89220", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004451")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004452")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004453")]
	[Address(RVA = "0xA89080", Offset = "0xA88480", VA = "0x180A89080", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004454")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeCraftCountRequest other)
	{
	}

	[Token(Token = "0x6004455")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004456")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
