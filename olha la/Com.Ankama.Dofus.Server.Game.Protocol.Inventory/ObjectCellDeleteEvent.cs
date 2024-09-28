using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003A1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectCellDeleteEvent : IMessage<ObjectCellDeleteEvent>, IMessage, IEquatable<ObjectCellDeleteEvent>, IDeepCloneable<ObjectCellDeleteEvent>, IBufferMessage
{
	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectCellDeleteEvent> _parser;

	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C82")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x17000815")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectCellDeleteEvent> Parser
	{
		[Token(Token = "0x60025BB")]
		[Address(RVA = "0x98B710", Offset = "0x98AB10", VA = "0x18098B710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000816")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x98B660", Offset = "0x98AA60", VA = "0x18098B660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000817")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x98B760", Offset = "0x98AB60", VA = "0x18098B760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000818")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CellId
	{
		[Token(Token = "0x60025C1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60025C2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60025BE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectCellDeleteEvent()
	{
	}

	[Token(Token = "0x60025BF")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectCellDeleteEvent(ObjectCellDeleteEvent other)
	{
	}

	[Token(Token = "0x60025C0")]
	[Address(RVA = "0x98B3F0", Offset = "0x98A7F0", VA = "0x18098B3F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectCellDeleteEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60025C3")]
	[Address(RVA = "0x98B470", Offset = "0x98A870", VA = "0x18098B470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60025C4")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectCellDeleteEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60025C5")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60025C6")]
	[Address(RVA = "0x98B500", Offset = "0x98A900", VA = "0x18098B500", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60025C7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60025C8")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60025C9")]
	[Address(RVA = "0x98B360", Offset = "0x98A760", VA = "0x18098B360", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60025CA")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectCellDeleteEvent other)
	{
	}

	[Token(Token = "0x60025CB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60025CC")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
