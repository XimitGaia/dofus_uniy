using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002AD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockRemoveItemRequest : IMessage<PaddockRemoveItemRequest>, IMessage, IEquatable<PaddockRemoveItemRequest>, IDeepCloneable<PaddockRemoveItemRequest>, IBufferMessage
{
	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockRemoveItemRequest> _parser;

	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400096D")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x17000600")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddockRemoveItemRequest> Parser
	{
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0xD0C400", Offset = "0xD0B800", VA = "0x180D0C400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000601")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0xD0C350", Offset = "0xD0B750", VA = "0x180D0C350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000602")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0xD0C450", Offset = "0xD0B850", VA = "0x180D0C450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000603")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockRemoveItemRequest()
	{
	}

	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockRemoveItemRequest(PaddockRemoveItemRequest other)
	{
	}

	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0xD0C0E0", Offset = "0xD0B4E0", VA = "0x180D0C0E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockRemoveItemRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0xD0C160", Offset = "0xD0B560", VA = "0x180D0C160", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddockRemoveItemRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BDB")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001BDC")]
	[Address(RVA = "0xD0C1F0", Offset = "0xD0B5F0", VA = "0x180D0C1F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001BDF")]
	[Address(RVA = "0xD0C050", Offset = "0xD0B450", VA = "0x180D0C050", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PaddockRemoveItemRequest other)
	{
	}

	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
