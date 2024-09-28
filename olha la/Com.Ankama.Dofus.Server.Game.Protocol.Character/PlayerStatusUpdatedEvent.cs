using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x200086B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerStatusUpdatedEvent : IMessage<PlayerStatusUpdatedEvent>, IMessage, IEquatable<PlayerStatusUpdatedEvent>, IDeepCloneable<PlayerStatusUpdatedEvent>, IBufferMessage
{
	[Token(Token = "0x4001D2B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayerStatusUpdatedEvent> _parser;

	[Token(Token = "0x4001D2C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D2D")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x4001D2E")]
	[FieldOffset(Offset = "0x18")]
	private int accountId_;

	[Token(Token = "0x4001D2F")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4001D30")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x4001D31")]
	public const int StatusFieldNumber = 3;

	[Token(Token = "0x4001D32")]
	[FieldOffset(Offset = "0x28")]
	private CharacterStatus status_;

	[Token(Token = "0x1700130D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerStatusUpdatedEvent> Parser
	{
		[Token(Token = "0x6005979")]
		[Address(RVA = "0xB28700", Offset = "0xB27B00", VA = "0x180B28700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700130E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600597A")]
		[Address(RVA = "0xB28650", Offset = "0xB27A50", VA = "0x180B28650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700130F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600597B")]
		[Address(RVA = "0xB28890", Offset = "0xB27C90", VA = "0x180B28890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001310")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AccountId
	{
		[Token(Token = "0x600597F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005980")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001311")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x6005981")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005982")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001312")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterStatus Status
	{
		[Token(Token = "0x6005983")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005984")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x600597C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerStatusUpdatedEvent()
	{
	}

	[Token(Token = "0x600597D")]
	[Address(RVA = "0xB285D0", Offset = "0xB279D0", VA = "0x180B285D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerStatusUpdatedEvent(PlayerStatusUpdatedEvent other)
	{
	}

	[Token(Token = "0x600597E")]
	[Address(RVA = "0xB28220", Offset = "0xB27620", VA = "0x180B28220", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerStatusUpdatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005985")]
	[Address(RVA = "0xB282D0", Offset = "0xB276D0", VA = "0x180B282D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005986")]
	[Address(RVA = "0xAA4160", Offset = "0xAA3560", VA = "0x180AA4160", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PlayerStatusUpdatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005987")]
	[Address(RVA = "0xAA41E0", Offset = "0xAA35E0", VA = "0x180AA41E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005988")]
	[Address(RVA = "0xB28470", Offset = "0xB27870", VA = "0x180B28470", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005989")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600598A")]
	[Address(RVA = "0xAA48B0", Offset = "0xAA3CB0", VA = "0x180AA48B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600598B")]
	[Address(RVA = "0xB28130", Offset = "0xB27530", VA = "0x180B28130", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600598C")]
	[Address(RVA = "0xB28390", Offset = "0xB27790", VA = "0x180B28390", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerStatusUpdatedEvent other)
	{
	}

	[Token(Token = "0x600598D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600598E")]
	[Address(RVA = "0xB28750", Offset = "0xB27B50", VA = "0x180B28750", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
