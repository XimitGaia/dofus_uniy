using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x200039D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectDroppedEvent : IMessage<ObjectDroppedEvent>, IMessage, IEquatable<ObjectDroppedEvent>, IDeepCloneable<ObjectDroppedEvent>, IBufferMessage
{
	[Token(Token = "0x4000C75")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectDroppedEvent> _parser;

	[Token(Token = "0x4000C76")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C77")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000C78")]
	[FieldOffset(Offset = "0x18")]
	private ObjectInRolePlay object_;

	[Token(Token = "0x1700080D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectDroppedEvent> Parser
	{
		[Token(Token = "0x6002590")]
		[Address(RVA = "0x98DA40", Offset = "0x98CE40", VA = "0x18098DA40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700080E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002591")]
		[Address(RVA = "0x98D990", Offset = "0x98CD90", VA = "0x18098D990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700080F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002592")]
		[Address(RVA = "0x98DB90", Offset = "0x98CF90", VA = "0x18098DB90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000810")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectInRolePlay Object
	{
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002593")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectDroppedEvent()
	{
	}

	[Token(Token = "0x6002594")]
	[Address(RVA = "0x98D920", Offset = "0x98CD20", VA = "0x18098D920")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectDroppedEvent(ObjectDroppedEvent other)
	{
	}

	[Token(Token = "0x6002595")]
	[Address(RVA = "0x98D5A0", Offset = "0x98C9A0", VA = "0x18098D5A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectDroppedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002598")]
	[Address(RVA = "0x98D640", Offset = "0x98CA40", VA = "0x18098D640", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002599")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectDroppedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600259A")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600259B")]
	[Address(RVA = "0x98D7C0", Offset = "0x98CBC0", VA = "0x18098D7C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600259C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600259D")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600259E")]
	[Address(RVA = "0x98D510", Offset = "0x98C910", VA = "0x18098D510", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600259F")]
	[Address(RVA = "0x98D6F0", Offset = "0x98CAF0", VA = "0x18098D6F0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectDroppedEvent other)
	{
	}

	[Token(Token = "0x60025A0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60025A1")]
	[Address(RVA = "0x98DA90", Offset = "0x98CE90", VA = "0x18098DA90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
