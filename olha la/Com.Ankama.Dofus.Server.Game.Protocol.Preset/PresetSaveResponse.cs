using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000203")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetSaveResponse : IMessage<PresetSaveResponse>, IMessage, IEquatable<PresetSaveResponse>, IDeepCloneable<PresetSaveResponse>, IBufferMessage
{
	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetSaveResponse> _parser;

	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006DA")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x17000461")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetSaveResponse> Parser
	{
		[Token(Token = "0x6001475")]
		[Address(RVA = "0xCE6DB0", Offset = "0xCE61B0", VA = "0x180CE6DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000462")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001476")]
		[Address(RVA = "0xCE6D00", Offset = "0xCE6100", VA = "0x180CE6D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000463")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001477")]
		[Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000464")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSuccess
	{
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6001478")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSaveResponse()
	{
	}

	[Token(Token = "0x6001479")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSaveResponse(PresetSaveResponse other)
	{
	}

	[Token(Token = "0x600147A")]
	[Address(RVA = "0xCE69F0", Offset = "0xCE5DF0", VA = "0x180CE69F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSaveResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x600147D")]
	[Address(RVA = "0xCE6A70", Offset = "0xCE5E70", VA = "0x180CE6A70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600147E")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetSaveResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600147F")]
	[Address(RVA = "0xCE6B00", Offset = "0xCE5F00", VA = "0x180CE6B00", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001480")]
	[Address(RVA = "0xCE6BA0", Offset = "0xCE5FA0", VA = "0x180CE6BA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001481")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001482")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001483")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001484")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetSaveResponse other)
	{
	}

	[Token(Token = "0x6001485")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001486")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
