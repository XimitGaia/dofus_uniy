using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003D9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StorageObjectRemovedEvent : IMessage<StorageObjectRemovedEvent>, IMessage, IEquatable<StorageObjectRemovedEvent>, IDeepCloneable<StorageObjectRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StorageObjectRemovedEvent> _parser;

	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D41")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x17000899")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StorageObjectRemovedEvent> Parser
	{
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x9AC940", Offset = "0x9ABD40", VA = "0x1809AC940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002841")]
		[Address(RVA = "0x9AC890", Offset = "0x9ABC90", VA = "0x1809AC890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002842")]
		[Address(RVA = "0x9AC990", Offset = "0x9ABD90", VA = "0x1809AC990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700089C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6002843")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectRemovedEvent()
	{
	}

	[Token(Token = "0x6002844")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectRemovedEvent(StorageObjectRemovedEvent other)
	{
	}

	[Token(Token = "0x6002845")]
	[Address(RVA = "0x9AC620", Offset = "0x9ABA20", VA = "0x1809AC620", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageObjectRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002848")]
	[Address(RVA = "0x9AC6A0", Offset = "0x9ABAA0", VA = "0x1809AC6A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002849")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(StorageObjectRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600284A")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600284B")]
	[Address(RVA = "0x9AC730", Offset = "0x9ABB30", VA = "0x1809AC730", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600284C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600284D")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600284E")]
	[Address(RVA = "0x9AC590", Offset = "0x9AB990", VA = "0x1809AC590", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600284F")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(StorageObjectRemovedEvent other)
	{
	}

	[Token(Token = "0x6002850")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002851")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
