using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000A0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorPresetSpellRemoveRequest : IMessage<TaxCollectorPresetSpellRemoveRequest>, IMessage, IEquatable<TaxCollectorPresetSpellRemoveRequest>, IDeepCloneable<TaxCollectorPresetSpellRemoveRequest>, IBufferMessage
{
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorPresetSpellRemoveRequest> _parser;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000213")]
	public const int PresetUidFieldNumber = 1;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x18")]
	private string presetUid_;

	[Token(Token = "0x4000215")]
	public const int SlotIdFieldNumber = 2;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x20")]
	private int slotId_;

	[Token(Token = "0x17000141")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorPresetSpellRemoveRequest> Parser
	{
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x956FD0", Offset = "0x9563D0", VA = "0x180956FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000142")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x956F20", Offset = "0x956320", VA = "0x180956F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000143")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9570F0", Offset = "0x9564F0", VA = "0x1809570F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000144")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUid
	{
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x9571D0", Offset = "0x9565D0", VA = "0x1809571D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000145")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SlotId
	{
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x956ED0", Offset = "0x9562D0", VA = "0x180956ED0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetSpellRemoveRequest()
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x956E20", Offset = "0x956220", VA = "0x180956E20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetSpellRemoveRequest(TaxCollectorPresetSpellRemoveRequest other)
	{
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x956AD0", Offset = "0x955ED0", VA = "0x180956AD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorPresetSpellRemoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x956BA0", Offset = "0x955FA0", VA = "0x180956BA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorPresetSpellRemoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x956CC0", Offset = "0x9560C0", VA = "0x180956CC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x955630", Offset = "0x954A30", VA = "0x180955630", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x956A10", Offset = "0x955E10", VA = "0x180956A10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x956C50", Offset = "0x956050", VA = "0x180956C50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorPresetSpellRemoveRequest other)
	{
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x957020", Offset = "0x956420", VA = "0x180957020", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
