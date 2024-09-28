using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008BF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterDeletionPrepareEvent : IMessage<CharacterDeletionPrepareEvent>, IMessage, IEquatable<CharacterDeletionPrepareEvent>, IDeepCloneable<CharacterDeletionPrepareEvent>, IBufferMessage
{
	[Token(Token = "0x4001E1F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterDeletionPrepareEvent> _parser;

	[Token(Token = "0x4001E20")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E21")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4001E22")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x4001E23")]
	public const int NameFieldNumber = 2;

	[Token(Token = "0x4001E24")]
	[FieldOffset(Offset = "0x20")]
	private string name_;

	[Token(Token = "0x4001E25")]
	public const int SecretQuestionFieldNumber = 3;

	[Token(Token = "0x4001E26")]
	[FieldOffset(Offset = "0x28")]
	private string secretQuestion_;

	[Token(Token = "0x4001E27")]
	public const int NeedSecretAnswerFieldNumber = 4;

	[Token(Token = "0x4001E28")]
	[FieldOffset(Offset = "0x30")]
	private bool needSecretAnswer_;

	[Token(Token = "0x170013A2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterDeletionPrepareEvent> Parser
	{
		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0xB19760", Offset = "0xB18B60", VA = "0x180B19760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0xB196B0", Offset = "0xB18AB0", VA = "0x180B196B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0xB199D0", Offset = "0xB18DD0", VA = "0x180B199D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x170013A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0xB19AB0", Offset = "0xB18EB0", VA = "0x180B19AB0")]
		set
		{
		}
	}

	[Token(Token = "0x170013A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SecretQuestion
	{
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0xB19B20", Offset = "0xB18F20", VA = "0x180B19B20")]
		set
		{
		}
	}

	[Token(Token = "0x170013A8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NeedSecretAnswer
	{
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
		set
		{
		}
	}

	[Token(Token = "0x6005C80")]
	[Address(RVA = "0xB19640", Offset = "0xB18A40", VA = "0x180B19640")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionPrepareEvent()
	{
	}

	[Token(Token = "0x6005C81")]
	[Address(RVA = "0xB19550", Offset = "0xB18950", VA = "0x180B19550")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionPrepareEvent(CharacterDeletionPrepareEvent other)
	{
	}

	[Token(Token = "0x6005C82")]
	[Address(RVA = "0xB18FC0", Offset = "0xB183C0", VA = "0x180B18FC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionPrepareEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005C8B")]
	[Address(RVA = "0xB19160", Offset = "0xB18560", VA = "0x180B19160", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C8C")]
	[Address(RVA = "0xB190D0", Offset = "0xB184D0", VA = "0x180B190D0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterDeletionPrepareEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C8D")]
	[Address(RVA = "0xB19240", Offset = "0xB18640", VA = "0x180B19240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005C8E")]
	[Address(RVA = "0xB193F0", Offset = "0xB187F0", VA = "0x180B193F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005C8F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005C90")]
	[Address(RVA = "0xB198F0", Offset = "0xB18CF0", VA = "0x180B198F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005C91")]
	[Address(RVA = "0xB18EC0", Offset = "0xB182C0", VA = "0x180B18EC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005C92")]
	[Address(RVA = "0xB19350", Offset = "0xB18750", VA = "0x180B19350", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterDeletionPrepareEvent other)
	{
	}

	[Token(Token = "0x6005C93")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005C94")]
	[Address(RVA = "0xB197B0", Offset = "0xB18BB0", VA = "0x180B197B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
