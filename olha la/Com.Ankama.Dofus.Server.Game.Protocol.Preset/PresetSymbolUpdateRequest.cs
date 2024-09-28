using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200023B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetSymbolUpdateRequest : IMessage<PresetSymbolUpdateRequest>, IMessage, IEquatable<PresetSymbolUpdateRequest>, IDeepCloneable<PresetSymbolUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetSymbolUpdateRequest> _parser;

	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400078D")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x400078F")]
	public const int PresetTypeFieldNumber = 2;

	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x20")]
	private PresetType presetType_;

	[Token(Token = "0x4000791")]
	public const int SymbolIdFieldNumber = 3;

	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x24")]
	private int symbolId_;

	[Token(Token = "0x170004D2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetSymbolUpdateRequest> Parser
	{
		[Token(Token = "0x6001697")]
		[Address(RVA = "0xCE9930", Offset = "0xCE8D30", VA = "0x180CE9930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001698")]
		[Address(RVA = "0xCE9880", Offset = "0xCE8C80", VA = "0x180CE9880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001699")]
		[Address(RVA = "0xCE9B20", Offset = "0xCE8F20", VA = "0x180CE9B20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PresetUuid
	{
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600169E")]
		[Address(RVA = "0xCE9C00", Offset = "0xCE9000", VA = "0x180CE9C00")]
		set
		{
		}
	}

	[Token(Token = "0x170004D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetType PresetType
	{
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(PresetType);
		}
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170004D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SymbolId
	{
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x600169A")]
	[Address(RVA = "0xCE9830", Offset = "0xCE8C30", VA = "0x180CE9830")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSymbolUpdateRequest()
	{
	}

	[Token(Token = "0x600169B")]
	[Address(RVA = "0xCE9780", Offset = "0xCE8B80", VA = "0x180CE9780")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSymbolUpdateRequest(PresetSymbolUpdateRequest other)
	{
	}

	[Token(Token = "0x600169C")]
	[Address(RVA = "0xCE9350", Offset = "0xCE8750", VA = "0x180CE9350", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSymbolUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60016A3")]
	[Address(RVA = "0xCE9430", Offset = "0xCE8830", VA = "0x180CE9430", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x954650", Offset = "0x953A50", VA = "0x180954650", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetSymbolUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60016A5")]
	[Address(RVA = "0xCE94F0", Offset = "0xCE88F0", VA = "0x180CE94F0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60016A6")]
	[Address(RVA = "0xCE9620", Offset = "0xCE8A20", VA = "0x180CE9620", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60016A7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60016A8")]
	[Address(RVA = "0xCE9A70", Offset = "0xCE8E70", VA = "0x180CE9A70", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60016A9")]
	[Address(RVA = "0xCE9270", Offset = "0xCE8670", VA = "0x180CE9270", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60016AA")]
	[Address(RVA = "0xCE95A0", Offset = "0xCE89A0", VA = "0x180CE95A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetSymbolUpdateRequest other)
	{
	}

	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60016AC")]
	[Address(RVA = "0xCE9980", Offset = "0xCE8D80", VA = "0x180CE9980", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
