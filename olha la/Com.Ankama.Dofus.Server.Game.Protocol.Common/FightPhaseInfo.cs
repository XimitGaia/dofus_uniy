using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A0D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPhaseInfo : IMessage<FightPhaseInfo>, IMessage, IEquatable<FightPhaseInfo>, IDeepCloneable<FightPhaseInfo>, IBufferMessage
{
	[Token(Token = "0x2000A0E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000A0F")]
		public enum FightPhase
		{
			[Token(Token = "0x4002404")]
			[OriginalName("STARTED")]
			Started,
			[Token(Token = "0x4002405")]
			[OriginalName("JOINING_PHASE")]
			JoiningPhase,
			[Token(Token = "0x4002406")]
			[OriginalName("POSITIONING_PHASE")]
			PositioningPhase
		}
	}

	[Token(Token = "0x40023FD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPhaseInfo> _parser;

	[Token(Token = "0x40023FE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40023FF")]
	public const int PhaseFieldNumber = 1;

	[Token(Token = "0x4002400")]
	[FieldOffset(Offset = "0x18")]
	private Types.FightPhase phase_;

	[Token(Token = "0x4002401")]
	public const int PhaseEndTimestampFieldNumber = 2;

	[Token(Token = "0x4002402")]
	[FieldOffset(Offset = "0x20")]
	private long phaseEndTimestamp_;

	[Token(Token = "0x17001697")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightPhaseInfo> Parser
	{
		[Token(Token = "0x60068E6")]
		[Address(RVA = "0xBB7060", Offset = "0xBB6460", VA = "0x180BB7060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001698")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60068E7")]
		[Address(RVA = "0xBB6FB0", Offset = "0xBB63B0", VA = "0x180BB6FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001699")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60068E8")]
		[Address(RVA = "0xBB70B0", Offset = "0xBB64B0", VA = "0x180BB70B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700169A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.FightPhase Phase
	{
		[Token(Token = "0x60068EC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.FightPhase);
		}
		[Token(Token = "0x60068ED")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700169B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PhaseEndTimestamp
	{
		[Token(Token = "0x60068EE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60068EF")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60068E9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPhaseInfo()
	{
	}

	[Token(Token = "0x60068EA")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPhaseInfo(FightPhaseInfo other)
	{
	}

	[Token(Token = "0x60068EB")]
	[Address(RVA = "0xBB6D20", Offset = "0xBB6120", VA = "0x180BB6D20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPhaseInfo Clone()
	{
		return null;
	}

	[Token(Token = "0x60068F0")]
	[Address(RVA = "0xBB6DB0", Offset = "0xBB61B0", VA = "0x180BB6DB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60068F1")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightPhaseInfo other)
	{
		return default(bool);
	}

	[Token(Token = "0x60068F2")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60068F3")]
	[Address(RVA = "0xBB6E50", Offset = "0xBB6250", VA = "0x180BB6E50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60068F4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60068F5")]
	[Address(RVA = "0xA308E0", Offset = "0xA2FCE0", VA = "0x180A308E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60068F6")]
	[Address(RVA = "0xBB6C60", Offset = "0xBB6060", VA = "0x180BB6C60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60068F7")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightPhaseInfo other)
	{
	}

	[Token(Token = "0x60068F8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60068F9")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
