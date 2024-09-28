using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002B5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockObjectRemovedEvent : IMessage<PaddockObjectRemovedEvent>, IMessage, IEquatable<PaddockObjectRemovedEvent>, IDeepCloneable<PaddockObjectRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockObjectRemovedEvent> _parser;

	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400098B")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x17000615")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddockObjectRemovedEvent> Parser
	{
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0xD09160", Offset = "0xD08560", VA = "0x180D09160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000616")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0xD090B0", Offset = "0xD084B0", VA = "0x180D090B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000617")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0xD091B0", Offset = "0xD085B0", VA = "0x180D091B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000618")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x6001C39")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001C36")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectRemovedEvent()
	{
	}

	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectRemovedEvent(PaddockObjectRemovedEvent other)
	{
	}

	[Token(Token = "0x6001C38")]
	[Address(RVA = "0xD08E40", Offset = "0xD08240", VA = "0x180D08E40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0xD08EC0", Offset = "0xD082C0", VA = "0x180D08EC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PaddockObjectRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0xD08F50", Offset = "0xD08350", VA = "0x180D08F50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001C3F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001C40")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001C41")]
	[Address(RVA = "0xD08DB0", Offset = "0xD081B0", VA = "0x180D08DB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PaddockObjectRemovedEvent other)
	{
	}

	[Token(Token = "0x6001C43")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001C44")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
