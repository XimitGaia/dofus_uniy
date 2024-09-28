using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008B3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterListWithRemodelingEvent : IMessage<CharacterListWithRemodelingEvent>, IMessage, IEquatable<CharacterListWithRemodelingEvent>, IDeepCloneable<CharacterListWithRemodelingEvent>, IBufferMessage
{
	[Token(Token = "0x4001E00")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterListWithRemodelingEvent> _parser;

	[Token(Token = "0x4001E01")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E02")]
	public const int CharactersFieldNumber = 1;

	[Token(Token = "0x4001E03")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> _repeated_characters_codec;

	[Token(Token = "0x4001E04")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> characters_;

	[Token(Token = "0x4001E05")]
	public const int CharactersToRemodelFieldNumber = 2;

	[Token(Token = "0x4001E06")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> _repeated_charactersToRemodel_codec;

	[Token(Token = "0x4001E07")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> charactersToRemodel_;

	[Token(Token = "0x1700138E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterListWithRemodelingEvent> Parser
	{
		[Token(Token = "0x6005C12")]
		[Address(RVA = "0xB1E080", Offset = "0xB1D480", VA = "0x180B1E080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700138F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005C13")]
		[Address(RVA = "0xB1DFD0", Offset = "0xB1D3D0", VA = "0x180B1DFD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001390")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005C14")]
		[Address(RVA = "0xB1E310", Offset = "0xB1D710", VA = "0x180B1E310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001391")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> Characters
	{
		[Token(Token = "0x6005C18")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001392")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> CharactersToRemodel
	{
		[Token(Token = "0x6005C19")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005C15")]
	[Address(RVA = "0xB1DF20", Offset = "0xB1D320", VA = "0x180B1DF20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListWithRemodelingEvent()
	{
	}

	[Token(Token = "0x6005C16")]
	[Address(RVA = "0xB1DE70", Offset = "0xB1D270", VA = "0x180B1DE70")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterListWithRemodelingEvent(CharacterListWithRemodelingEvent other)
	{
	}

	[Token(Token = "0x6005C17")]
	[Address(RVA = "0xB1D8D0", Offset = "0xB1CCD0", VA = "0x180B1D8D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterListWithRemodelingEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005C1A")]
	[Address(RVA = "0xB1DA60", Offset = "0xB1CE60", VA = "0x180B1DA60", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C1B")]
	[Address(RVA = "0xB1D9B0", Offset = "0xB1CDB0", VA = "0x180B1D9B0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterListWithRemodelingEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005C1C")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005C1D")]
	[Address(RVA = "0xB1DBF0", Offset = "0xB1CFF0", VA = "0x180B1DBF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005C1E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005C1F")]
	[Address(RVA = "0xB1E230", Offset = "0xB1D630", VA = "0x180B1E230", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005C20")]
	[Address(RVA = "0xB1D7F0", Offset = "0xB1CBF0", VA = "0x180B1D7F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005C21")]
	[Address(RVA = "0xB1DB50", Offset = "0xB1CF50", VA = "0x180B1DB50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterListWithRemodelingEvent other)
	{
	}

	[Token(Token = "0x6005C22")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005C23")]
	[Address(RVA = "0xB1E0D0", Offset = "0xB1D4D0", VA = "0x180B1E0D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
