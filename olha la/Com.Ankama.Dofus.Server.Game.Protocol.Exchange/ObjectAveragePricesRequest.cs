using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x200068F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectAveragePricesRequest : IMessage<ObjectAveragePricesRequest>, IMessage, IEquatable<ObjectAveragePricesRequest>, IDeepCloneable<ObjectAveragePricesRequest>, IBufferMessage
{
	[Token(Token = "0x40016F4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectAveragePricesRequest> _parser;

	[Token(Token = "0x40016F5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000F08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectAveragePricesRequest> Parser
	{
		[Token(Token = "0x6004652")]
		[Address(RVA = "0xA996B0", Offset = "0xA98AB0", VA = "0x180A996B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F09")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004653")]
		[Address(RVA = "0xA99600", Offset = "0xA98A00", VA = "0x180A99600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F0A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004654")]
		[Address(RVA = "0xA99700", Offset = "0xA98B00", VA = "0x180A99700", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004655")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectAveragePricesRequest()
	{
	}

	[Token(Token = "0x6004656")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectAveragePricesRequest(ObjectAveragePricesRequest other)
	{
	}

	[Token(Token = "0x6004657")]
	[Address(RVA = "0xA993A0", Offset = "0xA987A0", VA = "0x180A993A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectAveragePricesRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004658")]
	[Address(RVA = "0xA99420", Offset = "0xA98820", VA = "0x180A99420", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004659")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectAveragePricesRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600465A")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600465B")]
	[Address(RVA = "0xA994A0", Offset = "0xA988A0", VA = "0x180A994A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600465C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600465D")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600465E")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600465F")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectAveragePricesRequest other)
	{
	}

	[Token(Token = "0x6004660")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004661")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
