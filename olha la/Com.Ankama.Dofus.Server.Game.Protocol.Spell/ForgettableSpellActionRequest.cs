using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell;

[Token(Token = "0x2000100")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellActionRequest : IMessage<ForgettableSpellActionRequest>, IMessage, IEquatable<ForgettableSpellActionRequest>, IDeepCloneable<ForgettableSpellActionRequest>, IBufferMessage
{
	[Token(Token = "0x2000101")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000102")]
		public enum ForgettableSpellAction
		{
			[Token(Token = "0x4000365")]
			[OriginalName("FORGET")]
			Forget,
			[Token(Token = "0x4000366")]
			[OriginalName("EQUIP")]
			Equip,
			[Token(Token = "0x4000367")]
			[OriginalName("REMOVE")]
			Remove
		}
	}

	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellActionRequest> _parser;

	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000360")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x4000362")]
	public const int ActionFieldNumber = 2;

	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x1C")]
	private Types.ForgettableSpellAction action_;

	[Token(Token = "0x17000217")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ForgettableSpellActionRequest> Parser
	{
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xB65B60", Offset = "0xB64F60", VA = "0x180B65B60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000218")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xB65AB0", Offset = "0xB64EB0", VA = "0x180B65AB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000219")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xB65BB0", Offset = "0xB64FB0", VA = "0x180B65BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700021A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpellId
	{
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700021B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.ForgettableSpellAction Action
	{
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.ForgettableSpellAction);
		}
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellActionRequest()
	{
	}

	[Token(Token = "0x60009E9")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellActionRequest(ForgettableSpellActionRequest other)
	{
	}

	[Token(Token = "0x60009EA")]
	[Address(RVA = "0xB65830", Offset = "0xB64C30", VA = "0x180B65830", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellActionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60009EF")]
	[Address(RVA = "0xB658C0", Offset = "0xB64CC0", VA = "0x180B658C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F0")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellActionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60009F2")]
	[Address(RVA = "0xB65950", Offset = "0xB64D50", VA = "0x180B65950", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60009F4")]
	[Address(RVA = "0xA25CC0", Offset = "0xA250C0", VA = "0x180A25CC0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60009F5")]
	[Address(RVA = "0xB65770", Offset = "0xB64B70", VA = "0x180B65770", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ForgettableSpellActionRequest other)
	{
	}

	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
