using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AAC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Shortcut : IMessage<Shortcut>, IMessage, IEquatable<Shortcut>, IDeepCloneable<Shortcut>, IBufferMessage
{
	[Token(Token = "0x2000AAD")]
	public enum ShortcutOneofCase
	{
		[Token(Token = "0x4002712")]
		None = 0,
		[Token(Token = "0x4002713")]
		ShortcutObjectItem = 2,
		[Token(Token = "0x4002714")]
		ShortcutPreset = 3,
		[Token(Token = "0x4002715")]
		ShortcutSpell = 4,
		[Token(Token = "0x4002716")]
		ShortcutSmiley = 5,
		[Token(Token = "0x4002717")]
		ShortcutEmote = 6,
		[Token(Token = "0x4002718")]
		ShortcutCosmeticObject = 7,
		[Token(Token = "0x4002719")]
		ShortcutOutfit = 8
	}

	[Token(Token = "0x4002704")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Shortcut> _parser;

	[Token(Token = "0x4002705")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002706")]
	public const int SlotIdFieldNumber = 1;

	[Token(Token = "0x4002707")]
	[FieldOffset(Offset = "0x18")]
	private int slotId_;

	[Token(Token = "0x4002708")]
	public const int ShortcutObjectItemFieldNumber = 2;

	[Token(Token = "0x4002709")]
	public const int ShortcutPresetFieldNumber = 3;

	[Token(Token = "0x400270A")]
	public const int ShortcutSpellFieldNumber = 4;

	[Token(Token = "0x400270B")]
	public const int ShortcutSmileyFieldNumber = 5;

	[Token(Token = "0x400270C")]
	public const int ShortcutEmoteFieldNumber = 6;

	[Token(Token = "0x400270D")]
	public const int ShortcutCosmeticObjectFieldNumber = 7;

	[Token(Token = "0x400270E")]
	public const int ShortcutOutfitFieldNumber = 8;

	[Token(Token = "0x400270F")]
	[FieldOffset(Offset = "0x20")]
	private object shortcut_;

	[Token(Token = "0x4002710")]
	[FieldOffset(Offset = "0x28")]
	private ShortcutOneofCase shortcutCase_;

	[Token(Token = "0x17001856")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Shortcut> Parser
	{
		[Token(Token = "0x6006FA8")]
		[Address(RVA = "0xBECA40", Offset = "0xBEBE40", VA = "0x180BECA40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001857")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006FA9")]
		[Address(RVA = "0xBEC990", Offset = "0xBEBD90", VA = "0x180BEC990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001858")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006FAA")]
		[Address(RVA = "0xBED5B0", Offset = "0xBEC9B0", VA = "0x180BED5B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001859")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SlotId
	{
		[Token(Token = "0x6006FAE")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006FAF")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700185A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutObjectItem ShortcutObjectItem
	{
		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0xBECB50", Offset = "0xBEBF50", VA = "0x180BECB50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
		set
		{
		}
	}

	[Token(Token = "0x1700185B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutPreset ShortcutPreset
	{
		[Token(Token = "0x6006FB2")]
		[Address(RVA = "0xBECC10", Offset = "0xBEC010", VA = "0x180BECC10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FB3")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x1700185C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutSpell ShortcutSpell
	{
		[Token(Token = "0x6006FB4")]
		[Address(RVA = "0xBECCD0", Offset = "0xBEC0D0", VA = "0x180BECCD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FB5")]
		[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
		set
		{
		}
	}

	[Token(Token = "0x1700185D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutSmiley ShortcutSmiley
	{
		[Token(Token = "0x6006FB6")]
		[Address(RVA = "0xBECC70", Offset = "0xBEC070", VA = "0x180BECC70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FB7")]
		[Address(RVA = "0x9264D0", Offset = "0x9258D0", VA = "0x1809264D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700185E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutEmote ShortcutEmote
	{
		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0xBECAF0", Offset = "0xBEBEF0", VA = "0x180BECAF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FB9")]
		[Address(RVA = "0x9265D0", Offset = "0x9259D0", VA = "0x1809265D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700185F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutCosmeticObject ShortcutCosmeticObject
	{
		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0xBECA90", Offset = "0xBEBE90", VA = "0x180BECA90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FBB")]
		[Address(RVA = "0x926510", Offset = "0x925910", VA = "0x180926510")]
		set
		{
		}
	}

	[Token(Token = "0x17001860")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutOutfit ShortcutOutfit
	{
		[Token(Token = "0x6006FBC")]
		[Address(RVA = "0xBECBB0", Offset = "0xBEBFB0", VA = "0x180BECBB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FBD")]
		[Address(RVA = "0x926490", Offset = "0x925890", VA = "0x180926490")]
		set
		{
		}
	}

	[Token(Token = "0x17001861")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutOneofCase ShortcutCase
	{
		[Token(Token = "0x6006FBE")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(ShortcutOneofCase);
		}
	}

	[Token(Token = "0x6006FAB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Shortcut()
	{
	}

	[Token(Token = "0x6006FAC")]
	[Address(RVA = "0xBEC490", Offset = "0xBEB890", VA = "0x180BEC490")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Shortcut(Shortcut other)
	{
	}

	[Token(Token = "0x6006FAD")]
	[Address(RVA = "0xBEB8E0", Offset = "0xBEACE0", VA = "0x180BEB8E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Shortcut Clone()
	{
		return null;
	}

	[Token(Token = "0x6006FBF")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearShortcut()
	{
	}

	[Token(Token = "0x6006FC0")]
	[Address(RVA = "0xBEB940", Offset = "0xBEAD40", VA = "0x180BEB940", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FC1")]
	[Address(RVA = "0xBEB9A0", Offset = "0xBEADA0", VA = "0x180BEB9A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(Shortcut other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006FC2")]
	[Address(RVA = "0xBEBB50", Offset = "0xBEAF50", VA = "0x180BEBB50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006FC3")]
	[Address(RVA = "0xBEC330", Offset = "0xBEB730", VA = "0x180BEC330", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006FC4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006FC5")]
	[Address(RVA = "0xBED260", Offset = "0xBEC660", VA = "0x180BED260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006FC6")]
	[Address(RVA = "0xBEB530", Offset = "0xBEA930", VA = "0x180BEB530", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006FC7")]
	[Address(RVA = "0xBEBED0", Offset = "0xBEB2D0", VA = "0x180BEBED0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Shortcut other)
	{
	}

	[Token(Token = "0x6006FC8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006FC9")]
	[Address(RVA = "0xBECD30", Offset = "0xBEC130", VA = "0x180BECD30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
