using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x200007D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportToBuddyOfferEvent : IMessage<TeleportToBuddyOfferEvent>, IMessage, IEquatable<TeleportToBuddyOfferEvent>, IDeepCloneable<TeleportToBuddyOfferEvent>, IBufferMessage
{
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportToBuddyOfferEvent> _parser;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000192")]
	public const int DungeonIdFieldNumber = 1;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x18")]
	private int dungeonId_;

	[Token(Token = "0x4000194")]
	public const int BuddyIdFieldNumber = 2;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x20")]
	private long buddyId_;

	[Token(Token = "0x4000196")]
	public const int TimeLeftFieldNumber = 3;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x28")]
	private int timeLeft_;

	[Token(Token = "0x170000E9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TeleportToBuddyOfferEvent> Parser
	{
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x963BE0", Offset = "0x962FE0", VA = "0x180963BE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000EA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x963B30", Offset = "0x962F30", VA = "0x180963B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x963DA0", Offset = "0x9631A0", VA = "0x180963DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000EC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DungeonId
	{
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170000ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BuddyId
	{
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170000EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TimeLeft
	{
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportToBuddyOfferEvent()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x963AD0", Offset = "0x962ED0", VA = "0x180963AD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportToBuddyOfferEvent(TeleportToBuddyOfferEvent other)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x9636E0", Offset = "0x962AE0", VA = "0x1809636E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportToBuddyOfferEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x963770", Offset = "0x962B70", VA = "0x180963770", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x963810", Offset = "0x962C10", VA = "0x180963810", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TeleportToBuddyOfferEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x963850", Offset = "0x962C50", VA = "0x180963850", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x963970", Offset = "0x962D70", VA = "0x180963970", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x963D00", Offset = "0x963100", VA = "0x180963D00", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x963600", Offset = "0x962A00", VA = "0x180963600", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x963900", Offset = "0x962D00", VA = "0x180963900", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TeleportToBuddyOfferEvent other)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x963C30", Offset = "0x963030", VA = "0x180963C30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
