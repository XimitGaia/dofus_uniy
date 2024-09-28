using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005FC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightSlaveNoLongerControlledEvent : IMessage<FightSlaveNoLongerControlledEvent>, IMessage, IEquatable<FightSlaveNoLongerControlledEvent>, IDeepCloneable<FightSlaveNoLongerControlledEvent>, IBufferMessage
{
	[Token(Token = "0x40014FD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightSlaveNoLongerControlledEvent> _parser;

	[Token(Token = "0x40014FE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014FF")]
	public const int MasterIdFieldNumber = 1;

	[Token(Token = "0x4001500")]
	[FieldOffset(Offset = "0x18")]
	private long masterId_;

	[Token(Token = "0x4001501")]
	public const int SlaveIdFieldNumber = 2;

	[Token(Token = "0x4001502")]
	[FieldOffset(Offset = "0x20")]
	private long slaveId_;

	[Token(Token = "0x17000DBF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightSlaveNoLongerControlledEvent> Parser
	{
		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0xA49B90", Offset = "0xA48F90", VA = "0x180A49B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0xA49AE0", Offset = "0xA48EE0", VA = "0x180A49AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DC1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0xA49BE0", Offset = "0xA48FE0", VA = "0x180A49BE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DC2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MasterId
	{
		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003FFF")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000DC3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long SlaveId
	{
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004001")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6003FFB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSlaveNoLongerControlledEvent()
	{
	}

	[Token(Token = "0x6003FFC")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSlaveNoLongerControlledEvent(FightSlaveNoLongerControlledEvent other)
	{
	}

	[Token(Token = "0x6003FFD")]
	[Address(RVA = "0xA49850", Offset = "0xA48C50", VA = "0x180A49850", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightSlaveNoLongerControlledEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004002")]
	[Address(RVA = "0xA498E0", Offset = "0xA48CE0", VA = "0x180A498E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004003")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightSlaveNoLongerControlledEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004004")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004005")]
	[Address(RVA = "0xA49980", Offset = "0xA48D80", VA = "0x180A49980", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004006")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004007")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004008")]
	[Address(RVA = "0xA49790", Offset = "0xA48B90", VA = "0x180A49790", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004009")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightSlaveNoLongerControlledEvent other)
	{
	}

	[Token(Token = "0x600400A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600400B")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
