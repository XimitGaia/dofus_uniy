using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x200016C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightRequestCanceledEvent : IMessage<FightRequestCanceledEvent>, IMessage, IEquatable<FightRequestCanceledEvent>, IDeepCloneable<FightRequestCanceledEvent>, IBufferMessage
{
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightRequestCanceledEvent> _parser;

	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004CB")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40004CD")]
	public const int SourceIdFieldNumber = 2;

	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x20")]
	private long sourceId_;

	[Token(Token = "0x40004CF")]
	public const int TargetIdFieldNumber = 3;

	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x28")]
	private long targetId_;

	[Token(Token = "0x17000302")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightRequestCanceledEvent> Parser
	{
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0xC44A40", Offset = "0xC43E40", VA = "0x180C44A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000303")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0xC44990", Offset = "0xC43D90", VA = "0x180C44990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000304")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0xC44B30", Offset = "0xC43F30", VA = "0x180C44B30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000305")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000306")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SourceId
	{
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000307")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetId
	{
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightRequestCanceledEvent()
	{
	}

	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0xA97190", Offset = "0xA96590", VA = "0x180A97190")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightRequestCanceledEvent(FightRequestCanceledEvent other)
	{
	}

	[Token(Token = "0x6000E20")]
	[Address(RVA = "0xC44700", Offset = "0xC43B00", VA = "0x180C44700", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightRequestCanceledEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000E27")]
	[Address(RVA = "0xC44790", Offset = "0xC43B90", VA = "0x180C44790", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E28")]
	[Address(RVA = "0xA96E30", Offset = "0xA96230", VA = "0x180A96E30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightRequestCanceledEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E29")]
	[Address(RVA = "0xA96F10", Offset = "0xA96310", VA = "0x180A96F10", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0xC44830", Offset = "0xC43C30", VA = "0x180C44830", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0xC44A90", Offset = "0xC43E90", VA = "0x180C44A90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0xC44610", Offset = "0xC43A10", VA = "0x180C44610", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0xA96FC0", Offset = "0xA963C0", VA = "0x180A96FC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightRequestCanceledEvent other)
	{
	}

	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000E30")]
	[Address(RVA = "0xA972F0", Offset = "0xA966F0", VA = "0x180A972F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
