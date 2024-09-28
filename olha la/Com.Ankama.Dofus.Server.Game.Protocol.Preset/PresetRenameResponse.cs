using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000237")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetRenameResponse : IMessage<PresetRenameResponse>, IMessage, IEquatable<PresetRenameResponse>, IDeepCloneable<PresetRenameResponse>, IBufferMessage
{
	[Token(Token = "0x2000238")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000239")]
		public enum Result
		{
			[Token(Token = "0x4000785")]
			[OriginalName("SUCCESS")]
			Success,
			[Token(Token = "0x4000786")]
			[OriginalName("PRESET_NOT_FOUND")]
			PresetNotFound,
			[Token(Token = "0x4000787")]
			[OriginalName("ERROR_NAME_SIZE")]
			ErrorNameSize,
			[Token(Token = "0x4000788")]
			[OriginalName("UNKNOWN_ERROR")]
			UnknownError,
			[Token(Token = "0x4000789")]
			[OriginalName("FEATURE_DISABLED")]
			FeatureDisabled
		}
	}

	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetRenameResponse> _parser;

	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000782")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x18")]
	private Types.Result result_;

	[Token(Token = "0x170004CE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetRenameResponse> Parser
	{
		[Token(Token = "0x6001681")]
		[Address(RVA = "0xCE6090", Offset = "0xCE5490", VA = "0x180CE6090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001682")]
		[Address(RVA = "0xCE5FE0", Offset = "0xCE53E0", VA = "0x180CE5FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001683")]
		[Address(RVA = "0xCE60E0", Offset = "0xCE54E0", VA = "0x180CE60E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Result Result
	{
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Result);
		}
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001684")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetRenameResponse()
	{
	}

	[Token(Token = "0x6001685")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetRenameResponse(PresetRenameResponse other)
	{
	}

	[Token(Token = "0x6001686")]
	[Address(RVA = "0xCE5D70", Offset = "0xCE5170", VA = "0x180CE5D70", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetRenameResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6001689")]
	[Address(RVA = "0xCE5DF0", Offset = "0xCE51F0", VA = "0x180CE5DF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600168A")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetRenameResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600168B")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600168C")]
	[Address(RVA = "0xCE5E80", Offset = "0xCE5280", VA = "0x180CE5E80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600168D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600168E")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600168F")]
	[Address(RVA = "0xCE5CE0", Offset = "0xCE50E0", VA = "0x180CE5CE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001690")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetRenameResponse other)
	{
	}

	[Token(Token = "0x6001691")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001692")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
