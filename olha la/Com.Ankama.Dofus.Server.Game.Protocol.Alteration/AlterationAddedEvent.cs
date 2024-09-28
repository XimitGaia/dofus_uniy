using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alteration;

[Token(Token = "0x2000C43")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlterationAddedEvent : IMessage<AlterationAddedEvent>, IMessage, IEquatable<AlterationAddedEvent>, IDeepCloneable<AlterationAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4002D7A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AlterationAddedEvent> _parser;

	[Token(Token = "0x4002D7B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D7C")]
	public const int AlterationFieldNumber = 1;

	[Token(Token = "0x4002D7D")]
	[FieldOffset(Offset = "0x18")]
	private Alteration alteration_;

	[Token(Token = "0x17001C53")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AlterationAddedEvent> Parser
	{
		[Token(Token = "0x600810D")]
		[Address(RVA = "0xC7F7D0", Offset = "0xC7EBD0", VA = "0x180C7F7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C54")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600810E")]
		[Address(RVA = "0xC7F720", Offset = "0xC7EB20", VA = "0x180C7F720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C55")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600810F")]
		[Address(RVA = "0xC7F920", Offset = "0xC7ED20", VA = "0x180C7F920", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C56")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Alteration Alteration
	{
		[Token(Token = "0x6008113")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008114")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008110")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlterationAddedEvent()
	{
	}

	[Token(Token = "0x6008111")]
	[Address(RVA = "0xC7F6B0", Offset = "0xC7EAB0", VA = "0x180C7F6B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlterationAddedEvent(AlterationAddedEvent other)
	{
	}

	[Token(Token = "0x6008112")]
	[Address(RVA = "0xC7F330", Offset = "0xC7E730", VA = "0x180C7F330", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlterationAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008115")]
	[Address(RVA = "0xC7F3D0", Offset = "0xC7E7D0", VA = "0x180C7F3D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008116")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlterationAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008117")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008118")]
	[Address(RVA = "0xC7F550", Offset = "0xC7E950", VA = "0x180C7F550", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008119")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600811A")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600811B")]
	[Address(RVA = "0xC7F2A0", Offset = "0xC7E6A0", VA = "0x180C7F2A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600811C")]
	[Address(RVA = "0xC7F480", Offset = "0xC7E880", VA = "0x180C7F480", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AlterationAddedEvent other)
	{
	}

	[Token(Token = "0x600811D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600811E")]
	[Address(RVA = "0xC7F820", Offset = "0xC7EC20", VA = "0x180C7F820", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
