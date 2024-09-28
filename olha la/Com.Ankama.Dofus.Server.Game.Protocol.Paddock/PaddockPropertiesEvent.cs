using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002BD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockPropertiesEvent : IMessage<PaddockPropertiesEvent>, IMessage, IEquatable<PaddockPropertiesEvent>, IDeepCloneable<PaddockPropertiesEvent>, IBufferMessage
{
	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockPropertiesEvent> _parser;

	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40009A4")]
	public const int PropertiesFieldNumber = 1;

	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x18")]
	private PaddockInformation properties_;

	[Token(Token = "0x17000627")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddockPropertiesEvent> Parser
	{
		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0xD0A150", Offset = "0xD09550", VA = "0x180D0A150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000628")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0xD0A0A0", Offset = "0xD094A0", VA = "0x180D0A0A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000629")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0xD0A2A0", Offset = "0xD096A0", VA = "0x180D0A2A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700062A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockInformation Properties
	{
		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6001C91")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockPropertiesEvent()
	{
	}

	[Token(Token = "0x6001C92")]
	[Address(RVA = "0x9F6030", Offset = "0x9F5430", VA = "0x1809F6030")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockPropertiesEvent(PaddockPropertiesEvent other)
	{
	}

	[Token(Token = "0x6001C93")]
	[Address(RVA = "0xD09D20", Offset = "0xD09120", VA = "0x180D09D20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockPropertiesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001C96")]
	[Address(RVA = "0xD09DC0", Offset = "0xD091C0", VA = "0x180D09DC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddockPropertiesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001C99")]
	[Address(RVA = "0xD09F40", Offset = "0xD09340", VA = "0x180D09F40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001C9A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001C9B")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001C9C")]
	[Address(RVA = "0xD09C90", Offset = "0xD09090", VA = "0x180D09C90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001C9D")]
	[Address(RVA = "0xD09E70", Offset = "0xD09270", VA = "0x180D09E70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PaddockPropertiesEvent other)
	{
	}

	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0xD0A1A0", Offset = "0xD095A0", VA = "0x180D0A1A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
