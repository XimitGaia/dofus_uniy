using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003B3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectQuantityEvent : IMessage<ObjectQuantityEvent>, IMessage, IEquatable<ObjectQuantityEvent>, IDeepCloneable<ObjectQuantityEvent>, IBufferMessage
{
	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectQuantityEvent> _parser;

	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CB6")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x18")]
	private ObjectUidWithQuantity object_;

	[Token(Token = "0x4000CB8")]
	public const int OriginFieldNumber = 2;

	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x20")]
	private ObjectOrigin origin_;

	[Token(Token = "0x1700083B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectQuantityEvent> Parser
	{
		[Token(Token = "0x6002682")]
		[Address(RVA = "0x991CA0", Offset = "0x9910A0", VA = "0x180991CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700083C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002683")]
		[Address(RVA = "0x991BF0", Offset = "0x990FF0", VA = "0x180991BF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700083D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x991E10", Offset = "0x991210", VA = "0x180991E10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700083E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUidWithQuantity Object
	{
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700083F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectOrigin Origin
	{
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ObjectOrigin);
		}
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6002685")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectQuantityEvent()
	{
	}

	[Token(Token = "0x6002686")]
	[Address(RVA = "0x991B70", Offset = "0x990F70", VA = "0x180991B70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectQuantityEvent(ObjectQuantityEvent other)
	{
	}

	[Token(Token = "0x6002687")]
	[Address(RVA = "0x9917E0", Offset = "0x990BE0", VA = "0x1809917E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectQuantityEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600268C")]
	[Address(RVA = "0x991890", Offset = "0x990C90", VA = "0x180991890", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600268D")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectQuantityEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600268E")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600268F")]
	[Address(RVA = "0x991A10", Offset = "0x990E10", VA = "0x180991A10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002690")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002691")]
	[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002692")]
	[Address(RVA = "0x991720", Offset = "0x990B20", VA = "0x180991720", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002693")]
	[Address(RVA = "0x991940", Offset = "0x990D40", VA = "0x180991940", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectQuantityEvent other)
	{
	}

	[Token(Token = "0x6002694")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002695")]
	[Address(RVA = "0x991CF0", Offset = "0x9910F0", VA = "0x180991CF0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
