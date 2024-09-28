using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000249")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetInfoResponse : IMessage<ForgettableSpellPresetInfoResponse>, IMessage, IEquatable<ForgettableSpellPresetInfoResponse>, IDeepCloneable<ForgettableSpellPresetInfoResponse>, IBufferMessage
{
	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetInfoResponse> _parser;

	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007BA")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x40007BC")]
	public const int InfoFieldNumber = 2;

	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x20")]
	private ForgettableSpellPresetInfo info_;

	[Token(Token = "0x170004F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ForgettableSpellPresetInfoResponse> Parser
	{
		[Token(Token = "0x600173B")]
		[Address(RVA = "0xCF1FA0", Offset = "0xCF13A0", VA = "0x180CF1FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600173C")]
		[Address(RVA = "0xCF1EF0", Offset = "0xCF12F0", VA = "0x180CF1EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600173D")]
		[Address(RVA = "0xCF2120", Offset = "0xCF1520", VA = "0x180CF2120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		[Token(Token = "0x6001741")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001742")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x170004F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetInfo Info
	{
		[Token(Token = "0x6001743")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001744")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600173E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetInfoResponse()
	{
	}

	[Token(Token = "0x600173F")]
	[Address(RVA = "0xCDF580", Offset = "0xCDE980", VA = "0x180CDF580")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetInfoResponse(ForgettableSpellPresetInfoResponse other)
	{
	}

	[Token(Token = "0x6001740")]
	[Address(RVA = "0xCF1AA0", Offset = "0xCF0EA0", VA = "0x180CF1AA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetInfoResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6001745")]
	[Address(RVA = "0xCF1B40", Offset = "0xCF0F40", VA = "0x180CF1B40", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001746")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellPresetInfoResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001747")]
	[Address(RVA = "0xCF1BF0", Offset = "0xCF0FF0", VA = "0x180CF1BF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001748")]
	[Address(RVA = "0xCF1D90", Offset = "0xCF1190", VA = "0x180CF1D90", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001749")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600174A")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600174B")]
	[Address(RVA = "0xCF1A00", Offset = "0xCF0E00", VA = "0x180CF1A00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600174C")]
	[Address(RVA = "0xCF1CB0", Offset = "0xCF10B0", VA = "0x180CF1CB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ForgettableSpellPresetInfoResponse other)
	{
	}

	[Token(Token = "0x600174D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600174E")]
	[Address(RVA = "0xCF1FF0", Offset = "0xCF13F0", VA = "0x180CF1FF0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
