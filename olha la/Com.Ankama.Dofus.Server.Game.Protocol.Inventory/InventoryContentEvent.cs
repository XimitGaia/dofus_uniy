using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003BF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InventoryContentEvent : IMessage<InventoryContentEvent>, IMessage, IEquatable<InventoryContentEvent>, IDeepCloneable<InventoryContentEvent>, IBufferMessage
{
	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InventoryContentEvent> _parser;

	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CDD")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x4000CE0")]
	public const int KamasFieldNumber = 2;

	[Token(Token = "0x4000CE1")]
	[FieldOffset(Offset = "0x20")]
	private long kamas_;

	[Token(Token = "0x17000857")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<InventoryContentEvent> Parser
	{
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x983600", Offset = "0x982A00", VA = "0x180983600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000858")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x983550", Offset = "0x982950", VA = "0x180983550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000859")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x983850", Offset = "0x982C50", VA = "0x180983850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Kamas
	{
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6002710")]
	[Address(RVA = "0x9834D0", Offset = "0x9828D0", VA = "0x1809834D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InventoryContentEvent()
	{
	}

	[Token(Token = "0x6002711")]
	[Address(RVA = "0x983430", Offset = "0x982830", VA = "0x180983430")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InventoryContentEvent(InventoryContentEvent other)
	{
	}

	[Token(Token = "0x6002712")]
	[Address(RVA = "0x982ED0", Offset = "0x9822D0", VA = "0x180982ED0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InventoryContentEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002716")]
	[Address(RVA = "0x983030", Offset = "0x982430", VA = "0x180983030", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002717")]
	[Address(RVA = "0x982F90", Offset = "0x982390", VA = "0x180982F90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InventoryContentEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002718")]
	[Address(RVA = "0x983110", Offset = "0x982510", VA = "0x180983110", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002719")]
	[Address(RVA = "0x983230", Offset = "0x982630", VA = "0x180983230", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600271A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600271B")]
	[Address(RVA = "0x983780", Offset = "0x982B80", VA = "0x180983780", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600271C")]
	[Address(RVA = "0x982DF0", Offset = "0x9821F0", VA = "0x180982DF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600271D")]
	[Address(RVA = "0x9831A0", Offset = "0x9825A0", VA = "0x1809831A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(InventoryContentEvent other)
	{
	}

	[Token(Token = "0x600271E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600271F")]
	[Address(RVA = "0x983650", Offset = "0x982A50", VA = "0x180983650", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
