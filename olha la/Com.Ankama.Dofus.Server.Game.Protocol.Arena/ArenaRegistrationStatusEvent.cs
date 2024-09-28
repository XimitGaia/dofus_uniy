using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000B92")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaRegistrationStatusEvent : IMessage<ArenaRegistrationStatusEvent>, IMessage, IEquatable<ArenaRegistrationStatusEvent>, IDeepCloneable<ArenaRegistrationStatusEvent>, IBufferMessage
{
	[Token(Token = "0x2000B93")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000B94")]
		public enum Step
		{
			[Token(Token = "0x4002B2A")]
			[OriginalName("REGISTERED")]
			Registered,
			[Token(Token = "0x4002B2B")]
			[OriginalName("WAITING_FIGHT")]
			WaitingFight,
			[Token(Token = "0x4002B2C")]
			[OriginalName("STARTING_FIGHT")]
			StartingFight,
			[Token(Token = "0x4002B2D")]
			[OriginalName("UNREGISTERED")]
			Unregistered
		}
	}

	[Token(Token = "0x4002B21")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaRegistrationStatusEvent> _parser;

	[Token(Token = "0x4002B22")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B23")]
	public const int RegisteredFieldNumber = 1;

	[Token(Token = "0x4002B24")]
	[FieldOffset(Offset = "0x18")]
	private bool registered_;

	[Token(Token = "0x4002B25")]
	public const int StepFieldNumber = 2;

	[Token(Token = "0x4002B26")]
	[FieldOffset(Offset = "0x1C")]
	private Types.Step step_;

	[Token(Token = "0x4002B27")]
	public const int BattleModeFieldNumber = 3;

	[Token(Token = "0x4002B28")]
	[FieldOffset(Offset = "0x20")]
	private ArenaType battleMode_;

	[Token(Token = "0x17001AC6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaRegistrationStatusEvent> Parser
	{
		[Token(Token = "0x60079AD")]
		[Address(RVA = "0xC32AC0", Offset = "0xC31EC0", VA = "0x180C32AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60079AE")]
		[Address(RVA = "0xC32A10", Offset = "0xC31E10", VA = "0x180C32A10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60079AF")]
		[Address(RVA = "0xC32BB0", Offset = "0xC31FB0", VA = "0x180C32BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Registered
	{
		[Token(Token = "0x60079B3")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60079B4")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17001ACA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Step Step
	{
		[Token(Token = "0x60079B5")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Types.Step);
		}
		[Token(Token = "0x60079B6")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001ACB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaType BattleMode
	{
		[Token(Token = "0x60079B7")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ArenaType);
		}
		[Token(Token = "0x60079B8")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60079B0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaRegistrationStatusEvent()
	{
	}

	[Token(Token = "0x60079B1")]
	[Address(RVA = "0xA89F20", Offset = "0xA89320", VA = "0x180A89F20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaRegistrationStatusEvent(ArenaRegistrationStatusEvent other)
	{
	}

	[Token(Token = "0x60079B2")]
	[Address(RVA = "0xC326A0", Offset = "0xC31AA0", VA = "0x180C326A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaRegistrationStatusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60079B9")]
	[Address(RVA = "0xC32730", Offset = "0xC31B30", VA = "0x180C32730", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60079BA")]
	[Address(RVA = "0xA89B90", Offset = "0xA88F90", VA = "0x180A89B90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaRegistrationStatusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60079BB")]
	[Address(RVA = "0xC327D0", Offset = "0xC31BD0", VA = "0x180C327D0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60079BC")]
	[Address(RVA = "0xC328B0", Offset = "0xC31CB0", VA = "0x180C328B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60079BD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60079BE")]
	[Address(RVA = "0xC32B10", Offset = "0xC31F10", VA = "0x180C32B10", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60079BF")]
	[Address(RVA = "0xC325E0", Offset = "0xC319E0", VA = "0x180C325E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60079C0")]
	[Address(RVA = "0xA89D50", Offset = "0xA89150", VA = "0x180A89D50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaRegistrationStatusEvent other)
	{
	}

	[Token(Token = "0x60079C1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60079C2")]
	[Address(RVA = "0xA8A080", Offset = "0xA89480", VA = "0x180A8A080", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
