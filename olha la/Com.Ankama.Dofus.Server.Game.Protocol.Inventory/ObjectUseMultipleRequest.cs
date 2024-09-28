using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x200038E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectUseMultipleRequest : IMessage<ObjectUseMultipleRequest>, IMessage, IEquatable<ObjectUseMultipleRequest>, IDeepCloneable<ObjectUseMultipleRequest>, IBufferMessage
{
	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectUseMultipleRequest> _parser;

	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C46")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4000C48")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x170007EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectUseMultipleRequest> Parser
	{
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x992830", Offset = "0x991C30", VA = "0x180992830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x992780", Offset = "0x991B80", VA = "0x180992780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x992880", Offset = "0x991C80", VA = "0x180992880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectUid
	{
		[Token(Token = "0x60024F2")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60024EF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUseMultipleRequest()
	{
	}

	[Token(Token = "0x60024F0")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUseMultipleRequest(ObjectUseMultipleRequest other)
	{
	}

	[Token(Token = "0x60024F1")]
	[Address(RVA = "0x992500", Offset = "0x991900", VA = "0x180992500", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUseMultipleRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60024F6")]
	[Address(RVA = "0x992590", Offset = "0x991990", VA = "0x180992590", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60024F7")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectUseMultipleRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60024F8")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60024F9")]
	[Address(RVA = "0x992620", Offset = "0x991A20", VA = "0x180992620", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60024FA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60024FB")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60024FC")]
	[Address(RVA = "0x992440", Offset = "0x991840", VA = "0x180992440", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60024FD")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectUseMultipleRequest other)
	{
	}

	[Token(Token = "0x60024FE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60024FF")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
