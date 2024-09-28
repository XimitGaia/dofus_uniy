using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x200038C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectUseRequest : IMessage<ObjectUseRequest>, IMessage, IEquatable<ObjectUseRequest>, IDeepCloneable<ObjectUseRequest>, IBufferMessage
{
	[Token(Token = "0x4000C3F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectUseRequest> _parser;

	[Token(Token = "0x4000C40")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C41")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x170007E7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectUseRequest> Parser
	{
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x993760", Offset = "0x992B60", VA = "0x180993760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x9936B0", Offset = "0x992AB0", VA = "0x1809936B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x9937B0", Offset = "0x992BB0", VA = "0x1809937B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60024D9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUseRequest()
	{
	}

	[Token(Token = "0x60024DA")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUseRequest(ObjectUseRequest other)
	{
	}

	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x993440", Offset = "0x992840", VA = "0x180993440", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60024DE")]
	[Address(RVA = "0x9934C0", Offset = "0x9928C0", VA = "0x1809934C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60024DF")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectUseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60024E0")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60024E1")]
	[Address(RVA = "0x993550", Offset = "0x992950", VA = "0x180993550", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60024E2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60024E3")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60024E4")]
	[Address(RVA = "0x9933B0", Offset = "0x9927B0", VA = "0x1809933B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60024E5")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectUseRequest other)
	{
	}

	[Token(Token = "0x60024E6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60024E7")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
