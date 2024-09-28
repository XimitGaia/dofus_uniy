using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003C1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InventoryContentWatchEvent : IMessage<InventoryContentWatchEvent>, IMessage, IEquatable<InventoryContentWatchEvent>, IDeepCloneable<InventoryContentWatchEvent>, IBufferMessage
{
	[Token(Token = "0x4000CE3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InventoryContentWatchEvent> _parser;

	[Token(Token = "0x4000CE4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CE5")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4000CE6")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

	[Token(Token = "0x4000CE7")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectItemInventory> objects_;

	[Token(Token = "0x4000CE8")]
	public const int KamasFieldNumber = 2;

	[Token(Token = "0x4000CE9")]
	[FieldOffset(Offset = "0x20")]
	private long kamas_;

	[Token(Token = "0x1700085C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<InventoryContentWatchEvent> Parser
	{
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x9840B0", Offset = "0x9834B0", VA = "0x1809840B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x984000", Offset = "0x983400", VA = "0x180984000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x984300", Offset = "0x983700", VA = "0x180984300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectItemInventory> Objects
	{
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000860")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Kamas
	{
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6002727")]
	[Address(RVA = "0x983F80", Offset = "0x983380", VA = "0x180983F80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InventoryContentWatchEvent()
	{
	}

	[Token(Token = "0x6002728")]
	[Address(RVA = "0x983EE0", Offset = "0x9832E0", VA = "0x180983EE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InventoryContentWatchEvent(InventoryContentWatchEvent other)
	{
	}

	[Token(Token = "0x6002729")]
	[Address(RVA = "0x983A10", Offset = "0x982E10", VA = "0x180983A10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InventoryContentWatchEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600272D")]
	[Address(RVA = "0x983B70", Offset = "0x982F70", VA = "0x180983B70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600272E")]
	[Address(RVA = "0x983AD0", Offset = "0x982ED0", VA = "0x180983AD0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InventoryContentWatchEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600272F")]
	[Address(RVA = "0x983110", Offset = "0x982510", VA = "0x180983110", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002730")]
	[Address(RVA = "0x983CE0", Offset = "0x9830E0", VA = "0x180983CE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002731")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002732")]
	[Address(RVA = "0x984230", Offset = "0x983630", VA = "0x180984230", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002733")]
	[Address(RVA = "0x983930", Offset = "0x982D30", VA = "0x180983930", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002734")]
	[Address(RVA = "0x983C50", Offset = "0x983050", VA = "0x180983C50", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(InventoryContentWatchEvent other)
	{
	}

	[Token(Token = "0x6002735")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002736")]
	[Address(RVA = "0x984100", Offset = "0x983500", VA = "0x180984100", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
