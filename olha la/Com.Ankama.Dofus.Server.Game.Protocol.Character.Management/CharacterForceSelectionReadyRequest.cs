using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x200089A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterForceSelectionReadyRequest : IMessage<CharacterForceSelectionReadyRequest>, IMessage, IEquatable<CharacterForceSelectionReadyRequest>, IDeepCloneable<CharacterForceSelectionReadyRequest>, IBufferMessage
{
	[Token(Token = "0x4001DB5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterForceSelectionReadyRequest> _parser;

	[Token(Token = "0x4001DB6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001368")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterForceSelectionReadyRequest> Parser
	{
		[Token(Token = "0x6005B48")]
		[Address(RVA = "0xB1BA30", Offset = "0xB1AE30", VA = "0x180B1BA30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001369")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005B49")]
		[Address(RVA = "0xB1B980", Offset = "0xB1AD80", VA = "0x180B1B980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700136A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0xB1BA80", Offset = "0xB1AE80", VA = "0x180B1BA80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005B4B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterForceSelectionReadyRequest()
	{
	}

	[Token(Token = "0x6005B4C")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterForceSelectionReadyRequest(CharacterForceSelectionReadyRequest other)
	{
	}

	[Token(Token = "0x6005B4D")]
	[Address(RVA = "0xB1B720", Offset = "0xB1AB20", VA = "0x180B1B720", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterForceSelectionReadyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005B4E")]
	[Address(RVA = "0xB1B7A0", Offset = "0xB1ABA0", VA = "0x180B1B7A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B4F")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterForceSelectionReadyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B50")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005B51")]
	[Address(RVA = "0xB1B820", Offset = "0xB1AC20", VA = "0x180B1B820", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005B52")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005B53")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005B54")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005B55")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterForceSelectionReadyRequest other)
	{
	}

	[Token(Token = "0x6005B56")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005B57")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
