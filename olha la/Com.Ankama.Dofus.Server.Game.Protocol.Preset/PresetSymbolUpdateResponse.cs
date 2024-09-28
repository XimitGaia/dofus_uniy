using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200023D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetSymbolUpdateResponse : IMessage<PresetSymbolUpdateResponse>, IMessage, IEquatable<PresetSymbolUpdateResponse>, IDeepCloneable<PresetSymbolUpdateResponse>, IBufferMessage
{
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetSymbolUpdateResponse> _parser;

	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000796")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x170004D8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetSymbolUpdateResponse> Parser
	{
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0xCEA030", Offset = "0xCE9430", VA = "0x180CEA030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004D9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0xCE9F80", Offset = "0xCE9380", VA = "0x180CE9F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0xCEA080", Offset = "0xCE9480", VA = "0x180CEA080", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSuccess
	{
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSymbolUpdateResponse()
	{
	}

	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSymbolUpdateResponse(PresetSymbolUpdateResponse other)
	{
	}

	[Token(Token = "0x60016B6")]
	[Address(RVA = "0xCE9C70", Offset = "0xCE9070", VA = "0x180CE9C70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSymbolUpdateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x60016B9")]
	[Address(RVA = "0xCE9CF0", Offset = "0xCE90F0", VA = "0x180CE9CF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetSymbolUpdateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x60016BB")]
	[Address(RVA = "0xCE9D80", Offset = "0xCE9180", VA = "0x180CE9D80", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60016BC")]
	[Address(RVA = "0xCE9E20", Offset = "0xCE9220", VA = "0x180CE9E20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetSymbolUpdateResponse other)
	{
	}

	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
