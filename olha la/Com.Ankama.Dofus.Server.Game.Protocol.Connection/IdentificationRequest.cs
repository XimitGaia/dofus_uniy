using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection;

[Token(Token = "0x2000811")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdentificationRequest : IMessage<IdentificationRequest>, IMessage, IEquatable<IdentificationRequest>, IDeepCloneable<IdentificationRequest>, IBufferMessage
{
	[Token(Token = "0x4001BEA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<IdentificationRequest> _parser;

	[Token(Token = "0x4001BEB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001BEC")]
	public const int TicketKeyFieldNumber = 1;

	[Token(Token = "0x4001BED")]
	[FieldOffset(Offset = "0x18")]
	private string ticketKey_;

	[Token(Token = "0x4001BEE")]
	public const int LanguageCodeFieldNumber = 2;

	[Token(Token = "0x4001BEF")]
	[FieldOffset(Offset = "0x20")]
	private string languageCode_;

	[Token(Token = "0x17001242")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<IdentificationRequest> Parser
	{
		[Token(Token = "0x60055AB")]
		[Address(RVA = "0xB0D080", Offset = "0xB0C480", VA = "0x180B0D080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001243")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60055AC")]
		[Address(RVA = "0xB0CFD0", Offset = "0xB0C3D0", VA = "0x180B0CFD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001244")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60055AD")]
		[Address(RVA = "0xB0D1C0", Offset = "0xB0C5C0", VA = "0x180B0D1C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001245")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TicketKey
	{
		[Token(Token = "0x60055B1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60055B2")]
		[Address(RVA = "0xB0D310", Offset = "0xB0C710", VA = "0x180B0D310")]
		set
		{
		}
	}

	[Token(Token = "0x17001246")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LanguageCode
	{
		[Token(Token = "0x60055B3")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60055B4")]
		[Address(RVA = "0xB0D2A0", Offset = "0xB0C6A0", VA = "0x180B0D2A0")]
		set
		{
		}
	}

	[Token(Token = "0x60055AE")]
	[Address(RVA = "0xB0CF60", Offset = "0xB0C360", VA = "0x180B0CF60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public IdentificationRequest()
	{
	}

	[Token(Token = "0x60055AF")]
	[Address(RVA = "0xB0CE80", Offset = "0xB0C280", VA = "0x180B0CE80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdentificationRequest(IdentificationRequest other)
	{
	}

	[Token(Token = "0x60055B0")]
	[Address(RVA = "0xB0CAE0", Offset = "0xB0BEE0", VA = "0x180B0CAE0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public IdentificationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60055B5")]
	[Address(RVA = "0xB0CBE0", Offset = "0xB0BFE0", VA = "0x180B0CBE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60055B6")]
	[Address(RVA = "0x931D60", Offset = "0x931160", VA = "0x180931D60", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(IdentificationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60055B7")]
	[Address(RVA = "0x931DE0", Offset = "0x9311E0", VA = "0x180931DE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60055B8")]
	[Address(RVA = "0xB0CD20", Offset = "0xB0C120", VA = "0x180B0CD20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60055B9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60055BA")]
	[Address(RVA = "0x932390", Offset = "0x931790", VA = "0x180932390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60055BB")]
	[Address(RVA = "0xB0CA20", Offset = "0xB0BE20", VA = "0x180B0CA20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60055BC")]
	[Address(RVA = "0xB0CCA0", Offset = "0xB0C0A0", VA = "0x180B0CCA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(IdentificationRequest other)
	{
	}

	[Token(Token = "0x60055BD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60055BE")]
	[Address(RVA = "0xB0D0D0", Offset = "0xB0C4D0", VA = "0x180B0D0D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
