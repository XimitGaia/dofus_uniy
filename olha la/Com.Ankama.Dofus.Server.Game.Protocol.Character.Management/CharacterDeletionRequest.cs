using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x200088A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterDeletionRequest : IMessage<CharacterDeletionRequest>, IMessage, IEquatable<CharacterDeletionRequest>, IDeepCloneable<CharacterDeletionRequest>, IBufferMessage
{
	[Token(Token = "0x4001D8B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterDeletionRequest> _parser;

	[Token(Token = "0x4001D8C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D8D")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001D8E")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4001D8F")]
	public const int SecretAnswerHashFieldNumber = 2;

	[Token(Token = "0x4001D90")]
	[FieldOffset(Offset = "0x20")]
	private string secretAnswerHash_;

	[Token(Token = "0x17001347")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterDeletionRequest> Parser
	{
		[Token(Token = "0x6005A96")]
		[Address(RVA = "0xB1A160", Offset = "0xB19560", VA = "0x180B1A160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001348")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005A97")]
		[Address(RVA = "0xB1A0B0", Offset = "0xB194B0", VA = "0x180B1A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001349")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005A98")]
		[Address(RVA = "0xB1A290", Offset = "0xB19690", VA = "0x180B1A290", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700134A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005A9D")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700134B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SecretAnswerHash
	{
		[Token(Token = "0x6005A9E")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005A9F")]
		[Address(RVA = "0xB1A370", Offset = "0xB19770", VA = "0x180B1A370")]
		set
		{
		}
	}

	[Token(Token = "0x6005A99")]
	[Address(RVA = "0xB1A060", Offset = "0xB19460", VA = "0x180B1A060")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionRequest()
	{
	}

	[Token(Token = "0x6005A9A")]
	[Address(RVA = "0xB19FB0", Offset = "0xB193B0", VA = "0x180B19FB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionRequest(CharacterDeletionRequest other)
	{
	}

	[Token(Token = "0x6005A9B")]
	[Address(RVA = "0xB19C50", Offset = "0xB19050", VA = "0x180B19C50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005AA0")]
	[Address(RVA = "0xB19D20", Offset = "0xB19120", VA = "0x180B19D20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AA1")]
	[Address(RVA = "0x92C840", Offset = "0x92BC40", VA = "0x18092C840", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterDeletionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005AA2")]
	[Address(RVA = "0x92C8B0", Offset = "0x92BCB0", VA = "0x18092C8B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005AA3")]
	[Address(RVA = "0xB19E50", Offset = "0xB19250", VA = "0x180B19E50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005AA4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005AA5")]
	[Address(RVA = "0x92CDC0", Offset = "0x92C1C0", VA = "0x18092CDC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005AA6")]
	[Address(RVA = "0xB19B90", Offset = "0xB18F90", VA = "0x180B19B90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005AA7")]
	[Address(RVA = "0xB19DE0", Offset = "0xB191E0", VA = "0x180B19DE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterDeletionRequest other)
	{
	}

	[Token(Token = "0x6005AA8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005AA9")]
	[Address(RVA = "0xB1A1B0", Offset = "0xB195B0", VA = "0x180B1A1B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
