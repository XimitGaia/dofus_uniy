using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003AD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectErrorEvent : IMessage<ObjectErrorEvent>, IMessage, IEquatable<ObjectErrorEvent>, IDeepCloneable<ObjectErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4000CA4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectErrorEvent> _parser;

	[Token(Token = "0x4000CA5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CA6")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0x18")]
	private ObjectError reason_;

	[Token(Token = "0x1700082F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectErrorEvent> Parser
	{
		[Token(Token = "0x6002641")]
		[Address(RVA = "0x98E020", Offset = "0x98D420", VA = "0x18098E020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002642")]
		[Address(RVA = "0x98DF70", Offset = "0x98D370", VA = "0x18098DF70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000831")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002643")]
		[Address(RVA = "0x98E070", Offset = "0x98D470", VA = "0x18098E070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000832")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectError Reason
	{
		[Token(Token = "0x6002647")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ObjectError);
		}
		[Token(Token = "0x6002648")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6002644")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectErrorEvent()
	{
	}

	[Token(Token = "0x6002645")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectErrorEvent(ObjectErrorEvent other)
	{
	}

	[Token(Token = "0x6002646")]
	[Address(RVA = "0x98DD00", Offset = "0x98D100", VA = "0x18098DD00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002649")]
	[Address(RVA = "0x98DD80", Offset = "0x98D180", VA = "0x18098DD80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600264A")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600264B")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600264C")]
	[Address(RVA = "0x98DE10", Offset = "0x98D210", VA = "0x18098DE10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600264D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600264E")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600264F")]
	[Address(RVA = "0x98DC70", Offset = "0x98D070", VA = "0x18098DC70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002650")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectErrorEvent other)
	{
	}

	[Token(Token = "0x6002651")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002652")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
