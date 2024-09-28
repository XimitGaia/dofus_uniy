using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003C9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutBarRemovedEvent : IMessage<ShortcutBarRemovedEvent>, IMessage, IEquatable<ShortcutBarRemovedEvent>, IDeepCloneable<ShortcutBarRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4000D01")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutBarRemovedEvent> _parser;

	[Token(Token = "0x4000D02")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D03")]
	public const int BarTypeFieldNumber = 1;

	[Token(Token = "0x4000D04")]
	[FieldOffset(Offset = "0x18")]
	private ShortcutBar barType_;

	[Token(Token = "0x4000D05")]
	public const int SlotIdFieldNumber = 2;

	[Token(Token = "0x4000D06")]
	[FieldOffset(Offset = "0x1C")]
	private int slotId_;

	[Token(Token = "0x17000870")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShortcutBarRemovedEvent> Parser
	{
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x9A9C30", Offset = "0x9A9030", VA = "0x1809A9C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000871")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x9A9B80", Offset = "0x9A8F80", VA = "0x1809A9B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000872")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x9A9C80", Offset = "0x9A9080", VA = "0x1809A9C80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000873")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBar BarType
	{
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ShortcutBar);
		}
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000874")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SlotId
	{
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6002785")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarRemovedEvent()
	{
	}

	[Token(Token = "0x6002786")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBarRemovedEvent(ShortcutBarRemovedEvent other)
	{
	}

	[Token(Token = "0x6002787")]
	[Address(RVA = "0x9A9900", Offset = "0x9A8D00", VA = "0x1809A9900", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600278C")]
	[Address(RVA = "0x9A9990", Offset = "0x9A8D90", VA = "0x1809A9990", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600278D")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShortcutBarRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600278E")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600278F")]
	[Address(RVA = "0x9A9A20", Offset = "0x9A8E20", VA = "0x1809A9A20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002790")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002791")]
	[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002792")]
	[Address(RVA = "0x9A9840", Offset = "0x9A8C40", VA = "0x1809A9840", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002793")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutBarRemovedEvent other)
	{
	}

	[Token(Token = "0x6002794")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002795")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
