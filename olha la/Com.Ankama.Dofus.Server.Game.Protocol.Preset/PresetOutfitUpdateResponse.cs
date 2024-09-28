using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200024D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetOutfitUpdateResponse : IMessage<PresetOutfitUpdateResponse>, IMessage, IEquatable<PresetOutfitUpdateResponse>, IDeepCloneable<PresetOutfitUpdateResponse>, IBufferMessage
{
	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetOutfitUpdateResponse> _parser;

	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40007C9")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x40007CB")]
	public const int UpdatedLookFieldNumber = 2;

	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x20")]
	private PresetLook updatedLook_;

	[Token(Token = "0x170004FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetOutfitUpdateResponse> Parser
	{
		[Token(Token = "0x600176D")]
		[Address(RVA = "0xD03200", Offset = "0xD02600", VA = "0x180D03200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600176E")]
		[Address(RVA = "0xD03150", Offset = "0xD02550", VA = "0x180D03150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000500")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600176F")]
		[Address(RVA = "0xD03380", Offset = "0xD02780", VA = "0x180D03380", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000501")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSuccess
	{
		[Token(Token = "0x6001773")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000502")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetLook UpdatedLook
	{
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6001770")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOutfitUpdateResponse()
	{
	}

	[Token(Token = "0x6001771")]
	[Address(RVA = "0xD030E0", Offset = "0xD024E0", VA = "0x180D030E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetOutfitUpdateResponse(PresetOutfitUpdateResponse other)
	{
	}

	[Token(Token = "0x6001772")]
	[Address(RVA = "0xD02C90", Offset = "0xD02090", VA = "0x180D02C90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOutfitUpdateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6001777")]
	[Address(RVA = "0xD02D30", Offset = "0xD02130", VA = "0x180D02D30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001778")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetOutfitUpdateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001779")]
	[Address(RVA = "0xD02DE0", Offset = "0xD021E0", VA = "0x180D02DE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600177A")]
	[Address(RVA = "0xD02F80", Offset = "0xD02380", VA = "0x180D02F80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600177B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600177C")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600177D")]
	[Address(RVA = "0xD02BF0", Offset = "0xD01FF0", VA = "0x180D02BF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600177E")]
	[Address(RVA = "0xD02EA0", Offset = "0xD022A0", VA = "0x180D02EA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetOutfitUpdateResponse other)
	{
	}

	[Token(Token = "0x600177F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001780")]
	[Address(RVA = "0xD03250", Offset = "0xD02650", VA = "0x180D03250", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
