using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002A9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockSellRequest : IMessage<PaddockSellRequest>, IMessage, IEquatable<PaddockSellRequest>, IDeepCloneable<PaddockSellRequest>, IBufferMessage
{
	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockSellRequest> _parser;

	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000961")]
	public const int PriceFieldNumber = 1;

	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x18")]
	private long price_;

	[Token(Token = "0x4000963")]
	public const int ForSaleFieldNumber = 2;

	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x20")]
	private bool forSale_;

	[Token(Token = "0x170005F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddockSellRequest> Parser
	{
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0xD0C9D0", Offset = "0xD0BDD0", VA = "0x180D0C9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0xD0C920", Offset = "0xD0BD20", VA = "0x180D0C920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0xD0CA20", Offset = "0xD0BE20", VA = "0x180D0CA20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Price
	{
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170005FB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ForSale
	{
		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6001BA6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockSellRequest()
	{
	}

	[Token(Token = "0x6001BA7")]
	[Address(RVA = "0x9D4B00", Offset = "0x9D3F00", VA = "0x1809D4B00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockSellRequest(PaddockSellRequest other)
	{
	}

	[Token(Token = "0x6001BA8")]
	[Address(RVA = "0xD0C5C0", Offset = "0xD0B9C0", VA = "0x180D0C5C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockSellRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001BAD")]
	[Address(RVA = "0xD0C650", Offset = "0xD0BA50", VA = "0x180D0C650", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BAE")]
	[Address(RVA = "0x9D4790", Offset = "0x9D3B90", VA = "0x1809D4790", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PaddockSellRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BAF")]
	[Address(RVA = "0xD0C6F0", Offset = "0xD0BAF0", VA = "0x180D0C6F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001BB0")]
	[Address(RVA = "0xD0C7C0", Offset = "0xD0BBC0", VA = "0x180D0C7C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x9D4D20", Offset = "0x9D4120", VA = "0x1809D4D20", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0xD0C530", Offset = "0xD0B930", VA = "0x180D0C530", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x9D4940", Offset = "0x9D3D40", VA = "0x1809D4940", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PaddockSellRequest other)
	{
	}

	[Token(Token = "0x6001BB5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001BB6")]
	[Address(RVA = "0x9D4C60", Offset = "0x9D4060", VA = "0x1809D4C60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
