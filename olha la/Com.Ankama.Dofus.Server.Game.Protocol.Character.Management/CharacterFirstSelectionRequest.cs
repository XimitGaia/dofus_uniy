using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x200089C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterFirstSelectionRequest : IMessage<CharacterFirstSelectionRequest>, IMessage, IEquatable<CharacterFirstSelectionRequest>, IDeepCloneable<CharacterFirstSelectionRequest>, IBufferMessage
{
	[Token(Token = "0x4001DB8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterFirstSelectionRequest> _parser;

	[Token(Token = "0x4001DB9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001DBA")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001DBB")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4001DBC")]
	public const int DoTutorialFieldNumber = 2;

	[Token(Token = "0x4001DBD")]
	[FieldOffset(Offset = "0x20")]
	private bool doTutorial_;

	[Token(Token = "0x1700136B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterFirstSelectionRequest> Parser
	{
		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0xB1B110", Offset = "0xB1A510", VA = "0x180B1B110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700136C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0xB1B060", Offset = "0xB1A460", VA = "0x180B1B060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700136D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005B5E")]
		[Address(RVA = "0xB1B160", Offset = "0xB1A560", VA = "0x180B1B160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700136E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6005B62")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005B63")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700136F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DoTutorial
	{
		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005B65")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6005B5F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterFirstSelectionRequest()
	{
	}

	[Token(Token = "0x6005B60")]
	[Address(RVA = "0x9D4B00", Offset = "0x9D3F00", VA = "0x1809D4B00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterFirstSelectionRequest(CharacterFirstSelectionRequest other)
	{
	}

	[Token(Token = "0x6005B61")]
	[Address(RVA = "0xB1AD00", Offset = "0xB1A100", VA = "0x180B1AD00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterFirstSelectionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005B66")]
	[Address(RVA = "0xB1AD90", Offset = "0xB1A190", VA = "0x180B1AD90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B67")]
	[Address(RVA = "0x9D4790", Offset = "0x9D3B90", VA = "0x1809D4790", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterFirstSelectionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005B68")]
	[Address(RVA = "0xB1AE30", Offset = "0xB1A230", VA = "0x180B1AE30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005B69")]
	[Address(RVA = "0xB1AF00", Offset = "0xB1A300", VA = "0x180B1AF00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005B6A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005B6B")]
	[Address(RVA = "0x9D4D20", Offset = "0x9D4120", VA = "0x1809D4D20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005B6C")]
	[Address(RVA = "0xB1AC70", Offset = "0xB1A070", VA = "0x180B1AC70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005B6D")]
	[Address(RVA = "0x9D4940", Offset = "0x9D3D40", VA = "0x1809D4940", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterFirstSelectionRequest other)
	{
	}

	[Token(Token = "0x6005B6E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005B6F")]
	[Address(RVA = "0x9D4C60", Offset = "0x9D4060", VA = "0x1809D4C60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
