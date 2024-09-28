using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x200086F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterLevelUpEvent : IMessage<CharacterLevelUpEvent>, IMessage, IEquatable<CharacterLevelUpEvent>, IDeepCloneable<CharacterLevelUpEvent>, IBufferMessage
{
	[Token(Token = "0x4001D39")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterLevelUpEvent> _parser;

	[Token(Token = "0x4001D3A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D3B")]
	public const int NewLevelFieldNumber = 1;

	[Token(Token = "0x4001D3C")]
	[FieldOffset(Offset = "0x18")]
	private int newLevel_;

	[Token(Token = "0x17001317")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterLevelUpEvent> Parser
	{
		[Token(Token = "0x60059A9")]
		[Address(RVA = "0xB1BF10", Offset = "0xB1B310", VA = "0x180B1BF10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001318")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60059AA")]
		[Address(RVA = "0xB1BE60", Offset = "0xB1B260", VA = "0x180B1BE60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001319")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60059AB")]
		[Address(RVA = "0xB1BF60", Offset = "0xB1B360", VA = "0x180B1BF60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700131A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NewLevel
	{
		[Token(Token = "0x60059AF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60059B0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60059AC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterLevelUpEvent()
	{
	}

	[Token(Token = "0x60059AD")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterLevelUpEvent(CharacterLevelUpEvent other)
	{
	}

	[Token(Token = "0x60059AE")]
	[Address(RVA = "0xB1BBF0", Offset = "0xB1AFF0", VA = "0x180B1BBF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterLevelUpEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60059B1")]
	[Address(RVA = "0xB1BC70", Offset = "0xB1B070", VA = "0x180B1BC70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60059B2")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterLevelUpEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60059B3")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60059B4")]
	[Address(RVA = "0xB1BD00", Offset = "0xB1B100", VA = "0x180B1BD00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60059B5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60059B6")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60059B7")]
	[Address(RVA = "0xB1BB60", Offset = "0xB1AF60", VA = "0x180B1BB60", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60059B8")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterLevelUpEvent other)
	{
	}

	[Token(Token = "0x60059B9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60059BA")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
