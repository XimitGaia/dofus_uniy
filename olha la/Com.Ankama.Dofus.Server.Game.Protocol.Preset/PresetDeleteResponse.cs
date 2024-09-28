using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200020F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetDeleteResponse : IMessage<PresetDeleteResponse>, IMessage, IEquatable<PresetDeleteResponse>, IDeepCloneable<PresetDeleteResponse>, IBufferMessage
{
	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetDeleteResponse> _parser;

	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006FE")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x1700047C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetDeleteResponse> Parser
	{
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0xCE2DD0", Offset = "0xCE21D0", VA = "0x180CE2DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001500")]
		[Address(RVA = "0xCE2D20", Offset = "0xCE2120", VA = "0x180CE2D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001501")]
		[Address(RVA = "0xCE2E20", Offset = "0xCE2220", VA = "0x180CE2E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6001502")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDeleteResponse()
	{
	}

	[Token(Token = "0x6001503")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDeleteResponse(PresetDeleteResponse other)
	{
	}

	[Token(Token = "0x6001504")]
	[Address(RVA = "0xCE2A10", Offset = "0xCE1E10", VA = "0x180CE2A10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDeleteResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6001507")]
	[Address(RVA = "0xCE2A90", Offset = "0xCE1E90", VA = "0x180CE2A90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001508")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetDeleteResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001509")]
	[Address(RVA = "0xCE2B20", Offset = "0xCE1F20", VA = "0x180CE2B20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600150A")]
	[Address(RVA = "0xCE2BC0", Offset = "0xCE1FC0", VA = "0x180CE2BC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600150B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600150C")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600150D")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600150E")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetDeleteResponse other)
	{
	}

	[Token(Token = "0x600150F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001510")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
