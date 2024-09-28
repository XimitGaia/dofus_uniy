using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009FD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntityLook : IMessage<EntityLook>, IMessage, IEquatable<EntityLook>, IDeepCloneable<EntityLook>, IBufferMessage
{
	[Token(Token = "0x40023AC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EntityLook> _parser;

	[Token(Token = "0x40023AD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40023AE")]
	public const int BonesIdFieldNumber = 1;

	[Token(Token = "0x40023AF")]
	[FieldOffset(Offset = "0x18")]
	private int bonesId_;

	[Token(Token = "0x40023B0")]
	public const int SkinsFieldNumber = 2;

	[Token(Token = "0x40023B1")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_skins_codec;

	[Token(Token = "0x40023B2")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> skins_;

	[Token(Token = "0x40023B3")]
	public const int IndexedColorsFieldNumber = 3;

	[Token(Token = "0x40023B4")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_indexedColors_codec;

	[Token(Token = "0x40023B5")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<int> indexedColors_;

	[Token(Token = "0x40023B6")]
	public const int ScalesFieldNumber = 4;

	[Token(Token = "0x40023B7")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<int> _repeated_scales_codec;

	[Token(Token = "0x40023B8")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<int> scales_;

	[Token(Token = "0x40023B9")]
	public const int SubEntitiesFieldNumber = 5;

	[Token(Token = "0x40023BA")]
	[FieldOffset(Offset = "0x20")]
	private static readonly FieldCodec<SubEntityInformation> _repeated_subEntities_codec;

	[Token(Token = "0x40023BB")]
	[FieldOffset(Offset = "0x38")]
	private readonly RepeatedField<SubEntityInformation> subEntities_;

	[Token(Token = "0x1700166D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EntityLook> Parser
	{
		[Token(Token = "0x6006844")]
		[Address(RVA = "0xBA9C30", Offset = "0xBA9030", VA = "0x180BA9C30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700166E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006845")]
		[Address(RVA = "0xBA9B80", Offset = "0xBA8F80", VA = "0x180BA9B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700166F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006846")]
		[Address(RVA = "0xBAA040", Offset = "0xBA9440", VA = "0x180BAA040", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BonesId
	{
		[Token(Token = "0x600684A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600684B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001671")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Skins
	{
		[Token(Token = "0x600684C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001672")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> IndexedColors
	{
		[Token(Token = "0x600684D")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001673")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Scales
	{
		[Token(Token = "0x600684E")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001674")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SubEntityInformation> SubEntities
	{
		[Token(Token = "0x600684F")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006847")]
	[Address(RVA = "0xBA9940", Offset = "0xBA8D40", VA = "0x180BA9940")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook()
	{
	}

	[Token(Token = "0x6006848")]
	[Address(RVA = "0xBA9A60", Offset = "0xBA8E60", VA = "0x180BA9A60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityLook(EntityLook other)
	{
	}

	[Token(Token = "0x6006849")]
	[Address(RVA = "0xBA9100", Offset = "0xBA8500", VA = "0x180BA9100", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityLook Clone()
	{
		return null;
	}

	[Token(Token = "0x6006850")]
	[Address(RVA = "0xBA9350", Offset = "0xBA8750", VA = "0x180BA9350", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006851")]
	[Address(RVA = "0xBA9240", Offset = "0xBA8640", VA = "0x180BA9240", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EntityLook other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006852")]
	[Address(RVA = "0xBA94B0", Offset = "0xBA88B0", VA = "0x180BA94B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006853")]
	[Address(RVA = "0xBA96A0", Offset = "0xBA8AA0", VA = "0x180BA96A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006854")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006855")]
	[Address(RVA = "0xBA9EE0", Offset = "0xBA92E0", VA = "0x180BA9EE0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006856")]
	[Address(RVA = "0xBA8F90", Offset = "0xBA8390", VA = "0x180BA8F90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006857")]
	[Address(RVA = "0xBA95B0", Offset = "0xBA89B0", VA = "0x180BA95B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EntityLook other)
	{
	}

	[Token(Token = "0x6006858")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006859")]
	[Address(RVA = "0xBA9C80", Offset = "0xBA9080", VA = "0x180BA9C80", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
