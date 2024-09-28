using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B31")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellModifier : IMessage<SpellModifier>, IMessage, IEquatable<SpellModifier>, IDeepCloneable<SpellModifier>, IBufferMessage
{
	[Token(Token = "0x40029D6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellModifier> _parser;

	[Token(Token = "0x40029D7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40029D8")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x40029D9")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x40029DA")]
	public const int ActionTypeFieldNumber = 2;

	[Token(Token = "0x40029DB")]
	[FieldOffset(Offset = "0x1C")]
	private SpellModifierActionType actionType_;

	[Token(Token = "0x40029DC")]
	public const int ModifierTypeFieldNumber = 3;

	[Token(Token = "0x40029DD")]
	[FieldOffset(Offset = "0x20")]
	private SpellModifierType modifierType_;

	[Token(Token = "0x40029DE")]
	public const int ContextFieldNumber = 4;

	[Token(Token = "0x40029DF")]
	[FieldOffset(Offset = "0x24")]
	private int context_;

	[Token(Token = "0x40029E0")]
	public const int EquipmentFieldNumber = 5;

	[Token(Token = "0x40029E1")]
	[FieldOffset(Offset = "0x28")]
	private int equipment_;

	[Token(Token = "0x170019FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SpellModifier> Parser
	{
		[Token(Token = "0x60075F2")]
		[Address(RVA = "0xC0D7F0", Offset = "0xC0CBF0", VA = "0x180C0D7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60075F3")]
		[Address(RVA = "0xC0D740", Offset = "0xC0CB40", VA = "0x180C0D740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A01")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60075F4")]
		[Address(RVA = "0xC0D920", Offset = "0xC0CD20", VA = "0x180C0D920", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A02")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpellId
	{
		[Token(Token = "0x60075F8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60075F9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001A03")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellModifierActionType ActionType
	{
		[Token(Token = "0x60075FA")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(SpellModifierActionType);
		}
		[Token(Token = "0x60075FB")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001A04")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellModifierType ModifierType
	{
		[Token(Token = "0x60075FC")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(SpellModifierType);
		}
		[Token(Token = "0x60075FD")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001A05")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Context
	{
		[Token(Token = "0x60075FE")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60075FF")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A06")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Equipment
	{
		[Token(Token = "0x6007600")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007601")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x60075F5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellModifier()
	{
	}

	[Token(Token = "0x60075F6")]
	[Address(RVA = "0xA55430", Offset = "0xA54830", VA = "0x180A55430")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellModifier(SpellModifier other)
	{
	}

	[Token(Token = "0x60075F7")]
	[Address(RVA = "0xC0D3B0", Offset = "0xC0C7B0", VA = "0x180C0D3B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellModifier Clone()
	{
		return null;
	}

	[Token(Token = "0x6007602")]
	[Address(RVA = "0xC0D450", Offset = "0xC0C850", VA = "0x180C0D450", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007603")]
	[Address(RVA = "0xA55120", Offset = "0xA54520", VA = "0x180A55120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpellModifier other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007604")]
	[Address(RVA = "0xC0D500", Offset = "0xC0C900", VA = "0x180C0D500", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007605")]
	[Address(RVA = "0xC0D5E0", Offset = "0xC0C9E0", VA = "0x180C0D5E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007606")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007607")]
	[Address(RVA = "0xC0D840", Offset = "0xC0CC40", VA = "0x180C0D840", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007608")]
	[Address(RVA = "0xC0D280", Offset = "0xC0C680", VA = "0x180C0D280", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007609")]
	[Address(RVA = "0xA55250", Offset = "0xA54650", VA = "0x180A55250", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SpellModifier other)
	{
	}

	[Token(Token = "0x600760A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600760B")]
	[Address(RVA = "0xA555A0", Offset = "0xA549A0", VA = "0x180A555A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
