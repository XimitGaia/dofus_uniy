using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BE5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterFaces : IMessage<CharacterFaces>, IMessage, IEquatable<CharacterFaces>, IDeepCloneable<CharacterFaces>, IBufferMessage
{
	[Token(Token = "0x4002C20")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterFaces> _parser;

	[Token(Token = "0x4002C21")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C22")]
	public const int SlotsFieldNumber = 1;

	[Token(Token = "0x4002C23")]
	[FieldOffset(Offset = "0x18")]
	private int slots_;

	[Token(Token = "0x4002C24")]
	public const int FacesFieldNumber = 2;

	[Token(Token = "0x4002C25")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_faces_codec;

	[Token(Token = "0x4002C26")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> faces_;

	[Token(Token = "0x4002C27")]
	public const int MaxSlotsFieldNumber = 3;

	[Token(Token = "0x4002C28")]
	[FieldOffset(Offset = "0x28")]
	private int maxSlots_;

	[Token(Token = "0x17001B75")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterFaces> Parser
	{
		[Token(Token = "0x6007CFD")]
		[Address(RVA = "0xC36DD0", Offset = "0xC361D0", VA = "0x180C36DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B76")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007CFE")]
		[Address(RVA = "0xC36D20", Offset = "0xC36120", VA = "0x180C36D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B77")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007CFF")]
		[Address(RVA = "0xC37060", Offset = "0xC36460", VA = "0x180C37060", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B78")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Slots
	{
		[Token(Token = "0x6007D03")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D04")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001B79")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Faces
	{
		[Token(Token = "0x6007D05")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B7A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxSlots
	{
		[Token(Token = "0x6007D06")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D07")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6007D00")]
	[Address(RVA = "0xC36C00", Offset = "0xC36000", VA = "0x180C36C00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterFaces()
	{
	}

	[Token(Token = "0x6007D01")]
	[Address(RVA = "0xC36C80", Offset = "0xC36080", VA = "0x180C36C80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterFaces(CharacterFaces other)
	{
	}

	[Token(Token = "0x6007D02")]
	[Address(RVA = "0xC36780", Offset = "0xC35B80", VA = "0x180C36780", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterFaces Clone()
	{
		return null;
	}

	[Token(Token = "0x6007D08")]
	[Address(RVA = "0xC368F0", Offset = "0xC35CF0", VA = "0x180C368F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D09")]
	[Address(RVA = "0xC36850", Offset = "0xC35C50", VA = "0x180C36850", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterFaces other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D0A")]
	[Address(RVA = "0xC2E920", Offset = "0xC2DD20", VA = "0x180C2E920", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007D0B")]
	[Address(RVA = "0xC36A70", Offset = "0xC35E70", VA = "0x180C36A70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007D0C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007D0D")]
	[Address(RVA = "0xC36F70", Offset = "0xC36370", VA = "0x180C36F70", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007D0E")]
	[Address(RVA = "0xC36670", Offset = "0xC35A70", VA = "0x180C36670", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007D0F")]
	[Address(RVA = "0xC369E0", Offset = "0xC35DE0", VA = "0x180C369E0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterFaces other)
	{
	}

	[Token(Token = "0x6007D10")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007D11")]
	[Address(RVA = "0xC36E20", Offset = "0xC36220", VA = "0x180C36E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
