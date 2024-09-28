using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x2000116")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellItem : IMessage<SpellItem>, IMessage, IEquatable<SpellItem>, IDeepCloneable<SpellItem>, IBufferMessage
{
	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellItem> _parser;

	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40003AE")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0x1C")]
	private int spellId_;

	[Token(Token = "0x40003B0")]
	public const int SpellLevelFieldNumber = 2;

	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x20")]
	private int spellLevel_;

	[Token(Token = "0x40003B2")]
	public const int AvailableFieldNumber = 3;

	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly bool AvailableDefaultValue;

	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x24")]
	private bool available_;

	[Token(Token = "0x17000241")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SpellItem> Parser
	{
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xB71790", Offset = "0xB70B90", VA = "0x180B71790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000242")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xB716E0", Offset = "0xB70AE0", VA = "0x180B716E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000243")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xB719B0", Offset = "0xB70DB0", VA = "0x180B719B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000244")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000245")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellLevel
	{
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000246")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Available
	{
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xB71670", Offset = "0xB70A70", VA = "0x180B71670")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xB71A90", Offset = "0xB70E90", VA = "0x180B71A90")]
		set
		{
		}
	}

	[Token(Token = "0x17000247")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasAvailable
	{
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellItem()
	{
	}

	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0xA7E300", Offset = "0xA7D700", VA = "0x180A7E300")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellItem(SpellItem other)
	{
	}

	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0xB71190", Offset = "0xB70590", VA = "0x180B71190", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellItem Clone()
	{
		return null;
	}

	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAvailable()
	{
	}

	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0xB71220", Offset = "0xB70620", VA = "0x180B71220", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0xB712E0", Offset = "0xB706E0", VA = "0x180B712E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpellItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0xB71360", Offset = "0xB70760", VA = "0x180B71360", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0xB71500", Offset = "0xB70900", VA = "0x180B71500", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0xB718C0", Offset = "0xB70CC0", VA = "0x180B718C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0xB710D0", Offset = "0xB704D0", VA = "0x180B710D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0xB71490", Offset = "0xB70890", VA = "0x180B71490", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpellItem other)
	{
	}

	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0xB717E0", Offset = "0xB70BE0", VA = "0x180B717E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
