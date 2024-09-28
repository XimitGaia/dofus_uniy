using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000235")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetRenameRequest : IMessage<PresetRenameRequest>, IMessage, IEquatable<PresetRenameRequest>, IDeepCloneable<PresetRenameRequest>, IBufferMessage
{
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetRenameRequest> _parser;

	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000779")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x400077B")]
	public const int PresetTypeFieldNumber = 2;

	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x20")]
	private PresetType presetType_;

	[Token(Token = "0x400077D")]
	public const int NameFieldNumber = 3;

	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x28")]
	private string name_;

	[Token(Token = "0x170004C8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetRenameRequest> Parser
	{
		[Token(Token = "0x6001667")]
		[Address(RVA = "0xCE5910", Offset = "0xCE4D10", VA = "0x180CE5910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001668")]
		[Address(RVA = "0xCE5860", Offset = "0xCE4C60", VA = "0x180CE5860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001669")]
		[Address(RVA = "0xCE5B20", Offset = "0xCE4F20", VA = "0x180CE5B20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PresetUuid
	{
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600166E")]
		[Address(RVA = "0xCE5C70", Offset = "0xCE5070", VA = "0x180CE5C70")]
		set
		{
		}
	}

	[Token(Token = "0x170004CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetType PresetType
	{
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(PresetType);
		}
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170004CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001672")]
		[Address(RVA = "0xCE5C00", Offset = "0xCE5000", VA = "0x180CE5C00")]
		set
		{
		}
	}

	[Token(Token = "0x600166A")]
	[Address(RVA = "0xCE57F0", Offset = "0xCE4BF0", VA = "0x180CE57F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetRenameRequest()
	{
	}

	[Token(Token = "0x600166B")]
	[Address(RVA = "0xCE5710", Offset = "0xCE4B10", VA = "0x180CE5710")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetRenameRequest(PresetRenameRequest other)
	{
	}

	[Token(Token = "0x600166C")]
	[Address(RVA = "0xCE5200", Offset = "0xCE4600", VA = "0x180CE5200", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetRenameRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001673")]
	[Address(RVA = "0xCE5310", Offset = "0xCE4710", VA = "0x180CE5310", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001674")]
	[Address(RVA = "0xCE53E0", Offset = "0xCE47E0", VA = "0x180CE53E0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetRenameRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001675")]
	[Address(RVA = "0xCE5460", Offset = "0xCE4860", VA = "0x180CE5460", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001676")]
	[Address(RVA = "0xCE55B0", Offset = "0xCE49B0", VA = "0x180CE55B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001677")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001678")]
	[Address(RVA = "0xCE5A70", Offset = "0xCE4E70", VA = "0x180CE5A70", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001679")]
	[Address(RVA = "0xCE5110", Offset = "0xCE4510", VA = "0x180CE5110", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600167A")]
	[Address(RVA = "0xCE5520", Offset = "0xCE4920", VA = "0x180CE5520", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetRenameRequest other)
	{
	}

	[Token(Token = "0x600167B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600167C")]
	[Address(RVA = "0xCE5960", Offset = "0xCE4D60", VA = "0x180CE5960", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
