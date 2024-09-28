using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003CB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutBarReplacedEvent : IMessage<ShortcutBarReplacedEvent>, IMessage, IEquatable<ShortcutBarReplacedEvent>, IDeepCloneable<ShortcutBarReplacedEvent>, IBufferMessage
{
	[Token(Token = "0x4000D08")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutBarReplacedEvent> _parser;

	[Token(Token = "0x4000D09")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D0A")]
	public const int BarTypeFieldNumber = 1;

	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x18")]
	private ShortcutBar barType_;

	[Token(Token = "0x4000D0C")]
	public const int ShortcutFieldNumber = 2;

	[Token(Token = "0x4000D0D")]
	[FieldOffset(Offset = "0x20")]
	private Shortcut shortcut_;

	[Token(Token = "0x17000875")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShortcutBarReplacedEvent> Parser
	{
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x9AA250", Offset = "0x9A9650", VA = "0x1809AA250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000876")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x9AA1A0", Offset = "0x9A95A0", VA = "0x1809AA1A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000877")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600279C")]
		[Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000878")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBar BarType
	{
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ShortcutBar);
		}
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000879")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Shortcut Shortcut
	{
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600279D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBarReplacedEvent()
	{
	}

	[Token(Token = "0x600279E")]
	[Address(RVA = "0x996470", Offset = "0x995870", VA = "0x180996470")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBarReplacedEvent(ShortcutBarReplacedEvent other)
	{
	}

	[Token(Token = "0x600279F")]
	[Address(RVA = "0x9A9E20", Offset = "0x9A9220", VA = "0x1809A9E20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBarReplacedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60027A4")]
	[Address(RVA = "0x9A9EC0", Offset = "0x9A92C0", VA = "0x1809A9EC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027A5")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShortcutBarReplacedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60027A6")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60027A7")]
	[Address(RVA = "0x9AA040", Offset = "0x9A9440", VA = "0x1809AA040", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60027A8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60027A9")]
	[Address(RVA = "0x996700", Offset = "0x995B00", VA = "0x180996700", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60027AA")]
	[Address(RVA = "0x9A9D60", Offset = "0x9A9160", VA = "0x1809A9D60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60027AB")]
	[Address(RVA = "0x9A9F70", Offset = "0x9A9370", VA = "0x1809A9F70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutBarReplacedEvent other)
	{
	}

	[Token(Token = "0x60027AC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60027AD")]
	[Address(RVA = "0x9AA2A0", Offset = "0x9A96A0", VA = "0x1809AA2A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
