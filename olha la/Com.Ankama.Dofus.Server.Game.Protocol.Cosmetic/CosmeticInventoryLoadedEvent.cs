using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BED")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CosmeticInventoryLoadedEvent : IMessage<CosmeticInventoryLoadedEvent>, IMessage, IEquatable<CosmeticInventoryLoadedEvent>, IDeepCloneable<CosmeticInventoryLoadedEvent>, IBufferMessage
{
	[Token(Token = "0x4002C54")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CosmeticInventoryLoadedEvent> _parser;

	[Token(Token = "0x4002C55")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C56")]
	public const int ObjectsFieldNumber = 1;

	[Token(Token = "0x4002C57")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItem> _repeated_objects_codec;

	[Token(Token = "0x4002C58")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<ObjectItem> objects_;

	[Token(Token = "0x17001B86")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CosmeticInventoryLoadedEvent> Parser
	{
		[Token(Token = "0x6007D48")]
		[Address(RVA = "0xC5A9A0", Offset = "0xC59DA0", VA = "0x180C5A9A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B87")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007D49")]
		[Address(RVA = "0xC5A8F0", Offset = "0xC59CF0", VA = "0x180C5A8F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B88")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007D4A")]
		[Address(RVA = "0xC5ABB0", Offset = "0xC59FB0", VA = "0x180C5ABB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B89")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectItem> Objects
	{
		[Token(Token = "0x6007D4E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007D4B")]
	[Address(RVA = "0xC5A7E0", Offset = "0xC59BE0", VA = "0x180C5A7E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryLoadedEvent()
	{
	}

	[Token(Token = "0x6007D4C")]
	[Address(RVA = "0xC5A860", Offset = "0xC59C60", VA = "0x180C5A860")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryLoadedEvent(CosmeticInventoryLoadedEvent other)
	{
	}

	[Token(Token = "0x6007D4D")]
	[Address(RVA = "0xC5A330", Offset = "0xC59730", VA = "0x180C5A330", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryLoadedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007D4F")]
	[Address(RVA = "0xC5A480", Offset = "0xC59880", VA = "0x180C5A480", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D50")]
	[Address(RVA = "0xC5A3F0", Offset = "0xC597F0", VA = "0x180C5A3F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CosmeticInventoryLoadedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D51")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007D52")]
	[Address(RVA = "0xC5A5E0", Offset = "0xC599E0", VA = "0x180C5A5E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007D53")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007D54")]
	[Address(RVA = "0xC5AB00", Offset = "0xC59F00", VA = "0x180C5AB00", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007D55")]
	[Address(RVA = "0xC5A290", Offset = "0xC59690", VA = "0x180C5A290", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007D56")]
	[Address(RVA = "0xC5A560", Offset = "0xC59960", VA = "0x180C5A560", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CosmeticInventoryLoadedEvent other)
	{
	}

	[Token(Token = "0x6007D57")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007D58")]
	[Address(RVA = "0xC5A9F0", Offset = "0xC59DF0", VA = "0x180C5A9F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
