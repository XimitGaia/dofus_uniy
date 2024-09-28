using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008A7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterDeletionErrorEvent : IMessage<CharacterDeletionErrorEvent>, IMessage, IEquatable<CharacterDeletionErrorEvent>, IDeepCloneable<CharacterDeletionErrorEvent>, IBufferMessage
{
	[Token(Token = "0x20008A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20008A9")]
		public enum CharacterDeletionError
		{
			[Token(Token = "0x4001DE7")]
			[OriginalName("DELETE_ERROR_NO_REASON")]
			DeleteErrorNoReason,
			[Token(Token = "0x4001DE8")]
			[OriginalName("DELETE_ERROR_TOO_MANY_CHAR_DELETED")]
			DeleteErrorTooManyCharDeleted,
			[Token(Token = "0x4001DE9")]
			[OriginalName("DELETE_ERROR_BAD_SECRET_ANSWER")]
			DeleteErrorBadSecretAnswer
		}
	}

	[Token(Token = "0x4001DE2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterDeletionErrorEvent> _parser;

	[Token(Token = "0x4001DE3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001DE4")]
	public const int ReasonFieldNumber = 1;

	[Token(Token = "0x4001DE5")]
	[FieldOffset(Offset = "0x18")]
	private Types.CharacterDeletionError reason_;

	[Token(Token = "0x1700137C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterDeletionErrorEvent> Parser
	{
		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0xB18D90", Offset = "0xB18190", VA = "0x180B18D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700137D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0xB18CE0", Offset = "0xB180E0", VA = "0x180B18CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700137E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0xB18DE0", Offset = "0xB181E0", VA = "0x180B18DE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700137F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.CharacterDeletionError Reason
	{
		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.CharacterDeletionError);
		}
		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005BB9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionErrorEvent()
	{
	}

	[Token(Token = "0x6005BBA")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionErrorEvent(CharacterDeletionErrorEvent other)
	{
	}

	[Token(Token = "0x6005BBB")]
	[Address(RVA = "0xB18A70", Offset = "0xB17E70", VA = "0x180B18A70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterDeletionErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005BBE")]
	[Address(RVA = "0xB18AF0", Offset = "0xB17EF0", VA = "0x180B18AF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BBF")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterDeletionErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BC0")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005BC1")]
	[Address(RVA = "0xB18B80", Offset = "0xB17F80", VA = "0x180B18B80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005BC2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005BC3")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005BC4")]
	[Address(RVA = "0xB189E0", Offset = "0xB17DE0", VA = "0x180B189E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005BC5")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterDeletionErrorEvent other)
	{
	}

	[Token(Token = "0x6005BC6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005BC7")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
