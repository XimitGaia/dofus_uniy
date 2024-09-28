using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008A2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCreationResultEvent : IMessage<CharacterCreationResultEvent>, IMessage, IEquatable<CharacterCreationResultEvent>, IDeepCloneable<CharacterCreationResultEvent>, IBufferMessage
{
	[Token(Token = "0x20008A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20008A4")]
		public enum CharacterCreationResult
		{
			[Token(Token = "0x4001DCE")]
			[OriginalName("CREATE_OK")]
			CreateOk,
			[Token(Token = "0x4001DCF")]
			[OriginalName("CREATE_ERROR_NO_REASON")]
			CreateErrorNoReason,
			[Token(Token = "0x4001DD0")]
			[OriginalName("CREATE_ERROR_INVALID_NAME")]
			CreateErrorInvalidName,
			[Token(Token = "0x4001DD1")]
			[OriginalName("CREATE_ERROR_TOO_MANY_CHARACTERS")]
			CreateErrorTooManyCharacters,
			[Token(Token = "0x4001DD2")]
			[OriginalName("CREATE_ERROR_NOT_ALLOWED")]
			CreateErrorNotAllowed,
			[Token(Token = "0x4001DD3")]
			[OriginalName("CREATE_ERROR_NEW_PLAYER_NOT_ALLOWED")]
			CreateErrorNewPlayerNotAllowed
		}

		[Token(Token = "0x20008A5")]
		public enum NameCompliance
		{
			[Token(Token = "0x4001DD5")]
			[OriginalName("NAME_OK")]
			NameOk,
			[Token(Token = "0x4001DD6")]
			[OriginalName("NAME_ERROR_SERVICE_UNAVAILABLE")]
			NameErrorServiceUnavailable,
			[Token(Token = "0x4001DD7")]
			[OriginalName("NAME_ERROR_ALREADY_EXISTS")]
			NameErrorAlreadyExists,
			[Token(Token = "0x4001DD8")]
			[OriginalName("NAME_ERROR_BAD_ALPHABET")]
			NameErrorBadAlphabet,
			[Token(Token = "0x4001DD9")]
			[OriginalName("NAME_ERROR_BAD_LENGTH")]
			NameErrorBadLength,
			[Token(Token = "0x4001DDA")]
			[OriginalName("NAME_ERROR_BAD_CHAR")]
			NameErrorBadChar,
			[Token(Token = "0x4001DDB")]
			[OriginalName("NAME_ERROR_INVALID_DASH_POSITION")]
			NameErrorInvalidDashPosition,
			[Token(Token = "0x4001DDC")]
			[OriginalName("NAME_ERROR_NAME_WITH_BAD_CASE")]
			NameErrorNameWithBadCase,
			[Token(Token = "0x4001DDD")]
			[OriginalName("NAME_ERROR_TOO_MANY_CONSECUTIVE_IDENTICAL")]
			NameErrorTooManyConsecutiveIdentical,
			[Token(Token = "0x4001DDE")]
			[OriginalName("NAME_ERROR_TOO_MANY_SPECIAL")]
			NameErrorTooManySpecial,
			[Token(Token = "0x4001DDF")]
			[OriginalName("NAME_ERROR_FORBIDDEN")]
			NameErrorForbidden,
			[Token(Token = "0x4001DE0")]
			[OriginalName("NAME_ERROR_RESERVED")]
			NameErrorReserved
		}
	}

	[Token(Token = "0x4001DC7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCreationResultEvent> _parser;

	[Token(Token = "0x4001DC8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001DC9")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4001DCA")]
	[FieldOffset(Offset = "0x18")]
	private Types.CharacterCreationResult result_;

	[Token(Token = "0x4001DCB")]
	public const int ReasonFieldNumber = 2;

	[Token(Token = "0x4001DCC")]
	[FieldOffset(Offset = "0x1C")]
	private Types.NameCompliance reason_;

	[Token(Token = "0x17001377")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterCreationResultEvent> Parser
	{
		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0xB188B0", Offset = "0xB17CB0", VA = "0x180B188B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001378")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0xB18800", Offset = "0xB17C00", VA = "0x180B18800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001379")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005BA0")]
		[Address(RVA = "0xB18900", Offset = "0xB17D00", VA = "0x180B18900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700137A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.CharacterCreationResult Result
	{
		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.CharacterCreationResult);
		}
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700137B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.NameCompliance Reason
	{
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.NameCompliance);
		}
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6005BA1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCreationResultEvent()
	{
	}

	[Token(Token = "0x6005BA2")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCreationResultEvent(CharacterCreationResultEvent other)
	{
	}

	[Token(Token = "0x6005BA3")]
	[Address(RVA = "0xB18580", Offset = "0xB17980", VA = "0x180B18580", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCreationResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005BA8")]
	[Address(RVA = "0xB18610", Offset = "0xB17A10", VA = "0x180B18610", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BA9")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterCreationResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005BAA")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005BAB")]
	[Address(RVA = "0xB186A0", Offset = "0xB17AA0", VA = "0x180B186A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005BAC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005BAD")]
	[Address(RVA = "0x944F10", Offset = "0x944310", VA = "0x180944F10", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005BAE")]
	[Address(RVA = "0xB184C0", Offset = "0xB178C0", VA = "0x180B184C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005BAF")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterCreationResultEvent other)
	{
	}

	[Token(Token = "0x6005BB0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005BB1")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
