using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000211")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetUseRequest : IMessage<PresetUseRequest>, IMessage, IEquatable<PresetUseRequest>, IDeepCloneable<PresetUseRequest>, IBufferMessage
{
	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetUseRequest> _parser;

	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000703")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x4000705")]
	public const int PresetTypeFieldNumber = 2;

	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x20")]
	private PresetType presetType_;

	[Token(Token = "0x17000480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetUseRequest> Parser
	{
		[Token(Token = "0x6001515")]
		[Address(RVA = "0xCEA720", Offset = "0xCE9B20", VA = "0x180CEA720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000481")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001516")]
		[Address(RVA = "0xCEA670", Offset = "0xCE9A70", VA = "0x180CEA670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000482")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001517")]
		[Address(RVA = "0xCEA840", Offset = "0xCE9C40", VA = "0x180CEA840", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000483")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUuid
	{
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600151C")]
		[Address(RVA = "0xCEA920", Offset = "0xCE9D20", VA = "0x180CEA920")]
		set
		{
		}
	}

	[Token(Token = "0x17000484")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetType PresetType
	{
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(PresetType);
		}
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6001518")]
	[Address(RVA = "0xCEA620", Offset = "0xCE9A20", VA = "0x180CEA620")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetUseRequest()
	{
	}

	[Token(Token = "0x6001519")]
	[Address(RVA = "0xCEA570", Offset = "0xCE9970", VA = "0x180CEA570")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetUseRequest(PresetUseRequest other)
	{
	}

	[Token(Token = "0x600151A")]
	[Address(RVA = "0xCEA220", Offset = "0xCE9620", VA = "0x180CEA220", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetUseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600151F")]
	[Address(RVA = "0xCEA2F0", Offset = "0xCE96F0", VA = "0x180CEA2F0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001520")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetUseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001521")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001522")]
	[Address(RVA = "0xCEA410", Offset = "0xCE9810", VA = "0x180CEA410", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001523")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001524")]
	[Address(RVA = "0x958970", Offset = "0x957D70", VA = "0x180958970", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001525")]
	[Address(RVA = "0xCEA160", Offset = "0xCE9560", VA = "0x180CEA160", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001526")]
	[Address(RVA = "0xCEA3A0", Offset = "0xCE97A0", VA = "0x180CEA3A0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetUseRequest other)
	{
	}

	[Token(Token = "0x6001527")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001528")]
	[Address(RVA = "0xCEA770", Offset = "0xCE9B70", VA = "0x180CEA770", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
