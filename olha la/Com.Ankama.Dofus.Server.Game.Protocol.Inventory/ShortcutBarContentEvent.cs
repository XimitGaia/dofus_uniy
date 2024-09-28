using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003C5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutBarContentEvent : IMessage<ShortcutBarContentEvent>, IMessage, IEquatable<ShortcutBarContentEvent>, IDeepCloneable<ShortcutBarContentEvent>, IBufferMessage
{
	[Token(Token = "0x4000CF2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutBarContentEvent> _parser;

	[Token(Token = "0x4000CF3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CF4")]
	public const int BarTypeFieldNumber = 1;

	[Token(Token = "0x4000CF5")]
	[FieldOffset(Offset = "0x18")]
	private ShortcutBar barType_;

	[Token(Token = "0x4000CF6")]
	public const int ShortcutsFieldNumber = 2;

	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Shortcut> _repeated_shortcuts_codec;

	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Shortcut> shortcuts_;

	[Token(Token = "0x17000866")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShortcutBarContentEvent> Parser
	{
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x996FD0", Offset = "0x9963D0", VA = "0x180996FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000867")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x996F20", Offset = "0x996320", VA = "0x180996F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000868")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002755")]
		[Address(RVA = "0x997220", Offset = "0x996620", VA = "0x180997220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000869")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBar BarType
	{
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ShortcutBar);
		}
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700086A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Shortcut> Shortcuts
	{
		[Token(Token = "0x600275B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002756")]
	[Address(RVA = "0x996EA0", Offset = "0x9962A0", VA = "0x180996EA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarContentEvent()
	{
	}

	[Token(Token = "0x6002757")]
	[Address(RVA = "0x996E10", Offset = "0x996210", VA = "0x180996E10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarContentEvent(ShortcutBarContentEvent other)
	{
	}

	[Token(Token = "0x6002758")]
	[Address(RVA = "0x996940", Offset = "0x995D40", VA = "0x180996940", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBarContentEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600275C")]
	[Address(RVA = "0x996A00", Offset = "0x995E00", VA = "0x180996A00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600275D")]
	[Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShortcutBarContentEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600275E")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600275F")]
	[Address(RVA = "0x996C10", Offset = "0x996010", VA = "0x180996C10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002760")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002761")]
	[Address(RVA = "0x997150", Offset = "0x996550", VA = "0x180997150", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002762")]
	[Address(RVA = "0x996860", Offset = "0x995C60", VA = "0x180996860", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002763")]
	[Address(RVA = "0x996B80", Offset = "0x995F80", VA = "0x180996B80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutBarContentEvent other)
	{
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002765")]
	[Address(RVA = "0x997020", Offset = "0x996420", VA = "0x180997020", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
