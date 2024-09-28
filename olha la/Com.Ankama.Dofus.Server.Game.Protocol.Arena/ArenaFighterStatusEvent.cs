using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000B98")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaFighterStatusEvent : IMessage<ArenaFighterStatusEvent>, IMessage, IEquatable<ArenaFighterStatusEvent>, IDeepCloneable<ArenaFighterStatusEvent>, IBufferMessage
{
	[Token(Token = "0x4002B39")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaFighterStatusEvent> _parser;

	[Token(Token = "0x4002B3A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B3B")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x4002B3C")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x4002B3D")]
	public const int CharacterIdFieldNumber = 2;

	[Token(Token = "0x4002B3E")]
	[FieldOffset(Offset = "0x20")]
	private long characterId_;

	[Token(Token = "0x4002B3F")]
	public const int AcceptedFieldNumber = 3;

	[Token(Token = "0x4002B40")]
	[FieldOffset(Offset = "0x28")]
	private bool accepted_;

	[Token(Token = "0x17001AD2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ArenaFighterStatusEvent> Parser
	{
		[Token(Token = "0x60079E0")]
		[Address(RVA = "0xC2FB60", Offset = "0xC2EF60", VA = "0x180C2FB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AD3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60079E1")]
		[Address(RVA = "0xC2FAB0", Offset = "0xC2EEB0", VA = "0x180C2FAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AD4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60079E2")]
		[Address(RVA = "0xC2FD20", Offset = "0xC2F120", VA = "0x180C2FD20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AD5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x60079E6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60079E7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001AD6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x60079E8")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60079E9")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001AD7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accepted
	{
		[Token(Token = "0x60079EA")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60079EB")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x60079E3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaFighterStatusEvent()
	{
	}

	[Token(Token = "0x60079E4")]
	[Address(RVA = "0xC2FA50", Offset = "0xC2EE50", VA = "0x180C2FA50")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaFighterStatusEvent(ArenaFighterStatusEvent other)
	{
	}

	[Token(Token = "0x60079E5")]
	[Address(RVA = "0xC2F630", Offset = "0xC2EA30", VA = "0x180C2F630", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFighterStatusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60079EC")]
	[Address(RVA = "0xC2F6C0", Offset = "0xC2EAC0", VA = "0x180C2F6C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60079ED")]
	[Address(RVA = "0xC2F760", Offset = "0xC2EB60", VA = "0x180C2F760", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaFighterStatusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60079EE")]
	[Address(RVA = "0xC2F7A0", Offset = "0xC2EBA0", VA = "0x180C2F7A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60079EF")]
	[Address(RVA = "0xC2F8F0", Offset = "0xC2ECF0", VA = "0x180C2F8F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60079F0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60079F1")]
	[Address(RVA = "0xC2FC80", Offset = "0xC2F080", VA = "0x180C2FC80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60079F2")]
	[Address(RVA = "0xC2F560", Offset = "0xC2E960", VA = "0x180C2F560", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60079F3")]
	[Address(RVA = "0xC2F880", Offset = "0xC2EC80", VA = "0x180C2F880", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaFighterStatusEvent other)
	{
	}

	[Token(Token = "0x60079F4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60079F5")]
	[Address(RVA = "0xC2FBB0", Offset = "0xC2EFB0", VA = "0x180C2FBB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
