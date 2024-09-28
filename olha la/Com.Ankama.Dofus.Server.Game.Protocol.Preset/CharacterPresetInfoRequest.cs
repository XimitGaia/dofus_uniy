using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000243")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetInfoRequest : IMessage<CharacterPresetInfoRequest>, IMessage, IEquatable<CharacterPresetInfoRequest>, IDeepCloneable<CharacterPresetInfoRequest>, IBufferMessage
{
	[Token(Token = "0x40007A7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetInfoRequest> _parser;

	[Token(Token = "0x40007A8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007A9")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x40007AA")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x170004E6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPresetInfoRequest> Parser
	{
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0xCF07D0", Offset = "0xCEFBD0", VA = "0x180CF07D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0xCF0720", Offset = "0xCEFB20", VA = "0x180CF0720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0xCF08E0", Offset = "0xCEFCE0", VA = "0x180CF08E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUuid
	{
		[Token(Token = "0x60016FD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0xCF09C0", Offset = "0xCEFDC0", VA = "0x180CF09C0")]
		set
		{
		}
	}

	[Token(Token = "0x60016FA")]
	[Address(RVA = "0xCF0630", Offset = "0xCEFA30", VA = "0x180CF0630")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetInfoRequest()
	{
	}

	[Token(Token = "0x60016FB")]
	[Address(RVA = "0xCF0680", Offset = "0xCEFA80", VA = "0x180CF0680")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetInfoRequest(CharacterPresetInfoRequest other)
	{
	}

	[Token(Token = "0x60016FC")]
	[Address(RVA = "0xCF02F0", Offset = "0xCEF6F0", VA = "0x180CF02F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetInfoRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60016FF")]
	[Address(RVA = "0xCF03C0", Offset = "0xCEF7C0", VA = "0x180CF03C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001700")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterPresetInfoRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001701")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001702")]
	[Address(RVA = "0xCF04D0", Offset = "0xCEF8D0", VA = "0x180CF04D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001703")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001704")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001705")]
	[Address(RVA = "0xCF0260", Offset = "0xCEF660", VA = "0x180CF0260", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001706")]
	[Address(RVA = "0xCF0470", Offset = "0xCEF870", VA = "0x180CF0470", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterPresetInfoRequest other)
	{
	}

	[Token(Token = "0x6001707")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001708")]
	[Address(RVA = "0xCF0820", Offset = "0xCEFC20", VA = "0x180CF0820", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
