using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B14")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorLootInformation : IMessage<TaxCollectorLootInformation>, IMessage, IEquatable<TaxCollectorLootInformation>, IDeepCloneable<TaxCollectorLootInformation>, IBufferMessage
{
	[Token(Token = "0x4002923")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorLootInformation> _parser;

	[Token(Token = "0x4002924")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002925")]
	public const int PodsFieldNumber = 1;

	[Token(Token = "0x4002926")]
	[FieldOffset(Offset = "0x18")]
	private int pods_;

	[Token(Token = "0x4002927")]
	public const int ItemsKamasValueFieldNumber = 2;

	[Token(Token = "0x4002928")]
	[FieldOffset(Offset = "0x20")]
	private long itemsKamasValue_;

	[Token(Token = "0x17001998")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorLootInformation> Parser
	{
		[Token(Token = "0x6007483")]
		[Address(RVA = "0xC10CD0", Offset = "0xC100D0", VA = "0x180C10CD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001999")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007484")]
		[Address(RVA = "0xC10C20", Offset = "0xC10020", VA = "0x180C10C20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700199A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007485")]
		[Address(RVA = "0xC10D20", Offset = "0xC10120", VA = "0x180C10D20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700199B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Pods
	{
		[Token(Token = "0x6007489")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600748A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700199C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ItemsKamasValue
	{
		[Token(Token = "0x600748B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600748C")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6007486")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorLootInformation()
	{
	}

	[Token(Token = "0x6007487")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorLootInformation(TaxCollectorLootInformation other)
	{
	}

	[Token(Token = "0x6007488")]
	[Address(RVA = "0xC10990", Offset = "0xC0FD90", VA = "0x180C10990", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorLootInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600748D")]
	[Address(RVA = "0xC10A20", Offset = "0xC0FE20", VA = "0x180C10A20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600748E")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TaxCollectorLootInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600748F")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007490")]
	[Address(RVA = "0xC10AC0", Offset = "0xC0FEC0", VA = "0x180C10AC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007491")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007492")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007493")]
	[Address(RVA = "0xC108D0", Offset = "0xC0FCD0", VA = "0x180C108D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007494")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorLootInformation other)
	{
	}

	[Token(Token = "0x6007495")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007496")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
