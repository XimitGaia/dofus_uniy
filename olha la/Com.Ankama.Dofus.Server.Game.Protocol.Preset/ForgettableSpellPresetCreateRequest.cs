using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001F0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ForgettableSpellPresetCreateRequest : IMessage<ForgettableSpellPresetCreateRequest>, IMessage, IEquatable<ForgettableSpellPresetCreateRequest>, IDeepCloneable<ForgettableSpellPresetCreateRequest>, IBufferMessage
{
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ForgettableSpellPresetCreateRequest> _parser;

	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000698")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x400069A")]
	public const int SymbolIdFieldNumber = 2;

	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x20")]
	private int symbolId_;

	[Token(Token = "0x400069C")]
	public const int OriginFieldNumber = 3;

	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x28")]
	private PresetOrigin origin_;

	[Token(Token = "0x17000437")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ForgettableSpellPresetCreateRequest> Parser
	{
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0xCDD530", Offset = "0xCDC930", VA = "0x180CDD530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000438")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0xCDD480", Offset = "0xCDC880", VA = "0x180CDD480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000439")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0xCDD6E0", Offset = "0xCDCAE0", VA = "0x180CDD6E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700043A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0xCDD7C0", Offset = "0xCDCBC0", VA = "0x180CDD7C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700043B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SymbolId
	{
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700043C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOrigin Origin
	{
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x60013B4")]
	[Address(RVA = "0xCDD430", Offset = "0xCDC830", VA = "0x180CDD430")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetCreateRequest()
	{
	}

	[Token(Token = "0x60013B5")]
	[Address(RVA = "0xCDD360", Offset = "0xCDC760", VA = "0x180CDD360")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetCreateRequest(ForgettableSpellPresetCreateRequest other)
	{
	}

	[Token(Token = "0x60013B6")]
	[Address(RVA = "0xCDCF50", Offset = "0xCDC350", VA = "0x180CDCF50", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ForgettableSpellPresetCreateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60013BD")]
	[Address(RVA = "0xCDD040", Offset = "0xCDC440", VA = "0x180CDD040", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60013BE")]
	[Address(RVA = "0xBBC040", Offset = "0xBBB440", VA = "0x180BBC040", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ForgettableSpellPresetCreateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60013BF")]
	[Address(RVA = "0xBBC190", Offset = "0xBBB590", VA = "0x180BBC190", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60013C0")]
	[Address(RVA = "0xCDD200", Offset = "0xCDC600", VA = "0x180CDD200", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60013C2")]
	[Address(RVA = "0xBBC940", Offset = "0xBBBD40", VA = "0x180BBC940", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60013C3")]
	[Address(RVA = "0xCDCE60", Offset = "0xCDC260", VA = "0x180CDCE60", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60013C4")]
	[Address(RVA = "0xCDD110", Offset = "0xCDC510", VA = "0x180CDD110", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ForgettableSpellPresetCreateRequest other)
	{
	}

	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60013C6")]
	[Address(RVA = "0xCDD580", Offset = "0xCDC980", VA = "0x180CDD580", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
