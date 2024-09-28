using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x2000894")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterSelectionRequest : IMessage<CharacterSelectionRequest>, IMessage, IEquatable<CharacterSelectionRequest>, IDeepCloneable<CharacterSelectionRequest>, IBufferMessage
{
	[Token(Token = "0x4001DA6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterSelectionRequest> _parser;

	[Token(Token = "0x4001DA7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001DA8")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001DA9")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x1700135C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterSelectionRequest> Parser
	{
		[Token(Token = "0x6005B06")]
		[Address(RVA = "0xB25BC0", Offset = "0xB24FC0", VA = "0x180B25BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700135D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005B07")]
		[Address(RVA = "0xB25B10", Offset = "0xB24F10", VA = "0x180B25B10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700135E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005B08")]
		[Address(RVA = "0xB25C10", Offset = "0xB25010", VA = "0x180B25C10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700135F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005B0D")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005B09")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterSelectionRequest()
	{
	}

	[Token(Token = "0x6005B0A")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterSelectionRequest(CharacterSelectionRequest other)
	{
	}

	[Token(Token = "0x6005B0B")]
	[Address(RVA = "0xB258A0", Offset = "0xB24CA0", VA = "0x180B258A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterSelectionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005B0E")]
	[Address(RVA = "0xB25920", Offset = "0xB24D20", VA = "0x180B25920", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B0F")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterSelectionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B10")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005B11")]
	[Address(RVA = "0xB259B0", Offset = "0xB24DB0", VA = "0x180B259B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005B12")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005B13")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005B14")]
	[Address(RVA = "0xB25810", Offset = "0xB24C10", VA = "0x180B25810", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005B15")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterSelectionRequest other)
	{
	}

	[Token(Token = "0x6005B16")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005B17")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
