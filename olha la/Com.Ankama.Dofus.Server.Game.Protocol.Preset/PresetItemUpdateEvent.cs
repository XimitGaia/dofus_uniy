using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200024F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetItemUpdateEvent : IMessage<PresetItemUpdateEvent>, IMessage, IEquatable<PresetItemUpdateEvent>, IDeepCloneable<PresetItemUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetItemUpdateEvent> _parser;

	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007D0")]
	public const int IsLinkedFieldNumber = 1;

	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x18")]
	private bool isLinked_;

	[Token(Token = "0x40007D2")]
	public const int ItemPositionByPresetUuidFieldNumber = 2;

	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly MapField<string, int>.Codec _map_itemPositionByPresetUuid_codec;

	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x20")]
	private readonly MapField<string, int> itemPositionByPresetUuid_;

	[Token(Token = "0x40007D5")]
	public const int ItemUidFieldNumber = 3;

	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x28")]
	private int itemUid_;

	[Token(Token = "0x17000503")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetItemUpdateEvent> Parser
	{
		[Token(Token = "0x6001785")]
		[Address(RVA = "0xD00EA0", Offset = "0xD002A0", VA = "0x180D00EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000504")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001786")]
		[Address(RVA = "0xD00DF0", Offset = "0xD001F0", VA = "0x180D00DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000505")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001787")]
		[Address(RVA = "0xD01130", Offset = "0xD00530", VA = "0x180D01130", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000506")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsLinked
	{
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000507")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<string, int> ItemPositionByPresetUuid
	{
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000508")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ItemUid
	{
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6001788")]
	[Address(RVA = "0xD00CD0", Offset = "0xD000D0", VA = "0x180D00CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetItemUpdateEvent()
	{
	}

	[Token(Token = "0x6001789")]
	[Address(RVA = "0xD00D50", Offset = "0xD00150", VA = "0x180D00D50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetItemUpdateEvent(PresetItemUpdateEvent other)
	{
	}

	[Token(Token = "0x600178A")]
	[Address(RVA = "0xD00700", Offset = "0xCFFB00", VA = "0x180D00700", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetItemUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001790")]
	[Address(RVA = "0xD007D0", Offset = "0xCFFBD0", VA = "0x180D007D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001791")]
	[Address(RVA = "0xD008C0", Offset = "0xCFFCC0", VA = "0x180D008C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetItemUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001792")]
	[Address(RVA = "0xD00960", Offset = "0xCFFD60", VA = "0x180D00960", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001793")]
	[Address(RVA = "0xD00AD0", Offset = "0xCFFED0", VA = "0x180D00AD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001794")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001795")]
	[Address(RVA = "0xD01040", Offset = "0xD00440", VA = "0x180D01040", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001796")]
	[Address(RVA = "0xD00610", Offset = "0xCFFA10", VA = "0x180D00610", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001797")]
	[Address(RVA = "0xD00A40", Offset = "0xCFFE40", VA = "0x180D00A40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetItemUpdateEvent other)
	{
	}

	[Token(Token = "0x6001798")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001799")]
	[Address(RVA = "0xD00EF0", Offset = "0xD002F0", VA = "0x180D00EF0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
