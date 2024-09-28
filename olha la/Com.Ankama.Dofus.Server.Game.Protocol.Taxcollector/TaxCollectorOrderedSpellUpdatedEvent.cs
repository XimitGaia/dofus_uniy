using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000C0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorOrderedSpellUpdatedEvent : IMessage<TaxCollectorOrderedSpellUpdatedEvent>, IMessage, IEquatable<TaxCollectorOrderedSpellUpdatedEvent>, IDeepCloneable<TaxCollectorOrderedSpellUpdatedEvent>, IBufferMessage
{
	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorOrderedSpellUpdatedEvent> _parser;

	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400029F")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x40002A1")]
	public const int SpellsFieldNumber = 2;

	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TaxCollectorOrderedSpell> _repeated_spells_codec;

	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<TaxCollectorOrderedSpell> spells_;

	[Token(Token = "0x17000192")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorOrderedSpellUpdatedEvent> Parser
	{
		[Token(Token = "0x6000750")]
		[Address(RVA = "0xA689B0", Offset = "0xA67DB0", VA = "0x180A689B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000193")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0xA68900", Offset = "0xA67D00", VA = "0x180A68900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000194")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000752")]
		[Address(RVA = "0xA68C30", Offset = "0xA68030", VA = "0x180A68C30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000195")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TaxCollectorUid
	{
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000757")]
		[Address(RVA = "0xA68D10", Offset = "0xA68110", VA = "0x180A68D10")]
		set
		{
		}
	}

	[Token(Token = "0x17000196")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TaxCollectorOrderedSpell> Spells
	{
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0xA68860", Offset = "0xA67C60", VA = "0x180A68860")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpellUpdatedEvent()
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0xA687C0", Offset = "0xA67BC0", VA = "0x180A687C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpellUpdatedEvent(TaxCollectorOrderedSpellUpdatedEvent other)
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0xA68220", Offset = "0xA67620", VA = "0x180A68220", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorOrderedSpellUpdatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0xA682F0", Offset = "0xA676F0", VA = "0x180A682F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0xA683E0", Offset = "0xA677E0", VA = "0x180A683E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorOrderedSpellUpdatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0xA68490", Offset = "0xA67890", VA = "0x180A68490", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0xA685C0", Offset = "0xA679C0", VA = "0x180A685C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0xA68B50", Offset = "0xA67F50", VA = "0x180A68B50", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0xA68130", Offset = "0xA67530", VA = "0x180A68130", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0xA68520", Offset = "0xA67920", VA = "0x180A68520", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TaxCollectorOrderedSpellUpdatedEvent other)
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0xA68A00", Offset = "0xA67E00", VA = "0x180A68A00", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
