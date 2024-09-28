using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000668")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMountRequest : IMessage<ExchangeMountRequest>, IMessage, IEquatable<ExchangeMountRequest>, IDeepCloneable<ExchangeMountRequest>, IBufferMessage
{
	[Token(Token = "0x400166F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMountRequest> _parser;

	[Token(Token = "0x4001670")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000EB6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMountRequest> Parser
	{
		[Token(Token = "0x60044B5")]
		[Address(RVA = "0xA8BAD0", Offset = "0xA8AED0", VA = "0x180A8BAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EB7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60044B6")]
		[Address(RVA = "0xA8BA20", Offset = "0xA8AE20", VA = "0x180A8BA20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EB8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60044B7")]
		[Address(RVA = "0xA8BB20", Offset = "0xA8AF20", VA = "0x180A8BB20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60044B8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMountRequest()
	{
	}

	[Token(Token = "0x60044B9")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountRequest(ExchangeMountRequest other)
	{
	}

	[Token(Token = "0x60044BA")]
	[Address(RVA = "0xA8B7C0", Offset = "0xA8ABC0", VA = "0x180A8B7C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60044BB")]
	[Address(RVA = "0xA8B840", Offset = "0xA8AC40", VA = "0x180A8B840", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044BC")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMountRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60044BD")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60044BE")]
	[Address(RVA = "0xA8B8C0", Offset = "0xA8ACC0", VA = "0x180A8B8C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60044BF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60044C0")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60044C1")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60044C2")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMountRequest other)
	{
	}

	[Token(Token = "0x60044C3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60044C4")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
