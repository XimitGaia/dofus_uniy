using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001E7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetCreateRequest : IMessage<CharacterPresetCreateRequest>, IMessage, IEquatable<CharacterPresetCreateRequest>, IDeepCloneable<CharacterPresetCreateRequest>, IBufferMessage
{
	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetCreateRequest> _parser;

	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400067A")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x400067C")]
	public const int SymbolIdFieldNumber = 2;

	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0x20")]
	private int symbolId_;

	[Token(Token = "0x400067E")]
	public const int OriginFieldNumber = 3;

	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x28")]
	private PresetOrigin origin_;

	[Token(Token = "0x17000426")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPresetCreateRequest> Parser
	{
		[Token(Token = "0x6001365")]
		[Address(RVA = "0xCD8D00", Offset = "0xCD8100", VA = "0x180CD8D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000427")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001366")]
		[Address(RVA = "0xCD8C50", Offset = "0xCD8050", VA = "0x180CD8C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000428")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001367")]
		[Address(RVA = "0xCD8EB0", Offset = "0xCD82B0", VA = "0x180CD8EB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000429")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600136C")]
		[Address(RVA = "0xCD8F90", Offset = "0xCD8390", VA = "0x180CD8F90")]
		set
		{
		}
	}

	[Token(Token = "0x1700042A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SymbolId
	{
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x1700042B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOrigin Origin
	{
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6001368")]
	[Address(RVA = "0xCD8C00", Offset = "0xCD8000", VA = "0x180CD8C00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetCreateRequest()
	{
	}

	[Token(Token = "0x6001369")]
	[Address(RVA = "0xCD8B30", Offset = "0xCD7F30", VA = "0x180CD8B30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetCreateRequest(CharacterPresetCreateRequest other)
	{
	}

	[Token(Token = "0x600136A")]
	[Address(RVA = "0xCD8720", Offset = "0xCD7B20", VA = "0x180CD8720", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetCreateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001371")]
	[Address(RVA = "0xCD8810", Offset = "0xCD7C10", VA = "0x180CD8810", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001372")]
	[Address(RVA = "0xBBC040", Offset = "0xBBB440", VA = "0x180BBC040", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterPresetCreateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001373")]
	[Address(RVA = "0xBBC190", Offset = "0xBBB590", VA = "0x180BBC190", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001374")]
	[Address(RVA = "0xCD89D0", Offset = "0xCD7DD0", VA = "0x180CD89D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001375")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001376")]
	[Address(RVA = "0xBBC940", Offset = "0xBBBD40", VA = "0x180BBC940", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001377")]
	[Address(RVA = "0xCD8630", Offset = "0xCD7A30", VA = "0x180CD8630", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001378")]
	[Address(RVA = "0xCD88E0", Offset = "0xCD7CE0", VA = "0x180CD88E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterPresetCreateRequest other)
	{
	}

	[Token(Token = "0x6001379")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600137A")]
	[Address(RVA = "0xCD8D50", Offset = "0xCD8150", VA = "0x180CD8D50", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
