using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003AF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectDeletedEvent : IMessage<ObjectDeletedEvent>, IMessage, IEquatable<ObjectDeletedEvent>, IDeepCloneable<ObjectDeletedEvent>, IBufferMessage
{
	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectDeletedEvent> _parser;

	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CAB")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x17000833")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectDeletedEvent> Parser
	{
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x98CCF0", Offset = "0x98C0F0", VA = "0x18098CCF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000834")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x98CC40", Offset = "0x98C040", VA = "0x18098CC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000835")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x98CD40", Offset = "0x98C140", VA = "0x18098CD40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000836")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x600265D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600265E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600265A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectDeletedEvent()
	{
	}

	[Token(Token = "0x600265B")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectDeletedEvent(ObjectDeletedEvent other)
	{
	}

	[Token(Token = "0x600265C")]
	[Address(RVA = "0x98C9D0", Offset = "0x98BDD0", VA = "0x18098C9D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectDeletedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600265F")]
	[Address(RVA = "0x98CA50", Offset = "0x98BE50", VA = "0x18098CA50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002660")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectDeletedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002661")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002662")]
	[Address(RVA = "0x98CAE0", Offset = "0x98BEE0", VA = "0x18098CAE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002663")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002664")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002665")]
	[Address(RVA = "0x98C940", Offset = "0x98BD40", VA = "0x18098C940", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002666")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectDeletedEvent other)
	{
	}

	[Token(Token = "0x6002667")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002668")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
