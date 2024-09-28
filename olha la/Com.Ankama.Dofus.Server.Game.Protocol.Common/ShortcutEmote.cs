using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AB5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutEmote : IMessage<ShortcutEmote>, IMessage, IEquatable<ShortcutEmote>, IDeepCloneable<ShortcutEmote>, IBufferMessage
{
	[Token(Token = "0x400272C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutEmote> _parser;

	[Token(Token = "0x400272D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400272E")]
	public const int EmoteIdFieldNumber = 1;

	[Token(Token = "0x400272F")]
	[FieldOffset(Offset = "0x18")]
	private int emoteId_;

	[Token(Token = "0x1700186F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShortcutEmote> Parser
	{
		[Token(Token = "0x6007012")]
		[Address(RVA = "0xBE9520", Offset = "0xBE8920", VA = "0x180BE9520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001870")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007013")]
		[Address(RVA = "0xBE9470", Offset = "0xBE8870", VA = "0x180BE9470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001871")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007014")]
		[Address(RVA = "0xBE9570", Offset = "0xBE8970", VA = "0x180BE9570", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001872")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EmoteId
	{
		[Token(Token = "0x6007018")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007019")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007015")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutEmote()
	{
	}

	[Token(Token = "0x6007016")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutEmote(ShortcutEmote other)
	{
	}

	[Token(Token = "0x6007017")]
	[Address(RVA = "0xBE9200", Offset = "0xBE8600", VA = "0x180BE9200", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutEmote Clone()
	{
		return null;
	}

	[Token(Token = "0x600701A")]
	[Address(RVA = "0xBE9280", Offset = "0xBE8680", VA = "0x180BE9280", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600701B")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShortcutEmote other)
	{
		return default(bool);
	}

	[Token(Token = "0x600701C")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600701D")]
	[Address(RVA = "0xBE9310", Offset = "0xBE8710", VA = "0x180BE9310", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600701E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600701F")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007020")]
	[Address(RVA = "0xBE9170", Offset = "0xBE8570", VA = "0x180BE9170", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007021")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutEmote other)
	{
	}

	[Token(Token = "0x6007022")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007023")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
