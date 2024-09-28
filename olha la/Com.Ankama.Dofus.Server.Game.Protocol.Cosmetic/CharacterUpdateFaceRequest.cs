using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BE7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterUpdateFaceRequest : IMessage<CharacterUpdateFaceRequest>, IMessage, IEquatable<CharacterUpdateFaceRequest>, IDeepCloneable<CharacterUpdateFaceRequest>, IBufferMessage
{
	[Token(Token = "0x4002C2A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterUpdateFaceRequest> _parser;

	[Token(Token = "0x4002C2B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C2C")]
	public const int FaceIdFieldNumber = 1;

	[Token(Token = "0x4002C2D")]
	[FieldOffset(Offset = "0x18")]
	private int faceId_;

	[Token(Token = "0x4002C2E")]
	public const int SlotFieldNumber = 2;

	[Token(Token = "0x4002C2F")]
	[FieldOffset(Offset = "0x1C")]
	private int slot_;

	[Token(Token = "0x17001B7B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterUpdateFaceRequest> Parser
	{
		[Token(Token = "0x6007D16")]
		[Address(RVA = "0xC582B0", Offset = "0xC576B0", VA = "0x180C582B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B7C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007D17")]
		[Address(RVA = "0xC58200", Offset = "0xC57600", VA = "0x180C58200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B7D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007D18")]
		[Address(RVA = "0xC58300", Offset = "0xC57700", VA = "0x180C58300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B7E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FaceId
	{
		[Token(Token = "0x6007D1C")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D1D")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001B7F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Slot
	{
		[Token(Token = "0x6007D1E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D1F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6007D19")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterUpdateFaceRequest()
	{
	}

	[Token(Token = "0x6007D1A")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterUpdateFaceRequest(CharacterUpdateFaceRequest other)
	{
	}

	[Token(Token = "0x6007D1B")]
	[Address(RVA = "0xC57F80", Offset = "0xC57380", VA = "0x180C57F80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterUpdateFaceRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007D20")]
	[Address(RVA = "0xC58010", Offset = "0xC57410", VA = "0x180C58010", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D21")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterUpdateFaceRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D22")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007D23")]
	[Address(RVA = "0xC580A0", Offset = "0xC574A0", VA = "0x180C580A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007D24")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007D25")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007D26")]
	[Address(RVA = "0xC57EC0", Offset = "0xC572C0", VA = "0x180C57EC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007D27")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterUpdateFaceRequest other)
	{
	}

	[Token(Token = "0x6007D28")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007D29")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
