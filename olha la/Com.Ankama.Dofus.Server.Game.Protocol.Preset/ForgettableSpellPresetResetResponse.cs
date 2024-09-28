using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200020B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetResetResponse : IMessage<ForgettableSpellPresetResetResponse>, IMessage, IEquatable<ForgettableSpellPresetResetResponse>, IDeepCloneable<ForgettableSpellPresetResetResponse>, IBufferMessage
{
	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetResetResponse> _parser;

	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006F0")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x40006F2")]
	public const int PresetInfoFieldNumber = 2;

	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x20")]
	private ForgettableSpellPresetInfo presetInfo_;

	[Token(Token = "0x17000472")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ForgettableSpellPresetResetResponse> Parser
	{
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0xCDF6A0", Offset = "0xCDEAA0", VA = "0x180CDF6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000473")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0xCDF5F0", Offset = "0xCDE9F0", VA = "0x180CDF5F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000474")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0xCDF820", Offset = "0xCDEC20", VA = "0x180CDF820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000475")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000476")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetInfo PresetInfo
	{
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60014D2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetResetResponse()
	{
	}

	[Token(Token = "0x60014D3")]
	[Address(RVA = "0xCDF580", Offset = "0xCDE980", VA = "0x180CDF580")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetResetResponse(ForgettableSpellPresetResetResponse other)
	{
	}

	[Token(Token = "0x60014D4")]
	[Address(RVA = "0xCDF130", Offset = "0xCDE530", VA = "0x180CDF130", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetResetResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60014D9")]
	[Address(RVA = "0xCDF1D0", Offset = "0xCDE5D0", VA = "0x180CDF1D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60014DA")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellPresetResetResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60014DB")]
	[Address(RVA = "0xCDF280", Offset = "0xCDE680", VA = "0x180CDF280", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60014DC")]
	[Address(RVA = "0xCDF420", Offset = "0xCDE820", VA = "0x180CDF420", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60014DD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60014DE")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60014DF")]
	[Address(RVA = "0xCDF090", Offset = "0xCDE490", VA = "0x180CDF090", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60014E0")]
	[Address(RVA = "0xCDF340", Offset = "0xCDE740", VA = "0x180CDF340", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ForgettableSpellPresetResetResponse other)
	{
	}

	[Token(Token = "0x60014E1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60014E2")]
	[Address(RVA = "0xCDF6F0", Offset = "0xCDEAF0", VA = "0x180CDF6F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
