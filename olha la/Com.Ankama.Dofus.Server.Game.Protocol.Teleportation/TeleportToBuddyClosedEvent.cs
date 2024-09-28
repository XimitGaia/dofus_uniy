using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x200007F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportToBuddyClosedEvent : IMessage<TeleportToBuddyClosedEvent>, IMessage, IEquatable<TeleportToBuddyClosedEvent>, IDeepCloneable<TeleportToBuddyClosedEvent>, IBufferMessage
{
	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportToBuddyClosedEvent> _parser;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400019B")]
	public const int DungeonIdFieldNumber = 1;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x18")]
	private int dungeonId_;

	[Token(Token = "0x400019D")]
	public const int BuddyIdFieldNumber = 2;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x20")]
	private long buddyId_;

	[Token(Token = "0x170000EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TeleportToBuddyClosedEvent> Parser
	{
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x9634D0", Offset = "0x9628D0", VA = "0x1809634D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x963420", Offset = "0x962820", VA = "0x180963420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x963520", Offset = "0x962920", VA = "0x180963520", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DungeonId
	{
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170000F3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long BuddyId
	{
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportToBuddyClosedEvent()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportToBuddyClosedEvent(TeleportToBuddyClosedEvent other)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x963190", Offset = "0x962590", VA = "0x180963190", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportToBuddyClosedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x963220", Offset = "0x962620", VA = "0x180963220", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TeleportToBuddyClosedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x9632C0", Offset = "0x9626C0", VA = "0x1809632C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x9630D0", Offset = "0x9624D0", VA = "0x1809630D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TeleportToBuddyClosedEvent other)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
