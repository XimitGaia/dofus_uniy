using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000B8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorEquipmentUpdateEvent : IMessage<TaxCollectorEquipmentUpdateEvent>, IMessage, IEquatable<TaxCollectorEquipmentUpdateEvent>, IDeepCloneable<TaxCollectorEquipmentUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorEquipmentUpdateEvent> _parser;

	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400027F")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x4000281")]
	public const int ObjectFieldNumber = 2;

	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x20")]
	private ObjectItemInventory object_;

	[Token(Token = "0x4000283")]
	public const int AddedFieldNumber = 3;

	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x28")]
	private bool added_;

	[Token(Token = "0x4000285")]
	public const int CharacteristicsFieldNumber = 4;

	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<CharacterCharacteristic> _repeated_characteristics_codec;

	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<CharacterCharacteristic> characteristics_;

	[Token(Token = "0x17000183")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorEquipmentUpdateEvent> Parser
	{
		[Token(Token = "0x6000709")]
		[Address(RVA = "0xA64FF0", Offset = "0xA643F0", VA = "0x180A64FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000184")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600070A")]
		[Address(RVA = "0xA64F40", Offset = "0xA64340", VA = "0x180A64F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000185")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600070B")]
		[Address(RVA = "0xA65340", Offset = "0xA64740", VA = "0x180A65340", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000186")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TaxCollectorUid
	{
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000710")]
		[Address(RVA = "0xA65420", Offset = "0xA64820", VA = "0x180A65420")]
		set
		{
		}
	}

	[Token(Token = "0x17000187")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectItemInventory Object
	{
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17000188")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Added
	{
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x17000189")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharacterCharacteristic> Characteristics
	{
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0xA64EA0", Offset = "0xA642A0", VA = "0x180A64EA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorEquipmentUpdateEvent()
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0xA64DD0", Offset = "0xA641D0", VA = "0x180A64DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorEquipmentUpdateEvent(TaxCollectorEquipmentUpdateEvent other)
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0xA646E0", Offset = "0xA63AE0", VA = "0x180A646E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorEquipmentUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0xA647E0", Offset = "0xA63BE0", VA = "0x180A647E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0xA648F0", Offset = "0xA63CF0", VA = "0x180A648F0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorEquipmentUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0xA649B0", Offset = "0xA63DB0", VA = "0x180A649B0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0xA64BD0", Offset = "0xA63FD0", VA = "0x180A64BD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0xA65210", Offset = "0xA64610", VA = "0x180A65210", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0xA645C0", Offset = "0xA639C0", VA = "0x180A645C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0xA64AB0", Offset = "0xA63EB0", VA = "0x180A64AB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorEquipmentUpdateEvent other)
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0xA65040", Offset = "0xA64440", VA = "0x180A65040", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
