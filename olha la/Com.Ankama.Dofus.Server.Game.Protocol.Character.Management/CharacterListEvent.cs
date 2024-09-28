using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008B5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterListEvent : IMessage<CharacterListEvent>, IMessage, IEquatable<CharacterListEvent>, IDeepCloneable<CharacterListEvent>, IBufferMessage
{
	[Token(Token = "0x4001E09")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterListEvent> _parser;

	[Token(Token = "0x4001E0A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E0B")]
	public const int CharactersFieldNumber = 1;

	[Token(Token = "0x4001E0C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> _repeated_characters_codec;

	[Token(Token = "0x4001E0D")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> characters_;

	[Token(Token = "0x17001393")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterListEvent> Parser
	{
		[Token(Token = "0x6005C28")]
		[Address(RVA = "0xB1D0C0", Offset = "0xB1C4C0", VA = "0x180B1D0C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001394")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005C29")]
		[Address(RVA = "0xB1D010", Offset = "0xB1C410", VA = "0x180B1D010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001395")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005C2A")]
		[Address(RVA = "0xB1D2D0", Offset = "0xB1C6D0", VA = "0x180B1D2D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001396")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> Characters
	{
		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005C2B")]
	[Address(RVA = "0xB1CF90", Offset = "0xB1C390", VA = "0x180B1CF90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListEvent()
	{
	}

	[Token(Token = "0x6005C2C")]
	[Address(RVA = "0xB1CF00", Offset = "0xB1C300", VA = "0x180B1CF00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListEvent(CharacterListEvent other)
	{
	}

	[Token(Token = "0x6005C2D")]
	[Address(RVA = "0xB1CA50", Offset = "0xB1BE50", VA = "0x180B1CA50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005C2F")]
	[Address(RVA = "0xB1CB10", Offset = "0xB1BF10", VA = "0x180B1CB10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C30")]
	[Address(RVA = "0xB1CBF0", Offset = "0xB1BFF0", VA = "0x180B1CBF0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C31")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005C32")]
	[Address(RVA = "0xB1CD00", Offset = "0xB1C100", VA = "0x180B1CD00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005C33")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005C34")]
	[Address(RVA = "0xB1D220", Offset = "0xB1C620", VA = "0x180B1D220", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005C35")]
	[Address(RVA = "0xB1C9B0", Offset = "0xB1BDB0", VA = "0x180B1C9B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005C36")]
	[Address(RVA = "0xB1CC80", Offset = "0xB1C080", VA = "0x180B1CC80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterListEvent other)
	{
	}

	[Token(Token = "0x6005C37")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005C38")]
	[Address(RVA = "0xB1D110", Offset = "0xB1C510", VA = "0x180B1D110", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
