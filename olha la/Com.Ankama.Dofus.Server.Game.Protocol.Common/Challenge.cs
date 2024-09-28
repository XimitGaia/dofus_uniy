using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009A2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Challenge : IMessage<Challenge>, IMessage, IEquatable<Challenge>, IDeepCloneable<Challenge>, IBufferMessage
{
	[Token(Token = "0x20009A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x20009A4")]
		public enum ChallengeState
		{
			[Token(Token = "0x40021F2")]
			[OriginalName("CHALLENGE_COMPLETED")]
			ChallengeCompleted,
			[Token(Token = "0x40021F3")]
			[OriginalName("CHALLENGE_FAILED")]
			ChallengeFailed,
			[Token(Token = "0x40021F4")]
			[OriginalName("CHALLENGE_RUNNING")]
			ChallengeRunning
		}
	}

	[Token(Token = "0x40021E4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Challenge> _parser;

	[Token(Token = "0x40021E5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40021E6")]
	public const int ChallengeIdFieldNumber = 1;

	[Token(Token = "0x40021E7")]
	[FieldOffset(Offset = "0x18")]
	private int challengeId_;

	[Token(Token = "0x40021E8")]
	public const int TargetsFieldNumber = 2;

	[Token(Token = "0x40021E9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ChallengeTarget> _repeated_targets_codec;

	[Token(Token = "0x40021EA")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<ChallengeTarget> targets_;

	[Token(Token = "0x40021EB")]
	public const int DropBonusFieldNumber = 3;

	[Token(Token = "0x40021EC")]
	[FieldOffset(Offset = "0x28")]
	private int dropBonus_;

	[Token(Token = "0x40021ED")]
	public const int XpBonusFieldNumber = 4;

	[Token(Token = "0x40021EE")]
	[FieldOffset(Offset = "0x2C")]
	private int xpBonus_;

	[Token(Token = "0x40021EF")]
	public const int StateFieldNumber = 5;

	[Token(Token = "0x40021F0")]
	[FieldOffset(Offset = "0x30")]
	private Types.ChallengeState state_;

	[Token(Token = "0x17001567")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Challenge> Parser
	{
		[Token(Token = "0x6006465")]
		[Address(RVA = "0xB92100", Offset = "0xB91500", VA = "0x180B92100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001568")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006466")]
		[Address(RVA = "0xB92050", Offset = "0xB91450", VA = "0x180B92050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001569")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006467")]
		[Address(RVA = "0xB92410", Offset = "0xB91810", VA = "0x180B92410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700156A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChallengeId
	{
		[Token(Token = "0x600646B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600646C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700156B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChallengeTarget> Targets
	{
		[Token(Token = "0x600646D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700156C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DropBonus
	{
		[Token(Token = "0x600646E")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600646F")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x1700156D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int XpBonus
	{
		[Token(Token = "0x6006470")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006471")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x1700156E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ChallengeState State
	{
		[Token(Token = "0x6006472")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(Types.ChallengeState);
		}
		[Token(Token = "0x6006473")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x6006468")]
	[Address(RVA = "0xB91F20", Offset = "0xB91320", VA = "0x180B91F20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Challenge()
	{
	}

	[Token(Token = "0x6006469")]
	[Address(RVA = "0xB91FA0", Offset = "0xB913A0", VA = "0x180B91FA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Challenge(Challenge other)
	{
	}

	[Token(Token = "0x600646A")]
	[Address(RVA = "0xB91910", Offset = "0xB90D10", VA = "0x180B91910", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Challenge Clone()
	{
		return null;
	}

	[Token(Token = "0x6006474")]
	[Address(RVA = "0xB919E0", Offset = "0xB90DE0", VA = "0x180B919E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006475")]
	[Address(RVA = "0xB91AE0", Offset = "0xB90EE0", VA = "0x180B91AE0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Challenge other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006476")]
	[Address(RVA = "0xB91B90", Offset = "0xB90F90", VA = "0x180B91B90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006477")]
	[Address(RVA = "0xB91D20", Offset = "0xB91120", VA = "0x180B91D20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006478")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006479")]
	[Address(RVA = "0xB922D0", Offset = "0xB916D0", VA = "0x180B922D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600647A")]
	[Address(RVA = "0xB917B0", Offset = "0xB90BB0", VA = "0x180B917B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600647B")]
	[Address(RVA = "0xB91C70", Offset = "0xB91070", VA = "0x180B91C70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Challenge other)
	{
	}

	[Token(Token = "0x600647C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600647D")]
	[Address(RVA = "0xB92150", Offset = "0xB91550", VA = "0x180B92150", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
