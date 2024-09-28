using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BF9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CosmeticInventoryAddedEvent : IMessage<CosmeticInventoryAddedEvent>, IMessage, IEquatable<CosmeticInventoryAddedEvent>, IDeepCloneable<CosmeticInventoryAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4002C72")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CosmeticInventoryAddedEvent> _parser;

	[Token(Token = "0x4002C73")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C74")]
	public const int ObjectFieldNumber = 1;

	[Token(Token = "0x4002C75")]
	[FieldOffset(Offset = "0x18")]
	private ObjectItem object_;

	[Token(Token = "0x17001B9A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CosmeticInventoryAddedEvent> Parser
	{
		[Token(Token = "0x6007DB5")]
		[Address(RVA = "0xC592D0", Offset = "0xC586D0", VA = "0x180C592D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B9B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007DB6")]
		[Address(RVA = "0xC59220", Offset = "0xC58620", VA = "0x180C59220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B9C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007DB7")]
		[Address(RVA = "0xC59420", Offset = "0xC58820", VA = "0x180C59420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B9D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItem Object
	{
		[Token(Token = "0x6007DBB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007DBC")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6007DB8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CosmeticInventoryAddedEvent()
	{
	}

	[Token(Token = "0x6007DB9")]
	[Address(RVA = "0xC591B0", Offset = "0xC585B0", VA = "0x180C591B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryAddedEvent(CosmeticInventoryAddedEvent other)
	{
	}

	[Token(Token = "0x6007DBA")]
	[Address(RVA = "0xC58E30", Offset = "0xC58230", VA = "0x180C58E30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CosmeticInventoryAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007DBD")]
	[Address(RVA = "0xC58ED0", Offset = "0xC582D0", VA = "0x180C58ED0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007DBE")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CosmeticInventoryAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007DBF")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007DC0")]
	[Address(RVA = "0xC59050", Offset = "0xC58450", VA = "0x180C59050", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007DC1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007DC2")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007DC3")]
	[Address(RVA = "0xC58DA0", Offset = "0xC581A0", VA = "0x180C58DA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007DC4")]
	[Address(RVA = "0xC58F80", Offset = "0xC58380", VA = "0x180C58F80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CosmeticInventoryAddedEvent other)
	{
	}

	[Token(Token = "0x6007DC5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007DC6")]
	[Address(RVA = "0xC59320", Offset = "0xC58720", VA = "0x180C59320", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
