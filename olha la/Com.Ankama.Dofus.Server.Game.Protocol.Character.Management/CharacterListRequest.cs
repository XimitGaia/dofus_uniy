using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x2000898")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterListRequest : IMessage<CharacterListRequest>, IMessage, IEquatable<CharacterListRequest>, IDeepCloneable<CharacterListRequest>, IBufferMessage
{
	[Token(Token = "0x4001DB2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterListRequest> _parser;

	[Token(Token = "0x4001DB3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001365")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterListRequest> Parser
	{
		[Token(Token = "0x6005B34")]
		[Address(RVA = "0xB1D6C0", Offset = "0xB1CAC0", VA = "0x180B1D6C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001366")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005B35")]
		[Address(RVA = "0xB1D610", Offset = "0xB1CA10", VA = "0x180B1D610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001367")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005B36")]
		[Address(RVA = "0xB1D710", Offset = "0xB1CB10", VA = "0x180B1D710", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005B37")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListRequest()
	{
	}

	[Token(Token = "0x6005B38")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListRequest(CharacterListRequest other)
	{
	}

	[Token(Token = "0x6005B39")]
	[Address(RVA = "0xB1D3B0", Offset = "0xB1C7B0", VA = "0x180B1D3B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005B3A")]
	[Address(RVA = "0xB1D430", Offset = "0xB1C830", VA = "0x180B1D430", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B3B")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterListRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B3C")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005B3D")]
	[Address(RVA = "0xB1D4B0", Offset = "0xB1C8B0", VA = "0x180B1D4B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005B3E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005B3F")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005B40")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005B41")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterListRequest other)
	{
	}

	[Token(Token = "0x6005B42")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005B43")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
