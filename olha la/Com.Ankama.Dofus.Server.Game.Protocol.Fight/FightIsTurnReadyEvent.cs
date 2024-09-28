using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x2000600")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightIsTurnReadyEvent : IMessage<FightIsTurnReadyEvent>, IMessage, IEquatable<FightIsTurnReadyEvent>, IDeepCloneable<FightIsTurnReadyEvent>, IBufferMessage
{
	[Token(Token = "0x400150B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightIsTurnReadyEvent> _parser;

	[Token(Token = "0x400150C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400150D")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x400150E")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x17000DC9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightIsTurnReadyEvent> Parser
	{
		[Token(Token = "0x6004028")]
		[Address(RVA = "0xA3EDE0", Offset = "0xA3E1E0", VA = "0x180A3EDE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DCA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004029")]
		[Address(RVA = "0xA3ED30", Offset = "0xA3E130", VA = "0x180A3ED30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DCB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600402A")]
		[Address(RVA = "0xA3EE30", Offset = "0xA3E230", VA = "0x180A3EE30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DCC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x600402E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600402F")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x600402B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightIsTurnReadyEvent()
	{
	}

	[Token(Token = "0x600402C")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightIsTurnReadyEvent(FightIsTurnReadyEvent other)
	{
	}

	[Token(Token = "0x600402D")]
	[Address(RVA = "0xA3EAC0", Offset = "0xA3DEC0", VA = "0x180A3EAC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightIsTurnReadyEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004030")]
	[Address(RVA = "0xA3EB40", Offset = "0xA3DF40", VA = "0x180A3EB40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004031")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightIsTurnReadyEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004032")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004033")]
	[Address(RVA = "0xA3EBD0", Offset = "0xA3DFD0", VA = "0x180A3EBD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004034")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004035")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004036")]
	[Address(RVA = "0xA3EA30", Offset = "0xA3DE30", VA = "0x180A3EA30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004037")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightIsTurnReadyEvent other)
	{
	}

	[Token(Token = "0x6004038")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004039")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
