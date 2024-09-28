using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x200020D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetDeleteRequest : IMessage<PresetDeleteRequest>, IMessage, IEquatable<PresetDeleteRequest>, IDeepCloneable<PresetDeleteRequest>, IBufferMessage
{
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetDeleteRequest> _parser;

	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006F7")]
	public const int PresetUuidFieldNumber = 1;

	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x18")]
	private string presetUuid_;

	[Token(Token = "0x40006F9")]
	public const int PresetTypeFieldNumber = 2;

	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x20")]
	private PresetType presetType_;

	[Token(Token = "0x17000477")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetDeleteRequest> Parser
	{
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0xCE27A0", Offset = "0xCE1BA0", VA = "0x180CE27A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000478")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0xCE26F0", Offset = "0xCE1AF0", VA = "0x180CE26F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000479")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0xCE28C0", Offset = "0xCE1CC0", VA = "0x180CE28C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetUuid
	{
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0xCE29A0", Offset = "0xCE1DA0", VA = "0x180CE29A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700047B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetType PresetType
	{
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(PresetType);
		}
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60014EA")]
	[Address(RVA = "0xCE26A0", Offset = "0xCE1AA0", VA = "0x180CE26A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetDeleteRequest()
	{
	}

	[Token(Token = "0x60014EB")]
	[Address(RVA = "0xCE25F0", Offset = "0xCE19F0", VA = "0x180CE25F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDeleteRequest(PresetDeleteRequest other)
	{
	}

	[Token(Token = "0x60014EC")]
	[Address(RVA = "0xCE22A0", Offset = "0xCE16A0", VA = "0x180CE22A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDeleteRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60014F1")]
	[Address(RVA = "0xCE2370", Offset = "0xCE1770", VA = "0x180CE2370", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetDeleteRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60014F3")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60014F4")]
	[Address(RVA = "0xCE2490", Offset = "0xCE1890", VA = "0x180CE2490", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60014F5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60014F6")]
	[Address(RVA = "0x958970", Offset = "0x957D70", VA = "0x180958970", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60014F7")]
	[Address(RVA = "0xCE21E0", Offset = "0xCE15E0", VA = "0x180CE21E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60014F8")]
	[Address(RVA = "0xCE2420", Offset = "0xCE1820", VA = "0x180CE2420", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetDeleteRequest other)
	{
	}

	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60014FA")]
	[Address(RVA = "0xCE27F0", Offset = "0xCE1BF0", VA = "0x180CE27F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
