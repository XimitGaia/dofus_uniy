using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008B7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterLoadingCompleteEvent : IMessage<CharacterLoadingCompleteEvent>, IMessage, IEquatable<CharacterLoadingCompleteEvent>, IDeepCloneable<CharacterLoadingCompleteEvent>, IBufferMessage
{
	[Token(Token = "0x4001E0F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterLoadingCompleteEvent> _parser;

	[Token(Token = "0x4001E10")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001397")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterLoadingCompleteEvent> Parser
	{
		[Token(Token = "0x6005C3D")]
		[Address(RVA = "0xB1E700", Offset = "0xB1DB00", VA = "0x180B1E700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001398")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005C3E")]
		[Address(RVA = "0xB1E650", Offset = "0xB1DA50", VA = "0x180B1E650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001399")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005C3F")]
		[Address(RVA = "0xB1E750", Offset = "0xB1DB50", VA = "0x180B1E750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005C40")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterLoadingCompleteEvent()
	{
	}

	[Token(Token = "0x6005C41")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterLoadingCompleteEvent(CharacterLoadingCompleteEvent other)
	{
	}

	[Token(Token = "0x6005C42")]
	[Address(RVA = "0xB1E3F0", Offset = "0xB1D7F0", VA = "0x180B1E3F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterLoadingCompleteEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005C43")]
	[Address(RVA = "0xB1E470", Offset = "0xB1D870", VA = "0x180B1E470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C44")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterLoadingCompleteEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C45")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005C46")]
	[Address(RVA = "0xB1E4F0", Offset = "0xB1D8F0", VA = "0x180B1E4F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005C47")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005C48")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005C49")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005C4A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterLoadingCompleteEvent other)
	{
	}

	[Token(Token = "0x6005C4B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005C4C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
