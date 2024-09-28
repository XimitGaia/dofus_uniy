using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000207")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetResetResponse : IMessage<CharacterPresetResetResponse>, IMessage, IEquatable<CharacterPresetResetResponse>, IDeepCloneable<CharacterPresetResetResponse>, IBufferMessage
{
	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetResetResponse> _parser;

	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006E4")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x40006E6")]
	public const int PresetInfoFieldNumber = 2;

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x20")]
	private CharacterPresetInfo presetInfo_;

	[Token(Token = "0x17000469")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPresetResetResponse> Parser
	{
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0xCDAE70", Offset = "0xCDA270", VA = "0x180CDAE70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700046A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0xCDADC0", Offset = "0xCDA1C0", VA = "0x180CDADC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700046B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0xCDAFF0", Offset = "0xCDA3F0", VA = "0x180CDAFF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700046C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSuccess
	{
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x1700046D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetInfo PresetInfo
	{
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetResetResponse()
	{
	}

	[Token(Token = "0x60014A5")]
	[Address(RVA = "0xCDAD50", Offset = "0xCDA150", VA = "0x180CDAD50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetResetResponse(CharacterPresetResetResponse other)
	{
	}

	[Token(Token = "0x60014A6")]
	[Address(RVA = "0xCDA900", Offset = "0xCD9D00", VA = "0x180CDA900", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetResetResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60014AB")]
	[Address(RVA = "0xCDA9A0", Offset = "0xCD9DA0", VA = "0x180CDA9A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterPresetResetResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60014AD")]
	[Address(RVA = "0xCDAA50", Offset = "0xCD9E50", VA = "0x180CDAA50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60014AE")]
	[Address(RVA = "0xCDABF0", Offset = "0xCD9FF0", VA = "0x180CDABF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60014B1")]
	[Address(RVA = "0xCDA860", Offset = "0xCD9C60", VA = "0x180CDA860", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60014B2")]
	[Address(RVA = "0xCDAB10", Offset = "0xCD9F10", VA = "0x180CDAB10", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterPresetResetResponse other)
	{
	}

	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60014B4")]
	[Address(RVA = "0xCDAEC0", Offset = "0xCDA2C0", VA = "0x180CDAEC0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
