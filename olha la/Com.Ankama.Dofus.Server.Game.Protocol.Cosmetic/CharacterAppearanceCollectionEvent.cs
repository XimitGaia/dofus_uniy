using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BE3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterAppearanceCollectionEvent : IMessage<CharacterAppearanceCollectionEvent>, IMessage, IEquatable<CharacterAppearanceCollectionEvent>, IDeepCloneable<CharacterAppearanceCollectionEvent>, IBufferMessage
{
	[Token(Token = "0x4002C1B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterAppearanceCollectionEvent> _parser;

	[Token(Token = "0x4002C1C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C1D")]
	public const int CharacterFacesFieldNumber = 1;

	[Token(Token = "0x4002C1E")]
	[FieldOffset(Offset = "0x18")]
	private CharacterFaces characterFaces_;

	[Token(Token = "0x17001B71")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterAppearanceCollectionEvent> Parser
	{
		[Token(Token = "0x6007CE7")]
		[Address(RVA = "0xC35910", Offset = "0xC34D10", VA = "0x180C35910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B72")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007CE8")]
		[Address(RVA = "0xC35860", Offset = "0xC34C60", VA = "0x180C35860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B73")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007CE9")]
		[Address(RVA = "0xC35A60", Offset = "0xC34E60", VA = "0x180C35A60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B74")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterFaces CharacterFaces
	{
		[Token(Token = "0x6007CED")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007CEE")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6007CEA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterAppearanceCollectionEvent()
	{
	}

	[Token(Token = "0x6007CEB")]
	[Address(RVA = "0xC357F0", Offset = "0xC34BF0", VA = "0x180C357F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterAppearanceCollectionEvent(CharacterAppearanceCollectionEvent other)
	{
	}

	[Token(Token = "0x6007CEC")]
	[Address(RVA = "0xC35470", Offset = "0xC34870", VA = "0x180C35470", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterAppearanceCollectionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007CEF")]
	[Address(RVA = "0xC35510", Offset = "0xC34910", VA = "0x180C35510", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CF0")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterAppearanceCollectionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007CF1")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007CF2")]
	[Address(RVA = "0xC35690", Offset = "0xC34A90", VA = "0x180C35690", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007CF3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007CF4")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007CF5")]
	[Address(RVA = "0xC353E0", Offset = "0xC347E0", VA = "0x180C353E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007CF6")]
	[Address(RVA = "0xC355C0", Offset = "0xC349C0", VA = "0x180C355C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterAppearanceCollectionEvent other)
	{
	}

	[Token(Token = "0x6007CF7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007CF8")]
	[Address(RVA = "0xC35960", Offset = "0xC34D60", VA = "0x180C35960", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
