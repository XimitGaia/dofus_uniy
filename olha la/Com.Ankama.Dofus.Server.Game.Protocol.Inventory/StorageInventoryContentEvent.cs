using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003D1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class StorageInventoryContentEvent : IMessage<StorageInventoryContentEvent>, IMessage, IEquatable<StorageInventoryContentEvent>, IDeepCloneable<StorageInventoryContentEvent>, IBufferMessage
{
	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<StorageInventoryContentEvent> _parser;

	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D29")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4000D2A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x4000D2C")]
	public const int KamasFieldNumber = 2;

	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x20")]
	private long kamas_;

	[Token(Token = "0x17000888")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StorageInventoryContentEvent> Parser
	{
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x9ABD80", Offset = "0x9AB180", VA = "0x1809ABD80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000889")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x9ABCD0", Offset = "0x9AB0D0", VA = "0x1809ABCD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60027EA")]
		[Address(RVA = "0x9ABFD0", Offset = "0x9AB3D0", VA = "0x1809ABFD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x60027EE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Kamas
	{
		[Token(Token = "0x60027EF")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x9ABBB0", Offset = "0x9AAFB0", VA = "0x1809ABBB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageInventoryContentEvent()
	{
	}

	[Token(Token = "0x60027EC")]
	[Address(RVA = "0x9ABC30", Offset = "0x9AB030", VA = "0x1809ABC30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StorageInventoryContentEvent(StorageInventoryContentEvent other)
	{
	}

	[Token(Token = "0x60027ED")]
	[Address(RVA = "0x9AB6E0", Offset = "0x9AAAE0", VA = "0x1809AB6E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StorageInventoryContentEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60027F1")]
	[Address(RVA = "0x9AB840", Offset = "0x9AAC40", VA = "0x1809AB840", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027F2")]
	[Address(RVA = "0x9AB7A0", Offset = "0x9AABA0", VA = "0x1809AB7A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StorageInventoryContentEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027F3")]
	[Address(RVA = "0x983110", Offset = "0x982510", VA = "0x180983110", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60027F4")]
	[Address(RVA = "0x9AB9B0", Offset = "0x9AADB0", VA = "0x1809AB9B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60027F5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60027F6")]
	[Address(RVA = "0x9ABF00", Offset = "0x9AB300", VA = "0x1809ABF00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60027F7")]
	[Address(RVA = "0x9AB600", Offset = "0x9AAA00", VA = "0x1809AB600", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60027F8")]
	[Address(RVA = "0x9AB920", Offset = "0x9AAD20", VA = "0x1809AB920", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StorageInventoryContentEvent other)
	{
	}

	[Token(Token = "0x60027F9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60027FA")]
	[Address(RVA = "0x9ABDD0", Offset = "0x9AB1D0", VA = "0x1809ABDD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
