using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x2000890")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterReplayRequest : IMessage<CharacterReplayRequest>, IMessage, IEquatable<CharacterReplayRequest>, IDeepCloneable<CharacterReplayRequest>, IBufferMessage
{
	[Token(Token = "0x4001D9A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterReplayRequest> _parser;

	[Token(Token = "0x4001D9B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D9C")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001D9D")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x17001353")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterReplayRequest> Parser
	{
		[Token(Token = "0x6005AD8")]
		[Address(RVA = "0xB233C0", Offset = "0xB227C0", VA = "0x180B233C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001354")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0xB23310", Offset = "0xB22710", VA = "0x180B23310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001355")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0xB23410", Offset = "0xB22810", VA = "0x180B23410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001356")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005ADB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterReplayRequest()
	{
	}

	[Token(Token = "0x6005ADC")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterReplayRequest(CharacterReplayRequest other)
	{
	}

	[Token(Token = "0x6005ADD")]
	[Address(RVA = "0xB230A0", Offset = "0xB224A0", VA = "0x180B230A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterReplayRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005AE0")]
	[Address(RVA = "0xB23120", Offset = "0xB22520", VA = "0x180B23120", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AE1")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterReplayRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AE2")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005AE3")]
	[Address(RVA = "0xB231B0", Offset = "0xB225B0", VA = "0x180B231B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005AE4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005AE5")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005AE6")]
	[Address(RVA = "0xB23010", Offset = "0xB22410", VA = "0x180B23010", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005AE7")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterReplayRequest other)
	{
	}

	[Token(Token = "0x6005AE8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005AE9")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
