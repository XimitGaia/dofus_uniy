using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001CC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetLook : IMessage<PresetLook>, IMessage, IEquatable<PresetLook>, IDeepCloneable<PresetLook>, IBufferMessage
{
	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetLook> _parser;

	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400061C")]
	public const int LookWithOutfitFieldNumber = 1;

	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0x18")]
	private EntityLook lookWithOutfit_;

	[Token(Token = "0x400061E")]
	public const int LookWithoutOutfitFieldNumber = 2;

	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0x20")]
	private EntityLook lookWithoutOutfit_;

	[Token(Token = "0x170003E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetLook> Parser
	{
		[Token(Token = "0x6001245")]
		[Address(RVA = "0xCC4A90", Offset = "0xCC3E90", VA = "0x180CC4A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003E9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001246")]
		[Address(RVA = "0xCC49E0", Offset = "0xCC3DE0", VA = "0x180CC49E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003EA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001247")]
		[Address(RVA = "0xCC4C30", Offset = "0xCC4030", VA = "0x180CC4C30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook LookWithOutfit
	{
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x170003EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook LookWithoutOutfit
	{
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600124E")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6001248")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetLook()
	{
	}

	[Token(Token = "0x6001249")]
	[Address(RVA = "0xCC4940", Offset = "0xCC3D40", VA = "0x180CC4940")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetLook(PresetLook other)
	{
	}

	[Token(Token = "0x600124A")]
	[Address(RVA = "0xCC4530", Offset = "0xCC3930", VA = "0x180CC4530", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetLook Clone()
	{
		return null;
	}

	[Token(Token = "0x600124F")]
	[Address(RVA = "0xCC4600", Offset = "0xCC3A00", VA = "0x180CC4600", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001250")]
	[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetLook other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001251")]
	[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001252")]
	[Address(RVA = "0xCC47E0", Offset = "0xCC3BE0", VA = "0x180CC47E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001253")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001254")]
	[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001255")]
	[Address(RVA = "0xCC4470", Offset = "0xCC3870", VA = "0x180CC4470", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001256")]
	[Address(RVA = "0xCC46C0", Offset = "0xCC3AC0", VA = "0x180CC46C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetLook other)
	{
	}

	[Token(Token = "0x6001257")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001258")]
	[Address(RVA = "0xCC4AE0", Offset = "0xCC3EE0", VA = "0x180CC4AE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
