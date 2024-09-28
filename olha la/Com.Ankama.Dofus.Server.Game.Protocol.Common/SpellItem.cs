using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B2F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellItem : IMessage<SpellItem>, IMessage, IEquatable<SpellItem>, IDeepCloneable<SpellItem>, IBufferMessage
{
	[Token(Token = "0x40029CB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellItem> _parser;

	[Token(Token = "0x40029CC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40029CD")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x40029CE")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x40029CF")]
	[FieldOffset(Offset = "0x1C")]
	private int spellId_;

	[Token(Token = "0x40029D0")]
	public const int SpellLevelFieldNumber = 2;

	[Token(Token = "0x40029D1")]
	[FieldOffset(Offset = "0x20")]
	private int spellLevel_;

	[Token(Token = "0x40029D2")]
	public const int AvailableFieldNumber = 3;

	[Token(Token = "0x40029D3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly bool AvailableDefaultValue;

	[Token(Token = "0x40029D4")]
	[FieldOffset(Offset = "0x24")]
	private bool available_;

	[Token(Token = "0x170019F8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SpellItem> Parser
	{
		[Token(Token = "0x60075D6")]
		[Address(RVA = "0xC0D060", Offset = "0xC0C460", VA = "0x180C0D060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019F9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60075D7")]
		[Address(RVA = "0xC0CFB0", Offset = "0xC0C3B0", VA = "0x180C0CFB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019FA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60075D8")]
		[Address(RVA = "0xC0D1A0", Offset = "0xC0C5A0", VA = "0x180C0D1A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019FB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x60075DC")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60075DD")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170019FC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpellLevel
	{
		[Token(Token = "0x60075DE")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60075DF")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170019FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Available
	{
		[Token(Token = "0x60075E0")]
		[Address(RVA = "0xC0CF40", Offset = "0xC0C340", VA = "0x180C0CF40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60075E1")]
		[Address(RVA = "0xB71A90", Offset = "0xB70E90", VA = "0x180B71A90")]
		set
		{
		}
	}

	[Token(Token = "0x170019FE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasAvailable
	{
		[Token(Token = "0x60075E2")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60075D9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellItem()
	{
	}

	[Token(Token = "0x60075DA")]
	[Address(RVA = "0xA7E300", Offset = "0xA7D700", VA = "0x180A7E300")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellItem(SpellItem other)
	{
	}

	[Token(Token = "0x60075DB")]
	[Address(RVA = "0xC0CA60", Offset = "0xC0BE60", VA = "0x180C0CA60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellItem Clone()
	{
		return null;
	}

	[Token(Token = "0x60075E3")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearAvailable()
	{
	}

	[Token(Token = "0x60075E4")]
	[Address(RVA = "0xC0CAF0", Offset = "0xC0BEF0", VA = "0x180C0CAF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60075E5")]
	[Address(RVA = "0xC0CBB0", Offset = "0xC0BFB0", VA = "0x180C0CBB0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpellItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x60075E6")]
	[Address(RVA = "0xC0CC30", Offset = "0xC0C030", VA = "0x180C0CC30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60075E7")]
	[Address(RVA = "0xC0CDD0", Offset = "0xC0C1D0", VA = "0x180C0CDD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60075E8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60075E9")]
	[Address(RVA = "0xC0D0B0", Offset = "0xC0C4B0", VA = "0x180C0D0B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60075EA")]
	[Address(RVA = "0xC0C9A0", Offset = "0xC0BDA0", VA = "0x180C0C9A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60075EB")]
	[Address(RVA = "0xC0CD60", Offset = "0xC0C160", VA = "0x180C0CD60", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SpellItem other)
	{
	}

	[Token(Token = "0x60075EC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60075ED")]
	[Address(RVA = "0xB717E0", Offset = "0xB70BE0", VA = "0x180B717E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
