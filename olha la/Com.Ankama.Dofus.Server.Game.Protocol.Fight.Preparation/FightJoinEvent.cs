using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000623")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightJoinEvent : IMessage<FightJoinEvent>, IMessage, IEquatable<FightJoinEvent>, IDeepCloneable<FightJoinEvent>, IBufferMessage
{
	[Token(Token = "0x4001595")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightJoinEvent> _parser;

	[Token(Token = "0x4001596")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001597")]
	public const int IsTeamPhaseFieldNumber = 1;

	[Token(Token = "0x4001598")]
	[FieldOffset(Offset = "0x18")]
	private bool isTeamPhase_;

	[Token(Token = "0x4001599")]
	public const int CanBeCancelledFieldNumber = 2;

	[Token(Token = "0x400159A")]
	[FieldOffset(Offset = "0x19")]
	private bool canBeCancelled_;

	[Token(Token = "0x400159B")]
	public const int CanSayReadyFieldNumber = 3;

	[Token(Token = "0x400159C")]
	[FieldOffset(Offset = "0x1A")]
	private bool canSayReady_;

	[Token(Token = "0x400159D")]
	public const int IsFightStartedFieldNumber = 4;

	[Token(Token = "0x400159E")]
	[FieldOffset(Offset = "0x1B")]
	private bool isFightStarted_;

	[Token(Token = "0x400159F")]
	public const int TimeMaxBeforeFightStartFieldNumber = 5;

	[Token(Token = "0x40015A0")]
	[FieldOffset(Offset = "0x20")]
	private long timeMaxBeforeFightStart_;

	[Token(Token = "0x40015A1")]
	public const int FightTypeFieldNumber = 6;

	[Token(Token = "0x40015A2")]
	[FieldOffset(Offset = "0x28")]
	private FightType fightType_;

	[Token(Token = "0x17000E18")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightJoinEvent> Parser
	{
		[Token(Token = "0x60041A2")]
		[Address(RVA = "0xA7C710", Offset = "0xA7BB10", VA = "0x180A7C710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E19")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60041A3")]
		[Address(RVA = "0xA7C660", Offset = "0xA7BA60", VA = "0x180A7C660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E1A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0xA7C9B0", Offset = "0xA7BDB0", VA = "0x180A7C9B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E1B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTeamPhase
	{
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000E1C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool CanBeCancelled
	{
		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x87EAB0", Offset = "0x87DEB0", VA = "0x18087EAB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041AB")]
		[Address(RVA = "0x87EAF0", Offset = "0x87DEF0", VA = "0x18087EAF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000E1D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool CanSayReady
	{
		[Token(Token = "0x60041AC")]
		[Address(RVA = "0x928A60", Offset = "0x927E60", VA = "0x180928A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041AD")]
		[Address(RVA = "0x928D50", Offset = "0x928150", VA = "0x180928D50")]
		set
		{
		}
	}

	[Token(Token = "0x17000E1E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsFightStarted
	{
		[Token(Token = "0x60041AE")]
		[Address(RVA = "0x928A00", Offset = "0x927E00", VA = "0x180928A00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60041AF")]
		[Address(RVA = "0x928D30", Offset = "0x928130", VA = "0x180928D30")]
		set
		{
		}
	}

	[Token(Token = "0x17000E1F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TimeMaxBeforeFightStart
	{
		[Token(Token = "0x60041B0")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60041B1")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000E20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightType FightType
	{
		[Token(Token = "0x60041B2")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(FightType);
		}
		[Token(Token = "0x60041B3")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x60041A5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinEvent()
	{
	}

	[Token(Token = "0x60041A6")]
	[Address(RVA = "0xA7C5F0", Offset = "0xA7B9F0", VA = "0x180A7C5F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinEvent(FightJoinEvent other)
	{
	}

	[Token(Token = "0x60041A7")]
	[Address(RVA = "0xA7C0D0", Offset = "0xA7B4D0", VA = "0x180A7C0D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightJoinEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60041B4")]
	[Address(RVA = "0xA7C170", Offset = "0xA7B570", VA = "0x180A7C170", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60041B5")]
	[Address(RVA = "0xA7C230", Offset = "0xA7B630", VA = "0x180A7C230", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightJoinEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60041B6")]
	[Address(RVA = "0xA7C290", Offset = "0xA7B690", VA = "0x180A7C290", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60041B7")]
	[Address(RVA = "0xA7C490", Offset = "0xA7B890", VA = "0x180A7C490", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60041B8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60041B9")]
	[Address(RVA = "0xA7C8B0", Offset = "0xA7BCB0", VA = "0x180A7C8B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60041BA")]
	[Address(RVA = "0xA7BFF0", Offset = "0xA7B3F0", VA = "0x180A7BFF0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60041BB")]
	[Address(RVA = "0xA7C400", Offset = "0xA7B800", VA = "0x180A7C400", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightJoinEvent other)
	{
	}

	[Token(Token = "0x60041BC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60041BD")]
	[Address(RVA = "0xA7C760", Offset = "0xA7BB60", VA = "0x180A7C760", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
