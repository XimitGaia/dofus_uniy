using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x2000888")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrepareCharacterDeletionRequest : IMessage<PrepareCharacterDeletionRequest>, IMessage, IEquatable<PrepareCharacterDeletionRequest>, IDeepCloneable<PrepareCharacterDeletionRequest>, IBufferMessage
{
	[Token(Token = "0x4001D86")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrepareCharacterDeletionRequest> _parser;

	[Token(Token = "0x4001D87")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D88")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001D89")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x17001343")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PrepareCharacterDeletionRequest> Parser
	{
		[Token(Token = "0x6005A80")]
		[Address(RVA = "0xB28D20", Offset = "0xB28120", VA = "0x180B28D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001344")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005A81")]
		[Address(RVA = "0xB28C70", Offset = "0xB28070", VA = "0x180B28C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001345")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005A82")]
		[Address(RVA = "0xB28D70", Offset = "0xB28170", VA = "0x180B28D70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001346")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6005A86")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005A87")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005A83")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrepareCharacterDeletionRequest()
	{
	}

	[Token(Token = "0x6005A84")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrepareCharacterDeletionRequest(PrepareCharacterDeletionRequest other)
	{
	}

	[Token(Token = "0x6005A85")]
	[Address(RVA = "0xB28A00", Offset = "0xB27E00", VA = "0x180B28A00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrepareCharacterDeletionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005A88")]
	[Address(RVA = "0xB28A80", Offset = "0xB27E80", VA = "0x180B28A80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A89")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PrepareCharacterDeletionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A8A")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005A8B")]
	[Address(RVA = "0xB28B10", Offset = "0xB27F10", VA = "0x180B28B10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005A8C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005A8D")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005A8E")]
	[Address(RVA = "0xB28970", Offset = "0xB27D70", VA = "0x180B28970", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005A8F")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PrepareCharacterDeletionRequest other)
	{
	}

	[Token(Token = "0x6005A90")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005A91")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
