using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000079")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportBuddiesEvent : IMessage<TeleportBuddiesEvent>, IMessage, IEquatable<TeleportBuddiesEvent>, IDeepCloneable<TeleportBuddiesEvent>, IBufferMessage
{
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportBuddiesEvent> _parser;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000183")]
	public const int DungeonIdFieldNumber = 1;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x18")]
	private int dungeonId_;

	[Token(Token = "0x170000DF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TeleportBuddiesEvent> Parser
	{
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x95E2C0", Offset = "0x95D6C0", VA = "0x18095E2C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x95E210", Offset = "0x95D610", VA = "0x18095E210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x95E310", Offset = "0x95D710", VA = "0x18095E310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DungeonId
	{
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportBuddiesEvent()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportBuddiesEvent(TeleportBuddiesEvent other)
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x95DFA0", Offset = "0x95D3A0", VA = "0x18095DFA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportBuddiesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x95E020", Offset = "0x95D420", VA = "0x18095E020", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TeleportBuddiesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x95E0B0", Offset = "0x95D4B0", VA = "0x18095E0B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x95DF10", Offset = "0x95D310", VA = "0x18095DF10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TeleportBuddiesEvent other)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
