using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003B5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectsQuantityEvent : IMessage<ObjectsQuantityEvent>, IMessage, IEquatable<ObjectsQuantityEvent>, IDeepCloneable<ObjectsQuantityEvent>, IBufferMessage
{
	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectsQuantityEvent> _parser;

	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CBD")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectUidWithQuantity> _repeated_object_codec;

	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectUidWithQuantity> object_;

	[Token(Token = "0x17000840")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectsQuantityEvent> Parser
	{
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x995D40", Offset = "0x995140", VA = "0x180995D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000841")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x995C90", Offset = "0x995090", VA = "0x180995C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000842")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x995F50", Offset = "0x995350", VA = "0x180995F50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000843")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectUidWithQuantity> Object
	{
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600269D")]
	[Address(RVA = "0x995B80", Offset = "0x994F80", VA = "0x180995B80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectsQuantityEvent()
	{
	}

	[Token(Token = "0x600269E")]
	[Address(RVA = "0x995C00", Offset = "0x995000", VA = "0x180995C00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectsQuantityEvent(ObjectsQuantityEvent other)
	{
	}

	[Token(Token = "0x600269F")]
	[Address(RVA = "0x9956D0", Offset = "0x994AD0", VA = "0x1809956D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectsQuantityEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60026A1")]
	[Address(RVA = "0x995790", Offset = "0x994B90", VA = "0x180995790", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026A2")]
	[Address(RVA = "0x995870", Offset = "0x994C70", VA = "0x180995870", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectsQuantityEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026A3")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60026A4")]
	[Address(RVA = "0x995980", Offset = "0x994D80", VA = "0x180995980", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60026A5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60026A6")]
	[Address(RVA = "0x995EA0", Offset = "0x9952A0", VA = "0x180995EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60026A7")]
	[Address(RVA = "0x995630", Offset = "0x994A30", VA = "0x180995630", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60026A8")]
	[Address(RVA = "0x995900", Offset = "0x994D00", VA = "0x180995900", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectsQuantityEvent other)
	{
	}

	[Token(Token = "0x60026A9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60026AA")]
	[Address(RVA = "0x995D90", Offset = "0x995190", VA = "0x180995D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
