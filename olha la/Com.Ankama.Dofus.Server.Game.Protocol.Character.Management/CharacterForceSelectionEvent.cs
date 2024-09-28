using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008C1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterForceSelectionEvent : IMessage<CharacterForceSelectionEvent>, IMessage, IEquatable<CharacterForceSelectionEvent>, IDeepCloneable<CharacterForceSelectionEvent>, IBufferMessage
{
	[Token(Token = "0x4001E2A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterForceSelectionEvent> _parser;

	[Token(Token = "0x4001E2B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E2C")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001E2D")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x170013A9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterForceSelectionEvent> Parser
	{
		[Token(Token = "0x6005C99")]
		[Address(RVA = "0xB1B5F0", Offset = "0xB1A9F0", VA = "0x180B1B5F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013AA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0xB1B540", Offset = "0xB1A940", VA = "0x180B1B540")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0xB1B640", Offset = "0xB1AA40", VA = "0x180B1B640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013AC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005C9C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterForceSelectionEvent()
	{
	}

	[Token(Token = "0x6005C9D")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterForceSelectionEvent(CharacterForceSelectionEvent other)
	{
	}

	[Token(Token = "0x6005C9E")]
	[Address(RVA = "0xB1B2D0", Offset = "0xB1A6D0", VA = "0x180B1B2D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterForceSelectionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005CA1")]
	[Address(RVA = "0xB1B350", Offset = "0xB1A750", VA = "0x180B1B350", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CA2")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterForceSelectionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CA3")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005CA4")]
	[Address(RVA = "0xB1B3E0", Offset = "0xB1A7E0", VA = "0x180B1B3E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005CA5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005CA6")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005CA7")]
	[Address(RVA = "0xB1B240", Offset = "0xB1A640", VA = "0x180B1B240", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005CA8")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterForceSelectionEvent other)
	{
	}

	[Token(Token = "0x6005CA9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005CAA")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
