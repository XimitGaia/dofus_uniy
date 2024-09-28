using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x200089E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterNameSuggestionRequest : IMessage<CharacterNameSuggestionRequest>, IMessage, IEquatable<CharacterNameSuggestionRequest>, IDeepCloneable<CharacterNameSuggestionRequest>, IBufferMessage
{
	[Token(Token = "0x4001DBF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterNameSuggestionRequest> _parser;

	[Token(Token = "0x4001DC0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001370")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterNameSuggestionRequest> Parser
	{
		[Token(Token = "0x6005B74")]
		[Address(RVA = "0xB22A00", Offset = "0xB21E00", VA = "0x180B22A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001371")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005B75")]
		[Address(RVA = "0xB22950", Offset = "0xB21D50", VA = "0x180B22950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001372")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005B76")]
		[Address(RVA = "0xB22A50", Offset = "0xB21E50", VA = "0x180B22A50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005B77")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterNameSuggestionRequest()
	{
	}

	[Token(Token = "0x6005B78")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterNameSuggestionRequest(CharacterNameSuggestionRequest other)
	{
	}

	[Token(Token = "0x6005B79")]
	[Address(RVA = "0xB226F0", Offset = "0xB21AF0", VA = "0x180B226F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterNameSuggestionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005B7A")]
	[Address(RVA = "0xB22770", Offset = "0xB21B70", VA = "0x180B22770", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B7B")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterNameSuggestionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B7C")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005B7D")]
	[Address(RVA = "0xB227F0", Offset = "0xB21BF0", VA = "0x180B227F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005B7E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005B7F")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005B80")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005B81")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterNameSuggestionRequest other)
	{
	}

	[Token(Token = "0x6005B82")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005B83")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
