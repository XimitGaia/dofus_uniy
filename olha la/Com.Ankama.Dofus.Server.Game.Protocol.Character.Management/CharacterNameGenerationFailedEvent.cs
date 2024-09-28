using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008BB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterNameGenerationFailedEvent : IMessage<CharacterNameGenerationFailedEvent>, IMessage, IEquatable<CharacterNameGenerationFailedEvent>, IDeepCloneable<CharacterNameGenerationFailedEvent>, IBufferMessage
{
	[Token(Token = "0x20008BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20008BD")]
		public enum NameGenerationFailureReason
		{
			[Token(Token = "0x4001E1C")]
			[OriginalName("NAME_GENERATOR_RETRY_TOO_SHORT")]
			NameGeneratorRetryTooShort,
			[Token(Token = "0x4001E1D")]
			[OriginalName("NAME_GENERATOR_UNAVAILABLE")]
			NameGeneratorUnavailable
		}
	}

	[Token(Token = "0x4001E17")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterNameGenerationFailedEvent> _parser;

	[Token(Token = "0x4001E18")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E19")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4001E1A")]
	[FieldOffset(Offset = "0x18")]
	private Types.NameGenerationFailureReason reason_;

	[Token(Token = "0x1700139E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterNameGenerationFailedEvent> Parser
	{
		[Token(Token = "0x6005C67")]
		[Address(RVA = "0xB21DF0", Offset = "0xB211F0", VA = "0x180B21DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700139F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005C68")]
		[Address(RVA = "0xB21D40", Offset = "0xB21140", VA = "0x180B21D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005C69")]
		[Address(RVA = "0xB21E40", Offset = "0xB21240", VA = "0x180B21E40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.NameGenerationFailureReason Reason
	{
		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.NameGenerationFailureReason);
		}
		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005C6A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterNameGenerationFailedEvent()
	{
	}

	[Token(Token = "0x6005C6B")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterNameGenerationFailedEvent(CharacterNameGenerationFailedEvent other)
	{
	}

	[Token(Token = "0x6005C6C")]
	[Address(RVA = "0xB21AD0", Offset = "0xB20ED0", VA = "0x180B21AD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterNameGenerationFailedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005C6F")]
	[Address(RVA = "0xB21B50", Offset = "0xB20F50", VA = "0x180B21B50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C70")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterNameGenerationFailedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C71")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005C72")]
	[Address(RVA = "0xB21BE0", Offset = "0xB20FE0", VA = "0x180B21BE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005C73")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005C74")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005C75")]
	[Address(RVA = "0xB21A40", Offset = "0xB20E40", VA = "0x180B21A40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005C76")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterNameGenerationFailedEvent other)
	{
	}

	[Token(Token = "0x6005C77")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005C78")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
