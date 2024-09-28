using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000176")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonsterNotAngryAtPlayerEvent : IMessage<MonsterNotAngryAtPlayerEvent>, IMessage, IEquatable<MonsterNotAngryAtPlayerEvent>, IDeepCloneable<MonsterNotAngryAtPlayerEvent>, IBufferMessage
{
	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MonsterNotAngryAtPlayerEvent> _parser;

	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004FA")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x40004FC")]
	public const int MonsterGroupIdFieldNumber = 2;

	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x20")]
	private long monsterGroupId_;

	[Token(Token = "0x17000321")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterNotAngryAtPlayerEvent> Parser
	{
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0xC47270", Offset = "0xC46670", VA = "0x180C47270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000322")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0xC471C0", Offset = "0xC465C0", VA = "0x180C471C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000323")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0xC472C0", Offset = "0xC466C0", VA = "0x180C472C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000324")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharacterId
	{
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000325")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MonsterGroupId
	{
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterNotAngryAtPlayerEvent()
	{
	}

	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterNotAngryAtPlayerEvent(MonsterNotAngryAtPlayerEvent other)
	{
	}

	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0xC46F30", Offset = "0xC46330", VA = "0x180C46F30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterNotAngryAtPlayerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0xC46FC0", Offset = "0xC463C0", VA = "0x180C46FC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MonsterNotAngryAtPlayerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0xC47060", Offset = "0xC46460", VA = "0x180C47060", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0xC46E70", Offset = "0xC46270", VA = "0x180C46E70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterNotAngryAtPlayerEvent other)
	{
	}

	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
