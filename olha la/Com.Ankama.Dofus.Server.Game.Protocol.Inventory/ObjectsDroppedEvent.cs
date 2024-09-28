using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x200039F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectsDroppedEvent : IMessage<ObjectsDroppedEvent>, IMessage, IEquatable<ObjectsDroppedEvent>, IDeepCloneable<ObjectsDroppedEvent>, IBufferMessage
{
	[Token(Token = "0x4000C7A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectsDroppedEvent> _parser;

	[Token(Token = "0x4000C7B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C7C")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000C7D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectInRolePlay> _repeated_object_codec;

	[Token(Token = "0x4000C7E")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectInRolePlay> object_;

	[Token(Token = "0x17000811")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectsDroppedEvent> Parser
	{
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x995340", Offset = "0x994740", VA = "0x180995340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000812")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x995290", Offset = "0x994690", VA = "0x180995290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000813")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x995550", Offset = "0x994950", VA = "0x180995550", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000814")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectInRolePlay> Object
	{
		[Token(Token = "0x60025AC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x995210", Offset = "0x994610", VA = "0x180995210")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectsDroppedEvent()
	{
	}

	[Token(Token = "0x60025AA")]
	[Address(RVA = "0x995180", Offset = "0x994580", VA = "0x180995180")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectsDroppedEvent(ObjectsDroppedEvent other)
	{
	}

	[Token(Token = "0x60025AB")]
	[Address(RVA = "0x994CD0", Offset = "0x9940D0", VA = "0x180994CD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectsDroppedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60025AD")]
	[Address(RVA = "0x994D90", Offset = "0x994190", VA = "0x180994D90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60025AE")]
	[Address(RVA = "0x994E70", Offset = "0x994270", VA = "0x180994E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectsDroppedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60025AF")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60025B0")]
	[Address(RVA = "0x994F80", Offset = "0x994380", VA = "0x180994F80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60025B1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60025B2")]
	[Address(RVA = "0x9954A0", Offset = "0x9948A0", VA = "0x1809954A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60025B3")]
	[Address(RVA = "0x994C30", Offset = "0x994030", VA = "0x180994C30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60025B4")]
	[Address(RVA = "0x994F00", Offset = "0x994300", VA = "0x180994F00", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectsDroppedEvent other)
	{
	}

	[Token(Token = "0x60025B5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60025B6")]
	[Address(RVA = "0x995390", Offset = "0x994790", VA = "0x180995390", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
