using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration;

[Token(Token = "0x2000C45")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlterationRemovedEvent : IMessage<AlterationRemovedEvent>, IMessage, IEquatable<AlterationRemovedEvent>, IDeepCloneable<AlterationRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4002D7F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AlterationRemovedEvent> _parser;

	[Token(Token = "0x4002D80")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D81")]
	public const int AlterationFieldNumber = 1;

	[Token(Token = "0x4002D82")]
	[FieldOffset(Offset = "0x18")]
	private Alteration alteration_;

	[Token(Token = "0x17001C57")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlterationRemovedEvent> Parser
	{
		[Token(Token = "0x6008123")]
		[Address(RVA = "0xC80B90", Offset = "0xC7FF90", VA = "0x180C80B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C58")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008124")]
		[Address(RVA = "0xC80AE0", Offset = "0xC7FEE0", VA = "0x180C80AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C59")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008125")]
		[Address(RVA = "0xC80CE0", Offset = "0xC800E0", VA = "0x180C80CE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C5A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Alteration Alteration
	{
		[Token(Token = "0x6008129")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600812A")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008126")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlterationRemovedEvent()
	{
	}

	[Token(Token = "0x6008127")]
	[Address(RVA = "0xC7F6B0", Offset = "0xC7EAB0", VA = "0x180C7F6B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlterationRemovedEvent(AlterationRemovedEvent other)
	{
	}

	[Token(Token = "0x6008128")]
	[Address(RVA = "0xC80760", Offset = "0xC7FB60", VA = "0x180C80760", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlterationRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600812B")]
	[Address(RVA = "0xC80800", Offset = "0xC7FC00", VA = "0x180C80800", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600812C")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlterationRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600812D")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600812E")]
	[Address(RVA = "0xC80980", Offset = "0xC7FD80", VA = "0x180C80980", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600812F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008130")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008131")]
	[Address(RVA = "0xC806D0", Offset = "0xC7FAD0", VA = "0x180C806D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008132")]
	[Address(RVA = "0xC808B0", Offset = "0xC7FCB0", VA = "0x180C808B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlterationRemovedEvent other)
	{
	}

	[Token(Token = "0x6008133")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008134")]
	[Address(RVA = "0xC80BE0", Offset = "0xC7FFE0", VA = "0x180C80BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
