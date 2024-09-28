using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AD2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectUidWithQuantity : IMessage<ObjectUidWithQuantity>, IMessage, IEquatable<ObjectUidWithQuantity>, IDeepCloneable<ObjectUidWithQuantity>, IBufferMessage
{
	[Token(Token = "0x40027A2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectUidWithQuantity> _parser;

	[Token(Token = "0x40027A3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40027A4")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x40027A5")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x40027A6")]
	public const int QuantityFieldNumber = 2;

	[Token(Token = "0x40027A7")]
	[FieldOffset(Offset = "0x1C")]
	private int quantity_;

	[Token(Token = "0x170018BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ObjectUidWithQuantity> Parser
	{
		[Token(Token = "0x600715B")]
		[Address(RVA = "0xBFB410", Offset = "0xBFA810", VA = "0x180BFB410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018BC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600715C")]
		[Address(RVA = "0xBFB360", Offset = "0xBFA760", VA = "0x180BFB360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018BD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600715D")]
		[Address(RVA = "0xBFB460", Offset = "0xBFA860", VA = "0x180BFB460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x6007161")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007162")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170018BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Quantity
	{
		[Token(Token = "0x6007163")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007164")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600715E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUidWithQuantity()
	{
	}

	[Token(Token = "0x600715F")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUidWithQuantity(ObjectUidWithQuantity other)
	{
	}

	[Token(Token = "0x6007160")]
	[Address(RVA = "0xBFB0E0", Offset = "0xBFA4E0", VA = "0x180BFB0E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUidWithQuantity Clone()
	{
		return null;
	}

	[Token(Token = "0x6007165")]
	[Address(RVA = "0xBFB170", Offset = "0xBFA570", VA = "0x180BFB170", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007166")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectUidWithQuantity other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007167")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007168")]
	[Address(RVA = "0xBFB200", Offset = "0xBFA600", VA = "0x180BFB200", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007169")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600716A")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600716B")]
	[Address(RVA = "0xBFB020", Offset = "0xBFA420", VA = "0x180BFB020", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600716C")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ObjectUidWithQuantity other)
	{
	}

	[Token(Token = "0x600716D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600716E")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
