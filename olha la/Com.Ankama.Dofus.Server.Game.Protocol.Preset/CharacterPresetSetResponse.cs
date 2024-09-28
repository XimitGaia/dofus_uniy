using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001FB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetSetResponse : IMessage<CharacterPresetSetResponse>, IMessage, IEquatable<CharacterPresetSetResponse>, IDeepCloneable<CharacterPresetSetResponse>, IBufferMessage
{
	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetSetResponse> _parser;

	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006BE")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x40006C0")]
	public const int PresetInfoFieldNumber = 2;

	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x20")]
	private CharacterPresetInfo presetInfo_;

	[Token(Token = "0x1700044D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPresetSetResponse> Parser
	{
		[Token(Token = "0x6001415")]
		[Address(RVA = "0xCDBFD0", Offset = "0xCDB3D0", VA = "0x180CDBFD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700044E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001416")]
		[Address(RVA = "0xCDBF20", Offset = "0xCDB320", VA = "0x180CDBF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700044F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001417")]
		[Address(RVA = "0xCDC150", Offset = "0xCDB550", VA = "0x180CDC150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000450")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000451")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetInfo PresetInfo
	{
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6001418")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetSetResponse()
	{
	}

	[Token(Token = "0x6001419")]
	[Address(RVA = "0xCDAD50", Offset = "0xCDA150", VA = "0x180CDAD50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetSetResponse(CharacterPresetSetResponse other)
	{
	}

	[Token(Token = "0x600141A")]
	[Address(RVA = "0xCDBAD0", Offset = "0xCDAED0", VA = "0x180CDBAD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetSetResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x600141F")]
	[Address(RVA = "0xCDBB70", Offset = "0xCDAF70", VA = "0x180CDBB70", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001420")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterPresetSetResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001421")]
	[Address(RVA = "0xCDBC20", Offset = "0xCDB020", VA = "0x180CDBC20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001422")]
	[Address(RVA = "0xCDBDC0", Offset = "0xCDB1C0", VA = "0x180CDBDC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001423")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001424")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001425")]
	[Address(RVA = "0xCDBA30", Offset = "0xCDAE30", VA = "0x180CDBA30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001426")]
	[Address(RVA = "0xCDBCE0", Offset = "0xCDB0E0", VA = "0x180CDBCE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterPresetSetResponse other)
	{
	}

	[Token(Token = "0x6001427")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001428")]
	[Address(RVA = "0xCDC020", Offset = "0xCDB420", VA = "0x180CDC020", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
