using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000247")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetInfoRequest : IMessage<ForgettableSpellPresetInfoRequest>, IMessage, IEquatable<ForgettableSpellPresetInfoRequest>, IDeepCloneable<ForgettableSpellPresetInfoRequest>, IBufferMessage
{
	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetInfoRequest> _parser;

	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007B5")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x170004EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ForgettableSpellPresetInfoRequest> Parser
	{
		[Token(Token = "0x6001725")]
		[Address(RVA = "0xCF17A0", Offset = "0xCF0BA0", VA = "0x180CF17A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001726")]
		[Address(RVA = "0xCF16F0", Offset = "0xCF0AF0", VA = "0x180CF16F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001727")]
		[Address(RVA = "0xCF18B0", Offset = "0xCF0CB0", VA = "0x180CF18B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUuid
	{
		[Token(Token = "0x600172B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600172C")]
		[Address(RVA = "0xCF1990", Offset = "0xCF0D90", VA = "0x180CF1990")]
		set
		{
		}
	}

	[Token(Token = "0x6001728")]
	[Address(RVA = "0xCF16A0", Offset = "0xCF0AA0", VA = "0x180CF16A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetInfoRequest()
	{
	}

	[Token(Token = "0x6001729")]
	[Address(RVA = "0xCF1600", Offset = "0xCF0A00", VA = "0x180CF1600")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ForgettableSpellPresetInfoRequest(ForgettableSpellPresetInfoRequest other)
	{
	}

	[Token(Token = "0x600172A")]
	[Address(RVA = "0xCF12C0", Offset = "0xCF06C0", VA = "0x180CF12C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetInfoRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600172D")]
	[Address(RVA = "0xCF1390", Offset = "0xCF0790", VA = "0x180CF1390", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600172E")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellPresetInfoRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600172F")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001730")]
	[Address(RVA = "0xCF14A0", Offset = "0xCF08A0", VA = "0x180CF14A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001731")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001732")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001733")]
	[Address(RVA = "0xCF1230", Offset = "0xCF0630", VA = "0x180CF1230", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001734")]
	[Address(RVA = "0xCF1440", Offset = "0xCF0840", VA = "0x180CF1440", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ForgettableSpellPresetInfoRequest other)
	{
	}

	[Token(Token = "0x6001735")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001736")]
	[Address(RVA = "0xCF17F0", Offset = "0xCF0BF0", VA = "0x180CF17F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
