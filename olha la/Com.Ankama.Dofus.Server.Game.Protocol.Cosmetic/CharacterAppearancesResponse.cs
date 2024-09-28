using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BE1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterAppearancesResponse : IMessage<CharacterAppearancesResponse>, IMessage, IEquatable<CharacterAppearancesResponse>, IDeepCloneable<CharacterAppearancesResponse>, IBufferMessage
{
	[Token(Token = "0x4002C16")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterAppearancesResponse> _parser;

	[Token(Token = "0x4002C17")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C18")]
	public const int CharacterFacesFieldNumber = 1;

	[Token(Token = "0x4002C19")]
	[FieldOffset(Offset = "0x18")]
	private CharacterFaces characterFaces_;

	[Token(Token = "0x17001B6D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterAppearancesResponse> Parser
	{
		[Token(Token = "0x6007CD1")]
		[Address(RVA = "0xC36440", Offset = "0xC35840", VA = "0x180C36440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B6E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007CD2")]
		[Address(RVA = "0xC36390", Offset = "0xC35790", VA = "0x180C36390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B6F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007CD3")]
		[Address(RVA = "0xC36590", Offset = "0xC35990", VA = "0x180C36590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterFaces CharacterFaces
	{
		[Token(Token = "0x6007CD7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007CD8")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6007CD4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterAppearancesResponse()
	{
	}

	[Token(Token = "0x6007CD5")]
	[Address(RVA = "0xC357F0", Offset = "0xC34BF0", VA = "0x180C357F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterAppearancesResponse(CharacterAppearancesResponse other)
	{
	}

	[Token(Token = "0x6007CD6")]
	[Address(RVA = "0xC36010", Offset = "0xC35410", VA = "0x180C36010", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterAppearancesResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6007CD9")]
	[Address(RVA = "0xC360B0", Offset = "0xC354B0", VA = "0x180C360B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CDA")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterAppearancesResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CDB")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007CDC")]
	[Address(RVA = "0xC36230", Offset = "0xC35630", VA = "0x180C36230", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007CDD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007CDE")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007CDF")]
	[Address(RVA = "0xC35F80", Offset = "0xC35380", VA = "0x180C35F80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007CE0")]
	[Address(RVA = "0xC36160", Offset = "0xC35560", VA = "0x180C36160", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterAppearancesResponse other)
	{
	}

	[Token(Token = "0x6007CE1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007CE2")]
	[Address(RVA = "0xC36490", Offset = "0xC35890", VA = "0x180C36490", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
