using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BDF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterAppearancesRequest : IMessage<CharacterAppearancesRequest>, IMessage, IEquatable<CharacterAppearancesRequest>, IDeepCloneable<CharacterAppearancesRequest>, IBufferMessage
{
	[Token(Token = "0x4002C13")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterAppearancesRequest> _parser;

	[Token(Token = "0x4002C14")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001B6A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterAppearancesRequest> Parser
	{
		[Token(Token = "0x6007CBD")]
		[Address(RVA = "0xC35E50", Offset = "0xC35250", VA = "0x180C35E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B6B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007CBE")]
		[Address(RVA = "0xC35DA0", Offset = "0xC351A0", VA = "0x180C35DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B6C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007CBF")]
		[Address(RVA = "0xC35EA0", Offset = "0xC352A0", VA = "0x180C35EA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007CC0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterAppearancesRequest()
	{
	}

	[Token(Token = "0x6007CC1")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterAppearancesRequest(CharacterAppearancesRequest other)
	{
	}

	[Token(Token = "0x6007CC2")]
	[Address(RVA = "0xC35B40", Offset = "0xC34F40", VA = "0x180C35B40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterAppearancesRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007CC3")]
	[Address(RVA = "0xC35BC0", Offset = "0xC34FC0", VA = "0x180C35BC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CC4")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterAppearancesRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CC5")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007CC6")]
	[Address(RVA = "0xC35C40", Offset = "0xC35040", VA = "0x180C35C40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007CC7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007CC8")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007CC9")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007CCA")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterAppearancesRequest other)
	{
	}

	[Token(Token = "0x6007CCB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007CCC")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
