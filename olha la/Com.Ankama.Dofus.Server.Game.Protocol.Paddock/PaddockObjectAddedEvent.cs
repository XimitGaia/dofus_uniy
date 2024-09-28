using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002B7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockObjectAddedEvent : IMessage<PaddockObjectAddedEvent>, IMessage, IEquatable<PaddockObjectAddedEvent>, IDeepCloneable<PaddockObjectAddedEvent>, IBufferMessage
{
	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockObjectAddedEvent> _parser;

	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000990")]
	public const int PaddockItemFieldNumber = 1;

	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x18")]
	private ObjectInRolePlay paddockItem_;

	[Token(Token = "0x17000619")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PaddockObjectAddedEvent> Parser
	{
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0xD081E0", Offset = "0xD075E0", VA = "0x180D081E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0xD08130", Offset = "0xD07530", VA = "0x180D08130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0xD08330", Offset = "0xD07730", VA = "0x180D08330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectInRolePlay PaddockItem
	{
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectAddedEvent()
	{
	}

	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0x98D920", Offset = "0x98CD20", VA = "0x18098D920")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectAddedEvent(PaddockObjectAddedEvent other)
	{
	}

	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0xD07DB0", Offset = "0xD071B0", VA = "0x180D07DB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockObjectAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6001C51")]
	[Address(RVA = "0xD07E50", Offset = "0xD07250", VA = "0x180D07E50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PaddockObjectAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C53")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001C54")]
	[Address(RVA = "0xD07FD0", Offset = "0xD073D0", VA = "0x180D07FD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001C55")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001C57")]
	[Address(RVA = "0xD07D20", Offset = "0xD07120", VA = "0x180D07D20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001C58")]
	[Address(RVA = "0xD07F00", Offset = "0xD07300", VA = "0x180D07F00", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PaddockObjectAddedEvent other)
	{
	}

	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0xD08230", Offset = "0xD07630", VA = "0x180D08230", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
