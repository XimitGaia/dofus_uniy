using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000255")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetCurrentStateResponse : IMessage<CharacterPresetCurrentStateResponse>, IMessage, IEquatable<CharacterPresetCurrentStateResponse>, IDeepCloneable<CharacterPresetCurrentStateResponse>, IBufferMessage
{
	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetCurrentStateResponse> _parser;

	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007E6")]
	public const int PresetFieldNumber = 1;

	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0x18")]
	private CharacterPresetInfo preset_;

	[Token(Token = "0x17000511")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPresetCurrentStateResponse> Parser
	{
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0xCF0030", Offset = "0xCEF430", VA = "0x180CF0030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000512")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0xCEFF80", Offset = "0xCEF380", VA = "0x180CEFF80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000513")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0xCF0180", Offset = "0xCEF580", VA = "0x180CF0180", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000514")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetInfo Preset
	{
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60017CB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetCurrentStateResponse()
	{
	}

	[Token(Token = "0x60017CC")]
	[Address(RVA = "0xCED170", Offset = "0xCEC570", VA = "0x180CED170")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetCurrentStateResponse(CharacterPresetCurrentStateResponse other)
	{
	}

	[Token(Token = "0x60017CD")]
	[Address(RVA = "0xCEFC00", Offset = "0xCEF000", VA = "0x180CEFC00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetCurrentStateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60017D0")]
	[Address(RVA = "0xCEFCA0", Offset = "0xCEF0A0", VA = "0x180CEFCA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60017D1")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterPresetCurrentStateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60017D2")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60017D3")]
	[Address(RVA = "0xCEFE20", Offset = "0xCEF220", VA = "0x180CEFE20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60017D4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60017D5")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60017D6")]
	[Address(RVA = "0xCEFB70", Offset = "0xCEEF70", VA = "0x180CEFB70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60017D7")]
	[Address(RVA = "0xCEFD50", Offset = "0xCEF150", VA = "0x180CEFD50", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterPresetCurrentStateResponse other)
	{
	}

	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60017D9")]
	[Address(RVA = "0xCF0080", Offset = "0xCEF480", VA = "0x180CF0080", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
