using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000172")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerFightFriendlyAnsweredEvent : IMessage<PlayerFightFriendlyAnsweredEvent>, IMessage, IEquatable<PlayerFightFriendlyAnsweredEvent>, IDeepCloneable<PlayerFightFriendlyAnsweredEvent>, IBufferMessage
{
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayerFightFriendlyAnsweredEvent> _parser;

	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004E4")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40004E6")]
	public const int SourceIdFieldNumber = 2;

	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0x20")]
	private long sourceId_;

	[Token(Token = "0x40004E8")]
	public const int TargetIdFieldNumber = 3;

	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0x28")]
	private long targetId_;

	[Token(Token = "0x40004EA")]
	public const int AcceptFieldNumber = 4;

	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0x30")]
	private bool accept_;

	[Token(Token = "0x17000313")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerFightFriendlyAnsweredEvent> Parser
	{
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0xC47FE0", Offset = "0xC473E0", VA = "0x180C47FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000314")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0xC47F30", Offset = "0xC47330", VA = "0x180C47F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000315")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0xC481F0", Offset = "0xC475F0", VA = "0x180C481F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000316")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FightId
	{
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000317")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long SourceId
	{
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000318")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TargetId
	{
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000319")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Accept
	{
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x9DF090", Offset = "0x9DE490", VA = "0x1809DF090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x9DF8C0", Offset = "0x9DECC0", VA = "0x1809DF8C0")]
		set
		{
		}
	}

	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerFightFriendlyAnsweredEvent()
	{
	}

	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0xC47EC0", Offset = "0xC472C0", VA = "0x180C47EC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerFightFriendlyAnsweredEvent(PlayerFightFriendlyAnsweredEvent other)
	{
	}

	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0xC47A40", Offset = "0xC46E40", VA = "0x180C47A40", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerFightFriendlyAnsweredEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000E75")]
	[Address(RVA = "0xC47AE0", Offset = "0xC46EE0", VA = "0x180C47AE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E76")]
	[Address(RVA = "0xC47B90", Offset = "0xC46F90", VA = "0x180C47B90", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PlayerFightFriendlyAnsweredEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E77")]
	[Address(RVA = "0xC47BE0", Offset = "0xC46FE0", VA = "0x180C47BE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000E78")]
	[Address(RVA = "0xC47D60", Offset = "0xC47160", VA = "0x180C47D60", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0xC48130", Offset = "0xC47530", VA = "0x180C48130", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0xC47950", Offset = "0xC46D50", VA = "0x180C47950", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0xC47CE0", Offset = "0xC470E0", VA = "0x180C47CE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerFightFriendlyAnsweredEvent other)
	{
	}

	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0xC48030", Offset = "0xC47430", VA = "0x180C48030", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
