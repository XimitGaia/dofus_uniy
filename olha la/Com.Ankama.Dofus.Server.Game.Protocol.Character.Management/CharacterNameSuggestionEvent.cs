using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008B9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterNameSuggestionEvent : IMessage<CharacterNameSuggestionEvent>, IMessage, IEquatable<CharacterNameSuggestionEvent>, IDeepCloneable<CharacterNameSuggestionEvent>, IBufferMessage
{
	[Token(Token = "0x4001E12")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterNameSuggestionEvent> _parser;

	[Token(Token = "0x4001E13")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E14")]
	public const int SuggestionFieldNumber = 1;

	[Token(Token = "0x4001E15")]
	[FieldOffset(Offset = "0x18")]
	private string suggestion_;

	[Token(Token = "0x1700139A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterNameSuggestionEvent> Parser
	{
		[Token(Token = "0x6005C51")]
		[Address(RVA = "0xB22490", Offset = "0xB21890", VA = "0x180B22490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700139B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005C52")]
		[Address(RVA = "0xB223E0", Offset = "0xB217E0", VA = "0x180B223E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700139C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005C53")]
		[Address(RVA = "0xB225A0", Offset = "0xB219A0", VA = "0x180B225A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700139D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Suggestion
	{
		[Token(Token = "0x6005C57")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C58")]
		[Address(RVA = "0xB22680", Offset = "0xB21A80", VA = "0x180B22680")]
		set
		{
		}
	}

	[Token(Token = "0x6005C54")]
	[Address(RVA = "0xB222F0", Offset = "0xB216F0", VA = "0x180B222F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterNameSuggestionEvent()
	{
	}

	[Token(Token = "0x6005C55")]
	[Address(RVA = "0xB22340", Offset = "0xB21740", VA = "0x180B22340")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterNameSuggestionEvent(CharacterNameSuggestionEvent other)
	{
	}

	[Token(Token = "0x6005C56")]
	[Address(RVA = "0xB21FB0", Offset = "0xB213B0", VA = "0x180B21FB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterNameSuggestionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005C59")]
	[Address(RVA = "0xB22080", Offset = "0xB21480", VA = "0x180B22080", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C5A")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterNameSuggestionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C5B")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005C5C")]
	[Address(RVA = "0xB22190", Offset = "0xB21590", VA = "0x180B22190", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005C5D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005C5E")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005C5F")]
	[Address(RVA = "0xB21F20", Offset = "0xB21320", VA = "0x180B21F20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005C60")]
	[Address(RVA = "0xB22130", Offset = "0xB21530", VA = "0x180B22130", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterNameSuggestionEvent other)
	{
	}

	[Token(Token = "0x6005C61")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005C62")]
	[Address(RVA = "0xB224E0", Offset = "0xB218E0", VA = "0x180B224E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
