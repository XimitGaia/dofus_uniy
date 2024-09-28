using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003B7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectModifiedEvent : IMessage<ObjectModifiedEvent>, IMessage, IEquatable<ObjectModifiedEvent>, IDeepCloneable<ObjectModifiedEvent>, IBufferMessage
{
	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectModifiedEvent> _parser;

	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CC3")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x18")]
	private ObjectItemInventory object_;

	[Token(Token = "0x17000844")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectModifiedEvent> Parser
	{
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x990FD0", Offset = "0x9903D0", VA = "0x180990FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000845")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x990F20", Offset = "0x990320", VA = "0x180990F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000846")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60026B1")]
		[Address(RVA = "0x991120", Offset = "0x990520", VA = "0x180991120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000847")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory Object
	{
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60026B2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectModifiedEvent()
	{
	}

	[Token(Token = "0x60026B3")]
	[Address(RVA = "0x990EB0", Offset = "0x9902B0", VA = "0x180990EB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectModifiedEvent(ObjectModifiedEvent other)
	{
	}

	[Token(Token = "0x60026B4")]
	[Address(RVA = "0x990B30", Offset = "0x98FF30", VA = "0x180990B30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectModifiedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60026B7")]
	[Address(RVA = "0x990BD0", Offset = "0x98FFD0", VA = "0x180990BD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026B8")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectModifiedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026B9")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60026BA")]
	[Address(RVA = "0x990D50", Offset = "0x990150", VA = "0x180990D50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60026BB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60026BC")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60026BD")]
	[Address(RVA = "0x990AA0", Offset = "0x98FEA0", VA = "0x180990AA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60026BE")]
	[Address(RVA = "0x990C80", Offset = "0x990080", VA = "0x180990C80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectModifiedEvent other)
	{
	}

	[Token(Token = "0x60026BF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60026C0")]
	[Address(RVA = "0x991020", Offset = "0x990420", VA = "0x180991020", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
