using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AD6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectItem : IMessage<ObjectItem>, IMessage, IEquatable<ObjectItem>, IDeepCloneable<ObjectItem>, IBufferMessage
{
	[Token(Token = "0x40027B5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectItem> _parser;

	[Token(Token = "0x40027B6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40027B7")]
	public const int UidFieldNumber = 1;

	[Token(Token = "0x40027B8")]
	[FieldOffset(Offset = "0x18")]
	private int uid_;

	[Token(Token = "0x40027B9")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x40027BA")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x40027BB")]
	public const int GidFieldNumber = 3;

	[Token(Token = "0x40027BC")]
	[FieldOffset(Offset = "0x20")]
	private long gid_;

	[Token(Token = "0x40027BD")]
	public const int EffectsFieldNumber = 4;

	[Token(Token = "0x40027BE")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x40027BF")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x170018C7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectItem> Parser
	{
		[Token(Token = "0x600718E")]
		[Address(RVA = "0xBFA0A0", Offset = "0xBF94A0", VA = "0x180BFA0A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600718F")]
		[Address(RVA = "0xBF9FF0", Offset = "0xBF93F0", VA = "0x180BF9FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007190")]
		[Address(RVA = "0xBFA380", Offset = "0xBF9780", VA = "0x180BFA380", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Uid
	{
		[Token(Token = "0x6007194")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007195")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170018CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Quantity
	{
		[Token(Token = "0x6007196")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007197")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170018CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Gid
	{
		[Token(Token = "0x6007198")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007199")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170018CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x600719A")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007191")]
	[Address(RVA = "0xBF9ED0", Offset = "0xBF92D0", VA = "0x180BF9ED0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectItem()
	{
	}

	[Token(Token = "0x6007192")]
	[Address(RVA = "0xBF9F50", Offset = "0xBF9350", VA = "0x180BF9F50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectItem(ObjectItem other)
	{
	}

	[Token(Token = "0x6007193")]
	[Address(RVA = "0xBF99C0", Offset = "0xBF8DC0", VA = "0x180BF99C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItem Clone()
	{
		return null;
	}

	[Token(Token = "0x600719B")]
	[Address(RVA = "0xBF9A90", Offset = "0xBF8E90", VA = "0x180BF9A90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600719C")]
	[Address(RVA = "0xBF9B80", Offset = "0xBF8F80", VA = "0x180BF9B80", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ObjectItem other)
	{
		return default(bool);
	}

	[Token(Token = "0x600719D")]
	[Address(RVA = "0xA9CFE0", Offset = "0xA9C3E0", VA = "0x180A9CFE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600719E")]
	[Address(RVA = "0xBF9CD0", Offset = "0xBF90D0", VA = "0x180BF9CD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600719F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60071A0")]
	[Address(RVA = "0xBFA260", Offset = "0xBF9660", VA = "0x180BFA260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60071A1")]
	[Address(RVA = "0xBF9880", Offset = "0xBF8C80", VA = "0x180BF9880", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60071A2")]
	[Address(RVA = "0xBF9C30", Offset = "0xBF9030", VA = "0x180BF9C30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectItem other)
	{
	}

	[Token(Token = "0x60071A3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60071A4")]
	[Address(RVA = "0xBFA0F0", Offset = "0xBF94F0", VA = "0x180BFA0F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
