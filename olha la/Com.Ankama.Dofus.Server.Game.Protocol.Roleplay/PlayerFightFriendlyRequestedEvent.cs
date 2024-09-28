using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000170")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerFightFriendlyRequestedEvent : IMessage<PlayerFightFriendlyRequestedEvent>, IMessage, IEquatable<PlayerFightFriendlyRequestedEvent>, IDeepCloneable<PlayerFightFriendlyRequestedEvent>, IBufferMessage
{
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayerFightFriendlyRequestedEvent> _parser;

	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004DB")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40004DD")]
	public const int SourceIdFieldNumber = 2;

	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x20")]
	private long sourceId_;

	[Token(Token = "0x40004DF")]
	public const int TargetIdFieldNumber = 3;

	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x28")]
	private long targetId_;

	[Token(Token = "0x1700030D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PlayerFightFriendlyRequestedEvent> Parser
	{
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0xC48700", Offset = "0xC47B00", VA = "0x180C48700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0xC48650", Offset = "0xC47A50", VA = "0x180C48650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700030F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0xC48750", Offset = "0xC47B50", VA = "0x180C48750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000310")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FightId
	{
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000311")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long SourceId
	{
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000312")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TargetId
	{
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerFightFriendlyRequestedEvent()
	{
	}

	[Token(Token = "0x6000E51")]
	[Address(RVA = "0xA97190", Offset = "0xA96590", VA = "0x180A97190")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerFightFriendlyRequestedEvent(PlayerFightFriendlyRequestedEvent other)
	{
	}

	[Token(Token = "0x6000E52")]
	[Address(RVA = "0xC483C0", Offset = "0xC477C0", VA = "0x180C483C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerFightFriendlyRequestedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000E59")]
	[Address(RVA = "0xC48450", Offset = "0xC47850", VA = "0x180C48450", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0xA96E30", Offset = "0xA96230", VA = "0x180A96E30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerFightFriendlyRequestedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0xA96F10", Offset = "0xA96310", VA = "0x180A96F10", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0xC484F0", Offset = "0xC478F0", VA = "0x180C484F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0xC44A90", Offset = "0xC43E90", VA = "0x180C44A90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0xC482D0", Offset = "0xC476D0", VA = "0x180C482D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000E60")]
	[Address(RVA = "0xA96FC0", Offset = "0xA963C0", VA = "0x180A96FC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerFightFriendlyRequestedEvent other)
	{
	}

	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000E62")]
	[Address(RVA = "0xA972F0", Offset = "0xA966F0", VA = "0x180A972F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
