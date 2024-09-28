using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000918")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BidActivitiesRequest : IMessage<BidActivitiesRequest>, IMessage, IEquatable<BidActivitiesRequest>, IDeepCloneable<BidActivitiesRequest>, IBufferMessage
{
	[Token(Token = "0x4001F15")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BidActivitiesRequest> _parser;

	[Token(Token = "0x4001F16")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001458")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BidActivitiesRequest> Parser
	{
		[Token(Token = "0x600602D")]
		[Address(RVA = "0xB4B440", Offset = "0xB4A840", VA = "0x180B4B440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001459")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600602E")]
		[Address(RVA = "0xB4B390", Offset = "0xB4A790", VA = "0x180B4B390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700145A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600602F")]
		[Address(RVA = "0xB4B490", Offset = "0xB4A890", VA = "0x180B4B490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006030")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidActivitiesRequest()
	{
	}

	[Token(Token = "0x6006031")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BidActivitiesRequest(BidActivitiesRequest other)
	{
	}

	[Token(Token = "0x6006032")]
	[Address(RVA = "0xB4B130", Offset = "0xB4A530", VA = "0x180B4B130", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BidActivitiesRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6006033")]
	[Address(RVA = "0xB4B1B0", Offset = "0xB4A5B0", VA = "0x180B4B1B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006034")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BidActivitiesRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006035")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006036")]
	[Address(RVA = "0xB4B230", Offset = "0xB4A630", VA = "0x180B4B230", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006037")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006038")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006039")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600603A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BidActivitiesRequest other)
	{
	}

	[Token(Token = "0x600603B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600603C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
