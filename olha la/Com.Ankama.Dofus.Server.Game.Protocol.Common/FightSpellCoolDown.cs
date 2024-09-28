using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A57")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightSpellCoolDown : IMessage<FightSpellCoolDown>, IMessage, IEquatable<FightSpellCoolDown>, IDeepCloneable<FightSpellCoolDown>, IBufferMessage
{
	[Token(Token = "0x4002567")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightSpellCoolDown> _parser;

	[Token(Token = "0x4002568")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002569")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x400256A")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x400256B")]
	public const int CoolDownFieldNumber = 2;

	[Token(Token = "0x400256C")]
	[FieldOffset(Offset = "0x1C")]
	private int coolDown_;

	[Token(Token = "0x17001768")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightSpellCoolDown> Parser
	{
		[Token(Token = "0x6006C16")]
		[Address(RVA = "0xBCE470", Offset = "0xBCD870", VA = "0x180BCE470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001769")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006C17")]
		[Address(RVA = "0xBCE3C0", Offset = "0xBCD7C0", VA = "0x180BCE3C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006C18")]
		[Address(RVA = "0xBCE4C0", Offset = "0xBCD8C0", VA = "0x180BCE4C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700176B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x6006C1C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006C1D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700176C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CoolDown
	{
		[Token(Token = "0x6006C1E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006C1F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6006C19")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSpellCoolDown()
	{
	}

	[Token(Token = "0x6006C1A")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightSpellCoolDown(FightSpellCoolDown other)
	{
	}

	[Token(Token = "0x6006C1B")]
	[Address(RVA = "0xBCE140", Offset = "0xBCD540", VA = "0x180BCE140", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSpellCoolDown Clone()
	{
		return null;
	}

	[Token(Token = "0x6006C20")]
	[Address(RVA = "0xBCE1D0", Offset = "0xBCD5D0", VA = "0x180BCE1D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C21")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightSpellCoolDown other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C22")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006C23")]
	[Address(RVA = "0xBCE260", Offset = "0xBCD660", VA = "0x180BCE260", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006C24")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006C25")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006C26")]
	[Address(RVA = "0xBCE080", Offset = "0xBCD480", VA = "0x180BCE080", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006C27")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightSpellCoolDown other)
	{
	}

	[Token(Token = "0x6006C28")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006C29")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
