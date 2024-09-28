using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001FF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetSetResponse : IMessage<ForgettableSpellPresetSetResponse>, IMessage, IEquatable<ForgettableSpellPresetSetResponse>, IDeepCloneable<ForgettableSpellPresetSetResponse>, IBufferMessage
{
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetSetResponse> _parser;

	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006CC")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x40006CE")]
	public const int PresetInfoFieldNumber = 2;

	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x20")]
	private ForgettableSpellPresetInfo presetInfo_;

	[Token(Token = "0x17000457")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ForgettableSpellPresetSetResponse> Parser
	{
		[Token(Token = "0x6001445")]
		[Address(RVA = "0xCE0800", Offset = "0xCDFC00", VA = "0x180CE0800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000458")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001446")]
		[Address(RVA = "0xCE0750", Offset = "0xCDFB50", VA = "0x180CE0750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000459")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001447")]
		[Address(RVA = "0xCE0980", Offset = "0xCDFD80", VA = "0x180CE0980", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700045A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x1700045B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetInfo PresetInfo
	{
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6001448")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetSetResponse()
	{
	}

	[Token(Token = "0x6001449")]
	[Address(RVA = "0xCDF580", Offset = "0xCDE980", VA = "0x180CDF580")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetSetResponse(ForgettableSpellPresetSetResponse other)
	{
	}

	[Token(Token = "0x600144A")]
	[Address(RVA = "0xCE0300", Offset = "0xCDF700", VA = "0x180CE0300", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetSetResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x600144F")]
	[Address(RVA = "0xCE03A0", Offset = "0xCDF7A0", VA = "0x180CE03A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001450")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellPresetSetResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001451")]
	[Address(RVA = "0xCE0450", Offset = "0xCDF850", VA = "0x180CE0450", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001452")]
	[Address(RVA = "0xCE05F0", Offset = "0xCDF9F0", VA = "0x180CE05F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001453")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001454")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001455")]
	[Address(RVA = "0xCE0260", Offset = "0xCDF660", VA = "0x180CE0260", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001456")]
	[Address(RVA = "0xCE0510", Offset = "0xCDF910", VA = "0x180CE0510", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ForgettableSpellPresetSetResponse other)
	{
	}

	[Token(Token = "0x6001457")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001458")]
	[Address(RVA = "0xCE0850", Offset = "0xCDFC50", VA = "0x180CE0850", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
