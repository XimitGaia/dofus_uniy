using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x200007B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportBuddiesRequestedEvent : IMessage<TeleportBuddiesRequestedEvent>, IMessage, IEquatable<TeleportBuddiesRequestedEvent>, IDeepCloneable<TeleportBuddiesRequestedEvent>, IBufferMessage
{
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportBuddiesRequestedEvent> _parser;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000188")]
	public const int DungeonIdFieldNumber = 1;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x18")]
	private int dungeonId_;

	[Token(Token = "0x400018A")]
	public const int InviterIdFieldNumber = 2;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x20")]
	private long inviterId_;

	[Token(Token = "0x400018C")]
	public const int InvalidBuddiesIdFieldNumber = 3;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_invalidBuddiesId_codec;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<long> invalidBuddiesId_;

	[Token(Token = "0x170000E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TeleportBuddiesRequestedEvent> Parser
	{
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x95EC10", Offset = "0x95E010", VA = "0x18095EC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x95EB60", Offset = "0x95DF60", VA = "0x18095EB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x95EEB0", Offset = "0x95E2B0", VA = "0x18095EEB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DungeonId
	{
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170000E7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long InviterId
	{
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170000E8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> InvalidBuddiesId
	{
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x95EA40", Offset = "0x95DE40", VA = "0x18095EA40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportBuddiesRequestedEvent()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x95EAC0", Offset = "0x95DEC0", VA = "0x18095EAC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportBuddiesRequestedEvent(TeleportBuddiesRequestedEvent other)
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x95E500", Offset = "0x95D900", VA = "0x18095E500", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportBuddiesRequestedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x95E670", Offset = "0x95DA70", VA = "0x18095E670", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x95E5D0", Offset = "0x95D9D0", VA = "0x18095E5D0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TeleportBuddiesRequestedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x95E760", Offset = "0x95DB60", VA = "0x18095E760", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x95E8B0", Offset = "0x95DCB0", VA = "0x18095E8B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x95EDB0", Offset = "0x95E1B0", VA = "0x18095EDB0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x95E3F0", Offset = "0x95D7F0", VA = "0x18095E3F0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x95E810", Offset = "0x95DC10", VA = "0x18095E810", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TeleportBuddiesRequestedEvent other)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x95EC60", Offset = "0x95E060", VA = "0x18095EC60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
