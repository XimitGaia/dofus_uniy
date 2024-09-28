using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200021E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetSpellUpdateResponse : IMessage<PresetSpellUpdateResponse>, IMessage, IEquatable<PresetSpellUpdateResponse>, IDeepCloneable<PresetSpellUpdateResponse>, IBufferMessage
{
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetSpellUpdateResponse> _parser;

	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000734")]
	public const int IsSuccessFieldNumber = 1;

	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x18")]
	private bool isSuccess_;

	[Token(Token = "0x17000498")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetSpellUpdateResponse> Parser
	{
		[Token(Token = "0x600157C")]
		[Address(RVA = "0xCE7D20", Offset = "0xCE7120", VA = "0x180CE7D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000499")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600157D")]
		[Address(RVA = "0xCE7C70", Offset = "0xCE7070", VA = "0x180CE7C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600157E")]
		[Address(RVA = "0xCE7D70", Offset = "0xCE7170", VA = "0x180CE7D70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSuccess
	{
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x600157F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSpellUpdateResponse()
	{
	}

	[Token(Token = "0x6001580")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetSpellUpdateResponse(PresetSpellUpdateResponse other)
	{
	}

	[Token(Token = "0x6001581")]
	[Address(RVA = "0xCE7960", Offset = "0xCE6D60", VA = "0x180CE7960", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetSpellUpdateResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6001584")]
	[Address(RVA = "0xCE79E0", Offset = "0xCE6DE0", VA = "0x180CE79E0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001585")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetSpellUpdateResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001586")]
	[Address(RVA = "0xCE7A70", Offset = "0xCE6E70", VA = "0x180CE7A70", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001587")]
	[Address(RVA = "0xCE7B10", Offset = "0xCE6F10", VA = "0x180CE7B10", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001588")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001589")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600158A")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600158B")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetSpellUpdateResponse other)
	{
	}

	[Token(Token = "0x600158C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600158D")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
