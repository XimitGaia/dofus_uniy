using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AB1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutSpell : IMessage<ShortcutSpell>, IMessage, IEquatable<ShortcutSpell>, IDeepCloneable<ShortcutSpell>, IBufferMessage
{
	[Token(Token = "0x4002722")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutSpell> _parser;

	[Token(Token = "0x4002723")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002724")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x4002725")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x17001867")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShortcutSpell> Parser
	{
		[Token(Token = "0x6006FE6")]
		[Address(RVA = "0xBEB400", Offset = "0xBEA800", VA = "0x180BEB400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001868")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006FE7")]
		[Address(RVA = "0xBEB350", Offset = "0xBEA750", VA = "0x180BEB350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001869")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006FE8")]
		[Address(RVA = "0xBEB450", Offset = "0xBEA850", VA = "0x180BEB450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700186A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpellId
	{
		[Token(Token = "0x6006FEC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006FED")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6006FE9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutSpell()
	{
	}

	[Token(Token = "0x6006FEA")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutSpell(ShortcutSpell other)
	{
	}

	[Token(Token = "0x6006FEB")]
	[Address(RVA = "0xBEB0E0", Offset = "0xBEA4E0", VA = "0x180BEB0E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutSpell Clone()
	{
		return null;
	}

	[Token(Token = "0x6006FEE")]
	[Address(RVA = "0xBEB160", Offset = "0xBEA560", VA = "0x180BEB160", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FEF")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShortcutSpell other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FF0")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006FF1")]
	[Address(RVA = "0xBEB1F0", Offset = "0xBEA5F0", VA = "0x180BEB1F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006FF2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006FF3")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006FF4")]
	[Address(RVA = "0xBEB050", Offset = "0xBEA450", VA = "0x180BEB050", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006FF5")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutSpell other)
	{
	}

	[Token(Token = "0x6006FF6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006FF7")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
