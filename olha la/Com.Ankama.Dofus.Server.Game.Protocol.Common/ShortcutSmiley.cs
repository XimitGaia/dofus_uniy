using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AB3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutSmiley : IMessage<ShortcutSmiley>, IMessage, IEquatable<ShortcutSmiley>, IDeepCloneable<ShortcutSmiley>, IBufferMessage
{
	[Token(Token = "0x4002727")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutSmiley> _parser;

	[Token(Token = "0x4002728")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002729")]
	public const int SmileyIdFieldNumber = 1;

	[Token(Token = "0x400272A")]
	[FieldOffset(Offset = "0x18")]
	private int smileyId_;

	[Token(Token = "0x1700186B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShortcutSmiley> Parser
	{
		[Token(Token = "0x6006FFC")]
		[Address(RVA = "0xBEAF20", Offset = "0xBEA320", VA = "0x180BEAF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700186C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006FFD")]
		[Address(RVA = "0xBEAE70", Offset = "0xBEA270", VA = "0x180BEAE70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700186D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006FFE")]
		[Address(RVA = "0xBEAF70", Offset = "0xBEA370", VA = "0x180BEAF70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700186E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SmileyId
	{
		[Token(Token = "0x6007002")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007003")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6006FFF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutSmiley()
	{
	}

	[Token(Token = "0x6007000")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutSmiley(ShortcutSmiley other)
	{
	}

	[Token(Token = "0x6007001")]
	[Address(RVA = "0xBEAC00", Offset = "0xBEA000", VA = "0x180BEAC00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutSmiley Clone()
	{
		return null;
	}

	[Token(Token = "0x6007004")]
	[Address(RVA = "0xBEAC80", Offset = "0xBEA080", VA = "0x180BEAC80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007005")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShortcutSmiley other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007006")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007007")]
	[Address(RVA = "0xBEAD10", Offset = "0xBEA110", VA = "0x180BEAD10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007008")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007009")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600700A")]
	[Address(RVA = "0xBEAB70", Offset = "0xBE9F70", VA = "0x180BEAB70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600700B")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutSmiley other)
	{
	}

	[Token(Token = "0x600700C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600700D")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
