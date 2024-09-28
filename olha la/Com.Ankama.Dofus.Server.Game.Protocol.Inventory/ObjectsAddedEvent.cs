using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003A9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectsAddedEvent : IMessage<ObjectsAddedEvent>, IMessage, IEquatable<ObjectsAddedEvent>, IDeepCloneable<ObjectsAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4000C99")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectsAddedEvent> _parser;

	[Token(Token = "0x4000C9A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C9B")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x4000C9D")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x17000827")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectsAddedEvent> Parser
	{
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x993FA0", Offset = "0x9933A0", VA = "0x180993FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000828")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x993EF0", Offset = "0x9932F0", VA = "0x180993EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000829")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x9941B0", Offset = "0x9935B0", VA = "0x1809941B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700082A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002619")]
	[Address(RVA = "0x993E70", Offset = "0x993270", VA = "0x180993E70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectsAddedEvent()
	{
	}

	[Token(Token = "0x600261A")]
	[Address(RVA = "0x993DE0", Offset = "0x9931E0", VA = "0x180993DE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectsAddedEvent(ObjectsAddedEvent other)
	{
	}

	[Token(Token = "0x600261B")]
	[Address(RVA = "0x993930", Offset = "0x992D30", VA = "0x180993930", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectsAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600261D")]
	[Address(RVA = "0x993A80", Offset = "0x992E80", VA = "0x180993A80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600261E")]
	[Address(RVA = "0x9939F0", Offset = "0x992DF0", VA = "0x1809939F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectsAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600261F")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002620")]
	[Address(RVA = "0x993BE0", Offset = "0x992FE0", VA = "0x180993BE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002621")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002622")]
	[Address(RVA = "0x994100", Offset = "0x993500", VA = "0x180994100", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002623")]
	[Address(RVA = "0x993890", Offset = "0x992C90", VA = "0x180993890", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002624")]
	[Address(RVA = "0x993B60", Offset = "0x992F60", VA = "0x180993B60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectsAddedEvent other)
	{
	}

	[Token(Token = "0x6002625")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002626")]
	[Address(RVA = "0x993FF0", Offset = "0x9933F0", VA = "0x180993FF0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
