using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008C3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterListErrorEvent : IMessage<CharacterListErrorEvent>, IMessage, IEquatable<CharacterListErrorEvent>, IDeepCloneable<CharacterListErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4001E2F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterListErrorEvent> _parser;

	[Token(Token = "0x4001E30")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x170013AD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterListErrorEvent> Parser
	{
		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0xB1C880", Offset = "0xB1BC80", VA = "0x180B1C880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013AE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0xB1C7D0", Offset = "0xB1BBD0", VA = "0x180B1C7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0xB1C8D0", Offset = "0xB1BCD0", VA = "0x180B1C8D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005CB2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterListErrorEvent()
	{
	}

	[Token(Token = "0x6005CB3")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListErrorEvent(CharacterListErrorEvent other)
	{
	}

	[Token(Token = "0x6005CB4")]
	[Address(RVA = "0xB1C570", Offset = "0xB1B970", VA = "0x180B1C570", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005CB5")]
	[Address(RVA = "0xB1C5F0", Offset = "0xB1B9F0", VA = "0x180B1C5F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CB6")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterListErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CB7")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005CB8")]
	[Address(RVA = "0xB1C670", Offset = "0xB1BA70", VA = "0x180B1C670", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005CB9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005CBA")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005CBB")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005CBC")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterListErrorEvent other)
	{
	}

	[Token(Token = "0x6005CBD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005CBE")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
