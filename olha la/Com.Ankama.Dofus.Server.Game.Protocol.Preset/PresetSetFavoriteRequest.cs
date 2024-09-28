using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200023F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetSetFavoriteRequest : IMessage<PresetSetFavoriteRequest>, IMessage, IEquatable<PresetSetFavoriteRequest>, IDeepCloneable<PresetSetFavoriteRequest>, IBufferMessage
{
	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetSetFavoriteRequest> _parser;

	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400079B")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x400079D")]
	public const int PresetTypeFieldNumber = 2;

	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x20")]
	private PresetType presetType_;

	[Token(Token = "0x400079F")]
	public const int IsFavoriteFieldNumber = 3;

	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x24")]
	private bool isFavorite_;

	[Token(Token = "0x170004DC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetSetFavoriteRequest> Parser
	{
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0xD03BB0", Offset = "0xD02FB0", VA = "0x180D03BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0xD03B00", Offset = "0xD02F00", VA = "0x180D03B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0xD03DA0", Offset = "0xD031A0", VA = "0x180D03DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUuid
	{
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0xD03E80", Offset = "0xD03280", VA = "0x180D03E80")]
		set
		{
		}
	}

	[Token(Token = "0x170004E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetType PresetType
	{
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(PresetType);
		}
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170004E1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsFavorite
	{
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0xA7E460", Offset = "0xA7D860", VA = "0x180A7E460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0xA7E710", Offset = "0xA7DB10", VA = "0x180A7E710")]
		set
		{
		}
	}

	[Token(Token = "0x60016CA")]
	[Address(RVA = "0xD03A00", Offset = "0xD02E00", VA = "0x180D03A00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSetFavoriteRequest()
	{
	}

	[Token(Token = "0x60016CB")]
	[Address(RVA = "0xD03A50", Offset = "0xD02E50", VA = "0x180D03A50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSetFavoriteRequest(PresetSetFavoriteRequest other)
	{
	}

	[Token(Token = "0x60016CC")]
	[Address(RVA = "0xD03520", Offset = "0xD02920", VA = "0x180D03520", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSetFavoriteRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60016D3")]
	[Address(RVA = "0xD03680", Offset = "0xD02A80", VA = "0x180D03680", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60016D4")]
	[Address(RVA = "0xD03600", Offset = "0xD02A00", VA = "0x180D03600", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetSetFavoriteRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60016D5")]
	[Address(RVA = "0xD03740", Offset = "0xD02B40", VA = "0x180D03740", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60016D6")]
	[Address(RVA = "0xD038A0", Offset = "0xD02CA0", VA = "0x180D038A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60016D8")]
	[Address(RVA = "0xD03CF0", Offset = "0xD030F0", VA = "0x180D03CF0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60016D9")]
	[Address(RVA = "0xD03460", Offset = "0xD02860", VA = "0x180D03460", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60016DA")]
	[Address(RVA = "0xD03820", Offset = "0xD02C20", VA = "0x180D03820", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetSetFavoriteRequest other)
	{
	}

	[Token(Token = "0x60016DB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60016DC")]
	[Address(RVA = "0xD03C00", Offset = "0xD03000", VA = "0x180D03C00", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
