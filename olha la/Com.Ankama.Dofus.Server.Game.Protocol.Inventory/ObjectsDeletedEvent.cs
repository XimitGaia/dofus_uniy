using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003B1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectsDeletedEvent : IMessage<ObjectsDeletedEvent>, IMessage, IEquatable<ObjectsDeletedEvent>, IDeepCloneable<ObjectsDeletedEvent>, IBufferMessage
{
	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectsDeletedEvent> _parser;

	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CB0")]
	public const int ObjectsUidFieldNumber = 1;

	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_objectsUid_codec;

	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> objectsUid_;

	[Token(Token = "0x17000837")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectsDeletedEvent> Parser
	{
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x994930", Offset = "0x993D30", VA = "0x180994930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000838")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x994880", Offset = "0x993C80", VA = "0x180994880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000839")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x994B50", Offset = "0x993F50", VA = "0x180994B50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700083A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ObjectsUid
	{
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002670")]
	[Address(RVA = "0x994770", Offset = "0x993B70", VA = "0x180994770")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectsDeletedEvent()
	{
	}

	[Token(Token = "0x6002671")]
	[Address(RVA = "0x9947F0", Offset = "0x993BF0", VA = "0x1809947F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectsDeletedEvent(ObjectsDeletedEvent other)
	{
	}

	[Token(Token = "0x6002672")]
	[Address(RVA = "0x994330", Offset = "0x993730", VA = "0x180994330", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectsDeletedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002674")]
	[Address(RVA = "0x994480", Offset = "0x993880", VA = "0x180994480", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002675")]
	[Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectsDeletedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002676")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002677")]
	[Address(RVA = "0x9945E0", Offset = "0x9939E0", VA = "0x1809945E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002678")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002679")]
	[Address(RVA = "0x994AA0", Offset = "0x993EA0", VA = "0x180994AA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600267A")]
	[Address(RVA = "0x994290", Offset = "0x993690", VA = "0x180994290", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600267B")]
	[Address(RVA = "0x994560", Offset = "0x993960", VA = "0x180994560", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectsDeletedEvent other)
	{
	}

	[Token(Token = "0x600267C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600267D")]
	[Address(RVA = "0x994980", Offset = "0x993D80", VA = "0x180994980", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
