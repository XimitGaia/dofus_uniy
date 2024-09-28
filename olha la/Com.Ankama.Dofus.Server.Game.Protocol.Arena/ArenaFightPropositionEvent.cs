using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000B96")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaFightPropositionEvent : IMessage<ArenaFightPropositionEvent>, IMessage, IEquatable<ArenaFightPropositionEvent>, IDeepCloneable<ArenaFightPropositionEvent>, IBufferMessage
{
	[Token(Token = "0x4002B2F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaFightPropositionEvent> _parser;

	[Token(Token = "0x4002B30")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B31")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x4002B32")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x4002B33")]
	public const int AlliesFieldNumber = 2;

	[Token(Token = "0x4002B34")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_allies_codec;

	[Token(Token = "0x4002B35")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<long> allies_;

	[Token(Token = "0x4002B36")]
	public const int DurationFieldNumber = 3;

	[Token(Token = "0x4002B37")]
	[FieldOffset(Offset = "0x28")]
	private int duration_;

	[Token(Token = "0x17001ACC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaFightPropositionEvent> Parser
	{
		[Token(Token = "0x60079C7")]
		[Address(RVA = "0xC2EDB0", Offset = "0xC2E1B0", VA = "0x180C2EDB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ACD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60079C8")]
		[Address(RVA = "0xC2ED00", Offset = "0xC2E100", VA = "0x180C2ED00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ACE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60079C9")]
		[Address(RVA = "0xC2F040", Offset = "0xC2E440", VA = "0x180C2F040", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ACF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x60079CD")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60079CE")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001AD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> Allies
	{
		[Token(Token = "0x60079CF")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AD1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Duration
	{
		[Token(Token = "0x60079D0")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60079D1")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x60079CA")]
	[Address(RVA = "0xC2EC80", Offset = "0xC2E080", VA = "0x180C2EC80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFightPropositionEvent()
	{
	}

	[Token(Token = "0x60079CB")]
	[Address(RVA = "0xC2EBE0", Offset = "0xC2DFE0", VA = "0x180C2EBE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFightPropositionEvent(ArenaFightPropositionEvent other)
	{
	}

	[Token(Token = "0x60079CC")]
	[Address(RVA = "0xC2E6C0", Offset = "0xC2DAC0", VA = "0x180C2E6C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFightPropositionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60079D2")]
	[Address(RVA = "0xC2E830", Offset = "0xC2DC30", VA = "0x180C2E830", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60079D3")]
	[Address(RVA = "0xC2E790", Offset = "0xC2DB90", VA = "0x180C2E790", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaFightPropositionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60079D4")]
	[Address(RVA = "0xC2E920", Offset = "0xC2DD20", VA = "0x180C2E920", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60079D5")]
	[Address(RVA = "0xC2EA50", Offset = "0xC2DE50", VA = "0x180C2EA50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60079D6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60079D7")]
	[Address(RVA = "0xC2EF50", Offset = "0xC2E350", VA = "0x180C2EF50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60079D8")]
	[Address(RVA = "0xC2E5B0", Offset = "0xC2D9B0", VA = "0x180C2E5B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60079D9")]
	[Address(RVA = "0xC2E9C0", Offset = "0xC2DDC0", VA = "0x180C2E9C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ArenaFightPropositionEvent other)
	{
	}

	[Token(Token = "0x60079DA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60079DB")]
	[Address(RVA = "0xC2EE00", Offset = "0xC2E200", VA = "0x180C2EE00", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
